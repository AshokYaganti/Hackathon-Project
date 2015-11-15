<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Forgot.aspx.cs" Inherits="Forgot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">

<form id="form1" runat="server">


    <table style="width: 100%; height: 45px">
        <tr>
            <td class="style3" 
                style="font-size: xx-large; text-align: center; color: #660033">
                Password Recovery</td>
        </tr>
    </table>

    <br />
<table align="center" style="width: 100%; height: 143px">
   
    <tr>
        <td style="width: 75px; text-align: center">
            &nbsp;</td>
        <td class="col_w250" 
            
            style="color: #996633; font-family: 'Times New Roman', Times, serif; font-size: medium; width: 170px">
            Email ID</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 75px; text-align: center; height: 43px">
        </td>
        <td class="col_w250" style="height: 43px; width: 170px">
        </td>
        <td style="height: 43px">
            <asp:Button ID="Button1" runat="server" BorderStyle="Groove" Height="36px" 
                onclick="Button1_Click" 
                style="font-family: 'Times New Roman', Times, serif; color: #990000; font-size: large" 
                Text="Get Password" Width="155px" />
        </td>
        <td style="height: 43px">
        </td>
    </tr>
</table>
    <br />
<br />
</form>

</asp:Content>

