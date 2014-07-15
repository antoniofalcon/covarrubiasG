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
    public partial class frmUsuarios : Form
    {
        Tools tls = new Tools();
        ConexionBD bd = new ConexionBD();
        int nivel;
        string id;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnAceptarUser_Click(object sender, EventArgs e)
        {
            if (!tls.ValidText(txtNameUser.Text))
            {
                MessageBox.Show("Nombre de usuario no válido");
                txtNameUser.Clear();
                txtNameUser.Focus();
                return;
            }
            if (!tls.ValidCuenta(txtCuentaUser.Text))
            {
                MessageBox.Show("Cuenta de usuario no válida");
                txtCuentaUser.Clear();
                txtCuentaUser.Focus();
                return;
            }
            if (txtPassUser.Text.Length < 6)
            {
                MessageBox.Show("la contraseña debe ser mayor a 6 dígitos");
                txtPassUser.Clear();
                txtPassUser.Focus();
                return;
            }
            if (txtPassUser.Text != txtConfirmar.Text)
            {
                MessageBox.Show("la contraseña no coincide");
                txtConfirmar.Clear();
                txtConfirmar.Focus();
                return;
            }
            if (!tls.ValidText(cmbNivelUser.Text))
            {
                MessageBox.Show("Nivel de usuario no válida");
                txtCuentaUser.Clear();
                txtCuentaUser.Focus();
                return;
            }
            if(cmbNivelUser.Text =="ADMINISTRADOR")
            {
                nivel = 1;
            }
            else
            {
                nivel = 2;
            }

            if (frmInicio.usu == "nuevo")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.InsertUsuario(txtNameUser.Text.ToUpper(),txtCuentaUser.Text.ToUpper(),txtPassUser.Text,nivel);
                    bd.CerrarConexion();
                    MessageBox.Show("Usuario registrado correctamente");
                    txtConfirmar.Clear();
                    txtCuentaUser.Clear();
                    txtNameUser.Clear();
                    txtPassUser.Clear();
                    cmbNivelUser.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("No se pudo registrar usuario" + ex.Message);
                }
            }
            else if (frmInicio.usu == "existe" && btnAceptarUser.Text == "Eliminar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.DeleteUsuario(id);
                    bd.CerrarConexion();
                    MessageBox.Show("Usuario eliminado correctamente");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo eliminar usuario" + ex.Message);
                }
            }
            else if (frmInicio.usu == "existe" && btnAceptarUser.Text == "Aceptar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.UpdateUsuario(txtNameUser.Text.ToUpper(),txtCuentaUser.Text.ToUpper(),txtPassUser.Text.ToUpper(),nivel,id);
                    bd.CerrarConexion();
                    MessageBox.Show("Usuario modificado correctamente");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo modificar usuario" + ex.Message);
                }
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            btnAceptarUser.BackgroundImage = Image.FromFile(frmInicio.bAcep);
            btnAceptarUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelUser.BackgroundImage = Image.FromFile(frmInicio.bCan);
            btnCancelUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.BackgroundImage = Image.FromFile(frmInicio.bLim);
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            if (frmInicio.usu == "nuevo")
            {
                cmbNivelUser.SelectedIndex = 0;
            }
             else if (frmInicio.usu == "existe")
            {

                if (frmBuscar.verUsu)
                {
                    btnAceptarUser.Text = "Eliminar";
                    btnLimpiar.Enabled = false;
                    txtNameUser.Enabled = false;
                    txtConfirmar.Enabled = false;
                    txtCuentaUser.Enabled = false;
                    txtPassUser.Enabled = false;
                    cmbNivelUser.Enabled = false;
                }

                try
                {
                    bd.AbrirConexion();
                    bd.ObtenerUsuario(frmBuscar.usuario, frmBuscar.cuenta);
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        id = bd.ResultadoConsulta().GetValue(0).ToString();
                        txtNameUser.Text = bd.ResultadoConsulta().GetValue(1).ToString();
                        txtCuentaUser.Text = bd.ResultadoConsulta().GetValue(2).ToString();
                        
                        if (bd.ResultadoConsulta().GetValue(4).ToString() == "1")
                        {
                            cmbNivelUser.Text = "ADMINISTRADOR";
                        }
                        else
                        {
                            cmbNivelUser.Text = "NORMAL";
                        }
                    }
                    bd.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. Intentelo nuevamente");
                    frmInicio.busqueda = "usuario";
                    frmBuscar bus = new frmBuscar();
                    bus.Show();
                    this.Close();
                    
                }
            }
        }
    }
}
