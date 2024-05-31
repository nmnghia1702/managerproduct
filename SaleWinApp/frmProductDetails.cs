using BusinessObject;
using DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmProductDetails : Form
    {
        public IProductRepository ProductRepository { get; set; }

        public bool InsertOrUpdate { get; set; } // false is insert, true is update

        public frmProductDetails()
        {
            InitializeComponent();
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {

                    CategoryId = int.Parse(cboCategory.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)

                };
                ProductRepository.InsertProduct(product);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
