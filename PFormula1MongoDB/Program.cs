using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using PFormula1MongoDB;

internal class Program
{
    private static void Main(string[] args)
    {
        MongoClient mongo = new MongoClient("mongodb://localhost:27017");

        var basededados = mongo.GetDatabase("Formula1");
        var collection = basededados.GetCollection<BsonDocument>("Pilotos");
        var documents = collection.Find(new BsonDocument()).ToList();
        #region CRUD
        //Console.WriteLine("Informe o nome do piloto: ");
        //string n = Console.ReadLine();

        //var filtro = Builders<BsonDocument>.Filter.Regex("Driver", n);

        //var p = collection.Find(filtro).FirstOrDefault();

        //var piloto = BsonSerializer.Deserialize<Driver>(p);

        //Console.WriteLine("\n"+piloto.ToString());

        //Console.WriteLine("Nome: ");
        //string n = Console.ReadLine();

        //Console.WriteLine("Abreviação: ");
        //string a = Console.ReadLine();

        //Console.WriteLine("Numero: ");
        //int m = int.Parse(Console.ReadLine());

        //Console.WriteLine("Equipe: ");
        //string t = Console.ReadLine();

        //Console.WriteLine("País: ");
        //string c = Console.ReadLine();

        //Console.WriteLine("Data de Nascimento: ");
        //string d = Console.ReadLine();

        //Driver driver = new(n, a, m, t, c, d);

        //Console.WriteLine(driver.ToString());

        //var dr = new BsonDocument
        //{
        //    {"Driver", driver.Name},
        //    {"Abbreviation", driver.Abbreviation },
        //    {"No", driver.Number },
        //    {"Team", driver.Team },
        //    {"Country", driver.Country },
        //    {"Date of Birth", driver.BirthDate}
        //};

        //Console.WriteLine(dr);

        //collection.InsertOne(dr);
        #endregion

        Console.WriteLine("Informe o nome do piloto: ");
        string n = Console.ReadLine();

        var p = collection.Find(Builders<BsonDocument>.Filter.Regex("Driver",n)).First();

        //var driver = BsonSerializer.Deserialize<Driver>(p);

        Console.WriteLine("Informe o novo numero: ");
        int m = int.Parse(Console.ReadLine());
        //driver.Number = m;

        //collection.UpdateOne(Builders<BsonDocument>.Filter.Regex("Driver", n), 
            //Builders<BsonDocument>.Update.Set("No", m));

        var filtro = Builders<BsonDocument>.Filter.Regex("Driver", n);
        var update = Builders<BsonDocument>.Update.Set("No", m);

        //collection.UpdateOne(filtro, update);

        collection.DeleteMany(filtro);
    }
}