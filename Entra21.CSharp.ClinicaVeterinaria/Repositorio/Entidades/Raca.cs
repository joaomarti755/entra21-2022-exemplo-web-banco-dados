namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades
{
    // Entidades: são representações das tabelas para classe de objetos
    public class Raca : EntidadeBase
    {
        // 1ª etapa migration: criar a entidade
        public string Nome { get; set; }

        public string Especie { get; set; }
    }
}
