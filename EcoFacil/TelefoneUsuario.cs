using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class TelefonesUsuario : Telefone
	{
		public int IdTelefoneUsuario { get; set; }
		public UsuarioSistema Usuario { get; set; }

		public TelefonesUsuario(int idTelefoneUsuario, string numeroTelefone, UsuarioSistema usuario)
		{
			this.IdTelefoneUsuario = idTelefoneUsuario;
			base.NumeroTelefone = numeroTelefone;
			this.Usuario = usuario;
		}
	}
}
