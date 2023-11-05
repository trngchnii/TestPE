using System.Windows.Forms;
using TestLibrary.Data_Access;
using TestLibrary.Data_Access.Repository;
using TestLibrary.Models;

namespace PEWinApp
{
    public partial class Form1 : Form
    {
        IProductRepository repos = new ProductRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategory();
            
        }

        public void LoadProduct()
        {
            dgProduct.Columns.Clear();
            dgProduct.DataSource = repos.GetProducts().Select(x => new
            {
                Id = x.ProductId,
                Name = x.ProductName,
                CategoryName = x.Category.CategoryName,
                Discontinued = x.Discontinued == true ? "Active" : "Block",
                UnitPrice = x.UnitPrice
            }).ToList();

            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
            dataGridViewButtonColumn.Name = "delete";
            dataGridViewButtonColumn.HeaderText = "Action";
            dataGridViewButtonColumn.Text = "Delete";
            dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            dgProduct.Columns.Add(dataGridViewButtonColumn);

        }

        public void LoadCategory()
        {
            cboCategory.DataSource = categoryRepository.GetCategories();
            cboCategory.ValueMember = "CategoryId";
            cboCategory.DisplayMember = "CategoryName";

        }

        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex != -1 || dgProduct.Columns[e.ColumnIndex].Name != "delete")
                {
             
                    int idProduct = int.Parse(dgProduct.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    IEnumerable<OrderDetail> orderDetails = orderDetailRepository.GetOrderDetails(idProduct);
                    dgOrderDetail.DataSource = null;
                    dgOrderDetail.DataSource = orderDetails;

                    Product product = repos.GetProductByID(idProduct);
                    txtId.Text = product.ProductId.ToString();
                    txtName.Text = product.ProductName;
                    cbDiscountinued.Checked = product.Discontinued;
                    cboCategory.SelectedValue = product.CategoryId;
                        if (product.UnitPrice != null)
                        {
                            numUnitPrice.Value = decimal.Parse(product.UnitPrice.ToString());
                        }

                }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != null && txtName.Text != null)
            {
                int id;
                if (int.TryParse(txtId.Text, out id))
                {
                    Product product = repos.GetProductByID(id);
                    product.ProductName = txtName.Text;
                    product.Discontinued = cbDiscountinued.Checked == true;
                    product.CategoryId = int.Parse(cboCategory.SelectedValue.ToString());
                    product.UnitPrice = decimal.Parse(numUnitPrice.Value.ToString());
                    repos.UpdateProduct(product);
                    MessageBox.Show("Update sucessfull");
                    LoadProduct();
                }
                else
                {
                    MessageBox.Show("ID not format");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null)
            {
                Product product = new Product();
                bool checkFormat = true;
                if (txtName.Text.Length < 5)
                {
                    checkFormat = false;
                    MessageBox.Show("Name is not format");
                }
                if (checkFormat)
                {
                    product.ProductName = txtName.Text;
                    product.Discontinued = cbDiscountinued.Checked == true;
                    product.CategoryId = int.Parse(cboCategory.SelectedValue.ToString());
                    product.UnitPrice = decimal.Parse(numUnitPrice.Value.ToString());
                    repos.InsertProduct(product);
                    MessageBox.Show("Add sucessfull");
                    LoadProduct();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtId.Text, out id))
            {
                repos.RemoveProduct(id);
                MessageBox.Show("Delete sucessfull");
                LoadProduct();

            }
            else
            {
                MessageBox.Show("ID not format");
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "txt";
            //saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Bộ lọc tệp
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        foreach (Product item in repos.GetProducts())
                        {
                            sw.WriteLine(item.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Product> products = new List<Product>();
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] arr = line.Split('\t');
                            Product product = new Product();
                            product.ProductId = int.Parse(arr[0]);
                            product.ProductName = arr[1];
                            product.SupplierId = int.Parse(arr[2]);
                            product.CategoryId = int.Parse(arr[3]);
                            product.QuantityPerUnit = arr[4];
                            product.UnitPrice = decimal.Parse(arr[5]);
                            product.UnitsInStock = short.Parse(arr[6]);
                            product.UnitsOnOrder = short.Parse(arr[7]);
                            product.ReorderLevel = short.Parse(arr[8]);
                            product.Discontinued = bool.Parse(arr[9]);
                            products.Add(product);
                        }
                    }
                    dgProductFile.DataSource = products;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProduct.Columns[e.ColumnIndex].Name == "delete")
            {
                int idProduct = int.Parse(dgProduct.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                repos.RemoveProduct(idProduct);
                MessageBox.Show("Delete sucessfull");
                LoadProduct();
            }
        }
    }
}