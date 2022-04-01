using System;
using System.Collections.Generic;

namespace AtividadeOO.Model
{
    public class Contato
    {
        private int id;
        private String nome;
        private String numero;

        public Contato()
        {
            
        }
        
        public int Id
        {
            get => id;
        }

        public String Numero
        {
            get => numero;
            set => numero = value;
        }

        public String Nome
        {
            get => nome;
            set => nome = value;
        }

        public void createContato()
        {
            Console.Write("Digite o id de contato: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite seu nome: ");
            String nome = Console.ReadLine();
            
            Console.Write("Digite o código de área: ");
            String codArea = Console.ReadLine();
            
            Console.Write("Digite o DDD: ");
            String ddd = Console.ReadLine();
            
            Console.Write("Digite o número: ");
            String numero = Console.ReadLine();

            this.id = id;
            this.nome = nome;
            this.numero = "+" + codArea + " " + ddd + " " + numero;
        }

        protected bool Equals(Contato other)
        {
            return nome == other.nome && numero == other.numero;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Contato) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nome, numero);
        }
    }
}