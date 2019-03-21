namespace Enterprise.AdminUI.Forms
{
    partial class FormOrder
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
            this.grvDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLookUpRestaurant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpRestaurantRepository = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.restaurantLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colLookUpMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpMenuRepository = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.menuLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colLookUpMenuItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpMenuItemRepository = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.menuItemLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colOrderDetailId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestaurantName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailsMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesValues = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailsQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalMenuItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcOrder = new DevExpress.XtraGrid.GridControl();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropdownMenu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEmailAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestaurant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalForeach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpOderStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.orderStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDes = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.txtReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubmittedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFulllName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderStatusId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.restaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingOrder = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRestaurantRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenuRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenuItemRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpOderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDetails
            // 
            this.grvDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLookUpRestaurant,
            this.colLookUpMenu,
            this.colLookUpMenuItem,
            this.colOrderDetailId,
            this.colMenuItemId,
            this.colRestaurantName,
            this.colDetailsMenuId,
            this.colUnitPrice,
            this.colSalesValues,
            this.colDetailsQuantity,
            this.colTotalMenuItem});
            this.grvDetails.GridControl = this.grcOrder;
            this.grvDetails.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalMenuItem", this.colTotalMenuItem, "Total {0}")});
            this.grvDetails.Name = "grvDetails";
            this.grvDetails.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvDetails.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.grvDetails.OptionsEditForm.EditFormColumnCount = 2;
            this.grvDetails.OptionsNavigation.AutoFocusNewRow = true;
            this.grvDetails.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grvDetails.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.grvDetails_EditFormShowing);
            this.grvDetails.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvDetails_InitNewRow);
            this.grvDetails.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.grvDetails_RowDeleted);
            this.grvDetails.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvDetails_ValidateRow);
            this.grvDetails.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvDetails_RowUpdated);
            this.grvDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvDetails_KeyDown);
            this.grvDetails.DoubleClick += new System.EventHandler(this.grvDetails_DoubleClick);
            // 
            // colLookUpRestaurant
            // 
            this.colLookUpRestaurant.Caption = "Restaurant";
            this.colLookUpRestaurant.ColumnEdit = this.lookUpRestaurantRepository;
            this.colLookUpRestaurant.FieldName = "RestaurantId";
            this.colLookUpRestaurant.Name = "colLookUpRestaurant";
            this.colLookUpRestaurant.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // lookUpRestaurantRepository
            // 
            this.lookUpRestaurantRepository.AutoHeight = false;
            this.lookUpRestaurantRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRestaurantRepository.DataSource = this.restaurantLookupBindingSource;
            this.lookUpRestaurantRepository.DisplayMember = "Name";
            this.lookUpRestaurantRepository.Name = "lookUpRestaurantRepository";
            this.lookUpRestaurantRepository.ValueMember = "Id";
            this.lookUpRestaurantRepository.EditValueChanged += new System.EventHandler(this.lookUpRestaurantRepository_EditValueChanged);
            // 
            // restaurantLookupBindingSource
            // 
            this.restaurantLookupBindingSource.DataSource = typeof(Enterprise.Logic.Entities.Restaurant);
            // 
            // colLookUpMenu
            // 
            this.colLookUpMenu.Caption = "Menu";
            this.colLookUpMenu.ColumnEdit = this.lookUpMenuRepository;
            this.colLookUpMenu.FieldName = "MenuId";
            this.colLookUpMenu.Name = "colLookUpMenu";
            this.colLookUpMenu.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // lookUpMenuRepository
            // 
            this.lookUpMenuRepository.AutoHeight = false;
            this.lookUpMenuRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMenuRepository.DataSource = this.menuLookupBindingSource;
            this.lookUpMenuRepository.DisplayMember = "MenuType";
            this.lookUpMenuRepository.Name = "lookUpMenuRepository";
            this.lookUpMenuRepository.ValueMember = "Id";
            this.lookUpMenuRepository.EditValueChanged += new System.EventHandler(this.lookUpMenuRepository_EditValueChanged_1);
            // 
            // menuLookupBindingSource
            // 
            this.menuLookupBindingSource.DataSource = typeof(Enterprise.Logic.Entities.Menu);
            // 
            // colLookUpMenuItem
            // 
            this.colLookUpMenuItem.Caption = "Menu Item";
            this.colLookUpMenuItem.ColumnEdit = this.lookUpMenuItemRepository;
            this.colLookUpMenuItem.FieldName = "MenuItemId";
            this.colLookUpMenuItem.Name = "colLookUpMenuItem";
            this.colLookUpMenuItem.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // lookUpMenuItemRepository
            // 
            this.lookUpMenuItemRepository.AutoHeight = false;
            this.lookUpMenuItemRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMenuItemRepository.DataSource = this.menuItemLookupBindingSource;
            this.lookUpMenuItemRepository.DisplayMember = "Name";
            this.lookUpMenuItemRepository.Name = "lookUpMenuItemRepository";
            this.lookUpMenuItemRepository.ValueMember = "Id";
            // 
            // menuItemLookupBindingSource
            // 
            this.menuItemLookupBindingSource.DataSource = typeof(Enterprise.Logic.Entities.MenuItem);
            // 
            // colOrderDetailId
            // 
            this.colOrderDetailId.Caption = "Order Detail Id";
            this.colOrderDetailId.FieldName = "Id";
            this.colOrderDetailId.Name = "colOrderDetailId";
            // 
            // colMenuItemId
            // 
            this.colMenuItemId.Caption = "Menu Item";
            this.colMenuItemId.FieldName = "MenuItemName";
            this.colMenuItemId.Name = "colMenuItemId";
            this.colMenuItemId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colMenuItemId.Visible = true;
            this.colMenuItemId.VisibleIndex = 0;
            // 
            // colRestaurantName
            // 
            this.colRestaurantName.Caption = "Restaurant";
            this.colRestaurantName.FieldName = "RestaurantName";
            this.colRestaurantName.Name = "colRestaurantName";
            this.colRestaurantName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colRestaurantName.Visible = true;
            this.colRestaurantName.VisibleIndex = 1;
            // 
            // colDetailsMenuId
            // 
            this.colDetailsMenuId.Caption = "Menu";
            this.colDetailsMenuId.FieldName = "MenuName";
            this.colDetailsMenuId.Name = "colDetailsMenuId";
            this.colDetailsMenuId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDetailsMenuId.Visible = true;
            this.colDetailsMenuId.VisibleIndex = 2;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 3;
            // 
            // colSalesValues
            // 
            this.colSalesValues.FieldName = "SalesValues";
            this.colSalesValues.Name = "colSalesValues";
            this.colSalesValues.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colSalesValues.Visible = true;
            this.colSalesValues.VisibleIndex = 4;
            // 
            // colDetailsQuantity
            // 
            this.colDetailsQuantity.FieldName = "Quantity";
            this.colDetailsQuantity.Name = "colDetailsQuantity";
            this.colDetailsQuantity.Visible = true;
            this.colDetailsQuantity.VisibleIndex = 5;
            // 
            // colTotalMenuItem
            // 
            this.colTotalMenuItem.Caption = "Total";
            this.colTotalMenuItem.FieldName = "TotalMenuItem";
            this.colTotalMenuItem.Name = "colTotalMenuItem";
            this.colTotalMenuItem.Visible = true;
            this.colTotalMenuItem.VisibleIndex = 6;
            // 
            // grcOrder
            // 
            this.grcOrder.DataSource = this.orderBindingSource;
            this.grcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.grvDetails;
            gridLevelNode1.RelationName = "Order Details";
            this.grcOrder.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grcOrder.Location = new System.Drawing.Point(0, 22);
            this.grcOrder.MainView = this.grvOrder;
            this.grcOrder.Name = "grcOrder";
            this.grcOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropdownMenu,
            this.txtDes,
            this.txtReadOnly,
            this.lookUpOderStatus,
            this.lookUpRestaurantRepository,
            this.lookUpMenuRepository,
            this.lookUpMenuItemRepository});
            this.grcOrder.Size = new System.Drawing.Size(834, 473);
            this.grcOrder.TabIndex = 5;
            this.grcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvOrder,
            this.gridViewDetail,
            this.grvDetails});
            this.grcOrder.Click += new System.EventHandler(this.grcOrder_Click);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Enterprise.Logic.Entities.Order);
            // 
            // grvOrder
            // 
            this.grvOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName,
            this.colMenuId,
            this.colEmailAddress,
            this.colAddress,
            this.colId,
            this.colRestaurant,
            this.colStatus,
            this.colCustomer,
            this.colTotalForeach,
            this.colCustomerSummary,
            this.colPostalCode,
            this.colState,
            this.colContactPhone,
            this.colStatusId});
            this.grvOrder.CustomizationFormBounds = new System.Drawing.Rectangle(560, 389, 210, 179);
            this.grvOrder.GridControl = this.grcOrder;
            this.grvOrder.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", this.colTotalForeach, "$ {0}")});
            this.grvOrder.Name = "grvOrder";
            this.grvOrder.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvOrder.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.grvOrder.OptionsEditForm.EditFormColumnCount = 2;
            this.grvOrder.OptionsView.ShowAutoFilterRow = true;
            this.grvOrder.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.grvOrder_MasterRowEmpty);
            this.grvOrder.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.grvOrder_MasterRowGetChildList);
            this.grvOrder.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.grvOrder_MasterRowGetRelationName);
            this.grvOrder.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.grvOrder_MasterRowGetRelationCount);
            this.grvOrder.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.grvOrder_RowDeleted);
            this.grvOrder.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvOrder_ValidateRow);
            this.grvOrder.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvOrder_RowUpdated);
            this.grvOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvOrder_KeyDown);
            this.grvOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grvOrder_MouseDown);
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Name";
            this.colFullName.FieldName = "FulllName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsEditForm.ColumnSpan = 2;
            this.colFullName.OptionsEditForm.UseEditorColRowSpan = false;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            this.colFullName.Width = 113;
            // 
            // colMenuId
            // 
            this.colMenuId.Caption = "MenuId";
            this.colMenuId.ColumnEdit = this.dropdownMenu;
            this.colMenuId.FieldName = "MenuId";
            this.colMenuId.Name = "colMenuId";
            this.colMenuId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colMenuId.Width = 109;
            // 
            // dropdownMenu
            // 
            this.dropdownMenu.AutoHeight = false;
            this.dropdownMenu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropdownMenu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuType", "Menu")});
            this.dropdownMenu.DisplayMember = "MenuType";
            this.dropdownMenu.Name = "dropdownMenu";
            this.dropdownMenu.NullText = "";
            this.dropdownMenu.ValueMember = "Id";
            // 
            // colEmailAddress
            // 
            this.colEmailAddress.Caption = "Email";
            this.colEmailAddress.FieldName = "Email";
            this.colEmailAddress.Name = "colEmailAddress";
            this.colEmailAddress.Visible = true;
            this.colEmailAddress.VisibleIndex = 2;
            this.colEmailAddress.Width = 130;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "StreetAddress";
            this.colAddress.FieldName = "StreetAddress";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            this.colAddress.Width = 135;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colId.Width = 46;
            // 
            // colRestaurant
            // 
            this.colRestaurant.Caption = "City";
            this.colRestaurant.FieldName = "City";
            this.colRestaurant.Name = "colRestaurant";
            this.colRestaurant.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colRestaurant.ToolTip = "Menu";
            this.colRestaurant.Visible = true;
            this.colRestaurant.VisibleIndex = 4;
            this.colRestaurant.Width = 95;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "OrderStatus";
            this.colStatus.Name = "colStatus";
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer Name";
            this.colCustomer.FieldName = "FullName";
            this.colCustomer.Name = "colCustomer";
            // 
            // colTotalForeach
            // 
            this.colTotalForeach.Caption = "Total";
            this.colTotalForeach.DisplayFormat.FormatString = "$ {0}";
            this.colTotalForeach.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalForeach.FieldName = "Total";
            this.colTotalForeach.Name = "colTotalForeach";
            this.colTotalForeach.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalForeach.Visible = true;
            this.colTotalForeach.VisibleIndex = 7;
            this.colTotalForeach.Width = 148;
            // 
            // colCustomerSummary
            // 
            this.colCustomerSummary.Caption = "Customer";
            this.colCustomerSummary.FieldName = "CustomerSummary";
            this.colCustomerSummary.Name = "colCustomerSummary";
            // 
            // colPostalCode
            // 
            this.colPostalCode.Caption = "PostalCode";
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Visible = true;
            this.colPostalCode.VisibleIndex = 5;
            this.colPostalCode.Width = 103;
            // 
            // colState
            // 
            this.colState.Caption = "State";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 6;
            this.colState.Width = 96;
            // 
            // colContactPhone
            // 
            this.colContactPhone.Caption = "Phone Number";
            this.colContactPhone.FieldName = "ContactTelephone";
            this.colContactPhone.Name = "colContactPhone";
            this.colContactPhone.Visible = true;
            this.colContactPhone.VisibleIndex = 1;
            // 
            // colStatusId
            // 
            this.colStatusId.Caption = "Order Status";
            this.colStatusId.ColumnEdit = this.lookUpOderStatus;
            this.colStatusId.FieldName = "OrderStatusId";
            this.colStatusId.Name = "colStatusId";
            this.colStatusId.Visible = true;
            this.colStatusId.VisibleIndex = 8;
            // 
            // lookUpOderStatus
            // 
            this.lookUpOderStatus.AutoHeight = false;
            this.lookUpOderStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpOderStatus.DataSource = this.orderStatusBindingSource;
            this.lookUpOderStatus.DisplayMember = "Name";
            this.lookUpOderStatus.ImmediatePopup = true;
            this.lookUpOderStatus.Name = "lookUpOderStatus";
            this.lookUpOderStatus.ValueMember = "Id";
            // 
            // txtDes
            // 
            this.txtDes.Name = "txtDes";
            // 
            // txtReadOnly
            // 
            this.txtReadOnly.AllowFocused = false;
            this.txtReadOnly.AutoHeight = false;
            this.txtReadOnly.Name = "txtReadOnly";
            this.txtReadOnly.ReadOnly = true;
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId2,
            this.colSubmittedDate,
            this.colCustomerID,
            this.colTotal,
            this.colContactTelephone,
            this.colPostalCode1,
            this.colState1,
            this.colStreetAddress,
            this.colCity,
            this.colEmail,
            this.colFulllName,
            this.colOrderStatusId});
            this.gridViewDetail.GridControl = this.grcOrder;
            this.gridViewDetail.Name = "gridViewDetail";
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            this.colId2.Visible = true;
            this.colId2.VisibleIndex = 0;
            // 
            // colSubmittedDate
            // 
            this.colSubmittedDate.FieldName = "SubmittedDate";
            this.colSubmittedDate.Name = "colSubmittedDate";
            this.colSubmittedDate.Visible = true;
            this.colSubmittedDate.VisibleIndex = 1;
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 2;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            // 
            // colContactTelephone
            // 
            this.colContactTelephone.FieldName = "ContactTelephone";
            this.colContactTelephone.Name = "colContactTelephone";
            this.colContactTelephone.Visible = true;
            this.colContactTelephone.VisibleIndex = 4;
            // 
            // colPostalCode1
            // 
            this.colPostalCode1.FieldName = "PostalCode";
            this.colPostalCode1.Name = "colPostalCode1";
            this.colPostalCode1.Visible = true;
            this.colPostalCode1.VisibleIndex = 5;
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 6;
            // 
            // colStreetAddress
            // 
            this.colStreetAddress.FieldName = "StreetAddress";
            this.colStreetAddress.Name = "colStreetAddress";
            this.colStreetAddress.Visible = true;
            this.colStreetAddress.VisibleIndex = 7;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 8;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            // 
            // colFulllName
            // 
            this.colFulllName.FieldName = "FulllName";
            this.colFulllName.Name = "colFulllName";
            this.colFulllName.Visible = true;
            this.colFulllName.VisibleIndex = 10;
            // 
            // colOrderStatusId
            // 
            this.colOrderStatusId.FieldName = "OrderStatusId";
            this.colOrderStatusId.Name = "colOrderStatusId";
            this.colOrderStatusId.Visible = true;
            this.colOrderStatusId.VisibleIndex = 11;
            // 
            // restaurantBindingSource
            // 
            this.restaurantBindingSource.DataSource = typeof(Enterprise.Logic.Entities.Restaurant);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barRefresh,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "Refresh";
            this.barRefresh.Id = 0;
            this.barRefresh.Name = "barRefresh";
            this.barRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRefresh_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(834, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 495);
            this.barDockControlBottom.Size = new System.Drawing.Size(834, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 473);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(834, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 473);
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.ColumnEdit = this.txtDes;
            this.colDescription.FieldName = "ContactTelephone";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsEditForm.ColumnSpan = 2;
            this.colDescription.OptionsEditForm.RowSpan = 5;
            this.colDescription.OptionsEditForm.UseEditorColRowSpan = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 263;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 495);
            this.Controls.Add(this.grcOrder);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Shown += new System.EventHandler(this.FormOrder_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRestaurantRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenuRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenuItemRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpOderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grcOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView grvOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dropdownMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtDes;
        private DevExpress.XtraGrid.Columns.GridColumn colRestaurant;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalForeach;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn colSubmittedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colContactTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colFulllName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderStatusId;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDetailId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colRestaurantName;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailsMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesValues;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailsQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalMenuItem;
        private System.Windows.Forms.BindingSource restaurantBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colContactPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusId;
        private System.Windows.Forms.BindingSource orderStatusBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpOderStatus;
        private DevExpress.XtraBars.BarButtonItem barRefresh;
        private System.Windows.Forms.BindingSource menuLookupBindingSource;
        private System.Windows.Forms.BindingSource restaurantLookupBindingSource;
        private System.Windows.Forms.BindingSource menuItemLookupBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colLookUpRestaurant;
        private DevExpress.XtraGrid.Columns.GridColumn colLookUpMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colLookUpMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpRestaurantRepository;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpMenuRepository;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpMenuItemRepository;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bindingOrder;
    }
}