using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio
{
	public class Client
	{
		public Client()
		{
			UsuarioRepositorio usuario = new UsuarioRepositorio();
			Produto produto = new Produto();
			Usuario user = new Usuario();


			usuario.Adicionar(user);
		}
	}
}
