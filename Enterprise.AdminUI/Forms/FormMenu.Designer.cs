namespace Enterprise.AdminUI.Forms
{
    partial class FormMenu
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
            this.btnAddMenu = new DevExpress.XtraBars.BarButtonItem();
            this.barRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.grcMenu = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceMenu = new System.Windows.Forms.BindingSource(this.components);
            this.grvMenu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMenuType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestaurantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropDownRestaurant = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceRestaurant = new System.Windows.Forms.BindingSource(this.components);
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brnStartDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEndDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnStartDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEndDate.CalendarTimeProperties)).BeginInit();
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
            this.barSubItem1,
            this.btnAddMenu,
            this.barRefresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barRefresh)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Caption = "Add";
            this.btnAddMenu.Id = 1;
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddMenu_ItemClick);
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "Refresh";
            this.barRefresh.Id = 2;
            this.barRefresh.Name = "barRefresh";
            this.barRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(585, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 343);
            this.barDockControlBottom.Size = new System.Drawing.Size(585, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 321);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(585, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 321);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // grcMenu
            // 
            this.grcMenu.DataSource = this.bindingSourceMenu;
            this.grcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcMenu.Location = new System.Drawing.Point(0, 22);
            this.grcMenu.MainView = this.grvMenu;
            this.grcMenu.Name = "grcMenu";
            this.grcMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropDownRestaurant,
            this.brnStartDate,
            this.btnEndDate});
            this.grcMenu.Size = new System.Drawing.Size(585, 321);
            this.grcMenu.TabIndex = 4;
            this.grcMenu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMenu});
            this.grcMenu.Click += new System.EventHandler(this.grcMenu_Click);
            // 
            // bindingSourceMenu
            // 
            this.bindingSourceMenu.DataSource = typeof(Enterprise.Logic.Entities.Menu);
            // 
            // grvMenu
            // 
            this.grvMenu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMenuType,
            this.colRestaurantId,
            this.colStartDate,
            this.colEndDate,
            this.colId});
            this.grvMenu.CustomizationFormBounds = new System.Drawing.Rectangle(560, 389, 210, 179);
            this.grvMenu.GridControl = this.grcMenu;
            this.grvMenu.Name = "grvMenu";
            this.grvMenu.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvMenu.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.grvMenu.OptionsEditForm.EditFormColumnCount = 2;
            this.grvMenu.OptionsView.ShowAutoFilterRow = true;
            this.grvMenu.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvMenu_InitNewRow);
            this.grvMenu.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvMenu_RowDeleting);
            this.grvMenu.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.grvMenu_RowDeleted);
            this.grvMenu.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvMenu_ValidateRow);
            this.grvMenu.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvMenu_RowUpdated);
            this.grvMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvMenu_KeyDown);
            // 
            // colMenuType
            // 
            this.colMenuType.FieldName = "MenuType";
            this.colMenuType.Name = "colMenuType";
            this.colMenuType.Visible = true;
            this.colMenuType.VisibleIndex = 1;
            this.colMenuType.Width = 143;
            // 
            // colRestaurantId
            // 
            this.colRestaurantId.Caption = "Restaurant";
            this.colRestaurantId.ColumnEdit = this.dropDownRestaurant;
            this.colRestaurantId.FieldName = "RestaurantId";
            this.colRestaurantId.Name = "colRestaurantId";
            this.colRestaurantId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRestaurantId.Visible = true;
            this.colRestaurantId.VisibleIndex = 2;
            this.colRestaurantId.Width = 73;
            // 
            // dropDownRestaurant
            // 
            this.dropDownRestaurant.AutoHeight = false;
            this.dropDownRestaurant.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropDownRestaurant.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Restaurant")});
            this.dropDownRestaurant.DataSource = this.bindingSourceRestaurant;
            this.dropDownRestaurant.DisplayMember = "Name";
            this.dropDownRestaurant.Name = "dropDownRestaurant";
            this.dropDownRestaurant.ValueMember = "Id";
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Start Date";
            this.colStartDate.ColumnEdit = this.brnStartDate;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 3;
            this.colStartDate.Width = 109;
            // 
            // brnStartDate
            // 
            this.brnStartDate.AutoHeight = false;
            this.brnStartDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.brnStartDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.brnStartDate.Name = "brnStartDate";
            // 
            // colEndDate
            // 
            this.colEndDate.ColumnEdit = this.btnEndDate;
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 4;
            this.colEndDate.Width = 110;
            // 
            // btnEndDate
            // 
            this.btnEndDate.AutoHeight = false;
            this.btnEndDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.btnEndDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.btnEndDate.Name = "btnEndDate";
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
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 343);
            this.Controls.Add(this.grcMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Shown += new System.EventHandler(this.FormMenu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnStartDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEndDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEndDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnAddMenu;
        private DevExpress.XtraGrid.GridControl grcMenu;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuType;
        private DevExpress.XtraGrid.Columns.GridColumn colRestaurantId;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.BindingSource bindingSourceMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dropDownRestaurant;
        private System.Windows.Forms.BindingSource bindingSourceRestaurant;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit brnStartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit btnEndDate;
        private DevExpress.XtraBars.BarButtonItem barRefresh;

    }
}