using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();

            for (int values = 1; values <= 13; values++)
            {
                cards.Add(new Card((Values)values));
            }
        }
       
        public int PaassItem(object a, object b)
        {
            
            int x = a.GetHashCode();
            int y = b.GetHashCode();

            if (x > y)
            {
                MessageBox.Show("WIN");
                return 1;

            }
            if (x == y)
            {
                MessageBox.Show("DRAW");

            }
            if (x < y)
            {
                MessageBox.Show("LOSE");
                return 2;

            }
            return 0;
        }
       

    }
}
