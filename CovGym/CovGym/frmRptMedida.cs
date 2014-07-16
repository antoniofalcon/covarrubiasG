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
    public partial class frmRptMedida : Form
    {
        ConexionBD bd = new ConexionBD();
        Tools tls = new Tools();
        public static string idCliente;
        public static string fecha,fechaFi;
        public frmRptMedida()
        {
            InitializeComponent();
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            lbForma.Text = "Nombre:";
            txtForma.Clear();
            txtForma.Focus();
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lbForma.Text = "Código:";
            txtForma.Clear();
            txtForma.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((rbName.Checked && !tls.ValidText(txtForma.Text)) || (rbCodigo.Checked && !tls.ValidCode(txtForma.Text)))
            {
                MessageBox.Show("Datos inválidos");
                txtForma.Clear();
                txtForma.Focus();
                return;
            }
            try
            {
                cmbCliente.Enabled = true;
                if (rbCodigo.Checked == true)
                {
                    cmbCliente.Items.Clear();
                    bd.AbrirConexion();
                    bd.BuscarClienteClave(txtForma.Text);
                    if (bd.ResultadoConsulta().Read())
                    {
                        cmbCliente.Items.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                    }
                    bd.CerrarConexion();
                }
                else if (rbName.Checked == true)
                {
                    string dato = "%" + txtForma.Text + "%";
                    cmbCliente.Items.Clear();
                    bd.AbrirConexion();
                    bd.BuscarClienteNombre(dato);
                    while (bd.ResultadoConsulta().Read())
                    {
                        cmbCliente.Items.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                    }
                    bd.CerrarConexion();
                    cmbCliente.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar buscar");
            }


        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                cmbFecIni.Enabled = true;
                bd.AbrirConexion();
                bd.ObtenerIdClienteMedida(cmbCliente.Text);
                bd.ResultadoConsulta();
                if (bd.ResultadoConsulta().Read())
                {
                    idCliente = bd.ResultadoConsulta().GetValue(0).ToString();
                }
                bd.CerrarConexion();
                bd.AbrirConexion();
                bd.ObtenerFechaMedida(idCliente);
                bd.ResultadoConsulta();
                while (bd.ResultadoConsulta().Read())
                {
                     tls.QuitarHora(bd.ResultadoConsulta().GetValue(0).ToString());
                     fecha = tls.fecha;
                    cmbFecIni.Items.Add(fecha);
                }
                bd.CerrarConexion();
                cmbFecIni.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al seleccionar cliente");
            }
        }

        private void cmbFecIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbFecFin.Items.Clear();
                cmbFecFin.Enabled = true;               
                bd.AbrirConexion();
                fecha = tls.DMYToYMD(cmbFecIni.Text);
                bd.ObtenerFechaMedida(idCliente,fecha);
                bd.ResultadoConsulta();
                while (bd.ResultadoConsulta().Read())
                {
                    tls.QuitarHora(bd.ResultadoConsulta().GetValue(0).ToString());
                    fechaFi = tls.fecha;
                    cmbFecFin.Items.Add(fechaFi);

                }

                bd.CerrarConexion();
                cmbFecFin.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al seleccionar fecha de inicio");
            }
        }

        private void frmRptMedida_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            btnGenerar.BackgroundImage = Image.FromFile(frmInicio.bAcep);
            btnGenerar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelar.BackgroundImage = Image.FromFile(frmInicio.bCan);
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.BackgroundImage = Image.FromFile(frmInicio.bLim);
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            rbName.Checked = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmInicio ini = new frmInicio();
            fecha = cmbFecIni.Text;
            fechaFi = cmbFecFin.Text;
            frmRptMedidaGen med = new frmRptMedidaGen();        
            //med.MdiParent = ini;
            med.Show();
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtForma.Clear();
            txtForma.Focus();
        }
    }
}
