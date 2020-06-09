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
    public partial class Categoria : Form
    {
        Conexion conexion = new Conexion();
        public Categoria()
        {
            InitializeComponent();
            obtenerDatos();
        }

        public void obtenerDatos()
        {
            try
            {
                string consulta = "SELECT * FROM category;";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion.conexion);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntGC_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNomC.Text))
                {
                    conexion.conexion.Open();
                    //Si el campo del id está vacío, es porque se insertará un dato nuevo y se realiza el INSERT
                    if (string.IsNullOrEmpty(txtIdC.Text))
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO category(categoryName, categoryDescription) VALUES (@categoryName, @categoryDescription)", conexion.conexion);
                        cmd.Parameters.AddWithValue("@categoryName", txtNomC.Text);
                        cmd.Parameters.AddWithValue("@categoryDescription", rtxtDescC.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Guardado satisfactoriamente");
                    }
                    else
                    {
                        //Si el campo del Id tiene un valor, es porque se actualizará un registro existente y se realiza un UPDATE
                        int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        MySqlCommand cmd = new MySqlCommand(String.Format("Call actualizarCat('{0}', '{1}', '{2}');",
                        id, txtNomC.Text, rtxtDescC.Text), conexion.conexion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Actualizado satisfactoriamente");
                    }
                    conexion.conexion.Close();
                    obtenerDatos();
                    txtIdC.Clear();
                    txtNomC.Clear();
                    rtxtDescC.Clear();
                }
                else
                {
                    MessageBox.Show("El campo está vacío");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.conexion.Close();

            }

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtIdC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtNomC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            rtxtDescC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
        }

        private void btnEC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DialogResult confEliminacion = MessageBox.Show("El registro " + id + " será eliminado", "Advertencia", MessageBoxButtons.YesNo);
                if (confEliminacion == DialogResult.Yes)
                {
                    conexion.conexion.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM subcategory WHERE categoryid='" + id + "';", conexion.conexion);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand("DELETE FROM category WHERE id='" + id + "';", conexion.conexion);
                    cmd.ExecuteNonQuery();
                    conexion.conexion.Close();
                    MessageBox.Show("Eliminado satisfactoriamente");
                    obtenerDatos();
                    txtIdC.Clear();
                    txtNomC.Clear();
                    rtxtDescC.Clear();
                }
                else
                {
                    //En caso de que se arrepienta, se le notoficará que ha sido cancelada la petición
                    MessageBox.Show("Proceso cancelado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.conexion.Close();

            }
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;
            txtIdC.Enabled = true;
            txtNomC.Enabled = false;
            rtxtDescC.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si el campo del Id no está vacío, realizará la búsqueda
                if (!string.IsNullOrEmpty(txtIdC.Text))
                {
                    int id = Convert.ToInt32(txtIdC.Text);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM category WHERE id = @id", conexion.conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    conexion.conexion.Open();
                    MySqlDataReader tabla = cmd.ExecuteReader();
                    try
                    {
                        //Si lo encuentra, se mostrará el título que corresponde al Id
                        tabla.Read();
                        MessageBox.Show("La  categoría" + id + " es: " + tabla[1].ToString() + "\n Descripción: \n" + tabla[2].ToString());
                        conexion.conexion.Close();
                        //Se habilitan los elementos como al inicio
                        txtIdC.Enabled = false;
                        txtIdC.Clear();
                        txtNomC.Enabled = true;
                        rtxtDescC.Enabled = true;
                        btnBuscar.Visible = false;
                    }
                    catch
                    {
                        //Si no se encuentra, se mostrará el siguiente mensaje indicando el error
                        MessageBox.Show("No se encuentra esa categoría");
                        //Se habilitan los elementos como al inicio
                        txtIdC.Enabled = false;
                        txtIdC.Clear();
                        txtNomC.Enabled = true;
                        btnBuscar.Visible = false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.conexion.Close();

            }
        }
    }
}
