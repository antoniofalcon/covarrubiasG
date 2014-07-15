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
    
    public partial class frmInicio : Form
    {
        ConexionBD bd = new ConexionBD();
        public static int nivel=0;
        public static string busqueda = "", direccion = @"c:\archivos\fondo.png", bAcep = @"c:\archivos\b1.png", bCan = @"c:\archivos\b2.png", bLim = @"c:\archivos\b3.png", bVer = @"c:\archivos\b4.png", bMod = @"c:\archivos\b5.png";
        public static string mensual = "";
        public static string membres = "";
        public static string cliente = "";
        public static string med = "";
        public static string ent = "";
        public static string usu = "";
        public static int month;
        public frmInicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cliente = "nuevo";
            frmClientes cli = new frmClientes();
            cli.MdiParent = this;
            cli.Show();
            cli.lbCliente.Text = "Registro de Cliente";
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cliente = "existe";
            busqueda = "cliente";
            frmBuscar buscar = new frmBuscar();
            buscar.lbTituloBus.Text = "   Buscar Clientes";
            buscar.MdiParent = this;
            buscar.Show();            
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mensual = "nuevo";
            frmMensualidad men = new frmMensualidad();
            men.lbMensualidad.Text = "Registro de Mensualidad";
            men.MdiParent = this;
            men.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mensual = "existe";
            busqueda = "mensual";
            frmBuscar buscar = new frmBuscar();
            buscar.lbTituloBus.Text = "Buscar Mensualidades";
            buscar.MdiParent = this;
            buscar.Show();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            membres = "nuevo";
            frmMembresia memb = new frmMembresia();
            memb.lbMemb.Text = "Registro de Membresía";
            memb.MdiParent = this;
            memb.Show();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            membres = "existe";
            busqueda = "membresia";
            frmBuscar buscar = new frmBuscar();
            buscar.MdiParent = this;
            buscar.Show();
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            med = "nuevo";
            frmMedicion medida = new frmMedicion();
            medida.lbMedida.Text = "Registro de Medidas";
            medida.MdiParent = this;
            medida.Show();

        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            med = "existe";
            busqueda = "medida";
            frmBuscar buscar = new frmBuscar();
            buscar.MdiParent = this;
            buscar.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(@"c:\archivos\fondo2.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            frmAcceso acceso = new frmAcceso();
            acceso.ShowDialog();
            if (nivel == 1)
            {
                ganaciaMensualToolStripMenuItem.Visible = true;
                ganaciaMensualToolStripMenuItem.Enabled = true;
                nuevoToolStripMenuItem5.Visible = true;
                nuevoToolStripMenuItem5.Enabled = true;
                modificarToolStripMenuItem4.Visible = true;
                modificarToolStripMenuItem4.Enabled = true;
                membresiasToolStripMenuItem.Visible = true;
                membresiasToolStripMenuItem.Enabled = true;

            }
            else if (nivel == 3)
            {
                menuStrip1.Enabled = false;
                frmEntradasCli cli = new frmEntradasCli();
                cli.ShowDialog();
            }
            //month = DateTime.Now.Year * 100 + DateTime.Now.Month;
            try
            {
                if (nivel < 3)
                {


                    if (frmInicio.nivel > 0)
                    {
                        bd.AbrirConexion();
                        bd.reporteVencido();
                        bd.ResultadoConsulta();
                        if (bd.ResultadoConsulta().Read())
                        {
                            frmRptVencida ven = new frmRptVencida();
                            ven.ShowDialog();
                        }
                        bd.CerrarConexion();
                    }
                }
            }
            catch
            {

            }
        }

        private void nuevoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ent = "nuevo";
            frmEntradas entrada = new frmEntradas();
            entrada.MdiParent = this;
            entrada.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void nuevoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            usu = "nuevo";
            frmUsuarios usuario = new frmUsuarios();
            usuario.lbUsuario.Text = "Registro de Usuario";
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            usu = "existe";
            busqueda = "usuario";
            frmBuscar buscar = new frmBuscar();
            buscar.MdiParent = this;
            buscar.Show();
        }

        private void eliminarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ent = "existe";
            busqueda = "entrada";
            frmBuscar buscar = new frmBuscar();
            buscar.MdiParent = this;
            buscar.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbFecSis.Text = DateTime.Now.ToShortDateString();
            //lbHora.Text = DateTime.Now.ToShortTimeString();
            tsmFecha.Text = DateTime.Now.ToShortDateString();
            tsmHora.Text = DateTime.Now.ToShortTimeString(); 
        }

        private void ganaciaMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmRptGanancia gan = new frmRptGanancia();
            gan.ShowDialog();


        }

        private void medidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRptMedida med = new frmRptMedida();
            med.MdiParent = this;
            med.Show();
        }

        private void mensualidadVencidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptVencida ven = new frmRptVencida();
            ven.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
