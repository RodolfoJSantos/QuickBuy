using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
	public class Entidade
	{
		private List<string> _mensagemValidacao;
		private List<string> MensagemValidacao
		{
			get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
		}

		public bool EhValido
		{
			get { return !MensagemValidacao.Any(); }
		}
		public void AdicionarCritica(string mensagem)
		{
			MensagemValidacao.Add(mensagem);
		}

		public void LimparMensagens()
		{
			MensagemValidacao.Clear();
		}
	}
}
