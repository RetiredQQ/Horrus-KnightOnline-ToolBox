using System.Globalization;
using System.Reflection;
using System.Resources;

namespace TableEditor
{
    public static class LanguageManager
    {
        static ResourceManager _resManager = new ResourceManager("TableEditor.Resources.LangEn", Assembly.Load("TableEditor"));

        public static string Get(string label)
        {
            return _resManager.GetString(label, CultureInfo.CreateSpecificCulture("en"));
        }
    }
}
