<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TrainingDiary.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:Yellow">
   
    <form id="form1" runat="server">
      <div>
            <asp:gridview runat="server" ID="Gv1" AutoGenerateColumns="true" HeaderStyle-BackColor="Red" BackColor="LightBlue"
            BorderWidth="5" BorderColor="Blue">
            </asp:gridview>
          <asp:Button runat="server" ID="SavePdf" Text="Save To Pdf" OnClick="SavePdf_Click" />

      </div>

        <p>
             <asp:TextBox ID="Value1" MaxLength="3" runat="server"/>  
          <asp:Button runat="server" ID="AddExercise" Text="Add Exercise" OnClick="AddExercise_Click" Height="48px" Width="114px" />
          
          </p>

    </form>
</body>
</html>
