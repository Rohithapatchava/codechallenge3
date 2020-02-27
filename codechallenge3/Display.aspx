<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="codechallenge3.Display" %>

<asp:Content ID="cont1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Studentdata" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>

    <div>
        <asp:Button ID="Button2" runat="server" Text="Facultydata" OnClick="Button2_Click" />
        <asp:GridView ID="GridView2" runat="server"></asp:GridView>
    </div>

    <div>
        <asp:Button ID="Button3" runat="server" Text="Coursedata" OnClick="Button3_Click" />
        <asp:GridView ID="GridView3" runat="server"></asp:GridView>
    </div>
    </asp:Content>