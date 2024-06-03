namespace c_Sharp_tinhtong
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblso1 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.lblso2 = new System.Windows.Forms.Label();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.btntinhtong = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblso1
            // 
            this.lblso1.AutoSize = true;
            this.lblso1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblso1.Location = new System.Drawing.Point(166, 90);
            this.lblso1.Name = "lblso1";
            this.lblso1.Size = new System.Drawing.Size(27, 13);
            this.lblso1.TabIndex = 0;
            this.lblso1.Text = "số 1";
            this.lblso1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(365, 83);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 1;
            this.txtso1.Text = "2";
            this.txtso1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblso2
            // 
            this.lblso2.AutoSize = true;
            this.lblso2.Location = new System.Drawing.Point(166, 130);
            this.lblso2.Name = "lblso2";
            this.lblso2.Size = new System.Drawing.Size(27, 13);
            this.lblso2.TabIndex = 2;
            this.lblso2.Text = "số 2";
            this.lblso2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(365, 123);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 3;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(297, 173);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 4;
            this.lblkq.Text = "kết quả";
            this.lblkq.Click += new System.EventHandler(this.label3_Click);
            // 
            // btntinhtong
            // 
            this.btntinhtong.Location = new System.Drawing.Point(239, 255);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(304, 79);
            this.btntinhtong.TabIndex = 5;
            this.btntinhtong.Text = "button1";
            this.btntinhtong.UseVisualStyleBackColor = true;
            this.btntinhtong.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(365, 166);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btntinhtong);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.lblso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.lblso1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "chuong trinh tinh tong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblso1;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Label lblso2;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.TextBox txtkq;
    }
}

