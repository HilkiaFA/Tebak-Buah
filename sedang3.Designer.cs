namespace Tebak_Buah
{
    partial class sedang3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sedang3));
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.img_1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_selesai = new System.Windows.Forms.Button();
            this.btn_tebak = new System.Windows.Forms.Button();
            this.txtbox_isi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_1
            // 
            this.pic_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_1.Image = ((System.Drawing.Image)(resources.GetObject("pic_1.Image")));
            this.pic_1.Location = new System.Drawing.Point(-5, -4);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(1081, 680);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_1.TabIndex = 0;
            this.pic_1.TabStop = false;
            this.pic_1.Visible = false;
            // 
            // img_1
            // 
            this.img_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img_1.BackColor = System.Drawing.Color.Transparent;
            this.img_1.ErrorImage = null;
            this.img_1.Image = ((System.Drawing.Image)(resources.GetObject("img_1.Image")));
            this.img_1.Location = new System.Drawing.Point(252, 120);
            this.img_1.Name = "img_1";
            this.img_1.Size = new System.Drawing.Size(553, 252);
            this.img_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_1.TabIndex = 49;
            this.img_1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 42);
            this.label1.TabIndex = 48;
            this.label1.Text = "Level 3";
            // 
            // btn_selesai
            // 
            this.btn_selesai.Location = new System.Drawing.Point(903, 593);
            this.btn_selesai.Name = "btn_selesai";
            this.btn_selesai.Size = new System.Drawing.Size(139, 62);
            this.btn_selesai.TabIndex = 47;
            this.btn_selesai.Text = "Selesai";
            this.btn_selesai.UseVisualStyleBackColor = true;
            this.btn_selesai.Visible = false;
            this.btn_selesai.Click += new System.EventHandler(this.btn_selesai_Click);
            // 
            // btn_tebak
            // 
            this.btn_tebak.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_tebak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tebak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tebak.Location = new System.Drawing.Point(434, 495);
            this.btn_tebak.Name = "btn_tebak";
            this.btn_tebak.Size = new System.Drawing.Size(203, 61);
            this.btn_tebak.TabIndex = 46;
            this.btn_tebak.Text = "Tebak";
            this.btn_tebak.UseVisualStyleBackColor = true;
            this.btn_tebak.Click += new System.EventHandler(this.btn_tebak_Click);
            // 
            // txtbox_isi
            // 
            this.txtbox_isi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbox_isi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbox_isi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_isi.Location = new System.Drawing.Point(318, 406);
            this.txtbox_isi.Multiline = true;
            this.txtbox_isi.Name = "txtbox_isi";
            this.txtbox_isi.Size = new System.Drawing.Size(421, 73);
            this.txtbox_isi.TabIndex = 45;
            this.txtbox_isi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown_enter);
            // 
            // sedang3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 671);
            this.Controls.Add(this.img_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selesai);
            this.Controls.Add(this.btn_tebak);
            this.Controls.Add(this.txtbox_isi);
            this.Controls.Add(this.pic_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sedang3";
            this.Text = "Tebak Buah";
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.PictureBox img_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_selesai;
        private System.Windows.Forms.Button btn_tebak;
        private System.Windows.Forms.TextBox txtbox_isi;
    }
}