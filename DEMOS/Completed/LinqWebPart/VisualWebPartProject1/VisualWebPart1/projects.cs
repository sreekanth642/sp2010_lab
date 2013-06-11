//--------------------------------------------------------------------------------
// This file is a "Sample" from the SharePoint Foundation 2010
// Samples
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
// This source code is intended only as a supplement to Microsoft
// Development Tools and/or on-line documentation.  See these other
// materials for detailed information regarding Microsoft code samples.
// 
// THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//--------------------------------------------------------------------------------

namespace Projects {
	using System;
	
	
	public partial class ProjectsDataContext : Microsoft.SharePoint.Linq.DataContext {
		
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		public ProjectsDataContext(string requestUrl) : 
				base(requestUrl) {
			this.OnCreated();
		}
		
		/// <summary>
		/// Use the Announcements list to post messages on the home page of your site.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Announcements")]
		public Microsoft.SharePoint.Linq.EntityList<Announcement> Announcements {
			get {
				return this.GetList<Announcement>("Announcements");
			}
		}
		
		/// <summary>
		/// Use the Calendar list to keep informed of upcoming meetings, deadlines, and other important events.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Calendar")]
		public Microsoft.SharePoint.Linq.EntityList<CalendarEvent> Calendar {
			get {
				return this.GetList<CalendarEvent>("Calendar");
			}
		}
		
		/// <summary>
		/// Employees
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Employees")]
		public Microsoft.SharePoint.Linq.EntityList<EmployeesItem> Employees {
			get {
				return this.GetList<EmployeesItem>("Employees");
			}
		}
		
		/// <summary>
		/// Use the Links list for links to Web pages that your team members will find interesting or useful.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Links")]
		public Microsoft.SharePoint.Linq.EntityList<Link> Links {
			get {
				return this.GetList<Link>("Links");
			}
		}
		
		/// <summary>
		/// Company Projects
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Projects")]
		public Microsoft.SharePoint.Linq.EntityList<ProjectsItem> Projects {
			get {
				return this.GetList<ProjectsItem>("Projects");
			}
		}
		
		/// <summary>
		/// Share a document with the team by adding it to this document library.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Shared Documents")]
		public Microsoft.SharePoint.Linq.EntityList<Document> SharedDocuments {
			get {
				return this.GetList<Document>("Shared Documents");
			}
		}
		
		/// <summary>
		/// Use this library to store files which are included on pages within this site, such as images on Wiki pages.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Site Assets")]
		public Microsoft.SharePoint.Linq.EntityList<Document> SiteAssets {
			get {
				return this.GetList<Document>("Site Assets");
			}
		}
		
		/// <summary>
		/// Use this library to create and store pages on this site.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Site Pages")]
		public Microsoft.SharePoint.Linq.EntityList<WikiPage> SitePages {
			get {
				return this.GetList<WikiPage>("Site Pages");
			}
		}
		
		/// <summary>
		/// Use the style library to store style sheets, such as CSS or XSL files. The style sheets in this gallery can be used by this site or any of its subsites.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Style Library")]
		public Microsoft.SharePoint.Linq.EntityList<Document> StyleLibrary {
			get {
				return this.GetList<Document>("Style Library");
			}
		}
		
		/// <summary>
		/// Use the Tasks list to keep track of work that you or your team needs to complete.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Tasks")]
		public Microsoft.SharePoint.Linq.EntityList<Item> Tasks {
			get {
				return this.GetList<Item>("Tasks");
			}
		}
		
		/// <summary>
		/// Use the Team Discussion list to hold newsgroup-style discussions on topics relevant to your team.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Team Discussion")]
		public Microsoft.SharePoint.Linq.EntityList<Item> TeamDiscussion {
			get {
				return this.GetList<Item>("Team Discussion");
			}
		}
	}
	
	/// <summary>
	/// Create a new list item.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Item", Id="0x01")]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Announcement))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Folder))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Event))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(EmployeesItem))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Link))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(ProjectsItem))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Document))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Task))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Message))]
	public partial class Item : Microsoft.SharePoint.Linq.ITrackEntityState, Microsoft.SharePoint.Linq.ITrackOriginalValues, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
		
		private System.Nullable<int> _id;
		
		private System.Nullable<int> _version;
		
		private string _path;
		
		private Microsoft.SharePoint.Linq.EntityState _entityState;
		
		private System.Collections.Generic.IDictionary<string, object> _originalValues;
		
		protected string _title;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion

		Microsoft.SharePoint.Linq.EntityState Microsoft.SharePoint.Linq.ITrackEntityState.EntityState {
			get {
				return this._entityState;
			}
			set {
				if ((value != this._entityState)) {
					this._entityState = value;
				}
			}
		}

		System.Collections.Generic.IDictionary<string, object> Microsoft.SharePoint.Linq.ITrackOriginalValues.OriginalValues {
			get {
				if ((null == this._originalValues)) {
					this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
				}
				return this._originalValues;
			}
		}
		
		public Item() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ID", Storage="_id", ReadOnly=true, FieldType="Counter")]
		public System.Nullable<int> Id {
			get {
				return this._id;
			}
			set {
				if ((value != this._id)) {
					this.OnPropertyChanging("Id", this._id);
					this._id = value;
					this.OnPropertyChanged("Id");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="owshiddenversion", Storage="_version", ReadOnly=true, FieldType="Integer")]
		public System.Nullable<int> Version {
			get {
				return this._version;
			}
			set {
				if ((value != this._version)) {
					this.OnPropertyChanging("Version", this._version);
					this._version = value;
					this.OnPropertyChanged("Version");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FileDirRef", Storage="_path", ReadOnly=true, FieldType="Lookup", IsLookupValue=true)]
		public string Path {
			get {
				return this._path;
			}
			set {
				if ((value != this._path)) {
					this.OnPropertyChanging("Path", this._path);
					this._path = value;
					this.OnPropertyChanged("Path");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Title", Storage="_title", Required=true, FieldType="Text")]
		public virtual string Title {
			get {
				return this._title;
			}
			set {
				if ((value != this._title)) {
					this.OnPropertyChanging("Title", this._title);
					this._title = value;
					this.OnPropertyChanged("Title");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		protected virtual void OnPropertyChanged(string propertyName) {
			if ((null != this.PropertyChanged)) {
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		protected virtual void OnPropertyChanging(string propertyName, object value) {
			if ((null == this._originalValues)) {
				this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
			}
			if ((false == this._originalValues.ContainsKey(propertyName))) {
				this._originalValues.Add(propertyName, value);
			}
			if ((null != this.PropertyChanging)) {
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
	}
	
	/// <summary>
	/// Create a new news item, status or other short piece of information.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Announcement", Id="0x0104")]
	public partial class Announcement : Item {
		
		private string _body;
		
		private System.Nullable<System.DateTime> _expires;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Announcement() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Body", Storage="_body", FieldType="Note")]
		public string Body {
			get {
				return this._body;
			}
			set {
				if ((value != this._body)) {
					this.OnPropertyChanging("Body", this._body);
					this._body = value;
					this.OnPropertyChanged("Body");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Expires", Storage="_expires", FieldType="DateTime")]
		public System.Nullable<System.DateTime> Expires {
			get {
				return this._expires;
			}
			set {
				if ((value != this._expires)) {
					this.OnPropertyChanging("Expires", this._expires);
					this._expires = value;
					this.OnPropertyChanged("Expires");
				}
			}
		}
	}
	
	/// <summary>
	/// Create a new folder.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Folder", Id="0x0120")]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(SummaryTask))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Discussion))]
	public partial class Folder : Item {
		
		private string _name;
		
		private System.Nullable<int> _itemChildCountId;
		
		private string _itemChildCountItemChildCount;
		
		private System.Nullable<int> _folderChildCountId;
		
		private string _folderChildCountFolderChildCount;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Folder() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FileLeafRef", Storage="_name", Required=true, FieldType="File")]
		public virtual string Name {
			get {
				return this._name;
			}
			set {
				if ((value != this._name)) {
					this.OnPropertyChanging("Name", this._name);
					this._name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
		public override string Title {
			get {
				throw new System.InvalidOperationException("Field Title was removed from content type Folder.");
			}
			set {
				throw new System.InvalidOperationException("Field Title was removed from content type Folder.");
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ItemChildCount", Storage="_itemChildCountId", ReadOnly=true, FieldType="Lookup", IsLookupId=true)]
		public System.Nullable<int> ItemChildCountId {
			get {
				return this._itemChildCountId;
			}
			set {
				if ((value != this._itemChildCountId)) {
					this.OnPropertyChanging("ItemChildCountId", this._itemChildCountId);
					this._itemChildCountId = value;
					this.OnPropertyChanged("ItemChildCountId");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ItemChildCount", Storage="_itemChildCountItemChildCount", ReadOnly=true, FieldType="Lookup", IsLookupValue=true)]
		public string ItemChildCountItemChildCount {
			get {
				return this._itemChildCountItemChildCount;
			}
			set {
				if ((value != this._itemChildCountItemChildCount)) {
					this.OnPropertyChanging("ItemChildCountItemChildCount", this._itemChildCountItemChildCount);
					this._itemChildCountItemChildCount = value;
					this.OnPropertyChanged("ItemChildCountItemChildCount");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FolderChildCount", Storage="_folderChildCountId", ReadOnly=true, FieldType="Lookup", IsLookupId=true)]
		public System.Nullable<int> FolderChildCountId {
			get {
				return this._folderChildCountId;
			}
			set {
				if ((value != this._folderChildCountId)) {
					this.OnPropertyChanging("FolderChildCountId", this._folderChildCountId);
					this._folderChildCountId = value;
					this.OnPropertyChanged("FolderChildCountId");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FolderChildCount", Storage="_folderChildCountFolderChildCount", ReadOnly=true, FieldType="Lookup", IsLookupValue=true)]
		public string FolderChildCountFolderChildCount {
			get {
				return this._folderChildCountFolderChildCount;
			}
			set {
				if ((value != this._folderChildCountFolderChildCount)) {
					this.OnPropertyChanging("FolderChildCountFolderChildCount", this._folderChildCountFolderChildCount);
					this._folderChildCountFolderChildCount = value;
					this.OnPropertyChanged("FolderChildCountFolderChildCount");
				}
			}
		}
	}
	
	/// <summary>
	/// Create a new meeting, deadline or other event.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Event", Id="0x0102")]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(CalendarEvent))]
	public partial class Event : Item {
		
		private string _location;
		
		protected System.Nullable<System.DateTime> _startTime;
		
		private System.Nullable<System.DateTime> _endTime;
		
		protected string _description;
		
		private System.Nullable<bool> _allDayEvent;
		
		private System.Nullable<bool> _recurrence;
		
		private System.Nullable<bool> _workspace;
		
		private System.Nullable<Category> _category;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Event() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Location", Storage="_location", FieldType="Text")]
		public string Location {
			get {
				return this._location;
			}
			set {
				if ((value != this._location)) {
					this.OnPropertyChanging("Location", this._location);
					this._location = value;
					this.OnPropertyChanged("Location");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="StartDate", Storage="_startTime", Required=true, FieldType="DateTime")]
		public virtual System.Nullable<System.DateTime> StartTime {
			get {
				return this._startTime;
			}
			set {
				if ((value != this._startTime)) {
					this.OnPropertyChanging("StartTime", this._startTime);
					this._startTime = value;
					this.OnPropertyChanged("StartTime");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="EndDate", Storage="_endTime", Required=true, FieldType="DateTime")]
		public System.Nullable<System.DateTime> EndTime {
			get {
				return this._endTime;
			}
			set {
				if ((value != this._endTime)) {
					this.OnPropertyChanging("EndTime", this._endTime);
					this._endTime = value;
					this.OnPropertyChanged("EndTime");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Comments", Storage="_description", FieldType="Note")]
		public virtual string Description {
			get {
				return this._description;
			}
			set {
				if ((value != this._description)) {
					this.OnPropertyChanging("Description", this._description);
					this._description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="fAllDayEvent", Storage="_allDayEvent", FieldType="AllDayEvent")]
		public System.Nullable<bool> AllDayEvent {
			get {
				return this._allDayEvent;
			}
			set {
				if ((value != this._allDayEvent)) {
					this.OnPropertyChanging("AllDayEvent", this._allDayEvent);
					this._allDayEvent = value;
					this.OnPropertyChanged("AllDayEvent");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="fRecurrence", Storage="_recurrence", FieldType="Recurrence")]
		public System.Nullable<bool> Recurrence {
			get {
				return this._recurrence;
			}
			set {
				if ((value != this._recurrence)) {
					this.OnPropertyChanging("Recurrence", this._recurrence);
					this._recurrence = value;
					this.OnPropertyChanged("Recurrence");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WorkspaceLink", Storage="_workspace", FieldType="CrossProjectLink")]
		public System.Nullable<bool> Workspace {
			get {
				return this._workspace;
			}
			set {
				if ((value != this._workspace)) {
					this.OnPropertyChanging("Workspace", this._workspace);
					this._workspace = value;
					this.OnPropertyChanged("Workspace");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Category", Storage="_category", FieldType="Choice")]
		public System.Nullable<Category> Category {
			get {
				return this._category;
			}
			set {
				if ((value != this._category)) {
					this.OnPropertyChanging("Category", this._category);
					this._category = value;
					this.OnPropertyChanged("Category");
				}
			}
		}
	}
	
	/// <summary>
	/// Create a new link to a Web page or other resource.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Link", Id="0x0105")]
	public partial class Link : Item {
		
		private string _uRL;
		
		private string _comments;
		
		private string _uRL0;
		
		private string _uRL1;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Link() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="URL", Storage="_uRL", Required=true, FieldType="Url")]
		public string URL {
			get {
				return this._uRL;
			}
			set {
				if ((value != this._uRL)) {
					this.OnPropertyChanging("URL", this._uRL);
					this._uRL = value;
					this.OnPropertyChanged("URL");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Comments", Storage="_comments", FieldType="Note")]
		public string Comments {
			get {
				return this._comments;
			}
			set {
				if ((value != this._comments)) {
					this.OnPropertyChanging("Comments", this._comments);
					this._comments = value;
					this.OnPropertyChanged("Comments");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="URLwMenu", Storage="_uRL0", ReadOnly=true, FieldType="Computed")]
		public string URL0 {
			get {
				return this._uRL0;
			}
			set {
				if ((value != this._uRL0)) {
					this.OnPropertyChanging("URL0", this._uRL0);
					this._uRL0 = value;
					this.OnPropertyChanged("URL0");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="URLNoMenu", Storage="_uRL1", ReadOnly=true, FieldType="Computed")]
		public string URL1 {
			get {
				return this._uRL1;
			}
			set {
				if ((value != this._uRL1)) {
					this.OnPropertyChanging("URL1", this._uRL1);
					this._uRL1 = value;
					this.OnPropertyChanged("URL1");
				}
			}
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
		public override string Title {
			get {
				throw new System.InvalidOperationException("Field Title was removed from content type Link.");
			}
			set {
				throw new System.InvalidOperationException("Field Title was removed from content type Link.");
			}
		}
	}
	
	/// <summary>
	/// Create a new document.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Document", Id="0x0101")]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(WikiPage))]
	public partial class Document : Item {
		
		private string _name;
		
		private string _documentModifiedBy;
		
		private string _documentCreatedBy;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Document() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FileLeafRef", Storage="_name", Required=true, FieldType="File")]
		public string Name {
			get {
				return this._name;
			}
			set {
				if ((value != this._name)) {
					this.OnPropertyChanging("Name", this._name);
					this._name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Modified_x0020_By", Storage="_documentModifiedBy", ReadOnly=true, FieldType="Text")]
		public string DocumentModifiedBy {
			get {
				return this._documentModifiedBy;
			}
			set {
				if ((value != this._documentModifiedBy)) {
					this.OnPropertyChanging("DocumentModifiedBy", this._documentModifiedBy);
					this._documentModifiedBy = value;
					this.OnPropertyChanged("DocumentModifiedBy");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Created_x0020_By", Storage="_documentCreatedBy", ReadOnly=true, FieldType="Text")]
		public string DocumentCreatedBy {
			get {
				return this._documentCreatedBy;
			}
			set {
				if ((value != this._documentCreatedBy)) {
					this.OnPropertyChanging("DocumentCreatedBy", this._documentCreatedBy);
					this._documentCreatedBy = value;
					this.OnPropertyChanged("DocumentCreatedBy");
				}
			}
		}
	}
	
	/// <summary>
	/// Track a work item that you or your team needs to complete.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Task", Id="0x0108")]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(TasksTask))]
	public partial class Task : Item {
		
		private System.Nullable<double> _complete;
		
		private string _body;
		
		private System.Nullable<System.DateTime> _startDate;
		
		protected System.Nullable<System.DateTime> _dueDate;
		
		private System.Nullable<Priority> _priority;
		
		protected System.Nullable<TaskStatus> _taskStatus;
		
		private System.Nullable<int> _assignedToId;
		
		private string _assignedTo;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Task() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="PercentComplete", Storage="_complete", FieldType="Number")]
		public System.Nullable<double> Complete {
			get {
				return this._complete;
			}
			set {
				if ((value != this._complete)) {
					this.OnPropertyChanging("Complete", this._complete);
					this._complete = value;
					this.OnPropertyChanged("Complete");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Body", Storage="_body", FieldType="Note")]
		public string Body {
			get {
				return this._body;
			}
			set {
				if ((value != this._body)) {
					this.OnPropertyChanging("Body", this._body);
					this._body = value;
					this.OnPropertyChanged("Body");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="StartDate", Storage="_startDate", FieldType="DateTime")]
		public System.Nullable<System.DateTime> StartDate {
			get {
				return this._startDate;
			}
			set {
				if ((value != this._startDate)) {
					this.OnPropertyChanging("StartDate", this._startDate);
					this._startDate = value;
					this.OnPropertyChanged("StartDate");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="TaskDueDate", Storage="_dueDate", FieldType="DateTime")]
		public virtual System.Nullable<System.DateTime> DueDate {
			get {
				return this._dueDate;
			}
			set {
				if ((value != this._dueDate)) {
					this.OnPropertyChanging("DueDate", this._dueDate);
					this._dueDate = value;
					this.OnPropertyChanged("DueDate");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Priority", Storage="_priority", FieldType="Choice")]
		public System.Nullable<Priority> Priority {
			get {
				return this._priority;
			}
			set {
				if ((value != this._priority)) {
					this.OnPropertyChanging("Priority", this._priority);
					this._priority = value;
					this.OnPropertyChanged("Priority");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="TaskStatus", Storage="_taskStatus", FieldType="Choice")]
		public virtual System.Nullable<TaskStatus> TaskStatus {
			get {
				return this._taskStatus;
			}
			set {
				if ((value != this._taskStatus)) {
					this.OnPropertyChanging("TaskStatus", this._taskStatus);
					this._taskStatus = value;
					this.OnPropertyChanged("TaskStatus");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="AssignedTo", Storage="_assignedToId", FieldType="User", IsLookupId=true)]
		public System.Nullable<int> AssignedToId {
			get {
				return this._assignedToId;
			}
			set {
				if ((value != this._assignedToId)) {
					this.OnPropertyChanging("AssignedToId", this._assignedToId);
					this._assignedToId = value;
					this.OnPropertyChanged("AssignedToId");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="AssignedTo", Storage="_assignedTo", ReadOnly=true, FieldType="User", IsLookupValue=true)]
		public string AssignedTo {
			get {
				return this._assignedTo;
			}
			set {
				if ((value != this._assignedTo)) {
					this.OnPropertyChanging("AssignedTo", this._assignedTo);
					this._assignedTo = value;
					this.OnPropertyChanged("AssignedTo");
				}
			}
		}
	}
	
	/// <summary>
	/// Create a new message.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Message", Id="0x0107")]
	public partial class Message : Item {
		
		private string _discussionSubject;
		
		private string _version0;
		
		private string _body;
		
		private string _reply;
		
		private string _post;
		
		private string _threading;
		
		private string _postedBy;
		
		private string _eMailSender;
		
		private System.Nullable<int> _modifiedById;
		
		private string _modifiedByNameWithPicture;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Message() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="DiscussionTitle", Storage="_discussionSubject", ReadOnly=true, FieldType="Computed")]
		public string DiscussionSubject {
			get {
				return this._discussionSubject;
			}
			set {
				if ((value != this._discussionSubject)) {
					this.OnPropertyChanging("DiscussionSubject", this._discussionSubject);
					this._discussionSubject = value;
					this.OnPropertyChanged("DiscussionSubject");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="_UIVersionString", Storage="_version0", ReadOnly=true, FieldType="Text")]
		public string Version0 {
			get {
				return this._version0;
			}
			set {
				if ((value != this._version0)) {
					this.OnPropertyChanging("Version0", this._version0);
					this._version0 = value;
					this.OnPropertyChanged("Version0");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Body", Storage="_body", FieldType="Note")]
		public string Body {
			get {
				return this._body;
			}
			set {
				if ((value != this._body)) {
					this.OnPropertyChanging("Body", this._body);
					this._body = value;
					this.OnPropertyChanged("Body");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ReplyNoGif", Storage="_reply", ReadOnly=true, FieldType="Computed")]
		public string Reply {
			get {
				return this._reply;
			}
			set {
				if ((value != this._reply)) {
					this.OnPropertyChanging("Reply", this._reply);
					this._reply = value;
					this.OnPropertyChanged("Reply");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="BodyAndMore", Storage="_post", ReadOnly=true, FieldType="Computed")]
		public string Post {
			get {
				return this._post;
			}
			set {
				if ((value != this._post)) {
					this.OnPropertyChanging("Post", this._post);
					this._post = value;
					this.OnPropertyChanged("Post");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Threading", Storage="_threading", ReadOnly=true, FieldType="Computed")]
		public string Threading {
			get {
				return this._threading;
			}
			set {
				if ((value != this._threading)) {
					this.OnPropertyChanging("Threading", this._threading);
					this._threading = value;
					this.OnPropertyChanged("Threading");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="PersonViewMinimal", Storage="_postedBy", ReadOnly=true, FieldType="Computed")]
		public string PostedBy {
			get {
				return this._postedBy;
			}
			set {
				if ((value != this._postedBy)) {
					this.OnPropertyChanging("PostedBy", this._postedBy);
					this._postedBy = value;
					this.OnPropertyChanged("PostedBy");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="EmailSender", Storage="_eMailSender", FieldType="Note")]
		public string EMailSender {
			get {
				return this._eMailSender;
			}
			set {
				if ((value != this._eMailSender)) {
					this.OnPropertyChanging("EMailSender", this._eMailSender);
					this._eMailSender = value;
					this.OnPropertyChanged("EMailSender");
				}
			}
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
		public override string Title {
			get {
				throw new System.InvalidOperationException("Field Title was removed from content type Message.");
			}
			set {
				throw new System.InvalidOperationException("Field Title was removed from content type Message.");
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="MyEditor", Storage="_modifiedById", ReadOnly=true, FieldType="User", IsLookupId=true)]
		public System.Nullable<int> ModifiedById {
			get {
				return this._modifiedById;
			}
			set {
				if ((value != this._modifiedById)) {
					this.OnPropertyChanging("ModifiedById", this._modifiedById);
					this._modifiedById = value;
					this.OnPropertyChanged("ModifiedById");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="MyEditor", Storage="_modifiedByNameWithPicture", ReadOnly=true, FieldType="User", IsLookupValue=true)]
		public string ModifiedByNameWithPicture {
			get {
				return this._modifiedByNameWithPicture;
			}
			set {
				if ((value != this._modifiedByNameWithPicture)) {
					this.OnPropertyChanging("ModifiedByNameWithPicture", this._modifiedByNameWithPicture);
					this._modifiedByNameWithPicture = value;
					this.OnPropertyChanged("ModifiedByNameWithPicture");
				}
			}
		}
	}
	
	/// <summary>
	/// Create a new wiki page.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Wiki Page", Id="0x010108")]
	public partial class WikiPage : Document {
		
		private string _wikiContent;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public WikiPage() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WikiField", Storage="_wikiContent", FieldType="Note")]
		public string WikiContent {
			get {
				return this._wikiContent;
			}
			set {
				if ((value != this._wikiContent)) {
					this.OnPropertyChanging("WikiContent", this._wikiContent);
					this._wikiContent = value;
					this.OnPropertyChanged("WikiContent");
				}
			}
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
		public override string Title {
			get {
				throw new System.InvalidOperationException("Field Title was removed from content type Wiki Page.");
			}
			set {
				throw new System.InvalidOperationException("Field Title was removed from content type Wiki Page.");
			}
		}
	}
	
	/// <summary>
	/// Group and describe related tasks that you or your team needs to complete.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Summary Task", Id="0x012004")]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(TasksSummaryTask))]
	public partial class SummaryTask : Folder {
		
		private System.Nullable<double> _complete;
		
		private string _body;
		
		private System.Nullable<System.DateTime> _startDate;
		
		protected System.Nullable<System.DateTime> _dueDate;
		
		private System.Nullable<Priority> _priority;
		
		protected System.Nullable<TaskStatus> _taskStatus;
		
		private System.Nullable<int> _assignedToId;
		
		private string _assignedTo;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public SummaryTask() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="PercentComplete", Storage="_complete", FieldType="Number")]
		public System.Nullable<double> Complete {
			get {
				return this._complete;
			}
			set {
				if ((value != this._complete)) {
					this.OnPropertyChanging("Complete", this._complete);
					this._complete = value;
					this.OnPropertyChanged("Complete");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Body", Storage="_body", FieldType="Note")]
		public string Body {
			get {
				return this._body;
			}
			set {
				if ((value != this._body)) {
					this.OnPropertyChanging("Body", this._body);
					this._body = value;
					this.OnPropertyChanged("Body");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="StartDate", Storage="_startDate", FieldType="DateTime")]
		public System.Nullable<System.DateTime> StartDate {
			get {
				return this._startDate;
			}
			set {
				if ((value != this._startDate)) {
					this.OnPropertyChanging("StartDate", this._startDate);
					this._startDate = value;
					this.OnPropertyChanged("StartDate");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="TaskDueDate", Storage="_dueDate", FieldType="DateTime")]
		public virtual System.Nullable<System.DateTime> DueDate {
			get {
				return this._dueDate;
			}
			set {
				if ((value != this._dueDate)) {
					this.OnPropertyChanging("DueDate", this._dueDate);
					this._dueDate = value;
					this.OnPropertyChanged("DueDate");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Priority", Storage="_priority", FieldType="Choice")]
		public System.Nullable<Priority> Priority {
			get {
				return this._priority;
			}
			set {
				if ((value != this._priority)) {
					this.OnPropertyChanging("Priority", this._priority);
					this._priority = value;
					this.OnPropertyChanged("Priority");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="TaskStatus", Storage="_taskStatus", FieldType="Choice")]
		public virtual System.Nullable<TaskStatus> TaskStatus {
			get {
				return this._taskStatus;
			}
			set {
				if ((value != this._taskStatus)) {
					this.OnPropertyChanging("TaskStatus", this._taskStatus);
					this._taskStatus = value;
					this.OnPropertyChanged("TaskStatus");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="AssignedTo", Storage="_assignedToId", FieldType="User", IsLookupId=true)]
		public System.Nullable<int> AssignedToId {
			get {
				return this._assignedToId;
			}
			set {
				if ((value != this._assignedToId)) {
					this.OnPropertyChanging("AssignedToId", this._assignedToId);
					this._assignedToId = value;
					this.OnPropertyChanged("AssignedToId");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="AssignedTo", Storage="_assignedTo", ReadOnly=true, FieldType="User", IsLookupValue=true)]
		public string AssignedTo {
			get {
				return this._assignedTo;
			}
			set {
				if ((value != this._assignedTo)) {
					this.OnPropertyChanging("AssignedTo", this._assignedTo);
					this._assignedTo = value;
					this.OnPropertyChanged("AssignedTo");
				}
			}
		}
	}
	
	/// <summary>
	/// Create a new discussion topic.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Discussion", Id="0x012002")]
	public partial class Discussion : Folder {
		
		private string _discussionSubject;
		
		private string _version0;
		
		private string _body;
		
		private string _reply;
		
		private string _post;
		
		private string _threading;
		
		private string _postedBy;
		
		private System.Nullable<System.DateTime> _lastUpdated;
		
		private string _eMailSender;
		
		private System.Nullable<int> _modifiedById;
		
		private string _modifiedByNameWithPicture;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Discussion() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Title", Storage="_title", Required=true, FieldType="Text")]
		public override string Title {
			get {
				return this._title;
			}
			set {
				if ((value != this._title)) {
					this.OnPropertyChanging("Title", this._title);
					this._title = value;
					this.OnPropertyChanged("Title");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="DiscussionTitle", Storage="_discussionSubject", ReadOnly=true, FieldType="Computed")]
		public string DiscussionSubject {
			get {
				return this._discussionSubject;
			}
			set {
				if ((value != this._discussionSubject)) {
					this.OnPropertyChanging("DiscussionSubject", this._discussionSubject);
					this._discussionSubject = value;
					this.OnPropertyChanged("DiscussionSubject");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="_UIVersionString", Storage="_version0", ReadOnly=true, FieldType="Text")]
		public string Version0 {
			get {
				return this._version0;
			}
			set {
				if ((value != this._version0)) {
					this.OnPropertyChanging("Version0", this._version0);
					this._version0 = value;
					this.OnPropertyChanged("Version0");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Body", Storage="_body", FieldType="Note")]
		public string Body {
			get {
				return this._body;
			}
			set {
				if ((value != this._body)) {
					this.OnPropertyChanging("Body", this._body);
					this._body = value;
					this.OnPropertyChanged("Body");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ReplyNoGif", Storage="_reply", ReadOnly=true, FieldType="Computed")]
		public string Reply {
			get {
				return this._reply;
			}
			set {
				if ((value != this._reply)) {
					this.OnPropertyChanging("Reply", this._reply);
					this._reply = value;
					this.OnPropertyChanged("Reply");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="BodyAndMore", Storage="_post", ReadOnly=true, FieldType="Computed")]
		public string Post {
			get {
				return this._post;
			}
			set {
				if ((value != this._post)) {
					this.OnPropertyChanging("Post", this._post);
					this._post = value;
					this.OnPropertyChanged("Post");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Threading", Storage="_threading", ReadOnly=true, FieldType="Computed")]
		public string Threading {
			get {
				return this._threading;
			}
			set {
				if ((value != this._threading)) {
					this.OnPropertyChanging("Threading", this._threading);
					this._threading = value;
					this.OnPropertyChanged("Threading");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="PersonViewMinimal", Storage="_postedBy", ReadOnly=true, FieldType="Computed")]
		public string PostedBy {
			get {
				return this._postedBy;
			}
			set {
				if ((value != this._postedBy)) {
					this.OnPropertyChanging("PostedBy", this._postedBy);
					this._postedBy = value;
					this.OnPropertyChanged("PostedBy");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="DiscussionLastUpdated", Storage="_lastUpdated", ReadOnly=true, FieldType="DateTime")]
		public System.Nullable<System.DateTime> LastUpdated {
			get {
				return this._lastUpdated;
			}
			set {
				if ((value != this._lastUpdated)) {
					this.OnPropertyChanging("LastUpdated", this._lastUpdated);
					this._lastUpdated = value;
					this.OnPropertyChanged("LastUpdated");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="EmailSender", Storage="_eMailSender", FieldType="Note")]
		public string EMailSender {
			get {
				return this._eMailSender;
			}
			set {
				if ((value != this._eMailSender)) {
					this.OnPropertyChanging("EMailSender", this._eMailSender);
					this._eMailSender = value;
					this.OnPropertyChanged("EMailSender");
				}
			}
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
		public override string Name {
			get {
				throw new System.InvalidOperationException("Field FileLeafRef was removed from content type Discussion.");
			}
			set {
				throw new System.InvalidOperationException("Field FileLeafRef was removed from content type Discussion.");
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="MyEditor", Storage="_modifiedById", ReadOnly=true, FieldType="User", IsLookupId=true)]
		public System.Nullable<int> ModifiedById {
			get {
				return this._modifiedById;
			}
			set {
				if ((value != this._modifiedById)) {
					this.OnPropertyChanging("ModifiedById", this._modifiedById);
					this._modifiedById = value;
					this.OnPropertyChanged("ModifiedById");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="MyEditor", Storage="_modifiedByNameWithPicture", ReadOnly=true, FieldType="User", IsLookupValue=true)]
		public string ModifiedByNameWithPicture {
			get {
				return this._modifiedByNameWithPicture;
			}
			set {
				if ((value != this._modifiedByNameWithPicture)) {
					this.OnPropertyChanging("ModifiedByNameWithPicture", this._modifiedByNameWithPicture);
					this._modifiedByNameWithPicture = value;
					this.OnPropertyChanged("ModifiedByNameWithPicture");
				}
			}
		}
	}
	
	/// <summary>
	/// Create a new list item.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Item", Id="0x01", List="Employees")]
	public partial class EmployeesItem : Item {
		
		private string _jobTitle;
		
		private string _team;
		
		private System.Nullable<double> _contributionInMilestones;
		
		private Microsoft.SharePoint.Linq.EntityRef<ProjectsItem> _project;
		
		private Microsoft.SharePoint.Linq.EntitySet<ProjectsItem> _projectsItem;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public EmployeesItem() {
			this._project = new Microsoft.SharePoint.Linq.EntityRef<ProjectsItem>();
			this._project.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<ProjectsItem>>(this.OnProjectSync);
			this._project.OnChanged += new System.EventHandler(this.OnProjectChanged);
			this._project.OnChanging += new System.EventHandler(this.OnProjectChanging);
			this._projectsItem = new Microsoft.SharePoint.Linq.EntitySet<ProjectsItem>();
			this._projectsItem.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<ProjectsItem>>(this.OnProjectsItemSync);
			this._projectsItem.OnChanged += new System.EventHandler(this.OnProjectsItemChanged);
			this._projectsItem.OnChanging += new System.EventHandler(this.OnProjectsItemChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="JobTitle", Storage="_jobTitle", FieldType="Text")]
		public string JobTitle {
			get {
				return this._jobTitle;
			}
			set {
				if ((value != this._jobTitle)) {
					this.OnPropertyChanging("JobTitle", this._jobTitle);
					this._jobTitle = value;
					this.OnPropertyChanged("JobTitle");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Team", Storage="_team", FieldType="Text")]
		public string Team {
			get {
				return this._team;
			}
			set {
				if ((value != this._team)) {
					this.OnPropertyChanging("Team", this._team);
					this._team = value;
					this.OnPropertyChanged("Team");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Contribution_x0020__x0028_in_x00", Storage="_contributionInMilestones", FieldType="Number")]
		public System.Nullable<double> ContributionInMilestones {
			get {
				return this._contributionInMilestones;
			}
			set {
				if ((value != this._contributionInMilestones)) {
					this.OnPropertyChanging("ContributionInMilestones", this._contributionInMilestones);
					this._contributionInMilestones = value;
					this.OnPropertyChanged("ContributionInMilestones");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="Project", Storage="_project", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Projects")]
		public ProjectsItem Project {
			get {
				return this._project.GetEntity();
			}
			set {
				this._project.SetEntity(value);
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="Primary_x0020_Contact", Storage="_projectsItem", ReadOnly=true, MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Backward, List="Projects")]
		public Microsoft.SharePoint.Linq.EntitySet<ProjectsItem> ProjectsItem {
			get {
				return this._projectsItem;
			}
			set {
				this._projectsItem.Assign(value);
			}
		}
		
		private void OnProjectChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Project", this._project.Clone());
		}
		
		private void OnProjectChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Project");
		}
		
		private void OnProjectSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<ProjectsItem> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.EmployeesItem.Add(this);
			}
			else {
				e.Item.EmployeesItem.Remove(this);
			}
		}
		
		private void OnProjectsItemChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("ProjectsItem", this._projectsItem.Clone());
		}
		
		private void OnProjectsItemChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("ProjectsItem");
		}
		
		private void OnProjectsItemSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<ProjectsItem> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.PrimaryContact = this;
			}
			else {
				e.Item.PrimaryContact = null;
			}
		}
	}
	
	/// <summary>
	/// Create a new list item.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Item", Id="0x01", List="Projects")]
	public partial class ProjectsItem : Item {
		
		private string _description;
		
		private System.Nullable<System.DateTime> _dueDate;
		
		private Microsoft.SharePoint.Linq.EntitySet<EmployeesItem> _employeesItem;
		
		private Microsoft.SharePoint.Linq.EntityRef<EmployeesItem> _primaryContact;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public ProjectsItem() {
			this._employeesItem = new Microsoft.SharePoint.Linq.EntitySet<EmployeesItem>();
			this._employeesItem.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<EmployeesItem>>(this.OnEmployeesItemSync);
			this._employeesItem.OnChanged += new System.EventHandler(this.OnEmployeesItemChanged);
			this._employeesItem.OnChanging += new System.EventHandler(this.OnEmployeesItemChanging);
			this._primaryContact = new Microsoft.SharePoint.Linq.EntityRef<EmployeesItem>();
			this._primaryContact.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<EmployeesItem>>(this.OnPrimaryContactSync);
			this._primaryContact.OnChanged += new System.EventHandler(this.OnPrimaryContactChanged);
			this._primaryContact.OnChanging += new System.EventHandler(this.OnPrimaryContactChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Description", Storage="_description", FieldType="Text")]
		public string Description {
			get {
				return this._description;
			}
			set {
				if ((value != this._description)) {
					this.OnPropertyChanging("Description", this._description);
					this._description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Due_x0020_Date", Storage="_dueDate", FieldType="DateTime")]
		public System.Nullable<System.DateTime> DueDate {
			get {
				return this._dueDate;
			}
			set {
				if ((value != this._dueDate)) {
					this.OnPropertyChanging("DueDate", this._dueDate);
					this._dueDate = value;
					this.OnPropertyChanged("DueDate");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="Project", Storage="_employeesItem", ReadOnly=true, MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Backward, List="Employees")]
		public Microsoft.SharePoint.Linq.EntitySet<EmployeesItem> EmployeesItem {
			get {
				return this._employeesItem;
			}
			set {
				this._employeesItem.Assign(value);
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="Primary_x0020_Contact", Storage="_primaryContact", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Employees")]
		public EmployeesItem PrimaryContact {
			get {
				return this._primaryContact.GetEntity();
			}
			set {
				this._primaryContact.SetEntity(value);
			}
		}
		
		private void OnEmployeesItemChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("EmployeesItem", this._employeesItem.Clone());
		}
		
		private void OnEmployeesItemChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("EmployeesItem");
		}
		
		private void OnEmployeesItemSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<EmployeesItem> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.Project = this;
			}
			else {
				e.Item.Project = null;
			}
		}
		
		private void OnPrimaryContactChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("PrimaryContact", this._primaryContact.Clone());
		}
		
		private void OnPrimaryContactChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("PrimaryContact");
		}
		
		private void OnPrimaryContactSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<EmployeesItem> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.ProjectsItem.Add(this);
			}
			else {
				e.Item.ProjectsItem.Remove(this);
			}
		}
	}
	
	/// <summary>
	/// Create a new meeting, deadline or other event.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Event", Id="0x0102", List="Calendar")]
	public partial class CalendarEvent : Event {
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public CalendarEvent() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="EventDate", Storage="_startTime", Required=true, FieldType="DateTime")]
		public override System.Nullable<System.DateTime> StartTime {
			get {
				return this._startTime;
			}
			set {
				if ((value != this._startTime)) {
					this.OnPropertyChanging("StartTime", this._startTime);
					this._startTime = value;
					this.OnPropertyChanged("StartTime");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Description", Storage="_description", FieldType="Note")]
		public override string Description {
			get {
				return this._description;
			}
			set {
				if ((value != this._description)) {
					this.OnPropertyChanging("Description", this._description);
					this._description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}
	}
	
	/// <summary>
	/// Track a work item that you or your team needs to complete.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Task", Id="0x0108", List="Tasks")]
	public partial class TasksTask : Task {
		
		private Microsoft.SharePoint.Linq.EntitySet<Item> _predecessors;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public TasksTask() {
			this._predecessors = new Microsoft.SharePoint.Linq.EntitySet<Item>();
			this._predecessors.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Item>>(this.OnPredecessorsSync);
			this._predecessors.OnChanged += new System.EventHandler(this.OnPredecessorsChanged);
			this._predecessors.OnChanging += new System.EventHandler(this.OnPredecessorsChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="DueDate", Storage="_dueDate", FieldType="DateTime")]
		public override System.Nullable<System.DateTime> DueDate {
			get {
				return this._dueDate;
			}
			set {
				if ((value != this._dueDate)) {
					this.OnPropertyChanging("DueDate", this._dueDate);
					this._dueDate = value;
					this.OnPropertyChanged("DueDate");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Status", Storage="_taskStatus", FieldType="Choice")]
		public override System.Nullable<TaskStatus> TaskStatus {
			get {
				return this._taskStatus;
			}
			set {
				if ((value != this._taskStatus)) {
					this.OnPropertyChanging("TaskStatus", this._taskStatus);
					this._taskStatus = value;
					this.OnPropertyChanged("TaskStatus");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="Predecessors", Storage="_predecessors", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Multi, List="Tasks")]
		public Microsoft.SharePoint.Linq.EntitySet<Item> Predecessors {
			get {
				return this._predecessors;
			}
			set {
				this._predecessors.Assign(value);
			}
		}
		
		private void OnPredecessorsChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Predecessors", this._predecessors.Clone());
		}
		
		private void OnPredecessorsChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Predecessors");
		}
		
		private void OnPredecessorsSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Item> e) {
		}
	}
	
	/// <summary>
	/// Group and describe related tasks that you or your team needs to complete.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Summary Task", Id="0x012004", List="Tasks")]
	public partial class TasksSummaryTask : SummaryTask {
		
		private Microsoft.SharePoint.Linq.EntitySet<Item> _predecessors;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public TasksSummaryTask() {
			this._predecessors = new Microsoft.SharePoint.Linq.EntitySet<Item>();
			this._predecessors.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Item>>(this.OnPredecessorsSync);
			this._predecessors.OnChanged += new System.EventHandler(this.OnPredecessorsChanged);
			this._predecessors.OnChanging += new System.EventHandler(this.OnPredecessorsChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="DueDate", Storage="_dueDate", FieldType="DateTime")]
		public override System.Nullable<System.DateTime> DueDate {
			get {
				return this._dueDate;
			}
			set {
				if ((value != this._dueDate)) {
					this.OnPropertyChanging("DueDate", this._dueDate);
					this._dueDate = value;
					this.OnPropertyChanged("DueDate");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Status", Storage="_taskStatus", FieldType="Choice")]
		public override System.Nullable<TaskStatus> TaskStatus {
			get {
				return this._taskStatus;
			}
			set {
				if ((value != this._taskStatus)) {
					this.OnPropertyChanging("TaskStatus", this._taskStatus);
					this._taskStatus = value;
					this.OnPropertyChanged("TaskStatus");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="Predecessors", Storage="_predecessors", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Multi, List="Tasks")]
		public Microsoft.SharePoint.Linq.EntitySet<Item> Predecessors {
			get {
				return this._predecessors;
			}
			set {
				this._predecessors.Assign(value);
			}
		}
		
		private void OnPredecessorsChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Predecessors", this._predecessors.Clone());
		}
		
		private void OnPredecessorsChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Predecessors");
		}
		
		private void OnPredecessorsSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Item> e) {
		}
	}
	
	public enum Category : int {
		
		None = 0,
		
		Invalid = 1,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="(1) Category1")]
		_1Category1 = 2,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="(2) Category2")]
		_2Category2 = 4,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="(3) Category3")]
		_3Category3 = 8,
	}
	
	public enum Priority : int {
		
		None = 0,
		
		Invalid = 1,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="(1) High")]
		_1High = 2,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="(2) Normal")]
		_2Normal = 4,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="(3) Low")]
		_3Low = 8,
	}
	
	public enum TaskStatus : int {
		
		None = 0,
		
		Invalid = 1,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="Not Started")]
		NotStarted = 2,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="In Progress")]
		InProgress = 4,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="Completed")]
		Completed = 8,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="Deferred")]
		Deferred = 16,
		
		[Microsoft.SharePoint.Linq.ChoiceAttribute(Value="Waiting on someone else")]
		WaitingOnSomeoneElse = 32,
	}
}
