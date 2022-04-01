using System;
using System.Collections.Generic;
using AtividadeOO.Model;

namespace AtividadeOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 1;
            List<Contato> listaTelefonica = new List<Contato>();
            
            while (option != 0)
            {
                Console.Write("SELECIONE A OPERAÇÃO\n" +
                              "1 - INSERIR CONTATO\n" +
                              "2 - DELETAR CONTATO\n" +
                              "3 - ATUALIZAR CONTATO\n" +
                              "4 - LISTAR CONTATOS\n" +
                              "0 - ENCERRAR OPERAÇÕES\n");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Contato contatoInsert = new Contato();
                        contatoInsert.createContato();
                        ListaTelefonica.insertContato(listaTelefonica, contatoInsert);
                        break;
                    
                    case 2:
                        Contato contatoDelete = new Contato();
                        contatoDelete.createContato();
                        ListaTelefonica.deleteContato(listaTelefonica, contatoDelete);
                        break;
                    
                    case 3:
                        ListaTelefonica.updateContato(listaTelefonica);
                        break;
                    case 4:
                        ListaTelefonica.listContatos(listaTelefonica);
                        break;
                }
            }
        }
    }
}
