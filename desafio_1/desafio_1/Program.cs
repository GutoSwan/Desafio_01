using desafio_1;
using System;

namespace Desafio
{
    class program
    {
        static void Main(string[] args)
        {
            Ubuntu ubuntinho = new Ubuntu("chubs silva", true, 65, 1.50, 50);
            Ubuntu ubuntao = new Ubuntu("orlando santos", false, 24, 1.80, 130);
            Ubuntu ubuntaco = new Ubuntu("scooby silva", true, 22, 1.90, 70);

            int somaIdades = ubuntinho.idade + ubuntao.idade + ubuntaco.idade;
            Console.WriteLine(somaIdades);
            Console.ReadKey();

            String nomePessoa;
            Console.WriteLine($"{ubuntinho.nome}\n{ubuntao.nome}\n{ubuntaco.nome}");

            Console.WriteLine($"imc do chubs é: {ubuntinho.peso / (ubuntinho.altura * ubuntinho.altura)}");
            Console.WriteLine($"imc do orlando é: {ubuntao.peso / (ubuntao.altura * ubuntao.altura)}");
            Console.WriteLine($"imc do scooby é: {ubuntaco.peso/  (ubuntaco.altura*ubuntaco.altura)}");

            var list = new List<Ubuntu>(){
                ubuntinho,ubuntao,ubuntaco
            };

            list.ForEach(x =>
            {
                if(x.dev == true)
                {
                    Console.WriteLine($"{x.nome} é dev");
                }
                else
                {
                    Console.WriteLine($"{x.nome} não é dev");
                }
                

                if (x.nome.Contains("silva"))
                {
                    Console.WriteLine($"{x.nome} é silva");

                }
                else
                {
                    Console.WriteLine($"{x.nome} não é silva");
                }
            });
        }
    }
 
}
