using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PFormula1MongoDB
{
    [BsonIgnoreExtraElements]
    internal class Driver
    {
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        
        [BsonElement("Driver")]
        public string? Name { get; set; }

        [BsonElement("Abbreviation")]
        public string? Abbreviation { get; set; }

        [BsonElement("No")]
        [BsonRepresentation(BsonType.Int32)]
        public int Number { get; set; }

        [BsonElement("Team")]
        public string? Team { get; set; }

        [BsonElement("Country")]
        public string? Country { get; set; }

        [BsonElement("Date of Birth")]
        public string? BirthDate { get; set; }

        public Driver(string? name, string? abbreviation, int number,
            string? team, string? country, string? birthDate)
        {
            Name = name;
            Abbreviation = abbreviation;
            Number = number;
            Team = team;
            Country = country;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nAbreviação: {Abbreviation}\nNumero do carro: {Number}\n" +
                $"Equipe: {Team}\nPaís de Origem: {Country}\nData de Nascimento: {BirthDate}\n";
        }
    }
}
