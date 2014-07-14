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
    public partial class frmEntradas : Form
    {
        Tools tls = new Tools();
        ConexionBD bd = new ConexionBD();
        string fecha,hora,idCliente,idEntrada;
        public frmEntradas()
        {
            InitializeComponent();
        }

        private void btnAceptarEn_Click(object sender, EventArgs e)
        {
            if (!tls.ValidCode(txtCodigo.Text))
            {
                MessageBox.Show("Código no Válido");
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }
            fecha = tls.DMYToYMD(DateTime.Now.ToShortDateString());
            hora = DateTime.Now.ToLongTimeString();
            if(frmInicio.ent == "nuevo")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.BuscarClienteClave(txtCodigo.Text);
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        idCliente = bd.ResultadoConsulta().GetValue(0).ToString();
                    }
                    bd.CerrarConexion();
                    txtFecha.Text = fecha;
                    txtHora.Text = hora;
                }
                    catch(Exception ex){
                        MessageBox.Show("Codigo de cliente Incorrecto");
                    }
                try
                {
                    bd.AbrirConexion();
                    bd.InsertEntrada(idCliente, fecha);
                    bd.CerrarConexion();
                    bd.AbrirConexion();
                    bd.UltimoIdEntrada();
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        idEntrada = bd.ResultadoConsulta().GetValue(0).ToString();
                    }
                    bd.CerrarConexion();
                    bd.AbrirConexion();
                    bd.SelectValidEnt(idEntrada);
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        if (bd.ResultadoConsulta().GetValue(4).ToString() == "V")
                        {
                            pbValid.ImageLocation = @"C:\archivos\valid.png";
                        }
                        else
                        {
                            pbValid.ImageLocation = @"C:\archivos\invalid.png";
                        } 
                        timer1.Start();
                    }
                    bd.CerrarConexion();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar ingresar Entrada" + ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtCodigo.Focus();
            pbValid.ImageLocation = "";
            timer1.Stop();
        }

        private void frmEntradas_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            btnAceptarEn.BackgroundImage = Image.FromFile(frmInicio.bAcep);
            btnAceptarEn.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelarEn.BackgroundImage = Image.FromFile(frmInicio.bCan);
            btnCancelarEn.BackgroundImageLayout = ImageLayout.Stretch;

        }
    }
}
