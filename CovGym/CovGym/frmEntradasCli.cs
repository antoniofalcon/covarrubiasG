using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CovGym
{
    public partial class frmEntradasCli : Form
    {
        Tools tls = new Tools();
        ConexionBD bd = new ConexionBD();
        public static bool entrar = false;
        string fecha, hora, idCliente, idEntrada;
        public frmEntradasCli()
        {
            InitializeComponent();
        }

        private void frmEntradasCli_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            entrar = true;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                entrada();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCodigo.Focus();
            pbValid.ImageLocation = "";
            timer1.Stop();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length==4)
            {
                entrada();
            }
        }
        private void entrada()
        {
            if (!tls.ValidCode(txtCodigo.Text))
            {
                Stream str = Properties.Resources.Errorentrada;
                SoundPlayer snd = new SoundPlayer(str);
                snd.Play();
                MessageBox.Show("Código no Válido");
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Codigo de cliente Incorrecto");
            }
            try
            {
                bd.AbrirConexion();
                bd.InsertEntrada(idCliente);
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
                        pbValid.ImageLocation = @"C:\archivos\rs\valid.png";
                        Stream str = Properties.Resources.valido;
                        SoundPlayer snd = new SoundPlayer(str);
                        snd.Play();
                    }
                    else
                    {
                        pbValid.ImageLocation = @"C:\archivos\rs\invalid.png";
                        Stream str = Properties.Resources.Errorentrada;
                        SoundPlayer snd = new SoundPlayer(str);
                        snd.Play();
                    }
                    timer1.Start();
                }
                bd.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar ingresar Entrada");
                txtCodigo.Clear();
                txtCodigo.Focus();
            }
        }
    }
}
