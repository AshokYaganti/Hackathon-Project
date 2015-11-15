<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">




    <form id="form1" runat="server">




    <table style="width: 100%">
        <tr>
            <td style="text-align: left; font-size: x-large; color: #990000">
                <span class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Register Here</span><br />
            </td>
        </tr>
    </table>
    <br />



    <table align="center" style="width: 100%" height="250">
        <tr>
            <td class="style3" style="height: 33px">
                <span style="font-size: medium">
            </td>
            <td class="col_w270" 
                
                style="width: 115px; font-family: 'Times New Roman', Times, serif; color: #996633; height: 33px; font-size: medium;">
                Email ID</span></td>
            <td class="col_w250" style="width: 190px; height: 33px;">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="style3" 
                    style="color: #0000FF"></asp:TextBox>
            </td>
            <td style="width: 187px; height: 33px;">
                <asp:Button ID="Button1" runat="server" CssClass="style3" 
                    style="color: #996633; font-size: medium;" Text="Register" 
                    onclick="Button1_Click" />
            </td>
            <td class="style3" style="color: #996633; height: 33px;">
                </td>
        </tr>
        <tr>
        <td></td> <td></td> <td></td> <td></td> <td></td>
        
        </tr>
    </table>
    </form>



</asp:Content>

