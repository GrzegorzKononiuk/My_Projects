<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TrainingDiary.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TrainigTable</title>
</head>
<body style="background-color:Yellow">
   
    <form id="form1" runat="server">
      <div>
           
            <asp:gridview ID="Gv1" runat="server"
                AutoGenerateEditButton="True" 
                AutoGenerateColumns="true" 
                AllowPaging="true" 
                HeaderStyle-BackColor="Red" 
                BackColor="LightBlue"
                BorderWidth="5" 
                BorderColor="Blue" 
                OnRowEditing="Gv1_RowEditing" 
                OnRowUpdating="Gv1_RowUpdating" 
                OnPageIndexChanging="Gv1_PageIndexChanging" 
                OnRowCancelingEdit="Gv1_RowCancelingEdit">
            
                      
            </asp:gridview>
            
          <!-- Safe & Open PDF Buttons -->
            <asp:Button ID="SavePdf" runat="server"  Text="Save To Pdf" OnClick="SavePdf_Click" />
            <asp:Button ID="OpenPdf" runat="server" Text="Open PDF in Browser" Font-Bold="True" OnClick="OpenPdf_Click" />
          <p>
              <!-- Add Exercise -->
            <asp:Button  ID="AddExercise" runat="server" Text="Add New Line" OnClick="AddExercise_Click" Height="48px" Width="114px" />
           </p>
            
      </div>
     </form>
</body>
</html>