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

		protected void btnGuardar_Click(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			persona.cedula = txtcedula.Text;
			persona.nombre = txtfechaNacimiento.Text;
			persona.apellido = txtapellido.Text;
			persona.fechaNacimiento =Convert.ToDateTime( txtfechaNacimiento.Text);
			persona.edad = Convert.ToInt32(txtedad.Text);
			persona.direccion = txtdireccion.Text;
			if (persona.nuevaPersona(persona) > 0)
			{
				ClientScript.RegisterClientScriptBlock(this.GetType(),
					"registro", "<script>alert('registro insertado correctamente')</script>");
				
				dgvPersona.DataBind();
			}
			else
			{
				ClientScript.RegisterClientScriptBlock(this.GetType(),
						"registro", "<script>alert('registro no insertado')</script>");
			
			}

		}
	}
}