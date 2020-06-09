using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BD_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria FormCategory = new Categoria();
            FormCategory.MdiParent = this;
            FormCategory.Show();
        }

        private void subcategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subcategoria FormSub = new Subcategoria();
            FormSub.MdiParent = this;
            FormSub.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos FormProd = new Productos();
            FormProd.MdiParent = this;
            FormProd.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Infor FormInfo = new Infor();
            FormInfo.MdiParent = this;
            FormInfo.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users userF = new Users();
            userF.MdiParent = this;
            userF.Show();
        }
    }
}
