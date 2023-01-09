using FundamentoPessoa.Models;

int quantidadeEmEstoque = 3;

int quantidadeCompra = 4;

bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;



Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade na compra: {quantidadeCompra}");
Console.WriteLine($"E possivel realizar a venda?: {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda Invalida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Desculpe, nao temos a quantidade desejada em estoque");

}


