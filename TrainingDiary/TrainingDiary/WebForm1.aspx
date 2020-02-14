<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TrainingDiary.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:Yellow">
   
    <form id="form1" runat="server">
      <div>
            <!-- Modify Grid -->
            <asp:gridview runat="server" ID="Gv1" AutoGenerateColumns="true" HeaderStyle-BackColor="Red" BackColor="LightBlue"
            BorderWidth="5" BorderColor="Blue" OnRowEditing="gv1_RowEditing" OnRowUpdating="gv1_RowUpdating">
            
                 <Columns>

                    <asp:CommandField ShowEditButton="True"/>
                    
                    <!-- CZY DA SIE POLACZYC TEXTBOX Z WARTOSCIAMI Z FORMULARZAA ( dr["Exercise"] = plan.exercises.ToString();) -->
                    <asp:TemplateField HeaderText="sno" InsertVisible="False" SortExpression="sno">

                            <EditItemTemplate>
                                 <asp:TextBox ID="TextBox2" runat="server" Visible='<%# IsInEditMode %>' Text='<%# Bind("parameters") %>'></asp:TextBox>
                            </EditItemTemplate>
                            
                            <ItemTemplate>

                                <asp:Label ID="Label2" runat="server" Visible='<%# !(bool) IsInEditMode %>' Text='<%# Bind("parameters") %>'></asp:Label>

                                <asp:TextBox ID="TextBox2" runat="server" Visible='<%# IsInEditMode %>' Text='<%# Bind("parameters") %>'></asp:TextBox>

                            </ItemTemplate>
                    </asp:TemplateField>
                
                       
                           
                </Columns>            
            </asp:gridview>
            
          
          
          
          
          <asp:Button runat="server" ID="SavePdf" Text="Save To Pdf" OnClick="SavePdf_Click" />
            <asp:Button ID="OpenPdf" runat="server" Text="Open PDF in Browser" Font-Bold="True" OnClick="OpenPdf_Click" />
          <p>
            <asp:TextBox ID="Value1" MaxLength="3" runat="server"/>  
            <asp:Button runat="server" ID="AddExercise" Text="Add Exercise" OnClick="AddExercise_Click" Height="48px" Width="114px" />
            
          
             
          </p>
            
      </div>
     
          


       

    </form>
</body>
</html>
