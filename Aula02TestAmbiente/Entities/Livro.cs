using System;
using System.Runtime.CompilerServices;

namespace Aula02TestAmbiente.Entities
{
    public class Livro
    {
        private int id;
        private string titulo;
        private decimal valor;
        private DateTime dataPublicacao;
        private Autor autor;
        
        public Livro(){}

        public Livro(int id, string titulo)
        {
            this.id = id;
            this.titulo = titulo;
        }

        public Livro(int id, string titulo, Autor autor)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetTitulo()
        {
            return this.titulo;
        }

        public void SetTitutlo(string titulo)
        {
            this.titulo = titulo;
        }

        public decimal GetValor()
        {
            return this.valor;
        }

        public void SetValor(decimal valor)
        {
            this.valor = valor;
        }

        public DateTime GetDataPublicacao()
        {
            return this.dataPublicacao;
        }

        public void SetDataPublicacao(DateTime dataPublicacao)
        {
            this.dataPublicacao = dataPublicacao;
        }
        
    }
}