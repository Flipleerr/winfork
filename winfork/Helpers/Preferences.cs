using Tomlyn.Parsing;
using winfork.Properties;

namespace winfork.Helpers
{
    public class Preferences
    {
        public void Read()
        {
            try
            {
                string prefs = File.ReadAllText("settings.toml");
            }
            catch 
            {
                File.Create("settings.toml");
            }
        }
    }
}
