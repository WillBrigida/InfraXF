using InfraXF.Services.Armazenamento;
using Xamarin.Forms;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Dependency(typeof(InfraXF.Droid.Services.Armazenamento.SQLite))]
namespace InfraXF.Droid.Services.Armazenamento
{
    public class SQLite : ISQLite
    {
        private string directoryDB;
        private ISQLitePlatform platform;

        public string DirectoryDB
        {
            get
            {
                if (string.IsNullOrEmpty(directoryDB))
                {
                    directoryDB = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return directoryDB;
            }
        }

        public ISQLitePlatform Platform
        {
            get
            {
                if (platform == null)
                {
                    platform = new SQLitePlatformAndroid();
                }
                return platform;
            }
        }
    }
}