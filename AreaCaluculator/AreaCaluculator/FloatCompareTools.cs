
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("UnitTests")]
namespace AreaCaluculator
{
    internal static class FloatCompareTools
    {
        private const double SmallEnoughValue = 1e-15;
        public static bool AreEqual(this double a, double b)
        {
            return (a - b) < SmallEnoughValue;
        }
    }
}
