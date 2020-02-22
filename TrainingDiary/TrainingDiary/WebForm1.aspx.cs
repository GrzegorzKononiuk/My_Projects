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
        DataTable taskTable = new DataTable("TaskList");
        DataRow tableRow;
        SafePdf safePdf = new SafePdf();

        TrainingPlan plan = new TrainingPlan();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               

                taskTable.Columns.Add("Exercise", typeof(string));

                taskTable.Columns.Add("Series", typeof(string));

                taskTable.Columns.Add("Reps", typeof(string));

                taskTable.Columns.Add("Weight", typeof(string));

                tableRow = taskTable.NewRow();

                tableRow["Exercise"] = plan.exercises.ToString();

                tableRow["Series"] = plan.Series.ToString() + " s";

                tableRow["Reps"] = plan.Reps.ToString() + " rep";

                tableRow["Weight"] = plan.Weight.ToString() + " KG";
                taskTable.Rows.Add(tableRow);

                Session["TaskTable"] = taskTable;

                BindData();
                

            }


        }
        //TABELA W HTML ASP.NET
      

        protected void SavePdf_Click(object sender, EventArgs e)
        {

            try
            {
                taskTable = (DataTable)Session["TaskTable"];

                safePdf.GeneratePDF(taskTable, @"E:\TrainingPlan.pdf", "TrainingPlan");

            }
            catch
            {
            }
        }

        protected void AddExercise_Click(object sender, EventArgs e)
        {
            taskTable = (DataTable)Session["TaskTable"];

            tableRow = taskTable.NewRow();

            //tableRow["Exercise"] = Value1.Text;

            //dr["Series"] = txtb2.Text;

            //dr["Reps"] = txtb3.Text;

            //dr["Weight"] = txtb4.Text;

            taskTable.Rows.Add(tableRow);

            Gv1.DataSource = taskTable;

            Gv1.DataBind();

            //Value1.Text = "";

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

        protected void Gv1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Gv1.PageIndex = e.NewPageIndex;
            //Bind data to the GridView control.
            BindData();
        }

        protected void Gv1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            Gv1.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            BindData();

        }
        protected void Gv1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            Gv1.EditIndex = -1;
            //Bind data to the GridView control.
            BindData();
        }

        protected void Gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Retrieve the table from the session object.
            DataTable dt = (DataTable)Session["TaskTable"];

            //Update the values.
            GridViewRow row = Gv1.Rows[e.RowIndex];
            dt.Rows[row.DataItemIndex]["Exercise"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Series"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Reps"] = ((TextBox)(row.Cells[3].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Weight"] = ((TextBox)(row.Cells[4].Controls[0])).Text;
            

            //Reset the edit index.
            Gv1.EditIndex = -1;

            //Bind data to the GridView control.
            BindData();
        }
        private void BindData()
        {
            Gv1.DataSource = Session["TaskTable"];
            Gv1.DataBind();
        }
    }
}
