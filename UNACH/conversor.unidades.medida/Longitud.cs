using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor.unidades.medida
{
    public partial class Longitud : Form
    {

        public Longitud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (opcion1.SelectedItem.ToString() == "Kilometros" && opcion2.SelectedItem.ToString() == "Decametros")
            {
                Resultado.Text = Convert.ToString(Convert.ToInt32(Cantidad.Text) * 10);
            }

        }
    }
}
