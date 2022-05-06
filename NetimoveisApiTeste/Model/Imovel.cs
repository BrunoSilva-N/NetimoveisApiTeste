namespace NetimoveisApiTeste.Model
{
    public class Imovel
    {
        public int id { get; set; }
        public string Tipo { get; set; }
        public string ValorVenda { get; set; }
        public string ValorLocacao { get; set; }

        public string Endereco { get; set; }
        public string numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
