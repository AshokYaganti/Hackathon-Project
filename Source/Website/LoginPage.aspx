<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">

  <form id="form1" runat="server">



    <table style="width: 100%; background-image: url('images/bg1.jpg'); height: 45px;">
        <tr>
            <td class="style3" 
                style="text-align: center; color: #FF0066; font-size: xx-large">
                LOGIN WITH</td>
        </tr>
    </table>

  

    <table style="width: 100%; height: 271px; background-image: url('images/bg1.jpg');">
        <tr>
            <td style="width: 36px; font-size: large; color: #996633;" class="style3">
                <span class="style3"></td>
            <td style="width: 213px; font-size: large; color: #996633;" class="style3">
                Email ID</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="204px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 36px; font-size: large; font-family: 'Times New Roman', Times, serif;" 
                class="style3">
                &nbsp;</td>
            <td style="width: 213px; font-size: large; color: #996633;" class="style3">
                Password</span></td>
            <td>
                <asp:TextBox ID="TextBox2" TextMode="Password" runat="server" Width="204px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 36px; font-size: large; font-family: 'Times New Roman', Times, serif;" 
                class="style3">
                &nbsp;</td>
            <td style="width: 213px" class="style3">
                <a href="Forgot.aspx"><span style="font-size: large">Forgot Password?</span></a><span 
                    style="font-size: large">&nbsp;</span></span></td>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="38px" 
                    ImageUrl="~/images/login.png" Width="147px" onclick="ImageButton1_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 36px">
                &nbsp;</td>
            <td style="width: 213px">
                <asp:ImageButton ID="ImageButton2" runat="server" Height="47px" 
                    ImageUrl="~/images/register.png" Width="205px" 
                    onclick="ImageButton2_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 36px; height: 37px;">
                </td>
            <td style="width: 213px; height: 37px;">
                </td>
            <td style="height: 37px">
                &nbsp;</td>
            <td style="height: 37px">
                </td>
        </tr>
    </table>
    </form>

</asp:Content>

