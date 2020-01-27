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
      </div>

    </form>
</body>
</html>
