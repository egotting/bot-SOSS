namespace bot_System_of_Sales_Store.Models.DTOs.Produtos;

public record ProdutosResponseDTO(Guid Id, string NomeDoProduto, double Valor,
    double Quantidade, DateTime Data, int? Cupom, double ValorTotal);
