<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="VB" AutoEventWireup="true" CodeBehind="VisualWebPart1UserControl.ascx.vb" Inherits="ScriptOMandDialog.VisualWebPart1UserControl" %>
<SharePoint:ScriptLink ID="ScriptLink1" runat="server" Name="sp.js" Localizable="false" LoadAfterUI="true" /> 

<script language="ecmascript" type="text/ecmascript">
    /* SharePoint list names */
    var ProjectListName = "Projects";

    /* SharePoint list field names */
    var ProjectNameField = "Title";
    var ProjectDescriptionField = "Description";

    /* List objects */
    var projectsList;

    /* variable to hold list items from the projects list */
    var projects;

    /* client context object - used to access SharePoint data */
    var context;

    /* web (SPWeb) that our page is running on */
    var web;

    /* variable to hold modalDialog to close later */
    var modalDialog;

    /* used when creating a new project ListItem. */
    var projectListItem;

    var copyOfAddProjectForm;

    /* our startup method when the page loads */
    _spBodyOnLoadFunctionNames.push("Initialize()");
    /* Initialize useful variables and retrieve ClientContext */
    function Initialize() {

        /* Retrieves the current ClientContext object */
        context = SP.ClientContext.get_current();
        web = context.get_web();

        // Get references to the lists we will use
        projectsList = web.get_lists().getByTitle(ProjectListName);

        var camlQuery = new SP.CamlQuery();
        camlQuery.set_viewXml('<View><Query/></View>');

        projects = projectsList.getItems(camlQuery);
        context.load(projects, 'Include(Title, Description)');
        context.executeQueryAsync(onListsLoaded, OnError);
    }
    /* Event handler called loading the projects list
    This method dynamically renders an HTML table to display the list data */
    function onListsLoaded() {
        // Get the list items for the contacts list 
        
       
        var projectTable = document.getElementById("tblProjectList");
        // clear out the table so when we add a new project there are not duplicates
        while (projectTable.rows.length > 0)
            projectTable.deleteRow(projectTable.rows.length - 1);
        var content;
        var cell;
        var tbo = document.createElement('tbody');
        // Loop for each project
        var listItemEnumerator = projects.getEnumerator();

        while (listItemEnumerator.moveNext()) {
            // For each project create a row in the table
            var newTR = document.createElement('tr');

            var projectLI = listItemEnumerator.get_current();
            // get_item() retrieves the listitem value 
            var projectName =
                    projectLI.get_item(ProjectNameField);
            var projectDesc =
                    projectLI.get_item(ProjectDescriptionField);
            // add the cells for the row
            cell = document.createElement('td');
            content = document.createTextNode(projectName);
            cell.appendChild(content);
            newTR.appendChild(cell);
            cell = document.createElement('td');
            content = document.createTextNode(projectDesc);
            cell.appendChild(content);
            newTR.appendChild(cell);
            // Add the row to the table body
            tbo.appendChild(newTR);
        }
        // add the table body to the table
        projectTable.appendChild(tbo);
    }
    /* Hide the modal dialog and display the updated UI */
    function onProjectAdded() {
        HideAddProject();
    }

    /* Show a modalDialog with the contents of divAddProject */
    function ShowAddProject() {
        var divAddProject = document.getElementById("divAddProject");

        // showModalDialog removes the element passed in from the DOM
        // so we save a copy and add it back later
        copyOfAddProjectForm = divAddProject.cloneNode(true);

        divAddProject.style.display = "block";
        var options = { html: divAddProject, width: 200, height: 350, dialogReturnValueCallback: ReAddClonedForm };
        modalDialog = SP.UI.ModalDialog.showModalDialog(options);
    }

    /* Close the modalDialog */
    function HideAddProject() {
        modalDialog.close();
        Initialize();
    }

    function ReAddClonedForm() {
        document.body.appendChild(copyOfAddProjectForm);
    }
    /* Called from the Add Project modal dialog 
    Creates a list item in the Project list */
    function AddProject() {
        var lici1 = new SP.ListItemCreationInformation();
        projectListItem = projectsList.addItem(lici1);
        projectListItem.set_item(ProjectNameField, getTBValue("txtProjectName"));
        projectListItem.set_item(ProjectDescriptionField, getTBValue("txtDescription"));
        projectListItem.update();
        context.load(projectListItem);
        // Execute the query to create the project list
        // onProjectAdded is our call back method called when the call to the server has completed
        context.executeQueryAsync(onProjectAdded, OnError);
    }
    /* Error handler */
    function OnError(sender, args) {
        var spnError = document.getElementById("spnError");
        spnError.innerHTML = args.get_message();
    }
    /* Helper function - shortcut to the value property of a textbox */
    function getTBValue(elID) {
        var el = document.getElementById(elID);
        return el.value;
    }

</script>
<div style="font-weight: bold">Project List</div>
<br />
<table id="tblProjectList" style="border: solid 1px silver">
    
</table>
<br />
<a href="javascript:ShowAddProject()">Add a project</a>
<br /> 

<div id="divAddProject" style="display: none; padding: 5px">
   <b>Project Information</b><br /><br />

    Name <br />
    <input type="text" id="txtProjectName" /><br />
    Description<br />
    <input type="text" id="txtDescription" /><br />
    <span id="spnError" style="color: Red" /><br />
    <input type="button" value="Add New Project" onclick="AddProject()" />
</div>
