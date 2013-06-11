<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="VB" AutoEventWireup="true" CodeBehind="VisualWebPart1UserControl.ascx.vb" Inherits="ProjectsListWebPart.VisualWebPart1UserControl" %>
<SharePoint:ListViewByQuery runat="server" ID="ProjectsListView" />
<br />
<asp:Label ID="Label1" runat="server" Text="Items due by:" />
<SharePoint:DateTimeControl ID="DueDate" AutoPostBack="true" OnDateChanged="OnDate_Changed"
    DateOnly="true" runat="server">
</SharePoint:DateTimeControl>
