<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2_User.master" AutoEventWireup="true" CodeFile="DisplayArchiveImage.aspx.cs" Inherits="DisplayArchiveImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">
   
   <form id="form1" runat="server">
    <table style="width: 100%">
        <tr>
            <td class="style3" 
                style="font-size: x-large; text-align: center; color: #990000">
                Display Archived Images</td>
        </tr>
    </table>

    <br/>

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
                                ImageUrl='<%# "~/Handler2.ashx?imageid=" + Eval("imageid")%>' style="width: 150px; height: 100px; margin-left: 0px; margin-right: 0px;"  />   

               </ItemTemplate>         
        </asp:TemplateField>
     <asp:TemplateField HeaderText="DATE" >
                      <ItemTemplate>
                <asp:Label ID="ID6" runat="server" Text='<%#Eval("date") %>'></asp:Label>
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

