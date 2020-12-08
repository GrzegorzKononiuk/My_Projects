using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList
{
    public delegate string GetNumber(int amount);

    public class PassingNumber
    {

        public string MyProperty { get; set; }

        public string NumberOfProduct(int amount)
        {
            return MyProperty = " x " + amount.ToString();

        }



    }
}
