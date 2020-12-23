using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ShopingList
{
    interface ICountItems
    {
        void CreateList(ArrayList x);
        string Get { get; set; }
    }
    public class CountItems : ICountItems
    {

        public string Get { get; set; }
        public void CreateList(ArrayList arrayList)
        {

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            switch (arrayList.Count)
            {
                case 0:
                    Get = "0 (items)";
                    break;
                case 1:
                    Get = "1 (items)";
                    break;
                case 2:
                    Get = "2 (items)";
                    break;
                case 3:
                    Get = "3 (items)";
                    break;
                case 4:
                    Get = "4 (items)";
                    break;
                case 5:
                    Get = "5 (items)";
                    break;
                case 6:
                    Get = "6 (items)";
                    break;
                case 7:
                    Get = "7 (items)";
                    break;
                case 8:
                    Get = "8 (items)";
                    break;
                case 9:
                    Get = "9 (items)";
                    break;
                case 10:
                    Get = "10 (items)";
                    break;
                case 11:
                    Get = "11 (items)";
                    break;
                case 12:
                    Get = "12 (items)";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }


    }
}
