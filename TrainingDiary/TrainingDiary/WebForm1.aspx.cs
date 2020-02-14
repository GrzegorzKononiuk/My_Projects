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
        DataRow dr;
        SafePdf safePdf = new SafePdf();
        
        TrainingPlan plan = new TrainingPlan();
       
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
               tb = (DataTable)ViewState["table1"];
               
               safePdf.GeneratePDF(tb, @"E:\TrainingPlan.pdf", "TrainingPlan");
            
            }
            catch
            { 
            }
        }

        protected void AddExercise_Click(object sender, EventArgs e)
        {
            tb = (DataTable)ViewState["table1"];

            dr = tb.NewRow();

            dr["Exercise"] = Value1.Text;

            //dr["Series"] = txtb2.Text;

            //dr["Reps"] = txtb3.Text;

            //dr["Weight"] = txtb4.Text;

            tb.Rows.Add(dr);

            Gv1.DataSource = tb;

            Gv1.DataBind();

            Value1.Text = "";

            //txtb2.Text = "";

            //txtb3.Text = "";

            //txtb4.Text = "";
        }

        protected void OpenPdf_Click(object sender, EventArgs e)
        {
            Response.Clear();
            string filePath = @"E:\TrainingPlan.pdf";
            Response.ContentType = "application/pdf";
            Response.WriteFile(filePath);
            
            Response.End();
        }

        protected void gv1_RowEditing(object sender, GridViewEditEventArgs e)
        {
          
        }

        protected void gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }
       
    }
}
 