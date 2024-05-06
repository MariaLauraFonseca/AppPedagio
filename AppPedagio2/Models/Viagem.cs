using SQLite;

namespace AppPedagio2.Models
{
    public class Viagem
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Origem { get; set; }

        public string Destino { get; set; }

        public double Distancia { get; set; }

        public double Rendimento { get; set; }

        public double Preco { get; set; }
    }
}
