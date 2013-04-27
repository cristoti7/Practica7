using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7PlantillaExamen
{
    public partial class Examen : Form
    {
        public Examen()
        {
            InitializeComponent();
        }

        

        private void Bterminar_Click(object sender, EventArgs e)
        {
            
            string FechaSeleccionada;
            string FechaIndependecia="16/09/1810";
            int aciertos = 0;
            if (this.RadCucei.Checked)
            {
               aciertos++;
            }
            if (this.SpinPregunta2.Text == "10")
            {
                aciertos++;

            }

            if (this.checkBrazil.Checked)
            {
                aciertos++;
            }
            if (this.checkUsa.Checked)
            {
                aciertos++;
            }

            FechaSeleccionada = Calendario.SelectionRange.Start.ToShortDateString();

            if (FechaSeleccionada == FechaIndependecia)
            {
                aciertos++;

            }

            MessageBox.Show(" los aciertos son: "+aciertos);




        }
    }
}
