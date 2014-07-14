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
    public partial class frmClientes : Form 
    {
        ConexionBD bd = new ConexionBD();
        Tools tls = new Tools();
        frmInicio inicio = new frmInicio();
        int clave;
        string claveTem;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnCancelCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
           /* if(frmInicio.cliente == "nuevo" && txtFoto.TextLength <1)
            {
                pbFoto.ImageLocation = @"C:\archivos\user.png";
            }
            */
            //frmInicio ini = new frmInicio();
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            btnAceptarCli.BackgroundImage = Image.FromFile(frmInicio.bAcep);
            btnAceptarCli.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelCli.BackgroundImage = Image.FromFile(frmInicio.bCan);
            btnCancelCli.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.BackgroundImage = Image.FromFile(frmInicio.bLim);
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            if (frmInicio.cliente == "nuevo")
            {
                pbFoto.ImageLocation = @"C:\archivos\user.png";
                bd.AbrirConexion();
                bd.ObtenerIdCliente();
                if (bd.ResultadoConsulta().Read())
                {
                    claveTem = bd.ResultadoConsulta().GetValue(0).ToString();
                    clave = int.Parse(claveTem) + 1;
                    txtClave.Text = clave.ToString("0000");
                }
                bd.CerrarConexion();
            }
            else if (frmInicio.cliente == "existe" && frmBuscar.ver == false)
            {               
                bd.AbrirConexion();
                bd.BuscarCliente(frmBuscar.code);
                if (bd.ResultadoConsulta().Read())
                {
                    txtName.Text = bd.ResultadoConsulta().GetValue(1).ToString();
                    tls.ObtenerCalle(bd.ResultadoConsulta().GetValue(2).ToString());
                    txtCalle.Text = tls.calle;
                    txtNum.Text = tls.numero;
                    txtCol.Text = tls.col;
                    txtCp.Text = tls.cp;
                    txtTel.Text = bd.ResultadoConsulta().GetValue(3).ToString();
                    txtCel.Text = bd.ResultadoConsulta().GetValue(4).ToString();
                    dtFec.Text = bd.ResultadoConsulta().GetValue(5).ToString();
                    txtEmail.Text = bd.ResultadoConsulta().GetValue(6).ToString();
                    txtFb.Text = bd.ResultadoConsulta().GetValue(7).ToString();
                    txtClave.Text = bd.ResultadoConsulta().GetValue(8).ToString();
                    txtFoto.Text = bd.ResultadoConsulta().GetValue(9).ToString();
                    pbFoto.ImageLocation = txtFoto.Text;
                }
                else
                {
                    MessageBox.Show("Error al intentar modificar cliente");
                    frmBuscar buscar = new frmBuscar();
                    buscar.Show();
                    this.Close();
                }
                bd.CerrarConexion();
            }
            else if (frmBuscar.ver)
            {
                btnAceptarCli.Text = "Eliminar";
                try
                {
                    bd.AbrirConexion();
                    bd.BuscarCliente(frmBuscar.code);
                    if (bd.ResultadoConsulta().Read())
                    {
                        txtName.Text = bd.ResultadoConsulta().GetValue(1).ToString();
                        tls.ObtenerCalle(bd.ResultadoConsulta().GetValue(2).ToString());
                        txtCalle.Text = tls.calle;
                        txtNum.Text = tls.numero;
                        txtCol.Text = tls.col;
                        txtCp.Text = tls.cp;
                        txtTel.Text = bd.ResultadoConsulta().GetValue(3).ToString();
                        txtCel.Text = bd.ResultadoConsulta().GetValue(4).ToString();
                        dtFec.Text = bd.ResultadoConsulta().GetValue(5).ToString();
                        txtEmail.Text = bd.ResultadoConsulta().GetValue(6).ToString();
                        txtFb.Text = bd.ResultadoConsulta().GetValue(7).ToString();
                        txtClave.Text = bd.ResultadoConsulta().GetValue(8).ToString();
                        txtFoto.Text = bd.ResultadoConsulta().GetValue(9).ToString();
                        pbFoto.ImageLocation = txtFoto.Text;

                        txtName.Enabled = false;
                        txtCalle.Enabled = false;
                        txtNum.Enabled = false;
                        txtCol.Enabled = false;
                        txtCp.Enabled = false;
                        txtTel.Enabled = false;
                        txtCel.Enabled = false;
                        dtFec.Enabled = false;
                        txtEmail.Enabled = false;
                        txtFb.Enabled = false;
                        txtClave.Enabled = false;
                        txtFoto.Enabled = false;
                        btnLimpiar.Enabled = false;
                        btnFoto.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar visualizar cliente");
                        frmBuscar buscar = new frmBuscar();
                        buscar.Show();
                        this.Close();
                    }
                    bd.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! Intentelo nuevamente");
                }
            }
        }
        
        private void btnAceptarCli_Click(object sender, EventArgs e)
        {
            string direccion, fecha, foto;
            //Validar Nombre
            if (!tls.ValidText(txtName.Text))
            {
                MessageBox.Show("Nombre no válido");
                txtName.Clear();
                txtName.Focus();
                return;
            }
            //Validar calle
            if (!tls.ValidAlfa(txtCalle.Text))
            {
                MessageBox.Show("Calle no válida");
                txtCalle.Clear();
                txtCalle.Focus();
                return;
            }
            //validar número de dirección
            if (!tls.ValidNumDir(txtNum.Text))
            {
                MessageBox.Show("Número de domicilio no válido");
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            //validar colonia
            if (!tls.ValidAlfa(txtCol.Text))
            {
                MessageBox.Show("Colonia no válida");
                txtCol.Clear();
                txtCol.Focus();
                return;
            }
            //validar código postal
            if (!tls.ValidCP(txtCp.Text))
            {
                MessageBox.Show("Código Postal no válido");
                txtCp.Clear();
                txtCp.Focus();
                return;
            }
            //Convertir dirección con formato especificado en Diccionario de Datos
            direccion = txtCalle.Text + " #" + txtNum.Text + " COL. " + txtCol.Text + " C.P. " + txtCp.Text;
            //Validar Telefono
            if (!tls.ValidPhone(txtTel.Text))
            {
                MessageBox.Show("Número telefonico no válido");
                txtTel.Clear();
                txtTel.Focus();
                return;
            }
            //Validar Celular
            if (!tls.ValidPhone(txtCel.Text))
            {
                MessageBox.Show("Número celular no válido");
                txtCel.Clear();
                txtCel.Focus();
                return;
            }
            //Formatear fecha
            fecha = tls.DMYToYMD(dtFec.Text);
            //Validar Email
            if (!tls.ValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Direccion de Correo Electrónico no válido");
                txtEmail.Clear();
                txtEmail.Focus();
                return;
            }
            //obtener dirección de fotografía
            foto = pbFoto.ImageLocation;
            //Insertar cliente

            if (txtFb.Text.Length < 1)
            {
                MessageBox.Show("Facebook no válido");
                txtFb.Clear();
                txtFb.Focus();
                return;
            }
            if (frmInicio.cliente == "nuevo")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.InsertCliente(txtName.Text.ToUpper(), direccion.ToUpper(), txtTel.Text, txtCel.Text, fecha, txtEmail.Text.ToUpper(), txtFb.Text.ToUpper(), txtClave.Text, foto.ToUpper());
                    bd.CerrarConexion();
                    MessageBox.Show("Cliente registrado correctamente");
                    bd.AbrirConexion();
                    bd.ObtenerIdCliente();
                    if (bd.ResultadoConsulta().Read())
                    {
                        claveTem = bd.ResultadoConsulta().GetValue(0).ToString();
                        clave = int.Parse(claveTem) + 1;
                        txtClave.Text = clave.ToString("0000");
                    }
                    bd.CerrarConexion();
                    txtCalle.Clear();
                    txtCel.Clear();
                    txtCol.Clear();
                    txtCp.Clear();
                    txtEmail.Clear();
                    txtFb.Clear();
                    txtFoto.Clear();
                    txtName.Clear();
                    txtNum.Clear();
                    txtTel.Clear();
                    pbFoto.ImageLocation = @"C:\archivos\user.png";                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede registrar nuevo cliente");

                }
            }
            else if (frmInicio.cliente == "existe" &&btnAceptarCli.Text=="Aceptar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.UpdateCliente(txtName.Text.ToUpper(), direccion.ToUpper(), txtTel.Text, txtCel.Text, fecha, txtEmail.Text.ToUpper(), txtFb.Text.ToUpper(), txtClave.Text, foto.ToUpper());
                    bd.CerrarConexion();
                    MessageBox.Show("Datos de cliente modificados correctamente");
                    bd.AbrirConexion();
                    bd.ObtenerIdCliente();
                    if (bd.ResultadoConsulta().Read())
                    {
                        claveTem = bd.ResultadoConsulta().GetValue(0).ToString();
                        clave = int.Parse(claveTem) + 1;
                        txtClave.Text = clave.ToString("0000");
                    }
                    bd.CerrarConexion();
                   /* txtCalle.Clear();
                    txtCel.Clear();
                    txtCol.Clear();
                    txtCp.Clear();
                    txtEmail.Clear();
                    txtFb.Clear();
                    txtFoto.Clear();
                    txtName.Clear();
                    txtNum.Clear();
                    txtTel.Clear();
                    pbFoto.ImageLocation = @"C:\archivos\user.png";*/
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede actualizar datos de cliente");

                }
            }
            else if (btnAceptarCli.Text == "Eliminar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.DeleteCliente(txtClave.Text);
                    bd.CerrarConexion();
                    MessageBox.Show("Cliente eliminado correctamente");
                    bd.AbrirConexion();
                    bd.ObtenerIdCliente();
                    if (bd.ResultadoConsulta().Read())
                    {
                        claveTem = bd.ResultadoConsulta().GetValue(0).ToString();
                        clave = int.Parse(claveTem) + 1;
                        txtClave.Text = clave.ToString("0000");
                    }
                    bd.CerrarConexion();
                    /*txtCalle.Clear();
                    txtCel.Clear();
                    txtCol.Clear();
                    txtCp.Clear();
                    txtEmail.Clear();
                    txtFb.Clear();
                    txtFoto.Clear();
                    txtName.Clear();
                    txtNum.Clear();
                    txtTel.Clear();
                    pbFoto.ImageLocation = @"C:\archivos\user.png";
                    btnAceptarCli.Text = "Aceptar";
                    txtName.Enabled = true;
                    txtCalle.Enabled = true;
                    txtNum.Enabled = true;
                    txtCol.Enabled = true;
                    txtCp.Enabled = true;
                    txtTel.Enabled = true;
                    txtCel.Enabled = true;
                    dtFec.Enabled = true;
                    txtEmail.Enabled = true;
                    txtFb.Enabled = true;
                    txtFoto.Enabled = true;
                    btnLimpiar.Enabled = true;
                    btnFoto.Enabled = true;
                    btnAceptarCli.Enabled = true;
                    frmInicio.cliente = "nuevo";*/
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede eliminar cliente");

                }
            }
        }
        
        private void btnFoto_Click(object sender, EventArgs e)
        {
            frmFoto a = new frmFoto();
            a.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            bd.CerrarConexion();
            txtCalle.Clear();
            txtCel.Clear();
            txtCol.Clear();
            txtCp.Clear();
            txtEmail.Clear();
            txtFb.Clear();
            txtFoto.Clear();
            txtName.Clear();
            txtNum.Clear();
            txtTel.Clear();
            pbFoto.ImageLocation = @"C:\archivos\user.png";
        }

        private void txtFoto_TextChanged(object sender, EventArgs e)
        {
            pbFoto.ImageLocation = txtFoto.Text;
        }

    }
}
