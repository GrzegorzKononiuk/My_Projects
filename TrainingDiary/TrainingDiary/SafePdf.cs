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
        
        public byte[] GeneratePDF(DataTable dtbl, string path, string header)
         {
            FileStream fs = File.Open(path, FileMode.Create,FileAccess.Write, FileShare.None);
            Document doc = new Document(PageSize.A4, 15, 15, 0, 0);
            PdfWriter.GetInstance(doc, fs);
            //doc.SetPageSize(PageSize.A4);
            //doc.SetMargins(20f, 20f, 20f, 20f);
            doc.Open();
            //doc.Add(new Paragraph(plan.exercises.ToString()));

            PdfPTable table = new PdfPTable(dtbl.Columns.Count);

            for (int i = 0; i < dtbl.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.AddElement(new Chunk(dtbl.Columns[i].ColumnName.ToUpper()));
                table.AddCell(cell);
            }

            for (int i = 0; i < dtbl.Rows.Count; i++)
            {
                for (int j = 0; j < dtbl.Columns.Count; j++)
                {
                    table.AddCell(dtbl.Rows[i][j].ToString());
                }
            }

            doc.Add(table);
            doc.Close();
            fs.Close();
            return memoryStream.ToArray();
        }
    }
}