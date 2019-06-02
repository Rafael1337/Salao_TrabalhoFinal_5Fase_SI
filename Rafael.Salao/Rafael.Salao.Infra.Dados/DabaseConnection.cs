

namespace Rafael.Salao.Infra.Dados
{
    public class DabaseConnection
    {
        public void VerifyConnectionString(string server, string _database, string _user, string _password)
        {

        }
        public void InitializeConnection()
        {

            DataContext DC = new DataContext();
        }
    }
}
