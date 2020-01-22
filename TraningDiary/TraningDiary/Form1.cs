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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
namespace TraningDiary
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            //CreateTable();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
        private void CreateFolder_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(@"c:\TRAINING")) 
            {
                MessageBox.Show("FOLDER TRAINING HAS CREATED IN C:\\TRAINING, CLICK OPEN TO CHECK YOUR TRAINIG");
                Directory.CreateDirectory(@"c:\TRAINING");
               
                
            }
            else
            {
                MessageBox.Show("TRAINING IT'S ALREADY EXIST, CLICK 'SET TRANING' AND OPEN PDF FILE ");
            }
        }

        private void openTraning_Click(object sender, EventArgs e)
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

                    textBox1.Text = ExtractTextFromPdf(name);
                   

                }

                
            }
            
          
        }

        public static string ExtractTextFromPdf(string path)
        {
            
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }
       
        private void savePdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4, 15, 15, 0, 0);
                    try
                    {
                        TrainingPlan plan = new TrainingPlan();
                        
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        
                        doc.Open();
                        PdfPTable table = new PdfPTable(1);

                        table.AddCell(new Paragraph(textBox1.Text = plan.Series.ToString()));

                        doc.Add(table);


                        
                        doc.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                  
                }
               
            }
        }
    }
}
