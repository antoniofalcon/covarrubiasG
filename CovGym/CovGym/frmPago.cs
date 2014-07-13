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

namespace CovGym
{
    public partial class frmPago : Form
    {
        Tools tls = new Tools();
        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {

            StreamWriter objWriter = new StreamWriter("comprobantepago.html");
            string sLine = "";
            objWriter.WriteLine("<!DOCTYPE html><html><head> <meta charset=\"utf-8\"/>" +
            "<script type=\"text/javascript\" src=\"js/jquery-1.11.1.min.js\"></script>" +
            "<link href=\"lib/tb/css/bootstrap.min.css\" rel=\"stylesheet\"> " +
            "</head><body><p class = \"text-right\">" + DateTime.Now.ToLongDateString() + "&nbsp;&nbsp;</p><br><br>" +
            "<p class = \"text-center lead\">COVARRUBIAS GYM</p><br>" +
            "<p class = \"text-center\">COMPROBANTE DE PAGO</p><br><br>");
            objWriter.WriteLine("<div class=\"table-responsive\"><table class= \"table table-bordered\"><tbody>");
            //sLine = "<tr><th >CLIENTE: &nbsp;&nbsp;&nbsp;&nbsp;" + frmMensualidad.cliente + "<br>MEMBRESÍA: &nbsp;&nbsp;&nbsp;&nbsp;" + frmMensualidad.membresia + "<br></th></tr>";
            sLine = "<tr><td><pre>";
            sLine += "<h4>             <b>CLIENTE:</b>                  " + frmMensualidad.cliente + "</h4><br>";
            sLine += "<h4>           <b>MEMBRESÍA:</b>                  " + frmMensualidad.membresia + "</h4><br>";
            sLine += "<h4>       <b>FECHA DE PAGO:</b>                  " + frmMensualidad.fecPago + "</h4><br>";
            sLine += "<h4>     <b>FECHA DE INICIO:</b>                  " + frmMensualidad.fecIni + "</h4><br>";
            sLine += "<h4><b>FECHA DE VENCIMIENTO:</b>                  " + frmMensualidad.fecVen + "</h4><br><br>";
            sLine += "</pre></td></tr><tr><td><pre>";
            sLine += "<h4><b>               TOTAL:</b>                  $" + frmMensualidad.costo + "</h4><br>";
            sLine += "<h4><b>     TOTAL CON LETRA:</b>                  " + tls.ConvertFloatToString(float.Parse(frmMensualidad.costo)) + "</h4>";
            sLine += "</pre></td></tr>";
            //sLine += "<tr>";
            //sLine += "<th>MEMBRESÍA</th><td>" + frmMensualidad.membresia + "</td>";
            //sLine += "</tr>";
            //sLine += "<tr>";
            //sLine += "<th>FECHA DE PAGO</th><td>" + frmMensualidad.fecPago + "</td>";
            //sLine += "</tr>";
            //sLine += "<tr>";
            //sLine += "<th>FECHA DE INICIO</th><td>" + frmMensualidad.fecIni + "</td>";
            //sLine += "</tr>";
            //sLine += "<th>FECHA DE VENCIMIENTO</th><td>" + frmMensualidad.fecVen + "</td>";
            //sLine += "</tr>";
            objWriter.WriteLine(sLine);
            objWriter.WriteLine("</tbody></table></div></body></html>");
            objWriter.Close();
            Uri dir = new Uri(Directory.GetCurrentDirectory() + "\\comprobantepago.html");
            webBrowser1.Url = dir;
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }
    }
}
