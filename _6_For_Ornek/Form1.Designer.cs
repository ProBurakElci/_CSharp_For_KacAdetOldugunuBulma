namespace _6_For_Ornek
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
            this.lsbSayilar = new System.Windows.Forms.ListBox();
            this.txtAranacak = new System.Windows.Forms.TextBox();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.btnKactane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbSayilar
            // 
            this.lsbSayilar.FormattingEnabled = true;
            this.lsbSayilar.ItemHeight = 16;
            this.lsbSayilar.Location = new System.Drawing.Point(16, 15);
            this.lsbSayilar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbSayilar.Name = "lsbSayilar";
            this.lsbSayilar.Size = new System.Drawing.Size(159, 228);
            this.lsbSayilar.TabIndex = 0;
            // 
            // txtAranacak
            // 
            this.txtAranacak.Location = new System.Drawing.Point(204, 98);
            this.txtAranacak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAranacak.Name = "txtAranacak";
            this.txtAranacak.Size = new System.Drawing.Size(132, 22);
            this.txtAranacak.TabIndex = 1;
            this.txtAranacak.TextChanged += new System.EventHandler(this.txtAranacak_TextChanged);
            // 
            // btnDoldur
            // 
            this.btnDoldur.Location = new System.Drawing.Point(204, 15);
            this.btnDoldur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(100, 28);
            this.btnDoldur.TabIndex = 2;
            this.btnDoldur.Text = "DOLDUR";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // btnKactane
            // 
            this.btnKactane.Location = new System.Drawing.Point(204, 130);
            this.btnKactane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKactane.Name = "btnKactane";
            this.btnKactane.Size = new System.Drawing.Size(133, 32);
            this.btnKactane.TabIndex = 3;
            this.btnKactane.Text = "Kaç tane var?";
            this.btnKactane.UseVisualStyleBackColor = true;
            this.btnKactane.Click += new System.EventHandler(this.btnKactane_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 373);
            this.Controls.Add(this.btnKactane);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.txtAranacak);
            this.Controls.Add(this.lsbSayilar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbSayilar;
        private System.Windows.Forms.TextBox txtAranacak;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.Button btnKactane;
    }
}

