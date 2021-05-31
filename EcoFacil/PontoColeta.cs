using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class PontoColeta
	{
		public int IdPontoColeta { get; set; }
		public TipoResiduo TipoResiduo { get; set; }

		public PontoColeta(int idPontoColeta, TipoResiduo tipoResiduo)
		{
			this.IdPontoColeta = idPontoColeta;
			this.TipoResiduo = tipoResiduo;
		}
	}
}
