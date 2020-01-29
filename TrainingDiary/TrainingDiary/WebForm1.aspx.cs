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
        SafePdf safePdf = new SafePdf();
        DataRow dr;
        TrainingPlan plan = new TrainingPlan();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CreateTable();
            }


        }
        public void CreateTable()
        {



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



            dr = tb.NewRow();

            dr["Exercise"] = "";

            dr["Series"] = "";

            dr["Reps"] = "";

            dr["Weight"] = "";

            tb.Rows.Add(dr);

            Gv1.DataSource = tb;

            Gv1.DataBind();

            ViewState["table1"] = tb;

        }

        protected void SavePdf_Click(object sender, EventArgs e)
        {

            safePdf.GeneratePDF();









        }

    }
}
 