using SQLite;

namespace AppPedagio2.Models
{
    public class Pedagio
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Local { get; set; }

        public string Valor { get; set; }

        public double Id_Viagem { get; set; }

    }
}
