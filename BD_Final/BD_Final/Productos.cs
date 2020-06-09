using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace BD_Final
{
    
    public partial class Productos : Form
    {
        string name = "";
        MemoryStream ms;
        Conexion conexion = new Conexion();
        public Productos()
        {
            InitializeComponent();
            obtenerDatos();
        }

        public void obtenerDatos()
        {
            try
            {
                MySqlCommand cm = new MySqlCommand("SELECT * From products", conexion.conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntGS_Click(object sender, EventArgs e)
        {
            byte[] ImageData  = null;

            try
            {
                if (!string.IsNullOrEmpty(txtNomP.Text))
                {

                    conexion.conexion.Open();
                    //Si el campo del id está vacío, es porque se insertará un dato nuevo y se realiza el INSERT
                    if (string.IsNullOrEmpty(txtIdP.Text))
                    {
                        
                        string FileName = txtImagen.Text;
                        ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, ImageFormat.Jpeg);

                        ImageData = ms.ToArray();
                       
                        

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO products (subCategory, productName, productCompany, productPrice, Image, shippingCharge, productAvailability) VALUES (@subcategory, @productName, " +
                            "@productCompany, @productPrice, @Image, @shippingCharge, @productAvailability)", conexion.conexion);
                        
                        cmd.Parameters.AddWithValue("@subcategory", int.Parse(txtIdS.Text));
                        cmd.Parameters.AddWithValue("@productName", txtNomP.Text);
                        cmd.Parameters.AddWithValue("@productCompany", txtCom.Text);
                        cmd.Parameters.AddWithValue("@productPrice", int.Parse(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@Image", ImageData);
                        cmd.Parameters.AddWithValue("@shippingCharge", int.Parse(txtCargos.Text));
                        cmd.Parameters.AddWithValue("@productAvailability", txtDis.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Guardado satisfactoriamente");
                    }
                    else
                    {
                        ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, ImageFormat.Jpeg);

                        ImageData = ms.ToArray();
                        //Si el campo del Id tiene un valor, es porque se actualizará un registro existente y se realiza un UPDATE
                        int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                        MySqlCommand cmd = new MySqlCommand(String.Format("Update products set subCategory = @subcategory, productName = @productName, productCompany = @productCompany, productPrice = @productPrice, Image = @Image, shippingCharge = @shippingCharge, productAvailability = @productAvailability where id = @idp"), conexion.conexion);
                        cmd.Parameters.AddWithValue("@subcategory", int.Parse(txtIdS.Text));
                        cmd.Parameters.AddWithValue("@productName", txtNomP.Text);
                        cmd.Parameters.AddWithValue("@productCompany", txtCom.Text);
                        cmd.Parameters.AddWithValue("@productPrice", int.Parse(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@Image", ImageData);
                        cmd.Parameters.AddWithValue("@shippingCharge", int.Parse(txtCargos.Text));
                        cmd.Parameters.AddWithValue("@productAvailability", txtDis.Text);
                        cmd.Parameters.AddWithValue("@idp", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Actualizado satisfactoriamente");
                    }
                    obtenerDatos();
                    txtIdP.Clear();
                    txtIdS.Clear();
                    txtNomP.Clear();
                    txtCom.Clear();
                    txtPrecio.Clear();
                    txtImagen.Clear();
                    txtCargos.Clear();
                    txtDis.Clear();
                }
                else
                {
                    MessageBox.Show("El campo está vacío");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    name = openFileDialog1.FileName;
                    txtImagen.Text = openFileDialog1.FileName;

                    pictureBox1.Image = System.Drawing.Image.FromFile(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAS_Click(object sender, EventArgs e)
        {
            txtIdP.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
            txtIdS.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
            txtNomP.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[2].Value); 
            txtCom.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[3].Value);
            txtPrecio.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[4].Value);
            txtCargos.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[6].Value);
            txtDis.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[7].Value);
            txtImagen.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[5].Value);


        }

        private void btnES_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                DialogResult confEliminacion = MessageBox.Show("El registro " + id + " será eliminado", "Advertencia", MessageBoxButtons.YesNo);
                if (confEliminacion == DialogResult.Yes)
                {
                    conexion.conexion.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM subcategory WHERE categoryid='" + id + "';", conexion.conexion);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand("DELETE FROM products WHERE id='" + id + "';", conexion.conexion);
                    cmd.ExecuteNonQuery();
                    conexion.conexion.Close();
                    MessageBox.Show("Eliminado satisfactoriamente");
                    obtenerDatos();
                    
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

        private void btnBS_Click(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;
            txtIdP.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si el campo del Id no está vacío, realizará la búsqueda
                if (!string.IsNullOrEmpty(txtIdP.Text))
                {
                    int id = Convert.ToInt32(txtIdP.Text);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM category WHERE id = @id", conexion.conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    conexion.conexion.Open();
                    MySqlDataReader tabla = cmd.ExecuteReader();
                    try
                    {
                        Form2 busquedaRes = new Form2(id);
                        busquedaRes.ShowDialog();
                    }
                    catch
                    {
                        //Si no se encuentra, se mostrará el siguiente mensaje indicando el error
                        MessageBox.Show("No se encuentra el producto");
                        //Se habilitan los elementos como al inicio
                       
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
