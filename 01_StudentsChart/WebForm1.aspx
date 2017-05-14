<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_01_StudentsChart.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Chart ID="Chart1" runat="server" Width="350px" OnLoad="Chart1_Load" Height="379px">
            <Titles>
                <asp:Title Text="Total marks of students"></asp:Title>
            </Titles>
            <series>
                <asp:Series Name="Series1" ChartArea="ChartArea1">
                    <Points>
                        <asp:DataPoint AxisLabel="Mark" YValues="800" />
                        <asp:DataPoint AxisLabel="Steve" YValues="900" />
                        <asp:DataPoint AxisLabel="John" YValues="700" />
                        <asp:DataPoint AxisLabel="Mary" YValues="900" />
                        <asp:DataPoint AxisLabel="Ben" YValues="600" />
                    </Points>
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Student name"></AxisX>
                    <AxisY Title="Total marks"></AxisY>
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    
    </div>
    </form>
</body>
</html>
