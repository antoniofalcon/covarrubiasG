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
    public partial class frmRptGanancia : Form
    {
        ConexionBD bd = new ConexionBD();
        Tools tls = new Tools();
        string membresia, fecha;
        decimal subtotal =0, total = 0;
        public frmRptGanancia()
        {
            UseWaitCursor = true;
            InitializeComponent();
            UseWaitCursor = false;
        }

        private void frmRptGanancia_Load_1(object sender, EventArgs e)
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1: fecha = "ENERO";
                    break;
                case 2: fecha = "FEBRERO";
                    break;
                case 3: fecha = "MARZO";
                    break;
                case 4: fecha = "ABRIL";
                    break;
                case 5: fecha = "MAYO";
                    break;
                case 6: fecha = "JUNIO";
                    break;
                case 7: fecha = "JULIO";
                    break;
                case 8: fecha = "AGOSTO";
                    break;
                case 9: fecha = "SEPTIEMBRE";
                    break;
                case 10: fecha = "OCTUBRE";
                    break;
                case 11: fecha = "NOVIEMBRE";
                    break;
                case 12: fecha = "DICIEMBRE";
                    break;
            }
            bd.AbrirConexion();
            bd.reporteGanancia();
            bd.ResultadoConsulta();
            StreamWriter objWriter = new StreamWriter("mensualidadganancia.html");
            string sLine = "";
            objWriter.WriteLine("<!DOCTYPE html><html><head> <meta charset=\"utf-8\"/>" +
            "<script type=\"text/javascript\" src=\"js/jquery-1.11.1.min.js\"></script>" +
            "<link href=\"lib/tb/css/bootstrap.min.css\" rel=\"stylesheet\"> " +
            "</head><body><p class = \"text-right\">" + DateTime.Now.ToLongDateString() + "&nbsp;&nbsp;</p><br><br>" +
            "<p class = \"text-center lead\">COVARRUBIAS GYM</p><br>" +
            "<p class = \"text-center\">REPORTE DE INGRESOS DEL MES DE "+ fecha +" </p><br><br>");
            objWriter.WriteLine("<div class=\"table-responsive\"><table  class = \"table table-bordered table-hover\"><tbody>");
            sLine = "<tr><th class = \"text-center\">MEMBRESÍA</th><th class = \"text-center\">TOTAL</th></tr>";
            objWriter.WriteLine(sLine);
            while (bd.ResultadoConsulta().Read())
            {
                membresia = bd.ResultadoConsulta().GetString(0);
                subtotal = decimal.Parse(bd.ResultadoConsulta().GetString(1));
                total = total + subtotal;
                sLine = "<tr><td class = \"text-center\">";
                sLine = sLine + membresia + "</td><td class = \"text-right\">";
                sLine = sLine + subtotal + "</td></tr>";
                objWriter.WriteLine(sLine);
            }
            bd.CerrarConexion();
            objWriter.WriteLine("<tr><th colspan = 2 class = \"text-right\">" + total + "</th></tr></tbody></table></div></body></html>");
            objWriter.Close();
            Uri dir = new Uri(Directory.GetCurrentDirectory() + "\\mensualidadganancia.html");
            webBrowser1.Url = dir;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }


       

        
    }
}
