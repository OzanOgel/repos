using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace AgeOfTicaret
{
    public partial class Kategoriİslemleri : Form
    {
        DataModel dm = new DataModel();
        int id = -1;
        public Kategoriİslemleri()
        {
            InitializeComponent();
            tb_categoryıd.Enabled = false;
        }

        private void Kategoriİslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dm.GetCategories();
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_categoryname.Text))
            {
                Category model = new Category();
                model.CategoryName = tb_categoryname.Text;
                model.description = tb_aciklama.Text;
                model = dm.AddCategory(model);
                if(model.CategoryID != 0)
                {
                    MessageBox.Show($"Kategori {model.CategoryID} ıd ile başarıyla eklenmiştir", "Başarılı");
                    tb_aciklama.Text = tb_categoryname.Text = "";
                    dataGridView1.DataSource = dm.GetCategories();
                }
                else
                {
                    MessageBox.Show("Kategori Eklerken Bir hata oluştu", "hata");
                }
            }
            else
            {
                MessageBox.Show("İsim Bol Olamaz","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                
                //contextMenuStrip1.Show(dataGridView1,e.X,e.Y);
                var yer = dataGridView1.HitTest(e.X, e.Y);
                if (yer.RowIndex != -1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[yer.RowIndex].Selected = true;
                    id = Convert.ToInt32(dataGridView1.Rows[yer.RowIndex].Cells[0].Value);
                    contextMenuStrip1.Show(dataGridView1,e.X,e.Y);
                }
            }

        }

        private void tsp_guncelle_Click(object sender, EventArgs e)
        {
            if (id != 1)
            {
                Category c = dm.GetCategory(id);
                tb_categoryıd.Text = c.CategoryID.ToString();
                tb_categoryname.Text = c.CategoryName;
                tb_aciklama.Text = c.description;
                btn_guncelle.Visible = true;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            
                Category c = new Category();
                c.CategoryID = Convert.ToInt32(tb_categoryıd.Text);
                c.CategoryName = tb_categoryname.Text;
                c.description = tb_aciklama.Text;
                if (dm.UptadeCategory(
                    c))
                {
                    MessageBox.Show("güncellendi");
             
                }
                else
                {
                    MessageBox.Show("guncellemedi");
               }
                dataGridView1 = new DataGridView();
            
        }
    }
}
