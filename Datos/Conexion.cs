using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
		public SqlConnection con { get; set; }

		// retorno cadenaconexión

		public string cadenaConexion() {
			return @"data source=.;initial=Practica1;user id=esneyder;password=alvarez123";
		}

		#region método conexión
		public SqlConnection conectar() {
			con = new SqlConnection(cadenaConexion());

			try
			{
				con.Open();
				return this.con;					
			}
			catch (Exception)
			{
				return null;
			}
		
		}

		#endregion
		#region deconectar
		public void desconectar() {
			if (this.con!=null)
			{
				this.con.Close();
			}
		}
		#endregion


	}
}
