using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class EnderecoUsuario : Endereco
	{
		public int IdEnderecoUsuario { get; set; }
		public UsuarioSistema Usuario { get; set; }

		public EnderecoUsuario(int idEnderecoUsuario, string logradouro, string numero, string complemento, string cidade, string UF, UsuarioSistema usuario)
		{
			this.IdEnderecoUsuario = idEnderecoUsuario;
			base.Logradouro = logradouro;
			base.Numero = numero;
			base.Complemento = complemento;
			base.Cidade = cidade;
			base.UF = UF;
			this.Usuario = usuario;
		}
	}
}
