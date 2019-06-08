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
    public partial class HarmonicFunctions : Form
    {
        private MainMenu mainMenu;

        public HarmonicFunctions(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
            this.InitializeComponent();
            typeA_combo.SelectedIndex = 0;
            typeB_combo.SelectedIndex = 0;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Res_btn_Click(object sender, EventArgs e)
        {
            res_entry.Text = "";

            if (textboxNoVacios() && tiposSeleccionados())
            {
                if (textboxSoloNum())
                {
                    if (freqA_entry.Text.Equals(freqB_entry.Text))
                    {
                        HarmonicFunction funcionA = new HarmonicFunction(double.Parse(amplitudeA_entry.Text),
                            double.Parse(freqA_entry.Text), double.Parse(phaseA_entry.Text), typeA_combo.SelectedIndex.Equals(2));
                        HarmonicFunction funcionB = new HarmonicFunction(double.Parse(amplitudeB_entry.Text),
                            double.Parse(freqB_entry.Text), double.Parse(phaseB_entry.Text), typeB_combo.SelectedIndex.Equals(2));

                        funcionA = funcionA.convertirEnFcos();
                        funcionB = funcionB.convertirEnFcos();

                        if (add_rad.Checked)
                        {
                            HarmonicFunction fres = Functions.sumaDeFuncArmonicas(funcionA, funcionB);

                            string stringRes = fres.mostrar();

                            if (stringRes.StartsWith("0"))
                            {
                                res_entry.AppendText("0");
                            }

                            else
                            {
                                res_entry.AppendText(stringRes);
                            }
                            
                        }

                        else
                        {
                            HarmonicFunction fres = Functions.restaDeFuncArmonicas(funcionA, funcionB);

                            string stringRes = fres.mostrar();

                            if (stringRes.StartsWith("0"))
                            {
                                res_entry.AppendText("0");
                            }

                            else
                            {
                                res_entry.AppendText(stringRes);
                            }
                            
                        }
                    }

                    else
                    {
                        MessageBox.Show("Las funciones ingresadas no tienen la misma frecuencia", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Los campos deben contener números únicamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            else
            {
                MessageBox.Show("Debe completar todos los campos solicitados y seleccionar el tipo de la función", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private Boolean textboxNoVacios()
        {
            List<TextBox> li = new List<TextBox>();
            li.Add(amplitudeA_entry);
            li.Add(amplitudeB_entry);
            li.Add(freqA_entry);
            li.Add(freqB_entry);
            li.Add(phaseA_entry);
            li.Add(phaseB_entry);

            return li.TrueForAll(e => !String.IsNullOrWhiteSpace(e.Text));
        }

        private Boolean textboxSoloNum()
        {
            List<TextBox> li = new List<TextBox>();
            li.Add(amplitudeA_entry);
            li.Add(amplitudeB_entry);
            li.Add(freqA_entry);
            li.Add(freqB_entry);
            li.Add(phaseA_entry);
            li.Add(phaseB_entry);

            int c = 0;

            foreach (TextBox nt in li)
            {
                if (!Functions.textbox_soloNum(nt))
                {
                    c += 2;
                }
            }

            return c.Equals(0);
        }

        public Boolean tiposSeleccionados()
        {
            return typeA_combo.SelectedIndex != 0 && typeB_combo.SelectedIndex != 0;
        }
    }
}