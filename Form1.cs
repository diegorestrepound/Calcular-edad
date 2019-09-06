using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbledad.Text = "";
        }

        private void btnCalculaEdad_Click(object sender, EventArgs e)
        {
            DateTime Fechanac = FechaNacimiento.Value;
            int años = System.DateTime.Now.Year - Fechanac.Year;
            if (System.DateTime.Now.Subtract(Fechanac.AddYears(años)).TotalDays < 0)
                lbledad.Text = Convert.ToString(años - 1);
            else
                lbledad.Text = Convert.ToString(años);

        }
    }
}
