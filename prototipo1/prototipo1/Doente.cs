using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo1
{
    public partial class Doente : Form
    {
        public Doente()
        {
            InitializeComponent();
        }

        private void button_entrar_doente(object sender, EventArgs e)
        {

        }

        private void button_criar_Click(object sender, EventArgs e)
        {
            this.Hide();
            socio_demog b = new socio_demog();
           b.ShowDialog();
        }

        private void buttonclick_sair(object sender, EventArgs e)
        {
            this.Hide();
            Inicio c = new Inicio();
            c.ShowDialog();
        }
    }
}
