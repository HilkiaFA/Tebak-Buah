using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tebak_Buah
{
    public partial class mudah2 : Form
    {
        public mudah2()
        {
            InitializeComponent();
        }

        private void mudah2_Load(object sender, EventArgs e)
        {

        }
        private void btn_tebak_Click_1(object sender, EventArgs e)
        {
            
            if (txtbox_isi.Text == "jeruk" || txtbox_isi.Text == "Jeruk")
            {

                lbl_2.Visible= false;
                img_1.Visible= false;
                lbl_2.Visible = false;
                txtbox_isi.Visible= false;
                btn_tebak.Visible= false;
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

        private void txtbox_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_tebak_Click_1(this, new EventArgs());
                txtbox_isi.Text = string.Empty;
            }
        }

        private void btn_selesai_Click(object sender, EventArgs e)
        {
            Form1 kembali = new Form1();

            kembali.Show();
            this.Hide();
        }
    }
}
