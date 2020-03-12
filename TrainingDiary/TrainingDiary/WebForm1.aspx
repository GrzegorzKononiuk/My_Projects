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
                OnRowCancelingEdit="Gv1_RowCancelingEdit" 
                OnRowDataBound="Gv1_RowDataBound" 
                OnRowDeleting="Gv1_RowDeleting"
                >
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                   
                </Columns>

            </asp:gridview>
            
          <!-- Safe , Open PDF & TXT Buttons -->
            <asp:Button ID="SavePdf" runat="server"  Text="Save To Pdf" OnClick="SavePdf_Click" />
            <asp:Button ID="OpenPdf" runat="server" Text="Open PDF in Browser" Font-Bold="True" OnClick="OpenPdf_Click" />
          <p>
              <!-- Add Exercise -->
            <asp:Button ID="SafeToTxt" runat="server" OnClick="SafeToTxt_Click" Text="Save To Txt" />
            <asp:Button ID="OpenTxt" runat="server" OnClick="OpenTxt_Click" Text="Open Txt To Edit" />
           </p>
            
      </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save To HexView.txt" />
        </p>
        <p>
            <asp:Button  ID="AddExercise" runat="server" Text="Add New Line" OnClick="AddExercise_Click" Height="48px" Width="277px" />
           </p>
     </form>
</body>
</html>