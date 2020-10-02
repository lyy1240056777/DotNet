using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice3;

namespace WinForm
{
    //修改订单
    public partial class UpdateForm : Form
    {
        public delegate bool func(int id, string commodity, double unitPrice, int amount);
        public func UpdateFunc;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (IDTb.Text == null || CommoTb.Text == null || UnitPTb.Text == null || AmountTb.Text == null)
                MessageBox.Show("Incomplete Infomation!");
            else
            {
                bool isUpdated = UpdateFunc(Int32.Parse(IDTb.Text), CommoTb.Text, double.Parse(UnitPTb.Text),
                    Int32.Parse(AmountTb.Text));
                if (isUpdated == false)
                    MessageBox.Show("Invalid ID!");
                else
                    this.Close();
            }
        }
    }
}
