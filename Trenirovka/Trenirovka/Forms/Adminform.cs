using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trenirovka.Forms
{
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 authForm = new Form1();
            authForm.Show();
        }

        private void Adminform_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trenirovkaDataSet.Agents". При необходимости она может быть перемещена или удалена.
            this.agentsTableAdapter.Fill(this.trenirovkaDataSet.Agents);

        }
    }
}
