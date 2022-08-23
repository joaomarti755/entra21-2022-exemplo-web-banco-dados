using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Mapeamentos
{
    // DB First: Criar uma aplicação onde o banco de dados já existente
    // Code Firts: Criar um banco de dados a partir de uma aplicação existente
    // Seed: Alimentar um banco de dados com registrar para quando subir a aplicação já termos dados
    // Migration: Representação do mapeamento que será aplicado no banco de dados
    // Mapeamento: Representação da entidade em tabelas, colunas, indices....
    internal class RacaMapeamento : IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            // 2ª etapa migration: Criar o mapeamento da entidade para tabela
            builder.ToTable("racas");

            builder.HasKey(x => x.Id)
                .HasName("id");

            builder.Property(x => x.Especie)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired() //NOT NULL
                .HasColumnName("especie");

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired() //NOT NULL
                .HasColumnName("nome");

            // Populando a tabela de raça com dois registros
            builder.HasData(
                new Raca
                {
                    Id = 1,
                    Nome = "Frajola",
                    Especie = "Gato"
                },
                new Raca
                {
                    Id = 2,
                    Nome = "PiuPiu",
                    Especie = "Capivara"
                }
                );
        }
    }
}
