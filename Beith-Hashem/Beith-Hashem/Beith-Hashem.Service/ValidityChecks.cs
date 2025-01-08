using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Service.Services
{
    public static class ValidityChecks
    {
        public static bool CheckId(this string identityString)
        {
            if (identityString.Length == 8 && !string.IsNullOrWhiteSpace(identityString))
            {
                foreach (char c in identityString)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}

