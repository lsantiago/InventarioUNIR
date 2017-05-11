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
    public partial class FormResumen : Form
    {
        public FormResumen(String nombreMedic,
            String tipoMedic,
            int cantidadMedic,
            String nombreDist)
        {
            InitializeComponent();

            // asigna el título a la venta de resumen
            this.Text = nombreMedic;
        }
    }
}
