using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovGym
{
    public partial class frmMembresia : Form
    {
        Tools tls = new Tools();
        ConexionBD bd = new ConexionBD();
        string id;

        public frmMembresia()
        {
            InitializeComponent();
        }

        private void btnAceptarCli_Click(object sender, EventArgs e)
        {
            //Validacion de membresia..
            if (!tls.ValidText(txtName.Text))
            { 
                MessageBox.Show("Membresía no Válida");
                txtName.Clear();
                txtName.Focus();
                return;
            }

            if (!tls.ValidDecimal(txtCosto.Text))
            {
                MessageBox.Show("Costo no Válido");
                txtCosto.Clear();
                txtCosto.Focus();
                return;
            }

            if (frmInicio.membres == "nuevo")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.InsertarMembresia(txtName.Text.ToUpper(), txtCosto.Text);
                    bd.CerrarConexion();
                    MessageBox.Show("Membresia agregada correctamente");
                    txtCosto.Clear();
                    txtName.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar membresía");
                }

            }
            else if (frmInicio.membres == "existe" && btnAceptarMemb.Text == "Aceptar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.UpdateMembresia(txtName.Text.ToUpper(), txtCosto.Text,id);
                    bd.CerrarConexion();
                    MessageBox.Show("Membresía modificada correctamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo modificar membresía");
                }
            }
            else if (btnAceptarMemb.Text == "Eliminar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.DeleteMembresia(id);
                    bd.CerrarConexion();
                    MessageBox.Show("Membresía Eliminada correctamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo Eliminar membresía" + ex.Message);
                }
            }

        }

        private void frmMembresia_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            btnAceptarMemb.BackgroundImage = Image.FromFile(frmInicio.bAcep);
            btnAceptarMemb.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelCliMemb.BackgroundImage = Image.FromFile(frmInicio.bCan);
            btnCancelCliMemb.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiarMemb.BackgroundImage = Image.FromFile(frmInicio.bLim);
            btnLimpiarMemb.BackgroundImageLayout = ImageLayout.Stretch;
            if (frmInicio.membres == "existe" )
            {
                try
                {
                    bd.AbrirConexion();
                    bd.buscarMembresia(frmBuscar.membr);
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        id = bd.ResultadoConsulta().GetValue(0).ToString();
                        txtName.Text = bd.ResultadoConsulta().GetValue(1).ToString();
                        txtCosto.Text = bd.ResultadoConsulta().GetValue(2).ToString();
                    }
                    bd.CerrarConexion();
                    if (frmBuscar.verMembre)
                    {
                        btnAceptarMemb.Text = "Eliminar";
                        txtCosto.Enabled = false;
                        txtName.Enabled = false;
                        btnLimpiarMemb.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo Obtener la consulta");
                }
            }
            
        }

        private void btnCancelCliMemb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarMemb_Click(object sender, EventArgs e)
        {
            txtCosto.Clear();
            txtName.Clear();
        }
    }
}
