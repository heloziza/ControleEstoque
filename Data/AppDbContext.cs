using System;
using Microsoft.EntityFrameworkCore;
using ControleEstoque.Models;

namespace ControleEstoque.Data;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=estoque.db");
    }
}