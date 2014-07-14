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
    public partial class frmBuscar : Form
    {
        ConexionBD bd = new ConexionBD();
        Tools tls = new Tools();
        public static string code,fecha,name,membr,hora,result,idEntrada,usuario,cuenta;
        public static bool ver = false, verMed = false, verMensual = false, verMembre = false,verUsu = false;
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbForma.Text = "Nombre:";
            txtForma.Clear();
            txtForma.Focus();
            //txtForma.Size = new System.Drawing.Size(316, 27);
           // lbForma.Location = new System.Drawing.Point(12, 77);
            //txtForma.Location = new System.Drawing.Point(112, 77);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbForma.Text = "Código:";
            txtForma.Clear();
            txtForma.Focus();
            //txtForma.Size = new System.Drawing.Size(116, 27);
           // this.lbForma.Location = new System.Drawing.Point(124, 77);
           // txtForma.Location = new System.Drawing.Point(205, 77);
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(frmInicio.direccion);
            BackgroundImageLayout = ImageLayout.Stretch;
            btnVer.BackgroundImage = Image.FromFile(frmInicio.bVer);
            btnVer.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.BackgroundImage = Image.FromFile(frmInicio.bCan);
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnModificar.BackgroundImage = Image.FromFile(frmInicio.bMod);
            btnModificar.BackgroundImageLayout = ImageLayout.Stretch;

            txtForma.Focus();
            if(frmInicio.busqueda =="entrada")
            {
                clmHora.Width = 110;
                clmResultado.Width = 100;
                clmCode.Width = 72;
                clmName.Width = 260;
                clmFecha.Width = 110;
                btnModificar.Text = "Eliminar";
            }
            else
            {
                clmHora.Width = 0;
                clmResultado.Width = 0;
            }
            if (frmInicio.busqueda == "cliente")
            {
                lbTituloBus.Text = "Buscar Clientes";
                rbCodigo.Visible = true;
                rbName.Visible = true;
                clmCode.Text = "Código";
                clmName.Text = "Nombre";
                clmCode.Width = 82;
                clmName.Width = 380;
                clmFecha.Width = 0;
            }          
            else if (frmInicio.busqueda == "mensual")
            {
                clmCode.Text = "Código";
                clmName.Text = "Cliente";
                clmFecha.Text = "Fecha de Pago";
                clmCode.Width = 72;
                clmName.Width = 261;
                clmFecha.Width = 130;
                rbCodigo.Visible = true;
                rbName.Visible = true;
                
            }
            else if (frmInicio.busqueda == "entrada")
            {
                clmCode.Text = "Código";
                clmName.Text = "Cliente";
                clmFecha.Text = "Fecha";
                lbTituloBus.Text = "    Buscar Entradas";
                rbCodigo.Visible = true;
                rbName.Visible = true;

                btnVer.Enabled = false;
            } 
            else if(frmInicio.busqueda == "membresia")
            {
                lbForma.Text = "Membresía:";
                lbTituloBus.Text = "    Buscar Membresías";
                rbCodigo.Visible = false;
                rbName.Visible = false;
                txtForma.Location = new System.Drawing.Point(140, 128);
                clmCode.Text = "Membresía";
                clmName.Text = "Costo";
                clmCode.Width = 360;
                clmName.Width = 102;
                clmFecha.Width = 0;
                
            }
            else if (frmInicio.busqueda == "usuario")
            {
                clmCode.Text = "Usuario";
                clmName.Text = "Cuenta";
                clmFecha.Text = "Nivel";
                clmCode.Width =210;
                clmName.Width = 140;
                clmFecha.Width = 140;
                rbCodigo.Visible = false;
                rbName.Visible = false;
                lbTituloBus.Text = "    Buscar Usuarios";
                lbForma.Text = " Cuenta:";
            }
            else if (frmInicio.busqueda == "medida")
            {
                clmFecha.Text = "Fecha";
                clmCode.Text = "Código";
                clmName.Text = "Nombre";
                clmCode.Width = 80;
                clmName.Width = 270;
                clmFecha.Width = 108;
                lbTituloBus.Text = "    Buscar Medidas";
                rbCodigo.Visible = true;
                rbName.Visible = true;
            }   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if ((rbName.Checked && !tls.ValidText(txtForma.Text)) || (rbCodigo.Checked && !tls.ValidCode(txtForma.Text)) ||(!rbCodigo.Visible && !tls.ValidText(txtForma.Text)))
            {
                MessageBox.Show("Datos inválidos");
                txtForma.Clear();
                txtForma.Focus();
                return;
            }

            //
            //ONLY FOR CLIENTS
            //
            if (frmInicio.busqueda == "cliente")
            {
                try
                {
                    if (rbCodigo.Checked == true)
                    {
                        lvBuscar.Items.Clear();
                        bd.AbrirConexion();
                        bd.BuscarClienteClave(txtForma.Text);
                        if (bd.ResultadoConsulta().Read())
                        {
                            lvBuscar.Items.Add(bd.ResultadoConsulta().GetValue(0).ToString()).SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                        }
                        bd.CerrarConexion();
                    }
                    else if (rbName.Checked == true)
                    {
                        string dato = "%" + txtForma.Text + "%";
                        lvBuscar.Items.Clear();
                        bd.AbrirConexion();
                        bd.BuscarClienteNombre(dato);
                        while (bd.ResultadoConsulta().Read())
                        {
                            lvBuscar.Items.Add(bd.ResultadoConsulta().GetValue(0).ToString()).SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                        }
                        bd.CerrarConexion();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar buscar");
                }
            }
            //
            //ONLY FOR MEAUSURES
            //
            if (frmInicio.busqueda == "medida")
            {
                try
                {
                    ListViewItem item1;
                    string fecha;
                    if (rbCodigo.Checked == true)
                    {
                        lvBuscar.Items.Clear();
                        bd.AbrirConexion();
                        bd.BuscarFechaMedidaClave(txtForma.Text);
                        bd.ResultadoConsulta();
                        while (bd.ResultadoConsulta().Read())
                        {
                            item1 = new ListViewItem(bd.ResultadoConsulta().GetValue(0).ToString(), 0);
                            item1.SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                            fecha = bd.ResultadoConsulta().GetValue(2).ToString();
                            tls.QuitarHora(fecha);
                            fecha = tls.DMYToYMD(tls.fecha);
                            item1.SubItems.Add(fecha);
                            lvBuscar.Items.AddRange(new ListViewItem[] { item1 });
                        }
                        bd.CerrarConexion();
                    }
                    else if (rbName.Checked == true)
                    {
                        string dato = "%" + txtForma.Text + "%";
                        lvBuscar.Items.Clear();
                        bd.AbrirConexion();
                        bd.BuscarFechaMedidaNombre(dato);
                        bd.ResultadoConsulta();
                        while (bd.ResultadoConsulta().Read())
                        {
                            item1 = new ListViewItem(bd.ResultadoConsulta().GetValue(0).ToString(), 0);
                            item1.SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                            fecha = bd.ResultadoConsulta().GetValue(2).ToString();
                            tls.QuitarHora(fecha);
                            fecha = tls.DMYToYMD(tls.fecha);
                            item1.SubItems.Add(fecha);
                            lvBuscar.Items.AddRange(new ListViewItem[] { item1 });
                            //lvBuscar.Items.Add(bd.ResultadoConsulta().GetValue(0).ToString()).SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());

                        }
                        bd.CerrarConexion();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar buscar");
                }
            }
            //
            //ONLY FOR MEMBERSHIPS
            //

            if (frmInicio.busqueda == "membresia")
            {
                try
                {
                    ListViewItem item1;
                    string dato = "%" + txtForma.Text + "%";
                    lvBuscar.Items.Clear();
                    bd.AbrirConexion();
                    bd.buscarMembresia(dato);
                    while (bd.ResultadoConsulta().Read())
                    {
                        item1 = new ListViewItem(bd.ResultadoConsulta().GetValue(1).ToString(), 0);
                        item1.SubItems.Add(bd.ResultadoConsulta().GetValue(2).ToString());
                        lvBuscar.Items.AddRange(new ListViewItem[] { item1 });
                    }
                    bd.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar buscar");
                }
            }
            //
            //ONLY FOR ENTER
            //

            if (frmInicio.busqueda == "entrada")
            {
                try
                {
                    ListViewItem item1;
                    string fecha;
                    if (rbCodigo.Checked == true)
                    {
                        lvBuscar.Items.Clear();
                        bd.AbrirConexion();
                        bd.BuscarEntradaClave(txtForma.Text);
                        bd.ResultadoConsulta();
                        while (bd.ResultadoConsulta().Read())
                        {
                            item1 = new ListViewItem(bd.ResultadoConsulta().GetValue(0).ToString(), 0);
                            item1.SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                            fecha = bd.ResultadoConsulta().GetValue(2).ToString();
                            tls.QuitarHora(fecha);
                            fecha = tls.DMYToYMD(tls.fecha);
                            item1.SubItems.Add(fecha);
                            item1.SubItems.Add(bd.ResultadoConsulta().GetValue(3).ToString());
                            item1.SubItems.Add(bd.ResultadoConsulta().GetValue(4).ToString());
                            lvBuscar.Items.AddRange(new ListViewItem[] { item1 });
                        }
                        bd.CerrarConexion();
                    }
                    else if (rbName.Checked == true)
                    {
                        string dato = "%" + txtForma.Text + "%";
                        lvBuscar.Items.Clear();
                        bd.AbrirConexion();
                        bd.BuscarEntradaNombre(dato);
                        bd.ResultadoConsulta();
                        while (bd.ResultadoConsulta().Read())
                        {
                            item1 = new ListViewItem(bd.ResultadoConsulta().GetValue(0).ToString(), 0);
                            item1.SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                            fecha = bd.ResultadoConsulta().GetValue(2).ToString();
                            tls.QuitarHora(fecha);
                            fecha = tls.DMYToYMD(tls.fecha);
                            item1.SubItems.Add(fecha);
                            item1.SubItems.Add(bd.ResultadoConsulta().GetValue(3).ToString());
                            if (bd.ResultadoConsulta().GetValue(4).ToString() == "V")
                            {
                                item1.SubItems.Add("Válido");
                            }
                            else
                            {
                                item1.SubItems.Add("Inválido");
                            }
                            lvBuscar.Items.AddRange(new ListViewItem[] { item1 });
                        }
                        bd.CerrarConexion();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar buscar" + ex.Message);
                }
            }
            //
            //ONLY FOR MONTHLY
            //
            if (frmInicio.busqueda == "mensual")
            {
                try
                {
                    ListViewItem item1;
                    string fecIni;
                    string fecVen;
                    string fecPago;
                    if (rbCodigo.Checked == true)
                    {
                        lvBuscar.Items.Clear();
                        bd.AbrirConexion();
                        bd.BuscarMensualidadClave(txtForma.Text,DateTime.Now.Year.ToString());
                        bd.ResultadoConsulta();
                        while (bd.ResultadoConsulta().Read())
                        {
                            item1 = new ListViewItem(bd.ResultadoConsulta().GetValue(0).ToString(), 0);
                            item1.SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                            fecha = bd.ResultadoConsulta().GetValue(2).ToString();
                            tls.QuitarHora(fecha);
                            fecha = tls.DMYToYMD(tls.fecha);
                            item1.SubItems.Add(fecha);
                            lvBuscar.Items.AddRange(new ListViewItem[] { item1 });
                        }
                        bd.CerrarConexion();
                    }
                    else if (rbName.Checked == true)
                    {
                        string dato = "%" + txtForma.Text + "%";
                        lvBuscar.Items.Clear();
                        bd.AbrirConexion();
                        bd.BuscarMensualidadNombre(dato, DateTime.Now.Year.ToString());
                        bd.ResultadoConsulta();
                        while (bd.ResultadoConsulta().Read())
                        {
                            item1 = new ListViewItem(bd.ResultadoConsulta().GetValue(0).ToString(), 0);
                            item1.SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                            fecha = bd.ResultadoConsulta().GetValue(2).ToString();
                            tls.QuitarHora(fecha);
                            fecha = tls.DMYToYMD(tls.fecha);
                            item1.SubItems.Add(fecha);
                            lvBuscar.Items.AddRange(new ListViewItem[] { item1 });
                            //lvBuscar.Items.Add(bd.ResultadoConsulta().GetValue(0).ToString()).SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());

                        }
                        bd.CerrarConexion();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar buscar");
                }
            }
             //
            //ONLY FOR USERS
            //
            if (frmInicio.busqueda == "usuario")
            {
                try
                {
                    ListViewItem item1;
                    string dato = "%" + txtForma.Text + "%";
                    string niv;
                    lvBuscar.Items.Clear();
                    bd.AbrirConexion();
                    bd.BuscarUsuario(dato);
                    while (bd.ResultadoConsulta().Read())
                    {
                        item1 = new ListViewItem(bd.ResultadoConsulta().GetValue(0).ToString(), 0);
                        item1.SubItems.Add(bd.ResultadoConsulta().GetValue(1).ToString());
                        if (bd.ResultadoConsulta().GetValue(2).ToString() == "1")
                        {
                            niv = "ADMINISTRADOR";
                        }
                        else
                        {
                            niv = "NORMAL";
                        }
                        item1.SubItems.Add(niv);
                        lvBuscar.Items.AddRange(new ListViewItem[] { item1 });
                    }
                    bd.CerrarConexion();
                }
                catch (Exception ex)
                {
                    
                     MessageBox.Show("Error al intentar buscar" + ex);
                }
            }

            //Finish
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "cliente")
            {
                ver = false;
                code = lvBuscar.SelectedItems[0].Text;
                frmClientes cli = new frmClientes();
                cli.lbCliente.Text = "Modificación de Clientes";
                cli.Show();
                this.Close();
            }
            else if (frmInicio.busqueda == "cliente")
            {
                MessageBox.Show("Seleccione un cliente");
            }
            //
            //MEAUSURES
            //
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "medida")
            {
                verMed = false;
                code = lvBuscar.SelectedItems[0].Text;
                fecha = lvBuscar.SelectedItems[0].SubItems[2].Text;
                frmMedicion med = new frmMedicion();
                med.lbMedida.Text = "Modificación de Medidas";
                med.Show();
                this.Close();
            }
            else if (frmInicio.busqueda == "medida")
            {
                MessageBox.Show("Seleccione una fecha");
            }
            //
            //MEMBERSHIPS
            //
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "membresia")
            {
                verMembre = false;
                membr = lvBuscar.SelectedItems[0].Text;
                frmMembresia memb = new frmMembresia();
                memb.lbMemb.Text = "Modificación de Membresía";
                memb.Show();
                this.Close();
            }
            else if (frmInicio.busqueda == "membresia")
            {
                MessageBox.Show("Seleccione una membresía");
            }
            //
            //ENTER
            //
            else if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "entrada" && btnModificar.Text=="Eliminar")
            {
                try
                {
                    bd.AbrirConexion();
                    bd.DeleteEntrada(idEntrada);
                    bd.CerrarConexion();
                    MessageBox.Show("Entrada eliminada correctamente");
                    lvBuscar.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar entrada");
                }
            }
            else if (frmInicio.busqueda == "entrada")
            {
                MessageBox.Show("Seleccione una membresía");
            }
            //
            //MONTHLY
            //
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "mensual")
            {
                verMensual = false;
                code = lvBuscar.SelectedItems[0].Text;
                name = lvBuscar.SelectedItems[0].SubItems[1].Text;
                fecha = lvBuscar.SelectedItems[0].SubItems[2].Text;
                frmMensualidad mens = new frmMensualidad();
                mens.lbMensualidad.Text = "Modificación de Mensualidades";
                mens.Show();
                this.Close();
            }
            else if (frmInicio.busqueda == "mensual")
            {
                MessageBox.Show("Seleccione una fecha");
            }
            //
            //USERS
            //
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "usuario")
            {
                verUsu = false;
                usuario = lvBuscar.SelectedItems[0].Text;
                cuenta = lvBuscar.SelectedItems[0].SubItems[1].Text;
                frmUsuarios usu = new frmUsuarios();
                usu.lbUsuario.Text = "Modificación de Usuario";
                usu.Show();
                this.Close();
            }
            else if (frmInicio.busqueda == "usuario")
            {
                MessageBox.Show("Seleccione un usuario");
            }

            //FINISH
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //
            //CLIENTS
            //
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda =="cliente")
            {
                ver = true;
                code = lvBuscar.SelectedItems[0].Text;
                frmClientes cli = new frmClientes();
                cli.lbCliente.Text = "Eliminación de Clientes";
                cli.Show();
                this.Close();
            }
            else if(frmInicio.busqueda =="cliente")
            {
                MessageBox.Show("Seleccione un cliente");
            }
            //
            //MEAUSURES
            //
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "medida")
            {
                verMed = true;
                code = lvBuscar.SelectedItems[0].Text;
                name = lvBuscar.SelectedItems[0].SubItems[1].Text;
                fecha = lvBuscar.SelectedItems[0].SubItems[2].Text;
                frmMedicion med = new frmMedicion();
                med.lbMedida.Text = "Eliminación de Medidas";
                med.Show();
                this.Close();
            }
            else if (frmInicio.busqueda == "medida")
            {
                MessageBox.Show("Seleccione una fecha");
            }
            //
            //MEMBERSHIPS
            //
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "membresia")
            {
                verMembre = true;
                membr = lvBuscar.SelectedItems[0].Text;
                frmMembresia memb = new frmMembresia();
                memb.lbMemb.Text = "Eliminación de Membresía";
                memb.Show();
                this.Close();
            }
            else if (frmInicio.busqueda == "membresia")
            {
                MessageBox.Show("Seleccione una membresía");
            }
            //
            //MONTHLY
            //
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "mensual")
            {
                verMensual = true;
                code = lvBuscar.SelectedItems[0].Text;
                name = lvBuscar.SelectedItems[0].SubItems[1].Text;
                fecha = lvBuscar.SelectedItems[0].SubItems[2].Text;
                frmMensualidad mens = new frmMensualidad();
                mens.lbMensualidad.Text = "Eliminación de Mensualidades";
                mens.Show();
                this.Close();
            }
            else if (frmInicio.busqueda == "mensual")
            {
                MessageBox.Show("Seleccione una fecha");
            }
            //
            //USERS
            //
            if (lvBuscar.SelectedItems.Count == 1 && frmInicio.busqueda == "usuario")
            {
                verUsu = true;
                usuario = lvBuscar.SelectedItems[0].Text;
                cuenta = lvBuscar.SelectedItems[0].SubItems[1].Text;
                frmUsuarios usu = new frmUsuarios();
                usu.lbUsuario.Text = "Eliminación de Usuario";
                usu.Show();
                this.Close();
            }
            else if (frmInicio.busqueda == "usuario")
            {
                MessageBox.Show("Seleccione un usuario");
            }

            //
            //FINISH
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmInicio.busqueda == "entrada")
            {
                string id="";
                try
                {
                    bd.AbrirConexion();
                    bd.BuscarClienteClave(lvBuscar.SelectedItems[0].Text);
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        id = bd.ResultadoConsulta().GetValue(0).ToString();
                    }
                    bd.CerrarConexion();
                    bd.AbrirConexion();
                    bd.ObtenerIdEntrada(id, lvBuscar.SelectedItems[0].SubItems[2].Text, lvBuscar.SelectedItems[0].SubItems[3].Text);
                    bd.ResultadoConsulta();
                    if (bd.ResultadoConsulta().Read())
                    {
                        idEntrada = bd.ResultadoConsulta().GetValue(0).ToString();
                    }
                    bd.CerrarConexion();
                }
                catch(Exception ex)
                {
                    //MessageBox.Show("Error al seleccionar fecha "+ex.Message);
                }
            }
        }

       
    }
}
