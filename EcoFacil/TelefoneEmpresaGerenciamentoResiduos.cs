using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class TelefoneEmpresaGerenciamentoResiduos : Telefone
	{
		public int IdTelefoneEmpresaGerenciamentoResiduos { get; set; }
		public EmpresaGerenciamentoResiduos EmpresaGerenciamentoResiduos { get; set; }

		private TelefoneEmpresaGerenciamentoResiduos(int idTelefoneEmpresaGerenciamentoResiduos, string numeroTelefone, EmpresaGerenciamentoResiduos empresaGerenciamentoResiduos)
		{
			this.IdTelefoneEmpresaGerenciamentoResiduos = idTelefoneEmpresaGerenciamentoResiduos;
			base.NumeroTelefone = numeroTelefone;
			this.EmpresaGerenciamentoResiduos = empresaGerenciamentoResiduos;
		}
	}
}
