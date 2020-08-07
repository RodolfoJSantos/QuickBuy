using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
	public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
	{
		public void Configure(EntityTypeBuilder<Endereco> builder)
		{
			builder.HasKey(e => e.Id);

			builder.Property(e => e.CEP)
				.IsRequired()
				.HasMaxLength(9);

			builder
				.Property(e => e.Cidade)
				.IsRequired()
				.HasMaxLength(20);

			builder
				.Property(e => e.Estado)
				.IsRequired()
				.HasMaxLength(2);

			builder
				.Property(e => e.EnderecoComplet)
				.IsRequired()
				.HasMaxLength(20);

			builder
				.Property(e => e.Numero);
		}
	}
}
