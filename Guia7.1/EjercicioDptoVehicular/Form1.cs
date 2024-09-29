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
        Persona propietario = null;
        DepartamentoVehicular dpto = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //en este botón tengo que hacer manejo de las excepciones lanzadas
            FormVer fver = new FormVer();
            try 
            { /*fijate como "todo pasa" normalmente desde un principio, y, 
               * excepcionalmente, se detendría la ejecución del código 
               * con el lanzamiento de una excepción (que se maneja al final).
               * Así se puede ver la separación del código de manejo de errores 
               * con el código funcional y normal del programa.
               */
                string patente = tbPatente.Text;
                string nombre = tbNombre.Text;
                int dni = Convert.ToInt32(tbDNI.Text);
                propietario = new Persona(dni, nombre);
                fver.tbResultados.Text+=dpto.RegistrarVehiculo(patente, propietario);
                fver.ShowDialog();

            }
            /*OJO: no significa que poner las excepciones más comunes (como FormatException)
             * al principio sea porque estas ocurren primero en la ejecución, sino que suelen
             * ser las más comunes y por eso es beneficioso comprobar éstas excepciones primero.
             */
            catch (FormatException ez)
            {
                MessageBox.Show($"Error de Formato. Reingrese los valores correspondientes para cada dato\r\n{ez.Message}");
            }
            catch (DniNoValidoException d)
            {
                MessageBox.Show($"DNI no válido. Ingrese de nuevo su DNI!\r\n{d.Message}");
            }
            catch(FormatoPatenteNoValidaException ex)
            {
                MessageBox.Show($"Ha surgido un error: {ex.Message}");
            }
            finally
            {
                fver.Dispose();
            }
            tbDNI.Clear();
            tbNombre.Clear();
            tbPatente.Clear();
        }
    }
}
