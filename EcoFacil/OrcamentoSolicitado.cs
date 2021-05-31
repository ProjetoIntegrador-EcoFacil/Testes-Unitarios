using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class OrcamentoSolicitado
	{
		public int IdOrcamento { get; set; }
		public decimal QuantidadeResiduos { get; set; }
		public DateTime DataSolicitacao { get; set; }
		public EmpresaGerenciamentoResiduos EmpresaGerenciamentoResiduos { get; set; }
		public TipoResiduo TipoResiduo { get; set; }
		public UsuarioSistema Usuario { get; set; }

		public OrcamentoSolicitado(int idOrcamento, decimal quantidadeResiduos, DateTime dataSolicitacao, EmpresaGerenciamentoResiduos empresaGerenciamentoResiduos, TipoResiduo tipoResiduo, UsuarioSistema usuario)
		{
			this.IdOrcamento = idOrcamento;
			this.QuantidadeResiduos = quantidadeResiduos;
			this.DataSolicitacao = dataSolicitacao;
			this.EmpresaGerenciamentoResiduos = empresaGerenciamentoResiduos;
			this.TipoResiduo = tipoResiduo;
			this.Usuario = usuario;
		}
	}
}
