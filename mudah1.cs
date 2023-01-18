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
    public partial class mudah1 : Form
    {
        public mudah1()
        {
            InitializeComponent();
        }

        private void btn_tebak_Click(object sender, EventArgs e)
        {
            if (txtbox_isi.Text == "anggur" || txtbox_isi.Text == "Anggur")
            {
                lbl_3.Text = "Jawaban benar";
                lbl_3.Visible = true;
                btn_next.Visible = true;
                lbl_2.Visible = false;
            }
            else if (string.IsNullOrEmpty(txtbox_isi.Text))
            {
                btn_next.Visible = false;
                lbl_3.Visible = false;
                lbl_2.Visible = false;
                MessageBox.Show("Silahkan masukkan tebakkan terlebih dahulu");
            }
            else
            {
                btn_next.Visible = false;
                lbl_3.Visible = false;
                lbl_2.Text = "Jawaban salah silahkan coba lagi";
                lbl_2.Visible = true;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            mudah2 next = new mudah2();

            next.Show();
            this.Hide();
        }

        private void txtdown_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_tebak_Click(this, new EventArgs());
                txtbox_isi.Text = string.Empty;
            }
        }
    }
}
