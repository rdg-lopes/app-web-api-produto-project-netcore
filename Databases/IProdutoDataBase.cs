using System.Collections.Generic;

namespace produto_microservice.Databases;

public interface IProdutoDataBase
{
    Task<IList<ProdutoEntity>> getAllProdutosAsync();
}