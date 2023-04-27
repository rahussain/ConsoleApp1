using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleNameSpace
{
    delegate double Function(double x);

    class Multiplier
    {
        double _factor;

        public Multiplier(double factor) => _factor = factor;

        public double Multiply(double x) => x * _factor;
    }

    class DelegateExample
    {
        static double[] Apply(double[] a, Function f)
        {
            var result = new double[a.Length];
            for (int i = 0; i < a.Length; i++) result[i] = f(a[i]);
            return result;
        }

        public static void MethodCall()
        {
            double[] a = { 0.0, 0.5, 1.0 };
            double[] squares = Apply(a, (x) => x * x);
            double[] sines = Apply(a, Math.Sin);
            Multiplier m = new(2.0);
            double[] doubles = Apply(a, m.Multiply);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"the square of {a[i]} is {squares[i]} and sin of {a[i]} is {sines[i]}");
            }
            
        }
    }
    public class HelpAttribute : Attribute
    {
         string _url;
         string _topic;

        public HelpAttribute(string url) => _url = url;

        public string Url => _url;

        public string Topic
        {
            get => _topic;
            set => _topic = value;
        }
    }
    [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features")]
    public class Widget
    {
        [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features",
        Topic = "Display")]
        public void Display(string text) { }
    }
}
