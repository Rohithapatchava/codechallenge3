<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Updatestudent.aspx.cs" Inherits="codechallenge3.Updatestudent" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <asp:Label runat="server" Text="Sid"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="updatedate"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button runat="server" Text="Button" OnClick="Unnamed3_Click"></asp:Button>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>

         <div>
             <asp:Label runat="server" Text="fid"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="fdept"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
             <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>

         </div>

         <div>
             <asp:Label runat="server" Text="Cid"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Cname"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
             <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            <asp:GridView ID="GridView3" runat="server"></asp:GridView>

         </div>
        </asp:Content>