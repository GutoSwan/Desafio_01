using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_1
{
    public class Ubuntu
    {
        public string nome { get; set; }
        public bool dev { get; set; }
        public int idade { get; set; }
        public double altura { get; set; }
        public double peso { get; set; }

        public Ubuntu(string nome, bool dev, int idade, double altura, double peso)
        {
            this.nome = nome;
            this.dev = dev;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }
    }
}
