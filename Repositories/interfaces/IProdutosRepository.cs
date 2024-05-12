using bot_System_of_Sales_Store.Models;
using bot_System_of_Sales_Store.Models.DTOs.Produtos;

namespace bot_System_of_Sales_Store.Repositories.interfaces;

public interface IProdutosRepository
{
    public IEnumerable<Produtos> GetAllNameProducts();
}