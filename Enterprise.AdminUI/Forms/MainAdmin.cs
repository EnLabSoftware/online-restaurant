using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Enterprise.AdminUI.Forms
{
    public partial class MainAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FormRestaurants _restaurant;
        FormMenu _formMenu;
        FormMenuItem _formMenuItem;
        FormOrder _formOder;
        Dashboard _dashBoard;

        public MainAdmin()
        {
            InitializeComponent();
           
        }

        private static void ShowDialogForm(Form form)
        {
            if (form == null)
                return;

            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void ShowForm(Form form)
        {
            if (form == null)
                return;

            form.MdiParent = this;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
          
        }

        private void menuOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_formOder == null || _formOder.IsDisposed)
                _formOder = new FormOrder();

            ShowForm(_formOder);
        }

        private void MainAdmin_Shown(object sender, EventArgs e)
        {
            if (_dashBoard == null || _dashBoard.IsDisposed)
                _dashBoard = new Dashboard();
            ShowForm(_dashBoard);
        }

        private void menuDashBoard_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_dashBoard == null || _dashBoard.IsDisposed)
                _dashBoard = new Dashboard();

            ShowForm(_dashBoard);
        }

        private void menuMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_restaurant == null || _restaurant.IsDisposed)
                _restaurant = new FormRestaurants();
            ShowForm(_restaurant);
        }
    }
}