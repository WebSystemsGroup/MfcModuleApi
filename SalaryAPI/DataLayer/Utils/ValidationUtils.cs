using System.Linq;

namespace DataLayer.Utils
{
    public static class ValidationUtils
    {
        public static bool IsValidName(string name) => name is null or { Length: 0 } || name.All(a => a is ' ');
    }
}
