using System;

namespace Orientacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            usuario.setNome("gabriel");
            Console.WriteLine($"Nome do usurio:{usuario.getNome()}");

            Produto produto1 = new Produto();
            produto1.Nome = "Agua";
            produto1.Preco = 3.5;
            Console.WriteLine($"Nome do Produto1: {produto1.Nome}");

            Produto produto2 = new Produto
            {
                Nome = "Coca",
                Preco = 5
            };
            Console.WriteLine($"Nome do Produto2: {produto2.Nome}");
        }
    }
}
