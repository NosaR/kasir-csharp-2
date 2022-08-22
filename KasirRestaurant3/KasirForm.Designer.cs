namespace KasirRestaurant3
{
    partial class KasirForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Laporan1 = new KasirRestaurant3.UserController.UC_Laporan();
            this.uC_Transaksi21 = new KasirRestaurant3.UserController.UC_Transaksi2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Laporan1);
            this.panel2.Controls.Add(this.uC_Transaksi21);
            this.panel2.Location = new System.Drawing.Point(145, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 426);
            this.panel2.TabIndex = 3;
            // 
            // uC_Laporan1
            // 
            this.uC_Laporan1.Location = new System.Drawing.Point(0, 0);
            this.uC_Laporan1.Name = "uC_Laporan1";
            this.uC_Laporan1.Size = new System.Drawing.Size(640, 423);
            this.uC_Laporan1.TabIndex = 4;
            this.uC_Laporan1.Load += new System.EventHandler(this.uC_Laporan1_Load);
            // 
            // uC_Transaksi21
            // 
            this.uC_Transaksi21.Location = new System.Drawing.Point(0, 0);
            this.uC_Transaksi21.Name = "uC_Transaksi21";
            this.uC_Transaksi21.Size = new System.Drawing.Size(640, 418);
            this.uC_Transaksi21.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 426);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Laporan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Transaksi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KasirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "KasirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasirForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KasirForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private UserController.UC_Transaksi2 uC_Transaksi21;
    }
}