using System;
using System.IO;

namespace Utility.SocketClient
{
    public static class KeyManager
    {
        private static string publicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEApnyhaSEgjJp697c9Ibu5jJB2bi21Pfu6a43qktmWpGTDNMeaqjLj2Gq3AZsnDY1UYHqfnka5X3692eJ5S27tZamvqu3tISlE/jpY+VXYnpE6gaoh+RpV4h5HXJYFl0SU7RSRAbtV0/7Hv1+IcLt3pndY7337cQNuBjtN3qlEKS8nhIzHjzDSLthgS75rmWNK3yj1jHsqCF1Vfrqkzqei9+OzGWAf8KBhR8dYcPLlqN6YDYVm5gu5cmNKYmWhgI2vLn9sQx5GqvMGBt9eXxynpc3THpoKuT80z7rsb3fClHIaCkLiLcqEXnWuQ5yI+O3TiKvS+Itu4B4kw4Jj8lKvuQIDAQAB";
        private static string privateKey = "MIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCmfKFpISCMmnr3tz0hu7mMkHZuLbU9+7prjeqS2ZakZMM0x5qqMuPYarcBmycNjVRgep+eRrlffr3Z4nlLbu1lqa+q7e0hKUT+Olj5VdiekTqBqiH5GlXiHkdclgWXRJTtFJEBu1XT/se/X4hwu3emd1jvfftxA24GO03eqUQpLyeEjMePMNIu2GBLvmuZY0rfKPWMeyoIXVV+uqTOp6L347MZYB/woGFHx1hw8uWo3pgNhWbmC7lyY0piZaGAja8uf2xDHkaq8wYG315fHKelzdMemgq5PzTPuuxvd8KUchoKQuItyoReda5DnIj47dOIq9L4i27gHiTDgmPyUq+5AgMBAAECggEAOHGqm6TijyjUpeVW8XfeuXxE2qfeeaw9kLdlnvHsM8IBuIQvuKJWQwozD3VVsS+IOsl4EkYyFOE4ZoV00BFEpSH5b78IlSSTwolvnuDu9xuPtWRD7ltyYJ4ZXZdzP8y9nP9LBkZIG/6WJBi0flvgfeyal1+j/rXF+JDknqfOdxN6mbcwpae3K17CpQwCHjJ8MviF00boO9OX8cbxMoTpSm3LoaKVrq66Jzjv8Mtd77KBiE3UcBR48m2kZKlGiqRSjlXJ9iMtsvgQloZpn7oqrz07A2XBgwFDjSvhM6b5n0Cbv0DbntXdv5EYtcwXozOARKixyZyNsbb8//kc2oSV/QKBgQD0eFkRyfkhc9fHJ8lGMrqbLKpvKDQNsVZhFBLu2/pazD0h2IT4gfo4w909ZetSI4UpDZGxWwSnqeZDqulPJgoRAzvFrRxGS5dGaMY7yoAdjLxaS/me5OCt5g2pTqct6Dc9eH51UHensthEe4Ft2AiRYy3B8EwCB8FVT3drJLq6pwKBgQCuVrzztnFM/IPu/ZsgGULLrZnJn3qtAlVW3XJjhEB/Ghcz2o17mE6DymFFu+Us9zxoaV8AfhnxEBDUCnrkAvCBwrCJ4ubeq38OVp4juDRPRm4XffHtMpiW/fYk3bvK4S5NkGOlCUXzdIsIb7DcESfEgDP3LI9kwP0dWgx1zlNunwKBgQCT7V64DOba/yXKNKDuATQ5QUXADSuyPWRvSZ5LOoC7AGrdWA7d8IhgYOQ2ir1h7mxc8wD9uH2QlpXmzDxw0Cu3L6Wzb5R0VLksual59IahWs9+NArPwt7RWytZD2bJuIH0iDy87/v3VZjXl4Qx208T6ld9ytGzSM4LuRIhmxACcQKBgFyvbIE9K3s8fH/ggEpOY76ZKruQd83nAavOy3Ow6gEow9Ejjjh5PrS+MXy7ahm/z3PLIWDHqc8JNYklkTQLhAXYlbaY1RjooAHldumSkuzaiskegjISxiDwH55169LuaImADBm/llraSNhRWPuGe1fyuK3eGNX97BNgvmMbMCwNAoGBANwEpyFRJortHNQdjZz9p2WlMrksZ67PPdiZOH0KUkAkD8QxPlVygcxrXbz8wGBspk8VgGb3Z+XB/wMoG/HKZSXsswuztWDJsRC775Yo96mzaKdn4KK+pKtT6eKE28kGZ/tL/YwlhWUcJUPsI70gS/3lKT6fZUDcKj2oWtuDC96D";

        //public static string getPrivateKey()
        //{
        //    return privateKey;
        //}

        //public static string getPublicKey()
        //{
        //    return "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA0IniPD59i4n0wuTG+9CbgwqrzdEGTPk7DCBBC/rk1abCvUisQXBYQVN+vu+dRMNDIHEmMBPJD123hH/cs5bT07FgDdhbrBg4D5x3Som/UfjE+GFI2t0ZwHWQpdqoj8ekK/TTtBT0a8bPBWP1snxf9BxBbHez+kD3TI0WovmRpgLHkB9V1kF02zfU8Jdp5QbwrliIGOhxRZkLjFBfbl3wkHZVSDQ+dmXj0MQROhQMQdicQ/mcYYlu51CNF3DoyPqicokLx/sSpFUXd831iCfZQ306pZCQGnk8FuwpDUwsPc91gNy3khM49mD5pOoYAmwDKU4tQUbcEGKT+g3ly9dQQwIDAQAB";
        //    //var data = File.ReadAllText("PublicKey-20201028145809.pem").Replace("-----BEGIN RSA PUBLIC KEY-----", "").Replace("-----END RSA PUBLIC KEY-----", "");

        //    //return publicKey;
        //}

        public static string getPrivateKey()
        {

            var directory = "/Users/asifnewaz/Project/DotNet/TestUPI/TestUPI/Keys/privatekey.pem";
            bool exists = System.IO.Directory.Exists(directory);

            string contents = File.ReadAllText(@directory);
            var prvtKey = contents.Replace("-----BEGIN RSA PRIVATE KEY-----", "").Replace("-----END RSA PRIVATE KEY-----", "");
            var keyprv = prvtKey.Replace(Environment.NewLine, ""); ;
            Console.WriteLine("Private Key Read from file: " + keyprv);
            return keyprv;
        }

        public static string getPublicKey()
        {
            var directory = "/Users/asifnewaz/Project/DotNet/FromGit/API/Utility/Keys/PublicKey-20201028145809.pem";
            bool exists = System.IO.Directory.Exists(directory);

            string contents = File.ReadAllText(@directory);
            var pubKey = contents.Replace("-----BEGIN RSA PUBLIC KEY-----", "").Replace("-----END RSA PUBLIC KEY-----", "");
            var keypub = pubKey.Replace(Environment.NewLine, ""); ;
            Console.WriteLine("Public Key Read from file: " + keypub);
            return keypub;
        }
    }
}
