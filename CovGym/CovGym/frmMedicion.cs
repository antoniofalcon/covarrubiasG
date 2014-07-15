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
    public partial class frmMedicion : Form
    {
        Tools tls = new Tools();
        ConexionBD bd = new ConexionBD();
        string id,idOld,idMed;
        public frmMedicion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!tls.ValidText(txtName.Text))
            {
                MessageBox.Show("Nombre no válido");
                txtName.Clear();
                txtName.Focus();
                return;
            }
            else
            {
                try
                {
                    cmbClienteMen.Items.Clear();
                    string dato = "%" + txtName.Text + "%";
                    bd.AbrirConexion();
                    bd.BuscarClienteNombre(dato);
                    while (bd.ResultadoConsulta().Read())
                    {
                        cmbClienteMen.Items.Add(bd.ResultadoConsulta().GetValue(1));
                    }                   
                    bd.CerrarConexion();
                    cmbClienteMen.SelectedIndex = 0;
                    txtName.Clear();
                    cmbClienteMen.Enabled = true;
                    txtBrazo.Enabled = true;
                    txtCadera.Enabled = true;
                    txtCinAlta.Enabled = true;
                    txtCinBaja.Enabled = true;
                    txtCinMedia.Enabled = true;
                    txtPecho.Enabled = true;
                    txtPeso.Enabled = true;
                    txtPierna.Enabled = true;
                    txtTalla.Enabled = true;
                    btnAceptarMe.Enabled = true;
                    btnLimpiarMe.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la consulta");
                }
            }
        }

        private void cmbClienteMen_SelectedIndexChanged(object sender, EventArgs e)
        {           
                try
                {
                    bd.AbrirConexion();
                    bd.ObtenerIdClienteMedida(cmbClienteMen.Text);
                    if (bd.ResultadoConsulta().Read())
                    {
                        id = bd.ResultadoConsulta().GetValue(0).ToString();
                    }
                    bd.CerrarConexion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al seleccionar cliente");
                }
            
        }

        private void btnAceptarMe_Click(object sender, EventArgs e)
        {
            //frmInicio ini = new frmInicio();
            string fecha;
            //ini.tsmFecha.Text;

            //Formatear fecha
            fecha = DateTime.Now.ToShortDateString();
            fecha = tls.DMYToYMD(fecha);          
            //Validar peso
            if (!tls.ValidMedida(txtPeso.Text))
            {
                MessageBox.Show("Peso no válido");
                txtPeso.Clear();
                txtPeso.Focus();
                return;
            }
            //Validar talla
            if (!tls.ValidTalla(txtTalla.Text))
            {
                MessageBox.Show("Talla no válido");
                txtTalla.Clear();
                txtTalla.Focus();
                return;
            }
            //Validar pecho
            if (!tls.ValidMedida(txtPecho.Text))
            {
                MessageBox.Show("Medida de pecho no válida");
                txtPecho.Clear();
                txtPecho.Focus();
                return;
            }
            //Validar brazo
            if (!tls.ValidMedida(txtBrazo.Text))
            {
                MessageBox.Show("Medida de peso no válida");
                txtBrazo.Clear();
                txtBrazo.Focus();
                return;
            }
            //Validar cintura alta
            if (!tls.ValidMedida(txtCinAlta.Text))
            {
                MessageBox.Show("Medida de cintura alta no válida");
                txtCinAlta.Clear();
                txtCinAlta.Focus();
                return;
            }
            //Validar cintura media
            if (!tls.ValidMedida(txtCinMedia.Text))
            {
                MessageBox.Show("Medida de cintura media no válida");
                txtCinMedia.Clear();
                txtCinMedia.Focus();
                return;
            }
            //Validar cintura baja
            if (!tls.ValidMedida(txtCinBaja.Text))
            {
                MessageBox.Show("Medida de cintura baja no válida");
                txtCinBaja.Clear();
                txtCinBaja.Focus();
                return;
            }
            //Validar cadera
            if (!tls.ValidMedida(txtCadera.Text))
            {
                MessageBox.Show("Medida de cadera no válida");
                txtCadera.Clear();
                txtCadera.Focus();
                return;
            }
            //Validar pierna
            if (!tls.ValidMedida(txtPierna.Text))
            {
                MessageBox.Show("Medida de pierna no válida");
                txtPierna.Clear();
                txtPierna.Focus();
                return;
            }
            if (frmInicio.med == "nuevo")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.InsertMedida(id, fecha, txtPeso.Text, txtTalla.Text, txtPecho.Text, txtBrazo.Text, txtCinAlta.Text, txtCinMedia.Text, txtCinBaja.Text, txtCadera.Text, txtPierna.Text);
                    bd.CerrarConexion();
                    MessageBox.Show("medidas registradas correctamente");                   
                    txtBrazo.Clear();
                    txtCadera.Clear();
                    txtCinAlta.Clear();
                    txtCinBaja.Clear();
                    txtCinMedia.Clear();
                    txtPecho.Clear();
                    txtPeso.Clear();
                    txtPierna.Clear();
                    txtTalla.Clear();
                    cmbClienteMen.Enabled = false;
                    cmbClienteMen.Items.Clear();
                    txtBrazo.Enabled = false;
                    txtCadera.Enabled = false;
                    txtCinAlta.Enabled = false;
                    txtCinBaja.Enabled = false;
                    txtCinMedia.Enabled = false;
                    txtPecho.Enabled = false;
                    txtPeso.Enabled = false;
                    txtPierna.Enabled = false;
                    txtTalla.Enabled = false;
                    btnAceptarMe.Enabled = false;
                    btnLimpiarMe.Enabled = false;
                    txtName.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar medida");
                }
            }
            else if (frmInicio.med == "existe" && btnAceptarMe.Text == "Aceptar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.UpdateMedida(id, txtPeso.Text, txtTalla.Text, txtPecho.Text, txtBrazo.Text, txtCinAlta.Text, txtCinMedia.Text, txtCinBaja.Text, txtCadera.Text, txtPierna.Text,idMed);
                    bd.CerrarConexion();
                    MessageBox.Show("Datos de medidas actualizadas correctamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar datos de medidas" + ex.Message);
                }
            }
            else if (btnAceptarMe.Text == "Eliminar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.DeleteMedida(idMed);
                    bd.CerrarConexion();
                    MessageBox.Show("Datos de medidas eliminadas correctamente");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar datos de medidas");

                }
            }
        }

        private void frmMedicion_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            btnAceptarMe.BackgroundImage = Image.FromFile(frmInicio.bAcep);
            btnAceptarMe.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelMe.BackgroundImage = Image.FromFile(frmInicio.bCan);
            btnCancelMe.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiarMe.BackgroundImage = Image.FromFile(frmInicio.bLim);
            btnLimpiarMe.BackgroundImageLayout = ImageLayout.Stretch;
            if (frmInicio.med == "existe" && frmBuscar.verMed == false)
            {
                txtName.Visible=true;
                btnBuscar.Visible=true;
                label11.Visible = true;
                btnAceptarMe.Enabled = true;
                btnLimpiarMe.Enabled = true;
                
                
                try
                {
                    bd.AbrirConexion();
                    bd.ObtenerMedidas(frmBuscar.code, frmBuscar.fecha);
                    if (bd.ResultadoConsulta().Read())
                    {
                        idOld= bd.ResultadoConsulta().GetValue(1).ToString();
                        idMed = bd.ResultadoConsulta().GetValue(0).ToString();
                        //cmbClienteMen.Text = frmBuscar.name;
                        txtPeso.Text = bd.ResultadoConsulta().GetValue(3).ToString();
                        txtTalla.Text = bd.ResultadoConsulta().GetValue(4).ToString();
                        txtPecho.Text = bd.ResultadoConsulta().GetValue(5).ToString();
                        txtBrazo.Text = bd.ResultadoConsulta().GetValue(6).ToString();
                        txtCinAlta.Text = bd.ResultadoConsulta().GetValue(7).ToString();
                        txtCinMedia.Text = bd.ResultadoConsulta().GetValue(8).ToString();
                        txtCinBaja.Text = bd.ResultadoConsulta().GetValue(9).ToString();                        
                        txtCadera.Text = bd.ResultadoConsulta().GetValue(10).ToString();
                        txtPierna.Text = bd.ResultadoConsulta().GetValue(11).ToString();
                    }                    
                    bd.CerrarConexion();
                    bd.AbrirConexion();
                    bd.BuscarClienteId(idOld);

                    if (bd.ResultadoConsulta().Read())
                    {
                        idOld = bd.ResultadoConsulta().GetValue(0).ToString();
                        cmbClienteMen.Items.Add(idOld);
                    }
                    bd.CerrarConexion();
                    cmbClienteMen.Enabled = true;
                    txtPeso.Enabled = true;
                    txtTalla.Enabled = true;
                    txtPecho.Enabled = true;
                    txtBrazo.Enabled = true;
                    txtCinAlta.Enabled = true;
                    txtCinMedia.Enabled = true;
                    txtCinBaja.Enabled = true;
                    txtCadera.Enabled = true;
                    txtPierna.Enabled = true;

                    try
                    {
                        bd.AbrirConexion();
                        bd.ObtenerIdClienteMedida(cmbClienteMen.Text);
                        if (bd.ResultadoConsulta().Read())
                        {
                            id = bd.ResultadoConsulta().GetValue(0).ToString();
                        }
                        bd.CerrarConexion();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error al seleccionar cliente");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al intentar consultar medidas");
                    frmBuscar buscar = new frmBuscar();
                    buscar.Show();
                    this.Close();
                }
            }
            else if (frmBuscar.verMed)
            {
                btnAceptarMe.Text = "Eliminar";
                txtName.Visible=false;
                btnBuscar.Visible=false;
                label11.Visible = false;
                btnAceptarMe.Enabled = true;
                btnLimpiarMe.Enabled = true;
                try
                {
                    bd.AbrirConexion();
                    bd.ObtenerMedidas(frmBuscar.code, frmBuscar.fecha);
                    if (bd.ResultadoConsulta().Read())
                    {
                        idOld = bd.ResultadoConsulta().GetValue(1).ToString();
                        idMed = bd.ResultadoConsulta().GetValue(0).ToString();
                        txtPeso.Text = bd.ResultadoConsulta().GetValue(3).ToString();
                        txtTalla.Text = bd.ResultadoConsulta().GetValue(4).ToString();
                        txtPecho.Text = bd.ResultadoConsulta().GetValue(5).ToString();
                        txtBrazo.Text = bd.ResultadoConsulta().GetValue(6).ToString();
                        txtCinAlta.Text = bd.ResultadoConsulta().GetValue(7).ToString();
                        txtCinMedia.Text = bd.ResultadoConsulta().GetValue(8).ToString();
                        txtCinBaja.Text = bd.ResultadoConsulta().GetValue(9).ToString();
                        txtCadera.Text = bd.ResultadoConsulta().GetValue(10).ToString();
                        txtPierna.Text = bd.ResultadoConsulta().GetValue(11).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar visualizar medidas");
                        frmBuscar buscar = new frmBuscar();
                        buscar.Show();
                        this.Close();
                    }
                    bd.CerrarConexion();
                    bd.AbrirConexion();
                    bd.BuscarClienteId(idOld);
                   
                    if (bd.ResultadoConsulta().Read())
                    {
                        idOld = bd.ResultadoConsulta().GetValue(0).ToString();
                        cmbClienteMen.Items.Add(idOld);
                    }
                    bd.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! Intentelo nuevamente");
                }
            }
        }

        private void btnCancelMe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarMe_Click(object sender, EventArgs e)
        {
            txtBrazo.Clear();
            txtCadera.Clear();
            txtCinAlta.Clear();
            txtCinBaja.Clear();
            txtCinMedia.Clear();
            txtPecho.Clear();
            txtPeso.Clear();
            txtPierna.Clear();
            txtTalla.Clear();
            txtName.Clear();
            cmbClienteMen.Items.Clear();
        } 
    }
}
