using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
namespace TrainingDiary
{
    public class SafePdf
    {
        MemoryStream memoryStream = new MemoryStream();
        PdfPTable table = new PdfPTable(3);
        public byte[] GeneratePDF()
        {
            if (!Directory.Exists(@"c:\TRAINING"))
            {
                //MessageBox.Show("FOLDER TRAINING HAS CREATED IN C:\\TRAINING, CLICK OPEN TO CHECK YOUR TRAINIG");
                Directory.CreateDirectory(@"c:\TRAINING");


            }
            else
            {
                //MessageBox.Show("TRAINING IT'S ALREADY EXIST, CLICK 'SET TRANING' AND OPEN PDF FILE ");
                Console.WriteLine("FOLDER ISTNIEJE !!!!!!"); 
            }
            Document doc = new Document(PageSize.A4, 15, 15, 0, 0);
            doc.SetPageSize(PageSize.A4);
            doc.SetMargins(20f, 20f, 20f, 20f);
            table.WidthPercentage = 100;
            table.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfWriter.GetInstance(doc, memoryStream);
            doc.Open();
            table.SetWidths(new float[] { 20f, 50f, 100f });
            table.HeaderRows = 2;
            doc.Add(table);
            doc.Close();
            return memoryStream.ToArray();
        }
       
    }
}