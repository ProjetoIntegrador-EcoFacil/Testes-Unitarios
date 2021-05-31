using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class EnderecoEmpresaGerenciamentoResiduos : Endereco
	{
		public int IdEnderecoEmpresaGerenciamentoResiduos { get; set; }
		public EmpresaGerenciamentoResiduos EmpresaGerenciamentoResiduos { get; set; }

		public EnderecoEmpresaGerenciamentoResiduos(int idEnderecoEmpresaGerenciamentoResiduos, string logradouro, string numero, string complemento, string cidade, string UF, EmpresaGerenciamentoResiduos empresaGerenciamentoResiduos)
		{
			this.IdEnderecoEmpresaGerenciamentoResiduos = idEnderecoEmpresaGerenciamentoResiduos;
			base.Logradouro = logradouro;
			base.Numero = numero;
			base.Complemento = complemento;
			base.Cidade = cidade;
			base.UF = UF;
			this.EmpresaGerenciamentoResiduos = empresaGerenciamentoResiduos;
		}
	}
}
