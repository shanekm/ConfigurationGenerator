using ConfigurationGenerator.Generator;

namespace Start
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SettingsAppConfig settings = new SettingsAppConfig();
            string isbn = settings.bookstore.book[1].ISBN;
            int someInt = settings.IntValue; // from appSettings

            SettingsXml xmlSettings = new SettingsXml(false);
            decimal price = xmlSettings.bookstore.book[0].price;



        }
    }
}