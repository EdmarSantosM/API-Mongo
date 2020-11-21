using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace ApiDio.Data.Collections
{
    public class Infectado //  Essa  classe  representa a  coleção de dados ( Collections)
    {
        public Infectado( DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

        public DateTime DataNascimento {get; set;}

        public string Sexo { get; set; }

        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}