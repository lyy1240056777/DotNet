namespace WinForm
{
    partial class UpdateForm
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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitPTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CommoTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.AmountTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.UnitPTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CommoTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IDTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(130, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 299);
            this.panel1.TabIndex = 0;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(99, 247);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "确 认";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AmountTb
            // 
            this.AmountTb.Location = new System.Drawing.Point(135, 192);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(100, 25);
            this.AmountTb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "请输入数量";
            // 
            // UnitPTb
            // 
            this.UnitPTb.Location = new System.Drawing.Point(135, 137);
            this.UnitPTb.Name = "UnitPTb";
            this.UnitPTb.Size = new System.Drawing.Size(100, 25);
            this.UnitPTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "请输入单价";
            // 
            // CommoTb
            // 
            this.CommoTb.Location = new System.Drawing.Point(135, 86);
            this.CommoTb.Name = "CommoTb";
            this.CommoTb.Size = new System.Drawing.Size(100, 25);
            this.CommoTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入商品";
            // 
            // IDTb
            // 
            this.IDTb.Location = new System.Drawing.Point(135, 35);
            this.IDTb.Name = "IDTb";
            this.IDTb.Size = new System.Drawing.Size(100, 25);
            this.IDTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入ID";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 323);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UnitPTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CommoTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Label label4;
    }
}