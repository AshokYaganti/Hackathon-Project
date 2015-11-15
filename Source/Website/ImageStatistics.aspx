<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2_User.master" AutoEventWireup="true" CodeFile="ImageStatistics.aspx.cs" Inherits="ImageStatistics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">
    <form id="form1">
    <table style="width: 100%">
        <tr>
            <td class="style3" 
                style="text-align: center; font-size: x-large; color: #990000">
                IMAGE STATISTICS IN PIE CHART</td>
        </tr>
    </table>

    <br />
   
  <asp:Chart ID="Chart1" runat="server" BackColor="0, 0, 64" BackGradientStyle="LeftRight"  
        BorderlineWidth="0" Height="540px" Palette="None" PaletteCustomColors="Maroon"  
        Width="600px" BorderlineColor="64, 0, 64">  
        <Titles>  
            <asp:Title ShadowOffset="10" Name="Items" />  
        </Titles>  
        <Legends>  
            <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default"  
                LegendStyle="Row" />  
        </Legends>  
        <Series>  
            <asp:Series Name="Default" />  
        </Series>  
        <ChartAreas>  
            <asp:ChartArea Name="ChartArea1" BorderWidth="0" />  
        </ChartAreas>  
    </asp:Chart>  
</form>
</asp:Content>

