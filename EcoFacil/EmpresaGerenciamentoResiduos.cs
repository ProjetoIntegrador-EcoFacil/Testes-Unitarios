using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class EmpresaGerenciamentoResiduos : Usuario
	{
		public int IdEmpresaGerenciamentoResiduos { get; set; }
		public TipoUsuario TipoUsuario { get; set; }

		public EmpresaGerenciamentoResiduos(int idEmpresaGerenciamentoResiduos, string nomeEmpresaGerenciamentoResiduos, string emailEmpresaGerenciamentoResiduos, string senhaEmpresaGerenciamentoResiduos, TipoUsuario tipoUsuario)
		{
			this.IdEmpresaGerenciamentoResiduos = idEmpresaGerenciamentoResiduos;
			base.Nome = nomeEmpresaGerenciamentoResiduos;
			base.Email = emailEmpresaGerenciamentoResiduos;
			base.Senha = senhaEmpresaGerenciamentoResiduos;
			this.TipoUsuario = tipoUsuario;
		}
	}
}
