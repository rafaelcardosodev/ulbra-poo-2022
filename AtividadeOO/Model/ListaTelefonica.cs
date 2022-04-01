using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AtividadeOO.Model
{
    public static class ListaTelefonica
    {

        public static void insertContato(List<Contato> listaTelefonica, Contato contato)
        {
            listaTelefonica.Add(contato);
        }

        public static void deleteContato(List<Contato> listaTelefonica, Contato contato) 
        {
            for (int i = 0; i < listaTelefonica.Count; i++)
            {
                if (listaTelefonica[i].Nome.Equals(contato.Nome) && listaTelefonica[i].Numero.Equals(contato.Numero))
                {
                    listaTelefonica.Remove(contato);
                }
            }
        }
        
        public static void updateContato(List<Contato> listaTelefonica)
        {
            Console.Write("Digite o id do contato que deseja atualizar: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("-- Digite as novas informações --\n\n");

            foreach (var contato in listaTelefonica)
            {
                if (contato.Id == id)
                {
                    Console.Write("Digite o nome: ");
                    String nome = Console.ReadLine();
                    contato.Nome = nome;
            
                    Console.Write("Digite o numero (cod-area + ddd + numero): ");
                    String numero = Console.ReadLine();
                    contato.Numero = numero;
                }
            }
            
            
        }

        public static void listContatos(List<Contato> listaTelefonica)
        {
            foreach (var contato in listaTelefonica)
            {
                Console.WriteLine("nome: " + contato.Nome + " | " + "numero: " + contato.Numero + "\n");
            }
        }
    }
}