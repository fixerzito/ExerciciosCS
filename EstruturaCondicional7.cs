using System;
using System.Globalization;

namespace EstruturaCondicional7
    //Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
    //que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
    //qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.

    //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb.Em seguida, calcule e
    //mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

    //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
    //salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
    //de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
    //duas casas decimais.
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o seu salário abaixo:");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imp8 = 0.08;
            double imp18 = 0.18;
            double imp28 = 0.28;
            double salarioPart1 = 0.0;
            double salarioPart2 = 0.0;
            double impostoTotal = 0.0;

            if (salarioBase > 2000.01 && salarioBase <= 3000.00) //0 a 2000
                impostoTotal = (salarioBase - 2000.00) * imp8;
            else if (salarioBase > 3000.01 && salarioBase <= 4500.00)// 2000.01 a 3000
                impostoTotal = ((salarioBase - 3000.00) * imp18) + (imp8 * 1000.00);
            else
                impostoTotal = ((salarioBase - 4500.00) * imp28) + (imp8 * 1000.00)+(imp18 * 1500.00);

            if (salarioBase >= 2000.00)
                Console.WriteLine("R$"+impostoTotal.ToString("F2", CultureInfo.InvariantCulture));
            else
                Console.WriteLine("ISENTO");
        }
    }
}