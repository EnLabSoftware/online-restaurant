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

namespace Enterprise.AdminUI.Forms
{
    public partial class AddMenu : DevExpress.XtraEditors.XtraForm
    {
        MenuService.MenuServiceClient _menuServiceClient;
        RestaurantService.RestaurantServiceClient _restaurantServiceClient;
        private FormRestaurants _formRestaurants;
        public AddMenu(FormRestaurants formRestaurants)
        {
            InitializeComponent();
            _menuServiceClient = new MenuService.MenuServiceClient();
            _restaurantServiceClient = new RestaurantService.RestaurantServiceClient();
            bindingRestaurant.DataSource = _restaurantServiceClient.GetRestaurants();
            _formRestaurants = formRestaurants;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddMenu_Load(object sender, EventArgs e)
        {

        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Add":
                    if (validator.Validate())
                    {
                        var restaurantId = Int32.Parse(lookUpRestaurant.EditValue.ToString());
                        var menu = new Logic.Entities.Menu();
                        menu.MenuType = txtMenu.Text;
                        menu.StartDate = DateTime.Parse(dateStartDate.EditValue.ToString());
                        menu.EndDate = DateTime.Parse(dateEndDate.EditValue.ToString());
                        menu.RestaurantId = restaurantId;
                        var addedMenu = _menuServiceClient.AddMenu(menu);
                        if (addedMenu != null)
                        {
                            MessageBox.Show("Menu created sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reset();
                            _formRestaurants.BindData();
                        }
                    }
                    break;
                case "Cancel":
                    this.Dispose();
                    break;

                default:
                    break;
            }
        }
        private void Reset()
        {
            lookUpRestaurant.EditValue = null;
            txtMenu.Text = string.Empty;
            dateStartDate.EditValue = null;
            dateEndDate.EditValue = null;
            txtMenu.Focus();
        }
    }
}