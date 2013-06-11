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

namespace SPCHOL303_Ex2.ServiceReference1
{
    
    /// <summary>
    /// There are no comments for TeamSiteDataContext in the schema.
    /// </summary>
    public partial class TeamSiteDataContext : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new TeamSiteDataContext object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public TeamSiteDataContext(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("Microsoft.SharePoint.DataService", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("SPCHOL303_Ex2.ServiceReference1", typeName.Substring(32)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("SPCHOL303_Ex2.ServiceReference1", global::System.StringComparison.Ordinal))
            {
                return string.Concat("Microsoft.SharePoint.DataService.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Announcements in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<AnnouncementsItem> Announcements
        {
            get
            {
                if ((this._Announcements == null))
                {
                    this._Announcements = base.CreateQuery<AnnouncementsItem>("Announcements");
                }
                return this._Announcements;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<AnnouncementsItem> _Announcements;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<AttachmentsItem> Attachments
        {
            get
            {
                if ((this._Attachments == null))
                {
                    this._Attachments = base.CreateQuery<AttachmentsItem>("Attachments");
                }
                return this._Attachments;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<AttachmentsItem> _Attachments;
        /// <summary>
        /// There are no comments for CacheProfiles in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<CacheProfilesItem> CacheProfiles
        {
            get
            {
                if ((this._CacheProfiles == null))
                {
                    this._CacheProfiles = base.CreateQuery<CacheProfilesItem>("CacheProfiles");
                }
                return this._CacheProfiles;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<CacheProfilesItem> _CacheProfiles;
        /// <summary>
        /// There are no comments for CacheProfilesCacheability in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<CacheProfilesCacheabilityValue> CacheProfilesCacheability
        {
            get
            {
                if ((this._CacheProfilesCacheability == null))
                {
                    this._CacheProfilesCacheability = base.CreateQuery<CacheProfilesCacheabilityValue>("CacheProfilesCacheability");
                }
                return this._CacheProfilesCacheability;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<CacheProfilesCacheabilityValue> _CacheProfilesCacheability;
        /// <summary>
        /// There are no comments for Calendar in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<CalendarItem> Calendar
        {
            get
            {
                if ((this._Calendar == null))
                {
                    this._Calendar = base.CreateQuery<CalendarItem>("Calendar");
                }
                return this._Calendar;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<CalendarItem> _Calendar;
        /// <summary>
        /// There are no comments for CalendarCategory in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<CalendarCategoryValue> CalendarCategory
        {
            get
            {
                if ((this._CalendarCategory == null))
                {
                    this._CalendarCategory = base.CreateQuery<CalendarCategoryValue>("CalendarCategory");
                }
                return this._CalendarCategory;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<CalendarCategoryValue> _CalendarCategory;
        /// <summary>
        /// There are no comments for ContentAndStructureReports in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ContentAndStructureReportsItem> ContentAndStructureReports
        {
            get
            {
                if ((this._ContentAndStructureReports == null))
                {
                    this._ContentAndStructureReports = base.CreateQuery<ContentAndStructureReportsItem>("ContentAndStructureReports");
                }
                return this._ContentAndStructureReports;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ContentAndStructureReportsItem> _ContentAndStructureReports;
        /// <summary>
        /// There are no comments for ContentTypePublishingErrorLog in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ContentTypePublishingErrorLogItem> ContentTypePublishingErrorLog
        {
            get
            {
                if ((this._ContentTypePublishingErrorLog == null))
                {
                    this._ContentTypePublishingErrorLog = base.CreateQuery<ContentTypePublishingErrorLogItem>("ContentTypePublishingErrorLog");
                }
                return this._ContentTypePublishingErrorLog;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ContentTypePublishingErrorLogItem> _ContentTypePublishingErrorLog;
        /// <summary>
        /// There are no comments for ConvertedForms in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ConvertedFormsItem> ConvertedForms
        {
            get
            {
                if ((this._ConvertedForms == null))
                {
                    this._ConvertedForms = base.CreateQuery<ConvertedFormsItem>("ConvertedForms");
                }
                return this._ConvertedForms;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ConvertedFormsItem> _ConvertedForms;
        /// <summary>
        /// There are no comments for CustomizedReports in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<CustomizedReportsItem> CustomizedReports
        {
            get
            {
                if ((this._CustomizedReports == null))
                {
                    this._CustomizedReports = base.CreateQuery<CustomizedReportsItem>("CustomizedReports");
                }
                return this._CustomizedReports;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<CustomizedReportsItem> _CustomizedReports;
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<EmployeesItem> Employees
        {
            get
            {
                if ((this._Employees == null))
                {
                    this._Employees = base.CreateQuery<EmployeesItem>("Employees");
                }
                return this._Employees;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<EmployeesItem> _Employees;
        /// <summary>
        /// There are no comments for FormTemplates in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<FormTemplatesItem> FormTemplates
        {
            get
            {
                if ((this._FormTemplates == null))
                {
                    this._FormTemplates = base.CreateQuery<FormTemplatesItem>("FormTemplates");
                }
                return this._FormTemplates;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<FormTemplatesItem> _FormTemplates;
        /// <summary>
        /// There are no comments for Links in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public new global::System.Data.Services.Client.DataServiceQuery<LinksItem> Links
        {
            get
            {
                if ((this._Links == null))
                {
                    this._Links = base.CreateQuery<LinksItem>("Links");
                }
                return this._Links;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<LinksItem> _Links;
        /// <summary>
        /// There are no comments for ListTemplateGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ListTemplateGalleryItem> ListTemplateGallery
        {
            get
            {
                if ((this._ListTemplateGallery == null))
                {
                    this._ListTemplateGallery = base.CreateQuery<ListTemplateGalleryItem>("ListTemplateGallery");
                }
                return this._ListTemplateGallery;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ListTemplateGalleryItem> _ListTemplateGallery;
        /// <summary>
        /// There are no comments for LongRunningOperationStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<LongRunningOperationStatusItem> LongRunningOperationStatus
        {
            get
            {
                if ((this._LongRunningOperationStatus == null))
                {
                    this._LongRunningOperationStatus = base.CreateQuery<LongRunningOperationStatusItem>("LongRunningOperationStatus");
                }
                return this._LongRunningOperationStatus;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<LongRunningOperationStatusItem> _LongRunningOperationStatus;
        /// <summary>
        /// There are no comments for MasterPageGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<MasterPageGalleryItem> MasterPageGallery
        {
            get
            {
                if ((this._MasterPageGallery == null))
                {
                    this._MasterPageGallery = base.CreateQuery<MasterPageGalleryItem>("MasterPageGallery");
                }
                return this._MasterPageGallery;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<MasterPageGalleryItem> _MasterPageGallery;
        /// <summary>
        /// There are no comments for MasterPageGalleryCompatibleUIVersionS in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<MasterPageGalleryCompatibleUIVersionSValue> MasterPageGalleryCompatibleUIVersionS
        {
            get
            {
                if ((this._MasterPageGalleryCompatibleUIVersionS == null))
                {
                    this._MasterPageGalleryCompatibleUIVersionS = base.CreateQuery<MasterPageGalleryCompatibleUIVersionSValue>("MasterPageGalleryCompatibleUIVersionS");
                }
                return this._MasterPageGalleryCompatibleUIVersionS;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<MasterPageGalleryCompatibleUIVersionSValue> _MasterPageGalleryCompatibleUIVersionS;
        /// <summary>
        /// There are no comments for NotificationList in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<NotificationListItem> NotificationList
        {
            get
            {
                if ((this._NotificationList == null))
                {
                    this._NotificationList = base.CreateQuery<NotificationListItem>("NotificationList");
                }
                return this._NotificationList;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<NotificationListItem> _NotificationList;
        /// <summary>
        /// There are no comments for Projects in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ProjectsItem> Projects
        {
            get
            {
                if ((this._Projects == null))
                {
                    this._Projects = base.CreateQuery<ProjectsItem>("Projects");
                }
                return this._Projects;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ProjectsItem> _Projects;
        /// <summary>
        /// There are no comments for QuickDeployItems in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<QuickDeployItemsItem> QuickDeployItems
        {
            get
            {
                if ((this._QuickDeployItems == null))
                {
                    this._QuickDeployItems = base.CreateQuery<QuickDeployItemsItem>("QuickDeployItems");
                }
                return this._QuickDeployItems;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<QuickDeployItemsItem> _QuickDeployItems;
        /// <summary>
        /// There are no comments for RelationshipsList in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<RelationshipsListItem> RelationshipsList
        {
            get
            {
                if ((this._RelationshipsList == null))
                {
                    this._RelationshipsList = base.CreateQuery<RelationshipsListItem>("RelationshipsList");
                }
                return this._RelationshipsList;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<RelationshipsListItem> _RelationshipsList;
        /// <summary>
        /// There are no comments for ReportingMetadata in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ReportingMetadataItem> ReportingMetadata
        {
            get
            {
                if ((this._ReportingMetadata == null))
                {
                    this._ReportingMetadata = base.CreateQuery<ReportingMetadataItem>("ReportingMetadata");
                }
                return this._ReportingMetadata;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ReportingMetadataItem> _ReportingMetadata;
        /// <summary>
        /// There are no comments for ReportingTemplates in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ReportingTemplatesItem> ReportingTemplates
        {
            get
            {
                if ((this._ReportingTemplates == null))
                {
                    this._ReportingTemplates = base.CreateQuery<ReportingTemplatesItem>("ReportingTemplates");
                }
                return this._ReportingTemplates;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ReportingTemplatesItem> _ReportingTemplates;
        /// <summary>
        /// There are no comments for ReusableContent in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ReusableContentItem> ReusableContent
        {
            get
            {
                if ((this._ReusableContent == null))
                {
                    this._ReusableContent = base.CreateQuery<ReusableContentItem>("ReusableContent");
                }
                return this._ReusableContent;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ReusableContentItem> _ReusableContent;
        /// <summary>
        /// There are no comments for ReusableContentContentCategory in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ReusableContentContentCategoryValue> ReusableContentContentCategory
        {
            get
            {
                if ((this._ReusableContentContentCategory == null))
                {
                    this._ReusableContentContentCategory = base.CreateQuery<ReusableContentContentCategoryValue>("ReusableContentContentCategory");
                }
                return this._ReusableContentContentCategory;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ReusableContentContentCategoryValue> _ReusableContentContentCategory;
        /// <summary>
        /// There are no comments for SharedDocuments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<SharedDocumentsItem> SharedDocuments
        {
            get
            {
                if ((this._SharedDocuments == null))
                {
                    this._SharedDocuments = base.CreateQuery<SharedDocumentsItem>("SharedDocuments");
                }
                return this._SharedDocuments;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<SharedDocumentsItem> _SharedDocuments;
        /// <summary>
        /// There are no comments for SiteAssets in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<SiteAssetsItem> SiteAssets
        {
            get
            {
                if ((this._SiteAssets == null))
                {
                    this._SiteAssets = base.CreateQuery<SiteAssetsItem>("SiteAssets");
                }
                return this._SiteAssets;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<SiteAssetsItem> _SiteAssets;
        /// <summary>
        /// There are no comments for SiteCollectionDocuments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<SiteCollectionDocumentsItem> SiteCollectionDocuments
        {
            get
            {
                if ((this._SiteCollectionDocuments == null))
                {
                    this._SiteCollectionDocuments = base.CreateQuery<SiteCollectionDocumentsItem>("SiteCollectionDocuments");
                }
                return this._SiteCollectionDocuments;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<SiteCollectionDocumentsItem> _SiteCollectionDocuments;
        /// <summary>
        /// There are no comments for SiteCollectionImages in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<SiteCollectionImagesItem> SiteCollectionImages
        {
            get
            {
                if ((this._SiteCollectionImages == null))
                {
                    this._SiteCollectionImages = base.CreateQuery<SiteCollectionImagesItem>("SiteCollectionImages");
                }
                return this._SiteCollectionImages;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<SiteCollectionImagesItem> _SiteCollectionImages;
        /// <summary>
        /// There are no comments for SitePages in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<SitePagesItem> SitePages
        {
            get
            {
                if ((this._SitePages == null))
                {
                    this._SitePages = base.CreateQuery<SitePagesItem>("SitePages");
                }
                return this._SitePages;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<SitePagesItem> _SitePages;
        /// <summary>
        /// There are no comments for SolutionGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<SolutionGalleryItem> SolutionGallery
        {
            get
            {
                if ((this._SolutionGallery == null))
                {
                    this._SolutionGallery = base.CreateQuery<SolutionGalleryItem>("SolutionGallery");
                }
                return this._SolutionGallery;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<SolutionGalleryItem> _SolutionGallery;
        /// <summary>
        /// There are no comments for StyleLibrary in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<StyleLibraryItem> StyleLibrary
        {
            get
            {
                if ((this._StyleLibrary == null))
                {
                    this._StyleLibrary = base.CreateQuery<StyleLibraryItem>("StyleLibrary");
                }
                return this._StyleLibrary;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<StyleLibraryItem> _StyleLibrary;
        /// <summary>
        /// There are no comments for SuggestedContentBrowserLocations in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<SuggestedContentBrowserLocationsItem> SuggestedContentBrowserLocations
        {
            get
            {
                if ((this._SuggestedContentBrowserLocations == null))
                {
                    this._SuggestedContentBrowserLocations = base.CreateQuery<SuggestedContentBrowserLocationsItem>("SuggestedContentBrowserLocations");
                }
                return this._SuggestedContentBrowserLocations;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<SuggestedContentBrowserLocationsItem> _SuggestedContentBrowserLocations;
        /// <summary>
        /// There are no comments for Tasks in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<TasksItem> Tasks
        {
            get
            {
                if ((this._Tasks == null))
                {
                    this._Tasks = base.CreateQuery<TasksItem>("Tasks");
                }
                return this._Tasks;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<TasksItem> _Tasks;
        /// <summary>
        /// There are no comments for TasksPriority in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<TasksPriorityValue> TasksPriority
        {
            get
            {
                if ((this._TasksPriority == null))
                {
                    this._TasksPriority = base.CreateQuery<TasksPriorityValue>("TasksPriority");
                }
                return this._TasksPriority;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<TasksPriorityValue> _TasksPriority;
        /// <summary>
        /// There are no comments for TasksStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<TasksStatusValue> TasksStatus
        {
            get
            {
                if ((this._TasksStatus == null))
                {
                    this._TasksStatus = base.CreateQuery<TasksStatusValue>("TasksStatus");
                }
                return this._TasksStatus;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<TasksStatusValue> _TasksStatus;
        /// <summary>
        /// There are no comments for TaxonomyHiddenList in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<TaxonomyHiddenListItem> TaxonomyHiddenList
        {
            get
            {
                if ((this._TaxonomyHiddenList == null))
                {
                    this._TaxonomyHiddenList = base.CreateQuery<TaxonomyHiddenListItem>("TaxonomyHiddenList");
                }
                return this._TaxonomyHiddenList;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<TaxonomyHiddenListItem> _TaxonomyHiddenList;
        /// <summary>
        /// There are no comments for TeamDiscussion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<TeamDiscussionItem> TeamDiscussion
        {
            get
            {
                if ((this._TeamDiscussion == null))
                {
                    this._TeamDiscussion = base.CreateQuery<TeamDiscussionItem>("TeamDiscussion");
                }
                return this._TeamDiscussion;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<TeamDiscussionItem> _TeamDiscussion;
        /// <summary>
        /// There are no comments for ThemeGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ThemeGalleryItem> ThemeGallery
        {
            get
            {
                if ((this._ThemeGallery == null))
                {
                    this._ThemeGallery = base.CreateQuery<ThemeGalleryItem>("ThemeGallery");
                }
                return this._ThemeGallery;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ThemeGalleryItem> _ThemeGallery;
        /// <summary>
        /// There are no comments for UserInformationList in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<UserInformationListItem> UserInformationList
        {
            get
            {
                if ((this._UserInformationList == null))
                {
                    this._UserInformationList = base.CreateQuery<UserInformationListItem>("UserInformationList");
                }
                return this._UserInformationList;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<UserInformationListItem> _UserInformationList;
        /// <summary>
        /// There are no comments for VariationLabels in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<VariationLabelsItem> VariationLabels
        {
            get
            {
                if ((this._VariationLabels == null))
                {
                    this._VariationLabels = base.CreateQuery<VariationLabelsItem>("VariationLabels");
                }
                return this._VariationLabels;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<VariationLabelsItem> _VariationLabels;
        /// <summary>
        /// There are no comments for VariationLabelsHierarchyCreationMode in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<VariationLabelsHierarchyCreationModeValue> VariationLabelsHierarchyCreationMode
        {
            get
            {
                if ((this._VariationLabelsHierarchyCreationMode == null))
                {
                    this._VariationLabelsHierarchyCreationMode = base.CreateQuery<VariationLabelsHierarchyCreationModeValue>("VariationLabelsHierarchyCreationMode");
                }
                return this._VariationLabelsHierarchyCreationMode;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<VariationLabelsHierarchyCreationModeValue> _VariationLabelsHierarchyCreationMode;
        /// <summary>
        /// There are no comments for WebPartGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<WebPartGalleryItem> WebPartGallery
        {
            get
            {
                if ((this._WebPartGallery == null))
                {
                    this._WebPartGallery = base.CreateQuery<WebPartGalleryItem>("WebPartGallery");
                }
                return this._WebPartGallery;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<WebPartGalleryItem> _WebPartGallery;
        /// <summary>
        /// There are no comments for WebPartGalleryGroup in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<WebPartGalleryGroupValue> WebPartGalleryGroup
        {
            get
            {
                if ((this._WebPartGalleryGroup == null))
                {
                    this._WebPartGalleryGroup = base.CreateQuery<WebPartGalleryGroupValue>("WebPartGalleryGroup");
                }
                return this._WebPartGalleryGroup;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<WebPartGalleryGroupValue> _WebPartGalleryGroup;
        /// <summary>
        /// There are no comments for WebPartGalleryRecommendationSettings in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<WebPartGalleryRecommendationSettingsValue> WebPartGalleryRecommendationSettings
        {
            get
            {
                if ((this._WebPartGalleryRecommendationSettings == null))
                {
                    this._WebPartGalleryRecommendationSettings = base.CreateQuery<WebPartGalleryRecommendationSettingsValue>("WebPartGalleryRecommendationSettings");
                }
                return this._WebPartGalleryRecommendationSettings;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<WebPartGalleryRecommendationSettingsValue> _WebPartGalleryRecommendationSettings;
        /// <summary>
        /// There are no comments for Wfpub in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<WfpubItem> Wfpub
        {
            get
            {
                if ((this._Wfpub == null))
                {
                    this._Wfpub = base.CreateQuery<WfpubItem>("Wfpub");
                }
                return this._Wfpub;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<WfpubItem> _Wfpub;
        /// <summary>
        /// There are no comments for WorkflowTasks in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<WorkflowTasksItem> WorkflowTasks
        {
            get
            {
                if ((this._WorkflowTasks == null))
                {
                    this._WorkflowTasks = base.CreateQuery<WorkflowTasksItem>("WorkflowTasks");
                }
                return this._WorkflowTasks;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<WorkflowTasksItem> _WorkflowTasks;
        /// <summary>
        /// There are no comments for WorkflowTasksPriority in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<WorkflowTasksPriorityValue> WorkflowTasksPriority
        {
            get
            {
                if ((this._WorkflowTasksPriority == null))
                {
                    this._WorkflowTasksPriority = base.CreateQuery<WorkflowTasksPriorityValue>("WorkflowTasksPriority");
                }
                return this._WorkflowTasksPriority;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<WorkflowTasksPriorityValue> _WorkflowTasksPriority;
        /// <summary>
        /// There are no comments for WorkflowTasksStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<WorkflowTasksStatusValue> WorkflowTasksStatus
        {
            get
            {
                if ((this._WorkflowTasksStatus == null))
                {
                    this._WorkflowTasksStatus = base.CreateQuery<WorkflowTasksStatusValue>("WorkflowTasksStatus");
                }
                return this._WorkflowTasksStatus;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<WorkflowTasksStatusValue> _WorkflowTasksStatus;
        /// <summary>
        /// There are no comments for Announcements in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToAnnouncements(AnnouncementsItem announcementsItem)
        {
            base.AddObject("Announcements", announcementsItem);
        }
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToAttachments(AttachmentsItem attachmentsItem)
        {
            base.AddObject("Attachments", attachmentsItem);
        }
        /// <summary>
        /// There are no comments for CacheProfiles in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCacheProfiles(CacheProfilesItem cacheProfilesItem)
        {
            base.AddObject("CacheProfiles", cacheProfilesItem);
        }
        /// <summary>
        /// There are no comments for CacheProfilesCacheability in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCacheProfilesCacheability(CacheProfilesCacheabilityValue cacheProfilesCacheabilityValue)
        {
            base.AddObject("CacheProfilesCacheability", cacheProfilesCacheabilityValue);
        }
        /// <summary>
        /// There are no comments for Calendar in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCalendar(CalendarItem calendarItem)
        {
            base.AddObject("Calendar", calendarItem);
        }
        /// <summary>
        /// There are no comments for CalendarCategory in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCalendarCategory(CalendarCategoryValue calendarCategoryValue)
        {
            base.AddObject("CalendarCategory", calendarCategoryValue);
        }
        /// <summary>
        /// There are no comments for ContentAndStructureReports in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToContentAndStructureReports(ContentAndStructureReportsItem contentAndStructureReportsItem)
        {
            base.AddObject("ContentAndStructureReports", contentAndStructureReportsItem);
        }
        /// <summary>
        /// There are no comments for ContentTypePublishingErrorLog in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToContentTypePublishingErrorLog(ContentTypePublishingErrorLogItem contentTypePublishingErrorLogItem)
        {
            base.AddObject("ContentTypePublishingErrorLog", contentTypePublishingErrorLogItem);
        }
        /// <summary>
        /// There are no comments for ConvertedForms in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToConvertedForms(ConvertedFormsItem convertedFormsItem)
        {
            base.AddObject("ConvertedForms", convertedFormsItem);
        }
        /// <summary>
        /// There are no comments for CustomizedReports in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCustomizedReports(CustomizedReportsItem customizedReportsItem)
        {
            base.AddObject("CustomizedReports", customizedReportsItem);
        }
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToEmployees(EmployeesItem employeesItem)
        {
            base.AddObject("Employees", employeesItem);
        }
        /// <summary>
        /// There are no comments for FormTemplates in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToFormTemplates(FormTemplatesItem formTemplatesItem)
        {
            base.AddObject("FormTemplates", formTemplatesItem);
        }
        /// <summary>
        /// There are no comments for Links in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToLinks(LinksItem linksItem)
        {
            base.AddObject("Links", linksItem);
        }
        /// <summary>
        /// There are no comments for ListTemplateGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToListTemplateGallery(ListTemplateGalleryItem listTemplateGalleryItem)
        {
            base.AddObject("ListTemplateGallery", listTemplateGalleryItem);
        }
        /// <summary>
        /// There are no comments for LongRunningOperationStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToLongRunningOperationStatus(LongRunningOperationStatusItem longRunningOperationStatusItem)
        {
            base.AddObject("LongRunningOperationStatus", longRunningOperationStatusItem);
        }
        /// <summary>
        /// There are no comments for MasterPageGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToMasterPageGallery(MasterPageGalleryItem masterPageGalleryItem)
        {
            base.AddObject("MasterPageGallery", masterPageGalleryItem);
        }
        /// <summary>
        /// There are no comments for MasterPageGalleryCompatibleUIVersionS in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToMasterPageGalleryCompatibleUIVersionS(MasterPageGalleryCompatibleUIVersionSValue masterPageGalleryCompatibleUIVersionSValue)
        {
            base.AddObject("MasterPageGalleryCompatibleUIVersionS", masterPageGalleryCompatibleUIVersionSValue);
        }
        /// <summary>
        /// There are no comments for NotificationList in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToNotificationList(NotificationListItem notificationListItem)
        {
            base.AddObject("NotificationList", notificationListItem);
        }
        /// <summary>
        /// There are no comments for Projects in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToProjects(ProjectsItem projectsItem)
        {
            base.AddObject("Projects", projectsItem);
        }
        /// <summary>
        /// There are no comments for QuickDeployItems in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToQuickDeployItems(QuickDeployItemsItem quickDeployItemsItem)
        {
            base.AddObject("QuickDeployItems", quickDeployItemsItem);
        }
        /// <summary>
        /// There are no comments for RelationshipsList in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToRelationshipsList(RelationshipsListItem relationshipsListItem)
        {
            base.AddObject("RelationshipsList", relationshipsListItem);
        }
        /// <summary>
        /// There are no comments for ReportingMetadata in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToReportingMetadata(ReportingMetadataItem reportingMetadataItem)
        {
            base.AddObject("ReportingMetadata", reportingMetadataItem);
        }
        /// <summary>
        /// There are no comments for ReportingTemplates in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToReportingTemplates(ReportingTemplatesItem reportingTemplatesItem)
        {
            base.AddObject("ReportingTemplates", reportingTemplatesItem);
        }
        /// <summary>
        /// There are no comments for ReusableContent in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToReusableContent(ReusableContentItem reusableContentItem)
        {
            base.AddObject("ReusableContent", reusableContentItem);
        }
        /// <summary>
        /// There are no comments for ReusableContentContentCategory in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToReusableContentContentCategory(ReusableContentContentCategoryValue reusableContentContentCategoryValue)
        {
            base.AddObject("ReusableContentContentCategory", reusableContentContentCategoryValue);
        }
        /// <summary>
        /// There are no comments for SharedDocuments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSharedDocuments(SharedDocumentsItem sharedDocumentsItem)
        {
            base.AddObject("SharedDocuments", sharedDocumentsItem);
        }
        /// <summary>
        /// There are no comments for SiteAssets in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSiteAssets(SiteAssetsItem siteAssetsItem)
        {
            base.AddObject("SiteAssets", siteAssetsItem);
        }
        /// <summary>
        /// There are no comments for SiteCollectionDocuments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSiteCollectionDocuments(SiteCollectionDocumentsItem siteCollectionDocumentsItem)
        {
            base.AddObject("SiteCollectionDocuments", siteCollectionDocumentsItem);
        }
        /// <summary>
        /// There are no comments for SiteCollectionImages in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSiteCollectionImages(SiteCollectionImagesItem siteCollectionImagesItem)
        {
            base.AddObject("SiteCollectionImages", siteCollectionImagesItem);
        }
        /// <summary>
        /// There are no comments for SitePages in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSitePages(SitePagesItem sitePagesItem)
        {
            base.AddObject("SitePages", sitePagesItem);
        }
        /// <summary>
        /// There are no comments for SolutionGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSolutionGallery(SolutionGalleryItem solutionGalleryItem)
        {
            base.AddObject("SolutionGallery", solutionGalleryItem);
        }
        /// <summary>
        /// There are no comments for StyleLibrary in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToStyleLibrary(StyleLibraryItem styleLibraryItem)
        {
            base.AddObject("StyleLibrary", styleLibraryItem);
        }
        /// <summary>
        /// There are no comments for SuggestedContentBrowserLocations in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSuggestedContentBrowserLocations(SuggestedContentBrowserLocationsItem suggestedContentBrowserLocationsItem)
        {
            base.AddObject("SuggestedContentBrowserLocations", suggestedContentBrowserLocationsItem);
        }
        /// <summary>
        /// There are no comments for Tasks in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTasks(TasksItem tasksItem)
        {
            base.AddObject("Tasks", tasksItem);
        }
        /// <summary>
        /// There are no comments for TasksPriority in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTasksPriority(TasksPriorityValue tasksPriorityValue)
        {
            base.AddObject("TasksPriority", tasksPriorityValue);
        }
        /// <summary>
        /// There are no comments for TasksStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTasksStatus(TasksStatusValue tasksStatusValue)
        {
            base.AddObject("TasksStatus", tasksStatusValue);
        }
        /// <summary>
        /// There are no comments for TaxonomyHiddenList in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTaxonomyHiddenList(TaxonomyHiddenListItem taxonomyHiddenListItem)
        {
            base.AddObject("TaxonomyHiddenList", taxonomyHiddenListItem);
        }
        /// <summary>
        /// There are no comments for TeamDiscussion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTeamDiscussion(TeamDiscussionItem teamDiscussionItem)
        {
            base.AddObject("TeamDiscussion", teamDiscussionItem);
        }
        /// <summary>
        /// There are no comments for ThemeGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToThemeGallery(ThemeGalleryItem themeGalleryItem)
        {
            base.AddObject("ThemeGallery", themeGalleryItem);
        }
        /// <summary>
        /// There are no comments for UserInformationList in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToUserInformationList(UserInformationListItem userInformationListItem)
        {
            base.AddObject("UserInformationList", userInformationListItem);
        }
        /// <summary>
        /// There are no comments for VariationLabels in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToVariationLabels(VariationLabelsItem variationLabelsItem)
        {
            base.AddObject("VariationLabels", variationLabelsItem);
        }
        /// <summary>
        /// There are no comments for VariationLabelsHierarchyCreationMode in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToVariationLabelsHierarchyCreationMode(VariationLabelsHierarchyCreationModeValue variationLabelsHierarchyCreationModeValue)
        {
            base.AddObject("VariationLabelsHierarchyCreationMode", variationLabelsHierarchyCreationModeValue);
        }
        /// <summary>
        /// There are no comments for WebPartGallery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToWebPartGallery(WebPartGalleryItem webPartGalleryItem)
        {
            base.AddObject("WebPartGallery", webPartGalleryItem);
        }
        /// <summary>
        /// There are no comments for WebPartGalleryGroup in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToWebPartGalleryGroup(WebPartGalleryGroupValue webPartGalleryGroupValue)
        {
            base.AddObject("WebPartGalleryGroup", webPartGalleryGroupValue);
        }
        /// <summary>
        /// There are no comments for WebPartGalleryRecommendationSettings in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToWebPartGalleryRecommendationSettings(WebPartGalleryRecommendationSettingsValue webPartGalleryRecommendationSettingsValue)
        {
            base.AddObject("WebPartGalleryRecommendationSettings", webPartGalleryRecommendationSettingsValue);
        }
        /// <summary>
        /// There are no comments for Wfpub in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToWfpub(WfpubItem wfpubItem)
        {
            base.AddObject("Wfpub", wfpubItem);
        }
        /// <summary>
        /// There are no comments for WorkflowTasks in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToWorkflowTasks(WorkflowTasksItem workflowTasksItem)
        {
            base.AddObject("WorkflowTasks", workflowTasksItem);
        }
        /// <summary>
        /// There are no comments for WorkflowTasksPriority in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToWorkflowTasksPriority(WorkflowTasksPriorityValue workflowTasksPriorityValue)
        {
            base.AddObject("WorkflowTasksPriority", workflowTasksPriorityValue);
        }
        /// <summary>
        /// There are no comments for WorkflowTasksStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToWorkflowTasksStatus(WorkflowTasksStatusValue workflowTasksStatusValue)
        {
            base.AddObject("WorkflowTasksStatus", workflowTasksStatusValue);
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.AnnouncementsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Announcements")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class AnnouncementsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AnnouncementsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static AnnouncementsItem CreateAnnouncementsItem(int ID)
        {
            AnnouncementsItem announcementsItem = new AnnouncementsItem();
            announcementsItem.Id = ID;
            return announcementsItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property Body in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Body
        {
            get
            {
                return this._Body;
            }
            set
            {
                this.OnBodyChanging(value);
                this._Body = value;
                this.OnBodyChanged();
                this.OnPropertyChanged("Body");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Body;
        partial void OnBodyChanging(string value);
        partial void OnBodyChanged();
        /// <summary>
        /// There are no comments for Property Expires in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Expires
        {
            get
            {
                return this._Expires;
            }
            set
            {
                this.OnExpiresChanging(value);
                this._Expires = value;
                this.OnExpiresChanged();
                this.OnPropertyChanged("Expires");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Expires;
        partial void OnExpiresChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnExpiresChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.AttachmentsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EntitySet
    /// ItemId
    /// Name
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Attachments")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Name", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("EntitySet", "ItemId", "Name")]
    public partial class AttachmentsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AttachmentsItem object.
        /// </summary>
        /// <param name="entitySet">Initial value of EntitySet.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="name">Initial value of Name.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static AttachmentsItem CreateAttachmentsItem(string entitySet, int itemId, string name)
        {
            AttachmentsItem attachmentsItem = new AttachmentsItem();
            attachmentsItem.EntitySet = entitySet;
            attachmentsItem.ItemId = itemId;
            attachmentsItem.Name = name;
            return attachmentsItem;
        }
        /// <summary>
        /// There are no comments for Property EntitySet in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string EntitySet
        {
            get
            {
                return this._EntitySet;
            }
            set
            {
                this.OnEntitySetChanging(value);
                this._EntitySet = value;
                this.OnEntitySetChanged();
                this.OnPropertyChanged("EntitySet");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _EntitySet;
        partial void OnEntitySetChanging(string value);
        partial void OnEntitySetChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ItemId;
        partial void OnItemIdChanging(int value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.CacheProfilesItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("CacheProfiles")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class CacheProfilesItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CacheProfilesItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static CacheProfilesItem CreateCacheProfilesItem(int ID)
        {
            CacheProfilesItem cacheProfilesItem = new CacheProfilesItem();
            cacheProfilesItem.Id = ID;
            return cacheProfilesItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property DisplayName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string DisplayName
        {
            get
            {
                return this._DisplayName;
            }
            set
            {
                this.OnDisplayNameChanging(value);
                this._DisplayName = value;
                this.OnDisplayNameChanged();
                this.OnPropertyChanged("DisplayName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _DisplayName;
        partial void OnDisplayNameChanging(string value);
        partial void OnDisplayNameChanged();
        /// <summary>
        /// There are no comments for Property DisplayDescription in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string DisplayDescription
        {
            get
            {
                return this._DisplayDescription;
            }
            set
            {
                this.OnDisplayDescriptionChanging(value);
                this._DisplayDescription = value;
                this.OnDisplayDescriptionChanged();
                this.OnPropertyChanged("DisplayDescription");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _DisplayDescription;
        partial void OnDisplayDescriptionChanging(string value);
        partial void OnDisplayDescriptionChanged();
        /// <summary>
        /// There are no comments for Property PerformACLCheck in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> PerformACLCheck
        {
            get
            {
                return this._PerformACLCheck;
            }
            set
            {
                this.OnPerformACLCheckChanging(value);
                this._PerformACLCheck = value;
                this.OnPerformACLCheckChanged();
                this.OnPropertyChanged("PerformACLCheck");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _PerformACLCheck;
        partial void OnPerformACLCheckChanging(global::System.Nullable<bool> value);
        partial void OnPerformACLCheckChanged();
        /// <summary>
        /// There are no comments for Property Enabled in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> Enabled
        {
            get
            {
                return this._Enabled;
            }
            set
            {
                this.OnEnabledChanging(value);
                this._Enabled = value;
                this.OnEnabledChanged();
                this.OnPropertyChanged("Enabled");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _Enabled;
        partial void OnEnabledChanging(global::System.Nullable<bool> value);
        partial void OnEnabledChanged();
        /// <summary>
        /// There are no comments for Property Duration in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<double> Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                this.OnDurationChanging(value);
                this._Duration = value;
                this.OnDurationChanged();
                this.OnPropertyChanged("Duration");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<double> _Duration;
        partial void OnDurationChanging(global::System.Nullable<double> value);
        partial void OnDurationChanged();
        /// <summary>
        /// There are no comments for Property CheckForChanges in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> CheckForChanges
        {
            get
            {
                return this._CheckForChanges;
            }
            set
            {
                this.OnCheckForChangesChanging(value);
                this._CheckForChanges = value;
                this.OnCheckForChangesChanged();
                this.OnPropertyChanged("CheckForChanges");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _CheckForChanges;
        partial void OnCheckForChangesChanging(global::System.Nullable<bool> value);
        partial void OnCheckForChangesChanged();
        /// <summary>
        /// There are no comments for Property VaryByCustomParameter in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VaryByCustomParameter
        {
            get
            {
                return this._VaryByCustomParameter;
            }
            set
            {
                this.OnVaryByCustomParameterChanging(value);
                this._VaryByCustomParameter = value;
                this.OnVaryByCustomParameterChanged();
                this.OnPropertyChanged("VaryByCustomParameter");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VaryByCustomParameter;
        partial void OnVaryByCustomParameterChanging(string value);
        partial void OnVaryByCustomParameterChanged();
        /// <summary>
        /// There are no comments for Property VaryByHTTPHeader in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VaryByHTTPHeader
        {
            get
            {
                return this._VaryByHTTPHeader;
            }
            set
            {
                this.OnVaryByHTTPHeaderChanging(value);
                this._VaryByHTTPHeader = value;
                this.OnVaryByHTTPHeaderChanged();
                this.OnPropertyChanged("VaryByHTTPHeader");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VaryByHTTPHeader;
        partial void OnVaryByHTTPHeaderChanging(string value);
        partial void OnVaryByHTTPHeaderChanged();
        /// <summary>
        /// There are no comments for Property VaryByQueryStringParameters in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VaryByQueryStringParameters
        {
            get
            {
                return this._VaryByQueryStringParameters;
            }
            set
            {
                this.OnVaryByQueryStringParametersChanging(value);
                this._VaryByQueryStringParameters = value;
                this.OnVaryByQueryStringParametersChanged();
                this.OnPropertyChanged("VaryByQueryStringParameters");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VaryByQueryStringParameters;
        partial void OnVaryByQueryStringParametersChanging(string value);
        partial void OnVaryByQueryStringParametersChanged();
        /// <summary>
        /// There are no comments for Property VaryByUserRights in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> VaryByUserRights
        {
            get
            {
                return this._VaryByUserRights;
            }
            set
            {
                this.OnVaryByUserRightsChanging(value);
                this._VaryByUserRights = value;
                this.OnVaryByUserRightsChanged();
                this.OnPropertyChanged("VaryByUserRights");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _VaryByUserRights;
        partial void OnVaryByUserRightsChanging(global::System.Nullable<bool> value);
        partial void OnVaryByUserRightsChanged();
        /// <summary>
        /// There are no comments for Property CacheabilityValue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CacheabilityValue
        {
            get
            {
                return this._CacheabilityValue;
            }
            set
            {
                this.OnCacheabilityValueChanging(value);
                this._CacheabilityValue = value;
                this.OnCacheabilityValueChanged();
                this.OnPropertyChanged("CacheabilityValue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CacheabilityValue;
        partial void OnCacheabilityValueChanging(string value);
        partial void OnCacheabilityValueChanged();
        /// <summary>
        /// There are no comments for Property SafeForAuthenticatedUse in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> SafeForAuthenticatedUse
        {
            get
            {
                return this._SafeForAuthenticatedUse;
            }
            set
            {
                this.OnSafeForAuthenticatedUseChanging(value);
                this._SafeForAuthenticatedUse = value;
                this.OnSafeForAuthenticatedUseChanged();
                this.OnPropertyChanged("SafeForAuthenticatedUse");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _SafeForAuthenticatedUse;
        partial void OnSafeForAuthenticatedUseChanging(global::System.Nullable<bool> value);
        partial void OnSafeForAuthenticatedUseChanged();
        /// <summary>
        /// There are no comments for Property AllowWritersToViewCachedContent in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> AllowWritersToViewCachedContent
        {
            get
            {
                return this._AllowWritersToViewCachedContent;
            }
            set
            {
                this.OnAllowWritersToViewCachedContentChanging(value);
                this._AllowWritersToViewCachedContent = value;
                this.OnAllowWritersToViewCachedContentChanged();
                this.OnPropertyChanged("AllowWritersToViewCachedContent");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _AllowWritersToViewCachedContent;
        partial void OnAllowWritersToViewCachedContentChanging(global::System.Nullable<bool> value);
        partial void OnAllowWritersToViewCachedContentChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Cacheability in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public CacheProfilesCacheabilityValue Cacheability
        {
            get
            {
                return this._Cacheability;
            }
            set
            {
                this._Cacheability = value;
                this.OnPropertyChanged("Cacheability");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private CacheProfilesCacheabilityValue _Cacheability;
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.CacheProfilesCacheabilityValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("CacheProfilesCacheability")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class CacheProfilesCacheabilityValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CacheProfilesCacheabilityValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static CacheProfilesCacheabilityValue CreateCacheProfilesCacheabilityValue(string value)
        {
            CacheProfilesCacheabilityValue cacheProfilesCacheabilityValue = new CacheProfilesCacheabilityValue();
            cacheProfilesCacheabilityValue.Value = value;
            return cacheProfilesCacheabilityValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.CalendarItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Calendar")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class CalendarItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CalendarItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static CalendarItem CreateCalendarItem(int ID)
        {
            CalendarItem calendarItem = new CalendarItem();
            calendarItem.Id = ID;
            return calendarItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property Location in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this.OnLocationChanging(value);
                this._Location = value;
                this.OnLocationChanged();
                this.OnPropertyChanged("Location");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Location;
        partial void OnLocationChanging(string value);
        partial void OnLocationChanged();
        /// <summary>
        /// There are no comments for Property StartTime in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                this.OnStartTimeChanging(value);
                this._StartTime = value;
                this.OnStartTimeChanged();
                this.OnPropertyChanged("StartTime");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _StartTime;
        partial void OnStartTimeChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnStartTimeChanged();
        /// <summary>
        /// There are no comments for Property EndTime in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> EndTime
        {
            get
            {
                return this._EndTime;
            }
            set
            {
                this.OnEndTimeChanging(value);
                this._EndTime = value;
                this.OnEndTimeChanged();
                this.OnPropertyChanged("EndTime");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _EndTime;
        partial void OnEndTimeChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnEndTimeChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property AllDayEvent in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> AllDayEvent
        {
            get
            {
                return this._AllDayEvent;
            }
            set
            {
                this.OnAllDayEventChanging(value);
                this._AllDayEvent = value;
                this.OnAllDayEventChanged();
                this.OnPropertyChanged("AllDayEvent");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _AllDayEvent;
        partial void OnAllDayEventChanging(global::System.Nullable<bool> value);
        partial void OnAllDayEventChanged();
        /// <summary>
        /// There are no comments for Property Recurrence in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> Recurrence
        {
            get
            {
                return this._Recurrence;
            }
            set
            {
                this.OnRecurrenceChanging(value);
                this._Recurrence = value;
                this.OnRecurrenceChanged();
                this.OnPropertyChanged("Recurrence");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _Recurrence;
        partial void OnRecurrenceChanging(global::System.Nullable<bool> value);
        partial void OnRecurrenceChanged();
        /// <summary>
        /// There are no comments for Property Workspace in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> Workspace
        {
            get
            {
                return this._Workspace;
            }
            set
            {
                this.OnWorkspaceChanging(value);
                this._Workspace = value;
                this.OnWorkspaceChanged();
                this.OnPropertyChanged("Workspace");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _Workspace;
        partial void OnWorkspaceChanging(global::System.Nullable<bool> value);
        partial void OnWorkspaceChanged();
        /// <summary>
        /// There are no comments for Property CategoryValue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CategoryValue
        {
            get
            {
                return this._CategoryValue;
            }
            set
            {
                this.OnCategoryValueChanging(value);
                this._CategoryValue = value;
                this.OnCategoryValueChanged();
                this.OnPropertyChanged("CategoryValue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CategoryValue;
        partial void OnCategoryValueChanging(string value);
        partial void OnCategoryValueChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        /// <summary>
        /// There are no comments for Attendees in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<UserInformationListItem> Attendees
        {
            get
            {
                return this._Attendees;
            }
            set
            {
                this._Attendees = value;
                this.OnPropertyChanged("Attendees");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<UserInformationListItem> _Attendees = new global::System.Data.Services.Client.DataServiceCollection<UserInformationListItem>(null, System.Data.Services.Client.TrackingMode.None);
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public CalendarCategoryValue Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this._Category = value;
                this.OnPropertyChanged("Category");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private CalendarCategoryValue _Category;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.CalendarCategoryValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("CalendarCategory")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class CalendarCategoryValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CalendarCategoryValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static CalendarCategoryValue CreateCalendarCategoryValue(string value)
        {
            CalendarCategoryValue calendarCategoryValue = new CalendarCategoryValue();
            calendarCategoryValue.Value = value;
            return calendarCategoryValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ContentAndStructureReportsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ContentAndStructureReports")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("ReportTitle", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class ContentAndStructureReportsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ContentAndStructureReportsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ContentAndStructureReportsItem CreateContentAndStructureReportsItem(int ID)
        {
            ContentAndStructureReportsItem contentAndStructureReportsItem = new ContentAndStructureReportsItem();
            contentAndStructureReportsItem.Id = ID;
            return contentAndStructureReportsItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ReportTitle in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ReportTitle
        {
            get
            {
                return this._ReportTitle;
            }
            set
            {
                this.OnReportTitleChanging(value);
                this._ReportTitle = value;
                this.OnReportTitleChanged();
                this.OnPropertyChanged("ReportTitle");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ReportTitle;
        partial void OnReportTitleChanging(string value);
        partial void OnReportTitleChanged();
        /// <summary>
        /// There are no comments for Property ResourceId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ResourceId
        {
            get
            {
                return this._ResourceId;
            }
            set
            {
                this.OnResourceIdChanging(value);
                this._ResourceId = value;
                this.OnResourceIdChanged();
                this.OnPropertyChanged("ResourceId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ResourceId;
        partial void OnResourceIdChanging(string value);
        partial void OnResourceIdChanged();
        /// <summary>
        /// There are no comments for Property ResourceId0 in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ResourceId0
        {
            get
            {
                return this._ResourceId0;
            }
            set
            {
                this.OnResourceId0Changing(value);
                this._ResourceId0 = value;
                this.OnResourceId0Changed();
                this.OnPropertyChanged("ResourceId0");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ResourceId0;
        partial void OnResourceId0Changing(string value);
        partial void OnResourceId0Changed();
        /// <summary>
        /// There are no comments for Property CAMLListType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CAMLListType
        {
            get
            {
                return this._CAMLListType;
            }
            set
            {
                this.OnCAMLListTypeChanging(value);
                this._CAMLListType = value;
                this.OnCAMLListTypeChanged();
                this.OnPropertyChanged("CAMLListType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CAMLListType;
        partial void OnCAMLListTypeChanging(string value);
        partial void OnCAMLListTypeChanged();
        /// <summary>
        /// There are no comments for Property CAMLQuery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CAMLQuery
        {
            get
            {
                return this._CAMLQuery;
            }
            set
            {
                this.OnCAMLQueryChanging(value);
                this._CAMLQuery = value;
                this.OnCAMLQueryChanged();
                this.OnPropertyChanged("CAMLQuery");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CAMLQuery;
        partial void OnCAMLQueryChanging(string value);
        partial void OnCAMLQueryChanged();
        /// <summary>
        /// There are no comments for Property ReportDescription in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ReportDescription
        {
            get
            {
                return this._ReportDescription;
            }
            set
            {
                this.OnReportDescriptionChanging(value);
                this._ReportDescription = value;
                this.OnReportDescriptionChanged();
                this.OnPropertyChanged("ReportDescription");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ReportDescription;
        partial void OnReportDescriptionChanging(string value);
        partial void OnReportDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ContentTypePublishingErrorLogItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ContentTypePublishingErrorLog")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class ContentTypePublishingErrorLogItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ContentTypePublishingErrorLogItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ContentTypePublishingErrorLogItem CreateContentTypePublishingErrorLogItem(int ID)
        {
            ContentTypePublishingErrorLogItem contentTypePublishingErrorLogItem = new ContentTypePublishingErrorLogItem();
            contentTypePublishingErrorLogItem.Id = ID;
            return contentTypePublishingErrorLogItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property SyndicationItem in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SyndicationItem
        {
            get
            {
                return this._SyndicationItem;
            }
            set
            {
                this.OnSyndicationItemChanging(value);
                this._SyndicationItem = value;
                this.OnSyndicationItemChanged();
                this.OnPropertyChanged("SyndicationItem");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SyndicationItem;
        partial void OnSyndicationItemChanging(string value);
        partial void OnSyndicationItemChanged();
        /// <summary>
        /// There are no comments for Property SyndicationFailureStage in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SyndicationFailureStage
        {
            get
            {
                return this._SyndicationFailureStage;
            }
            set
            {
                this.OnSyndicationFailureStageChanging(value);
                this._SyndicationFailureStage = value;
                this.OnSyndicationFailureStageChanged();
                this.OnPropertyChanged("SyndicationFailureStage");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SyndicationFailureStage;
        partial void OnSyndicationFailureStageChanging(string value);
        partial void OnSyndicationFailureStageChanged();
        /// <summary>
        /// There are no comments for Property SyndicationFailureMessage in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SyndicationFailureMessage
        {
            get
            {
                return this._SyndicationFailureMessage;
            }
            set
            {
                this.OnSyndicationFailureMessageChanging(value);
                this._SyndicationFailureMessage = value;
                this.OnSyndicationFailureMessageChanged();
                this.OnPropertyChanged("SyndicationFailureMessage");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SyndicationFailureMessage;
        partial void OnSyndicationFailureMessageChanging(string value);
        partial void OnSyndicationFailureMessageChanged();
        /// <summary>
        /// There are no comments for Property SyndicationFailureTime in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> SyndicationFailureTime
        {
            get
            {
                return this._SyndicationFailureTime;
            }
            set
            {
                this.OnSyndicationFailureTimeChanging(value);
                this._SyndicationFailureTime = value;
                this.OnSyndicationFailureTimeChanged();
                this.OnPropertyChanged("SyndicationFailureTime");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _SyndicationFailureTime;
        partial void OnSyndicationFailureTimeChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnSyndicationFailureTimeChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ConvertedFormsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ConvertedForms")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class ConvertedFormsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ConvertedFormsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ConvertedFormsItem CreateConvertedFormsItem(int ID)
        {
            ConvertedFormsItem convertedFormsItem = new ConvertedFormsItem();
            convertedFormsItem.Id = ID;
            return convertedFormsItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property TemplateId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string TemplateId
        {
            get
            {
                return this._TemplateId;
            }
            set
            {
                this.OnTemplateIdChanging(value);
                this._TemplateId = value;
                this.OnTemplateIdChanged();
                this.OnPropertyChanged("TemplateId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _TemplateId;
        partial void OnTemplateIdChanging(string value);
        partial void OnTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property FormRelativeUrl in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FormRelativeUrl
        {
            get
            {
                return this._FormRelativeUrl;
            }
            set
            {
                this.OnFormRelativeUrlChanging(value);
                this._FormRelativeUrl = value;
                this.OnFormRelativeUrlChanged();
                this.OnPropertyChanged("FormRelativeUrl");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FormRelativeUrl;
        partial void OnFormRelativeUrlChanging(string value);
        partial void OnFormRelativeUrlChanged();
        /// <summary>
        /// There are no comments for Property Version0 in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version0
        {
            get
            {
                return this._Version0;
            }
            set
            {
                this.OnVersion0Changing(value);
                this._Version0 = value;
                this.OnVersion0Changed();
                this.OnPropertyChanged("Version0");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version0;
        partial void OnVersion0Changing(string value);
        partial void OnVersion0Changed();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.CustomizedReportsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("CustomizedReports")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class CustomizedReportsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomizedReportsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static CustomizedReportsItem CreateCustomizedReportsItem(int ID)
        {
            CustomizedReportsItem customizedReportsItem = new CustomizedReportsItem();
            customizedReportsItem.Id = ID;
            return customizedReportsItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.EmployeesItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Employees")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Fullname", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class EmployeesItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EmployeesItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static EmployeesItem CreateEmployeesItem(int ID)
        {
            EmployeesItem employeesItem = new EmployeesItem();
            employeesItem.Id = ID;
            return employeesItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Fullname in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Fullname
        {
            get
            {
                return this._Fullname;
            }
            set
            {
                this.OnFullnameChanging(value);
                this._Fullname = value;
                this.OnFullnameChanged();
                this.OnPropertyChanged("Fullname");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Fullname;
        partial void OnFullnameChanging(string value);
        partial void OnFullnameChanged();
        /// <summary>
        /// There are no comments for Property JobTitle in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string JobTitle
        {
            get
            {
                return this._JobTitle;
            }
            set
            {
                this.OnJobTitleChanging(value);
                this._JobTitle = value;
                this.OnJobTitleChanged();
                this.OnPropertyChanged("JobTitle");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _JobTitle;
        partial void OnJobTitleChanging(string value);
        partial void OnJobTitleChanged();
        /// <summary>
        /// There are no comments for Property Team in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Team
        {
            get
            {
                return this._Team;
            }
            set
            {
                this.OnTeamChanging(value);
                this._Team = value;
                this.OnTeamChanged();
                this.OnPropertyChanged("Team");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Team;
        partial void OnTeamChanging(string value);
        partial void OnTeamChanged();
        /// <summary>
        /// There are no comments for Property ContributionInMilestones in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<double> ContributionInMilestones
        {
            get
            {
                return this._ContributionInMilestones;
            }
            set
            {
                this.OnContributionInMilestonesChanging(value);
                this._ContributionInMilestones = value;
                this.OnContributionInMilestonesChanged();
                this.OnPropertyChanged("ContributionInMilestones");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<double> _ContributionInMilestones;
        partial void OnContributionInMilestonesChanging(global::System.Nullable<double> value);
        partial void OnContributionInMilestonesChanged();
        /// <summary>
        /// There are no comments for Property ProjectId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ProjectId
        {
            get
            {
                return this._ProjectId;
            }
            set
            {
                this.OnProjectIdChanging(value);
                this._ProjectId = value;
                this.OnProjectIdChanged();
                this.OnPropertyChanged("ProjectId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ProjectId;
        partial void OnProjectIdChanging(global::System.Nullable<int> value);
        partial void OnProjectIdChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Project in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ProjectsItem Project
        {
            get
            {
                return this._Project;
            }
            set
            {
                this._Project = value;
                this.OnPropertyChanged("Project");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private ProjectsItem _Project;
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.FormTemplatesItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("FormTemplates")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class FormTemplatesItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FormTemplatesItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static FormTemplatesItem CreateFormTemplatesItem(int ID)
        {
            FormTemplatesItem formTemplatesItem = new FormTemplatesItem();
            formTemplatesItem.Id = ID;
            return formTemplatesItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property FormName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FormName
        {
            get
            {
                return this._FormName;
            }
            set
            {
                this.OnFormNameChanging(value);
                this._FormName = value;
                this.OnFormNameChanged();
                this.OnPropertyChanged("FormName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FormName;
        partial void OnFormNameChanging(string value);
        partial void OnFormNameChanged();
        /// <summary>
        /// There are no comments for Property FormCategory in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FormCategory
        {
            get
            {
                return this._FormCategory;
            }
            set
            {
                this.OnFormCategoryChanging(value);
                this._FormCategory = value;
                this.OnFormCategoryChanged();
                this.OnPropertyChanged("FormCategory");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FormCategory;
        partial void OnFormCategoryChanging(string value);
        partial void OnFormCategoryChanged();
        /// <summary>
        /// There are no comments for Property FormVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FormVersion
        {
            get
            {
                return this._FormVersion;
            }
            set
            {
                this.OnFormVersionChanging(value);
                this._FormVersion = value;
                this.OnFormVersionChanged();
                this.OnPropertyChanged("FormVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FormVersion;
        partial void OnFormVersionChanging(string value);
        partial void OnFormVersionChanged();
        /// <summary>
        /// There are no comments for Property FormID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FormID
        {
            get
            {
                return this._FormID;
            }
            set
            {
                this.OnFormIDChanging(value);
                this._FormID = value;
                this.OnFormIDChanged();
                this.OnPropertyChanged("FormID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FormID;
        partial void OnFormIDChanging(string value);
        partial void OnFormIDChanged();
        /// <summary>
        /// There are no comments for Property FormLocale in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FormLocale
        {
            get
            {
                return this._FormLocale;
            }
            set
            {
                this.OnFormLocaleChanging(value);
                this._FormLocale = value;
                this.OnFormLocaleChanged();
                this.OnPropertyChanged("FormLocale");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FormLocale;
        partial void OnFormLocaleChanging(string value);
        partial void OnFormLocaleChanged();
        /// <summary>
        /// There are no comments for Property FormDescription in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FormDescription
        {
            get
            {
                return this._FormDescription;
            }
            set
            {
                this.OnFormDescriptionChanging(value);
                this._FormDescription = value;
                this.OnFormDescriptionChanged();
                this.OnPropertyChanged("FormDescription");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FormDescription;
        partial void OnFormDescriptionChanging(string value);
        partial void OnFormDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ShowInCatalog in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> ShowInCatalog
        {
            get
            {
                return this._ShowInCatalog;
            }
            set
            {
                this.OnShowInCatalogChanging(value);
                this._ShowInCatalog = value;
                this.OnShowInCatalogChanged();
                this.OnPropertyChanged("ShowInCatalog");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _ShowInCatalog;
        partial void OnShowInCatalogChanging(global::System.Nullable<bool> value);
        partial void OnShowInCatalogChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.LinksItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Links")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class LinksItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LinksItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static LinksItem CreateLinksItem(int ID)
        {
            LinksItem linksItem = new LinksItem();
            linksItem.Id = ID;
            return linksItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property URL in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string URL
        {
            get
            {
                return this._URL;
            }
            set
            {
                this.OnURLChanging(value);
                this._URL = value;
                this.OnURLChanged();
                this.OnPropertyChanged("URL");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _URL;
        partial void OnURLChanging(string value);
        partial void OnURLChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ListTemplateGalleryItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ListTemplateGallery")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class ListTemplateGalleryItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ListTemplateGalleryItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ListTemplateGalleryItem CreateListTemplateGalleryItem(int ID)
        {
            ListTemplateGalleryItem listTemplateGalleryItem = new ListTemplateGalleryItem();
            listTemplateGalleryItem.Id = ID;
            return listTemplateGalleryItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property SiteDefinitionID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SiteDefinitionID
        {
            get
            {
                return this._SiteDefinitionID;
            }
            set
            {
                this.OnSiteDefinitionIDChanging(value);
                this._SiteDefinitionID = value;
                this.OnSiteDefinitionIDChanged();
                this.OnPropertyChanged("SiteDefinitionID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SiteDefinitionID;
        partial void OnSiteDefinitionIDChanging(string value);
        partial void OnSiteDefinitionIDChanged();
        /// <summary>
        /// There are no comments for Property BaseType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> BaseType
        {
            get
            {
                return this._BaseType;
            }
            set
            {
                this.OnBaseTypeChanging(value);
                this._BaseType = value;
                this.OnBaseTypeChanged();
                this.OnPropertyChanged("BaseType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _BaseType;
        partial void OnBaseTypeChanging(global::System.Nullable<int> value);
        partial void OnBaseTypeChanged();
        /// <summary>
        /// There are no comments for Property ProductVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<double> ProductVersion
        {
            get
            {
                return this._ProductVersion;
            }
            set
            {
                this.OnProductVersionChanging(value);
                this._ProductVersion = value;
                this.OnProductVersionChanged();
                this.OnPropertyChanged("ProductVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<double> _ProductVersion;
        partial void OnProductVersionChanging(global::System.Nullable<double> value);
        partial void OnProductVersionChanged();
        /// <summary>
        /// There are no comments for Property FeatureID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.Guid> FeatureID
        {
            get
            {
                return this._FeatureID;
            }
            set
            {
                this.OnFeatureIDChanging(value);
                this._FeatureID = value;
                this.OnFeatureIDChanged();
                this.OnPropertyChanged("FeatureID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.Guid> _FeatureID;
        partial void OnFeatureIDChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnFeatureIDChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.LongRunningOperationStatusItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("LongRunningOperationStatus")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class LongRunningOperationStatusItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LongRunningOperationStatusItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static LongRunningOperationStatusItem CreateLongRunningOperationStatusItem(int ID)
        {
            LongRunningOperationStatusItem longRunningOperationStatusItem = new LongRunningOperationStatusItem();
            longRunningOperationStatusItem.Id = ID;
            return longRunningOperationStatusItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property UrlToNavigateTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string UrlToNavigateTo
        {
            get
            {
                return this._UrlToNavigateTo;
            }
            set
            {
                this.OnUrlToNavigateToChanging(value);
                this._UrlToNavigateTo = value;
                this.OnUrlToNavigateToChanged();
                this.OnPropertyChanged("UrlToNavigateTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _UrlToNavigateTo;
        partial void OnUrlToNavigateToChanging(string value);
        partial void OnUrlToNavigateToChanged();
        /// <summary>
        /// There are no comments for Property OperationsPerformed in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> OperationsPerformed
        {
            get
            {
                return this._OperationsPerformed;
            }
            set
            {
                this.OnOperationsPerformedChanging(value);
                this._OperationsPerformed = value;
                this.OnOperationsPerformedChanged();
                this.OnPropertyChanged("OperationsPerformed");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _OperationsPerformed;
        partial void OnOperationsPerformedChanging(global::System.Nullable<int> value);
        partial void OnOperationsPerformedChanged();
        /// <summary>
        /// There are no comments for Property UrlToRetry in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string UrlToRetry
        {
            get
            {
                return this._UrlToRetry;
            }
            set
            {
                this.OnUrlToRetryChanging(value);
                this._UrlToRetry = value;
                this.OnUrlToRetryChanged();
                this.OnPropertyChanged("UrlToRetry");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _UrlToRetry;
        partial void OnUrlToRetryChanging(string value);
        partial void OnUrlToRetryChanged();
        /// <summary>
        /// There are no comments for Property StatusDescription in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string StatusDescription
        {
            get
            {
                return this._StatusDescription;
            }
            set
            {
                this.OnStatusDescriptionChanging(value);
                this._StatusDescription = value;
                this.OnStatusDescriptionChanged();
                this.OnPropertyChanged("StatusDescription");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _StatusDescription;
        partial void OnStatusDescriptionChanging(string value);
        partial void OnStatusDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Status;
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property TimeLastUpdated in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> TimeLastUpdated
        {
            get
            {
                return this._TimeLastUpdated;
            }
            set
            {
                this.OnTimeLastUpdatedChanging(value);
                this._TimeLastUpdated = value;
                this.OnTimeLastUpdatedChanged();
                this.OnPropertyChanged("TimeLastUpdated");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _TimeLastUpdated;
        partial void OnTimeLastUpdatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnTimeLastUpdatedChanged();
        /// <summary>
        /// There are no comments for Property TimeStarted in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> TimeStarted
        {
            get
            {
                return this._TimeStarted;
            }
            set
            {
                this.OnTimeStartedChanging(value);
                this._TimeStarted = value;
                this.OnTimeStartedChanged();
                this.OnPropertyChanged("TimeStarted");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _TimeStarted;
        partial void OnTimeStartedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnTimeStartedChanged();
        /// <summary>
        /// There are no comments for Property TotalNumberOfOperations in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> TotalNumberOfOperations
        {
            get
            {
                return this._TotalNumberOfOperations;
            }
            set
            {
                this.OnTotalNumberOfOperationsChanging(value);
                this._TotalNumberOfOperations = value;
                this.OnTotalNumberOfOperationsChanged();
                this.OnPropertyChanged("TotalNumberOfOperations");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _TotalNumberOfOperations;
        partial void OnTotalNumberOfOperationsChanging(global::System.Nullable<int> value);
        partial void OnTotalNumberOfOperationsChanged();
        /// <summary>
        /// There are no comments for Property UserName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                this.OnUserNameChanging(value);
                this._UserName = value;
                this.OnUserNameChanged();
                this.OnPropertyChanged("UserName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _UserName;
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
        /// <summary>
        /// There are no comments for Property WaitMessage in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string WaitMessage
        {
            get
            {
                return this._WaitMessage;
            }
            set
            {
                this.OnWaitMessageChanging(value);
                this._WaitMessage = value;
                this.OnWaitMessageChanged();
                this.OnPropertyChanged("WaitMessage");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _WaitMessage;
        partial void OnWaitMessageChanging(string value);
        partial void OnWaitMessageChanged();
        /// <summary>
        /// There are no comments for Property ErrorsEncountered in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ErrorsEncountered
        {
            get
            {
                return this._ErrorsEncountered;
            }
            set
            {
                this.OnErrorsEncounteredChanging(value);
                this._ErrorsEncountered = value;
                this.OnErrorsEncounteredChanged();
                this.OnPropertyChanged("ErrorsEncountered");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ErrorsEncountered;
        partial void OnErrorsEncounteredChanging(string value);
        partial void OnErrorsEncounteredChanged();
        /// <summary>
        /// There are no comments for Property SucessesEncountered in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SucessesEncountered
        {
            get
            {
                return this._SucessesEncountered;
            }
            set
            {
                this.OnSucessesEncounteredChanging(value);
                this._SucessesEncountered = value;
                this.OnSucessesEncounteredChanged();
                this.OnPropertyChanged("SucessesEncountered");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SucessesEncountered;
        partial void OnSucessesEncounteredChanging(string value);
        partial void OnSucessesEncounteredChanged();
        /// <summary>
        /// There are no comments for Property UserCanCancel in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> UserCanCancel
        {
            get
            {
                return this._UserCanCancel;
            }
            set
            {
                this.OnUserCanCancelChanging(value);
                this._UserCanCancel = value;
                this.OnUserCanCancelChanged();
                this.OnPropertyChanged("UserCanCancel");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _UserCanCancel;
        partial void OnUserCanCancelChanging(global::System.Nullable<bool> value);
        partial void OnUserCanCancelChanged();
        /// <summary>
        /// There are no comments for Property UserRequestedCancel in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> UserRequestedCancel
        {
            get
            {
                return this._UserRequestedCancel;
            }
            set
            {
                this.OnUserRequestedCancelChanging(value);
                this._UserRequestedCancel = value;
                this.OnUserRequestedCancelChanged();
                this.OnPropertyChanged("UserRequestedCancel");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _UserRequestedCancel;
        partial void OnUserRequestedCancelChanging(global::System.Nullable<bool> value);
        partial void OnUserRequestedCancelChanged();
        /// <summary>
        /// There are no comments for Property RedirectWhenFinished in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> RedirectWhenFinished
        {
            get
            {
                return this._RedirectWhenFinished;
            }
            set
            {
                this.OnRedirectWhenFinishedChanging(value);
                this._RedirectWhenFinished = value;
                this.OnRedirectWhenFinishedChanged();
                this.OnPropertyChanged("RedirectWhenFinished");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _RedirectWhenFinished;
        partial void OnRedirectWhenFinishedChanging(global::System.Nullable<bool> value);
        partial void OnRedirectWhenFinishedChanged();
        /// <summary>
        /// There are no comments for Property GearsImage in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string GearsImage
        {
            get
            {
                return this._GearsImage;
            }
            set
            {
                this.OnGearsImageChanging(value);
                this._GearsImage = value;
                this.OnGearsImageChanged();
                this.OnPropertyChanged("GearsImage");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _GearsImage;
        partial void OnGearsImageChanging(string value);
        partial void OnGearsImageChanged();
        /// <summary>
        /// There are no comments for Property PreviousJobId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.Guid> PreviousJobId
        {
            get
            {
                return this._PreviousJobId;
            }
            set
            {
                this.OnPreviousJobIdChanging(value);
                this._PreviousJobId = value;
                this.OnPreviousJobIdChanged();
                this.OnPropertyChanged("PreviousJobId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.Guid> _PreviousJobId;
        partial void OnPreviousJobIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnPreviousJobIdChanged();
        /// <summary>
        /// There are no comments for Property OriginalJobId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.Guid> OriginalJobId
        {
            get
            {
                return this._OriginalJobId;
            }
            set
            {
                this.OnOriginalJobIdChanging(value);
                this._OriginalJobId = value;
                this.OnOriginalJobIdChanged();
                this.OnPropertyChanged("OriginalJobId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.Guid> _OriginalJobId;
        partial void OnOriginalJobIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnOriginalJobIdChanged();
        /// <summary>
        /// There are no comments for Property RetryInformation in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string RetryInformation
        {
            get
            {
                return this._RetryInformation;
            }
            set
            {
                this.OnRetryInformationChanging(value);
                this._RetryInformation = value;
                this.OnRetryInformationChanged();
                this.OnPropertyChanged("RetryInformation");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _RetryInformation;
        partial void OnRetryInformationChanging(string value);
        partial void OnRetryInformationChanged();
        /// <summary>
        /// There are no comments for Property TypeOfJob in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string TypeOfJob
        {
            get
            {
                return this._TypeOfJob;
            }
            set
            {
                this.OnTypeOfJobChanging(value);
                this._TypeOfJob = value;
                this.OnTypeOfJobChanged();
                this.OnPropertyChanged("TypeOfJob");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _TypeOfJob;
        partial void OnTypeOfJobChanging(string value);
        partial void OnTypeOfJobChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.MasterPageGalleryItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("MasterPageGallery")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class MasterPageGalleryItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MasterPageGalleryItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static MasterPageGalleryItem CreateMasterPageGalleryItem(int ID)
        {
            MasterPageGalleryItem masterPageGalleryItem = new MasterPageGalleryItem();
            masterPageGalleryItem.Id = ID;
            return masterPageGalleryItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ApproverComments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApproverComments
        {
            get
            {
                return this._ApproverComments;
            }
            set
            {
                this.OnApproverCommentsChanging(value);
                this._ApproverComments = value;
                this.OnApproverCommentsChanged();
                this.OnPropertyChanged("ApproverComments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApproverComments;
        partial void OnApproverCommentsChanging(string value);
        partial void OnApproverCommentsChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property ContactId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ContactId
        {
            get
            {
                return this._ContactId;
            }
            set
            {
                this.OnContactIdChanging(value);
                this._ContactId = value;
                this.OnContactIdChanged();
                this.OnPropertyChanged("ContactId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ContactId;
        partial void OnContactIdChanging(global::System.Nullable<int> value);
        partial void OnContactIdChanged();
        /// <summary>
        /// There are no comments for Property PreviewImage in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PreviewImage
        {
            get
            {
                return this._PreviewImage;
            }
            set
            {
                this.OnPreviewImageChanging(value);
                this._PreviewImage = value;
                this.OnPreviewImageChanged();
                this.OnPropertyChanged("PreviewImage");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PreviewImage;
        partial void OnPreviewImageChanging(string value);
        partial void OnPreviewImageChanged();
        /// <summary>
        /// There are no comments for Property HiddenPage in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> HiddenPage
        {
            get
            {
                return this._HiddenPage;
            }
            set
            {
                this.OnHiddenPageChanging(value);
                this._HiddenPage = value;
                this.OnHiddenPageChanged();
                this.OnPropertyChanged("HiddenPage");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _HiddenPage;
        partial void OnHiddenPageChanging(global::System.Nullable<bool> value);
        partial void OnHiddenPageChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property AuthenticatedCacheProfileId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> AuthenticatedCacheProfileId
        {
            get
            {
                return this._AuthenticatedCacheProfileId;
            }
            set
            {
                this.OnAuthenticatedCacheProfileIdChanging(value);
                this._AuthenticatedCacheProfileId = value;
                this.OnAuthenticatedCacheProfileIdChanged();
                this.OnPropertyChanged("AuthenticatedCacheProfileId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _AuthenticatedCacheProfileId;
        partial void OnAuthenticatedCacheProfileIdChanging(global::System.Nullable<int> value);
        partial void OnAuthenticatedCacheProfileIdChanged();
        /// <summary>
        /// There are no comments for Property AnonymousCacheProfileId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> AnonymousCacheProfileId
        {
            get
            {
                return this._AnonymousCacheProfileId;
            }
            set
            {
                this.OnAnonymousCacheProfileIdChanging(value);
                this._AnonymousCacheProfileId = value;
                this.OnAnonymousCacheProfileIdChanged();
                this.OnPropertyChanged("AnonymousCacheProfileId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _AnonymousCacheProfileId;
        partial void OnAnonymousCacheProfileIdChanging(global::System.Nullable<int> value);
        partial void OnAnonymousCacheProfileIdChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for CompatibleUIVersionS in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<MasterPageGalleryCompatibleUIVersionSValue> CompatibleUIVersionS
        {
            get
            {
                return this._CompatibleUIVersionS;
            }
            set
            {
                this._CompatibleUIVersionS = value;
                this.OnPropertyChanged("CompatibleUIVersionS");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<MasterPageGalleryCompatibleUIVersionSValue> _CompatibleUIVersionS = new global::System.Data.Services.Client.DataServiceCollection<MasterPageGalleryCompatibleUIVersionSValue>(null, System.Data.Services.Client.TrackingMode.None);
        /// <summary>
        /// There are no comments for Contact in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem Contact
        {
            get
            {
                return this._Contact;
            }
            set
            {
                this._Contact = value;
                this.OnPropertyChanged("Contact");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _Contact;
        /// <summary>
        /// There are no comments for AuthenticatedCacheProfile in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public CacheProfilesItem AuthenticatedCacheProfile
        {
            get
            {
                return this._AuthenticatedCacheProfile;
            }
            set
            {
                this._AuthenticatedCacheProfile = value;
                this.OnPropertyChanged("AuthenticatedCacheProfile");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private CacheProfilesItem _AuthenticatedCacheProfile;
        /// <summary>
        /// There are no comments for AnonymousCacheProfile in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public CacheProfilesItem AnonymousCacheProfile
        {
            get
            {
                return this._AnonymousCacheProfile;
            }
            set
            {
                this._AnonymousCacheProfile = value;
                this.OnPropertyChanged("AnonymousCacheProfile");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private CacheProfilesItem _AnonymousCacheProfile;
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.MasterPageGalleryCompatibleUIVersionSValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("MasterPageGalleryCompatibleUIVersionS")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class MasterPageGalleryCompatibleUIVersionSValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MasterPageGalleryCompatibleUIVersionSValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static MasterPageGalleryCompatibleUIVersionSValue CreateMasterPageGalleryCompatibleUIVersionSValue(string value)
        {
            MasterPageGalleryCompatibleUIVersionSValue masterPageGalleryCompatibleUIVersionSValue = new MasterPageGalleryCompatibleUIVersionSValue();
            masterPageGalleryCompatibleUIVersionSValue.Value = value;
            return masterPageGalleryCompatibleUIVersionSValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.NotificationListItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("NotificationList")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class NotificationListItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new NotificationListItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static NotificationListItem CreateNotificationListItem(int ID)
        {
            NotificationListItem notificationListItem = new NotificationListItem();
            notificationListItem.Id = ID;
            return notificationListItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property PageURL in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PageURL
        {
            get
            {
                return this._PageURL;
            }
            set
            {
                this.OnPageURLChanging(value);
                this._PageURL = value;
                this.OnPageURLChanged();
                this.OnPropertyChanged("PageURL");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PageURL;
        partial void OnPageURLChanging(string value);
        partial void OnPageURLChanged();
        /// <summary>
        /// There are no comments for Property DeliveryDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> DeliveryDate
        {
            get
            {
                return this._DeliveryDate;
            }
            set
            {
                this.OnDeliveryDateChanging(value);
                this._DeliveryDate = value;
                this.OnDeliveryDateChanged();
                this.OnPropertyChanged("DeliveryDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _DeliveryDate;
        partial void OnDeliveryDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnDeliveryDateChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ProjectsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Projects")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class ProjectsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ProjectsItem CreateProjectsItem(int ID)
        {
            ProjectsItem projectsItem = new ProjectsItem();
            projectsItem.Id = ID;
            return projectsItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _DueDate;
        partial void OnDueDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnDueDateChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> PrimaryContactId
        {
            get
            {
                return this._PrimaryContactId;
            }
            set
            {
                this.OnPrimaryContactIdChanging(value);
                this._PrimaryContactId = value;
                this.OnPrimaryContactIdChanged();
                this.OnPropertyChanged("PrimaryContactId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _PrimaryContactId;
        partial void OnPrimaryContactIdChanging(global::System.Nullable<int> value);
        partial void OnPrimaryContactIdChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for PrimaryContact in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public EmployeesItem PrimaryContact
        {
            get
            {
                return this._PrimaryContact;
            }
            set
            {
                this._PrimaryContact = value;
                this.OnPropertyChanged("PrimaryContact");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private EmployeesItem _PrimaryContact;
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.QuickDeployItemsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("QuickDeployItems")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class QuickDeployItemsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new QuickDeployItemsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static QuickDeployItemsItem CreateQuickDeployItemsItem(int ID)
        {
            QuickDeployItemsItem quickDeployItemsItem = new QuickDeployItemsItem();
            quickDeployItemsItem.Id = ID;
            return quickDeployItemsItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property JobId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.Guid> JobId
        {
            get
            {
                return this._JobId;
            }
            set
            {
                this.OnJobIdChanging(value);
                this._JobId = value;
                this.OnJobIdChanged();
                this.OnPropertyChanged("JobId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.Guid> _JobId;
        partial void OnJobIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnJobIdChanged();
        /// <summary>
        /// There are no comments for Property ItemUrl in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ItemUrl
        {
            get
            {
                return this._ItemUrl;
            }
            set
            {
                this.OnItemUrlChanging(value);
                this._ItemUrl = value;
                this.OnItemUrlChanged();
                this.OnPropertyChanged("ItemUrl");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ItemUrl;
        partial void OnItemUrlChanging(string value);
        partial void OnItemUrlChanged();
        /// <summary>
        /// There are no comments for Property ItemType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ItemType
        {
            get
            {
                return this._ItemType;
            }
            set
            {
                this.OnItemTypeChanging(value);
                this._ItemType = value;
                this.OnItemTypeChanged();
                this.OnPropertyChanged("ItemType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ItemType;
        partial void OnItemTypeChanging(global::System.Nullable<int> value);
        partial void OnItemTypeChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.RelationshipsListItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("RelationshipsList")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class RelationshipsListItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RelationshipsListItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static RelationshipsListItem CreateRelationshipsListItem(int ID)
        {
            RelationshipsListItem relationshipsListItem = new RelationshipsListItem();
            relationshipsListItem.Id = ID;
            return relationshipsListItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property GroupGuid in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.Guid> GroupGuid
        {
            get
            {
                return this._GroupGuid;
            }
            set
            {
                this.OnGroupGuidChanging(value);
                this._GroupGuid = value;
                this.OnGroupGuidChanged();
                this.OnPropertyChanged("GroupGuid");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.Guid> _GroupGuid;
        partial void OnGroupGuidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnGroupGuidChanged();
        /// <summary>
        /// There are no comments for Property ObjectID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ObjectID
        {
            get
            {
                return this._ObjectID;
            }
            set
            {
                this.OnObjectIDChanging(value);
                this._ObjectID = value;
                this.OnObjectIDChanged();
                this.OnPropertyChanged("ObjectID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ObjectID;
        partial void OnObjectIDChanging(string value);
        partial void OnObjectIDChanged();
        /// <summary>
        /// There are no comments for Property ParentAreaID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ParentAreaID
        {
            get
            {
                return this._ParentAreaID;
            }
            set
            {
                this.OnParentAreaIDChanging(value);
                this._ParentAreaID = value;
                this.OnParentAreaIDChanged();
                this.OnPropertyChanged("ParentAreaID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ParentAreaID;
        partial void OnParentAreaIDChanging(string value);
        partial void OnParentAreaIDChanged();
        /// <summary>
        /// There are no comments for Property Deleted in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> Deleted
        {
            get
            {
                return this._Deleted;
            }
            set
            {
                this.OnDeletedChanging(value);
                this._Deleted = value;
                this.OnDeletedChanged();
                this.OnPropertyChanged("Deleted");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _Deleted;
        partial void OnDeletedChanging(global::System.Nullable<bool> value);
        partial void OnDeletedChanged();
        /// <summary>
        /// There are no comments for Property LastPropagatedSourcePageVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string LastPropagatedSourcePageVersion
        {
            get
            {
                return this._LastPropagatedSourcePageVersion;
            }
            set
            {
                this.OnLastPropagatedSourcePageVersionChanging(value);
                this._LastPropagatedSourcePageVersion = value;
                this.OnLastPropagatedSourcePageVersionChanged();
                this.OnPropertyChanged("LastPropagatedSourcePageVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _LastPropagatedSourcePageVersion;
        partial void OnLastPropagatedSourcePageVersionChanging(string value);
        partial void OnLastPropagatedSourcePageVersionChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ReportingMetadataItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ReportingMetadata")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class ReportingMetadataItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReportingMetadataItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ReportingMetadataItem CreateReportingMetadataItem(int ID)
        {
            ReportingMetadataItem reportingMetadataItem = new ReportingMetadataItem();
            reportingMetadataItem.Id = ID;
            return reportingMetadataItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property IconURL in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IconURL
        {
            get
            {
                return this._IconURL;
            }
            set
            {
                this.OnIconURLChanging(value);
                this._IconURL = value;
                this.OnIconURLChanged();
                this.OnPropertyChanged("IconURL");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IconURL;
        partial void OnIconURLChanging(string value);
        partial void OnIconURLChanged();
        /// <summary>
        /// There are no comments for Property TemplateID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.Guid> TemplateID
        {
            get
            {
                return this._TemplateID;
            }
            set
            {
                this.OnTemplateIDChanging(value);
                this._TemplateID = value;
                this.OnTemplateIDChanged();
                this.OnPropertyChanged("TemplateID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.Guid> _TemplateID;
        partial void OnTemplateIDChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnTemplateIDChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property Subcategory in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Subcategory
        {
            get
            {
                return this._Subcategory;
            }
            set
            {
                this.OnSubcategoryChanging(value);
                this._Subcategory = value;
                this.OnSubcategoryChanged();
                this.OnPropertyChanged("Subcategory");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Subcategory;
        partial void OnSubcategoryChanging(string value);
        partial void OnSubcategoryChanged();
        /// <summary>
        /// There are no comments for Property Locale in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Locale
        {
            get
            {
                return this._Locale;
            }
            set
            {
                this.OnLocaleChanging(value);
                this._Locale = value;
                this.OnLocaleChanged();
                this.OnPropertyChanged("Locale");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Locale;
        partial void OnLocaleChanging(global::System.Nullable<int> value);
        partial void OnLocaleChanged();
        /// <summary>
        /// There are no comments for Property QueryAssembly in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string QueryAssembly
        {
            get
            {
                return this._QueryAssembly;
            }
            set
            {
                this.OnQueryAssemblyChanging(value);
                this._QueryAssembly = value;
                this.OnQueryAssemblyChanged();
                this.OnPropertyChanged("QueryAssembly");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _QueryAssembly;
        partial void OnQueryAssemblyChanging(string value);
        partial void OnQueryAssemblyChanged();
        /// <summary>
        /// There are no comments for Property QueryClass in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string QueryClass
        {
            get
            {
                return this._QueryClass;
            }
            set
            {
                this.OnQueryClassChanging(value);
                this._QueryClass = value;
                this.OnQueryClassChanged();
                this.OnPropertyChanged("QueryClass");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _QueryClass;
        partial void OnQueryClassChanging(string value);
        partial void OnQueryClassChanged();
        /// <summary>
        /// There are no comments for Property QueryBuilderURL in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string QueryBuilderURL
        {
            get
            {
                return this._QueryBuilderURL;
            }
            set
            {
                this.OnQueryBuilderURLChanging(value);
                this._QueryBuilderURL = value;
                this.OnQueryBuilderURLChanged();
                this.OnPropertyChanged("QueryBuilderURL");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _QueryBuilderURL;
        partial void OnQueryBuilderURLChanging(string value);
        partial void OnQueryBuilderURLChanged();
        /// <summary>
        /// There are no comments for Property InjectionAssembly in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string InjectionAssembly
        {
            get
            {
                return this._InjectionAssembly;
            }
            set
            {
                this.OnInjectionAssemblyChanging(value);
                this._InjectionAssembly = value;
                this.OnInjectionAssemblyChanged();
                this.OnPropertyChanged("InjectionAssembly");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _InjectionAssembly;
        partial void OnInjectionAssemblyChanging(string value);
        partial void OnInjectionAssemblyChanged();
        /// <summary>
        /// There are no comments for Property InjectionClass in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string InjectionClass
        {
            get
            {
                return this._InjectionClass;
            }
            set
            {
                this.OnInjectionClassChanging(value);
                this._InjectionClass = value;
                this.OnInjectionClassChanged();
                this.OnPropertyChanged("InjectionClass");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _InjectionClass;
        partial void OnInjectionClassChanging(string value);
        partial void OnInjectionClassChanged();
        /// <summary>
        /// There are no comments for Property HTTPContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string HTTPContentType
        {
            get
            {
                return this._HTTPContentType;
            }
            set
            {
                this.OnHTTPContentTypeChanging(value);
                this._HTTPContentType = value;
                this.OnHTTPContentTypeChanged();
                this.OnPropertyChanged("HTTPContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _HTTPContentType;
        partial void OnHTTPContentTypeChanging(string value);
        partial void OnHTTPContentTypeChanged();
        /// <summary>
        /// There are no comments for Property DefaultQuery in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string DefaultQuery
        {
            get
            {
                return this._DefaultQuery;
            }
            set
            {
                this.OnDefaultQueryChanging(value);
                this._DefaultQuery = value;
                this.OnDefaultQueryChanged();
                this.OnPropertyChanged("DefaultQuery");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _DefaultQuery;
        partial void OnDefaultQueryChanging(string value);
        partial void OnDefaultQueryChanged();
        /// <summary>
        /// There are no comments for Property DefaultInjectionParameters in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string DefaultInjectionParameters
        {
            get
            {
                return this._DefaultInjectionParameters;
            }
            set
            {
                this.OnDefaultInjectionParametersChanging(value);
                this._DefaultInjectionParameters = value;
                this.OnDefaultInjectionParametersChanged();
                this.OnPropertyChanged("DefaultInjectionParameters");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _DefaultInjectionParameters;
        partial void OnDefaultInjectionParametersChanging(string value);
        partial void OnDefaultInjectionParametersChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ReportingTemplatesItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ReportingTemplates")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class ReportingTemplatesItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReportingTemplatesItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ReportingTemplatesItem CreateReportingTemplatesItem(int ID)
        {
            ReportingTemplatesItem reportingTemplatesItem = new ReportingTemplatesItem();
            reportingTemplatesItem.Id = ID;
            return reportingTemplatesItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ReusableContentItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ReusableContent")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class ReusableContentItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReusableContentItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ReusableContentItem CreateReusableContentItem(int ID)
        {
            ReusableContentItem reusableContentItem = new ReusableContentItem();
            reusableContentItem.Id = ID;
            return reusableContentItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Comments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this.OnCommentsChanging(value);
                this._Comments = value;
                this.OnCommentsChanged();
                this.OnPropertyChanged("Comments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Comments;
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
        /// <summary>
        /// There are no comments for Property ContentCategoryValue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentCategoryValue
        {
            get
            {
                return this._ContentCategoryValue;
            }
            set
            {
                this.OnContentCategoryValueChanging(value);
                this._ContentCategoryValue = value;
                this.OnContentCategoryValueChanged();
                this.OnPropertyChanged("ContentCategoryValue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentCategoryValue;
        partial void OnContentCategoryValueChanging(string value);
        partial void OnContentCategoryValueChanged();
        /// <summary>
        /// There are no comments for Property AutomaticUpdate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> AutomaticUpdate
        {
            get
            {
                return this._AutomaticUpdate;
            }
            set
            {
                this.OnAutomaticUpdateChanging(value);
                this._AutomaticUpdate = value;
                this.OnAutomaticUpdateChanged();
                this.OnPropertyChanged("AutomaticUpdate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _AutomaticUpdate;
        partial void OnAutomaticUpdateChanging(global::System.Nullable<bool> value);
        partial void OnAutomaticUpdateChanged();
        /// <summary>
        /// There are no comments for Property ShowInDropDownMenu in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> ShowInDropDownMenu
        {
            get
            {
                return this._ShowInDropDownMenu;
            }
            set
            {
                this.OnShowInDropDownMenuChanging(value);
                this._ShowInDropDownMenu = value;
                this.OnShowInDropDownMenuChanged();
                this.OnPropertyChanged("ShowInDropDownMenu");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _ShowInDropDownMenu;
        partial void OnShowInDropDownMenuChanging(global::System.Nullable<bool> value);
        partial void OnShowInDropDownMenuChanged();
        /// <summary>
        /// There are no comments for Property ReusableText in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ReusableText
        {
            get
            {
                return this._ReusableText;
            }
            set
            {
                this.OnReusableTextChanging(value);
                this._ReusableText = value;
                this.OnReusableTextChanged();
                this.OnPropertyChanged("ReusableText");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ReusableText;
        partial void OnReusableTextChanging(string value);
        partial void OnReusableTextChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for ContentCategory in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ReusableContentContentCategoryValue ContentCategory
        {
            get
            {
                return this._ContentCategory;
            }
            set
            {
                this._ContentCategory = value;
                this.OnPropertyChanged("ContentCategory");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private ReusableContentContentCategoryValue _ContentCategory;
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ReusableContentContentCategoryValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ReusableContentContentCategory")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class ReusableContentContentCategoryValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReusableContentContentCategoryValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ReusableContentContentCategoryValue CreateReusableContentContentCategoryValue(string value)
        {
            ReusableContentContentCategoryValue reusableContentContentCategoryValue = new ReusableContentContentCategoryValue();
            reusableContentContentCategoryValue.Value = value;
            return reusableContentContentCategoryValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.SharedDocumentsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("SharedDocuments")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class SharedDocumentsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SharedDocumentsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static SharedDocumentsItem CreateSharedDocumentsItem(int ID)
        {
            SharedDocumentsItem sharedDocumentsItem = new SharedDocumentsItem();
            sharedDocumentsItem.Id = ID;
            return sharedDocumentsItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.SiteAssetsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("SiteAssets")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class SiteAssetsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SiteAssetsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static SiteAssetsItem CreateSiteAssetsItem(int ID)
        {
            SiteAssetsItem siteAssetsItem = new SiteAssetsItem();
            siteAssetsItem.Id = ID;
            return siteAssetsItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.SiteCollectionDocumentsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("SiteCollectionDocuments")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class SiteCollectionDocumentsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SiteCollectionDocumentsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static SiteCollectionDocumentsItem CreateSiteCollectionDocumentsItem(int ID)
        {
            SiteCollectionDocumentsItem siteCollectionDocumentsItem = new SiteCollectionDocumentsItem();
            siteCollectionDocumentsItem.Id = ID;
            return siteCollectionDocumentsItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.SiteCollectionImagesItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("SiteCollectionImages")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class SiteCollectionImagesItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SiteCollectionImagesItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static SiteCollectionImagesItem CreateSiteCollectionImagesItem(int ID)
        {
            SiteCollectionImagesItem siteCollectionImagesItem = new SiteCollectionImagesItem();
            siteCollectionImagesItem.Id = ID;
            return siteCollectionImagesItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Author in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Author
        {
            get
            {
                return this._Author;
            }
            set
            {
                this.OnAuthorChanging(value);
                this._Author = value;
                this.OnAuthorChanged();
                this.OnPropertyChanged("Author");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Author;
        partial void OnAuthorChanging(string value);
        partial void OnAuthorChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Width in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Width
        {
            get
            {
                return this._Width;
            }
            set
            {
                this.OnWidthChanging(value);
                this._Width = value;
                this.OnWidthChanged();
                this.OnPropertyChanged("Width");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Width;
        partial void OnWidthChanging(global::System.Nullable<int> value);
        partial void OnWidthChanged();
        /// <summary>
        /// There are no comments for Property Height in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Height
        {
            get
            {
                return this._Height;
            }
            set
            {
                this.OnHeightChanging(value);
                this._Height = value;
                this.OnHeightChanged();
                this.OnPropertyChanged("Height");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Height;
        partial void OnHeightChanging(global::System.Nullable<int> value);
        partial void OnHeightChanged();
        /// <summary>
        /// There are no comments for Property DatePictureTaken in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> DatePictureTaken
        {
            get
            {
                return this._DatePictureTaken;
            }
            set
            {
                this.OnDatePictureTakenChanging(value);
                this._DatePictureTaken = value;
                this.OnDatePictureTakenChanged();
                this.OnPropertyChanged("DatePictureTaken");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _DatePictureTaken;
        partial void OnDatePictureTakenChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnDatePictureTakenChanged();
        /// <summary>
        /// There are no comments for Property Comments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this.OnCommentsChanging(value);
                this._Comments = value;
                this.OnCommentsChanged();
                this.OnPropertyChanged("Comments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Comments;
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
        /// <summary>
        /// There are no comments for Property Keywords in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Keywords
        {
            get
            {
                return this._Keywords;
            }
            set
            {
                this.OnKeywordsChanging(value);
                this._Keywords = value;
                this.OnKeywordsChanged();
                this.OnPropertyChanged("Keywords");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Keywords;
        partial void OnKeywordsChanging(string value);
        partial void OnKeywordsChanged();
        /// <summary>
        /// There are no comments for Property Copyright in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Copyright
        {
            get
            {
                return this._Copyright;
            }
            set
            {
                this.OnCopyrightChanging(value);
                this._Copyright = value;
                this.OnCopyrightChanged();
                this.OnPropertyChanged("Copyright");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Copyright;
        partial void OnCopyrightChanging(string value);
        partial void OnCopyrightChanged();
        /// <summary>
        /// There are no comments for Property PreviewImageURL in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PreviewImageURL
        {
            get
            {
                return this._PreviewImageURL;
            }
            set
            {
                this.OnPreviewImageURLChanging(value);
                this._PreviewImageURL = value;
                this.OnPreviewImageURLChanged();
                this.OnPropertyChanged("PreviewImageURL");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PreviewImageURL;
        partial void OnPreviewImageURLChanging(string value);
        partial void OnPreviewImageURLChanged();
        /// <summary>
        /// There are no comments for Property LengthSeconds in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> LengthSeconds
        {
            get
            {
                return this._LengthSeconds;
            }
            set
            {
                this.OnLengthSecondsChanging(value);
                this._LengthSeconds = value;
                this.OnLengthSecondsChanged();
                this.OnPropertyChanged("LengthSeconds");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _LengthSeconds;
        partial void OnLengthSecondsChanging(global::System.Nullable<int> value);
        partial void OnLengthSecondsChanged();
        /// <summary>
        /// There are no comments for Property FrameWidth in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> FrameWidth
        {
            get
            {
                return this._FrameWidth;
            }
            set
            {
                this.OnFrameWidthChanging(value);
                this._FrameWidth = value;
                this.OnFrameWidthChanged();
                this.OnPropertyChanged("FrameWidth");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _FrameWidth;
        partial void OnFrameWidthChanging(global::System.Nullable<int> value);
        partial void OnFrameWidthChanged();
        /// <summary>
        /// There are no comments for Property FrameHeight in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> FrameHeight
        {
            get
            {
                return this._FrameHeight;
            }
            set
            {
                this.OnFrameHeightChanging(value);
                this._FrameHeight = value;
                this.OnFrameHeightChanged();
                this.OnPropertyChanged("FrameHeight");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _FrameHeight;
        partial void OnFrameHeightChanging(global::System.Nullable<int> value);
        partial void OnFrameHeightChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.SitePagesItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("SitePages")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class SitePagesItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SitePagesItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static SitePagesItem CreateSitePagesItem(int ID)
        {
            SitePagesItem sitePagesItem = new SitePagesItem();
            sitePagesItem.Id = ID;
            return sitePagesItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property WikiContent in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string WikiContent
        {
            get
            {
                return this._WikiContent;
            }
            set
            {
                this.OnWikiContentChanging(value);
                this._WikiContent = value;
                this.OnWikiContentChanged();
                this.OnPropertyChanged("WikiContent");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _WikiContent;
        partial void OnWikiContentChanging(string value);
        partial void OnWikiContentChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.SolutionGalleryItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("SolutionGallery")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class SolutionGalleryItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SolutionGalleryItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static SolutionGalleryItem CreateSolutionGalleryItem(int ID)
        {
            SolutionGalleryItem solutionGalleryItem = new SolutionGalleryItem();
            solutionGalleryItem.Id = ID;
            return solutionGalleryItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property SolutionId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.Guid> SolutionId
        {
            get
            {
                return this._SolutionId;
            }
            set
            {
                this.OnSolutionIdChanging(value);
                this._SolutionId = value;
                this.OnSolutionIdChanged();
                this.OnPropertyChanged("SolutionId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.Guid> _SolutionId;
        partial void OnSolutionIdChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnSolutionIdChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Hash in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Hash
        {
            get
            {
                return this._Hash;
            }
            set
            {
                this.OnHashChanging(value);
                this._Hash = value;
                this.OnHashChanged();
                this.OnPropertyChanged("Hash");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Hash;
        partial void OnHashChanging(string value);
        partial void OnHashChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.StyleLibraryItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("StyleLibrary")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class StyleLibraryItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new StyleLibraryItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static StyleLibraryItem CreateStyleLibraryItem(int ID)
        {
            StyleLibraryItem styleLibraryItem = new StyleLibraryItem();
            styleLibraryItem.Id = ID;
            return styleLibraryItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.SuggestedContentBrowserLocationsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("SuggestedContentBrowserLocations")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class SuggestedContentBrowserLocationsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SuggestedContentBrowserLocationsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static SuggestedContentBrowserLocationsItem CreateSuggestedContentBrowserLocationsItem(int ID)
        {
            SuggestedContentBrowserLocationsItem suggestedContentBrowserLocationsItem = new SuggestedContentBrowserLocationsItem();
            suggestedContentBrowserLocationsItem.Id = ID;
            return suggestedContentBrowserLocationsItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Url in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Url
        {
            get
            {
                return this._Url;
            }
            set
            {
                this.OnUrlChanging(value);
                this._Url = value;
                this.OnUrlChanged();
                this.OnPropertyChanged("Url");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Url;
        partial void OnUrlChanging(string value);
        partial void OnUrlChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.TasksItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Tasks")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class TasksItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TasksItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static TasksItem CreateTasksItem(int ID)
        {
            TasksItem tasksItem = new TasksItem();
            tasksItem.Id = ID;
            return tasksItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property PriorityValue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PriorityValue
        {
            get
            {
                return this._PriorityValue;
            }
            set
            {
                this.OnPriorityValueChanging(value);
                this._PriorityValue = value;
                this.OnPriorityValueChanged();
                this.OnPropertyChanged("PriorityValue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PriorityValue;
        partial void OnPriorityValueChanging(string value);
        partial void OnPriorityValueChanged();
        /// <summary>
        /// There are no comments for Property StatusValue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string StatusValue
        {
            get
            {
                return this._StatusValue;
            }
            set
            {
                this.OnStatusValueChanging(value);
                this._StatusValue = value;
                this.OnStatusValueChanged();
                this.OnPropertyChanged("StatusValue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _StatusValue;
        partial void OnStatusValueChanging(string value);
        partial void OnStatusValueChanged();
        /// <summary>
        /// There are no comments for Property Complete in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<double> Complete
        {
            get
            {
                return this._Complete;
            }
            set
            {
                this.OnCompleteChanging(value);
                this._Complete = value;
                this.OnCompleteChanged();
                this.OnPropertyChanged("Complete");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<double> _Complete;
        partial void OnCompleteChanging(global::System.Nullable<double> value);
        partial void OnCompleteChanged();
        /// <summary>
        /// There are no comments for Property AssignedToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> AssignedToId
        {
            get
            {
                return this._AssignedToId;
            }
            set
            {
                this.OnAssignedToIdChanging(value);
                this._AssignedToId = value;
                this.OnAssignedToIdChanged();
                this.OnPropertyChanged("AssignedToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _AssignedToId;
        partial void OnAssignedToIdChanging(global::System.Nullable<int> value);
        partial void OnAssignedToIdChanged();
        /// <summary>
        /// There are no comments for Property TaskGroupId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> TaskGroupId
        {
            get
            {
                return this._TaskGroupId;
            }
            set
            {
                this.OnTaskGroupIdChanging(value);
                this._TaskGroupId = value;
                this.OnTaskGroupIdChanged();
                this.OnPropertyChanged("TaskGroupId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _TaskGroupId;
        partial void OnTaskGroupIdChanging(global::System.Nullable<int> value);
        partial void OnTaskGroupIdChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _StartDate;
        partial void OnStartDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _DueDate;
        partial void OnDueDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnDueDateChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        /// <summary>
        /// There are no comments for Predecessors in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<TasksItem> Predecessors
        {
            get
            {
                return this._Predecessors;
            }
            set
            {
                this._Predecessors = value;
                this.OnPropertyChanged("Predecessors");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<TasksItem> _Predecessors = new global::System.Data.Services.Client.DataServiceCollection<TasksItem>(null, System.Data.Services.Client.TrackingMode.None);
        /// <summary>
        /// There are no comments for Priority in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public TasksPriorityValue Priority
        {
            get
            {
                return this._Priority;
            }
            set
            {
                this._Priority = value;
                this.OnPropertyChanged("Priority");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private TasksPriorityValue _Priority;
        /// <summary>
        /// There are no comments for Status in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public TasksStatusValue Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this._Status = value;
                this.OnPropertyChanged("Status");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private TasksStatusValue _Status;
        /// <summary>
        /// There are no comments for AssignedTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem AssignedTo
        {
            get
            {
                return this._AssignedTo;
            }
            set
            {
                this._AssignedTo = value;
                this.OnPropertyChanged("AssignedTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _AssignedTo;
        /// <summary>
        /// There are no comments for TaskGroup in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem TaskGroup
        {
            get
            {
                return this._TaskGroup;
            }
            set
            {
                this._TaskGroup = value;
                this.OnPropertyChanged("TaskGroup");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _TaskGroup;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.TasksPriorityValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("TasksPriority")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class TasksPriorityValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TasksPriorityValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static TasksPriorityValue CreateTasksPriorityValue(string value)
        {
            TasksPriorityValue tasksPriorityValue = new TasksPriorityValue();
            tasksPriorityValue.Value = value;
            return tasksPriorityValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.TasksStatusValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("TasksStatus")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class TasksStatusValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TasksStatusValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static TasksStatusValue CreateTasksStatusValue(string value)
        {
            TasksStatusValue tasksStatusValue = new TasksStatusValue();
            tasksStatusValue.Value = value;
            return tasksStatusValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.TaxonomyHiddenListItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("TaxonomyHiddenList")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class TaxonomyHiddenListItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxonomyHiddenListItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static TaxonomyHiddenListItem CreateTaxonomyHiddenListItem(int ID)
        {
            TaxonomyHiddenListItem taxonomyHiddenListItem = new TaxonomyHiddenListItem();
            taxonomyHiddenListItem.Id = ID;
            return taxonomyHiddenListItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property IdForTermStore in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdForTermStore
        {
            get
            {
                return this._IdForTermStore;
            }
            set
            {
                this.OnIdForTermStoreChanging(value);
                this._IdForTermStore = value;
                this.OnIdForTermStoreChanged();
                this.OnPropertyChanged("IdForTermStore");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdForTermStore;
        partial void OnIdForTermStoreChanging(string value);
        partial void OnIdForTermStoreChanged();
        /// <summary>
        /// There are no comments for Property IdForTerm in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdForTerm
        {
            get
            {
                return this._IdForTerm;
            }
            set
            {
                this.OnIdForTermChanging(value);
                this._IdForTerm = value;
                this.OnIdForTermChanged();
                this.OnPropertyChanged("IdForTerm");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdForTerm;
        partial void OnIdForTermChanging(string value);
        partial void OnIdForTermChanged();
        /// <summary>
        /// There are no comments for Property IdForTermSet in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdForTermSet
        {
            get
            {
                return this._IdForTermSet;
            }
            set
            {
                this.OnIdForTermSetChanging(value);
                this._IdForTermSet = value;
                this.OnIdForTermSetChanged();
                this.OnPropertyChanged("IdForTermSet");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdForTermSet;
        partial void OnIdForTermSetChanging(string value);
        partial void OnIdForTermSetChanged();
        /// <summary>
        /// There are no comments for Property Term in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Term
        {
            get
            {
                return this._Term;
            }
            set
            {
                this.OnTermChanging(value);
                this._Term = value;
                this.OnTermChanged();
                this.OnPropertyChanged("Term");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Term;
        partial void OnTermChanging(string value);
        partial void OnTermChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CatchAllData in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CatchAllData
        {
            get
            {
                return this._CatchAllData;
            }
            set
            {
                this.OnCatchAllDataChanging(value);
                this._CatchAllData = value;
                this.OnCatchAllDataChanged();
                this.OnPropertyChanged("CatchAllData");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CatchAllData;
        partial void OnCatchAllDataChanging(string value);
        partial void OnCatchAllDataChanged();
        /// <summary>
        /// There are no comments for Property CatchAllDataLabel in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CatchAllDataLabel
        {
            get
            {
                return this._CatchAllDataLabel;
            }
            set
            {
                this.OnCatchAllDataLabelChanging(value);
                this._CatchAllDataLabel = value;
                this.OnCatchAllDataLabelChanged();
                this.OnPropertyChanged("CatchAllDataLabel");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CatchAllDataLabel;
        partial void OnCatchAllDataLabelChanging(string value);
        partial void OnCatchAllDataLabelChanged();
        /// <summary>
        /// There are no comments for Property Term1033 in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Term1033
        {
            get
            {
                return this._Term1033;
            }
            set
            {
                this.OnTerm1033Changing(value);
                this._Term1033 = value;
                this.OnTerm1033Changed();
                this.OnPropertyChanged("Term1033");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Term1033;
        partial void OnTerm1033Changing(string value);
        partial void OnTerm1033Changed();
        /// <summary>
        /// There are no comments for Property Path1033 in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path1033
        {
            get
            {
                return this._Path1033;
            }
            set
            {
                this.OnPath1033Changing(value);
                this._Path1033 = value;
                this.OnPath1033Changed();
                this.OnPropertyChanged("Path1033");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path1033;
        partial void OnPath1033Changing(string value);
        partial void OnPath1033Changed();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path0 in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path0
        {
            get
            {
                return this._Path0;
            }
            set
            {
                this.OnPath0Changing(value);
                this._Path0 = value;
                this.OnPath0Changed();
                this.OnPropertyChanged("Path0");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path0;
        partial void OnPath0Changing(string value);
        partial void OnPath0Changed();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.TeamDiscussionItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("TeamDiscussion")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Subject", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class TeamDiscussionItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TeamDiscussionItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static TeamDiscussionItem CreateTeamDiscussionItem(int ID)
        {
            TeamDiscussionItem teamDiscussionItem = new TeamDiscussionItem();
            teamDiscussionItem.Id = ID;
            return teamDiscussionItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Subject in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Subject
        {
            get
            {
                return this._Subject;
            }
            set
            {
                this.OnSubjectChanging(value);
                this._Subject = value;
                this.OnSubjectChanged();
                this.OnPropertyChanged("Subject");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Subject;
        partial void OnSubjectChanging(string value);
        partial void OnSubjectChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property Body in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Body
        {
            get
            {
                return this._Body;
            }
            set
            {
                this.OnBodyChanging(value);
                this._Body = value;
                this.OnBodyChanged();
                this.OnPropertyChanged("Body");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Body;
        partial void OnBodyChanging(string value);
        partial void OnBodyChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById0 in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById0
        {
            get
            {
                return this._ModifiedById0;
            }
            set
            {
                this.OnModifiedById0Changing(value);
                this._ModifiedById0 = value;
                this.OnModifiedById0Changed();
                this.OnPropertyChanged("ModifiedById0");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById0;
        partial void OnModifiedById0Changing(global::System.Nullable<int> value);
        partial void OnModifiedById0Changed();
        /// <summary>
        /// There are no comments for Property LastUpdated in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> LastUpdated
        {
            get
            {
                return this._LastUpdated;
            }
            set
            {
                this.OnLastUpdatedChanging(value);
                this._LastUpdated = value;
                this.OnLastUpdatedChanged();
                this.OnPropertyChanged("LastUpdated");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _LastUpdated;
        partial void OnLastUpdatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnLastUpdatedChanged();
        /// <summary>
        /// There are no comments for Property EMailSender in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string EMailSender
        {
            get
            {
                return this._EMailSender;
            }
            set
            {
                this.OnEMailSenderChanging(value);
                this._EMailSender = value;
                this.OnEMailSenderChanged();
                this.OnPropertyChanged("EMailSender");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _EMailSender;
        partial void OnEMailSenderChanging(string value);
        partial void OnEMailSenderChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        /// <summary>
        /// There are no comments for ModifiedBy0 in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy0
        {
            get
            {
                return this._ModifiedBy0;
            }
            set
            {
                this._ModifiedBy0 = value;
                this.OnPropertyChanged("ModifiedBy0");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy0;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.ThemeGalleryItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ThemeGallery")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class ThemeGalleryItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ThemeGalleryItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ThemeGalleryItem CreateThemeGalleryItem(int ID)
        {
            ThemeGalleryItem themeGalleryItem = new ThemeGalleryItem();
            themeGalleryItem.Id = ID;
            return themeGalleryItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.UserInformationListItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("UserInformationList")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Name", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class UserInformationListItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UserInformationListItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static UserInformationListItem CreateUserInformationListItem(int ID)
        {
            UserInformationListItem userInformationListItem = new UserInformationListItem();
            userInformationListItem.Id = ID;
            return userInformationListItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Account in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Account
        {
            get
            {
                return this._Account;
            }
            set
            {
                this.OnAccountChanging(value);
                this._Account = value;
                this.OnAccountChanged();
                this.OnPropertyChanged("Account");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Account;
        partial void OnAccountChanging(string value);
        partial void OnAccountChanged();
        /// <summary>
        /// There are no comments for Property WorkEMail in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string WorkEMail
        {
            get
            {
                return this._WorkEMail;
            }
            set
            {
                this.OnWorkEMailChanging(value);
                this._WorkEMail = value;
                this.OnWorkEMailChanged();
                this.OnPropertyChanged("WorkEMail");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _WorkEMail;
        partial void OnWorkEMailChanging(string value);
        partial void OnWorkEMailChanged();
        /// <summary>
        /// There are no comments for Property MobilePhone in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string MobilePhone
        {
            get
            {
                return this._MobilePhone;
            }
            set
            {
                this.OnMobilePhoneChanging(value);
                this._MobilePhone = value;
                this.OnMobilePhoneChanged();
                this.OnPropertyChanged("MobilePhone");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _MobilePhone;
        partial void OnMobilePhoneChanging(string value);
        partial void OnMobilePhoneChanged();
        /// <summary>
        /// There are no comments for Property AboutMe in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string AboutMe
        {
            get
            {
                return this._AboutMe;
            }
            set
            {
                this.OnAboutMeChanging(value);
                this._AboutMe = value;
                this.OnAboutMeChanged();
                this.OnPropertyChanged("AboutMe");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _AboutMe;
        partial void OnAboutMeChanging(string value);
        partial void OnAboutMeChanged();
        /// <summary>
        /// There are no comments for Property SIPAddress in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SIPAddress
        {
            get
            {
                return this._SIPAddress;
            }
            set
            {
                this.OnSIPAddressChanging(value);
                this._SIPAddress = value;
                this.OnSIPAddressChanged();
                this.OnPropertyChanged("SIPAddress");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SIPAddress;
        partial void OnSIPAddressChanging(string value);
        partial void OnSIPAddressChanged();
        /// <summary>
        /// There are no comments for Property IsSiteAdmin in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsSiteAdmin
        {
            get
            {
                return this._IsSiteAdmin;
            }
            set
            {
                this.OnIsSiteAdminChanging(value);
                this._IsSiteAdmin = value;
                this.OnIsSiteAdminChanged();
                this.OnPropertyChanged("IsSiteAdmin");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsSiteAdmin;
        partial void OnIsSiteAdminChanging(global::System.Nullable<bool> value);
        partial void OnIsSiteAdminChanged();
        /// <summary>
        /// There are no comments for Property Deleted in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> Deleted
        {
            get
            {
                return this._Deleted;
            }
            set
            {
                this.OnDeletedChanging(value);
                this._Deleted = value;
                this.OnDeletedChanged();
                this.OnPropertyChanged("Deleted");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _Deleted;
        partial void OnDeletedChanging(global::System.Nullable<bool> value);
        partial void OnDeletedChanged();
        /// <summary>
        /// There are no comments for Property Picture in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Picture
        {
            get
            {
                return this._Picture;
            }
            set
            {
                this.OnPictureChanging(value);
                this._Picture = value;
                this.OnPictureChanged();
                this.OnPropertyChanged("Picture");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Picture;
        partial void OnPictureChanging(string value);
        partial void OnPictureChanged();
        /// <summary>
        /// There are no comments for Property Department in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this.OnDepartmentChanging(value);
                this._Department = value;
                this.OnDepartmentChanged();
                this.OnPropertyChanged("Department");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Department;
        partial void OnDepartmentChanging(string value);
        partial void OnDepartmentChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property FirstName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this._FirstName = value;
                this.OnFirstNameChanged();
                this.OnPropertyChanged("FirstName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for Property LastName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this._LastName = value;
                this.OnLastNameChanged();
                this.OnPropertyChanged("LastName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        /// <summary>
        /// There are no comments for Property WorkPhone in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string WorkPhone
        {
            get
            {
                return this._WorkPhone;
            }
            set
            {
                this.OnWorkPhoneChanging(value);
                this._WorkPhone = value;
                this.OnWorkPhoneChanged();
                this.OnPropertyChanged("WorkPhone");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _WorkPhone;
        partial void OnWorkPhoneChanging(string value);
        partial void OnWorkPhoneChanged();
        /// <summary>
        /// There are no comments for Property UserName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                this.OnUserNameChanging(value);
                this._UserName = value;
                this.OnUserNameChanged();
                this.OnPropertyChanged("UserName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _UserName;
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
        /// <summary>
        /// There are no comments for Property WebSite in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string WebSite
        {
            get
            {
                return this._WebSite;
            }
            set
            {
                this.OnWebSiteChanging(value);
                this._WebSite = value;
                this.OnWebSiteChanged();
                this.OnPropertyChanged("WebSite");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _WebSite;
        partial void OnWebSiteChanging(string value);
        partial void OnWebSiteChanged();
        /// <summary>
        /// There are no comments for Property AskMeAbout in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string AskMeAbout
        {
            get
            {
                return this._AskMeAbout;
            }
            set
            {
                this.OnAskMeAboutChanging(value);
                this._AskMeAbout = value;
                this.OnAskMeAboutChanged();
                this.OnPropertyChanged("AskMeAbout");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _AskMeAbout;
        partial void OnAskMeAboutChanging(string value);
        partial void OnAskMeAboutChanged();
        /// <summary>
        /// There are no comments for Property Office in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Office
        {
            get
            {
                return this._Office;
            }
            set
            {
                this.OnOfficeChanging(value);
                this._Office = value;
                this.OnOfficeChanged();
                this.OnPropertyChanged("Office");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Office;
        partial void OnOfficeChanging(string value);
        partial void OnOfficeChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.VariationLabelsItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("VariationLabels")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Label", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class VariationLabelsItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VariationLabelsItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static VariationLabelsItem CreateVariationLabelsItem(int ID)
        {
            VariationLabelsItem variationLabelsItem = new VariationLabelsItem();
            variationLabelsItem.Id = ID;
            return variationLabelsItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Label in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Label
        {
            get
            {
                return this._Label;
            }
            set
            {
                this.OnLabelChanging(value);
                this._Label = value;
                this.OnLabelChanged();
                this.OnPropertyChanged("Label");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Label;
        partial void OnLabelChanging(string value);
        partial void OnLabelChanged();
        /// <summary>
        /// There are no comments for Property FlagControlDisplayName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FlagControlDisplayName
        {
            get
            {
                return this._FlagControlDisplayName;
            }
            set
            {
                this.OnFlagControlDisplayNameChanging(value);
                this._FlagControlDisplayName = value;
                this.OnFlagControlDisplayNameChanged();
                this.OnPropertyChanged("FlagControlDisplayName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FlagControlDisplayName;
        partial void OnFlagControlDisplayNameChanging(string value);
        partial void OnFlagControlDisplayNameChanged();
        /// <summary>
        /// There are no comments for Property Language in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Language
        {
            get
            {
                return this._Language;
            }
            set
            {
                this.OnLanguageChanging(value);
                this._Language = value;
                this.OnLanguageChanged();
                this.OnPropertyChanged("Language");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Language;
        partial void OnLanguageChanging(string value);
        partial void OnLanguageChanged();
        /// <summary>
        /// There are no comments for Property Locale in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Locale
        {
            get
            {
                return this._Locale;
            }
            set
            {
                this.OnLocaleChanging(value);
                this._Locale = value;
                this.OnLocaleChanged();
                this.OnPropertyChanged("Locale");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Locale;
        partial void OnLocaleChanging(string value);
        partial void OnLocaleChanged();
        /// <summary>
        /// There are no comments for Property IsSource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsSource
        {
            get
            {
                return this._IsSource;
            }
            set
            {
                this.OnIsSourceChanging(value);
                this._IsSource = value;
                this.OnIsSourceChanged();
                this.OnPropertyChanged("IsSource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsSource;
        partial void OnIsSourceChanging(global::System.Nullable<bool> value);
        partial void OnIsSourceChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property HierarchyCreationModeValue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string HierarchyCreationModeValue
        {
            get
            {
                return this._HierarchyCreationModeValue;
            }
            set
            {
                this.OnHierarchyCreationModeValueChanging(value);
                this._HierarchyCreationModeValue = value;
                this.OnHierarchyCreationModeValueChanged();
                this.OnPropertyChanged("HierarchyCreationModeValue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _HierarchyCreationModeValue;
        partial void OnHierarchyCreationModeValueChanging(string value);
        partial void OnHierarchyCreationModeValueChanged();
        /// <summary>
        /// There are no comments for Property HierarchyIsCreated in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> HierarchyIsCreated
        {
            get
            {
                return this._HierarchyIsCreated;
            }
            set
            {
                this.OnHierarchyIsCreatedChanging(value);
                this._HierarchyIsCreated = value;
                this.OnHierarchyIsCreatedChanged();
                this.OnPropertyChanged("HierarchyIsCreated");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _HierarchyIsCreated;
        partial void OnHierarchyIsCreatedChanging(global::System.Nullable<bool> value);
        partial void OnHierarchyIsCreatedChanged();
        /// <summary>
        /// There are no comments for Property TopWebURL in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string TopWebURL
        {
            get
            {
                return this._TopWebURL;
            }
            set
            {
                this.OnTopWebURLChanging(value);
                this._TopWebURL = value;
                this.OnTopWebURLChanged();
                this.OnPropertyChanged("TopWebURL");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _TopWebURL;
        partial void OnTopWebURLChanging(string value);
        partial void OnTopWebURLChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for HierarchyCreationMode in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public VariationLabelsHierarchyCreationModeValue HierarchyCreationMode
        {
            get
            {
                return this._HierarchyCreationMode;
            }
            set
            {
                this._HierarchyCreationMode = value;
                this.OnPropertyChanged("HierarchyCreationMode");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private VariationLabelsHierarchyCreationModeValue _HierarchyCreationMode;
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.VariationLabelsHierarchyCreationModeValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("VariationLabelsHierarchyCreationMode")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class VariationLabelsHierarchyCreationModeValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VariationLabelsHierarchyCreationModeValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static VariationLabelsHierarchyCreationModeValue CreateVariationLabelsHierarchyCreationModeValue(string value)
        {
            VariationLabelsHierarchyCreationModeValue variationLabelsHierarchyCreationModeValue = new VariationLabelsHierarchyCreationModeValue();
            variationLabelsHierarchyCreationModeValue.Value = value;
            return variationLabelsHierarchyCreationModeValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.WebPartGalleryItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("WebPartGallery")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class WebPartGalleryItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WebPartGalleryItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static WebPartGalleryItem CreateWebPartGalleryItem(int ID)
        {
            WebPartGalleryItem webPartGalleryItem = new WebPartGalleryItem();
            webPartGalleryItem.Id = ID;
            return webPartGalleryItem;
        }
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property GroupValue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string GroupValue
        {
            get
            {
                return this._GroupValue;
            }
            set
            {
                this.OnGroupValueChanging(value);
                this._GroupValue = value;
                this.OnGroupValueChanged();
                this.OnPropertyChanged("GroupValue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _GroupValue;
        partial void OnGroupValueChanging(string value);
        partial void OnGroupValueChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Group in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public WebPartGalleryGroupValue Group
        {
            get
            {
                return this._Group;
            }
            set
            {
                this._Group = value;
                this.OnPropertyChanged("Group");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private WebPartGalleryGroupValue _Group;
        /// <summary>
        /// There are no comments for RecommendationSettings in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<WebPartGalleryRecommendationSettingsValue> RecommendationSettings
        {
            get
            {
                return this._RecommendationSettings;
            }
            set
            {
                this._RecommendationSettings = value;
                this.OnPropertyChanged("RecommendationSettings");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<WebPartGalleryRecommendationSettingsValue> _RecommendationSettings = new global::System.Data.Services.Client.DataServiceCollection<WebPartGalleryRecommendationSettingsValue>(null, System.Data.Services.Client.TrackingMode.None);
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.WebPartGalleryGroupValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("WebPartGalleryGroup")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class WebPartGalleryGroupValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WebPartGalleryGroupValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static WebPartGalleryGroupValue CreateWebPartGalleryGroupValue(string value)
        {
            WebPartGalleryGroupValue webPartGalleryGroupValue = new WebPartGalleryGroupValue();
            webPartGalleryGroupValue.Value = value;
            return webPartGalleryGroupValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.WebPartGalleryRecommendationSettingsValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("WebPartGalleryRecommendationSettings")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class WebPartGalleryRecommendationSettingsValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WebPartGalleryRecommendationSettingsValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static WebPartGalleryRecommendationSettingsValue CreateWebPartGalleryRecommendationSettingsValue(string value)
        {
            WebPartGalleryRecommendationSettingsValue webPartGalleryRecommendationSettingsValue = new WebPartGalleryRecommendationSettingsValue();
            webPartGalleryRecommendationSettingsValue.Value = value;
            return webPartGalleryRecommendationSettingsValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.WfpubItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Wfpub")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.HasStreamAttribute()]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class WfpubItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WfpubItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static WfpubItem CreateWfpubItem(int ID)
        {
            WfpubItem wfpubItem = new WfpubItem();
            wfpubItem.Id = ID;
            return wfpubItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property CopySource in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CopySource
        {
            get
            {
                return this._CopySource;
            }
            set
            {
                this.OnCopySourceChanging(value);
                this._CopySource = value;
                this.OnCopySourceChanged();
                this.OnPropertyChanged("CopySource");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CopySource;
        partial void OnCopySourceChanging(string value);
        partial void OnCopySourceChanged();
        /// <summary>
        /// There are no comments for Property ApprovalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ApprovalStatus
        {
            get
            {
                return this._ApprovalStatus;
            }
            set
            {
                this.OnApprovalStatusChanging(value);
                this._ApprovalStatus = value;
                this.OnApprovalStatusChanged();
                this.OnPropertyChanged("ApprovalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ApprovalStatus;
        partial void OnApprovalStatusChanging(string value);
        partial void OnApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property CheckedOutToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CheckedOutToId
        {
            get
            {
                return this._CheckedOutToId;
            }
            set
            {
                this.OnCheckedOutToIdChanging(value);
                this._CheckedOutToId = value;
                this.OnCheckedOutToIdChanged();
                this.OnPropertyChanged("CheckedOutToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CheckedOutToId;
        partial void OnCheckedOutToIdChanging(global::System.Nullable<int> value);
        partial void OnCheckedOutToIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VirusStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string VirusStatus
        {
            get
            {
                return this._VirusStatus;
            }
            set
            {
                this.OnVirusStatusChanging(value);
                this._VirusStatus = value;
                this.OnVirusStatusChanged();
                this.OnPropertyChanged("VirusStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _VirusStatus;
        partial void OnVirusStatusChanging(string value);
        partial void OnVirusStatusChanged();
        /// <summary>
        /// There are no comments for Property IsCurrentVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<bool> IsCurrentVersion
        {
            get
            {
                return this._IsCurrentVersion;
            }
            set
            {
                this.OnIsCurrentVersionChanging(value);
                this._IsCurrentVersion = value;
                this.OnIsCurrentVersionChanged();
                this.OnPropertyChanged("IsCurrentVersion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<bool> _IsCurrentVersion;
        partial void OnIsCurrentVersionChanging(global::System.Nullable<bool> value);
        partial void OnIsCurrentVersionChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for CheckedOutTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CheckedOutTo
        {
            get
            {
                return this._CheckedOutTo;
            }
            set
            {
                this._CheckedOutTo = value;
                this.OnPropertyChanged("CheckedOutTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CheckedOutTo;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.WorkflowTasksItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("WorkflowTasks")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Title", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Modified", System.Data.Services.Common.SyndicationItemProperty.Updated, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class WorkflowTasksItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkflowTasksItem object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static WorkflowTasksItem CreateWorkflowTasksItem(int ID)
        {
            WorkflowTasksItem workflowTasksItem = new WorkflowTasksItem();
            workflowTasksItem.Id = ID;
            return workflowTasksItem;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ContentTypeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentTypeID
        {
            get
            {
                return this._ContentTypeID;
            }
            set
            {
                this.OnContentTypeIDChanging(value);
                this._ContentTypeID = value;
                this.OnContentTypeIDChanged();
                this.OnPropertyChanged("ContentTypeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentTypeID;
        partial void OnContentTypeIDChanging(string value);
        partial void OnContentTypeIDChanged();
        /// <summary>
        /// There are no comments for Property ContentType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this.OnContentTypeChanging(value);
                this._ContentType = value;
                this.OnContentTypeChanged();
                this.OnPropertyChanged("ContentType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContentType;
        partial void OnContentTypeChanging(string value);
        partial void OnContentTypeChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property CreatedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> CreatedById
        {
            get
            {
                return this._CreatedById;
            }
            set
            {
                this.OnCreatedByIdChanging(value);
                this._CreatedById = value;
                this.OnCreatedByIdChanged();
                this.OnPropertyChanged("CreatedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _CreatedById;
        partial void OnCreatedByIdChanging(global::System.Nullable<int> value);
        partial void OnCreatedByIdChanged();
        /// <summary>
        /// There are no comments for Property ModifiedById in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ModifiedById
        {
            get
            {
                return this._ModifiedById;
            }
            set
            {
                this.OnModifiedByIdChanging(value);
                this._ModifiedById = value;
                this.OnModifiedByIdChanged();
                this.OnPropertyChanged("ModifiedById");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ModifiedById;
        partial void OnModifiedByIdChanging(global::System.Nullable<int> value);
        partial void OnModifiedByIdChanged();
        /// <summary>
        /// There are no comments for Property Owshiddenversion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Owshiddenversion
        {
            get
            {
                return this._Owshiddenversion;
            }
            set
            {
                this.OnOwshiddenversionChanging(value);
                this._Owshiddenversion = value;
                this.OnOwshiddenversionChanged();
                this.OnPropertyChanged("Owshiddenversion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Owshiddenversion;
        partial void OnOwshiddenversionChanging(global::System.Nullable<int> value);
        partial void OnOwshiddenversionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        /// <summary>
        /// There are no comments for Property PriorityValue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PriorityValue
        {
            get
            {
                return this._PriorityValue;
            }
            set
            {
                this.OnPriorityValueChanging(value);
                this._PriorityValue = value;
                this.OnPriorityValueChanged();
                this.OnPropertyChanged("PriorityValue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PriorityValue;
        partial void OnPriorityValueChanging(string value);
        partial void OnPriorityValueChanged();
        /// <summary>
        /// There are no comments for Property StatusValue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string StatusValue
        {
            get
            {
                return this._StatusValue;
            }
            set
            {
                this.OnStatusValueChanging(value);
                this._StatusValue = value;
                this.OnStatusValueChanged();
                this.OnPropertyChanged("StatusValue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _StatusValue;
        partial void OnStatusValueChanging(string value);
        partial void OnStatusValueChanged();
        /// <summary>
        /// There are no comments for Property Complete in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<double> Complete
        {
            get
            {
                return this._Complete;
            }
            set
            {
                this.OnCompleteChanging(value);
                this._Complete = value;
                this.OnCompleteChanged();
                this.OnPropertyChanged("Complete");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<double> _Complete;
        partial void OnCompleteChanging(global::System.Nullable<double> value);
        partial void OnCompleteChanged();
        /// <summary>
        /// There are no comments for Property AssignedToId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> AssignedToId
        {
            get
            {
                return this._AssignedToId;
            }
            set
            {
                this.OnAssignedToIdChanging(value);
                this._AssignedToId = value;
                this.OnAssignedToIdChanged();
                this.OnPropertyChanged("AssignedToId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _AssignedToId;
        partial void OnAssignedToIdChanging(global::System.Nullable<int> value);
        partial void OnAssignedToIdChanged();
        /// <summary>
        /// There are no comments for Property TaskGroupId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> TaskGroupId
        {
            get
            {
                return this._TaskGroupId;
            }
            set
            {
                this.OnTaskGroupIdChanging(value);
                this._TaskGroupId = value;
                this.OnTaskGroupIdChanged();
                this.OnPropertyChanged("TaskGroupId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _TaskGroupId;
        partial void OnTaskGroupIdChanging(global::System.Nullable<int> value);
        partial void OnTaskGroupIdChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _StartDate;
        partial void OnStartDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _DueDate;
        partial void OnDueDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnDueDateChanged();
        /// <summary>
        /// There are no comments for CreatedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this._CreatedBy = value;
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _CreatedBy;
        /// <summary>
        /// There are no comments for ModifiedBy in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this._ModifiedBy = value;
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _ModifiedBy;
        /// <summary>
        /// There are no comments for Attachments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this._Attachments = value;
                this.OnPropertyChanged("Attachments");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem> _Attachments = new global::System.Data.Services.Client.DataServiceCollection<AttachmentsItem>(null, System.Data.Services.Client.TrackingMode.None);
        /// <summary>
        /// There are no comments for Predecessors in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<WorkflowTasksItem> Predecessors
        {
            get
            {
                return this._Predecessors;
            }
            set
            {
                this._Predecessors = value;
                this.OnPropertyChanged("Predecessors");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<WorkflowTasksItem> _Predecessors = new global::System.Data.Services.Client.DataServiceCollection<WorkflowTasksItem>(null, System.Data.Services.Client.TrackingMode.None);
        /// <summary>
        /// There are no comments for Priority in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public WorkflowTasksPriorityValue Priority
        {
            get
            {
                return this._Priority;
            }
            set
            {
                this._Priority = value;
                this.OnPropertyChanged("Priority");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private WorkflowTasksPriorityValue _Priority;
        /// <summary>
        /// There are no comments for Status in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public WorkflowTasksStatusValue Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this._Status = value;
                this.OnPropertyChanged("Status");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private WorkflowTasksStatusValue _Status;
        /// <summary>
        /// There are no comments for AssignedTo in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem AssignedTo
        {
            get
            {
                return this._AssignedTo;
            }
            set
            {
                this._AssignedTo = value;
                this.OnPropertyChanged("AssignedTo");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _AssignedTo;
        /// <summary>
        /// There are no comments for TaskGroup in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public UserInformationListItem TaskGroup
        {
            get
            {
                return this._TaskGroup;
            }
            set
            {
                this._TaskGroup = value;
                this.OnPropertyChanged("TaskGroup");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private UserInformationListItem _TaskGroup;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.WorkflowTasksPriorityValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("WorkflowTasksPriority")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class WorkflowTasksPriorityValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkflowTasksPriorityValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static WorkflowTasksPriorityValue CreateWorkflowTasksPriorityValue(string value)
        {
            WorkflowTasksPriorityValue workflowTasksPriorityValue = new WorkflowTasksPriorityValue();
            workflowTasksPriorityValue.Value = value;
            return workflowTasksPriorityValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Microsoft.SharePoint.DataService.WorkflowTasksStatusValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("WorkflowTasksStatus")]
    [global::System.Data.Services.Common.EntityPropertyMappingAttribute("Value", System.Data.Services.Common.SyndicationItemProperty.Title, System.Data.Services.Common.SyndicationTextContentKind.Plaintext, true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Value")]
    public partial class WorkflowTasksStatusValue : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkflowTasksStatusValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static WorkflowTasksStatusValue CreateWorkflowTasksStatusValue(string value)
        {
            WorkflowTasksStatusValue workflowTasksStatusValue = new WorkflowTasksStatusValue();
            workflowTasksStatusValue.Value = value;
            return workflowTasksStatusValue;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
