using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using produto_microservice.Services;

namespace produto_microservice.Controllers;

[ApiController]
[Route("/produto")]
public class ProdutoController
{
    private IProdutoService service;

    public ProdutoController(IProdutoService service)
    {
        this.service = service;
    }

    [HttpGet]
    public async Task<IList<ProdutoModelView>> getAllProdutosAsync()
    {
        IList<ProdutoModel> listProdutos = await this.service.getAllProdutoAsync();
        IList<ProdutoModelView> listResult = new List<ProdutoModelView>();
        foreach(ProdutoModel entity in listProdutos)
        {
            listResult.Add(new ProdutoModelView(){
                id = entity.id,
                nome = entity.nome
            });
        }
        return listResult;
    }

}