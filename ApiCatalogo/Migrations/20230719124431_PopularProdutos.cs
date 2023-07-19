using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                " VALUES ('COCA-COLA','REFRIGERANTE 350ML',5.45,'coca.png',1, GETDATE(), 1)");

            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                " VALUES ('LANCHE DE ATUM','ATUM COM MAIONESE',12.50,'atum.png',5, GETDATE(), 2)");
             
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                " VALUES ('PUDIM DE LEITE','PUDIM DE LEITO CONDENSADO 100g',12.45,'pudim.png',8, GETDATE(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos");
        }
    }
}
