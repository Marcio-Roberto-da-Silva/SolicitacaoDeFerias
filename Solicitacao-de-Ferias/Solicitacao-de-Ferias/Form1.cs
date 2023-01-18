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

        public List<DateTime> datasComConsultas = new List<DateTime>();

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
          

             var dataAtual = DateTime.UtcNow;
             var diasLimete = dataAtual.AddDays(-40);
             if(dataAtual >= diasLimete) {

             lblResultado.Text = ("Férias não cadastrada! Favor solicitar com no minímo 40 dias");

            }

            //if (datasComConsultas.Any(s => s == DateTime.Parse(dateDataInicial.Text))) MessageBox.Show("Esta data nao esta disponivel");
            //else MessageBox.Show("Data disponivel");
        }

        private void btnSolicitar_Click(object sender, EventArgs e) 
            {
            DateTime dataIncil, dataFinal;
            TimeSpan resultado;

            dataIncil = Convert.ToDateTime(dateDataInicial.Value);
            dataFinal = Convert.ToDateTime(dateDataFinal.Value);


            resultado = (dataFinal - dataIncil);

            lblResultado.Text = Convert.ToString(resultado.Days + " Férias solicitadas com sucesso!");
           
        }

        private void lblResultado_Click(object sender, EventArgs e) {

        }
        private void Form1_Load(object sender, EventArgs e) {
            datasComConsultas = new List<DateTime>
            {
                new DateTime(2023, 02, 04),
                new DateTime(2023, 02, 05),
                new DateTime(2023, 02, 10)
            };
        }

        private void txtNome_TextChanged(object sender, EventArgs e) {

        }

        private void dateDataFinal_ValueChanged(object sender, EventArgs e) {
            
        }
       
    }   
}
