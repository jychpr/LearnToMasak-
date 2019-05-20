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
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void btnEnterWP_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow formMainWindow = new MainWindow();
            formMainWindow.ShowDialog();
        }
    }
}
