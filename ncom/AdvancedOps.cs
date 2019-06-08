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
    public partial class AdvancedOps : Form
    {
        private MainMenu mainMenu;

        public AdvancedOps(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
            this.InitializeComponent();
        }

        private void Roots_btn_Click(object sender, EventArgs e)
        {
            new Roots().Show();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Res_btn_Click(object sender, EventArgs e)
        {
            {
                res_entry.Text = "";

                if (Functions.esComplejoValido(complex_entry.Text))
                {
                    if (Functions.esNumeroNatural(index_entry.Text))
                    {
                        if (pow_rad.Checked)
                        {
                            if (Functions.esBinomico(complex_entry.Text))
                            {
                                BinomialComplex n = Functions.conversionStringBinomica(complex_entry.Text);
                                var polar = n.convertirEnPolar();
                                res_entry.Text += Functions.potenciacion(polar, int.Parse(index_entry.Text)).mostrar() + Environment.NewLine;
                            }

                            else
                            {
                                res_entry.Text += (Functions.potenciacion(Functions.conversionStringPolar(complex_entry.Text), int.Parse(index_entry.Text))).mostrar() + Environment.NewLine;
                                return;
                            }
                        }

                        else
                        {
                            PolarComplex polar;

                            if (Functions.esBinomico(complex_entry.Text))
                            {
                                BinomialComplex n = Functions.conversionStringBinomica(complex_entry.Text);
                                polar = n.convertirEnPolar();
                            }

                            else
                            {
                                polar = Functions.conversionStringPolar(complex_entry.Text);
                            }

                            List<PolarComplex> raices = Functions.radicacion(polar, int.Parse(index_entry.Text));

                            for (int i = 0; i < raices.Count; i++)
                            {
                                res_entry.Text += ("w" + i.ToString() + ":\t" + raices[i].mostrar() + Environment.NewLine);
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("El exponente o índice debe ser un número natural", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("El número complejo debe estar expresado en forma binómica o polar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
