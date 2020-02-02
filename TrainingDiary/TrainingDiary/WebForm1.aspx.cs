using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace TrainingDiary
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable tb = new DataTable();
        //SafePdf safePdf = new SafePdf();
        //DataRow dr;
        TrainingPlan plan = new TrainingPlan();
        PdfPTable table = new PdfPTable(3);

        PdfPCell cell = new PdfPCell(new Phrase("Header spanning 3 columns"));
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CreateTable();
                
            }


        }
        public void CreateTable()
        {
            PdfPTable table = new PdfPTable(9);

            PdfPCell cell = new PdfPCell(new Phrase("Header spanning 3 columns"));

            cell.Colspan = 9;

            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right

            tb.Columns.Add("Exercise", typeof(string));

            tb.Columns.Add("Series", typeof(string));

            tb.Columns.Add("Reps", typeof(string));

            tb.Columns.Add("Weight", typeof(string));
            


            table.AddCell(cell);

            table.AddCell("Col 1 Row 1");

            table.AddCell("Col 2 Row 1");

            table.AddCell("Col 3 Row 1");

            table.AddCell("Col 1 Row 2");

            table.AddCell("Col 2 Row 2");

            table.AddCell("Col 3 Row 2");

            tb.Rows.Add(table);
            Gv1.DataSource = tb;

            Gv1.DataBind();

            ViewState["table1"] = tb;
        }

        protected void SavePdf_Click(object sender, EventArgs e)
        {

            //safePdf.GeneratePDF(dr);









        }

    }
}
 