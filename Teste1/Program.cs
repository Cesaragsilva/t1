using System;
using System.Text;

namespace Teste1
{
    class Program
    {
        //TODO
        /* 
         * Desenvolva um método que receba a string "abbcbbb". O retorno desse método deverá ser "abcb", 
         * logo o próximo caracter não deverá ser igual ao anterior, o método deve ser capaz de tratar qualquer string.
        */
        static string RemoverSequenciaRepetida(string str)
        {
            if(str.Length <= 1)
            {
                return str;
            }

            StringBuilder novaStr = new StringBuilder();
            novaStr.Append(str[0]);

            for (int x = 1; x < str.Length; x++)
            {
                if (str[x - 1] != str[x])
                    novaStr.Append(str[x]);
            }

            return novaStr.ToString();
        }

        static void Main(string[] args)
        {
            String avaliacao = "abbcbbb";
            Console.WriteLine(RemoverSequenciaRepetida(avaliacao));
        }

    }
}
