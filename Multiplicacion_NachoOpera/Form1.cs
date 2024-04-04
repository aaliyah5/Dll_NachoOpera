using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll_NachoOpera;

namespace Multiplicacion_NachoOpera
{
    public partial class Frm_multiplicacion : Form
    {
        public Frm_multiplicacion()
        {
            InitializeComponent();
        }


        private Operaciones operadores;


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            this.operadores = new Operaciones();
            double numero1 = Convert.ToDouble(txt1.Text);
            double numero2 = Convert.ToDouble(txt2.Text);

            total=this.operadores.Multiplicar(numero1, numero2);

            MessageBox.Show("El resultado de la multiplicacion es: " + total);
        }
    }
}
