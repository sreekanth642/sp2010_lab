<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="VB" AutoEventWireup="true" CodeBehind="SPLinqDemoWebPartUserControl.ascx.vb" Inherits="SPCHOL302_Ex1.SPLinqDemoWebPartUserControl" %>
<asp:DropDownList runat="server" ID="dropDownList" AutoPostBack="true" OnSelectedIndexChanged="ChangeQuery" >
<asp:ListItem Text="Employees" Value="Employees" />
<asp:ListItem Text="Projects" Value="Projects" />
<asp:ListItem Text="Bugs" Value="Bugs" />
</asp:DropDownList>
<SharePoint:SPGridView ID="spGridView" runat="server" AutoGenerateColumns="false">
   <HeaderStyle HorizontalAlign="Left" ForeColor="Navy" Font-Bold="true" />
   <Columns>
    <SharePoint:SPBoundField DataField="Title" HeaderText="Title"></SharePoint:SPBoundField>
    <SharePoint:SPBoundField DataField="JobTitle" HeaderText="JobTitle"></SharePoint:SPBoundField>
    <SharePoint:SPBoundField DataField="ProjectTitle" HeaderText="ProjectTitle"></SharePoint:SPBoundField>
   </Columns>
</SharePoint:SPGridView>