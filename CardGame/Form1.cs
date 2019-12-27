using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
      
        Deck passItem = new Deck();
        Random random = new Random();
       
        public Form1()
        {
            InitializeComponent();

            Shuffle();
          
        }
        public void Shuffle()
        {
            for (int i = 1; i < 6; i++)
            {
                Values randomBar = (Values)random.Next(1, Enum.GetNames(typeof(Values)).Length);
                playerDeck.Items.Add(randomBar);
            }

            for (int i = 1; i < 6; i++)
            {
                Values randomBar = (Values)random.Next(1, Enum.GetNames(typeof(Values)).Length);
                enemyDeck.Items.Add(randomBar);
            }
        }

        private void moveToTable_Click(object sender, EventArgs e)
        {
            //PLAYER CARDS
            compare.Items.Add(playerDeck.SelectedItem);
           
            //COMPUTER CARDS
            int randomIndex = random.Next(0, enemyDeck.Items.Count);
            enemyDeck.SelectedIndex = randomIndex;
            compare.Items.Add(enemyDeck.SelectedItem);
            
            CheckAndAddPoint();
        }
        public int CheckAndAddPoint()
        {
            int x = passItem.PaassItem(playerDeck.SelectedItem, enemyDeck.SelectedItem);
            playerDeck.Items.RemoveAt(playerDeck.SelectedIndex);
            if (x == 1)
            {
                int var1 = 1;
                int var2 = 1;
                int.TryParse(textBox1.Text, out var1);
                int sum = var1 + var2;
                textBox1.Text = sum.ToString();
                
                if(sum == 2)
                {
                    MessageBox.Show("YOU WIN !!");
                   
                    
                    string message = "PLAY AGAIN ? ";
                    string title = "Question";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result != DialogResult.Yes)
                    { 
                        this.Close();
                    }
                    else
                    {
                        //RESET FIELDS
                        playerDeck.Items.Clear();
                        enemyDeck.Items.Clear();
                        textBox1.Clear();
                        textBox2.Clear();
                        Shuffle();
                    }

                }
               
               
            }

            if (x == 2)
            {
                enemyDeck.Items.RemoveAt(enemyDeck.SelectedIndex);
                int var1 = 1;
                int var2 = 1;
                int.TryParse(textBox2.Text, out var1);
                int sum = var1 + var2;
                textBox2.Text = sum.ToString();
                if (sum == 2)
                {
                    MessageBox.Show("YOU LOSE !!");


                    string message = "PLAY AGAIN ? ";
                    string title = "Question";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result != DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        //RESET FIELDS
                        playerDeck.Items.Clear();
                        enemyDeck.Items.Clear();
                        textBox1.Clear();
                        textBox2.Clear();
                        Shuffle();
                    }

                }
            }
            compare.Items.Clear();
            return 0;
           
        }
    }
}
