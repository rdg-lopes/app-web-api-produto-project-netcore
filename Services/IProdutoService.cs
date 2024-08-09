using System.Collections.Generic;
namespace produto_microservice.Services;

public interface IProdutoService
{
    Task<IList<ProdutoModel>> getAllProdutoAsync();
}