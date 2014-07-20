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
    public partial class frmRptMedidaGen : Form
    {
        ConexionBD bd = new ConexionBD();
        Tools tls = new Tools();
        DateTime fecIni, fecFin;
        public frmRptMedidaGen()
        {
            InitializeComponent();
        }

        private void frmRptMedidaGen_Load(object sender, EventArgs e)
        {
            string cliente = "", edad="";
            fecIni = Convert.ToDateTime(frmRptMedida.fecha);
            fecFin = Convert.ToDateTime(frmRptMedida.fechaFi);
            string[] medidas = new string[8] { "PESO (kg)", "PECHO (cm)", "BRAZO (cm)", "CINTURA ALTA (cm)", "CINTURA MEDIA (cm)", "CINTURA BAJA (cm)", "CADERA (cm)", "PIERNA (cm)" };
            string[] inicial = new string[8];
            string[] final = new string[8];
            string[] avance = new string[8];
            try
            {
                bd.AbrirConexion();
                bd.BuscarClienteId(frmRptMedida.idCliente);
                bd.ResultadoConsulta();
                if (bd.ResultadoConsulta().Read())
                {
                    cliente = bd.ResultadoConsulta().GetString(0);
                    edad = bd.ResultadoConsulta().GetString(1);
                }
                bd.CerrarConexion();
                StreamWriter objWriter = new StreamWriter(@"c:\archivos\reportes\reportemedida.html");
                string sLine = "";
                objWriter.WriteLine("<!DOCTYPE html><html><head> <meta charset=\"utf-8\"/>" +
                "<script type=\"text/javascript\" src=\"js/jquery-1.11.1.min.js\"></script>" +
                "<link href=\"lib/tb/css/bootstrap.min.css\" rel=\"stylesheet\"> " +
                "</head><body><p class = \"text-right\">" + DateTime.Now.ToLongDateString() + "&nbsp;&nbsp;</p><br><br>" +
                "<p class = \"text-center lead\">COVARRUBIAS GYM</p><br>" +
                "<p class = \"text-center\">REPORTE DE MEDIDAS DE " + cliente + ".&nbsp;&nbsp;EDAD " + edad + "<br><br> DEL <b>" + frmRptMedida.fecha + "</b> AL <b>" + frmRptMedida.fechaFi + "</b> </p><br><br>");
                objWriter.WriteLine("<div class=\"table-responsive\"><table  class = \"table table-bordered table-hover\"><tbody>");
                sLine = "<tr><th class = \"text-center\">MEDIDA</th><th class = \"text-center\">ANTERIOR</th><th class = \"text-center\">ACTUAL</th><th class = \"text-center\">AVANCE</th></tr>";
                objWriter.WriteLine(sLine);
                bd.AbrirConexion();
                bd.ObtenerMedidasId(frmRptMedida.idCliente, tls.DMYToYMD(frmRptMedida.fecha));
                bd.ResultadoConsulta();
                if (bd.ResultadoConsulta().Read())
                {                 
                    for (int i = 0; i <8; i++)
                    {
                        inicial[i] = bd.ResultadoConsulta().GetString(i);
                    }

                }
                bd.CerrarConexion();
                bd.AbrirConexion();
                bd.ObtenerMedidasId(frmRptMedida.idCliente, tls.DMYToYMD(frmRptMedida.fechaFi));
                bd.ResultadoConsulta();
                if (bd.ResultadoConsulta().Read())
                {
                    for (int i = 0; i < 8; i++)
                    {
                        final[i] = bd.ResultadoConsulta().GetString(i);
                    }
                }
                bd.CerrarConexion();
                string feIn = Convert.ToString(fecIni.Year * 100 + fecIni.Month);
                string feFi = Convert.ToString(fecFin.Year * 100 + fecFin.Month);
                bd.AbrirConexion();
                bd.reporteMedida(feIn,feFi, frmRptMedida.idCliente);
                bd.ResultadoConsulta();
                if (bd.ResultadoConsulta().Read())
                {
                    for (int i = 0; i < 8; i++)
                    {
                        avance[i] = bd.ResultadoConsulta().GetString(i);
                    }
                }
                bd.CerrarConexion();
                for (int i = 0; i < 8; i++)
                {
                    sLine = "<tr><td class = \"text-center\">" + medidas[i] + "</td> ";
                    sLine = sLine + "<td class = \"text-center\">" + inicial[i] + "</td>";
                    sLine = sLine + "<td class = \"text-center\">" + final[i] + "</td>";
                    sLine = sLine + "<td class = \"text-center\">" + avance[i] + "</td>";
                    sLine = sLine + "</tr>";
                    objWriter.WriteLine(sLine);
                }

                objWriter.WriteLine("</tbody></table></div></body></html>");
                objWriter.Close();
                Uri dir = new Uri(@"c:\archivos\reportes\reportemedida.html");
                webBrowser1.Url = dir;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error!!");
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }
    }
}
