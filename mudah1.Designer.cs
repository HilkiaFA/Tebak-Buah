namespace Tebak_Buah
{
    partial class mudah1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mudah1));
            this.btn_tebak = new System.Windows.Forms.Button();
            this.txtbox_isi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tebak
            // 
            this.btn_tebak.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_tebak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tebak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tebak.Location = new System.Drawing.Point(440, 496);
            this.btn_tebak.Name = "btn_tebak";
            this.btn_tebak.Size = new System.Drawing.Size(203, 61);
            this.btn_tebak.TabIndex = 6;
            this.btn_tebak.Text = "Tebak";
            this.btn_tebak.UseVisualStyleBackColor = true;
            this.btn_tebak.Click += new System.EventHandler(this.btn_tebak_Click);
            // 
            // txtbox_isi
            // 
            this.txtbox_isi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbox_isi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbox_isi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_isi.Location = new System.Drawing.Point(324, 407);
            this.txtbox_isi.Multiline = true;
            this.txtbox_isi.Name = "txtbox_isi";
            this.txtbox_isi.Size = new System.Drawing.Size(421, 73);
            this.txtbox_isi.TabIndex = 5;
            this.txtbox_isi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdown_enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_2
            // 
            this.lbl_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbl_2.Location = new System.Drawing.Point(325, 571);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(92, 32);
            this.lbl_2.TabIndex = 13;
            this.lbl_2.Text = "label2";
            this.lbl_2.Visible = false;
            // 
            // lbl_3
            // 
            this.lbl_3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbl_3.Location = new System.Drawing.Point(442, 570);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(92, 32);
            this.lbl_3.TabIndex = 14;
            this.lbl_3.Text = "label2";
            this.lbl_3.Visible = false;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_next.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(881, 579);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(166, 71);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "Lanjut";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Visible = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // mudah1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 671);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_tebak);
            this.Controls.Add(this.txtbox_isi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mudah1";
            this.Text = "Tebak Buah";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tebak;
        private System.Windows.Forms.TextBox txtbox_isi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Button btn_next;
    }
}