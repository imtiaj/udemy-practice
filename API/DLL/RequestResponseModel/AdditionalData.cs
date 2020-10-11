using System;
namespace DLL.Models
{
    public class AdditionalData
    {
        //Discount Amount, length: 1-13, Format: AN, M/O/C: M,  Description:
        public string DiscountAmt { get; set; }

        //Discount Note, length: 1-50, Format: ANS, M/O/C: C,  Description:
        public string DiscountNote { get; set; }
    }
}
