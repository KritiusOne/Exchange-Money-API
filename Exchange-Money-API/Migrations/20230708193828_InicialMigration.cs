using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exchange_Money_API.Migrations
{
    /// <inheritdoc />
    public partial class InicialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acreedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acreedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divisas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMoneda = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoTransaccion = table.Column<bool>(type: "bit", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoSellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTipoSeller = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_Role_id",
                        column: x => x.Role_id,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSeller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoSeller_id = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sellers_TipoSellers_TipoSeller_id",
                        column: x => x.TipoSeller_id,
                        principalTable: "TipoSellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deudas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorDeuda = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: false),
                    Acreedor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deudas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deudas_Acreedores_Acreedor_id",
                        column: x => x.Acreedor_id,
                        principalTable: "Acreedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deudas_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingresos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    ValorIngreso = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo_id = table.Column<int>(type: "int", nullable: false),
                    Moneda_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingresos_Divisas_Moneda_id",
                        column: x => x.Moneda_id,
                        principalTable: "Divisas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingresos_Tipos_Tipo_id",
                        column: x => x.Tipo_id,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingresos_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Objetivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objetivos_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Egresos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_id = table.Column<int>(type: "int", nullable: false),
                    ValorEgreso = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Seller_id = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Moneda_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egresos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Egresos_Divisas_Moneda_id",
                        column: x => x.Moneda_id,
                        principalTable: "Divisas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Egresos_Sellers_Seller_id",
                        column: x => x.Seller_id,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Egresos_Tipos_Tipo_id",
                        column: x => x.Tipo_id,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Egresos_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ahorros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    Moneda_id = table.Column<int>(type: "int", nullable: false),
                    Objetivo_id = table.Column<int>(type: "int", nullable: false),
                    UserEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ahorros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ahorros_Divisas_Moneda_id",
                        column: x => x.Moneda_id,
                        principalTable: "Divisas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ahorros_Objetivos_Objetivo_id",
                        column: x => x.Objetivo_id,
                        principalTable: "Objetivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ahorros_Users_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ahorros_Moneda_id",
                table: "Ahorros",
                column: "Moneda_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ahorros_Objetivo_id",
                table: "Ahorros",
                column: "Objetivo_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ahorros_UserEntityId",
                table: "Ahorros",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Deudas_Acreedor_id",
                table: "Deudas",
                column: "Acreedor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Deudas_User_id",
                table: "Deudas",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Egresos_Moneda_id",
                table: "Egresos",
                column: "Moneda_id");

            migrationBuilder.CreateIndex(
                name: "IX_Egresos_Seller_id",
                table: "Egresos",
                column: "Seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Egresos_Tipo_id",
                table: "Egresos",
                column: "Tipo_id");

            migrationBuilder.CreateIndex(
                name: "IX_Egresos_User_id",
                table: "Egresos",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_Moneda_id",
                table: "Ingresos",
                column: "Moneda_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_Tipo_id",
                table: "Ingresos",
                column: "Tipo_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_User_id",
                table: "Ingresos",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Objetivos_User_id",
                table: "Objetivos",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_TipoSeller_id",
                table: "Sellers",
                column: "TipoSeller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_id",
                table: "Users",
                column: "Role_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ahorros");

            migrationBuilder.DropTable(
                name: "Deudas");

            migrationBuilder.DropTable(
                name: "Egresos");

            migrationBuilder.DropTable(
                name: "Ingresos");

            migrationBuilder.DropTable(
                name: "Objetivos");

            migrationBuilder.DropTable(
                name: "Acreedores");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Divisas");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TipoSellers");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
