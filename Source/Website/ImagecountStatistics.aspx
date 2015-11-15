<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2_User.master" AutoEventWireup="true" CodeFile="ImagecountStatistics.aspx.cs" Inherits="ImagecountStatistics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">
<br />
<asp:Chart ID="cTestChart" runat="server" Width="598px">
	<Series>
		<asp:Series Name="Testing" YValueType="Int32">

			<Points>
				<asp:DataPoint AxisLabel="13-Nov-2015" YValues="10" />
				<asp:DataPoint AxisLabel="14-Nov-20105" YValues="20" />

				<asp:DataPoint AxisLabel="15-Nov-2015" YValues="28" />
				

			</Points>
		</asp:Series>
	</Series>
	<ChartAreas>
		<asp:ChartArea Name="ChartArea1">
		</asp:ChartArea>

	</ChartAreas>
</asp:Chart>

</asp:Content>

