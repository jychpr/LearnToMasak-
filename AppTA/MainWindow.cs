using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTA
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs formAboutUs = new AboutUs();
            formAboutUs.ShowDialog();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lblHasilBahanMasak.Text = "-";
            lblHasilLangkahMasak.Text = "-";
            btnHapusResep.Enabled = false;
            using (var db = new RecipeModel())
            {
                var query = from Recipe in db.Recipes where Recipe.JudulResep == tbCariResep.Text select Recipe;
                foreach (var item in query)
                {
                    lblHasilBahanMasak.Text = item.BahanResep;
                    lblHasilLangkahMasak.Text = item.LangkahResep;
                    btnHapusResep.Enabled = true;
                }
            }
        }

        private void btnTambahResep_Click(object sender, EventArgs e)
        {
            InputLangkahMemasak formInputLangkahMemasak = new InputLangkahMemasak();
            formInputLangkahMemasak.ShowDialog();
        }


        private void btnHapusResep_Click(object sender, EventArgs e)
        {
            using (var db = new RecipeModel())
            {
                db.Recipes.RemoveRange(db.Recipes.Where(item => item.JudulResep == tbCariResep.Text));
                db.SaveChanges();
                tbCariResep.Text = "";
                lblHasilBahanMasak.Text = "-";
                lblHasilLangkahMasak.Text = "-";
                btnHapusResep.Enabled = false;
            }
        }
    }
}
