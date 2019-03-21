namespace Enterprise.AdminUI.Forms
{
    partial class FormRestaurants
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.grvMenu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colMenuType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestaurantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpRestaurant = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.restaurantLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcRestaurants = new DevExpress.XtraGrid.GridControl();
            this.restaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantMenuMenuItemDBSet = new Enterprise.AdminUI.restaurantMenuMenuItemDBSet();
            this.grvRestaurants = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestaurantCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropDownCategory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.restaurantCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colLogoImageLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLogoImageLocation = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSmallLogoImageLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSmallLogoImageLocation = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBannerImageLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBannerImageLocation = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colMainImageLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnMainImageLocation = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBackgroundLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBackgroundImageLocation = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtState = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpRestaurantMenuItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lookUpMenuMenuItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.menuLookUpBinding = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grvMenuItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMenuItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuItemRestaurantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuItemMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuItemPreparationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuItemMenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.addRestaurantButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.addMenuItemMenu = new DevExpress.XtraBars.BarButtonItem();
            this.barRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this._Enterprise_DatabaseDataSet = new Enterprise.AdminUI._Enterprise_DatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.grvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcRestaurants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantMenuMenuItemDBSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRestaurants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogoImageLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSmallLogoImageLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBannerImageLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainImageLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackgroundImageLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRestaurantMenuItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenuMenuItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLookUpBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMenuItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Enterprise_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grvMenu
            // 
            this.grvMenu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMenuId,
            this.colMenuType,
            this.colRestaurantId,
            this.colStartDate,
            this.colEndDate});
            this.grvMenu.GridControl = this.grcRestaurants;
            this.grvMenu.Name = "grvMenu";
            this.grvMenu.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvMenu.OptionsEditForm.EditFormColumnCount = 2;
            this.grvMenu.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.grvMenu_MasterRowGetChildList);
            this.grvMenu.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.grvMenu_MasterRowGetRelationName);
            this.grvMenu.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.grvMenu_MasterRowGetRelationCount);
            this.grvMenu.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvMenu_RowDeleting);
            this.grvMenu.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.grvMenu_RowDeleted);
            this.grvMenu.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvMenu_RowUpdated);
            this.grvMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvMenu_KeyDown);
            // 
            // colMenuId
            // 
            this.colMenuId.ColumnEdit = this.txtReadOnly;
            this.colMenuId.FieldName = "Id";
            this.colMenuId.Name = "colMenuId";
            this.colMenuId.OptionsEditForm.ColumnSpan = 2;
            this.colMenuId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colMenuId.Visible = true;
            this.colMenuId.VisibleIndex = 0;
            this.colMenuId.Width = 82;
            // 
            // txtReadOnly
            // 
            this.txtReadOnly.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtReadOnly.AutoHeight = false;
            this.txtReadOnly.Name = "txtReadOnly";
            this.txtReadOnly.ReadOnly = true;
            // 
            // colMenuType
            // 
            this.colMenuType.FieldName = "MenuType";
            this.colMenuType.Name = "colMenuType";
            this.colMenuType.OptionsEditForm.ColumnSpan = 2;
            this.colMenuType.OptionsEditForm.StartNewRow = true;
            this.colMenuType.OptionsEditForm.UseEditorColRowSpan = false;
            this.colMenuType.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colMenuType.Visible = true;
            this.colMenuType.VisibleIndex = 1;
            this.colMenuType.Width = 330;
            // 
            // colRestaurantId
            // 
            this.colRestaurantId.ColumnEdit = this.lookUpRestaurant;
            this.colRestaurantId.FieldName = "RestaurantId";
            this.colRestaurantId.Name = "colRestaurantId";
            // 
            // lookUpRestaurant
            // 
            this.lookUpRestaurant.AutoHeight = false;
            this.lookUpRestaurant.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRestaurant.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookUpRestaurant.DataSource = this.restaurantLookupBindingSource;
            this.lookUpRestaurant.DisplayMember = "Name";
            this.lookUpRestaurant.Name = "lookUpRestaurant";
            this.lookUpRestaurant.ValueMember = "Id";
            // 
            // restaurantLookupBindingSource
            // 
            this.restaurantLookupBindingSource.DataSource = typeof(Enterprise.Logic.Entities.Restaurant);
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.OptionsEditForm.StartNewRow = true;
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            this.colStartDate.Width = 330;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 3;
            this.colEndDate.Width = 330;
            // 
            // grcRestaurants
            // 
            this.grcRestaurants.DataSource = this.restaurantBindingSource;
            this.grcRestaurants.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.grvMenu;
            gridLevelNode2.LevelTemplate = this.grvMenuItem;
            gridLevelNode2.RelationName = "Menu Item";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "Menu";
            this.grcRestaurants.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grcRestaurants.Location = new System.Drawing.Point(0, 22);
            this.grcRestaurants.MainView = this.grvRestaurants;
            this.grcRestaurants.Name = "grcRestaurants";
            this.grcRestaurants.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnLogoImageLocation,
            this.btnSmallLogoImageLocation,
            this.btnBannerImageLocation,
            this.btnMainImageLocation,
            this.btnBackgroundImageLocation,
            this.dropDownCategory,
            this.txtState,
            this.lookUpRestaurant,
            this.txtReadOnly,
            this.lookUpRestaurantMenuItem,
            this.lookUpMenuMenuItem});
            this.grcRestaurants.Size = new System.Drawing.Size(991, 523);
            this.grcRestaurants.TabIndex = 0;
            this.grcRestaurants.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRestaurants,
            this.gridView2,
            this.grvMenuItem,
            this.grvMenu});
            this.grcRestaurants.Click += new System.EventHandler(this.grcRestaurants_Click);
            // 
            // restaurantBindingSource
            // 
            this.restaurantBindingSource.DataSource = this.restaurantMenuMenuItemDBSet;
            this.restaurantBindingSource.Position = 0;
            // 
            // restaurantMenuMenuItemDBSet
            // 
            this.restaurantMenuMenuItemDBSet.DataSetName = "restaurantMenuMenuItemDBSet";
            this.restaurantMenuMenuItemDBSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grvRestaurants
            // 
            this.grvRestaurants.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription,
            this.colRestaurantCategoryId,
            this.colLogoImageLocation,
            this.colSmallLogoImageLocation,
            this.colBannerImageLocation,
            this.colMainImageLocation,
            this.colBackgroundLocation,
            this.colStreetAddress,
            this.colCity,
            this.colState,
            this.colPostalCode,
            this.colId});
            this.grvRestaurants.CustomizationFormBounds = new System.Drawing.Rectangle(560, 389, 210, 179);
            this.grvRestaurants.GridControl = this.grcRestaurants;
            this.grvRestaurants.Name = "grvRestaurants";
            this.grvRestaurants.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvRestaurants.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.grvRestaurants.OptionsEditForm.EditFormColumnCount = 2;
            this.grvRestaurants.OptionsView.ShowAutoFilterRow = true;
            this.grvRestaurants.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.grvRestaurants_MasterRowGetChildList);
            this.grvRestaurants.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.grvRestaurants_MasterRowGetRelationName);
            this.grvRestaurants.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.grvRestaurants_MasterRowGetRelationCount);
            this.grvRestaurants.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvRestaurants_RowDeleting);
            this.grvRestaurants.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.grvRestaurants_RowDeleted);
            this.grvRestaurants.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvRestaurants_ValidateRow);
            this.grvRestaurants.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvRestaurants_RowUpdated);
            this.grvRestaurants.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvRestaurants_KeyDown);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 143;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsEditForm.ColumnSpan = 2;
            this.colDescription.OptionsEditForm.UseEditorColRowSpan = false;
            this.colDescription.OptionsEditForm.VisibleIndex = 99;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 135;
            // 
            // colRestaurantCategoryId
            // 
            this.colRestaurantCategoryId.Caption = "Category";
            this.colRestaurantCategoryId.ColumnEdit = this.dropDownCategory;
            this.colRestaurantCategoryId.FieldName = "RestaurantCategoryId";
            this.colRestaurantCategoryId.Name = "colRestaurantCategoryId";
            this.colRestaurantCategoryId.Visible = true;
            this.colRestaurantCategoryId.VisibleIndex = 2;
            this.colRestaurantCategoryId.Width = 73;
            // 
            // dropDownCategory
            // 
            this.dropDownCategory.AutoHeight = false;
            this.dropDownCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropDownCategory.DataSource = this.restaurantCategoryBindingSource;
            this.dropDownCategory.DisplayMember = "Description";
            this.dropDownCategory.Name = "dropDownCategory";
            this.dropDownCategory.NullText = "[...]";
            this.dropDownCategory.ValueMember = "Id";
            // 
            // restaurantCategoryBindingSource
            // 
            this.restaurantCategoryBindingSource.DataSource = typeof(Enterprise.Logic.Entities.RestaurantCategory);
            // 
            // colLogoImageLocation
            // 
            this.colLogoImageLocation.ColumnEdit = this.btnLogoImageLocation;
            this.colLogoImageLocation.FieldName = "LogoImageLocation";
            this.colLogoImageLocation.Name = "colLogoImageLocation";
            this.colLogoImageLocation.OptionsEditForm.ColumnSpan = 2;
            this.colLogoImageLocation.OptionsEditForm.UseEditorColRowSpan = false;
            this.colLogoImageLocation.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colLogoImageLocation.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colLogoImageLocation.Width = 142;
            // 
            // btnLogoImageLocation
            // 
            this.btnLogoImageLocation.AllowFocused = false;
            this.btnLogoImageLocation.AutoHeight = false;
            this.btnLogoImageLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnLogoImageLocation.Name = "btnLogoImageLocation";
            this.btnLogoImageLocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnLogoImageLocation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnImageLocation_ButtonClick);
            // 
            // colSmallLogoImageLocation
            // 
            this.colSmallLogoImageLocation.ColumnEdit = this.btnSmallLogoImageLocation;
            this.colSmallLogoImageLocation.FieldName = "SmallLogoImageLocation";
            this.colSmallLogoImageLocation.Name = "colSmallLogoImageLocation";
            this.colSmallLogoImageLocation.OptionsEditForm.ColumnSpan = 2;
            this.colSmallLogoImageLocation.OptionsEditForm.UseEditorColRowSpan = false;
            this.colSmallLogoImageLocation.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colSmallLogoImageLocation.Width = 146;
            // 
            // btnSmallLogoImageLocation
            // 
            this.btnSmallLogoImageLocation.AutoHeight = false;
            this.btnSmallLogoImageLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSmallLogoImageLocation.Name = "btnSmallLogoImageLocation";
            this.btnSmallLogoImageLocation.ReadOnly = true;
            this.btnSmallLogoImageLocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnSmallLogoImageLocation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnImageLocation_ButtonClick);
            // 
            // colBannerImageLocation
            // 
            this.colBannerImageLocation.ColumnEdit = this.btnBannerImageLocation;
            this.colBannerImageLocation.FieldName = "BannerImageLocation";
            this.colBannerImageLocation.Name = "colBannerImageLocation";
            this.colBannerImageLocation.OptionsEditForm.ColumnSpan = 2;
            this.colBannerImageLocation.OptionsEditForm.UseEditorColRowSpan = false;
            this.colBannerImageLocation.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colBannerImageLocation.Width = 130;
            // 
            // btnBannerImageLocation
            // 
            this.btnBannerImageLocation.AutoHeight = false;
            this.btnBannerImageLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnBannerImageLocation.Name = "btnBannerImageLocation";
            this.btnBannerImageLocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnBannerImageLocation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnImageLocation_ButtonClick);
            // 
            // colMainImageLocation
            // 
            this.colMainImageLocation.ColumnEdit = this.btnMainImageLocation;
            this.colMainImageLocation.FieldName = "MainImageLocation";
            this.colMainImageLocation.Name = "colMainImageLocation";
            this.colMainImageLocation.OptionsEditForm.ColumnSpan = 2;
            this.colMainImageLocation.OptionsEditForm.UseEditorColRowSpan = false;
            this.colMainImageLocation.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colMainImageLocation.Width = 118;
            // 
            // btnMainImageLocation
            // 
            this.btnMainImageLocation.AutoHeight = false;
            this.btnMainImageLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnMainImageLocation.Name = "btnMainImageLocation";
            this.btnMainImageLocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnMainImageLocation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnImageLocation_ButtonClick);
            // 
            // colBackgroundLocation
            // 
            this.colBackgroundLocation.ColumnEdit = this.btnBackgroundImageLocation;
            this.colBackgroundLocation.FieldName = "BackgroundLocation";
            this.colBackgroundLocation.Name = "colBackgroundLocation";
            this.colBackgroundLocation.OptionsEditForm.ColumnSpan = 2;
            this.colBackgroundLocation.OptionsEditForm.UseEditorColRowSpan = false;
            this.colBackgroundLocation.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colBackgroundLocation.Width = 119;
            // 
            // btnBackgroundImageLocation
            // 
            this.btnBackgroundImageLocation.AutoHeight = false;
            this.btnBackgroundImageLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnBackgroundImageLocation.Name = "btnBackgroundImageLocation";
            this.btnBackgroundImageLocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnBackgroundImageLocation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnImageLocation_ButtonClick);
            // 
            // colPostalCode
            // 
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Visible = true;
            this.colPostalCode.VisibleIndex = 6;
            this.colPostalCode.Width = 109;
            // 
            // colStreetAddress
            // 
            this.colStreetAddress.FieldName = "StreetAddress";
            this.colStreetAddress.Name = "colStreetAddress";
            this.colStreetAddress.Visible = true;
            this.colStreetAddress.VisibleIndex = 3;
            this.colStreetAddress.Width = 110;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 4;
            // 
            // colState
            // 
            this.colState.ColumnEdit = this.txtState;
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 5;
            this.colState.Width = 67;
            // 
            // txtState
            // 
            this.txtState.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtState.AutoHeight = false;
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 48;
            // 
            // lookUpRestaurantMenuItem
            // 
            this.lookUpRestaurantMenuItem.AutoHeight = false;
            this.lookUpRestaurantMenuItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRestaurantMenuItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookUpRestaurantMenuItem.DataSource = this.restaurantLookupBindingSource;
            this.lookUpRestaurantMenuItem.DisplayMember = "Name";
            this.lookUpRestaurantMenuItem.Name = "lookUpRestaurantMenuItem";
            this.lookUpRestaurantMenuItem.ValueMember = "Id";
            this.lookUpRestaurantMenuItem.EditValueChanged += new System.EventHandler(this.lookUpRestaurantMenuItem_EditValueChanged);
            // 
            // lookUpMenuMenuItem
            // 
            this.lookUpMenuMenuItem.AutoHeight = false;
            this.lookUpMenuMenuItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMenuMenuItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuType", "Menu Type")});
            this.lookUpMenuMenuItem.DataSource = this.menuLookUpBinding;
            this.lookUpMenuMenuItem.DisplayMember = "MenuType";
            this.lookUpMenuMenuItem.Name = "lookUpMenuMenuItem";
            this.lookUpMenuMenuItem.ValueMember = "Id";
            // 
            // menuLookUpBinding
            // 
            this.menuLookUpBinding.DataSource = typeof(Enterprise.Logic.Entities.Menu);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grcRestaurants;
            this.gridView2.Name = "gridView2";
            // 
            // grvMenuItem
            // 
            this.grvMenuItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMenuItemId,
            this.colMenuItemRestaurantId,
            this.colMenuItemMenuId,
            this.colMenuItemName,
            this.colMenuItemPrice,
            this.colMenuItemPreparationTime,
            this.colImageLocation,
            this.colMenuItemDescription,
            this.colMenuItemMenuName});
            this.grvMenuItem.GridControl = this.grcRestaurants;
            this.grvMenuItem.Name = "grvMenuItem";
            this.grvMenuItem.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.grvMenuItem.OptionsEditForm.EditFormColumnCount = 2;
            this.grvMenuItem.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.grvMenuItem_RowDeleted);
            this.grvMenuItem.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvMenuItem_RowUpdated);
            this.grvMenuItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvMenuItem_KeyDown);
            // 
            // colMenuItemId
            // 
            this.colMenuItemId.Caption = "Id";
            this.colMenuItemId.FieldName = "Id";
            this.colMenuItemId.Name = "colMenuItemId";
            this.colMenuItemId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colMenuItemId.Visible = true;
            this.colMenuItemId.VisibleIndex = 0;
            // 
            // colMenuItemRestaurantId
            // 
            this.colMenuItemRestaurantId.Caption = "Restaurant";
            this.colMenuItemRestaurantId.ColumnEdit = this.lookUpRestaurantMenuItem;
            this.colMenuItemRestaurantId.FieldName = "RestaurantId";
            this.colMenuItemRestaurantId.Name = "colMenuItemRestaurantId";
            this.colMenuItemRestaurantId.Visible = true;
            this.colMenuItemRestaurantId.VisibleIndex = 1;
            // 
            // colMenuItemMenuId
            // 
            this.colMenuItemMenuId.Caption = "Menu";
            this.colMenuItemMenuId.ColumnEdit = this.lookUpMenuMenuItem;
            this.colMenuItemMenuId.FieldName = "MenuId";
            this.colMenuItemMenuId.Name = "colMenuItemMenuId";
            this.colMenuItemMenuId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colMenuItemName
            // 
            this.colMenuItemName.Caption = "Name";
            this.colMenuItemName.FieldName = "Name";
            this.colMenuItemName.Name = "colMenuItemName";
            this.colMenuItemName.Visible = true;
            this.colMenuItemName.VisibleIndex = 3;
            // 
            // colMenuItemPrice
            // 
            this.colMenuItemPrice.Caption = "Price";
            this.colMenuItemPrice.FieldName = "Price";
            this.colMenuItemPrice.Name = "colMenuItemPrice";
            this.colMenuItemPrice.Visible = true;
            this.colMenuItemPrice.VisibleIndex = 4;
            // 
            // colMenuItemPreparationTime
            // 
            this.colMenuItemPreparationTime.Caption = "Preparation Time";
            this.colMenuItemPreparationTime.FieldName = "PreparationTime";
            this.colMenuItemPreparationTime.Name = "colMenuItemPreparationTime";
            this.colMenuItemPreparationTime.Visible = true;
            this.colMenuItemPreparationTime.VisibleIndex = 5;
            // 
            // colImageLocation
            // 
            this.colImageLocation.Caption = "Image";
            this.colImageLocation.ColumnEdit = this.btnLogoImageLocation;
            this.colImageLocation.FieldName = "ImageLocation";
            this.colImageLocation.Name = "colImageLocation";
            this.colImageLocation.Visible = true;
            this.colImageLocation.VisibleIndex = 6;
            // 
            // colMenuItemDescription
            // 
            this.colMenuItemDescription.Caption = "Description";
            this.colMenuItemDescription.FieldName = "Description";
            this.colMenuItemDescription.Name = "colMenuItemDescription";
            this.colMenuItemDescription.OptionsEditForm.ColumnSpan = 2;
            this.colMenuItemDescription.OptionsEditForm.RowSpan = 5;
            this.colMenuItemDescription.OptionsEditForm.StartNewRow = true;
            this.colMenuItemDescription.OptionsEditForm.UseEditorColRowSpan = false;
            this.colMenuItemDescription.Visible = true;
            this.colMenuItemDescription.VisibleIndex = 7;
            // 
            // colMenuItemMenuName
            // 
            this.colMenuItemMenuName.Caption = "Menu";
            this.colMenuItemMenuName.FieldName = "Menu";
            this.colMenuItemMenuName.Name = "colMenuItemMenuName";
            this.colMenuItemMenuName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colMenuItemMenuName.Visible = true;
            this.colMenuItemMenuName.VisibleIndex = 2;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add Restaurant";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Edit";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barRefresh,
            this.barButtonItem4,
            this.addMenuItemMenu,
            this.addRestaurantButton});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addRestaurantButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.addMenuItemMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barRefresh)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // addRestaurantButton
            // 
            this.addRestaurantButton.Caption = "Add Restaurant";
            this.addRestaurantButton.Id = 6;
            this.addRestaurantButton.Name = "addRestaurantButton";
            this.addRestaurantButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addRestaurantButton_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Add Menu";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // addMenuItemMenu
            // 
            this.addMenuItemMenu.Caption = "Add Menu Item";
            this.addMenuItemMenu.Id = 5;
            this.addMenuItemMenu.Name = "addMenuItemMenu";
            this.addMenuItemMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addMenuItemMenu_ItemClick);
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "Refresh";
            this.barRefresh.Id = 3;
            this.barRefresh.Name = "barRefresh";
            this.barRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(991, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 545);
            this.barDockControlBottom.Size = new System.Drawing.Size(991, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 523);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(991, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 523);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Restaurant";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // _Enterprise_DatabaseDataSet
            // 
            this._Enterprise_DatabaseDataSet.DataSetName = "_Enterprise_DatabaseDataSet";
            this._Enterprise_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRestaurants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 545);
            this.Controls.Add(this.grcRestaurants);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRestaurants";
            this.Text = "Restaurants";
            this.Shown += new System.EventHandler(this.FormRestaurants_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcRestaurants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantMenuMenuItemDBSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRestaurants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogoImageLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSmallLogoImageLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBannerImageLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainImageLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackgroundImageLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRestaurantMenuItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenuMenuItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLookUpBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMenuItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Enterprise_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.GridControl grcRestaurants;
        private System.Windows.Forms.BindingSource restaurantBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRestaurants;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colRestaurantCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colLogoImageLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colSmallLogoImageLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colBannerImageLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colMainImageLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colBackgroundLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnLogoImageLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSmallLogoImageLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnBannerImageLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnMainImageLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnBackgroundImageLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dropDownCategory;
        private System.Windows.Forms.BindingSource restaurantCategoryBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtState;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barRefresh;
        private System.Windows.Forms.BindingSource restaurantLookupBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpRestaurant;
        private _Enterprise_DatabaseDataSet _Enterprise_DatabaseDataSet;
        private restaurantMenuMenuItemDBSet restaurantMenuMenuItemDBSet;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMenu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuItemRestaurantId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuItemMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuType;
        private DevExpress.XtraGrid.Columns.GridColumn colRestaurantId;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuItemPreparationTime;
        private DevExpress.XtraGrid.Columns.GridColumn colImageLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuItemMenuName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpRestaurantMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpMenuMenuItem;
        private System.Windows.Forms.BindingSource menuLookUpBinding;
        private DevExpress.XtraBars.BarButtonItem addMenuItemMenu;
        private DevExpress.XtraBars.BarButtonItem addRestaurantButton;
    }
}