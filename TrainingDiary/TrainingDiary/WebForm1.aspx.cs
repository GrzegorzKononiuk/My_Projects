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
        
        SafePdf safePdf = new SafePdf();
        
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
        //TABELA W HTML ASP.NET
        public DataTable CreateTable()
        {
            DataTable tb = new DataTable();
            DataRow dr;
            tb.Columns.Add("Exercise", typeof(string));

            tb.Columns.Add("Series", typeof(string));

            tb.Columns.Add("Reps", typeof(string));

            tb.Columns.Add("Weight", typeof(string));


            dr = tb.NewRow();

            dr["Exercise"] = plan.exercises.ToString();

            dr["Series"] = plan.Series.ToString() + " s";

            dr["Reps"] = plan.Reps.ToString() + " rep";

            dr["Weight"] = plan.Weight.ToString() + " KG";

            tb.Rows.Add(dr);

            Gv1.DataSource = tb;

            Gv1.DataBind();

            ViewState["table1"] = tb;
            return tb;
        }

        protected void SavePdf_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dtbl = CreateTable();
                safePdf.GeneratePDF(dtbl, @"E:\TrainingPlan.pdf", "TrainingPlan");

            }
            catch
            { 
            }








        }

    }
}
 