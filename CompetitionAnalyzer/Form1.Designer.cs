
namespace CompetitionAnalyzer
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_products = new System.Windows.Forms.DataGridView();
            this.label_product_name = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(351, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Verileri Getir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(102, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(567, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 3;
            // 
            // dg_products
            // 
            this.dg_products.AllowUserToAddRows = false;
            this.dg_products.AllowUserToResizeColumns = false;
            this.dg_products.AllowUserToResizeRows = false;
            this.dg_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_products.Location = new System.Drawing.Point(49, 104);
            this.dg_products.Name = "dg_products";
            this.dg_products.Size = new System.Drawing.Size(728, 198);
            this.dg_products.TabIndex = 5;
            // 
            // label_product_name
            // 
            this.label_product_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_product_name.Location = new System.Drawing.Point(101, 31);
            this.label_product_name.Name = "label_product_name";
            this.label_product_name.Size = new System.Drawing.Size(622, 53);
            this.label_product_name.TabIndex = 6;
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(64, 328);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(699, 20);
            this.tb_url.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 466);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label_product_name);
            this.Controls.Add(this.dg_products);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_products;
        private System.Windows.Forms.Label label_product_name;
        private System.Windows.Forms.TextBox tb_url;
    }
}

