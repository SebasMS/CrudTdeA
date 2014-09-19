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
			Cargar();
		}

		private void Cargar()
		{
			Persona persona = new Persona();
			dgvPersona.DataSource = persona.listarPersona();
			dgvPersona.DataBind();
		}

		protected void btnGuardar_Click(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			persona.cedula = txtcedula.Text;
			persona.nombre = txtnombre.Text;
			persona.apellido = txtapellido.Text;
			persona.fechaNacimiento =Convert.ToDateTime( txtfechaNacimiento.Text);
			persona.edad = Convert.ToInt32(txtedad.Text);
			persona.direccion = txtdireccion.Text;
			if (persona.nuevaPersona(persona) > 0)
			{
				ClientScript.RegisterClientScriptBlock(this.GetType(),
					"registro", "<script>alert('registro insertado correctamente')</script>");

				Cargar();
			}
			else
			{
				ClientScript.RegisterClientScriptBlock(this.GetType(),
						"registro", "<script>alert('registro no insertado')</script>");
			
			}

		}

		protected void btnActualizar_Click(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			persona.cedula = txtcedula.Text;
			persona.nombre = txtnombre.Text;
			persona.apellido = txtapellido.Text;
			persona.fechaNacimiento = Convert.ToDateTime(txtfechaNacimiento.Text);
			persona.edad = Convert.ToInt32(txtedad.Text);
			persona.direccion = txtdireccion.Text;
			if (persona.ActulizarPersona(persona) > 0)
			{
				ClientScript.RegisterClientScriptBlock(this.GetType(),
					"registro", "<script>alert('registro actualizado correctamente')</script>");

				Cargar();
			}
			else
			{
				ClientScript.RegisterClientScriptBlock(this.GetType(),
						"registro", "<script>alert('registro no actualizar')</script>");

			}
		}

		protected void btnConsultar_Click(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			if ((persona = persona.getPersona(txtcedula.Text)) != null)
			{
				txtcedula.Text = persona.cedula;
				txtnombre.Text = persona.nombre;
				txtapellido.Text = persona.apellido;
				txtfechaNacimiento.Text = persona.fechaNacimiento+"";
				txtedad.Text = persona.edad.ToString();
				txtdireccion.Text = persona.direccion;
				ClientScript.RegisterClientScriptBlock(this.GetType(),
						"registro", "<script>alert('registro encontrado')</script>");
			}
			else
			{
				ClientScript.RegisterClientScriptBlock(this.GetType(),
							"registro", "<script>alert('registro no encontrado')</script>");
			
			}
		}

		protected void btnEliminar_Click(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			if (persona.eliminaPersona(txtcedula.Text) > 0)
			{
				ClientScript.RegisterClientScriptBlock(this.GetType(),
							"registro", "<script>alert('registro eliminado')</script>");
				Cargar();
			}
			else
			{
				ClientScript.RegisterClientScriptBlock(this.GetType(),
								"registro", "<script>alert('registro no eliminado')</script>");
			
			}
		}
	}
}