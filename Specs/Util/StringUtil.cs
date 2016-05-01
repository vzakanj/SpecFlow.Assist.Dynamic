using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Specs.Util
{
    public static class StringUtil
    {
        public static string[] GetNames(string commaSeparatedNames)
        {
            return commaSeparatedNames
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => n.Trim())
                .ToArray();
        }
    }
}
