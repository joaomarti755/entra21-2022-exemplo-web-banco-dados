using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Mapeamentos;
using Microsoft.EntityFrameworkCore;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados
{
    public class ClinicaVeterinariaContexto : DbContext
    {
        public DbSet<Raca> Racas { get; set; }

        public ClinicaVeterinariaContexto(
            DbContextOptions<ClinicaVeterinariaContexto> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 3ª etapa migration: Registrar o mapeamento
            /* 4ª etapa migration: Gerar a migration
                dotnet ef migrations add NOMEMIGRATION --project Repositorio -- startup-project NOMEDOPROJETO
            (por exemplo Entra21.CSharp.ClinicaVererinaria.Aplicacao) */

            /* 5ª etapa migration: A migration poderá ser aplicada de duas formas:
                - executar o comando para aplicar a migration sem a necessidade de executar a aplicação
                    dotnet ef database update
                - executar a aplicação irá aplicar a migration */
            modelBuilder.ApplyConfiguration(new RacaMapeamento());
            modelBuilder.ApplyConfiguration(new VeterinarioMapeamento());

        }
    }
}
