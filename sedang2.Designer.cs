namespace Tebak_Buah
{
    partial class sedang2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sedang2));
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_tebak = new System.Windows.Forms.Button();
            this.box_isi = new System.Windows.Forms.TextBox();
            this.ft_2 = new System.Windows.Forms.PictureBox();
            this.ft_1 = new System.Windows.Forms.PictureBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ft_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ft_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_3
            // 
            this.lbl_3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbl_3.Location = new System.Drawing.Point(325, 530);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(92, 32);
            this.lbl_3.TabIndex = 15;
            this.lbl_3.Text = "label3";
            this.lbl_3.Visible = false;
            // 
            // lbl_2
            // 
            this.lbl_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbl_2.Location = new System.Drawing.Point(442, 530);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(92, 32);
            this.lbl_2.TabIndex = 14;
            this.lbl_2.Text = "label2";
            this.lbl_2.Visible = false;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(899, 585);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(140, 56);
            this.btn_next.TabIndex = 13;
            this.btn_next.Text = "Lanjut";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Visible = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_tebak
            // 
            this.btn_tebak.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_tebak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tebak.Location = new System.Drawing.Point(448, 461);
            this.btn_tebak.Name = "btn_tebak";
            this.btn_tebak.Size = new System.Drawing.Size(193, 51);
            this.btn_tebak.TabIndex = 12;
            this.btn_tebak.Text = "Tebak";
            this.btn_tebak.UseVisualStyleBackColor = true;
            this.btn_tebak.Click += new System.EventHandler(this.btn_tebak_Click);
            // 
            // box_isi
            // 
            this.box_isi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_isi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_isi.Location = new System.Drawing.Point(369, 375);
            this.box_isi.Multiline = true;
            this.box_isi.Name = "box_isi";
            this.box_isi.Size = new System.Drawing.Size(344, 63);
            this.box_isi.TabIndex = 11;
            this.box_isi.TextChanged += new System.EventHandler(this.box_isi_TextChanged);
            this.box_isi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown_enter);
            // 
            // ft_2
            // 
            this.ft_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ft_2.BackColor = System.Drawing.Color.Transparent;
            this.ft_2.Image = ((System.Drawing.Image)(resources.GetObject("ft_2.Image")));
            this.ft_2.Location = new System.Drawing.Point(301, 83);
            this.ft_2.Name = "ft_2";
            this.ft_2.Size = new System.Drawing.Size(470, 270);
            this.ft_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ft_2.TabIndex = 10;
            this.ft_2.TabStop = false;
            this.ft_2.Visible = false;
            // 
            // ft_1
            // 
            this.ft_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ft_1.BackColor = System.Drawing.Color.Transparent;
            this.ft_1.Image = ((System.Drawing.Image)(resources.GetObject("ft_1.Image")));
            this.ft_1.Location = new System.Drawing.Point(301, 83);
            this.ft_1.Name = "ft_1";
            this.ft_1.Size = new System.Drawing.Size(470, 270);
            this.ft_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ft_1.TabIndex = 9;
            this.ft_1.TabStop = false;
            // 
            // lbl_1
            // 
            this.lbl_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(474, 30);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(122, 38);
            this.lbl_1.TabIndex = 8;
            this.lbl_1.Text = "Level 2";
            // 
            // sedang2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 671);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_tebak);
            this.Controls.Add(this.box_isi);
            this.Controls.Add(this.ft_2);
            this.Controls.Add(this.ft_1);
            this.Controls.Add(this.lbl_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sedang2";
            this.Text = "Tebak Buah";
            ((System.ComponentModel.ISupportInitialize)(this.ft_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ft_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_tebak;
        private System.Windows.Forms.TextBox box_isi;
        private System.Windows.Forms.PictureBox ft_2;
        private System.Windows.Forms.PictureBox ft_1;
        private System.Windows.Forms.Label lbl_1;
    }
}