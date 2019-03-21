using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Enterprise.AdminUI.MenuService;
using Enterprise.AdminUI.RestaurantService;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using Enterprise.AdminUI.FileService;

namespace Enterprise.AdminUI.Forms
{
    public partial class FormMenuItem : DevExpress.XtraEditors.XtraForm
    {
        private readonly MenuServiceClient _menuServiceClient;
        private readonly RestaurantServiceClient _restaurantServiceClient;
        private readonly FileServiceClient _fileServiceClient;
        public FormMenuItem()
        {
            InitializeComponent();
            _menuServiceClient = new MenuServiceClient();
            _restaurantServiceClient = new RestaurantServiceClient();
            _fileServiceClient = new FileServiceClient();
        }

        private void btnImageLocation_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileName = ofd.SafeFileName.Insert(ofd.SafeFileName.IndexOf("."), DateTime.Now.ToString("yyyymmddffff"));
                var buffer = File.ReadAllBytes(ofd.FileName);
                var fileNameURL = _fileServiceClient.UploadFile(new Logic.Entities.ImageData() { FileName = fileName, FileData = buffer });
                var buttonEdit = sender as ButtonEdit;
                buttonEdit.EditValue = fileNameURL;
            }
        }

        private void dropdownRestaurant_EditValueChanged(object sender, EventArgs e)
        {
            var lookUpedit = sender as LookUpEdit;
            var restaurantId = 0;
            var isNumeric = int.TryParse(lookUpedit.Properties.KeyValue.ToString(), out restaurantId);

            if (isNumeric)
            {
                var menuList = _menuServiceClient.GetMenus().Where(t => t.RestaurantId == restaurantId).ToList();
                dropdownMenu.DataSource = menuList;
                bindingMenu.DataSource = menuList;
            }
        }

        private void BindData()
        {
            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var items = _menuServiceClient.GetMenuItemModels();
                bindingSourceMenuItem.DataSource = _menuServiceClient.GetMenuItemModels();
                dropdownRestaurant.DataSource = _restaurantServiceClient.GetRestaurants();
                bindingMenu.DataSource = _menuServiceClient.GetMenus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Owner, ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void FormMenuItem_Shown(object sender, EventArgs e)
        {
            BindData();

        }

        private void grcMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvMenuItem.AddNewRow();
            grvMenuItem.ShowEditForm();
        }

        private void grvMenuItem_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var menuItemModel = (Logic.Entities.MenuItemModel)e.Row;

            var menuItem = new Logic.Entities.MenuItem();
            menuItem.Id = menuItemModel.Id;
            menuItem.ImageLocation = menuItemModel.ImageLocation;
            menuItem.MenuId = menuItemModel.MenuId;
            menuItem.Name = menuItemModel.Name;
            menuItem.PreparationTime = menuItemModel.PreparationTime;
            menuItem.Price = menuItemModel.Price;
            menuItem.Description = menuItemModel.Description;
            if (menuItem.Id == 0)
            {
                menuItem = _menuServiceClient.AddMenuItem(menuItem);
                //var result = _restaurantServiceClient.AddRestaurant(restaurant);
                menuItemModel.Id = menuItem.Id;
            }
            else
            {
                //_restaurantServiceClient.UpdateRestaurant(restaurant);
                menuItem = _menuServiceClient.UpdateMenuItem(menuItem);
            }
            if (menuItem.MenuId.HasValue)
            {
                menuItemModel.Menu = _menuServiceClient.GetMenu(menuItem.MenuId.Value).MenuType;
            }
        }

        private void grvMenuItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Shift)
            {
                if (MessageBox.Show("Delete Menu item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                  DialogResult.Yes)
                    return;
                var view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void grvMenuItem_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var menuItemModel = (Logic.Entities.MenuItemModel)e.Row;
            if (_menuServiceClient.DeleteMenuItem(menuItemModel.Id))
            {
                MessageBox.Show("Menu Item deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grvMenuItem_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            var menuItemModel = (Logic.Entities.MenuItemModel)e.Row;
        }

        private void grvMenuItem_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var menuItemModel = e.Row as Logic.Entities.MenuItemModel;
            e.Valid = false;
            if (string.IsNullOrEmpty(menuItemModel.Name))
            {
                e.ErrorText = "Please enter name.";
            }
            else if (menuItemModel.MenuId <= 0)
            {
                e.ErrorText = "Please select menu.";
            }
            else if (menuItemModel.Price <= 0)
            {
                e.ErrorText = "The price must be greater than 0.";
            }
            else if (string.IsNullOrEmpty(menuItemModel.ImageLocation))
            {
                e.ErrorText = "Please select image.";
            }

            else if (menuItemModel.PreparationTime < 0)
            {
                e.ErrorText = "The PreparationTime must be greater than 0.";
            }
            else
            {
                e.Valid = true;
            }
        }

        private void barRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindData();
        }

        private void grvMenuItem_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //rebind data
            dropdownRestaurant.DataSource = _restaurantServiceClient.GetRestaurants();
            bindingMenu.DataSource = _menuServiceClient.GetMenus();
        }
    }
}