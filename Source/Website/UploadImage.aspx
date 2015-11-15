<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2_User.master" AutoEventWireup="true" CodeFile="UploadImage.aspx.cs" Inherits="UploadImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">




    <form id="form1" runat="server">




    <table style="width: 100%">
        <tr>
            <td class="style3" 
                style="text-align: center; color: #990000; font-size: x-large">
                Upload Images Here</td>
        </tr>
    </table>

    <br />


<table style="width: 100%">
    <tr>
        <td style="width: 120px">
            &nbsp;</td>
        <td class="style3" style="font-size: medium; width: 169px; color: #996633">
            Select Category</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
                
                style="color: #0000FF; font-family: 'Times New Roman', Times, serif; font-size: medium" 
                AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 120px">
            &nbsp;</td>
        <td style="width: 169px; color: #996633; font-size: medium;" class="style3">
            <asp:Label ID="Label1" runat="server" Text="Enter Category" Visible="False"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" 
                style="font-family: 'Times New Roman', Times, serif; color: #0000CC" 
                Visible="False"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 120px">
            &nbsp;</td>
        <td style="width: 169px; font-size: medium; color: #996633;" class="style3">
            Upload Image</td>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" 
                style="color: #003366; font-family: 'Times New Roman', Times, serif" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 120px">
            &nbsp;</td>
        <td style="width: 169px; font-size: medium; color: #996633;" class="style3">
            Tag Image</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" style="color: #0000FF"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 120px">
            &nbsp;</td>
        <td style="width: 169px">
            &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                style="font-family: 'Times New Roman', Times, serif; font-size: medium; color: #990000; font-weight: 700" 
                Text="Upload" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 120px">
            &nbsp;</td>
        <td style="width: 169px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 120px">
            &nbsp;</td>
        <td style="width: 169px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 120px; height: 24px;">
            </td>
        <td style="width: 169px; height: 24px;">
            </td>
        <td style="height: 24px">
            </td>
        <td style="height: 24px">
            </td>
    </tr>
</table>
<br />
    <br />
</form>


</asp:Content>

