using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudTdeA
{
	public partial class Formulario_web11 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			dgvPersona.DataSource = persona.listarPersona();
			dgvPersona.DataBind();
		}
	}
}