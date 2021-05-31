using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class ServicoOferecidoEmpresaGerenciamentoResiduos
	{
		public int IdServicoOferecidoEmpresaGerenciamentoResiduos { get; set; }
		public string NomeServico { get; set; }
		public bool FazColeta { get; set; }
		public EmpresaGerenciamentoResiduos EmpresaGerenciamentoResiduos { get; set; }

		public ServicoOferecidoEmpresaGerenciamentoResiduos(int idServicoOferecidoEmpresaGerenciamentoResiduos, string nomeServico, bool fazColeta, EmpresaGerenciamentoResiduos empresaGerenciamentoResiduos)
		{
			this.IdServicoOferecidoEmpresaGerenciamentoResiduos = idServicoOferecidoEmpresaGerenciamentoResiduos;
			this.NomeServico = nomeServico;
			this.FazColeta = fazColeta;
			this.EmpresaGerenciamentoResiduos = empresaGerenciamentoResiduos;
		}
	}
}
