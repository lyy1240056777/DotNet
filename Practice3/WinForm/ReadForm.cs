using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    //查找订单
    public partial class ReadForm : Form
    {
        public delegate bool func(int id, string client, double down, double up, string commodity);
        public func ReadFunc;
        public ReadForm()
        {
            InitializeComponent();
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            int id;
            double down;
            double up;
            if (IDTb.Text == "") id = -1;
            else id = Int32.Parse(IDTb.Text);
            if (DownTb.Text == "" || UpTb.Text == "")
            {
                down = -1;
                up = -1;
            }
            else
            {
                down = double.Parse(DownTb.Text);
                up = double.Parse(UpTb.Text);
            }
            bool isRead = ReadFunc(id, ClientTb.Text, down, up, ComTb.Text);
            if (isRead == false) MessageBox.Show("Form Not Found!");
            else this.Close();
        }
    }
}
