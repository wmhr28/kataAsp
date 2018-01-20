<%@ Page Language="C#" Inherits="kataAsp.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Print!" OnClick="btnClick" />
        <br><br>
        <asp:Label id="label1" runat="server" Text="Matriz:"/>

         <br><br>
        <asp:Label id="label2" runat="server" Text="Resultado:"/>
	</form>
</body>
</html>
