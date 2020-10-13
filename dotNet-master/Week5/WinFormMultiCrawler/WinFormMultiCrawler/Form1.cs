﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCrawler;

using System.Threading;
using System.Collections.Concurrent;

namespace WinFormMultiCrawler
{

    public partial class Form1 : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        Crawler Crawler = new Crawler();
        Thread thread = null;

        public Form1()
        {
            InitializeComponent();
            dataGridView.DataSource = resultBindingSource;
            Crawler.PageDownloaded += PageDownloaded;
        }

        private void PageDownloaded(Crawler crawler, UrlStates url)
        {
            lock (resultBindingSource)
            {
                var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url.url };
                Action action = () => { resultBindingSource.Add(pageInfo); };
                if (this.InvokeRequired)
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
            resultBindingSource.Clear();
            Crawler.urls = new ConcurrentBag<UrlStates>();
            Crawler.count = 0;
            Crawler.startUrl = textBox1.Text;

            if (thread != null)
            {
                thread.Abort();
            }

            thread = new Thread(Crawler.Crawl);
            thread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)//退出时处理线程
                thread.Abort();
        }
    }
    
}
