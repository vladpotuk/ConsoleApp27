using System.Linq;

namespace ConsoleApp27.Core
{
    public class ArrayFilter
    {
        public static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            return originalArray.Where(element => !filterArray.Contains(element)).ToArray();
        }
    }
}
