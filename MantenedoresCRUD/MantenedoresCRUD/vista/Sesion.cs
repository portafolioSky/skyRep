using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.vista
{
    public static class Sesion
    {
        private static Dictionary<string, object> _values =
               new Dictionary<string, object>();
        public static void SetValue(string key, object value)
        {
            if (_values.ContainsKey(key))
            {
                _values.Remove(key);
            }
            _values.Add(key, value);
        }
        public static T GetValue<T>(string key)
        {
            if (_values.ContainsKey(key))
            {
                return (T)_values[key];
            }
            else
            {
                return default(T);
            }
        }
    }
}
