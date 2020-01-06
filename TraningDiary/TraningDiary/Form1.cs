using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TraningDiary
{
    public partial class Form1 : Form
    {
        TrainingPlan plan = new TrainingPlan();
        public Form1()
        {
            InitializeComponent();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
        private void fbwOpen_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(@"c:\TRAINING")) 
            {
                MessageBox.Show("FOLDER TRAINING HAS CREATED IN C:\\TRAINING");
                Directory.CreateDirectory(@"c:\TRAINING");
            }
            else
            {
                MessageBox.Show("TRAINING IT'S ALREADY EXIST, CLICK 'SET TRANING' AND OPEN TXT FILE ");
            }
            //plan.Generate();
            
            
        }

        private void setTraning_Click(object sender, EventArgs e)
        {
            string name;
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                
                name = openFileDialog1.FileName;
              
                dataGridView1.Text = File.ReadAllText(name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Exercise");
            dt.Columns.Add("Series");

            dt.Rows.Add(Exercises.BenchPress, plan.Series);
            
            
            dataGridView1.DataSource = dt;


        }
    }
}
