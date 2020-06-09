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
    public partial class Users : Form
    {
        Conexion conexion = new Conexion();

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cm = new MySqlCommand("select id, subcategory, productName, sum(productPrice-(productPrice*0.5)) as promedio from products group by id having sum(productPrice - (productPrice * 0.5)) >= 50; ", conexion.conexion);
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
