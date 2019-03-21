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
using Enterprise.AdminUI.RestaurantService;
using System.IO;
using System.Configuration;
using Enterprise.AdminUI.FileService;
using DevExpress.XtraGrid.Views.Grid;
namespace Enterprise.AdminUI.Forms
{
    public partial class FormRestaurants : DevExpress.XtraEditors.XtraForm
    {
        private readonly RestaurantServiceClient _restaurantServiceClient;
        private readonly FileServiceClient _fileServiceClient;
        private readonly MenuService.MenuServiceClient _menuServiceClient;
        public FormRestaurants()
        {
            InitializeComponent();
            _restaurantServiceClient = new RestaurantServiceClient();
            _fileServiceClient = new FileServiceClient();
            _menuServiceClient = new MenuService.MenuServiceClient();
        }
        public void BindData()
        {
            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                var restaurants = _restaurantServiceClient.GetRestaurants();
                var restaurantCategory = _restaurantServiceClient.GetRestaurantCategories();

                if (restaurants == null || !restaurants.Any())
                    return;

                restaurantBindingSource.DataSource = restaurants;
                dropDownCategory.DataSource = restaurantCategory;
                restaurantLookupBindingSource.DataSource = _restaurantServiceClient.GetRestaurants();
                grvRestaurants.OptionsDetail.AllowExpandEmptyDetails = true;
                grvMenu.OptionsDetail.AllowExpandEmptyDetails = true;
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
        private void FormRestaurants_Shown(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnImageLocation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void grvRestaurants_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var restaurant = (Logic.Entities.Restaurant)e.Row;
            _restaurantServiceClient.UpdateRestaurant(restaurant);
        }

        private void grcRestaurants_Click(object sender, EventArgs e)
        {

        }

        private void grvRestaurants_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var item = e.Row as Logic.Entities.Restaurant;
            e.Valid = false;
            if (string.IsNullOrEmpty(item.Name))
            {
                e.ErrorText = "Please enter restaurantName";
            }
            else if (string.IsNullOrEmpty(item.StreetAddress))
            {
                e.ErrorText = "Please enter address";
            }
            else if (string.IsNullOrEmpty(item.State))
            {
                e.ErrorText = "Please enter state";
            }
            else if (string.IsNullOrEmpty(item.LogoImageLocation))
            {
                e.ErrorText = "Please select restaurant logo image";
            }
            else if (string.IsNullOrEmpty(item.MainImageLocation))
            {
                e.ErrorText = "Please select main image logo";
            }
            else if (string.IsNullOrEmpty(item.SmallLogoImageLocation))
            {
                e.ErrorText = "Please select small logo image";
            }
            else if (string.IsNullOrEmpty(item.PostalCode))
            {
                e.ErrorText = "Please enter postal code";
            }
            else
            {
                e.Valid = true;
            }
        }

        private void grvRestaurants_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Shift)
            {
                if (MessageBox.Show("Delete restaurant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                  DialogResult.Yes)
                    return;
                var view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void grvRestaurants_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var item = e.Row as Logic.Entities.Restaurant;
            if (_restaurantServiceClient.DeleteRestaurant(item.Id))
            {
                MessageBox.Show("Restaurant deleted sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grvRestaurants_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            var item = e.Row as Logic.Entities.Restaurant;
            var check = _restaurantServiceClient.IsRestaurantHaveMenu(item.Id);
            if (check)
            {
                if (MessageBox.Show("The selected restaurant is associate with menu, continue delete restaurant, all menus and menu items associate with it?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
                DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void barRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindData();
        }

        private void grvRestaurants_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            var gridView = sender as GridView;
            var currentRow = gridView.GetRow(e.RowHandle) as Logic.Entities.Restaurant;
            e.ChildList = _menuServiceClient.GetMenusByRestaurant(currentRow.Id);
        }

        private void grvRestaurants_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvRestaurants_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Menu";
        }

        private void grvMenu_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var menu = (Logic.Entities.Menu)e.Row;
            if (menu.Id > 0)
            {
                _menuServiceClient.UpdateMenu(menu);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new AddMenu(this);
            form.ShowDialog();
            BindData();
        }

        private void grvMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Shift)
            {
                if (MessageBox.Show("Delete Menu?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                  DialogResult.Yes)
                    return;
                var view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void grvMenu_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var item = e.Row as Logic.Entities.Menu;
            if (_menuServiceClient.DeleteMenu(item.Id))
            {
                MessageBox.Show("Menu deleted sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grvMenu_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            var item = e.Row as Logic.Entities.Menu;
            var check = _menuServiceClient.IsMenuHaveMenuItem(item.Id);
            if (check)
            {
                if (MessageBox.Show("The selected menu is associate with menu item, continue delete menu and menu item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
                DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void lookUpRestaurantMenuItem_EditValueChanged(object sender, EventArgs e)
        {
            //change menu
            var lookUpedit = sender as LookUpEdit;
            var restaurantId = 0;
            var isNumeric = int.TryParse(lookUpedit.Properties.KeyValue.ToString(), out restaurantId);

            if (isNumeric)
            {
                var menuList = _menuServiceClient.GetMenus().Where(t => t.RestaurantId == restaurantId).ToList();
                menuLookUpBinding.DataSource = menuList;
            }
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
            //_restaurantServiceClient.UpdateRestaurant(restaurant);
            var currentMenusetting = _menuServiceClient.GetMenuItem(menuItem.Id);
            menuItem = _menuServiceClient.UpdateMenuItem(menuItem);
            if (menuItem.MenuId.HasValue)
            {
                menuItemModel.Menu = _menuServiceClient.GetMenu(menuItem.MenuId.Value).MenuType;
            }
            if (currentMenusetting.MenuId != menuItemModel.MenuId)
            {
                //refresh data
                //BindData();
                grcRestaurants.Refresh();
                grcRestaurants.RefreshDataSource();
                grvRestaurants.RefreshData();
                grvMenu.RefreshData();
            }

        }

        private void grvMenuItem_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var item = e.Row as Logic.Entities.MenuItemModel;
            if (_menuServiceClient.DeleteMenuItem(item.Id))
            {
                MessageBox.Show("Menu item deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grvMenuItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Shift)
            {
                if (MessageBox.Show("Delete Menu Item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                  DialogResult.Yes)
                    return;
                var view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void grvMenu_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvMenu_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Menu Item";
        }

        private void grvMenu_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            var gridView = sender as GridView;
            var currentRow = gridView.GetRow(e.RowHandle) as Logic.Entities.Menu;
            e.ChildList = _menuServiceClient.GetMenuItemModelByMenu(currentRow.Id);
        }

        private void addMenuItemMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var menuItemForm = new AddMenuItem(this);
            menuItemForm.ShowDialog();
        }

        private void addRestaurantButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addRestaurant = new FormAddRestaurant(this);
            addRestaurant.ShowDialog();
        }

    }
}