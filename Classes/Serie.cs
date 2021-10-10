namespace Malta.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Sinopse { get; set; }
        private int Ano { get; set; }
        private int Temporadas { get; set; }
        private int Episodios { get; set; }
        private int Classificacao { get; set; }
        private bool Excluido {get; set;}


        public Serie(int id, Genero genero, string titulo, string sinopse, int ano, int temporadas, int episodios, int classificacao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.Ano = ano;
            this.Temporadas = temporadas;
            this.Episodios = episodios;
            this.Classificacao = classificacao; 
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Sinopse: " + this.Sinopse + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Temporadas: " + this.Temporadas + Environment.NewLine;
            retorno += "Episodios: " + this.Episodios + Environment.NewLine;
            retorno += "Classificação: " + this.Classificacao + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir() {
            this.Excluido = true;
        }
    }
}