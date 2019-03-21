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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using Enterprise.Logic.Entities;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using Enterprise.Logic.Utility;

namespace Enterprise.AdminUI.Forms
{
    public partial class FormOrder : DevExpress.XtraEditors.XtraForm
    {
        private readonly CartService.CartServiceClient _cartServiceClient;
        private readonly RestaurantService.RestaurantServiceClient _restaurantServiceClient;
        private readonly MenuService.MenuServiceClient _menuServiceClient;
        public FormOrder()
        {
            InitializeComponent();
            _cartServiceClient = new CartService.CartServiceClient();
            _restaurantServiceClient = new RestaurantService.RestaurantServiceClient();
            _menuServiceClient = new MenuService.MenuServiceClient();
        }

        private void BindData()
        {
            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                orderBindingSource.DataSource = _cartServiceClient.GetOrders();
                //group by order status
                grvOrder.Columns["OrderStatusId"].GroupIndex = 0;
                restaurantBindingSource.DataSource = _restaurantServiceClient.GetRestaurants();
                orderStatusBindingSource.DataSource = _cartServiceClient.GetOrderStatuses();
                restaurantLookupBindingSource.DataSource = _restaurantServiceClient.GetRestaurants();
                //menuLookupBindingSource.DataSource = _menuServiceClient.GetMenus();
                //menuItemLookupBindingSource.DataSource = _menuServiceClient.GetMenuItems();
                grvOrder.OptionsDetail.AllowExpandEmptyDetails = true;

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
        private void FormOrder_Shown(object sender, EventArgs e)
        {
            BindData();
        }

        private void grvOrder_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            var gridView = sender as GridView;
            var currentRow = gridView.GetRow(e.RowHandle) as Order;
            e.ChildList = _cartServiceClient.GetListOrderDetail(currentRow.Id);
        }

        private void grvOrder_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvOrder_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Order Details";
        }

        private void grvOrder_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
        }
        bool IsRelationEmpty(int rowHandle, int relationIndex)
        {
            return false;
        }

        private void grcOrder_Click(object sender, EventArgs e)
        {
        }

        private void grvDetails_RowUpdated(object sender, RowObjectEventArgs e)
        {
            var orderDetailModel = (Logic.Entities.OrderDetailModel)e.Row;
            if (orderDetailModel == null) return;
            if (orderDetailModel.Quantity > 0)
            {
                var orderDetail = _cartServiceClient.UpdateOrderDetailQuantity(orderDetailModel.Id, orderDetailModel.Quantity);
                orderDetailModel.TotalMenuItem = orderDetailModel.Quantity * orderDetailModel.UnitPrice;
                var detailsView = sender as GridView;
                var i = detailsView.SourceRowHandle;
                var order = grvOrder.GetRow(i) as Order;
                var updatedOrder = _cartServiceClient.GetOrder(order.Id);
                order.Total = updatedOrder.Total;
                grvOrder.RefreshRow(i);
            }
            else
            {
                MessageBox.Show("Quantity must be greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grvDetails_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var item = e.Row as Logic.Entities.OrderDetailModel;
            if (item.Quantity <= 0)
            {
                e.ErrorText = "Quantity must be greater than 0";
                e.Valid = false;
            }
        }

        private void grvOrder_RowUpdated(object sender, RowObjectEventArgs e)
        {
            var order = e.Row as Order;
            _cartServiceClient.UpdateOrder(order);
        }

        #region delete
        private void grvOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Shift)
            {
                if (MessageBox.Show("Delete order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                  DialogResult.Yes)
                    return;
                var view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void grvOrder_RowDeleted(object sender, RowDeletedEventArgs e)
        {
            var item = e.Row as Logic.Entities.Order;
            if (_cartServiceClient.DeleteOrder(item.Id))
            {
                MessageBox.Show("Order deleted sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grvDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Shift)
            {
                if (MessageBox.Show("Delete order details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                  DialogResult.Yes)
                    return;
                var view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void grvDetails_RowDeleted(object sender, RowDeletedEventArgs e)
        {
            var item = e.Row as Logic.Entities.OrderDetailModel;
            if (_cartServiceClient.DeleteOrderDetails(item.Id))
            {
                MessageBox.Show("Order Detail deleted sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            var detailsView = sender as GridView;
            var i = detailsView.SourceRowHandle;
            var order = grvOrder.GetRow(i) as Order;
            var updatedOrder = _cartServiceClient.GetOrder(order.Id);
            order.Total = updatedOrder.Total;
            grvOrder.RefreshRow(i);
        }
        #endregion
        private void barRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindData();
        }


        private void txtUnitPrice_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void grvDetails_InitNewRow(object sender, InitNewRowEventArgs e)
        {

        }

        private void grvDetails_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {

        }

        private void lookUpRestaurantRepository_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as LookUpEdit;
            var lookUpValue = lookUp.EditValue.ToString();
            if (string.IsNullOrEmpty(lookUpValue))
            {
                lookUpValue = "0";
            }
            var restaurantId = Int32.Parse(lookUpValue);
            menuLookupBindingSource.DataSource = _menuServiceClient.GetMenusByRestaurant(restaurantId);
        }

        private void lookUpMenuRepository_EditValueChanged_1(object sender, EventArgs e)
        {
            var lookUp = sender as LookUpEdit;
            var lookUpValue = lookUp.EditValue.ToString();
            if (string.IsNullOrEmpty(lookUpValue))
            {
                lookUpValue = "0";
            }
            var menuId = Int32.Parse(lookUpValue);
            menuItemLookupBindingSource.DataSource = _menuServiceClient.GetMenuItemByMenu(menuId);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvOrder.FocusedRowHandle >= 0)
            {
                var abc = 0;
                grvOrder.ExpandMasterRow(grvOrder.FocusedRowHandle);
                var gridView = grvOrder.GetDetailView(grvOrder.FocusedRowHandle, 0) as GridView;
                if (gridView != null)
                {
                    gridView.AddNewRow();
                    //gridView.Focus();
                    gridView.ShowEditForm();
                }
            }
        }

        private void grvDetails_DoubleClick(object sender, EventArgs e)
        {
            var grid = sender as GridView;
            var currentRow = grid.FocusedRowHandle;
        }

        private void grvOrder_MouseDown(object sender, MouseEventArgs e)
        {
            var view = sender as GridView;
            if (view == null)
                return;
            var hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (((e.Button & MouseButtons.Right) != 0) && (hitInfo.InRow) &&
                (!view.IsGroupRow(hitInfo.RowHandle)))
            {
                view.FocusedRowHandle = hitInfo.RowHandle;

                var menu = new ViewMenu(view);

                var menuItem = new DXMenuItem("Add New SubMenu Item", new EventHandler(gridView3_AddNewRow));
                menuItem.Tag = view;
                menu.Items.Add(menuItem);

                //menuItem = new DXMenuItem("Edit Menu Item", new EventHandler(gridView2_EditFocusedRow));
                //menuItem.Tag = view;
                //menu.Items.Add(menuItem);

                menuItem = new DXMenuItem("Delete Menu Item", null);
                menuItem.Tag = view;
                menu.Items.Add(menuItem);

                menu.Show(hitInfo.HitPoint);
            }
        }

        private void gridView3_AddNewRow(object sender, EventArgs e)
        {
            var menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            var focusedView = menuItem.Tag as GridView;
            if (focusedView == null)
                return;

            focusedView.ExpandMasterRow(focusedView.FocusedRowHandle);
            var subMenuItemView = focusedView.GetDetailView(0, 0) as GridView;

            if (subMenuItemView != null)
            {
                subMenuItemView.AddNewRow();
                var rowHandle = subMenuItemView.GetRowHandle(subMenuItemView.DataRowCount);
                if (subMenuItemView.IsNewItemRow(rowHandle))
                {
                    subMenuItemView.SetRowCellValue(rowHandle, subMenuItemView.Columns[0], 0);
                    subMenuItemView.SetRowCellValue(rowHandle, subMenuItemView.Columns[1], 0);
                    subMenuItemView.SetRowCellValue(rowHandle, subMenuItemView.Columns[2], 0);
                }

                subMenuItemView.Focus();
                subMenuItemView.ShowEditForm();
            }
        }

        private void grvOrder_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var item = e.Row as Logic.Entities.Order;
            e.Valid = false;
            if (string.IsNullOrEmpty(item.FulllName))
            {
                e.ErrorText = "Please enter customer Name";
            }
            else if (!ValidateCommon.IsValidEmail(item.Email))
            {
                e.ErrorText = "Please enter correct email address";
            }
            else if (string.IsNullOrEmpty(item.City))
            {
                e.ErrorText = "Please enter city";
            }
            else if (string.IsNullOrEmpty(item.PostalCode))
            {
                e.ErrorText = "Please enter postal code";
            }
            else if (string.IsNullOrEmpty(item.StreetAddress))
            {
                e.ErrorText = "Please enter address";
            }
            else if (string.IsNullOrEmpty(item.State))
            {
                e.ErrorText = "Please enter state";
            }
            else if (item.State.Length > 2)
            {
                e.ErrorText = "State only has 2 characters";
            }
            else if (string.IsNullOrEmpty(item.Email))
            {
                e.ErrorText = "Please Enter Email Address";
            }
            else
            {
                e.Valid = true;
            }
        }

    }
}