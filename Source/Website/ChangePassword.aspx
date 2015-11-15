<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">

 <form id="form1" runat="server">



    <table style="width: 100%">
        <tr>
            <td class="style3" 
                style="font-size: large; color: #990000; text-align: center">
                CHANGE DEFAULT PASSWORD HERE</td>
        </tr>
    </table>

    <br />

    <table style="width: 100%" align="center">
       
        <tr>
            <td style="width: 64px">
                &nbsp;</td>
            <td class="style3" style="font-size: medium; width: 183px; color: #996633">
                New Password</td>
            <td style="width: 256px">
                <asp:TextBox ID="TextBox3" TextMode="Password" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 64px">
                &nbsp;</td>
            <td class="style3" style="font-size: medium; width: 183px; color: #996633">
                Confirm Password</td>
            <td style="width: 256px">
                <asp:TextBox ID="TextBox4" TextMode="Password" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 64px">
                &nbsp;</td>
            <td style="width: 183px">
                &nbsp;</td>
            <td style="width: 256px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td style="width: 64px">
                &nbsp;</td>
            <td style="width: 183px">
                &nbsp;</td>
            <td style="width: 256px">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    style="font-family: 'Times New Roman', Times, serif; font-size: medium; color: #CC0000" 
                    Text="Change Password" Width="174px" />
             </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br/>
    <br />
    <br />
    <br />
    <br />
    <br />
    </form>

</asp:Content>

