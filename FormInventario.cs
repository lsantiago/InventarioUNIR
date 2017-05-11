using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioUNIR
{
    public partial class FormInventario : Form
    {
        
        /// <summary>
        /// Constantes
        /// </summary>
        private const String DIRECCION_SUC_PRINC = "Calle de la Rosa n. 28";
        private const String DIRECCION_SUC_SEC = "Calle Alcazabilla n. 3";


        /// <summary>
        /// Costructor
        /// </summary>
        public FormInventario()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Método para tomar los datos del pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar_Click(object sender, EventArgs e)
        {


            try
            {
                String strNombreMedicamento = tbNombreMedicamento.Text;
                String strTipoMedicamento = cbTipoMedicamento.SelectedText;
                String strCantidadMedicamento = tbCantidadMedicamento.Text;

                int cantidadMedicamento = Int32.Parse(strCantidadMedicamento);

                // obtiene el nombre del distribuidor
                var rbSelecDist = gbDistribuidor.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                String strDistribuido = rbSelecDist.Text;


                // obtiene el nombre donde se va a recibir el medicamento
                //List<CheckBox> listDestinos = gbDestinos.Controls.OfType<CheckBox>().All(r => r.Checked);


                //Console.WriteLine(strDistribuido);

                FormResumen frmResumen = new FormResumen(strNombreMedicamento, strTipoMedicamento, cantidadMedicamento, "Principal");
                frmResumen.ShowDialog();
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Seleccione el nombre del distribuidor!");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Escriba un valor númerico en la cantidad de medicamentos!");
            }

            
            
            
        }
        
        
        /// <summary>
        /// Método para obtener la lista de sucursales
        /// </summary>
        /// <returns>
        /// listaSucursales Lista con sucursales donde se entregan los medicamentos
        /// </returns>
        private List<String> getListaSucursales()
        {
            List<String> listaSucursales = new List<string>();

            // genera la lista de sucursales
            if (cbSucursalPrincipal.Checked)
            {
                listaSucursales.Add(DIRECCION_SUC_PRINC);
            }

            if (cbSucursalSecundaria.Checked)
            {
                listaSucursales.Add(DIRECCION_SUC_SEC);
            }

            return listaSucursales;
        }
    }
}
