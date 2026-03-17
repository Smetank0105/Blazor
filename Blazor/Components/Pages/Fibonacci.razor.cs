using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {
        int number = 2;
        List<BigInteger> result = new List<BigInteger>();
        void GetFibonacci()
        {
            result = new List<BigInteger>();
            result.Add(0);
            result.Add(1);
            for(int i = 2; i < number; i++)
            {
                result.Add(result[i-1] + result[i-2]);
            }
        }
    }
}
