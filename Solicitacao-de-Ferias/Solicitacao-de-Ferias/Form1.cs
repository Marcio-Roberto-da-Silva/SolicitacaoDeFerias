using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solicitacao_de_Ferias {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e) 
            {

            this.Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
            {

            txtNome.Clear();
            lblResultado.Text = "";
            txtNome.Focus();

        }


        private void dateDataInicial_ValueChanged(object sender, EventArgs e) {

        }

        private void btnSolicitar_Click(object sender, EventArgs e) 
            {
            DateTime dataIncil, dataFinal;
            TimeSpan resultado;

            dataIncil = Convert.ToDateTime(dateDataInicial.Value);
            dataFinal = Convert.ToDateTime(dateDataFinal.Value);


            resultado = (dataFinal - dataIncil);

            lblResultado.Text = Convert.ToString(resultado.Days);
           
        }

        private void lblResultado_Click(object sender, EventArgs e) {

        }
    }
}
