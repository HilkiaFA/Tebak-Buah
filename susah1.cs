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
    public partial class susah1 : Form
    {
        public susah1()
        {
            InitializeComponent();
        }

        private void btn_tebak_Click(object sender, EventArgs e)
        {
            if (box_isi.Text == "Lontar" || box_isi.Text == "lontar")
            {
                lbl_2.Text = "Jawaban benar";
                lbl_2.Visible = true;
                btn_next.Visible = true;
                lbl_3.Visible = false;
                ft_1.Visible = false;
                ft_2.Visible = true;
            }
            else if (string.IsNullOrEmpty(box_isi.Text))
            {
                btn_next.Visible = false;
                lbl_2.Visible = false;
                lbl_3.Visible = false;
                MessageBox.Show("Silahkan masukkan tebakkan terlebih dahulu");
            }
            else
            {
                btn_next.Visible = false;
                lbl_2.Visible = false;
                lbl_3.Text = "Jawaban salah silahkan coba lagi";
                lbl_3.Visible = true;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            susah2 susah = new susah2();

            susah.Show();
            this.Hide();
        }

        private void keydown_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_tebak_Click(this, new EventArgs());
                box_isi.Text = string.Empty;
            }
        }
    }
}
