using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Concurrent;

namespace Practice5_Crawler
{
    public partial class Form1 : Form
    {
        BindingSource bindingSource = new BindingSource();
        Crawler crawler = new Crawler();
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource;
            crawler.PageDownloaded += PageDownloaded;
        }

        private void PageDownloaded(Crawler crawler,Url url)
        {
            lock(bindingSource)
            {
                var pageInfo = new
                {
                    Index = bindingSource.Count + 1,
                    URL = url.url
                };
                Action action = () => { bindingSource.Add(pageInfo); };
                if(this.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else
                {
                    action();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
            crawler.urlBag = new ConcurrentBag<Url>();
            crawler.count = 0;
            crawler.startUrl = textBox1.Text;

            if (thread != null)
            {
                thread.Abort();
            }

            thread = new Thread(crawler.Crawl);
            thread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
        }
    }
}
