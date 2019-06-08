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
    public partial class Conversion : Form
    {
        private MainMenu mainMenu;

        public Conversion(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
            this.InitializeComponent();
        }

        private void Backbinompolar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Binompolar_btn_Click(object sender, EventArgs e)
        {
            resbinompolar_entry.Text = "";

            if (Functions.textboxCompletos(this))
            {
                if (Functions.textbox_soloNum(real_entry)
                    && Functions.textbox_soloNum(im_entry))
                {
                    BinomialComplex num = new BinomialComplex(double.Parse(real_entry.Text), double.Parse(im_entry.Text));
                    PolarComplex numconvertido = num.convertirEnPolar();

                    resbinompolar_entry.Text = numconvertido.mostrar();
                    return;
                }

                else
                {
                    MessageBox.Show("Ingreso no válido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else
            {
                MessageBox.Show("Debe completar los campos solicitados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Backpolarbinom_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Polarbinom_btn_Click(object sender, EventArgs e)
        {
            respolarbinom_entry.Text = "";

            if (Functions.textboxCompletos(this))
            {
                if (Functions.textbox_soloNum(mod_entry)
                    && Functions.textbox_soloNum(arg_entry))
                {
                    PolarComplex num = new PolarComplex(double.Parse(mod_entry.Text), double.Parse(arg_entry.Text));
                    BinomialComplex numconvertido = num.convertirEnBinomica();

                    respolarbinom_entry.Text = numconvertido.mostrar();
                    return;
                }

                else
                {
                    MessageBox.Show("Ingreso no válido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else
            {
                MessageBox.Show("Debe completar los campos solicitados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}