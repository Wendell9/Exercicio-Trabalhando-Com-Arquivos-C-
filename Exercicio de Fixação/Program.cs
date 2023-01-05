using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Exercicio_de_Fixação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos, pos2, quantidade;
            string nome;
            double preco;
            string path = @"D:\Usuário\Usuários\Estudo\C# Udemy\POO C#\Trabalhando com arquivos\Arquivo para exercicio\Exercicio.csv";
            string target = @"D:\Usuário\Usuários\Estudo\C# Udemy\POO C#\Trabalhando com arquivos\Arquivo para exercicio\out\summary.csv";
            string pasta = @"D:\Usuário\Usuários\Estudo\C# Udemy\POO C#\Trabalhando com arquivos\Arquivo para exercicio\out";
            try
            {
                Directory.CreateDirectory(pasta);
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    pos = line.IndexOf(',');
                    pos2 = line.LastIndexOf(',');
                    nome = line.Substring(0, pos);
                    preco = double.Parse(line.Substring(pos + 1, pos2 - (pos + 1)), CultureInfo.InvariantCulture);
                    quantidade = int.Parse(line.Substring(pos2 + 1));
                    Produto p = new Produto(nome, quantidade, preco);
                    using (StreamWriter arquivo = File.AppendText(target))
                    {
                        arquivo.WriteLine(p);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
