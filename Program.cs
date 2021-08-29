using System;

namespace ProgramaLeet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, H4ck3r");
            
            Console.WriteLine("------------------");

            Console.Write("Insira sua mensagem para ser criptografada: ");
            string textoCriptografado = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Sua mensagem: " + textoCriptografado.Replace("A" , "4")
                                                               .Replace("a" , "4")
                                                               .Replace("E" , "3")
                                                               .Replace("e" , "3")
                                                               .Replace("I" , "1")
                                                               .Replace("i" , "1")
                                                               .Replace("S" , "$")
                                                               .Replace("s" , "$")
                                                               .Replace("G" , "6")
                                                               .Replace("g" , "6")
                                                               .Replace("O" , "0")
                                                               .Replace("o" , "0")
                                                               .Replace("T" , "7")
                                                               .Replace("t" , "7")
                                                               .Replace("B" , "8")
                                                               .Replace("b" , "8")
                                                               .Replace("H" , "#")
                                                               .Replace("h" , "#"));
        }
    }
}
