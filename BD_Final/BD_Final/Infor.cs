using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BD_Final
{
    public partial class Infor : Form
    {
        Conexion conexion = new Conexion();
        public Infor()
        {
            InitializeComponent();
        }

        private void Infor_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cm = new MySqlCommand("SELECT * From informacion", conexion.conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
