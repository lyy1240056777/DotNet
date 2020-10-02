namespace WinForm
{
    partial class ReadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientTb = new System.Windows.Forms.TextBox();
            this.DownTb = new System.Windows.Forms.TextBox();
            this.UpTb = new System.Windows.Forms.TextBox();
            this.ComTb = new System.Windows.Forms.TextBox();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReadBtn);
            this.panel1.Controls.Add(this.ComTb);
            this.panel1.Controls.Add(this.UpTb);
            this.panel1.Controls.Add(this.DownTb);
            this.panel1.Controls.Add(this.ClientTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IDTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(88, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 326);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入ID";
            // 
            // IDTb
            // 
            this.IDTb.Location = new System.Drawing.Point(205, 42);
            this.IDTb.Name = "IDTb";
            this.IDTb.Size = new System.Drawing.Size(100, 25);
            this.IDTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入客户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "请输入总价范围";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "请输入商品名";
            // 
            // ClientTb
            // 
            this.ClientTb.Location = new System.Drawing.Point(205, 81);
            this.ClientTb.Name = "ClientTb";
            this.ClientTb.Size = new System.Drawing.Size(100, 25);
            this.ClientTb.TabIndex = 5;
            // 
            // DownTb
            // 
            this.DownTb.Location = new System.Drawing.Point(205, 124);
            this.DownTb.Name = "DownTb";
            this.DownTb.Size = new System.Drawing.Size(42, 25);
            this.DownTb.TabIndex = 6;
            // 
            // UpTb
            // 
            this.UpTb.Location = new System.Drawing.Point(262, 124);
            this.UpTb.Name = "UpTb";
            this.UpTb.Size = new System.Drawing.Size(43, 25);
            this.UpTb.TabIndex = 7;
            // 
            // ComTb
            // 
            this.ComTb.Location = new System.Drawing.Point(205, 165);
            this.ComTb.Name = "ComTb";
            this.ComTb.Size = new System.Drawing.Size(100, 25);
            this.ComTb.TabIndex = 8;
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(156, 242);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadBtn.TabIndex = 9;
            this.ReadBtn.Text = "确 认";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReadForm";
            this.Text = "ReadForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpTb;
        private System.Windows.Forms.TextBox DownTb;
        private System.Windows.Forms.TextBox ClientTb;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.TextBox ComTb;
    }
}