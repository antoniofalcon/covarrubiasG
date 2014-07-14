using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovGym
{
    public partial class frmRptVencida : Form
    {
        ConexionBD bd = new ConexionBD();
        Tools tls = new Tools();
        string clave, cliente, fecha;
        public frmRptVencida()
        {
            InitializeComponent();
        }

        private void frmRptVencida_Load(object sender, EventArgs e)
        {
            try
            {
                bd.AbrirConexion();
                bd.reporteVencido();
                bd.ResultadoConsulta();
                StreamWriter objWriter = new StreamWriter("mensualidadvencida.html");
                string sLine = "";
                objWriter.WriteLine("<!DOCTYPE html><html><head> <meta charset=\"utf-8\"/>" +
                "<script type=\"text/javascript\" src=\"js/jquery-1.11.1.min.js\"></script>" +
                "<link href=\"lib/tb/css/bootstrap.min.css\" rel=\"stylesheet\"> " +
                "</head><body><p class = \"text-right\">" + DateTime.Now.ToLongDateString() + "&nbsp;&nbsp;</p><br><br>" +
                "<p class = \"text-center lead\">COVARRUBIAS GYM</p><br>" +
                "<p class = \"text-center\">REPORTE DE CLIENTES CON MENSUALIDAD VENCIDA</p><br><br>");
                objWriter.WriteLine("<div class=\"table-responsive\"><table  class = \"table table-bordered table-hover\"><tbody>");
                sLine = "<tr><th class = \"text-center\">CLAVE</th><th class = \"text-center\">CLIENTE</th><th class = \"text-center\">FECHA DE VENCIMIENTO </th></tr>";
                objWriter.WriteLine(sLine);
                while (bd.ResultadoConsulta().Read())
                {
                    clave = bd.ResultadoConsulta().GetString(0);
                    cliente = bd.ResultadoConsulta().GetString(1);
                    tls.QuitarHora(bd.ResultadoConsulta().GetString(2));
                    fecha = tls.fecha;
                    sLine = "<tr><td class = \"text-center\">";
                    sLine = sLine + clave + "</td><td class = \"text-center\">";
                    sLine = sLine + cliente + "</td><td class = \"text-center\">";
                    sLine = sLine + fecha + "</td></tr>";
                    objWriter.WriteLine(sLine);
                }
                bd.CerrarConexion();
                objWriter.WriteLine("</tbody></table></div></body></html>");
                objWriter.Close();
                Uri dir = new Uri(Directory.GetCurrentDirectory() + "\\mensualidadvencida.html");
                webBrowser1.Url = dir;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error!!");
                this.Close();
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }
    }
}
