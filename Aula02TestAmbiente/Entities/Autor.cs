namespace Aula02TestAmbiente.Entities
{
    public class Autor
    {
        private int id;
        private string nome;

        public Autor(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
    }
}