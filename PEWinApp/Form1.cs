using TestLibrary.Data_Access;
using TestLibrary.Data_Access.Repository;
using TestLibrary.Models;

namespace PEWinApp
{
    public partial class Form1 : Form
    {
        IProductRepository repos = new ProductRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        public void loadProduct()
        {
            dgProduct.DataSource = repos.GetProducts().Select(x => new
            {
                Id = x.ProductId,
                Name = x.ProductName,
                CategoryName = x.Category.CategoryName
            }).ToList();
        }

        public void loadCategory()
        {
            //cboCategory.DataSource = 
        }

        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string idProduct = dgProduct.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                IEnumerable<OrderDetail> orderDetails = orderDetailRepository.GetOrderDetails(int.Parse(idProduct));
                dgOrderDetail.DataSource = null;
                dgOrderDetail.DataSource = orderDetails;
            }

        }

    }
}