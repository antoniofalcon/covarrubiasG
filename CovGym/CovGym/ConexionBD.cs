 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CovGym
{
    class ConexionBD
    {
        public MySqlConnection cn;
        MySqlCommand com;
        MySqlDataReader lectorDatos;

        public ConexionBD()
        {
            cn = new MySqlConnection("Server=localhost; Database=bdgimnasio;Uid=root;Pwd=123;");
        }
        //
        //  CLIENTS
        //
        public void InsertCliente(string name, string address, string phone, string cePhone, string fecNac, string email, string fb, string clave, string photo)
        {
            com = new MySqlCommand("INSERT INTO clientes (cliente,direccion,telefono,celular,fecNac,email,facebook,clave,foto)" +
             "VALUES (@name,@address,@phone,@cePhone,@fecNac,@email,@fb,@clave,@photo)", cn);
            com.Parameters.Add("@name", name);
            com.Parameters.Add("@address", address);
            com.Parameters.Add("@phone", phone);
            com.Parameters.Add("@cePhone", cePhone);
            com.Parameters.Add("@fecNac", fecNac);
            com.Parameters.Add("@email", email);
            com.Parameters.Add("@fb", fb);
            com.Parameters.Add("@clave", clave);
            com.Parameters.Add("@photo", photo);
            com.ExecuteNonQuery();
        }
        public void DeleteCliente(string clave)
        {
            com = new MySqlCommand("DELETE FROM clientes WHERE clave = @clave", cn);
            com.Parameters.Add("@clave", clave);
            com.ExecuteNonQuery();
        }
        public void UpdateCliente(string name, string address, string phone, string cePhone, string fecNac, string email, string fb, string clave, string photo)
        {
            com = new MySqlCommand("UPDATE clientes SET cliente = @name, direccion = @address,telefono = @phone, celular = @cePhone," +
                "fecNac= @fecNac, email = @email, facebook = @fb, foto = @photo WHERE clave = @clave", cn);
            com.Parameters.Add("@name", name);
            com.Parameters.Add("@address", address);
            com.Parameters.Add("@phone", phone);
            com.Parameters.Add("@cePhone", cePhone);
            com.Parameters.Add("@fecNac", fecNac);
            com.Parameters.Add("@email", email);
            com.Parameters.Add("@fb", fb);
            com.Parameters.Add("@clave", clave);
            com.Parameters.Add("@photo", photo);
            com.ExecuteNonQuery();
        }

        public void ObtenerIdCliente()
        {
            com = new MySqlCommand("SELECT idCliente from clientes order by idCliente desc limit 1", cn);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();

        }
        public void BuscarClienteClave(string clave)
        {
            com = new MySqlCommand("SELECT clave, cliente from clientes where clave = @clave", cn);
            com.Parameters.Add("@clave", clave);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();

        }
        public void BuscarClienteId(string id)
        {
            com = new MySqlCommand("SELECT cliente from clientes where idCliente = @idCliente", cn);
            com.Parameters.Add("@idCliente", id);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();

        }


        public void BuscarClienteNombre(string cliente)
        {
            com = new MySqlCommand("SELECT clave, cliente from clientes where cliente like  @cliente order by clave", cn);
            com.Parameters.Add("@cliente", cliente);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();

        }
        public void ObtenerIdClienteMedida(string cliente)
        {
            com = new MySqlCommand("SELECT idCliente from clientes where cliente = @cliente order by clave", cn);
            com.Parameters.Add("@cliente", cliente);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();

        }
        public void BuscarCliente(string clave)
        {
            com = new MySqlCommand("SELECT * from clientes where clave = @clave", cn);
            com.Parameters.Add("@clave", clave);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();

        }

        //
        //  MEAUSURES
        //
        public void InsertMedida(string idCliente, string fecha, string peso, string talla, string pecho, string brazo, string cinAlta, string cinMedia, string cinBaja, string cadera, string pierna)
        {
            com = new MySqlCommand("INSERT INTO medidas VALUES (null,@idCliente,@fecha,@peso,@talla,@pecho,@brazo,@cinAlta,@cinMedia,@cinBaja,@cadera,@pierna)", cn);
            com.Parameters.Add("@idCliente", idCliente);
            com.Parameters.Add("@fecha", fecha);
            com.Parameters.Add("@peso", peso);
            com.Parameters.Add("@talla", talla);
            com.Parameters.Add("@pecho", pecho);
            com.Parameters.Add("@brazo", brazo);
            com.Parameters.Add("@cinAlta", cinAlta);
            com.Parameters.Add("@cinMedia", cinMedia);
            com.Parameters.Add("@cinBaja", cinBaja);
            com.Parameters.Add("@cadera", cadera);
            com.Parameters.Add("@pierna", pierna);
            com.ExecuteNonQuery();
        }
        public void UpdateMedida(string idCliente, string peso, string talla, string pecho, string brazo, string cinAlta, string cinMedia, string cinBaja, string cadera, string pierna, string idMedida)
        {
            com = new MySqlCommand("UPDATE medidas SET idCliente = @idCliente, peso = @peso, talla = @talla, pecho = @pecho,brazo = @brazo," +
            " cinAlta = @cinAlta,cinMedia = @cinMedia,cinBaja = @cinBaja,cadera = @cadera,pierna = @pierna WHERE idMedida = @idMedida", cn);
            com.Parameters.Add("@idCliente", idCliente);
            com.Parameters.Add("@idMedida", idMedida);
            //com.Parameters.Add("@fechaOld", fechaOld);
            com.Parameters.Add("@peso", peso);
            com.Parameters.Add("@talla", talla);
            com.Parameters.Add("@pecho", pecho);
            com.Parameters.Add("@brazo", brazo);
            com.Parameters.Add("@cinAlta", cinAlta);
            com.Parameters.Add("@cinMedia", cinMedia);
            com.Parameters.Add("@cinBaja", cinBaja);
            com.Parameters.Add("@cadera", cadera);
            com.Parameters.Add("@pierna", pierna);
            com.ExecuteNonQuery();
        }
        public void DeleteMedida(string idMedida)
        {
            com = new MySqlCommand("DELETE FROM medidas WHERE idMedida=@idMedida", cn);
            com.Parameters.Add("@idMedida", idMedida);
            com.ExecuteNonQuery();
        }

        public void ObtenerFechaMedida(string idCliente)
        {
            com = new MySqlCommand("SELECT fecha FROM medidas WHERE idCliente = @idCliente ORDER BY fecha", cn);
            com.Parameters.Add("@idCliente", idCliente);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        public void ObtenerFechaMedida(string idCliente,string fechaIn)
        {
            com = new MySqlCommand("SELECT fecha FROM medidas WHERE idCliente = @idCliente AND fecha > @fecha ORDER BY fecha", cn);
            com.Parameters.Add("@idCliente", idCliente);
            com.Parameters.Add("@fecha", fechaIn);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }

        public void BuscarFechaMedidaClave(string clave)
        {
            com = new MySqlCommand("SELECT clave,cliente,fecha FROM clientes JOIN(" +
                "SELECT idCliente,fecha FROM medidas" +
            ") AS t1 ON t1.idCliente = clientes.idCliente AND clave = @clave", cn);
            com.Parameters.Add("@clave", clave);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }

        public void BuscarFechaMedidaNombre(string cliente)
        {
            com = new MySqlCommand("SELECT clave,cliente,fecha FROM clientes JOIN(" +
               "SELECT idCliente,fecha FROM medidas" +
           ") AS t1 ON t1.idCliente = clientes.idCliente AND cliente like @cliente", cn);
            com.Parameters.Add("@cliente", cliente);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }

        public void ObtenerMedidas(string clave, string fec)
        {
            com = new MySqlCommand("SELECT * FROM medidas where idCliente in(SELECT idCliente FROM clientes WHERE clave =@clave) AND fecha = @fecha", cn);
            com.Parameters.Add("@clave", clave);
            com.Parameters.Add("@fecha", fec);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        public void ObtenerMedidasId(string idCliente, string fecha)
        {
            com = new MySqlCommand("SELECT peso,pecho,brazo,cinAlta,cinMedia,cinBaja,cadera,pierna FROM medidas where idCliente  = @idCliente AND fecha = @fecha", cn);
            com.Parameters.Add("@idCliente", idCliente);
            com.Parameters.Add("@fecha", fecha);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }

        //
        //  MEMBERSHIPS
        //
        public void InsertarMembresia(string membresia, string costo)
        {
            com = new MySqlCommand("INSERT INTO membresias VALUES (null,@membresia,@costo)", cn);
            com.Parameters.Add("@membresia", membresia);
            com.Parameters.Add("@costo", costo);
            com.ExecuteNonQuery();
        }
        public void UpdateMembresia(string membresia, string costo, string idMembresia)
        {
            com = new MySqlCommand("UPDATE membresias SET membresia = @membresia,monto = @costo WHERE idMembresia = @idMembresia", cn);
            com.Parameters.Add("@membresia", membresia);
            com.Parameters.Add("@idMembresia", idMembresia);
            com.Parameters.Add("@costo", costo);
            com.ExecuteNonQuery();
        }
        public void DeleteMembresia(string idMembresia)
        {
            com = new MySqlCommand("DELETE FROM membresias WHERE idMembresia = @idMembresia", cn);
            com.Parameters.Add("@idMembresia", idMembresia);
            com.ExecuteNonQuery();
        }
        public void buscarMembresia(string membresia)
        {
            com = new MySqlCommand("SELECT * FROM membresias WHERE membresia like @membresia", cn);
            com.Parameters.Add("@membresia", membresia);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        public void SelectMembresia()
        {
            com = new MySqlCommand("SELECT * FROM membresias", cn);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        public void SelectMembresia(string idMembresia,string nulo)
        {
            com = new MySqlCommand("SELECT * FROM membresias where idMembresia not in(@idMembresia)", cn);
            com.Parameters.Add("@idMembresia", idMembresia);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        public void SelectMembresia(string membresia)
        {
            com = new MySqlCommand("SELECT * FROM membresias WHERE membresia = @membresia", cn);
            com.Parameters.Add("@membresia", membresia);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        public void ObtenerMembresia(string idMembresia)
        {
            com = new MySqlCommand("SELECT membresia,monto FROM membresias WHERE idMembresia = @idMembresia", cn);
            com.Parameters.Add("@idMembresia", idMembresia);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }

        //
        //  Enter
        //

        public void InsertEntrada(string idCliente, string fecEntrada)
        {
            com = new MySqlCommand("INSERT INTO entradas(idCliente,fecEntrada,horaEntrada) values(@idCliente, @fecEntrada,CURTIME())", cn);
            com.Parameters.Add("@idCliente", idCliente);
            com.Parameters.Add("@fecEntrada", fecEntrada);
            com.ExecuteNonQuery();
        }
        public void SelectValidEnt(string idEntrada)
        {
            com = new MySqlCommand("SELECT * FROM entradas WHERE idEntrada = @idEntrada", cn);
            com.Parameters.Add("@idEntrada", idEntrada);
            lectorDatos = com.ExecuteReader();
        }
        public void ObtenerIdEntrada(string idCliente, string fecEntrada, string horaEntrada)
        {
            com = new MySqlCommand("SELECT idEntrada FROM entradas WHERE idCliente = @idCliente and fecEntrada = @fecEntrada and horaEntrada = @horaEntrada", cn);
            com.Parameters.Add("@idCliente", idCliente);
            com.Parameters.Add("@fecEntrada", fecEntrada);
            com.Parameters.Add("@horaEntrada", horaEntrada);
            lectorDatos = com.ExecuteReader();
        }

        public void BuscarEntradaNombre(string cliente)
        {
            com = new MySqlCommand("SELECT clave,cliente,fecEntrada,horaEntrada,resultado FROM clientes JOIN(" +
                                        "SELECT idCliente,fecEntrada,horaEntrada,resultado FROM entradas" +
                                   ") AS t1 ON t1.idCliente = clientes.idCliente AND" +
                                   " cliente LIKE @cliente" +
                                   " ORDER BY fecEntrada DESC", cn);
            com.Parameters.Add("@cliente", cliente);
            lectorDatos = com.ExecuteReader();
        }
        public void BuscarEntradaClave(string clave)
        {
            com = new MySqlCommand("SELECT clave,cliente,fecEntrada,horaEntrada,resultado FROM clientes JOIN(" +
                                       "SELECT idCliente,fecEntrada,horaEntrada,resultado FROM entradas" +
                                  ") AS t1 ON t1.idCliente = clientes.idCliente AND" +
                                  " clave = @clave" +
                                  " ORDER BY fecEntrada DESC", cn);
            com.Parameters.Add("@clave", clave);
            lectorDatos = com.ExecuteReader();
        }

        public void UltimoIdEntrada()
        {
            com = new MySqlCommand("Select idEntrada FROM entradas ORDER BY idEntrada desc limit 1", cn);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        public void DeleteEntrada(string idEntrada)
        {
            com = new MySqlCommand("DELETE FROM entradas WHERE idEntrada = @idEntrada", cn);
            com.Parameters.Add("@idEntrada", idEntrada);
            com.ExecuteNonQuery();
        }

        //
        // MONTHLY
        //
        public void InsertMensualidad(string idCliente, string idMembresia, string fecInicio, string fecFinal, string fecPago, string total)
        {
            com = new MySqlCommand("INSERT INTO mensualidades VALUES (null,@idCliente,@idMembresia,@fecInicio,@fecFinal,@fecPago,@total)", cn);
            com.Parameters.Add("@idCliente", idCliente);
            com.Parameters.Add("@idMembresia", idMembresia);
            com.Parameters.Add("@fecInicio", fecInicio);
            com.Parameters.Add("@fecFinal", fecFinal);
            com.Parameters.Add("@fecPago", fecPago);
            com.Parameters.Add("@total", total);
            com.ExecuteNonQuery();
        }

        public void DeleteMensualidad(string idMensualidad)
        {
            com = new MySqlCommand("DELETE FROM mensualidades WHERE idMensualidad = @idMensualidad", cn);
            com.Parameters.Add("@idMensualidad", idMensualidad);
            com.ExecuteNonQuery();
        }
        public void UpdateMensualidades(string idMensualidad, string idCliente, string idMembresia, string fecInicio, string fecFinal, string total)
        {
            com = new MySqlCommand("UPDATE mensualidades SET idCliente = @idCliente,idMembresia = @idMembresia, fecInicio = @fecInicio,fecFinal = @fecFinal, total = @total WHERE idMensualidad = @idMensualidad", cn);
            com.Parameters.Add("@idMensualidad", idMensualidad);
            com.Parameters.Add("@idCliente", idCliente);
            com.Parameters.Add("@idMembresia", idMembresia);
            com.Parameters.Add("@fecInicio", fecInicio);
            com.Parameters.Add("@fecFinal", fecFinal);
            com.Parameters.Add("@total", total);
            com.ExecuteNonQuery();
        }
        public void ObtenerMensualidad(string idCliente, string fecPago)
        {
            com = new MySqlCommand("SELECT * FROM mensualidades WHERE idCliente = @idCliente and fecPago = @fecPago", cn);
            com.Parameters.Add("@idCliente", idCliente);
            com.Parameters.Add("@fecPago", fecPago);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();

        }

        public void BuscarMensualidadNombre(string cliente, string year)
        {
            com = new MySqlCommand("SELECT clave,cliente,fecPago FROM clientes JOIN(" +
                                       " select idCliente,fecPago FROM mensualidades " +
                                       "WHERE year(fecPago) > @year - 1" +
                                   ") AS t1 ON t1.idCliente = clientes.idCliente AND" +
                                   " cliente LIKE @cliente" +
                                   " ORDER BY fecPago desc", cn);
            com.Parameters.Add("@cliente", cliente);
            com.Parameters.Add("@year", year);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        public void BuscarMensualidadClave(string clave, string year)
        {
            com = new MySqlCommand("SELECT clave,cliente,fecPago FROM clientes JOIN(" +
                                       " select idCliente,fecPago FROM mensualidades " +
                                       "WHERE year(fecPago) > @year - 1" +
                                   ") AS t1 ON t1.idCliente = clientes.idCliente AND" +
                                   " clave = @clave" +
                                   " ORDER BY fecPago desc", cn);
            com.Parameters.Add("@clave", clave);
            com.Parameters.Add("@year", year);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        //
        // USERS
        //
        public void ValidarUsuario(string cuenta, string paswd)
        {
            com = new MySqlCommand("SELECT nivel FROM usuarios WHERE cuenta = @cuenta AND paswd = MD5(@paswd)", cn);
            com.Parameters.Add("@cuenta", cuenta);
            com.Parameters.Add("@paswd", paswd);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();

        }
        public void InsertUsuario(string usuario, string cuenta, string paswd, int nivel)
        {
            com = new MySqlCommand("INSERT INTO usuarios VALUES(null,@usuario,@cuenta,MD5(@paswd),@nivel)", cn);
            com.Parameters.Add("@usuario", usuario);
            com.Parameters.Add("@cuenta", cuenta);
            com.Parameters.Add("@paswd", paswd);
            com.Parameters.Add("@nivel", nivel);
            com.ExecuteNonQuery();
        }

        public void BuscarUsuario(string usuario)
        {
            com = new MySqlCommand("SELECT usuario,cuenta,nivel FROM usuarios WHERE usuario LIKE @usuario ", cn);
            com.Parameters.Add("@usuario", usuario);
            com.ExecuteNonQuery(); 
            lectorDatos = com.ExecuteReader();
        }
        public void ObtenerUsuario(string usuario, string cuenta)
        {
            com = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario And cuenta = @cuenta", cn);
            com.Parameters.Add("@usuario", usuario);
            com.Parameters.Add("@cuenta", cuenta);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        public void DeleteUsuario(string idUsuario)
        {
            com = new MySqlCommand("DELETE FROM usuarios WHERE idUsuario = @idUsuario ", cn);
            com.Parameters.Add("@idUsuario", idUsuario);
            com.ExecuteNonQuery();
        }
        public void UpdateUsuario(string usuario, string cuenta, string paswd, int nivel, string idUsuario)
        {
            com = new MySqlCommand("UPDATE usuarios SET usuario = @usuario,cuenta = @cuenta, paswd = MD5(@paswd), nivel = @nivel WHERE idUsuario = @idUsuario", cn);
            com.Parameters.Add("@usuario", usuario);
            com.Parameters.Add("@cuenta", cuenta);
            com.Parameters.Add("@paswd", paswd);
            com.Parameters.Add("@nivel", nivel);
            com.Parameters.Add("@idUsuario", idUsuario);
            com.ExecuteNonQuery();
        }

        //
        //REPORTS
        //
        public void reporteVencido()
        {
            com = new MySqlCommand("SELECT clave,cliente,vencida FROM(" +
                                        "SELECT clave,cliente, vencida FROM clientes JOIN(" +
                                            "SELECT idCliente,fecFinal AS vencida FROM mensualidades " +
                                            "WHERE fecFinal > SUBDATE(CURDATE(),INTERVAL 3 MONTH)" +
                                            " ORDER BY idCliente,vencida DESC" +
                                        ") t1 ON clientes.idCliente = t1.idCliente" +
                                        " GROUP BY clientes.idCliente" +
                                    ") t2 WHERE vencida < CURDATE()" +
                                    " ORDER BY vencida DESC", cn);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }

        public void reporteGanancia()
        {
            com = new MySqlCommand("SELECT membresia, subtotal FROM membresias JOIN(" +
                                        "SELECT idMembresia, sum(total) subtotal FROM mensualidades " +
                                        "WHERE YEAR(fecPago) * 100 + MONTH(fecPago) = year(CURDATE()) * 100 + month(CURDATE()) " +
                                        "GROUP BY idMembresia" +
                                    ") t1 ON membresias.idMembresia = t1.idMembresia " +
                                    "ORDER BY membresia", cn);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }

        public void reporteMedida(string fecInicio, string fecFinal,string idCliente)
        {
            com = new MySqlCommand("SELECT t1.pesoAct-t2.pesoAnt as peso, t1.pechoAct - t2.pechoAnt as pecho," +
                                    "t1.brazoAct - t2.brazoAnt as brazo, t1.cinAltaAct - t2.cinAltaAnt as cinAlta, "+
                                    "t1.cinMediaAct - t2.cinMediaAnt as cinMedia, t1.cinBajaAct - t2.cinBajaAnt as cinBaja,"+
                                    "t1.caderaAct - t2.caderaAnt as cadera, t1.piernaAct - t2.piernaAnt as pierna FROM("+
                                    " SELECT idCliente,peso as pesoAct,pecho as pechoAct,brazo as brazoAct,"+
                                    " cinAlta as cinAltaAct,cinMedia as cinMediaAct, cinBaja as cinBajaAct, "+
                                    " cadera as caderaAct, pierna as piernaAct from medidas "+
                                    " WHERE year(fecha) * 100 + month(fecha) = @fecFinal and idCliente = @idCliente"+
                                    ") t1 JOIN("+
                                    " SELECT idCliente,peso as pesoAnt,pecho as pechoAnt,brazo as brazoAnt,"+
                                    " cinAlta as cinAltaAnt,cinMedia as cinMediaAnt, cinBaja as cinBajaAnt,"+
                                    " cadera as caderaAnt, pierna as piernaAnt from medidas "+
                                    " WHERE year(fecha) * 100 + month(fecha) = @fecInicio and idCliente =@idCliente"+
                                    ") t2 on t1.idCliente = t2.idCliente", cn);
            com.Parameters.Add("@fecInicio", fecInicio);
            com.Parameters.Add("@fecFinal", fecFinal);
            com.Parameters.Add("@idCliente", idCliente);
            com.ExecuteNonQuery();
            lectorDatos = com.ExecuteReader();
        }
        //
        //
        //Reader
        public MySqlDataReader ResultadoConsulta()
        {
            return lectorDatos;
        }

        //TOOLS
        public bool AbrirConexion()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
            return true;
        }

        public bool CerrarConexion()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            return true;
        }
    }
}
