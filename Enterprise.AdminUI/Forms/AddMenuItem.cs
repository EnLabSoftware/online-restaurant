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
using DevExpress.XtraBars.Docking2010;
using System.IO;

namespace Enterprise.AdminUI.Forms
{
    public partial class AddMenuItem : DevExpress.XtraEditors.XtraForm
    {
        private readonly RestaurantService.RestaurantServiceClient _restaurantServiceClient;
        private readonly MenuService.MenuServiceClient _menuServiceClient;
        private readonly FileService.FileServiceClient _fileServiceClient;
        private readonly FormRestaurants _formRestaurants;

        public AddMenuItem(FormRestaurants formRestaurants)
        {
            InitializeComponent();
            _restaurantServiceClient = new RestaurantService.RestaurantServiceClient();
            _menuServiceClient = new MenuService.MenuServiceClient();
            bindingRestaurant.DataSource = _restaurantServiceClient.GetRestaurants();
            _fileServiceClient = new FileService.FileServiceClient();
            _formRestaurants = formRestaurants;
        }

        private void lookUpRestaurant_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as LookUpEdit;
            if (edit.EditValue != null)
            {
                var editValue = edit.EditValue.ToString();
                var restaurantId = 0;
                var isNumeric = Int32.TryParse(editValue, out  restaurantId);
                if (isNumeric)
                {
                    var menuList = _menuServiceClient.GetMenus().Where(t => t.RestaurantId == restaurantId).ToList();
                    bindingMenu.DataSource = menuList;
                }
            }
        }

        private void txtImage_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtImage_Click(object sender, EventArgs e)
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

        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Add":
                    if (validateProvider.Validate())
                    {
                        var menuItem = new Logic.Entities.MenuItem();
                        menuItem.MenuId = Int32.Parse(lookUpmenu.EditValue.ToString());
                        menuItem.Name = txtName.Text;
                        menuItem.Price = decimal.Parse(txtPrice.Text);
                        menuItem.PreparationTime = Int32.Parse(txtPreparationTime.Text);
                        menuItem.ImageLocation = txtImage.Text;
                        var returnReuslt = _menuServiceClient.AddMenuItem(menuItem);
                        if (returnReuslt != null)
                        {
                            MessageBox.Show("Menu item added sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lookUpmenu.EditValue = null;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtPreparationTime.Text = string.Empty;
            txtImage.Text = string.Empty;
            lookUpRestaurant.EditValue = null;
            txtDescription.Text = string.Empty;
            txtImage.EditValue = null;
            lookUpRestaurant.Focus();
        }
    }
}