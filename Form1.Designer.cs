namespace Tebak_Buah
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mudah = new System.Windows.Forms.Button();
            this.btn_sedang = new System.Windows.Forms.Button();
            this.btn_susah = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(231, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tebak Buah";
            // 
            // btn_mudah
            // 
            this.btn_mudah.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_mudah.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_mudah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mudah.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mudah.Location = new System.Drawing.Point(111, 238);
            this.btn_mudah.Name = "btn_mudah";
            this.btn_mudah.Size = new System.Drawing.Size(215, 133);
            this.btn_mudah.TabIndex = 1;
            this.btn_mudah.Text = "Mudah";
            this.btn_mudah.UseVisualStyleBackColor = false;
            this.btn_mudah.Click += new System.EventHandler(this.btn_mudah_Click);
            // 
            // btn_sedang
            // 
            this.btn_sedang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sedang.BackColor = System.Drawing.Color.Yellow;
            this.btn_sedang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sedang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sedang.Location = new System.Drawing.Point(430, 238);
            this.btn_sedang.Name = "btn_sedang";
            this.btn_sedang.Size = new System.Drawing.Size(215, 133);
            this.btn_sedang.TabIndex = 2;
            this.btn_sedang.Text = "Sedang";
            this.btn_sedang.UseVisualStyleBackColor = false;
            this.btn_sedang.Click += new System.EventHandler(this.btn_sedang_Click);
            // 
            // btn_susah
            // 
            this.btn_susah.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_susah.BackColor = System.Drawing.Color.Red;
            this.btn_susah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_susah.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_susah.Location = new System.Drawing.Point(762, 238);
            this.btn_susah.Name = "btn_susah";
            this.btn_susah.Size = new System.Drawing.Size(215, 133);
            this.btn_susah.TabIndex = 3;
            this.btn_susah.Text = "Susah";
            this.btn_susah.UseVisualStyleBackColor = false;
            this.btn_susah.Click += new System.EventHandler(this.btn_susah_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jenis tantangan";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(471, 449);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 37);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Instagram";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.href_link);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(472, 503);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 32);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Panduan";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btn_keluar
            // 
            this.btn_keluar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_keluar.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_keluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_keluar.Location = new System.Drawing.Point(797, 559);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(180, 46);
            this.btn_keluar.TabIndex = 7;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = false;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1068, 671);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_susah);
            this.Controls.Add(this.btn_sedang);
            this.Controls.Add(this.btn_mudah);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tebak Buah";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mudah;
        private System.Windows.Forms.Button btn_sedang;
        private System.Windows.Forms.Button btn_susah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btn_keluar;
    }
}

