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
    public partial class Roots : Form
    {
        public Roots()
        {
            InitializeComponent();
        }

        private void Res_btn_Click(object sender, EventArgs e)
        {
            if (Functions.esNumeroNatural(rootsquantity_entry.Text))
            {
                roots_entry.Text = "";
                primitives_entry.Text = "";

                var raices = Functions.raicesUnidad(int.Parse(rootsquantity_entry.Text));
                var primitivas = Functions.raicesPrimitivas(int.Parse(rootsquantity_entry.Text));

                for (int i = 0; i < raices.Count; i++)
                {
                    roots_entry.Text += "w" + i.ToString() + ":\t" + raices[i].mostrar() + Environment.NewLine;
                }

                for (int j = 0; j < primitivas.Count; j++)
                {
                    primitives_entry.Text += "w" + primitivas[j].ToString() + Environment.NewLine;
                }
            }

            else
            {
                MessageBox.Show("Debe ingresar un número natural", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
