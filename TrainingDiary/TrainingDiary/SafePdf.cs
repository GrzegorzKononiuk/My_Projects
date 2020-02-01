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
        TrainingPlan plan = new TrainingPlan();
        public byte[] GeneratePDF()
        {
            FileStream fs = File.Open(@"E:\0001.pdf", FileMode.Create);
            Document doc = new Document(PageSize.A4, 15, 15, 0, 0);
            PdfWriter.GetInstance(doc, fs);
            doc.SetPageSize(PageSize.A4);
            doc.SetMargins(20f, 20f, 20f, 20f);
            doc.Open();
            doc.Add(new Paragraph(plan.exercises.ToString()));

            
            doc.Close();
            return memoryStream.ToArray();
        }
    }
}