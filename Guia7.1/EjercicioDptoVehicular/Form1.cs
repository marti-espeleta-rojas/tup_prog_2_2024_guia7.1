using EjercicioDptoVehicular.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDptoVehicular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string linea = "42352213Martiniano Espeleta     martinianoespeletrojas@gmail.com";
                string dniString = linea.Substring(0,8);
                string nombre = linea.Substring(8,21);
                string email = linea.Substring(21, linea.Length);

                int.TryParse(dniString, out int dni);
                Persona p = new Persona(dniString, nombre, );
            }
        }
    }
}
