using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faturamento_Distribuidora {
    internal class Program {
        static void Main(string[] args) {


            decimal faturamentoSP = 67836.43m;
            decimal faturamentoRJ = 36678.66m;
            decimal faturamentoMG = 29229.88m;
            decimal faturamentoES = 27165.48m;
            decimal faturamentoOutros = 19849.53m;

            decimal faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;


            decimal percentualSP = (faturamentoSP / faturamentoTotal) * 100m;
            decimal percentualRJ = (faturamentoRJ / faturamentoTotal) * 100m;
            decimal percentualMG = (faturamentoMG / faturamentoTotal) * 100m;
            decimal percentualES = (faturamentoES / faturamentoTotal) * 100m;
            decimal percentualOutros = (faturamentoOutros / faturamentoTotal) * 100m;



            Console.WriteLine("Percentual de representação de cada estado:");
            Console.WriteLine($"SP: {percentualSP:F2}%");
            Console.WriteLine($"RJ: {percentualRJ:F2}%");
            Console.WriteLine($"MG: {percentualMG:F2}%");
            Console.WriteLine($"ES: {percentualES:F2}%");
            Console.WriteLine($"Outros: {percentualOutros:F2}%");

            Console.ReadLine();

        }
    }
}
