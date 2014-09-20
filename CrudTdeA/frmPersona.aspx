<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPersona.aspx.cs" Inherits="CrudTdeA.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<br />
	<br />

	<table class="nav-justified">
		<tr>
			<td style="width: 161px">Cedula *</td>
			<td>
				<asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="#993333" ControlToValidate="txtcedula" ErrorMessage="Debe ingresar una cedula"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td style="width: 161px">Nombre *</td>
			<td>
				<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" BackColor="#993333" ControlToValidate="txtnombre" ErrorMessage="Debe ingresar un nombre"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td style="width: 161px">Apellido *</td>
			<td>
				<asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" BackColor="#993333" ControlToValidate="txtapellido" ErrorMessage="Debe ingresar un apellido"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td style="width: 161px">Fecha Nacimiento *</td>
			<td>
				<asp:TextBox ID="txtfechaNacimiento" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" BackColor="#993333" ControlToValidate="txtfechaNacimiento" ErrorMessage="Debe ingresar una fecha nacimiento"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td style="width: 161px">Edad *</td>
			<td>
				<asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" BackColor="#993333" ControlToValidate="txtedad" ErrorMessage="Debe ingresar una edad"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td style="width: 161px">Direccion</td>
			<td>
				<asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
			</td>
		</tr>
	</table>
	<br />
	<asp:Button ID="btnGuardar" runat="server" Text="Guardar" />

	<br />
	<asp:GridView ID="dgvPersona" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
		<AlternatingRowStyle BackColor="White" />
		<EditRowStyle BackColor="#7C6F57" />
		<FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
		<HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
		<PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
		<RowStyle BackColor="#E3EAEB" />
		<SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
		<SortedAscendingCellStyle BackColor="#F8FAFA" />
		<SortedAscendingHeaderStyle BackColor="#246B61" />
		<SortedDescendingCellStyle BackColor="#D4DFE1" />
		<SortedDescendingHeaderStyle BackColor="#15524A" />
	</asp:GridView>

</asp:Content>
