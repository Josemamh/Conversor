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
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            //Condicional para solo Longitud//
            if (Opciones.SelectedItem.ToString() == "Longitud")
            {
                this.Hide();
                Longitud frm = new Longitud();
                frm.Show();
            }

            if (Opciones.SelectedItem.ToString() == "Capacidad")
            {
                this.Hide();
                Capacidad frm = new Capacidad();
                frm.Show();
            }
            if (Opciones.SelectedItem.ToString() == "Tiempo")
            {
                this.Hide();
                Tiempo frm = new Tiempo();
                frm.Show();
            }
            if (Opciones.SelectedItem.ToString() == "Temperatura")
            {
                this.Hide();
                Temperatura frm = new Temperatura();
                frm.Show();
            }
            if (Opciones.SelectedItem.ToString() == "Peso")
            {
                this.Hide();
                Peso frm = new Peso();
                frm.Show();
            }
        }
    }
}
