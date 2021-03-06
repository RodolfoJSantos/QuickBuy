﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
	public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
	{
		public void Configure(EntityTypeBuilder<Pedido> builder)
		{
			builder.HasKey(p => p.Id);

			builder
				.Property(p => p.DataPedido)
				.IsRequired();

			builder
				.Property(p => p.DataPrevisaoEntrega)
				.IsRequired();

			
		}
	}
}
