using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ncom
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Conv_btn_Click(object sender, EventArgs e)
        {
            new Conversion(this).Show();
        }

        private void Basicops_btn_Click(object sender, EventArgs e)
        {
            new BasicOps(this).Show();
        }

        private void Advops_btn_Click(object sender, EventArgs e)
        {
            new AdvancedOps(this).Show();
        }

        private void Armfunc_btn_Click(object sender, EventArgs e)
        {
            new HarmonicFunctions(this).Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
