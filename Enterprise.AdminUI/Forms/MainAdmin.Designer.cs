namespace Enterprise.AdminUI.Forms
{
    partial class MainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdmin));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonControl = new DevExpress.ExpressApp.Win.Templates.Ribbon.XafRibbonControlV2();
            this.barMdiChildrenListItem = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barSubItemPanels = new DevExpress.XtraBars.BarSubItem();
            this.barContainerPanels = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerEdit = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerUndoRedo = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerView = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerReports = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerObjectsCreation = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerFile = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerSave = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerPrint = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerOpenObject = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerRecordEdit = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerExport = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerExit = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerAbout = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barContainerMenu = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.ribbonGallerySkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.menuDashBoard = new DevExpress.XtraBars.BarButtonItem();
            this.menuMenu = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.menuCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.menuOrder = new DevExpress.XtraBars.BarButtonItem();
            this.menuMenuItem = new DevExpress.XtraBars.BarButtonItem();
            this.defaultPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonGroupViewsHistoryNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.viewPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonGroupViewsNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupAppearance = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupWindows = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("home_32x32.png", "images/navigation/home_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "home_32x32.png");
            this.imageCollection1.InsertGalleryImage("home_32x32.png", "grayscaleimages/navigation/home_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/navigation/home_32x32.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "home_32x32.png");
            this.imageCollection1.InsertGalleryImage("documentmap_32x32.png", "images/navigation/documentmap_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/documentmap_32x32.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "documentmap_32x32.png");
            this.imageCollection1.InsertGalleryImage("documentmap_32x32.png", "grayscaleimages/page/documentmap_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/page/documentmap_32x32.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "documentmap_32x32.png");
            this.imageCollection1.InsertGalleryImage("usergroup_32x32.png", "images/people/usergroup_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/usergroup_32x32.png"), 4);
            this.imageCollection1.Images.SetKeyName(4, "usergroup_32x32.png");
            this.imageCollection1.InsertGalleryImage("edittask_32x32.png", "images/tasks/edittask_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/edittask_32x32.png"), 5);
            this.imageCollection1.Images.SetKeyName(5, "edittask_32x32.png");
            // 
            // ribbonControl
            // 
            this.ribbonControl.AutoHideEmptyItems = true;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barMdiChildrenListItem,
            this.barSubItemPanels,
            this.barContainerEdit,
            this.barContainerUndoRedo,
            this.barContainerView,
            this.barContainerReports,
            this.barContainerObjectsCreation,
            this.barContainerFile,
            this.barContainerSave,
            this.barContainerPrint,
            this.barContainerOpenObject,
            this.barContainerRecordEdit,
            this.barContainerExport,
            this.barContainerPanels,
            this.barContainerExit,
            this.barContainerAbout,
            this.barContainerMenu,
            this.ribbonGallerySkins,
            this.menuDashBoard,
            this.menuMenu,
            this.menuCustomer,
            this.menuOrder,
            this.menuMenuItem});
            this.ribbonControl.LargeImages = this.imageCollection1;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 11;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.defaultPage,
            this.viewPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(1012, 144);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // barMdiChildrenListItem
            // 
            this.barMdiChildrenListItem.Caption = "Window List";
            this.barMdiChildrenListItem.Id = 37;
            this.barMdiChildrenListItem.Name = "barMdiChildrenListItem";
            // 
            // barSubItemPanels
            // 
            this.barSubItemPanels.Caption = "Panels";
            this.barSubItemPanels.Id = 7;
            this.barSubItemPanels.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerPanels, true)});
            this.barSubItemPanels.Name = "barSubItemPanels";
            // 
            // barContainerPanels
            // 
            this.barContainerPanels.Caption = "Panels";
            this.barContainerPanels.Id = 16;
            this.barContainerPanels.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerPanels.Name = "barContainerPanels";
            // 
            // barContainerEdit
            // 
            this.barContainerEdit.Caption = "Edit";
            this.barContainerEdit.Id = 9;
            this.barContainerEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerEdit.Name = "barContainerEdit";
            // 
            // barContainerUndoRedo
            // 
            this.barContainerUndoRedo.Caption = "UndoRedo";
            this.barContainerUndoRedo.Id = 10;
            this.barContainerUndoRedo.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerUndoRedo.Name = "barContainerUndoRedo";
            // 
            // barContainerView
            // 
            this.barContainerView.Caption = "View";
            this.barContainerView.Id = 12;
            this.barContainerView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerView.Name = "barContainerView";
            // 
            // barContainerReports
            // 
            this.barContainerReports.Caption = "Reports";
            this.barContainerReports.Id = 11;
            this.barContainerReports.MergeOrder = 12;
            this.barContainerReports.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerReports.Name = "barContainerReports";
            // 
            // barContainerObjectsCreation
            // 
            this.barContainerObjectsCreation.Caption = "ObjectCreation";
            this.barContainerObjectsCreation.Id = 18;
            this.barContainerObjectsCreation.MergeOrder = 1;
            this.barContainerObjectsCreation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerObjectsCreation.Name = "barContainerObjectsCreation";
            // 
            // barContainerFile
            // 
            this.barContainerFile.Caption = "File";
            this.barContainerFile.Id = 5;
            this.barContainerFile.MergeOrder = 2;
            this.barContainerFile.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerFile.Name = "barContainerFile";
            // 
            // barContainerSave
            // 
            this.barContainerSave.Caption = "Save";
            this.barContainerSave.Id = 8;
            this.barContainerSave.MergeOrder = 7;
            this.barContainerSave.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerSave.Name = "barContainerSave";
            // 
            // barContainerPrint
            // 
            this.barContainerPrint.Caption = "Print";
            this.barContainerPrint.Id = 6;
            this.barContainerPrint.MergeOrder = 11;
            this.barContainerPrint.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerPrint.Name = "barContainerPrint";
            // 
            // barContainerOpenObject
            // 
            this.barContainerOpenObject.Caption = "Open Related Record";
            this.barContainerOpenObject.Id = 20;
            this.barContainerOpenObject.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerOpenObject.Name = "barContainerOpenObject";
            // 
            // barContainerRecordEdit
            // 
            this.barContainerRecordEdit.Caption = "Record Edit";
            this.barContainerRecordEdit.Id = 9;
            this.barContainerRecordEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerRecordEdit.Name = "barContainerRecordEdit";
            // 
            // barContainerExport
            // 
            this.barContainerExport.Caption = "Export";
            this.barContainerExport.Id = 7;
            this.barContainerExport.MergeOrder = 10;
            this.barContainerExport.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerExport.Name = "barContainerExport";
            // 
            // barContainerExit
            // 
            this.barContainerExit.Caption = "Exit";
            this.barContainerExit.Id = 8;
            this.barContainerExit.MergeOrder = 900;
            this.barContainerExit.Name = "barContainerExit";
            // 
            // barContainerAbout
            // 
            this.barContainerAbout.Caption = "About";
            this.barContainerAbout.Id = 15;
            this.barContainerAbout.MergeOrder = 15;
            this.barContainerAbout.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerAbout.Name = "barContainerAbout";
            // 
            // barContainerMenu
            // 
            this.barContainerMenu.Caption = "Menu";
            this.barContainerMenu.Id = 8;
            this.barContainerMenu.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerMenu.Name = "barContainerMenu";
            // 
            // ribbonGallerySkins
            // 
            this.ribbonGallerySkins.Caption = "Skins";
            this.ribbonGallerySkins.Id = 1;
            this.ribbonGallerySkins.Name = "ribbonGallerySkins";
            // 
            // menuDashBoard
            // 
            this.menuDashBoard.Caption = "Dashboard";
            this.menuDashBoard.Id = 2;
            this.menuDashBoard.LargeImageIndex = 0;
            this.menuDashBoard.Name = "menuDashBoard";
            this.menuDashBoard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuDashBoard_ItemClick);
            // 
            // menuMenu
            // 
            this.menuMenu.ActAsDropDown = true;
            this.menuMenu.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.menuMenu.Caption = "Restaurant";
            this.menuMenu.DropDownControl = this.galleryDropDown1;
            this.menuMenu.Id = 3;
            this.menuMenu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuMenu.LargeGlyph")));
            this.menuMenu.LargeImageIndex = 2;
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuMenu_ItemClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl;
            // 
            // menuCustomer
            // 
            this.menuCustomer.Caption = "Customer";
            this.menuCustomer.Id = 4;
            this.menuCustomer.LargeImageIndex = 4;
            this.menuCustomer.Name = "menuCustomer";
            // 
            // menuOrder
            // 
            this.menuOrder.Caption = "Order";
            this.menuOrder.Id = 5;
            this.menuOrder.LargeImageIndex = 5;
            this.menuOrder.Name = "menuOrder";
            this.menuOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuOrder_ItemClick);
            // 
            // menuMenuItem
            // 
            this.menuMenuItem.Caption = "Menu Item";
            this.menuMenuItem.Id = 10;
            this.menuMenuItem.LargeImageIndex = 3;
            this.menuMenuItem.Name = "menuMenuItem";
            // 
            // defaultPage
            // 
            this.defaultPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonGroupViewsHistoryNavigation,
            this.ribbonGroupSearch});
            this.defaultPage.Name = "defaultPage";
            this.defaultPage.Text = "Admin";
            // 
            // ribbonGroupViewsHistoryNavigation
            // 
            this.ribbonGroupViewsHistoryNavigation.AllowTextClipping = false;
            this.ribbonGroupViewsHistoryNavigation.ItemLinks.Add(this.menuDashBoard);
            this.ribbonGroupViewsHistoryNavigation.ItemLinks.Add(this.menuMenu);
            this.ribbonGroupViewsHistoryNavigation.Name = "ribbonGroupViewsHistoryNavigation";
            this.ribbonGroupViewsHistoryNavigation.ShowCaptionButton = false;
            this.ribbonGroupViewsHistoryNavigation.Text = "Management";
            // 
            // ribbonGroupSearch
            // 
            this.ribbonGroupSearch.AllowTextClipping = false;
            this.ribbonGroupSearch.ItemLinks.Add(this.menuOrder);
            this.ribbonGroupSearch.Name = "ribbonGroupSearch";
            this.ribbonGroupSearch.ShowCaptionButton = false;
            this.ribbonGroupSearch.Text = "Order";
            // 
            // viewPage
            // 
            this.viewPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonGroupViewsNavigation,
            this.ribbonGroupAppearance,
            this.ribbonGroupWindows,
            this.defaultPageGroup});
            this.viewPage.Name = "viewPage";
            this.viewPage.Text = "View";
            // 
            // ribbonGroupViewsNavigation
            // 
            this.ribbonGroupViewsNavigation.AllowTextClipping = false;
            this.ribbonGroupViewsNavigation.MergeOrder = 0;
            this.ribbonGroupViewsNavigation.Name = "ribbonGroupViewsNavigation";
            this.ribbonGroupViewsNavigation.ShowCaptionButton = false;
            this.ribbonGroupViewsNavigation.Text = "Navigation";
            // 
            // ribbonGroupAppearance
            // 
            this.ribbonGroupAppearance.AllowTextClipping = false;
            this.ribbonGroupAppearance.ItemLinks.Add(this.ribbonGallerySkins);
            this.ribbonGroupAppearance.MergeOrder = 1;
            this.ribbonGroupAppearance.Name = "ribbonGroupAppearance";
            this.ribbonGroupAppearance.ShowCaptionButton = false;
            this.ribbonGroupAppearance.Text = "Appearance";
            // 
            // ribbonGroupWindows
            // 
            this.ribbonGroupWindows.AllowTextClipping = false;
            this.ribbonGroupWindows.ItemLinks.Add(this.barMdiChildrenListItem);
            this.ribbonGroupWindows.MergeOrder = 2;
            this.ribbonGroupWindows.Name = "ribbonGroupWindows";
            this.ribbonGroupWindows.ShowCaptionButton = false;
            this.ribbonGroupWindows.Text = "Windows";
            // 
            // defaultPageGroup
            // 
            this.defaultPageGroup.AllowTextClipping = false;
            this.defaultPageGroup.ItemLinks.Add(this.barSubItemPanels);
            this.defaultPageGroup.MergeOrder = 3;
            this.defaultPageGroup.Name = "defaultPageGroup";
            this.defaultPageGroup.ShowCaptionButton = false;
            this.defaultPageGroup.Text = "Actions";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 647);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1012, 31);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 678);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "MainAdmin";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Restaurants Management";
            this.Shown += new System.EventHandler(this.MainAdmin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.ExpressApp.Win.Templates.Ribbon.XafRibbonControlV2 ribbonControl;
        private DevExpress.XtraBars.BarDockingMenuItem barMdiChildrenListItem;
        private DevExpress.XtraBars.BarSubItem barSubItemPanels;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerPanels;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerEdit;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerUndoRedo;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerView;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerReports;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerObjectsCreation;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerFile;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerSave;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerPrint;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerOpenObject;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerRecordEdit;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerExport;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerExit;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerAbout;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerMenu;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGallerySkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage defaultPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupViewsHistoryNavigation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPage viewPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupViewsNavigation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupAppearance;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupWindows;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup defaultPageGroup;
        private DevExpress.XtraBars.BarButtonItem menuDashBoard;
        private DevExpress.XtraBars.BarButtonItem menuMenu;
        private DevExpress.XtraBars.BarButtonItem menuCustomer;
        private DevExpress.XtraBars.BarButtonItem menuOrder;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem menuMenuItem;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
    }
}