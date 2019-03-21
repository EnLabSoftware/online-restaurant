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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace Enterprise.AdminUI.Forms
{
    public partial class FormMenu : DevExpress.XtraEditors.XtraForm
    {
        private readonly RestaurantServiceClient _restaurantServiceClient;
        private readonly MenuServiceClient _menuServices;
        public FormMenu()
        {
            InitializeComponent();
            _menuServices = new MenuService.MenuServiceClient();
            _restaurantServiceClient = new RestaurantServiceClient();
        }

        private void BindData()
        {
            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var menus = _menuServices.GetMenus();

                if (menus == null || !menus.Any())
                    return;

                bindingSourceMenu.DataSource = menus;
                bindingSourceRestaurant.DataSource = _restaurantServiceClient.GetRestaurants();
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
        private void FormMenu_Shown(object sender, EventArgs e)
        {
            BindData();
        }

        private void grcMenu_Click(object sender, EventArgs e)
        {

        }

        private void grvMenu_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var menu = (Logic.Entities.Menu)e.Row;

            if (menu.Id == 0)
            {
                var result = _menuServices.AddMenu(menu);
                menu.Id = result.Id;
            }
            else
            {
                _menuServices.UpdateMenu(menu);
            }
        }

        private void btnAddMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvMenu.AddNewRow();
            grvMenu.ShowEditForm();
        }

        private void grvMenu_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var item = e.Row as Logic.Entities.Menu;
            if (_menuServices.DeleteMenu(item.Id))
            {
                MessageBox.Show("Menu deleted sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grvMenu_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            var item = e.Row as Logic.Entities.Menu;
            var check = _menuServices.IsMenuHaveMenuItem(item.Id);
            if (check)
            {
                if (MessageBox.Show("The selected menu is associate with menu item, continue delete menu and menu item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
                DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void grvMenu_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var item = e.Row as Logic.Entities.Menu;
            e.Valid = false;
            if (string.IsNullOrEmpty(item.MenuType))
            {
                e.ErrorText = "Please enter menu type";
            }
            else if (item.RestaurantId <= 0)
            {
                e.ErrorText = "Please select restaurant";
            }
            else if (item.StartDate > item.EndDate)
            {
                e.ErrorText = "End date must be greater than start date";
            }
            else
            {
                e.Valid = true;
            }
        }

        private void grvMenu_KeyDown(object sender, KeyEventArgs e)
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

        private void barRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindData();
        }

        private void grvMenu_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //rebind restaurant
            bindingSourceRestaurant.DataSource = _restaurantServiceClient.GetRestaurants();
        }
    }
}