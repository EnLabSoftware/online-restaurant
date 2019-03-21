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
using System.IO;

namespace Enterprise.AdminUI.Forms
{
    public partial class FormAddRestaurant : DevExpress.XtraEditors.XtraForm
    {
        
        RestaurantService.RestaurantServiceClient _restaurantServiceClient;
        FileService.FileServiceClient _fileServiceClient;
        private FormRestaurants _formRestaurants;
        public FormAddRestaurant(FormRestaurants formRestaurant)
        {
            InitializeComponent();
            _restaurantServiceClient = new RestaurantService.RestaurantServiceClient();
            bindingCategory.DataSource = _restaurantServiceClient.GetRestaurantCategories();
            _fileServiceClient = new FileService.FileServiceClient();
            _formRestaurants = formRestaurant;
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Add":
                    if (validator.Validate())
                    {
                        var restaurant = new Logic.Entities.Restaurant();
                        restaurant.City = txtState.Text;
                        restaurant.Name = txtName.Text;
                        restaurant.PostalCode = txtStreetAddress.Text;
                        restaurant.RestaurantCategoryId = Int32.Parse(lookUpCategory.EditValue.ToString());

                        restaurant.LogoImageLocation = btnLogoImageLocation.EditValue.ToString();
                        restaurant.MainImageLocation = btnMainImageLocation.EditValue.ToString();
                        restaurant.SmallLogoImageLocation = btnSmallLogoImageLocation.EditValue.ToString();
                        restaurant.BackgroundLocation = btnBackGroundImageLocation.EditValue.ToString();
                        restaurant.BannerImageLocation = btnBannerImageLocation.EditValue.ToString();

                        restaurant.State = txtPosalCode.Text;
                        restaurant.StreetAddress = txtCity.Text;
                        var result = _restaurantServiceClient.AddRestaurant(restaurant);
                        if (result.Id > 0)
                        {
                            MessageBox.Show("Restaurant  was added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnImage_Click(object sender, EventArgs e)
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

        private void Reset()
        {
            txtState.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPosalCode.Text = string.Empty;
            txtCity.Text = string.Empty;
            btnLogoImageLocation.EditValue = null;
            btnMainImageLocation.EditValue = null;
            btnSmallLogoImageLocation.EditValue = null;
            lookUpCategory.EditValue = null;
            btnBackGroundImageLocation.EditValue = null;
            btnBannerImageLocation.EditValue = null;
            txtStreetAddress.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtName.Focus();
        }
    }
}