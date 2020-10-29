using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Utility.SocketClient
{
    public static class SocketClient
    {

        //comment


        public static Socket StartSocketClient(string serverAddress, int port)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(serverAddress), port);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ip);
                return server;
            }
            catch (SocketException e)
            {
                Console.WriteLine("Unable to connect to server." + e);
                return null;
            }
        }


        public static string GenerateJWSSignature(Socket server, string type, string payload, string kid, string requestPath, string appid, string privatekey)
        {
            string dataForSignatureGenerate = type + "::" + payload + "::" + kid + "::" + requestPath + "::" + appid + "::" + privatekey;

            server.Send(Encoding.ASCII.GetBytes(dataForSignatureGenerate));

            byte[] receivedDataForSignatureGenerate = new byte[1024];
            int length = server.Receive(receivedDataForSignatureGenerate);
            string signature = Encoding.ASCII.GetString(receivedDataForSignatureGenerate, 0, length);
            Console.WriteLine(signature);
            server.Close();
            return signature;
        }


        public static bool VerifyJWSSignature(Socket server, string type, string payload, string detachedSignature, string publicKey)
        {
            String dataFroVerifySignature = type + "::" + detachedSignature + "::" + payload + "::" + publicKey;
            server.Send(Encoding.ASCII.GetBytes(dataFroVerifySignature));

            byte[] receivedDataForSignatureVerify = new byte[1024];
            int length = server.Receive(receivedDataForSignatureVerify);
            string isSignatureVerified = Encoding.ASCII.GetString(receivedDataForSignatureVerify, 0, length);
            Console.WriteLine(isSignatureVerified);
            server.Close();
            if (isSignatureVerified == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public static String GenerateJWEContent(Socket server, string type, string payload, string kid, string publicKey)
        {
            string dataForGenerateJWEContent = type + ":" + payload + ":" + kid + ":" + publicKey;

            server.Send(Encoding.ASCII.GetBytes(dataForGenerateJWEContent));

            byte[] receiveddataForGenerateJWEContent = new byte[1024];
            int length = server.Receive(receiveddataForGenerateJWEContent);
            string jweContent = Encoding.ASCII.GetString(receiveddataForGenerateJWEContent, 0, length);
            Console.WriteLine(jweContent);
            server.Close();
            return jweContent;
        }


        public static String ParseJWEContent(Socket server, string type, string jweContent, string privateKey)
        {
            string dataForParseJWEContent = type + ":" + jweContent + ":" + privateKey;
            server.Send(Encoding.ASCII.GetBytes(dataForParseJWEContent));

            byte[] receivedParseJWEContent = new byte[1024];
            int length = server.Receive(receivedParseJWEContent);
            string plainText = Encoding.ASCII.GetString(receivedParseJWEContent, 0, length);
            Console.WriteLine(plainText);
            server.Close();
            return plainText;
        }


        public static String GetCertIDForJWSContent(Socket server, string type, string detachedSignature)
        {
            string dataForGetCertIDForJWSContent = type + ":" + detachedSignature;
            server.Send(Encoding.ASCII.GetBytes(dataForGetCertIDForJWSContent));

            byte[] receivedJWSCertID = new byte[1024];
            int length = server.Receive(receivedJWSCertID);
            string plainText = Encoding.ASCII.GetString(receivedJWSCertID, 0, length);
            Console.WriteLine(plainText);
            server.Close();
            return plainText;
        }


        public static String GetCertIDForJWEContent(Socket server, string type, string jweContent)
        {
            string dataForGetCertIDForJWEContent = type + ":" + jweContent;
            server.Send(Encoding.ASCII.GetBytes(dataForGetCertIDForJWEContent));

            byte[] receivedJWECertID = new byte[1024];
            int length = server.Receive(receivedJWECertID);
            string plainText = Encoding.ASCII.GetString(receivedJWECertID, 0, length);
            Console.WriteLine(plainText);
            server.Close();
            return plainText;
        }

    }
}
