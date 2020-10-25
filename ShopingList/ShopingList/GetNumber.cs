using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList
{
    public delegate string GetNumber(int amount);

    public class PassingNumber
    {
       
        private string _myProperty = null;
        public string MyProperty
        {
            get => _myProperty;
            set
            {
                if (value != null)
                {
                    _myProperty = value;
                }
            }
        }

        public string NumberOfProduct(int amount)
        {
            return _myProperty = amount.ToString() + " sztuk";
        }



    }
}
