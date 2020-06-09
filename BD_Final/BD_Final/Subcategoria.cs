﻿using System;
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
    public partial class Subcategoria : Form
    {
        Conexion conexion = new Conexion();
        public Subcategoria()
        {
            InitializeComponent();
            obtenerDatos();
            
        }
        

        private void Subcategoria_Load(object sender, EventArgs e)
        {

        }

        public void obtenerDatos()
        {
            try
            {
                string consulta = "SELECT * FROM subcategory;";
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

        private void bntGS_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNomS.Text))
                {
                    conexion.conexion.Open();
                    //Si el campo del id está vacío, es porque se insertará un dato nuevo y se realiza el INSERT
                    if (string.IsNullOrEmpty(txtIdS.Text))
                    {
                        MySqlCommand cmd = new MySqlCommand("CALL addSubC (@categoryid, @subcategory)", conexion.conexion);
                        cmd.Parameters.AddWithValue("@categoryid", int.Parse(txtIdC.Text));
                        cmd.Parameters.AddWithValue("@subcategory", txtNomS.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Guardado satisfactoriamente");
                    }
                    else
                    {
                        //Si el campo del Id tiene un valor, es porque se actualizará un registro existente y se realiza un UPDATE
                        int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        MySqlCommand cmd = new MySqlCommand(String.Format("CALL actualizarSCat('{0}', '{1}', '{2}');",
                        id, txtIdC.Text, txtNomS.Text), conexion.conexion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Actualizado satisfactoriamente");
                    }
                    conexion.conexion.Close();
                    obtenerDatos();
                    txtIdS.Clear();
                    txtIdC.Clear();
                    txtNomS.Clear();
                }
                else
                {
                    MessageBox.Show("El campo está vacío");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n LA CATEGORIA NO EXISTE");
                conexion.conexion.Close();
            }
        }

        private void btnAS_Click(object sender, EventArgs e)
        {
            txtIdS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtIdC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtNomS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
        }

        private void btnES_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DialogResult confEliminacion = MessageBox.Show("El registro " + id + " será eliminado", "Advertencia", MessageBoxButtons.YesNo);
                if (confEliminacion == DialogResult.Yes)
                {
                    conexion.conexion.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM subcategory WHERE id='" + id + "';", conexion.conexion);
                    cmd.ExecuteNonQuery();
                    conexion.conexion.Close();
                    MessageBox.Show("Eliminado satisfactoriamente");
                    obtenerDatos();
                    txtIdS.Clear();
                    txtIdC.Clear();
                    txtNomS.Clear();
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
            txtIdS.Enabled = true;
            txtIdC.Enabled = false;
            txtNomS.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si el campo del Id no está vacío, realizará la búsqueda
                if (!string.IsNullOrEmpty(txtIdS.Text))
                {
                    int id = Convert.ToInt32(txtIdS.Text);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM subcategory WHERE id = @id", conexion.conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    conexion.conexion.Open();
                    MySqlDataReader tabla = cmd.ExecuteReader();
                    try
                    {
                        //Si lo encuentra, se mostrará el título que corresponde al Id
                        tabla.Read();
                        MessageBox.Show("La  subcategoría" + id + " es: " + tabla[2].ToString());
                        conexion.conexion.Close();
                        //Se habilitan los elementos como al inicio
                        txtIdS.Enabled = false;
                        txtIdS.Clear();
                        txtIdC.Enabled = true;
                        txtNomS.Enabled = true;
                        btnBuscar.Visible = false;
                    }
                    catch
                    {
                        //Si no se encuentra, se mostrará el siguiente mensaje indicando el error
                        MessageBox.Show("No se encuentra esa subcategoría");
                        //Se habilitan los elementos como al inicio
                        txtIdS.Enabled = false;
                        txtIdS.Clear();
                        txtIdC.Enabled = true;
                        txtNomS.Enabled = true;
                        btnBuscar.Visible = false;
                    }
                    finally
                    {
                        conexion.conexion.Close();

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.conexion.Close();
            }
        }

        private void btnADatos_Click(object sender, EventArgs e)
        {
            obtenerDatos();
        }
    }
}
