using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoWebEntityFramework.Migrations
{
    public partial class WebEntityFrameworkMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Pedido_PedidoId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_PedidoId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "ItemPedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_PedidoId",
                table: "ItemPedido",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId",
                table: "ItemPedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId",
                table: "ItemPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedido_PedidoId",
                table: "ItemPedido");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "ItemPedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_PedidoId",
                table: "Pedido",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Pedido_PedidoId",
                table: "Pedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
