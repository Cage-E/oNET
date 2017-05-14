<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>
                <tr>
                    <td>
                        <b>Select chart type:</b>
                    </td>
                    <td>

                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" >
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Chart ID="Chart1" runat="server" Width="700px" Height="600px">
                            <Titles>
                                <asp:Title Text="Total marks of students">
                                </asp:Title>
                            </Titles>
                            <Series>
                                <asp:Series Name="Series1" ChartArea="ChartArea1">
                                    <Points>
                                        <asp:DataPoint AxisLabel="Mark" YValues="800" />
                                        <asp:DataPoint AxisLabel="Steve" YValues="900" />
                                        <asp:DataPoint AxisLabel="John" YValues="700" />
                                        <asp:DataPoint AxisLabel="Mary" YValues="900" />
                                        <asp:DataPoint AxisLabel="Ben" YValues="600" />
                                    </Points>
                                </asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1">
                                    <AxisX Title="Student Name">
                                    </AxisX>
                                    <AxisY Title="Total Marks">
                                    </AxisY>
                                </asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                    </td>
                </tr>
            </table>


        </div>
    </form>
</body>
</html>
