using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Limbo.Subscriptions.Persistence.Migrations {
    public partial class Inital : Migration {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsletterQueues",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_NewsletterQueues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionItems",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_SubscriptionItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionSystems",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_SubscriptionSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategorySubscriptionItem",
                columns: table => new {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_CategorySubscriptionItem", x => new { x.CategoriesId, x.SubscriptionItemsId });
                    table.ForeignKey(
                        name: "FK_CategorySubscriptionItem_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorySubscriptionItem_SubscriptionItems_SubscriptionItemsId",
                        column: x => x.SubscriptionItemsId,
                        principalTable: "SubscriptionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsletterQueueSubscriptionItem",
                columns: table => new {
                    NewsletterQueuesId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_NewsletterQueueSubscriptionItem", x => new { x.NewsletterQueuesId, x.SubscriptionItemsId });
                    table.ForeignKey(
                        name: "FK_NewsletterQueueSubscriptionItem_NewsletterQueues_NewsletterQueuesId",
                        column: x => x.NewsletterQueuesId,
                        principalTable: "NewsletterQueues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsletterQueueSubscriptionItem_SubscriptionItems_SubscriptionItemsId",
                        column: x => x.SubscriptionItemsId,
                        principalTable: "SubscriptionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    subscriptionSystemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscribers_SubscriptionSystems_subscriptionSystemId",
                        column: x => x.subscriptionSystemId,
                        principalTable: "SubscriptionSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategorySubscriber",
                columns: table => new {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    SubscribersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_CategorySubscriber", x => new { x.CategoriesId, x.SubscribersId });
                    table.ForeignKey(
                        name: "FK_CategorySubscriber_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorySubscriber_Subscribers_SubscribersId",
                        column: x => x.SubscribersId,
                        principalTable: "Subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriberSubscriptionItem",
                columns: table => new {
                    SubscribersId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_SubscriberSubscriptionItem", x => new { x.SubscribersId, x.SubscriptionItemsId });
                    table.ForeignKey(
                        name: "FK_SubscriberSubscriptionItem_Subscribers_SubscribersId",
                        column: x => x.SubscribersId,
                        principalTable: "Subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriberSubscriptionItem_SubscriptionItems_SubscriptionItemsId",
                        column: x => x.SubscriptionItemsId,
                        principalTable: "SubscriptionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorySubscriber_SubscribersId",
                table: "CategorySubscriber",
                column: "SubscribersId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySubscriptionItem_SubscriptionItemsId",
                table: "CategorySubscriptionItem",
                column: "SubscriptionItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsletterQueueSubscriptionItem_SubscriptionItemsId",
                table: "NewsletterQueueSubscriptionItem",
                column: "SubscriptionItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_subscriptionSystemId",
                table: "Subscribers",
                column: "subscriptionSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberSubscriptionItem_SubscriptionItemsId",
                table: "SubscriberSubscriptionItem",
                column: "SubscriptionItemsId");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "CategorySubscriber");

            migrationBuilder.DropTable(
                name: "CategorySubscriptionItem");

            migrationBuilder.DropTable(
                name: "NewsletterQueueSubscriptionItem");

            migrationBuilder.DropTable(
                name: "SubscriberSubscriptionItem");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "NewsletterQueues");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropTable(
                name: "SubscriptionItems");

            migrationBuilder.DropTable(
                name: "SubscriptionSystems");
        }
    }
}
