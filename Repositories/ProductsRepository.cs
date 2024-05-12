using bot_System_of_Sales_Store.Models;
using bot_System_of_Sales_Store.Models.DTOs.Produtos;
using bot_System_of_Sales_Store.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace bot_System_of_Sales_Store.Repositories;

public class ProductsRepository : IProdutosRepository
{
    protected readonly ModelContext _context;

    public ProductsRepository(ModelContext context)
    {
        _context = context;
    }

    public IEnumerable<Produtos> GetAllNameProducts()
    {
        return _context.Produtos.Include( p => p.NomeProduto);
    }
}