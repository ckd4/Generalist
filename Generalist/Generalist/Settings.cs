using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalist
{
    public static class Settings
    {
        public static int T4PB { get; set; }

        public static int[] IDArray { get; set; }

        public static T[] RemoveAt<T>(this T[] source, int index)
        {
            var dest = new List<T>(source);
            dest.RemoveAt(index);
            return dest.ToArray();
        }
    }
}
