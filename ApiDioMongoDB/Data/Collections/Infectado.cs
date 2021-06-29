using MongoDB.Driver.GeoJsonObjectModel;
using System;


namespace ApiDioMongoDB.Data.Collections
{
    public class Infectado
    {
        public Infectado(DateTime dataNascimeto, string sexo, double latitude, double longetude)
        {
            this.DataNascimento = dataNascimeto;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longetude, latitude);
        }

        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }

    

}