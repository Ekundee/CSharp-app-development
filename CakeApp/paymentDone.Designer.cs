
namespace _19cg026424_CakeApp
{
    partial class paymentDone
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
            this.label1 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Done \r\nRedirecting to Home page now >>>\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-5, 58);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(806, 402);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.DimGray;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(173, 250);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(425, 10);
            this.materialDivider2.TabIndex = 2;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // paymentDone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialDivider1);
            this.Name = "paymentDone";
            this.Text = "paymentDone";
            this.Load += new System.EventHandler(this.paymentDone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}