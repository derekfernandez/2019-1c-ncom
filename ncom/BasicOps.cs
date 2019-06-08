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
    public partial class BasicOps : Form
    {
        private MainMenu mainMenu;

        public BasicOps(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
            this.InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Res_btn_Click(object sender, EventArgs e)
        {
            res_entry.Text = "";
            
            if (Functions.esComplejoValido(complex1_entry.Text) && Functions.esComplejoValido(complex2_entry.Text))
            {
                #region suma

                if (add_rad.Checked)
                {
                    var c1 = complex1_entry.Text;
                    var c2 = complex2_entry.Text;

                    var li = new List<String>();
                    li.Add(c1);
                    li.Add(c2);

                    List<BinomialComplex> numeros = Functions.convertirTodosABinom(li);

                    BinomialComplex num1 = numeros[0];
                    BinomialComplex num2 = numeros[1];

                    var suma = Functions.suma(num1, num2);

                    res_entry.AppendText(suma.mostrar());
                    return;
                }
                #endregion

                #region resta

                else if (sub_rad.Checked)
                {
                    var c1 = complex1_entry.Text;
                    var c2 = complex2_entry.Text;

                    var li = new List<string>();
                    li.Add(c1);
                    li.Add(c2);

                    List<BinomialComplex> numeros = Functions.convertirTodosABinom(li);

                    BinomialComplex num1 = numeros[0];
                    BinomialComplex num2 = numeros[1];

                    var resta = Functions.resta(num1, num2);

                    res_entry.AppendText(resta.mostrar());
                    return;
                }

                #endregion

                #region producto

                else if (prod_rad.Checked)
                {
                    var c1 = complex1_entry.Text;
                    var c2 = complex2_entry.Text;

                    var li = new List<string>();
                    li.Add(c1);
                    li.Add(c2);

                    List<BinomialComplex> numeros = Functions.convertirTodosABinom(li);

                    BinomialComplex num1 = numeros[0];
                    BinomialComplex num2 = numeros[1];

                    var prod = Functions.producto(num1, num2);

                    res_entry.AppendText(prod.mostrar());
                    return;
                }

                #endregion

                #region div

                else
                {
                    var c1 = complex1_entry.Text;
                    var c2 = complex2_entry.Text;

                    var li = new List<string>();
                    li.Add(c1);
                    li.Add(c2);

                    List<BinomialComplex> numeros = Functions.convertirTodosABinom(li);

                    BinomialComplex dividendo = numeros[0];
                    BinomialComplex divisor = numeros[1];

                    var div = Functions.cociente(dividendo, divisor);

                    res_entry.AppendText(div.mostrar());
                    return;
                }

                #endregion
            }

            else
            {
                MessageBox.Show("Debe completar ambos campos con números complejos en forma de par ordenado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Complex1_entry_Enter(object sender, EventArgs e)
        {
            if (complex1_entry.Text.Contains("Ejemplo"))
            {
                complex1_entry.Text = "";
                complex1_entry.ForeColor = Color.Black;
            }
        }

        private void Complex2_entry_Enter(object sender, EventArgs e)
        {
            if (complex2_entry.Text.Contains("Ejemplo"))
            {
                complex2_entry.Text = "";
                complex2_entry.ForeColor = Color.Black;
            }
        }
    }
}
