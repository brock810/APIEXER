using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();
        }   
    }
}
