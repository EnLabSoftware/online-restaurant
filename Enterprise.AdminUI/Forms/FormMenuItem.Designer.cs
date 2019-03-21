namespace Enterprise.AdminUI.Forms
{
    partial class FormMenuItem
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grcMenuItem = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceMenuItem = new System.Windows.Forms.BindingSource(this.components);
            this.grvMenuItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestaurant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropdownRestaurant = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingRestaurant = new System.Windows.Forms.BindingSource(this.components);
            this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropdownMenu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingMenu = new System.Windows.Forms.BindingSource(this.components);
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreparationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImageLocation = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDes = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescription = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMenuItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenuItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMenuItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImageLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            this.SuspendLayout();
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
            this.barButtonItem1,
            this.barRefresh});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barRefresh)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "Refresh";
            this.barRefresh.Id = 1;
            this.barRefresh.Name = "barRefresh";
            this.barRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1042, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 632);
            this.barDockControlBottom.Size = new System.Drawing.Size(1042, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 610);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1042, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 610);
            // 
            // grcMenuItem
            // 
            this.grcMenuItem.DataSource = this.bindingSourceMenuItem;
            this.grcMenuItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcMenuItem.Location = new System.Drawing.Point(0, 22);
            this.grcMenuItem.MainView = this.grvMenuItem;
            this.grcMenuItem.Name = "grcMenuItem";
            this.grcMenuItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnImageLocation,
            this.dropdownRestaurant,
            this.dropdownMenu,
            this.txtDescription,
            this.txtDes});
            this.grcMenuItem.Size = new System.Drawing.Size(1042, 610);
            this.grcMenuItem.TabIndex = 4;
            this.grcMenuItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMenuItem});
            this.grcMenuItem.Click += new System.EventHandler(this.grcMenuItem_Click);
            // 
            // bindingSourceMenuItem
            // 
            this.bindingSourceMenuItem.DataSource = typeof(Enterprise.Logic.Entities.MenuItem);
            // 
            // grvMenuItem
            // 
            this.grvMenuItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colRestaurant,
            this.colMenuId,
            this.colPrice,
            this.colPreparationTime,
            this.colImageLocation,
            this.colId,
            this.colDescription,
            this.colMenu});
            this.grvMenuItem.CustomizationFormBounds = new System.Drawing.Rectangle(560, 389, 210, 179);
            this.grvMenuItem.GridControl = this.grcMenuItem;
            this.grvMenuItem.Name = "grvMenuItem";
            this.grvMenuItem.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvMenuItem.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.grvMenuItem.OptionsEditForm.EditFormColumnCount = 2;
            this.grvMenuItem.OptionsView.ShowAutoFilterRow = true;
            this.grvMenuItem.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvMenuItem_InitNewRow);
            this.grvMenuItem.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvMenuItem_RowDeleting);
            this.grvMenuItem.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.grvMenuItem_RowDeleted);
            this.grvMenuItem.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvMenuItem_ValidateRow);
            this.grvMenuItem.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvMenuItem_RowUpdated);
            this.grvMenuItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvMenuItem_KeyDown);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsEditForm.ColumnSpan = 2;
            this.colName.OptionsEditForm.UseEditorColRowSpan = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 137;
            // 
            // colRestaurant
            // 
            this.colRestaurant.Caption = "Restaurant";
            this.colRestaurant.ColumnEdit = this.dropdownRestaurant;
            this.colRestaurant.FieldName = "RestaurantId";
            this.colRestaurant.Name = "colRestaurant";
            this.colRestaurant.Visible = true;
            this.colRestaurant.VisibleIndex = 2;
            this.colRestaurant.Width = 187;
            // 
            // dropdownRestaurant
            // 
            this.dropdownRestaurant.AutoHeight = false;
            this.dropdownRestaurant.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropdownRestaurant.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.dropdownRestaurant.DataSource = this.bindingRestaurant;
            this.dropdownRestaurant.DisplayMember = "Name";
            this.dropdownRestaurant.Name = "dropdownRestaurant";
            this.dropdownRestaurant.NullText = "";
            this.dropdownRestaurant.ValueMember = "Id";
            this.dropdownRestaurant.EditValueChanged += new System.EventHandler(this.dropdownRestaurant_EditValueChanged);
            // 
            // bindingRestaurant
            // 
            this.bindingRestaurant.DataSource = typeof(Enterprise.Logic.Entities.Restaurant);
            // 
            // colMenuId
            // 
            this.colMenuId.Caption = "MenuId";
            this.colMenuId.ColumnEdit = this.dropdownMenu;
            this.colMenuId.FieldName = "MenuId";
            this.colMenuId.Name = "colMenuId";
            this.colMenuId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
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
            this.dropdownMenu.DataSource = this.bindingMenu;
            this.dropdownMenu.DisplayMember = "MenuType";
            this.dropdownMenu.Name = "dropdownMenu";
            this.dropdownMenu.NullText = "";
            this.dropdownMenu.ValueMember = "Id";
            // 
            // bindingMenu
            // 
            this.bindingMenu.DataSource = typeof(Enterprise.Logic.Entities.Menu);
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            this.colPrice.Width = 63;
            // 
            // colPreparationTime
            // 
            this.colPreparationTime.Caption = "Preparation Time";
            this.colPreparationTime.FieldName = "PreparationTime";
            this.colPreparationTime.Name = "colPreparationTime";
            this.colPreparationTime.Visible = true;
            this.colPreparationTime.VisibleIndex = 5;
            this.colPreparationTime.Width = 89;
            // 
            // colImageLocation
            // 
            this.colImageLocation.Caption = "ImageLocation";
            this.colImageLocation.ColumnEdit = this.btnImageLocation;
            this.colImageLocation.FieldName = "ImageLocation";
            this.colImageLocation.Name = "colImageLocation";
            this.colImageLocation.OptionsEditForm.ColumnSpan = 2;
            this.colImageLocation.OptionsEditForm.UseEditorColRowSpan = false;
            this.colImageLocation.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // btnImageLocation
            // 
            this.btnImageLocation.AutoHeight = false;
            this.btnImageLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnImageLocation.Name = "btnImageLocation";
            this.btnImageLocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnImageLocation.Click += new System.EventHandler(this.btnImageLocation_Click);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 54;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.ColumnEdit = this.txtDes;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsEditForm.ColumnSpan = 2;
            this.colDescription.OptionsEditForm.RowSpan = 5;
            this.colDescription.OptionsEditForm.UseEditorColRowSpan = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 271;
            // 
            // txtDes
            // 
            this.txtDes.Name = "txtDes";
            // 
            // colMenu
            // 
            this.colMenu.Caption = "Menu";
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            this.colMenu.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colMenu.ToolTip = "Menu";
            this.colMenu.Visible = true;
            this.colMenu.VisibleIndex = 3;
            this.colMenu.Width = 223;
            // 
            // txtDescription
            // 
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ShowCaretInReadOnly = false;
            // 
            // FormMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 632);
            this.Controls.Add(this.grcMenuItem);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMenuItem";
            this.Text = "FormMenuItem";
            this.Shown += new System.EventHandler(this.FormMenuItem_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMenuItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenuItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMenuItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImageLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grcMenuItem;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPreparationTime;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.BindingSource bindingSourceMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colImageLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnImageLocation;
        private System.Windows.Forms.BindingSource bindingRestaurant;
        private System.Windows.Forms.BindingSource bindingMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dropdownRestaurant;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dropdownMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colRestaurant;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit txtDescription;
        private DevExpress.XtraBars.BarButtonItem barRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtDes;
    }
}