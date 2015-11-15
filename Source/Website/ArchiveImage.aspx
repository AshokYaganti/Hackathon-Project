<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2_User.master" AutoEventWireup="true" CodeFile="ArchiveImage.aspx.cs" Inherits="ArchiveImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">



    <form id="form1" runat="server">



    <table style="width: 100%">
        <tr>
            <td class="style3" 
                style="font-size: x-large; text-align: center; color: #990000">
                Archive Images Here</td>
        </tr>
    </table>
    <br />
    <table style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
            <td class="style3" style="width: 107px; color: #996633; font-size: medium">
                From Date</td>
            <td style="width: 380px">
                
                
                 <asp:DropDownList ID="DropDownList2" runat="server" Width="130px" 
                    AutoPostBack="True" 
                     onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem Value="0">-- Select Month --</asp:ListItem>
                    <asp:ListItem Value="1">JAN</asp:ListItem>
                    <asp:ListItem Value="2">FEB</asp:ListItem>
                    <asp:ListItem Value="3">MAR</asp:ListItem>
                    <asp:ListItem Value="4">APR</asp:ListItem>
                    <asp:ListItem Value="5">MAY</asp:ListItem>
                    <asp:ListItem Value="6">JUN</asp:ListItem>
                    <asp:ListItem Value="7">JULY</asp:ListItem>
                    <asp:ListItem Value="8">AUG</asp:ListItem>
                    <asp:ListItem Value="9">SEP</asp:ListItem>
                    <asp:ListItem Value="10">OCT</asp:ListItem>
                    <asp:ListItem Value="11">NOV</asp:ListItem>
                    <asp:ListItem Value="12">DEC</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                     Width="70px">
                                     


                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList4" runat="server">
                 <asp:ListItem Value="0">-- Select Year --</asp:ListItem>
                     <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                      <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                     <asp:ListItem>2020</asp:ListItem>
                </asp:DropDownList>
                
                
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style3" style="width: 107px; color: #996633; font-size: medium">
                To Date</td>
            <td style="width: 380px">
                
                  <asp:DropDownList ID="DropDownList1" runat="server" Width="130px" 
                    AutoPostBack="True" 
                     onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="0">-- Select Month --</asp:ListItem>
                    <asp:ListItem Value="1">JAN</asp:ListItem>
                    <asp:ListItem Value="2">FEB</asp:ListItem>
                    <asp:ListItem Value="3">MAR</asp:ListItem>
                    <asp:ListItem Value="4">APR</asp:ListItem>
                    <asp:ListItem Value="5">MAY</asp:ListItem>
                    <asp:ListItem Value="6">JUN</asp:ListItem>
                    <asp:ListItem Value="7">JULY</asp:ListItem>
                    <asp:ListItem Value="8">AUG</asp:ListItem>
                    <asp:ListItem Value="9">SEP</asp:ListItem>
                    <asp:ListItem Value="10">OCT</asp:ListItem>
                    <asp:ListItem Value="11">NOV</asp:ListItem>
                    <asp:ListItem Value="12">DEC</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                     Width="70px">
                                     


                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList6" runat="server">
                 <asp:ListItem Value="0">-- Select Year --</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                      <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                     <asp:ListItem>2020</asp:ListItem>
                </asp:DropDownList>
                
                
                
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 107px">
                &nbsp;</td>
            <td style="width: 380px">
                <asp:Button ID="Button1" runat="server" 
                    style="font-family: 'Times New Roman', Times, serif; font-size: medium; color: #CC3300" 
                    Text="Archive Now" onclick="Button1_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 107px">
                &nbsp;</td>
            <td style="width: 380px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 107px">
                &nbsp;</td>
            <td style="width: 380px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

    <br />

    <br />


    </form>


</asp:Content>

