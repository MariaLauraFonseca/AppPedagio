using AppPedagio2.Models;
using SQLite;
namespace AppPedagio2.Helpers
{
    public class SQLiteDatabaseHelperPedagio
    {

        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelperPedagio(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Pedagio>().Wait();
        }
        public Task<int> InsertPedagio(Pedagio p)
        {
            return _conn.InsertAsync(p);
        }

        public Task<List<Pedagio>> Update(Pedagio p)
        {
            string sql = "UPDATE Pedagio SET Local=? Valor=?, Id_Viagem=? WHERE Id=?";
            return _conn.QueryAsync<Pedagio>(sql, p.Local, p.Valor, p.Id_Viagem, p.Id);
        }

        public Task<List<Pedagio>> GetAll()
        {
            return _conn.Table<Pedagio>().ToListAsync();
        }

        public Task Delete(int id)
        {
            return _conn.Table<Pedagio>().DeleteAsync(i => i.Id == id);
        }

        public Task<List<Pedagio>> Search(string q)
        {
            string sql = "SELECT * FROM Pedagio WHERE Origem LIKE '%" + q + "%'";
            return _conn.QueryAsync<Pedagio>(sql);
        }
    }
}
