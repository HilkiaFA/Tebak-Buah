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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mudah_Click(object sender, EventArgs e)
        {
            mudah mudah = new mudah();
            mudah.Show();
            this.Hide();
        }

        private void btn_sedang_Click(object sender, EventArgs e)
        {
            sedang sedang = new sedang();

            sedang.Show();
            this.Hide();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void href_link(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.instagram.com/hilkia1408.cs/?hl=id");
        }

        private void btn_susah_Click(object sender, EventArgs e)
        {
            susah susah = new susah();

            susah.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Panduan!!!\n" +
                "1. Silahkan menggunakan bahasa yang baku\n" +
                "2. Jangan menggunakan bahasa yang singkat\n" +
                "3. Jawab pertanyaan hanya mengunakan nama buah saja tidak memerlukan kata buah\n" +
                "4. Jawab nama buah menggunakan bahasa indonesia karena aplikasi ini belum mendekteksi bahasa inggir\n" +
                "5. Silahkan memainkan game ini dengan baik\n\n Copyrigth by Hilkia");
        }
    }
}
