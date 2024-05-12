using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.VisualBasic;

namespace bot_System_of_Sales_Store.Models;

public class Produtos
{
    [Key]public Guid Id { get; set; }
    [Required][DisplayName("Nome do Produto")]public string NomeProduto { get; set; }
    [Required] [DisplayName("Preço")]public double Valor { get; set; }
    [Required][DisplayName("Quantidade de produtos")]public double Quantidade { get; set; }
    public DateTime Data { get; set; }
    
    [DisplayName("Cupom")]public int? Cupom { get; set; }
    
    [Required]public double ValorTotal { get; set; }
    
    public Produtos(string nomeProduto, double valor, double quantidade, int? cupom, double valorTotal)
    {
        Id = new Guid();
        NomeProduto = nomeProduto;
        Valor = valor;
        Quantidade = quantidade;
        Data = DateTime.Today;
        Cupom = cupom;
        ValorTotal = valorTotal;
    }

    public Produtos()
    {
    }
}