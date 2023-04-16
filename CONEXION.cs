using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace tepatuuri_soft
{
    public static class CONEXION
    {
       static SqlConnection cnx;

       public static List<CONEXION.productos> envio{get; set;}
       public static CONEXION.pedidos pedidoenvio { get;set; }
         static CONEXION()
        {
            try {
            //cnx = new SqlConnection("server=DESKTOP-OAS86ED/SQLEXPRESS; database=TEPANTURI;Integrated security=true");
           // string connectionString = @"Data Source=(DESKTOP-OAS86ED/SQLEXPRESS);Initial Catalog=TEPANTURI;Integrated Security=True;";
            cnx = new SqlConnection("Data Source=DESKTOP-OAS86ED\\SQLEXPRESS;Initial Catalog=TEPANTURI;Integrated Security=True");

            cnx.Open();
            cnx.Close();
            envio = new List<productos>();

            }
            catch (Exception e)
            {
                
            }
        }
         public static List<string> getCalendar(DateTime Fecha)
        {
            List<string> calendar = new List<string>();
            try
            {
                cnx.Open();
                SqlParameter p1 = new SqlParameter("fecha", Fecha);
                SqlCommand getcalendar = new SqlCommand("Exec SpMostrarMes @Hoy=@fecha", cnx);
                getcalendar.Parameters.Add(p1);
                SqlDataReader info = getcalendar.ExecuteReader();
                while (info.Read())
                {
                    calendar.Add(info[1].ToString());
                }
                return calendar;
            }
            catch (Exception)
            {
                return new List<string>();
            }
            finally { cnx.Close();}
        }
        // info.GetName
         public static DataTable Listar(byte consulta, string buscar)
         {
             DataTable tab = new DataTable("Tabla");
             try
             {
                 cnx.Open();
                 SqlParameter p1 = new SqlParameter("buscar", buscar);
                 SqlParameter p2 = new SqlParameter("tabla", consulta);
                 SqlCommand listar = new SqlCommand("EXEC SpConsultas @Accion =@tabla, @parametro=@buscar", cnx);
                 listar.Parameters.Add(p1);
                 listar.Parameters.Add(p2);
                 SqlDataReader info = listar.ExecuteReader();
                 DataColumn[] col = new DataColumn[info.FieldCount];
                 for (int i = 0; i < info.FieldCount; i++)
                 {
                     col[i] = new DataColumn(info.GetName(i), System.Type.GetType("System.String"));
                 }
                 tab.Columns.AddRange(col);
                 while (info.Read())
                 {
                     DataRow row = tab.NewRow();
                     for (int i = 0; i < info.FieldCount; i++)
                     {
                         row[i] = info[i].ToString();
                     }
                     tab.Rows.Add(row);
                 }
                 return tab;
             }
             catch (Exception)
             {
                 throw;
             }
             finally { cnx.Close(); }
         }

         public static List<CONEXION.pedidos> Listpedidoxcliente(int idcliente)
         {
             try
             {
                 cnx.Open();
                // List<CONEXION.pedidos> realpedclientes = new List<pedidos>();
                 List<CONEXION.pedidos> pedclientes = new List<pedidos>();
                 SqlParameter p1 = new SqlParameter("idcliente", idcliente);
                 string com = "Select * from VisPedido where idcliente = @idcliente";
                 SqlCommand comand = new SqlCommand(com, cnx);
                 comand.Parameters.Add(p1);
                 SqlDataReader info = comand.ExecuteReader();
                 while (info.Read())
                 {
                     CONEXION.pedidos ped1 = new CONEXION.pedidos();
                     ped1.idpedido = Convert.ToInt32(info[0]);
                     ped1.idcliente = Convert.ToInt32(info[1]);
                     ped1.nombrecliente = info[2].ToString();
                     ped1.fecha = Convert.ToDateTime(info[3]);
                     ped1.nota = info[4].ToString();
                     ped1.total = Convert.ToDouble(info[5]);
                     ped1.direccion = info[6].ToString();
                     ped1.estado = Convert.ToBoolean(info[7]);
                     ped1.listaproductos = new List<productos>();
                     pedclientes.Add(ped1);
                 }
                 info.Close();
                 foreach (var item in pedclientes)
                 {
                     SqlParameter p2 = new SqlParameter("idpedido", item.idpedido);
                     com = "select * from VisProdPed where idpedido = @idpedido";
                     SqlCommand comando = new SqlCommand(com, cnx);
                     comando.Parameters.Add(p2);
                     SqlDataReader info2 = comando.ExecuteReader();

                     while (info2.Read())
                     {
                         CONEXION.productos px = new CONEXION.productos();
                         px.idproducto = Convert.ToInt32(info2[2]);
                         px.nombre = info2[3].ToString();
                         px.contenido = info2[4].ToString();
                         px.precio = Convert.ToInt32(info2[5]);
                         px.cantidad = Convert.ToInt32(info2[6]);
                         item.listaproductos.Add(px);
                     }
                     info2.Close();
                 }
                    
                 return pedclientes;
             }
             catch (Exception)
             {

                 throw;
             }
             finally { cnx.Close(); }
             
         }

         public static void cliente(byte accion, int id, string nombre, string direccion, string ciudad, string telefono)
         {
             try
             {
                 cnx.Open();
                 SqlParameter p1 = new SqlParameter("accion", accion);
                 SqlParameter p2 = new SqlParameter("id", id);
                 SqlParameter p3 = new SqlParameter("nombre", nombre);
                 SqlParameter p4 = new SqlParameter("direccion", direccion);
                 SqlParameter p5 = new SqlParameter("ciudad", ciudad);
                 SqlParameter p6 = new SqlParameter("telefono", telefono);
                 string comando = "Exec SpCliente @ACCION = @accion, @IdCliente=@id, @Nombre = @nombre, @Direccion=@direccion, @Ciudad =@ciudad, @Telefono=@telefono";
                 SqlCommand client = new SqlCommand(comando,cnx);
                 client.Parameters.Add(p1);
                 client.Parameters.Add(p2);
                 client.Parameters.Add(p3);
                 client.Parameters.Add(p4);
                 client.Parameters.Add(p5);
                 client.Parameters.Add(p6);
                 client.ExecuteNonQuery();

             }
             catch (Exception)
             {
                 throw;
             }
             finally
             { cnx.Close(); }
         
         }
         public static void proveedor(byte accion, int id, string nombre, string direccion, string telefono)
         {
             try
             {
                 cnx.Open();
                 SqlParameter p1 = new SqlParameter("accion", accion);
                 SqlParameter p2 = new SqlParameter("id", id);
                 SqlParameter p3 = new SqlParameter("nombre", nombre);
                 SqlParameter p4 = new SqlParameter("telefono", telefono);
                 SqlParameter p5 = new SqlParameter("direccion", direccion);
                 string comando = "EXEC SpProveedor @Accion =@accion, @IdProveedor=@id, @Nombre=@nombre,@telefono=@telefono,@direccion=@direccion";
                 SqlCommand prod = new SqlCommand(comando, cnx);
                 prod.Parameters.Add(p1);
                 prod.Parameters.Add(p2);
                 prod.Parameters.Add(p3);
                 prod.Parameters.Add(p4);
                 prod.Parameters.Add(p5);
                 prod.ExecuteNonQuery();

             }
             catch (Exception)
             {
                 throw;
             }
             finally
             { cnx.Close(); }

         }

         public static void producto(byte accion, int id,string nombre, int idprov,string categoria,string descripcion, string contenido, double precio)
         {
             try
             {
                 cnx.Open();
                 SqlParameter p1 = new SqlParameter("accion", accion);
                 SqlParameter p2 = new SqlParameter("id", id);
                 SqlParameter p3 = new SqlParameter("nombre", nombre);
                 SqlParameter p4 = new SqlParameter("idProv", idprov);
                 SqlParameter p5 = new SqlParameter("categoria", categoria);
                 SqlParameter p6 = new SqlParameter("descripcion", descripcion);
                 SqlParameter p7 = new SqlParameter("contenido", contenido);
                 SqlParameter p8 = new SqlParameter("precio", precio);
                 string comando = "EXEC SpProducto @ACCION=@accion,@IdProducto=@id,@IdProveedor =@idProv, @Nombre=@nombre,@Categoria=@categoria,@Descripcion=@descripcion,@Contenido=@contenido,@Precio=@precio";
                 SqlCommand prod = new SqlCommand(comando, cnx);
                 prod.Parameters.Add(p1);
                 prod.Parameters.Add(p2);
                 prod.Parameters.Add(p3);
                 prod.Parameters.Add(p4);
                 prod.Parameters.Add(p5);
                 prod.Parameters.Add(p6);
                 prod.Parameters.Add(p7);
                 prod.Parameters.Add(p8);
                 prod.ExecuteNonQuery();
             }
             catch (Exception)
             {

                 throw;
             }
             finally { cnx.Close(); }
         }

         public static void insumo(byte accion, int id, string nombre, int idprov, string descripcion, string contenido)
         {
             try
             {
                 cnx.Open();
                 SqlParameter p1 = new SqlParameter("accion", accion);
                 SqlParameter p2 = new SqlParameter("id", id);
                 SqlParameter p3 = new SqlParameter("nombre", nombre);
                 SqlParameter p4 = new SqlParameter("idProv", idprov);
                 SqlParameter p5 = new SqlParameter("descripcion", descripcion);
                 SqlParameter p6 = new SqlParameter("contenido", contenido);
                 string comando = "Exec SpInsumo @ACCION =@accion, @IdInsumo=@id, @IdProveedor=@idProv, @Nombre=@nombre,@Descripcion=@descripcion,@Contenido=@contenido";
                 SqlCommand prod = new SqlCommand(comando, cnx);
                 prod.Parameters.Add(p1);
                 prod.Parameters.Add(p2);
                 prod.Parameters.Add(p3);
                 prod.Parameters.Add(p4);
                 prod.Parameters.Add(p5);
                 prod.Parameters.Add(p6);
                 prod.ExecuteNonQuery();
             }
             catch (Exception)
             {

                 throw;
             }
             finally { cnx.Close(); }
         
         }

         public static void hacerpedido(byte accion, int idcliente, List<CONEXION.productos> listprod, DateTime fecha, string nota,double total)
         {
             try
             {
                 cnx.Open();
                 SqlParameter p1 = new SqlParameter("accion", accion);
                 SqlParameter p2 = new SqlParameter("idCliente", idcliente);
                 SqlParameter p3 = new SqlParameter("fecha", fecha);
                 SqlParameter p4 = new SqlParameter("nota", nota);
                 SqlParameter p5 = new SqlParameter("total", total);
                 string com = "Exec SpPedido @ACCION =@accion,@IdCliente = @idCliente,@Fecha=@fecha,@Nota=@nota,@Total=@total";
                 SqlCommand comand = new SqlCommand(com, cnx);
                 comand.Parameters.Add(p1);
                 comand.Parameters.Add(p2);
                 comand.Parameters.Add(p3);
                 comand.Parameters.Add(p4);
                 comand.Parameters.Add(p5);
                 int idpedido = Convert.ToInt32(comand.ExecuteScalar());
                 foreach (var item in listprod)
                 {
                     SqlParameter p6 = new SqlParameter("idpedido", idpedido);
                     SqlParameter p7 = new SqlParameter("idproducto", item.idproducto);
                     SqlParameter p8 = new SqlParameter("cantidad", item.cantidad);
                     com = "Exec SpProdPedido @ACCION = 1, @IdPedido = @idpedido,@IdProducto=@idproducto,@Cantidad = @cantidad";
                     SqlCommand addprod = new SqlCommand(com, cnx);
                     addprod.Parameters.Add(p6);
                     addprod.Parameters.Add(p7);
                     addprod.Parameters.Add(p8);
                     addprod.ExecuteNonQuery();
                 }
             }
             catch (Exception)
             {

                 throw;
             }
             finally { cnx.Close(); }
         
         }
         public static void Inventario(bool tb,  int id, int cant)
         {
             try
             {
                 cnx.Open();
                 SqlParameter p1 = new SqlParameter("id", id);
                 SqlParameter p2 = new SqlParameter("cant", cant);
                 string com="";
                 if (tb)
                 {
                     com = "Exec SpInvProducto @ACCION=2, @IdProducto=@id, @CantTotal=@cant";
                 }
                 else
                 {
                      com = "Exec SpInvInsumo @ACCION=2, @IdInsumo=@id, @CantTotal=@cant";
                 }
                 SqlCommand inv = new SqlCommand(com, cnx);
                 inv.Parameters.Add(p1);
                 inv.Parameters.Add(p2);
                 inv.ExecuteNonQuery();
             }
             catch (Exception)
             {
                 throw;
             }
             finally { cnx.Close(); }
         }
        public static List<string> obDatos(byte numtabla, int id)
        {

            List<string> row = new List<string>();
            try
            {
                cnx.Open();
                SqlParameter p1 = new SqlParameter("id", id);
                string com = "";
                switch (numtabla)
                {
                    case 1:
                        com = "select Nombre,Direccion, Telefono,Ciudad from cliente where IdCliente =@id";
                        break;
                    case 2:
                        com = "select prod.Nombre,p.IdProveedor,p.nombre,prod.categoria,prod.descripcion,prod.contenido,prod.precio from producto as prod full join proveedor as p on prod.IdProveedor = p.IdProveedor where idProducto =@id";
                        break;
                    case 3:
                        com = "select i.Nombre,p.IdProveedor,p.nombre,i.Descripcion,i.Contenido from Insumo as i full join proveedor as p on i.IdProveedor = p.IdProveedor where idInsumo = @id";
                        break;
                    case 4:
                        com = "select Nombre, Telefono, Direccion from proveedor where IdProveedor = @id";
                        break;
                }
                SqlCommand obdat = new SqlCommand(com, cnx);
                obdat.Parameters.Add(p1);
                SqlDataReader info = obdat.ExecuteReader();
                if (info.Read())
                {
                    for (int i = 0; i < info.FieldCount; i++)
                    {
                        row.Add(info[i].ToString());
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            { cnx.Close();}
        return row;
        }
        public static List<individuo> listarindividuo(bool modo)
        {
            try
            {
                cnx.Open();
                List<individuo> list = new List<individuo>();
                SqlCommand comando;
                if (modo)
                {
                     comando = new SqlCommand("select idproveedor, nombre from proveedor", cnx);
                }
                else
                {
                     comando = new SqlCommand("Select idCliente, nombre, direccion from cliente", cnx);
                }
                SqlDataReader info = comando.ExecuteReader();
                while (info.Read())
                {
                    individuo p = new individuo();
                    p.idindividuo = Convert.ToInt32(info[0]);
                    p.nombre = info[1].ToString();
                    if(!modo)
                    {
                        p.direccion = info[2].ToString();
                    }
                    list.Add(p);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cnx.Close(); }
        }

        public static void pedido(byte accion,CONEXION.pedidos pedido)
        {
            try
            {
                cnx.Open();

                SqlParameter p9 = new SqlParameter("idped", pedido.idpedido);
                string com = "delete from ProdPedido where idPedido=@Idped";
                SqlCommand dlt = new SqlCommand(com, cnx);
                dlt.Parameters.Add(p9);
                dlt.ExecuteNonQuery();

                SqlParameter p1 = new SqlParameter("accion", accion);
                SqlParameter p2 = new SqlParameter("idpedido", pedido.idpedido);
                SqlParameter p3 = new SqlParameter("idcliente", pedido.idcliente);
                SqlParameter p4 = new SqlParameter("fecha", pedido.fecha);
                SqlParameter p5 = new SqlParameter("nota", pedido.nota);
                SqlParameter p6 = new SqlParameter("estado", pedido.estado);
                SqlParameter p7 = new SqlParameter("total", pedido.total);
                com = "Exec SpPedido @Accion =@accion,@IdPedido = @idpedido,@IdCliente =@idcliente,@Fecha=@fecha,@Nota=@nota,@Estado=@estado,@Total=@total";
                SqlCommand comand = new SqlCommand(com, cnx);
                comand.Parameters.Add(p1);
                comand.Parameters.Add(p2);
                comand.Parameters.Add(p3);
                comand.Parameters.Add(p4);
                comand.Parameters.Add(p5);
                comand.Parameters.Add(p6);
                comand.Parameters.Add(p7);
                comand.ExecuteNonQuery();
                
                     if (accion != 3)
                     {
                         foreach (var item in pedido.listaproductos)
                         {
                             SqlParameter p10 = new SqlParameter("idped", pedido.idpedido);
                             SqlParameter p11 = new SqlParameter("idprod", item.idproducto);
                             SqlParameter p12 = new SqlParameter("cantidad", item.cantidad);
                             com = "Exec SpProdPedido @ACCION = 1, @IdPedido = @idped,@IdProducto=@idprod,@Cantidad = @cantidad";
                             SqlCommand recomand = new SqlCommand(com, cnx);
                             recomand.Parameters.Add(p10);
                             recomand.Parameters.Add(p11);
                             recomand.Parameters.Add(p12);
                             int n4 = recomand.ExecuteNonQuery();
                         }
                     }
                
            }
            catch (Exception)
            {

                throw;
            }
            finally { cnx.Close(); }
        
        
        }


        public static List<productos> listaprodPed(int idpedido)
        {
            try
            {
                cnx.Open();
                List<CONEXION.productos> listapp = new List<productos>();
                SqlParameter p1 = new SqlParameter("idpedido", idpedido);
                string com = "select * from VisProdPed where idpedido = @idpedido";
                SqlCommand comad = new SqlCommand(com, cnx);
                comad.Parameters.Add(p1);
                SqlDataReader info = comad.ExecuteReader();
                while (info.Read())
                {
                    CONEXION.productos p = new productos();
                    p.prodped = Convert.ToInt32(info[0]);
                    p.idproducto = Convert.ToInt32(info[2]);
                    p.nombre = info[3].ToString();
                    p.contenido = info[4].ToString();
                    p.precio = Convert.ToDouble(info[5]);
                    p.cantidad = Convert.ToInt32(info[6]);
                    listapp.Add(p);
                }
                return listapp;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cnx.Close();
            }
           
        }
        public struct individuo
        {
            public int idindividuo;
            public string nombre;
            public string direccion;
        }

        public struct productos
        {
            public int idproducto;
            public string nombre;
            public int cantidad;
            public string contenido;
            public double precio;
            public int prodped;
        
        }

        public struct pedidos
        {
            public int idpedido;
            public int idcliente;
            public string nombrecliente;
            public string direccion;
            public DateTime fecha;
            public string nota;
            public double total;
            public bool estado;
            public List<CONEXION.productos> listaproductos;
        
        }
        
    }
}
