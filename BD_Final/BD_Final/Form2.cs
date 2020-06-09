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
    public partial class Form2 : Form
    {
        Conexion conexion = new Conexion();
        int? id;
        public Form2(int? id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cm = new MySqlCommand("SELECT * From products where id = '"+id+"'", conexion.conexion);
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
