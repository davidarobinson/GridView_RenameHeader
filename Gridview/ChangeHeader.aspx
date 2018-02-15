<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ChangeHeader.aspx.vb" Inherits="Gridview.ChangeHeader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnChange" runat="server" Text="btnChange" />
            <div id="divTest">
                <asp:GridView ID="lstTest" AutoGenerateColumns="false" runat="server">
                    <Columns>
                        <asp:TemplateField ItemStyle-Width="0" Visible="true">
                            <HeaderTemplate>
                                <asp:Label ID="ColHeader" runat="server"
                                    Text='One'></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="OneID" runat="server"
                                    Text='<%# Eval("OneID")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
