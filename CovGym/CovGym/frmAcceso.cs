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
    public partial class frmAcceso : Form
    {
        ConexionBD bd = new ConexionBD();
        int cont = 0;
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmAcceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmInicio.nivel == 0) Application.Exit();
        }

        private void btnCancelAcc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {

            acceso();


        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            //frmInicio ini = new frmInicio();
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            btnAcceso.BackgroundImage = Image.FromFile(frmInicio.bAcep);
            btnAcceso.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelAcc.BackgroundImage = Image.FromFile(frmInicio.bCan);
            btnCancelAcc.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void acceso()
        {
            try
            {
                bd.AbrirConexion();
                bd.ValidarUsuario(txtUser.Text, txtPass.Text);
                bd.ResultadoConsulta();
                if (bd.ResultadoConsulta().Read())
                {
                    frmInicio.nivel = Convert.ToInt32(bd.ResultadoConsulta().GetString(0));
                    Stream str = Properties.Resources.entrada;
                    SoundPlayer snd = new SoundPlayer(str);
                    snd.Play();
                }
                else
                {
                    cont++;
                    if (cont < 3)
                    {
                        Stream str = Properties.Resources.Errorentrada;
                        SoundPlayer snd = new SoundPlayer(str);
                        snd.Play();
                        txtUser.Text = "";
                        txtPass.Text = "";
                        txtUser.Focus();
                        bd.CerrarConexion();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cantidad de intentos excedida!");
                        Application.Exit();
                    }
                }
                bd.CerrarConexion();
                Close();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error!");
                Application.Exit();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                acceso();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                acceso();
            }
        }
    }
}
