using System;
using System.Collections.Generic;

namespace Interfaces.Classes
{
    public class Carrinho : ICarrinho
    {   
        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int _codigo, Produto produto)
        {
            // Lambda
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
            carrinho.Find(x => x.Codigo == _codigo).Codigo = produto.Codigo;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach(Produto p in carrinho)
            {   
                Console.WriteLine($"Produto: {p.Nome}");
                Console.WriteLine($" Preço; {p.Preco}");
                Console.WriteLine($" Código: {p.Codigo}");
            }
        }
    }
}