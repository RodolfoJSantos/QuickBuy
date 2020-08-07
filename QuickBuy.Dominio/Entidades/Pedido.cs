using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
	public class Pedido
	{
		public int Id { get; set; }
		public DateTime DataPedido { get; set; }
		public int UsuarioId { get; set; }
		public virtual Usuario Usuario { get; set; }
		public Endereco Endereco { get; set; }
		public DateTime DataPrevisaoEntrega { get; set; }
		public virtual ICollection<ItemPedido> ItensPedido { get; set; }
	}
}
