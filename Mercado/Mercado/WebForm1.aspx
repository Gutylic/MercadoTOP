<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Mercado.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Visible="false" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Visible="false" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>


        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="pasar a 2" />

        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="pasar a  3" />

        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="890px" Height="58px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" Visible="false" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:TextBox ID="TextBox2" runat="server" Height="370px" TextMode="MultiLine" Width="291px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" Height="42px" Width="344px" />
        <asp:TextBox ID="TextBox5" runat="server" Height="360px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="limpiar" OnClick="Button3_Click" Height="62px" Width="369px" />
        <br />
        <br />
        <br />
        <br />
        col1<asp:TextBox ID="TextBox3" runat="server" Height="40px"></asp:TextBox>
&nbsp;col2
        <asp:TextBox ID="TextBox4" runat="server" Height="40px" Width="170px"></asp:TextBox>
        col3<asp:TextBox ID="TextBox12" runat="server" Height="41px" Width="230px"></asp:TextBox>
&nbsp;col4<asp:TextBox ID="TextBox13" runat="server" Height="39px" Width="166px"></asp:TextBox>
        <br />
        col5<asp:TextBox ID="TextBox14" runat="server" Height="38px"></asp:TextBox>
&nbsp; col6&nbsp;
        <asp:TextBox ID="TextBox15" runat="server" Height="38px" Width="161px"></asp:TextBox>
&nbsp; col7
        <asp:TextBox ID="TextBox16" runat="server" Height="38px" Width="216px"></asp:TextBox>
&nbsp; col8
        <asp:TextBox ID="TextBox17" runat="server" Height="36px" Width="230px"></asp:TextBox>
&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Height="53px" Text="======>" Width="202px" OnClick="Button4_Click" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Text="limpiar" Width="151px" OnClick="Button8_Click" />
        <br />
        <br />
        <br />
        c1 <asp:TextBox ID="TextBox6" runat="server" Height="38px" Width="148px"></asp:TextBox>
&nbsp;&nbsp; c2
        <asp:TextBox ID="TextBox8" runat="server" Height="38px" Width="153px"></asp:TextBox>
&nbsp;&nbsp; c3
        <asp:TextBox ID="TextBox10" runat="server" Height="39px"></asp:TextBox>
&nbsp;<br />
        numero inicial<asp:TextBox ID="TextBox11" runat="server" Height="52px" Width="169px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style1" Height="589px" TextMode="MultiLine" Width="253px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Height="51px" OnClick="Button6_Click" Text="C2 C3" Width="95px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" Height="51px" OnClick="Button7_Click" Text="C3" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Height="51px" OnClick="Button5_Click" Text="C1 C2 C3" Width="178px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox9" runat="server" Height="623px" TextMode="MultiLine" Width="195px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
