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
                MessageBox.Show("FOLDER TRAINING HAS CREATED IN C:\\TRAINING, CLICK OPEN TO CHECK YOUR TRAINIG");
                Directory.CreateDirectory(@"c:\TRAINING");
                CreateTable();
                
            }
            else
            {
                MessageBox.Show("TRAINING IT'S ALREADY EXIST, CLICK 'SET TRANING' AND OPEN TXT FILE ");
            }
          
            
            
        }

        private void setTraning_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"c:\TRAINING"))
            {
                MessageBox.Show("PLEASE CLICK 'CREATE FOLDER FIRST'");
                
            }
            else
            {
                string name;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    name = openFileDialog1.FileName;

                    dataGridView1.Text = File.ReadAllText(name);
                }
            }
            
          
        }

        public void CreateTable()
        {
        //
            //dlaczego table moge zrobic tylko tutaj a nie w klasie ???
            DataTable dt = new DataTable();

            if (Directory.Exists(@"c:\TRAINING"))
            {
                StreamWriter writer = new StreamWriter(@"c:\TRAINING\TRAINING-FBW.txt");

                //writer.WriteLine(@"c:\TRAINING\TRAINING-FBW.txt");

                writer.WriteLine(dt.Columns.Add("Exercise"));
                writer.WriteLine(dt.Columns.Add("Series"));
                dt.Rows.Add(Exercises.BenchPress, plan.Series);




                dataGridView1.DataSource = dt;
                GenerateToFile(dt, writer.ToString());
                writer.Close();
            }
        }

        public static void GenerateToFile(DataTable submittedDataTable, string submittedFilePath)
        {
            int i = 0;
            StreamWriter sw = null;

            sw = new StreamWriter(submittedFilePath, false);

            for (i = 0; i < submittedDataTable.Columns.Count - 1; i++)
            {

                sw.Write(submittedDataTable.Columns[i].ColumnName + ";");

            }
            sw.Write(submittedDataTable.Columns[i].ColumnName);
            sw.WriteLine();

            foreach (DataRow row in submittedDataTable.Rows)
            {
                object[] array = row.ItemArray;

                for (i = 0; i < array.Length - 1; i++)
                {
                    sw.Write(array[i].ToString() + ";");
                }
                sw.Write(array[i].ToString());
                sw.WriteLine();

            }

            sw.Close();
        }
    }
}
