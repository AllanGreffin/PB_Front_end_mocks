namespace PB_Front_end_mocks.Abstracts
{
    public abstract class Place
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Tipo { get; set; }

        protected Place(Guid id, string name, string endereco, string telefone, string tipo)
        {
            Id = id;
            Name = name;
            Endereco = endereco;
            Telefone = telefone;
            Tipo = tipo;
        }
    }
}
