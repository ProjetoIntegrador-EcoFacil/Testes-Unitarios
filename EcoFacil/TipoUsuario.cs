using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public enum TiposDeUsuarios
	{
		Comum = 1,
		Empresa = 2,
		Comercio = 3,
		EmpresaGerenciamentoDeResiduos = 4
	}

	public class TipoUsuario
	{
		public int IdTipoUsuario { get; set; }
		public TiposDeUsuarios TipoDeUsuario { get; set; }

		public TipoUsuario(int idTipoUsuario, TiposDeUsuarios tipoDeUsuario)
		{
			this.IdTipoUsuario = idTipoUsuario;
			this.TipoDeUsuario = tipoDeUsuario;
		}
	}
}
