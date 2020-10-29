using System;
using Figgle;

namespace HeronSeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double A; 
            double B;
            double C;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(FiggleFonts.Digital.Render($"HeronSeTriangulo"));
            Console.WriteLine("= Calcule a área de um triângulo =");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("= Escolha numeros decimais =");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Primeiro número: ");

             A =Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo número: ");
             B =Convert.ToDouble(Console.ReadLine());
            Console.Write("Terceiro e ultimo número: ");
             C =Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();
            double soma_S=(A + B + C) / 2;
            
            double soma_A=soma_S - A;
            double soma2_A=soma_S - B;
            double soma3_A=soma_S - C;
            double soma4_A=soma_S * soma_A * soma2_A * soma3_A;
            double soma5_A=Math.Round(soma4_A);

          
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if(A<(B+C) && A > Math.Abs(B - C) && B < (A + C) && B > 
            Math.Abs(A - C) && C < (A + B) && C > Math.Abs(A - B))
            Console.WriteLine($"Relatorio do triangulo");
           
            else
            Console.WriteLine(FiggleFonts.Doom.Render($"o p s !"));    
            Console.ResetColor();
            if(A==B && A==C && B==A && B==C && C==A && C==B)
            Console.WriteLine($"Seu triângulo é do tipo Equilátero");
            else if(A!=B && A!=C && B!=A && B!=C && C!=A && C!=B)
            Console.WriteLine($"Triângulo = Escaleno");
            else
            Console.WriteLine($"Triângulo = Isósceles");
       
            Console.WriteLine($"Extensão do traingulo é = {soma5_A}");

        
        }
    }
}