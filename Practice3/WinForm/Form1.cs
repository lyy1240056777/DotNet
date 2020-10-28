using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Practice3;

namespace WinForm
{
    
    public partial class Form1 : Form
    {
        public OrderService os;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            os = new OrderService();
            /*
            os.OrderList.Add(new Order
            {
                ID = 1,
                Client = "a",
                DetailsList = new List<OrderDetails>(),
                Total=0
            });
            */
            
            os.Create("lyy");
            os.Create("ww");
            os.Update(1, "cn", 10, 2);
            os.Update(1, "zyh", 6, 1);
            os.Update(2, "lzh", 20, 3);
            using(var db=new OrderContext())
            {
                var order = db.Orders.SingleOrDefault(s => s.ID == 1);
                label1.Text = order.Client;
            }
            orderBS.DataSource = os.GetAllOrders();
            orderBS.ResetBindings(true);
            //dataGridView1.DataSource = os.OrderList;
            /*
            dataGridView1.Columns[1].HeaderText = "客户名";
            dataGridView1.Columns[2].HeaderText = "总价";
            */
            //dataGridView1.Columns[0].Width = 70;
            //dataGridView1.Columns[1].Width = 100;
            //dataGridView1.Columns[2].Width = 100;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var order = os.OrderList.Where(s => s.ID == Convert.ToInt32(dataGridView1[0, index].Value)).FirstOrDefault();
            dataGridView2.DataSource = order.DetailsList;
            dataGridView2.Columns[0].Width = 70;
            /*
            dataGridView2.Columns[0].HeaderText = "商品名";
            dataGridView2.Columns[1].HeaderText = "单价";
            dataGridView2.Columns[2].HeaderText = "数量";
            dataGridView2.Columns[3].HeaderText = "总价";
            */
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[3].Width = 100;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (CreateTb.Text == null)
                MessageBox.Show("Please Enter Client!");
            else
                os.Create(CreateTb.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = os.OrderList;
            CreateTb.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DeleteBtn.Text == null)
                MessageBox.Show("Please Enter ID!");
            else
            {
                bool isDeleted = os.Delete(Int32.Parse(DeleteTb.Text));
                if (isDeleted == false)
                    MessageBox.Show("Invalid ID!");
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = os.OrderList;
            CreateTb.Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.UpdateFunc += new UpdateForm.func(UpdateForm1);
            updateForm.ShowDialog();
            dataGridView2.DataSource = null;
        }

        private bool UpdateForm1(int id, string commodity, double unitPrice, int amount)
        {
            return os.Update(id, commodity, unitPrice, amount);
        }

        private bool ReadForm1(int id,string client,double down,double up,string commodity)
        {
            List<Order> orders1 = os.ReadOrder(id, os.OrderList);
            if (orders1.Count == 0) MessageBox.Show("aaaa");
            List<Order> orders2 = os.ReadOrder(client, orders1);
            if (orders2.Count == 0) MessageBox.Show("bbbb");
            List<Order> orders3 = os.ReadOrder(down, up, orders2);
            List<Order> orders4 = os.ReadDetails(commodity, orders3);
            if (orders4.Count==0) return false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders4;
            return true;
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            ReadForm readForm = new ReadForm();
            readForm.ReadFunc += new ReadForm.func(ReadForm1);
            readForm.ShowDialog();
            dataGridView2.DataSource = null;
        }

        private void ReadAllBtn_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = os.OrderList;
            orderBS.DataSource = os.GetAllOrders();
            orderBS.ResetBindings(false);
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            xml_serializer_manager manager = new xml_serializer_manager();
            string path = @".\Orders.xml";
            os = (OrderService)manager.deserialize_from_xml(path, typeof(OrderService));
            MessageBox.Show("Import Successful!");
            dataGridView1.DataSource = os.OrderList;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            xml_serializer_manager manager = new xml_serializer_manager();
            string path = @".\Orders.xml";
            manager.serialize_to_xml(path, os);
            MessageBox.Show("Export Successful!");
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
        }
    }
}
