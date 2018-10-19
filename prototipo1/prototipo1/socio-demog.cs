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
    public partial class socio_demog : Form
    {
        public socio_demog()
        {
            InitializeComponent();
            DomainUpDown.DomainUpDownItemCollection collection = this.domain_filhos_sdm.Items;
            collection.Add("0");
            collection.Add("1");
            collection.Add("2");
            collection.Add("3 ou +");
        }

        
        private void data_nas_sdm_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doente a = new Doente();
            a.ShowDialog();
        }
    }
}
