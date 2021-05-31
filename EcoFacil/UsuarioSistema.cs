using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace EcoFacil
{
	public class UsuarioSistema : Usuario
	{
		public int IdUsuario { get; set; }

		public TipoUsuario TipoUsuario { get; set; }

		public UsuarioSistema(int idUsuario, string nomeUsuario, string emailUsuario, string senhaUsuario, TipoUsuario tipoUsuario)
		{
			this.IdUsuario = idUsuario;
			base.Nome = nomeUsuario;
			base.Email = emailUsuario;
			base.Senha = senhaUsuario;
			this.TipoUsuario = tipoUsuario;
		}
	}
}
