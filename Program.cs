using ControleEstoque.Data;
using ControleEstoque.Models;

AppDbContext context = new AppDbContext();

Produto produto = new Produto
{
    Nome = "Escova de Dente",
    Preco = 8.99M,
    Quantidade = 12
};

context.Produtos.Add(produto);
context.SaveChanges();

List<Produto> listaProdutos = context.Produtos.ToList();

Console.WriteLine("\n--- Lista de Produtos Cadastrados ---");
foreach(Produto p in listaProdutos)
{
    Console.WriteLine($"Produto {p.Nome} está saindo apenas por R$ {p.Preco} e ainda há {p.Quantidade} em estoque!");
}