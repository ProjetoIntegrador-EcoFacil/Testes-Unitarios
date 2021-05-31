using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFacil
{
	public class CoordenadasPontoColeta
	{
		public int IdCoordenadaPontoColeta { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public PontoColeta PontoColeta { get; set; }

		public CoordenadasPontoColeta(int idCoordenadaPontoColeta, string latitude, string longitude, PontoColeta pontoColeta)
		{
			this.IdCoordenadaPontoColeta = idCoordenadaPontoColeta;
			this.Latitude = latitude;
			this.Longitude = longitude;
			this.PontoColeta = pontoColeta;
		}
	}
}
