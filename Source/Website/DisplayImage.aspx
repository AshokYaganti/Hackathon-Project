<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2_User.master" Debug="true" AutoEventWireup="true" CodeFile="DisplayImage.aspx.cs" Inherits="DisplayImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">



    <form id="form1" runat="server">



    <table style="width: 100%">
        <tr>
            <td class="style3" 
                style="font-size: x-large; text-align: center; color: #990000">
                Display/Delete Images</td>
        </tr>
    </table>

    <br />

<table style="width: 100%">
    <tr>
        <td style="width: 76px">
            &nbsp;</td>
        <td class="col_w270" 
            style="width: 122px; font-family: 'Times New Roman', Times, serif; font-size: medium; color: #996633">
            Search By</td>
        <td style="width: 150px">
            <asp:DropDownList ID="DropDownList1" runat="server" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                
                style="color: #0000FF; font-family: 'Times New Roman', Times, serif; font-size: medium" 
                AutoPostBack="True">
                <asp:ListItem Value="0">......Select........</asp:ListItem>
                <asp:ListItem Value="1">Category Name</asp:ListItem>
                <asp:ListItem Value="2">Tag Name</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td style="width: 198px">
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
                style="font-family: 'Times New Roman', Times, serif; color: #0000CC; font-size: medium">
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>

<br />


     <asp:Panel ID="pnlGridView" runat="server" ScrollBars="Auto" Height="350px"> 
    <asp:GridView ID="GridView1"  runat="server" BackColor="#DEBA84" ScrollBars="Vertical"
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    CellSpacing="2" AutoGenerateColumns="False" HorizontalAlign="Center">

     <Columns>
     
        <asp:TemplateField HeaderText="IMAGE ID">
                 <ItemTemplate>
                <asp:Label ID="ID2" runat="server" Text='<%#Eval("imageid")%>'></asp:Label>
               </ItemTemplate>             
         </asp:TemplateField>
       <asp:TemplateField HeaderText="CATEGORY NAME">
             <ItemTemplate>
                <asp:Label ID="ID3" runat="server" Text='<%#Eval("categoryname") %>'></asp:Label>
               </ItemTemplate>                  
        </asp:TemplateField>
     <asp:TemplateField HeaderText="TAG NAME">
                  <ItemTemplate>
                <asp:Label ID="ID4" runat="server" Text='<%#Eval("tagname") %>'></asp:Label>
               </ItemTemplate>             
        </asp:TemplateField>
     <asp:TemplateField HeaderText="PHOTO">
                      <ItemTemplate>
              <%--  <asp:Label ID="ID5" runat="server" Text='<%#Eval("photo") %>'></asp:Label>--%>

              <asp:Image ID="Image1" runat="server" 
                                ImageUrl='<%# "~/Handler.ashx?imageid=" + Eval("imageid")%>' style="width: 150px; height: 100px; margin-left: 0px; margin-right: 0px;"  />   

               </ItemTemplate>         
        </asp:TemplateField>
     <asp:TemplateField HeaderText="DATE" >
                      <ItemTemplate>
                <asp:Label ID="ID6" runat="server" Text='<%#Eval("date") %>'></asp:Label>
               </ItemTemplate>         
        </asp:TemplateField>
    
      <asp:TemplateField HeaderText="DELETE">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkdelete" runat="server" OnClick="lnkdelete_Click" Text="Delete"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
    
    
    </Columns>

        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" HorizontalAlign="Center" 
            VerticalAlign="Middle" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />

    </asp:GridView>
    </asp:Panel>
</form>

</asp:Content>

