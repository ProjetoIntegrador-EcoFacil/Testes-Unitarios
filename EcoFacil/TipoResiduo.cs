using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class TipoResiduo
	{
		public int IdTipoResiduo { get; set; }
		public string NomeTipoResiduo { get; set; }
		public bool Perigoso { get; set; }

		public TipoResiduo(int idTipoResiduo, string nomeTipoResiduo, bool perigoso)
		{
			this.IdTipoResiduo = idTipoResiduo;
			this.NomeTipoResiduo = nomeTipoResiduo;
			this.Perigoso = perigoso;
		}
	}
}
