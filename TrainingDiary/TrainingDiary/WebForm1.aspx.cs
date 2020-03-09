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
               
                //Create Table, Columns, Rows
                taskTable.Columns.Add("Exercise", typeof(string));

                taskTable.Columns.Add("Series", typeof(string));

                taskTable.Columns.Add("Reps", typeof(string));

                taskTable.Columns.Add("Weight", typeof(string));
                for (int i = 0; i < 5; i++)
                {


                    tableRow = taskTable.NewRow();
                    tableRow["Exercise"] = plan.exercises.ToString();

                    tableRow["Series"] = plan.Series.ToString() + "s";

                    tableRow["Reps"] = plan.Reps.ToString() + "rep";

                    tableRow["Weight"] = plan.Weight.ToString() + "KG";
                    taskTable.Rows.Add(tableRow);

                }
                
                Session["TaskTable"] = taskTable;

                BindData();
                

            }


        }
        //Safe to Txt File
        protected void ExportTextFile(object sender, EventArgs e)
        {
            string txt = string.Empty;

            foreach (GridViewRow row in Gv1.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    
                    txt += cell.Text + " ";
                }

                //Break line, add to new rows
                txt += "\r\n";
            }

            //Download the Text File.
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=TrainingToEdit.txt");
            Response.Charset = "";
            Response.ContentType = "application/text";
            Response.Output.Write(txt);
            Response.Flush();
            Response.End();
        }
        protected void SafeToTxt_Click(object sender, EventArgs e)
        {
            ExportTextFile(sender, e);
        }
        //Safe To Pdf file
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

        protected void OpenPdf_Click(object sender, EventArgs e)
        {
            Response.Clear();
            string filePath = @"E:\TrainingPlan.pdf";
            Response.ContentType = "application/pdf";
            Response.WriteFile(filePath);

            Response.End();
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
            BindData();

            //Value1.Text = "";

            //txtb2.Text = "";

            //txtb3.Text = "";

            //txtb4.Text = "";
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
            dt.Rows[row.DataItemIndex]["Exercise"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Series"] = ((TextBox)(row.Cells[3].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Reps"] = ((TextBox)(row.Cells[4].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Weight"] = ((TextBox)(row.Cells[5].Controls[0])).Text;
            

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

        protected void OpenTxt_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["TaskTable"];
            using (TextReader tr = File.OpenText((@"E:\\TrainingToEdit.txt")))
            {
                
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                  
                    //ROZMIESZCZENIE W DANYCH W ODPOWIEDNICH ROWSW !!
                    string[] items = line.Trim().Split(' ');
                   
                    if (dt.Columns.Count < items.Length)
                    {
                        // Create the data columns for the data table based on the number of items
                        // on the first line of the file
                        for (int i = dt.Columns.Count; i < items.Length; i++)
                            dt.Columns.Add(new DataColumn());
                      
                           
                            
                    }
                    dt.Rows.Add(items);

                }
                
                //show it in gridview 
                BindData();
            }
        }

        protected void Gv1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string item = e.Row.Cells[0].Text;
                foreach (Button button in e.Row.Cells[2].Controls.OfType<Button>())
                {
                    if (button.CommandName == "Delete")
                    {
                        button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + item + "?')){ return false; };";
                    }
                }
            }
        }

        protected void Gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            DataTable dt = Session["TaskTable"] as DataTable;
            dt.Rows[index].Delete();
            ViewState["TaskTable"] = dt;
            BindData();
        }
    }
}
