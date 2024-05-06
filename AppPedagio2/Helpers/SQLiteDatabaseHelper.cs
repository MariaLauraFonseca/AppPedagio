using AppPedagio2.Models;
using SQLite;
using System.Reflection.PortableExecutable;

namespace AppPedagio2.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Viagem>().Wait();
        }
        public Task<int> InsertPedagio(Viagem v)
        {
            return _conn.InsertAsync(v);
        }

        public Task<List<Viagem>> GetAll ()
        {
            return _conn.Table<Viagem>().ToListAsync();
         
        }
        public Task<List<Viagem>> Update(Viagem p)
        {
            string sql = "UPDATE Viagem SET Origem=? Destino=?, Distancia=?, Rendimento=?, Preco=? WHERE Id=?";
            return _conn.QueryAsync<Viagem>(sql, p.Origem, p.Destino, p.Distancia, p.Rendimento, p.Preco);
        }

        public Task Delete(int id)
        {
            return _conn.Table<Viagem>().DeleteAsync(i => i.Id == id);
        }

        public Task<List<Viagem>> Search(string q)
        {
            string sql = "SELECT * FROM Viagem WHERE Origem LIKE '%" + q + "%'";
            return _conn.QueryAsync<Viagem>(sql);
        }
    }
}
