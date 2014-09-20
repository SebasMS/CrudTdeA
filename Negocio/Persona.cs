using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
	public class Persona
	{

		public string cedula { get; set; }
		public string nombre { get; set; }
		public string apellido { get; set; }
		public DateTime fechaNacimiento { get; set; }
		public int edad { get; set; }
		public string direccion { get; set; }
		#region metodo insertar
		public int nuevaPersona(Persona persona)
		{
			DatosSistema datos = new DatosSistema();
			string[] parametros = { "@operacion",
									  "@cedula",
									  "@nombre",
									  "@apellido",
									  "@fechaNacimiento",
									  "@edad",
									  "@direccion"};
			return datos.Ejecutar("spPersonaIA",parametros,"I",
				persona.cedula,
				persona.nombre,
				persona.apellido,
				persona.fechaNacimiento,
				persona.edad,
				persona.direccion);
		}

		#endregion
		#region método actulizar
		public int ActulizarPersona(Persona persona)
		{
			DatosSistema datos = new DatosSistema();
			string[] parametros = { "@operacion",
									  "@cedula",
									  "@nombre",
									  "@apellido",
									  "@fechaNacimiento",
									  "@edad",
									  "@direccion"};
			return datos.Ejecutar("spPersonaIA", parametros, "A",
				persona.cedula,
				persona.nombre,
				persona.apellido,
				persona.fechaNacimiento,
				persona.edad,
				persona.direccion);
		}

		#endregion

		#region método listas personas
		public DataTable listarPersona() {
			DatosSistema datos = new DatosSistema();			 
			String[] parametros = { "@operacion","@cedula"};
			return datos.getDatos("spPesonaSE",parametros,"T",0);	

		
		}

		#endregion

		#region eliminar

		public int eliminaPersona(String cedula)
		{
			DatosSistema datos = new DatosSistema();
			string[] parametros = {"@operacion","@cedula" };
			return datos.Ejecutar("spPersonaSE",parametros,"E",cedula);

		
		}


		#endregion

		#region consulta persona

		public Persona getPersona(string cedula) {
			DatosSistema datos = new DatosSistema();
			DataTable dt = new DataTable();
			Persona p = new Persona();
			string[] parametros = { "@operacion","@cedula"};
			dt = datos.getDatos("spPersonaSE",parametros,"S",cedula);
			foreach (DataRow fila in dt.Rows) {
				p.cedula = fila["cedula"].ToString();
				p.nombre = fila["nombre"].ToString();
				p.apellido=fila["apellido"].ToString();
				p.fechaNacimiento = Convert.ToDateTime(fila["fechaNacimiento"].ToString());
				p.edad = Convert.ToInt32(fila["edad"].ToString());
				p.direccion = fila["direccion"].ToString(); 
			
			}
			return p;

		
		}
		#endregion

	}
}
