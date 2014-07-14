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
    public partial class frmMensualidad : Form
    {
        Tools tls = new Tools();
        ConexionBD bd = new ConexionBD();
        public static string id,idMembre,fecIni,fecPago,fecVen,idMensual,cliente,membresia,costo;
        decimal pago = 0;
        public frmMensualidad()
        {
            InitializeComponent();
        }

        private void frmMensualidad_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            btnAceptarMen.BackgroundImage = Image.FromFile(frmInicio.bAcep);
            btnAceptarMen.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelMen.BackgroundImage = Image.FromFile(frmInicio.bCan);
            btnCancelMen.BackgroundImageLayout = ImageLayout.Stretch;
            btnImprimir.BackgroundImage = Image.FromFile(frmInicio.bMod);
            btnImprimir.BackgroundImageLayout = ImageLayout.Stretch;
            if (frmInicio.mensual == "nuevo")
            {
                try
                {
                    dtFecVencimiento.Value = dtFecInicio.Value.AddDays(30);
                    bd.AbrirConexion();
                    bd.SelectMembresia();
                    bd.ResultadoConsulta();
                    while (bd.ResultadoConsulta().Read())
                    {
                        cmbMemMen.Items.Add(bd.ResultadoConsulta().GetValue(1));
                    }
                    bd.CerrarConexion();
                    cmbMemMen.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                    this.Close();
                }
                
            }
                //Existente
            else if (frmInicio.mensual == "existe")
            { 
                if ( frmBuscar.verMensual)
                {
                    btnAceptarMen.Text = "Eliminar";
                    btnAceptarMen.Enabled = true;
                    btnImprimir.Enabled=true;
                    txtName.Enabled = false;
                    btnBuscar.Enabled=false;
                }
                else if ( !frmBuscar.verMensual)
                {
                    btnAceptarMen.Enabled = true;
                    btnImprimir.Enabled = true;
                    txtName.Enabled = true;
                    btnBuscar.Enabled = true;
                    cmbClienteMen.Enabled = true;
                    cmbMemMen.Enabled = true;
                    dtFecInicio.Enabled = true;
                    dtFecVencimiento.Enabled = true;
                }
                try
                {
                    bd.AbrirConexion();
                    bd.BuscarCliente(frmBuscar.code);
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        id = bd.ResultadoConsulta().GetValue(0).ToString();
                        cmbClienteMen.Items.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                        
                    }
                    bd.CerrarConexion();
                    cmbClienteMen.SelectedIndex = 0;
                    bd.AbrirConexion();
                    bd.ObtenerMensualidad(id, frmBuscar.fecha);
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        idMensual = bd.ResultadoConsulta().GetValue(0).ToString();
                        idMembre = bd.ResultadoConsulta().GetValue(2).ToString();
                        costo = bd.ResultadoConsulta().GetValue(6).ToString();
                        fecIni = bd.ResultadoConsulta().GetValue(3).ToString();
                        fecVen = bd.ResultadoConsulta().GetValue(4).ToString();
                        tls.QuitarHora(bd.ResultadoConsulta().GetValue(5).ToString());
                        fecPago = tls.fecha;
                    }
                    bd.CerrarConexion();
                    dtFecInicio.Text = fecIni;
                    dtFecVencimiento.Text= fecVen;
                    
                    bd.AbrirConexion();
                    bd.ObtenerMembresia(idMembre);
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        cmbMemMen.Items.Add(bd.ResultadoConsulta().GetValue(0).ToString());
                        
                    }
                    bd.CerrarConexion();
                    cmbMemMen.SelectedIndex = 0;
                    bd.AbrirConexion();
                    bd.SelectMembresia(idMembre,"");
                    bd.ResultadoConsulta();
                    while (bd.ResultadoConsulta().Read())
                    {
                        cmbMemMen.Items.Add(bd.ResultadoConsulta().GetValue(1));
                    }
                    bd.CerrarConexion();
                    txtCosto.Text = costo;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex.Message);
                    this.Close();
                }  
            }
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
                    cmbMemMen.Enabled = true;
                    dtFecInicio.Enabled = true;
                    dtFecVencimiento.Enabled = true;
                    btnAceptarMen.Enabled = true;
                    btnImprimir.Enabled = true;

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

        private void cmbMemMen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                    bd.AbrirConexion();
                    bd.SelectMembresia(cmbMemMen.Text);
                    if (bd.ResultadoConsulta().Read())
                    {
                        idMembre = bd.ResultadoConsulta().GetValue(0).ToString();
                        pago = Decimal.Parse(bd.ResultadoConsulta().GetValue(2).ToString());
                    }
                    bd.CerrarConexion();
                    txtCosto.Text = Convert.ToString(pago);
                    ObtenerMonto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al seleccionar Membresía");
            }
        }

        private void btnAceptarMen_Click(object sender, EventArgs e)
        {
            if(!tls.ValidText(cmbClienteMen.Text))
            {
                MessageBox.Show("Cliente no válido");
                txtName.Clear();
                txtName.Focus();
                return;
            }
            if (!tls.ValidAlfa(cmbMemMen.Text))
            {
                MessageBox.Show("Membresía no válido");
                cmbMemMen.Focus();
                return;
            }
            if ((dtFecVencimiento.Value.Year < dtFecInicio.Value.Year) || 
                ((dtFecVencimiento.Value.Year == dtFecInicio.Value.Year)
                && (dtFecVencimiento.Value.Month < dtFecInicio.Value.Month)) || 
                ((dtFecVencimiento.Value.Year == dtFecInicio.Value.Year)
                && (dtFecVencimiento.Value.Month == dtFecInicio.Value.Month) &&
                (dtFecVencimiento.Value.Day <= dtFecInicio.Value.Day)))
            {
                MessageBox.Show("Fecha de vencimiento no válida");
                dtFecVencimiento.Focus();
                return;
            }

            fecIni = tls.DMYToYMD(dtFecInicio.Text);
            fecVen = tls.DMYToYMD(dtFecVencimiento.Text);
            fecPago = tls.DMYToYMD(DateTime.Now.ToShortDateString());
            if (frmInicio.mensual == "nuevo")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.InsertMensualidad(id, idMembre, fecIni, fecVen, fecPago,txtCosto.Text);
                    bd.CerrarConexion();
                    MessageBox.Show("Mensualidad registrada correctamente");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al intentar registrar mensualidad");
                }
            }
            else if (frmInicio.mensual =="existe" &&  btnAceptarMen.Text=="Aceptar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.UpdateMensualidades(idMensual,id, idMembre, fecIni, fecVen,txtCosto.Text);
                    bd.CerrarConexion();
                    MessageBox.Show("Mensualidad modificada correctamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar modificar mensualidad" + ex.Message);
                }
            }
            else if (frmInicio.mensual == "existe" && btnAceptarMen.Text == "Eliminar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.DeleteMensualidad(idMensual);
                    bd.CerrarConexion();
                    MessageBox.Show("Mensualidad eliminada correctamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar Eliminar mensualidad" + ex.Message);
                }
            }
        }

        private void dtFecInicio_ValueChanged(object sender, EventArgs e)
        {
            dtFecVencimiento.Value = dtFecInicio.Value.AddDays(30);
        }

        private void dtFecVencimiento_ValueChanged(object sender, EventArgs e)
        {

            ObtenerMonto();
        }

        private void ObtenerMonto()
        {
            int cantidad = 0;
            decimal total = 0;
            if (dtFecVencimiento.Value < dtFecInicio.Value)
            {
                MessageBox.Show("La fecha de vencimiento debe ser mayor a la fecha de inicio");
                dtFecVencimiento.Value = dtFecInicio.Value.AddDays(30);
                return;
            }
            cantidad = Math.Abs((dtFecInicio.Value.Month - dtFecVencimiento.Value.Month) + 12 * (dtFecInicio.Value.Year - dtFecVencimiento.Value.Year));
            total = pago * cantidad;
            txtCosto.Text = Convert.ToString(total);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!tls.ValidText(cmbClienteMen.Text))
            {
                MessageBox.Show("Cliente no válido");
                txtName.Clear();
                txtName.Focus();
                return;
            }
            if (!tls.ValidAlfa(cmbMemMen.Text))
            {
                MessageBox.Show("Membresía no válido");
                cmbMemMen.Focus();
                return;
            }
            if ((dtFecVencimiento.Value.Year < dtFecInicio.Value.Year) ||
                ((dtFecVencimiento.Value.Year == dtFecInicio.Value.Year)
                && (dtFecVencimiento.Value.Month < dtFecInicio.Value.Month)) ||
                ((dtFecVencimiento.Value.Year == dtFecInicio.Value.Year)
                && (dtFecVencimiento.Value.Month == dtFecInicio.Value.Month) &&
                (dtFecVencimiento.Value.Day <= dtFecInicio.Value.Day)))
            {
                MessageBox.Show("Fecha de vencimiento no válida");
                dtFecVencimiento.Focus();
                return;
            }
            cliente = cmbClienteMen.Text;
            membresia = cmbMemMen.Text;
            fecIni = dtFecInicio.Text;
            fecVen = dtFecVencimiento.Text;
            costo = txtCosto.Text;
            frmPago pago = new frmPago();
            this.Close();
            pago.ShowDialog();
            
        }
    }
}
