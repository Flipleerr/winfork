using Tomlyn;
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
                string prefData = File.ReadAllText("settings.toml");
                var prefs = Toml.Parse(prefData);

                if (prefs.HasErrors)
                {
                    foreach (var error in prefs.Diagnostics)
                    {
                        Console.WriteLine(error);
                    }
                }
            }
            catch 
            {
                File.Create("settings.toml");
            }
        }

        public void Write()
        {

        }
    }
}
