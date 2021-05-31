using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class EnderecoPontoColeta : Endereco
	{
		public int IdEnderecoPontoColeta { get; set; }
		public PontoColeta PontoColeta { get; set; }

		public EnderecoPontoColeta(int idEnderecoPontoColeta, string logradouro, string numero, string complemento, string cidade, string UF, PontoColeta pontoColeta)
		{
			this.IdEnderecoPontoColeta = idEnderecoPontoColeta;
			base.Logradouro = logradouro;
			base.Numero = numero;
			base.Complemento = complemento;
			base.Cidade = cidade;
			base.UF = UF;
			this.PontoColeta = pontoColeta;
		}
	}
}
