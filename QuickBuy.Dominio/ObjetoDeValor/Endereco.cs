using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
	public class Endereco
	{
		public int Id { get; set; }
		public string CEP { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string EnderecoComplet { get; set; }
		public int Numero { get; set; }
	}
}
