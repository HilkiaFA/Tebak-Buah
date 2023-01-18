using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tebak_Buah
{
    public partial class susah2 : Form
    {
        public susah2()
        {
            InitializeComponent();
        }

        private void btn_tebak_Click(object sender, EventArgs e)
        {
            if (txtbox_isi.Text == "Bit" || txtbox_isi.Text == "bit")
            {
                label1.Visible = false;
                img_1.Visible = false;
                txtbox_isi.Visible = false;
                btn_tebak.Visible = false;
                pic_1.Visible = true;
                btn_selesai.Visible = true;
            }
            else if (string.IsNullOrEmpty(txtbox_isi.Text))
            {
                MessageBox.Show("Silahkan masukkan tebakkan terlebih dahulu");
            }
            else
            {
                MessageBox.Show("Jawaban salah silahkan coba lagi");
            }
        }

        private void btn_selesai_Click(object sender, EventArgs e)
        {
            Form1 kembali = new Form1();

            kembali.Show();
            this.Hide();
        }

        private void keydown_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_tebak_Click(this, new EventArgs());
                txtbox_isi.Text = string.Empty;
            }
        }
    }
}
