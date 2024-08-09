using System.Collections.Generic;
using produto_microservice.Databases;

namespace produto_microservice.Services;

public class ProdutoService : IProdutoService
{
    private IProdutoDataBase produtoDataBase;

    public ProdutoService(IProdutoDataBase produtoDataBase)
    {
        this.produtoDataBase = produtoDataBase;
    }

    public async Task<IList<ProdutoModel>> getAllProdutoAsync()
    {
        IList<ProdutoEntity> listEntity = await this.produtoDataBase.getAllProdutosAsync();
        IList<ProdutoModel> listModel = new List<ProdutoModel>();
        foreach(ProdutoEntity entity in listEntity)
        {
            listModel.Add(new ProdutoModel
            {
                id = (int)entity.id,
                nome = entity.nome
            });
        }
        return listModel;
    }
}