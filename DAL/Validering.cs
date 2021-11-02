using System;
using System.Xml;

namespace DAL
{
    public class Validering
    {
        public Boolean TextEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean CheckUrl(string url)
        {
            try
            {
                new XmlDocument().Load(url);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
