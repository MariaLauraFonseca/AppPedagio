using AppPedagio2.Helpers;

namespace AppPedagio2
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper DB
        {
            get
            {
                if(_db == null)
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "banco_sqlite_viagem.db3");

                    _db = new SQLiteDatabaseHelper(path);
                }

                return _db;
            }

        }

        static SQLiteDatabaseHelperPedagio _dbpedagio;

        public static SQLiteDatabaseHelperPedagio DBpedagio
        {
            get
            {
                if (_dbpedagio == null)
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "banco_sqlite_pedagios.db3");

                    _dbpedagio = new SQLiteDatabaseHelperPedagio(path);
                }

                return _dbpedagio;
            }

        }



        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
