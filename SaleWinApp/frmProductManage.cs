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
    public partial class frmProductManagement : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public frmProductManagement()
        {
            InitializeComponent();

            var listS = productRepository.getProductList().Select(x => x.CategoryId).Distinct().ToList();
            cboCateogoryID.Items.Add("All");
            foreach (var s in listS)
            {
                cboCateogoryID.Items.Add(s);
            }
            cboCateogoryID.SelectedItem = 0;
            cboCateogoryID.SelectedIndexChanged += cboCateogoryID_SelectedIndexChanged;
        }


        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            loadProductList();
        }
        private void ClearText()
        {
            txtProductName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            txtWeight.Text = string.Empty;

        }

        public int getcategoryID(string categoryName)
        {
            switch (categoryName)
            {
                case "Dress": return 1;
                case "Shirt": return 2;
                case "Jean": return 3;
            }
            return 0;
        }

        public Product getProductObject()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(cboCategory.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)

                };
                return product;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }

            return null;

        }

        public void loadProductList()
        {
            var products = productRepository.getProductList();
            try
            {


                if (products.Count() != 0)
                {
                    source = new BindingSource();
                    source.DataSource = products;

                    txtProductID.DataBindings.Clear();
                    txtProductName.DataBindings.Clear();
                    txtUnitPrice.DataBindings.Clear();
                    txtUnitsInStock.DataBindings.Clear();
                    txtWeight.DataBindings.Clear();
                    cboCategory.DataBindings.Clear();


                    // Tạo một BindingContext mới cho mỗi control
                    BindingContext productIDContext = new BindingContext();
                    BindingContext categoryContext = new BindingContext();
                    BindingContext productNameContext = new BindingContext();
                    BindingContext weightContext = new BindingContext();
                    BindingContext unitPriceContext = new BindingContext();
                    BindingContext unitsInStockContext = new BindingContext();

                    // Cài đặt BindingContext cho từng control
                    txtProductID.BindingContext = productIDContext;
                    cboCategory.BindingContext = categoryContext;
                    txtProductName.BindingContext = productNameContext;
                    txtWeight.BindingContext = weightContext;
                    txtUnitPrice.BindingContext = unitPriceContext;
                    txtUnitsInStock.BindingContext = unitsInStockContext;



                    // Cài đặt data binding với PropertyChanged event
                    txtProductID.DataBindings.Add("Text", source, "ProductId", true, DataSourceUpdateMode.OnPropertyChanged);
                    cboCategory.DataBindings.Add("Text", source, "CategoryId", true, DataSourceUpdateMode.OnPropertyChanged);
                    txtProductName.DataBindings.Add("Text", source, "ProductName", true, DataSourceUpdateMode.OnPropertyChanged);
                    txtWeight.DataBindings.Add("Text", source, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
                    txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice", true, DataSourceUpdateMode.OnPropertyChanged);
                    txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock", true, DataSourceUpdateMode.OnPropertyChanged);


                    dgvListProduct.DataSource = null;
                    dgvListProduct.DataSource = source;
                    if (products.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;

                    }
                    else
                    {
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }


        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            productRepository.updateProduct(getProductObject());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails
            {
                Text = "Add product",
                ProductRepository = productRepository
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                loadProductList();

                //set focus car inserted
                source.Position = source.Count - 1;
            }
            else
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = getProductObject();
                DialogResult rs = MessageBox.Show("Ban co chac khong ?", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    productRepository.deleteProduct(product.ProductId);
                    MessageBox.Show("Da xoa");
                    loadProductList();
                } else
                {
                    MessageBox.Show("Da huy xoa");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");

            }
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboCateogoryID_SelectedIndexChanged(object sender, EventArgs e)
        {

            source = new BindingSource();
            var list = productRepository.getProductList();
            
            if (cboCateogoryID.SelectedItem != null && cboCateogoryID.SelectedItem.ToString() == "All")
            {
                source.DataSource = list;
            }
            else if (cboCateogoryID.SelectedItem != null)
            {
                source.DataSource = list.Where(x => x.CategoryId == int.Parse(cboCateogoryID.SelectedItem.ToString())).ToList();
            }
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitsInStock.DataBindings.Clear();
            txtWeight.DataBindings.Clear();
            cboCategory.DataBindings.Clear();


            // Tạo một BindingContext mới cho mỗi control
            BindingContext productIDContext = new BindingContext();
            BindingContext categoryContext = new BindingContext();
            BindingContext productNameContext = new BindingContext();
            BindingContext weightContext = new BindingContext();
            BindingContext unitPriceContext = new BindingContext();
            BindingContext unitsInStockContext = new BindingContext();

            // Cài đặt BindingContext cho từng control
            txtProductID.BindingContext = productIDContext;
            cboCategory.BindingContext = categoryContext;
            txtProductName.BindingContext = productNameContext;
            txtWeight.BindingContext = weightContext;
            txtUnitPrice.BindingContext = unitPriceContext;
            txtUnitsInStock.BindingContext = unitsInStockContext;



            // Cài đặt data binding với PropertyChanged event
            txtProductID.DataBindings.Add("Text", source, "ProductId", true, DataSourceUpdateMode.OnPropertyChanged);
            cboCategory.DataBindings.Add("Text", source, "CategoryId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtProductName.DataBindings.Add("Text", source, "ProductName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtWeight.DataBindings.Add("Text", source, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
            txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock", true, DataSourceUpdateMode.OnPropertyChanged);
            dgvListProduct.DataSource = source;
        }
    }
}
