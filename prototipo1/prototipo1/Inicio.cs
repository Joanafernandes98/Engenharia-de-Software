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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

           
        }

        private void doente_click(object sender, EventArgs e)
        {
            this.Hide();
            Doente a = new Doente();
            a.ShowDialog();
        }


    }
}
