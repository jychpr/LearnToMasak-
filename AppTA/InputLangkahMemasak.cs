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
    public partial class InputLangkahMemasak : Form
    {
        public enum Mode { Insert }
        Mode mode;
        private Recipe Recipe;

        public InputLangkahMemasak()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnAksiResep.Text = "Tambah";
        }

        private void TambahData()
        {
            if (tbCariResep.Text != "" && rtbBahanMasak.Text != "" && rtbLangkahMemasak.Text != "")
            {
                using (var db = new RecipeModel())
                {
                    Recipe = new Recipe
                    {
                        JudulResep = tbCariResep.Text,
                        BahanResep = rtbBahanMasak.Text,
                        LangkahResep = rtbLangkahMemasak.Text
                    };
                    db.Recipes.Add(Recipe);
                    db.SaveChanges();
                    MessageBox.Show("Resep ditambahkan");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Semua harus diisi");
            }
        }


        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string ingredients = "";
            List<string> ingredientsList = new List<string>();
            ingredientsList = APIResep.GetBahan(tbCariResep.Text);
            for (int i = 0; i < ingredientsList.Count(); i++)
            {
                ingredients += ingredientsList[i] + "\n";
            }
            rtbBahanMasak.Text = ingredients;
        }

        private void btnAksiResep_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                TambahData();
            
        }
    }
}
