﻿namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateTb = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.DeleteTb = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.ReadAllBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.CreateTb);
            this.flowLayoutPanel1.Controls.Add(this.CreateBtn);
            this.flowLayoutPanel1.Controls.Add(this.DeleteTb);
            this.flowLayoutPanel1.Controls.Add(this.DeleteBtn);
            this.flowLayoutPanel1.Controls.Add(this.UpdateBtn);
            this.flowLayoutPanel1.Controls.Add(this.ReadBtn);
            this.flowLayoutPanel1.Controls.Add(this.ReadAllBtn);
            this.flowLayoutPanel1.Controls.Add(this.ImportBtn);
            this.flowLayoutPanel1.Controls.Add(this.ExportBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(821, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // CreateTb
            // 
            this.CreateTb.Location = new System.Drawing.Point(17, 3);
            this.CreateTb.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.CreateTb.Name = "CreateTb";
            this.CreateTb.Size = new System.Drawing.Size(61, 25);
            this.CreateTb.TabIndex = 9;
            // 
            // CreateBtn
            // 
            this.CreateBtn.AutoSize = true;
            this.CreateBtn.Location = new System.Drawing.Point(78, 3);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(77, 25);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "增加订单";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // DeleteTb
            // 
            this.DeleteTb.Location = new System.Drawing.Point(168, 3);
            this.DeleteTb.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.DeleteTb.Name = "DeleteTb";
            this.DeleteTb.Size = new System.Drawing.Size(62, 25);
            this.DeleteTb.TabIndex = 10;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = true;
            this.DeleteBtn.Location = new System.Drawing.Point(230, 3);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(77, 25);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "删除订单";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AutoSize = true;
            this.UpdateBtn.Location = new System.Drawing.Point(320, 3);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(77, 25);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "修改订单";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.AutoSize = true;
            this.ReadBtn.Location = new System.Drawing.Point(410, 3);
            this.ReadBtn.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(77, 25);
            this.ReadBtn.TabIndex = 6;
            this.ReadBtn.Text = "查找订单";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // ReadAllBtn
            // 
            this.ReadAllBtn.AutoSize = true;
            this.ReadAllBtn.Location = new System.Drawing.Point(487, 3);
            this.ReadAllBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ReadAllBtn.Name = "ReadAllBtn";
            this.ReadAllBtn.Size = new System.Drawing.Size(77, 25);
            this.ReadAllBtn.TabIndex = 11;
            this.ReadAllBtn.Text = "查看全部";
            this.ReadAllBtn.UseVisualStyleBackColor = true;
            this.ReadAllBtn.Click += new System.EventHandler(this.ReadAllBtn_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.AutoSize = true;
            this.ImportBtn.Location = new System.Drawing.Point(577, 3);
            this.ImportBtn.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(77, 25);
            this.ImportBtn.TabIndex = 7;
            this.ImportBtn.Text = "导入订单";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.AutoSize = true;
            this.ExportBtn.Location = new System.Drawing.Point(654, 3);
            this.ExportBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(77, 25);
            this.ExportBtn.TabIndex = 8;
            this.ExportBtn.Text = "导出订单";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 51);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(368, 387);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(365, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.dataGridView2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(386, 51);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(447, 387);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(444, 295);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox CreateTb;
        private System.Windows.Forms.TextBox DeleteTb;
        private System.Windows.Forms.Button ReadAllBtn;
    }
}

