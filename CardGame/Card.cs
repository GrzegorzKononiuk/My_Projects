using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Card
    {
        public Values value { get; set; }
        
        public Card(Values value)
        {
           
            this.value = value;
        }
      
        public string Name 
        { 
            get
            {
                string CardName = value + " of ";
             
                
                return CardName;
            }
        }
       

    }
}
