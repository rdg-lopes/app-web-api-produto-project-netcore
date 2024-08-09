using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace produto_microservice.Databases;

public class ProdutoDataBase : DbContext, IProdutoDataBase
{
    public DbSet<ProdutoEntity> ProdutoEntitys{get;set;}

    public ProdutoDataBase(DbContextOptions<ProdutoDataBase> options) : base(options){
    }

    public async Task<IList<ProdutoEntity>> getAllProdutosAsync()
    {
        return await this.ProdutoEntitys.ToListAsync();
    }
}
