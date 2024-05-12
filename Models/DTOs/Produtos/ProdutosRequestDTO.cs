using System.ComponentModel.DataAnnotations;
using System.Data;

namespace bot_System_of_Sales_Store.Models.DTOs.Produtos;

public record ProdutosRequestDTO(
    [Required(ErrorMessage = "Voce precisa por o nome do produto para poder comprar")]
    string NomeProduto);