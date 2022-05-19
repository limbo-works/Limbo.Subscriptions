using Microsoft.EntityFrameworkCore.Migrations;

namespace Limbo.Subscriptions.Persistence.Migrations {
    public partial class NamingPrefix : Migration {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubscriber_Categories_CategoriesId",
                table: "CategorySubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubscriber_Subscribers_SubscribersId",
                table: "CategorySubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubscriptionItem_Categories_CategoriesId",
                table: "CategorySubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubscriptionItem_SubscriptionItems_SubscriptionItemsId",
                table: "CategorySubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsletterQueueSubscriptionItem_NewsletterQueues_NewsletterQueuesId",
                table: "NewsletterQueueSubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsletterQueueSubscriptionItem_SubscriptionItems_SubscriptionItemsId",
                table: "NewsletterQueueSubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_SubscriptionSystems_SubscriptionSystemId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberSubscriptionItem_Subscribers_SubscribersId",
                table: "SubscriberSubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberSubscriptionItem_SubscriptionItems_SubscriptionItemsId",
                table: "SubscriberSubscriptionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionSystems",
                table: "SubscriptionSystems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionItems",
                table: "SubscriptionItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriberSubscriptionItem",
                table: "SubscriberSubscriptionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscribers",
                table: "Subscribers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsletterQueueSubscriptionItem",
                table: "NewsletterQueueSubscriptionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsletterQueues",
                table: "NewsletterQueues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategorySubscriptionItem",
                table: "CategorySubscriptionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategorySubscriber",
                table: "CategorySubscriber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "SubscriptionSystems",
                newName: "Limbo_Subscription_SubscriptionSystems");

            migrationBuilder.RenameTable(
                name: "SubscriptionItems",
                newName: "Limbo_Subscription_SubscriptionItems");

            migrationBuilder.RenameTable(
                name: "SubscriberSubscriptionItem",
                newName: "Limbo_Subscription_SubscriberSubscriptionItem");

            migrationBuilder.RenameTable(
                name: "Subscribers",
                newName: "Limbo_Subscription_Subscribers");

            migrationBuilder.RenameTable(
                name: "NewsletterQueueSubscriptionItem",
                newName: "Limbo_Subscription_NewsletterQueueSubscriptionItem");

            migrationBuilder.RenameTable(
                name: "NewsletterQueues",
                newName: "Limbo_Subscription_NewsletterQueues");

            migrationBuilder.RenameTable(
                name: "CategorySubscriptionItem",
                newName: "Limbo_Subscription_CategorySubscriptionItem");

            migrationBuilder.RenameTable(
                name: "CategorySubscriber",
                newName: "Limbo_Subscription_CategorySubscriber");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Limbo_Subscription_Categories");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriberSubscriptionItem_SubscriptionItemsId",
                table: "Limbo_Subscription_SubscriberSubscriptionItem",
                newName: "IX_Limbo_Subscription_SubscriberSubscriptionItem_SubscriptionItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscribers_SubscriptionSystemId",
                table: "Limbo_Subscription_Subscribers",
                newName: "IX_Limbo_Subscription_Subscribers_SubscriptionSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_NewsletterQueueSubscriptionItem_SubscriptionItemsId",
                table: "Limbo_Subscription_NewsletterQueueSubscriptionItem",
                newName: "IX_Limbo_Subscription_NewsletterQueueSubscriptionItem_SubscriptionItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySubscriptionItem_SubscriptionItemsId",
                table: "Limbo_Subscription_CategorySubscriptionItem",
                newName: "IX_Limbo_Subscription_CategorySubscriptionItem_SubscriptionItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySubscriber_SubscribersId",
                table: "Limbo_Subscription_CategorySubscriber",
                newName: "IX_Limbo_Subscription_CategorySubscriber_SubscribersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_Subscription_SubscriptionSystems",
                table: "Limbo_Subscription_SubscriptionSystems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_Subscription_SubscriptionItems",
                table: "Limbo_Subscription_SubscriptionItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_Subscription_SubscriberSubscriptionItem",
                table: "Limbo_Subscription_SubscriberSubscriptionItem",
                columns: new[] { "SubscribersId", "SubscriptionItemsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_Subscription_Subscribers",
                table: "Limbo_Subscription_Subscribers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_Subscription_NewsletterQueueSubscriptionItem",
                table: "Limbo_Subscription_NewsletterQueueSubscriptionItem",
                columns: new[] { "NewsletterQueuesId", "SubscriptionItemsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_Subscription_NewsletterQueues",
                table: "Limbo_Subscription_NewsletterQueues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_Subscription_CategorySubscriptionItem",
                table: "Limbo_Subscription_CategorySubscriptionItem",
                columns: new[] { "CategoriesId", "SubscriptionItemsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_Subscription_CategorySubscriber",
                table: "Limbo_Subscription_CategorySubscriber",
                columns: new[] { "CategoriesId", "SubscribersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_Subscription_Categories",
                table: "Limbo_Subscription_Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_Subscription_CategorySubscriber_Limbo_Subscription_Categories_CategoriesId",
                table: "Limbo_Subscription_CategorySubscriber",
                column: "CategoriesId",
                principalTable: "Limbo_Subscription_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_Subscription_CategorySubscriber_Limbo_Subscription_Subscribers_SubscribersId",
                table: "Limbo_Subscription_CategorySubscriber",
                column: "SubscribersId",
                principalTable: "Limbo_Subscription_Subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_Subscription_CategorySubscriptionItem_Limbo_Subscription_Categories_CategoriesId",
                table: "Limbo_Subscription_CategorySubscriptionItem",
                column: "CategoriesId",
                principalTable: "Limbo_Subscription_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_Subscription_CategorySubscriptionItem_Limbo_Subscription_SubscriptionItems_SubscriptionItemsId",
                table: "Limbo_Subscription_CategorySubscriptionItem",
                column: "SubscriptionItemsId",
                principalTable: "Limbo_Subscription_SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_Subscription_NewsletterQueueSubscriptionItem_Limbo_Subscription_NewsletterQueues_NewsletterQueuesId",
                table: "Limbo_Subscription_NewsletterQueueSubscriptionItem",
                column: "NewsletterQueuesId",
                principalTable: "Limbo_Subscription_NewsletterQueues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_Subscription_NewsletterQueueSubscriptionItem_Limbo_Subscription_SubscriptionItems_SubscriptionItemsId",
                table: "Limbo_Subscription_NewsletterQueueSubscriptionItem",
                column: "SubscriptionItemsId",
                principalTable: "Limbo_Subscription_SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_Subscription_Subscribers_Limbo_Subscription_SubscriptionSystems_SubscriptionSystemId",
                table: "Limbo_Subscription_Subscribers",
                column: "SubscriptionSystemId",
                principalTable: "Limbo_Subscription_SubscriptionSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_Subscription_SubscriberSubscriptionItem_Limbo_Subscription_Subscribers_SubscribersId",
                table: "Limbo_Subscription_SubscriberSubscriptionItem",
                column: "SubscribersId",
                principalTable: "Limbo_Subscription_Subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_Subscription_SubscriberSubscriptionItem_Limbo_Subscription_SubscriptionItems_SubscriptionItemsId",
                table: "Limbo_Subscription_SubscriberSubscriptionItem",
                column: "SubscriptionItemsId",
                principalTable: "Limbo_Subscription_SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_Subscription_CategorySubscriber_Limbo_Subscription_Categories_CategoriesId",
                table: "Limbo_Subscription_CategorySubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_Subscription_CategorySubscriber_Limbo_Subscription_Subscribers_SubscribersId",
                table: "Limbo_Subscription_CategorySubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_Subscription_CategorySubscriptionItem_Limbo_Subscription_Categories_CategoriesId",
                table: "Limbo_Subscription_CategorySubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_Subscription_CategorySubscriptionItem_Limbo_Subscription_SubscriptionItems_SubscriptionItemsId",
                table: "Limbo_Subscription_CategorySubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_Subscription_NewsletterQueueSubscriptionItem_Limbo_Subscription_NewsletterQueues_NewsletterQueuesId",
                table: "Limbo_Subscription_NewsletterQueueSubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_Subscription_NewsletterQueueSubscriptionItem_Limbo_Subscription_SubscriptionItems_SubscriptionItemsId",
                table: "Limbo_Subscription_NewsletterQueueSubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_Subscription_Subscribers_Limbo_Subscription_SubscriptionSystems_SubscriptionSystemId",
                table: "Limbo_Subscription_Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_Subscription_SubscriberSubscriptionItem_Limbo_Subscription_Subscribers_SubscribersId",
                table: "Limbo_Subscription_SubscriberSubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_Subscription_SubscriberSubscriptionItem_Limbo_Subscription_SubscriptionItems_SubscriptionItemsId",
                table: "Limbo_Subscription_SubscriberSubscriptionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_Subscription_SubscriptionSystems",
                table: "Limbo_Subscription_SubscriptionSystems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_Subscription_SubscriptionItems",
                table: "Limbo_Subscription_SubscriptionItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_Subscription_SubscriberSubscriptionItem",
                table: "Limbo_Subscription_SubscriberSubscriptionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_Subscription_Subscribers",
                table: "Limbo_Subscription_Subscribers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_Subscription_NewsletterQueueSubscriptionItem",
                table: "Limbo_Subscription_NewsletterQueueSubscriptionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_Subscription_NewsletterQueues",
                table: "Limbo_Subscription_NewsletterQueues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_Subscription_CategorySubscriptionItem",
                table: "Limbo_Subscription_CategorySubscriptionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_Subscription_CategorySubscriber",
                table: "Limbo_Subscription_CategorySubscriber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_Subscription_Categories",
                table: "Limbo_Subscription_Categories");

            migrationBuilder.RenameTable(
                name: "Limbo_Subscription_SubscriptionSystems",
                newName: "SubscriptionSystems");

            migrationBuilder.RenameTable(
                name: "Limbo_Subscription_SubscriptionItems",
                newName: "SubscriptionItems");

            migrationBuilder.RenameTable(
                name: "Limbo_Subscription_SubscriberSubscriptionItem",
                newName: "SubscriberSubscriptionItem");

            migrationBuilder.RenameTable(
                name: "Limbo_Subscription_Subscribers",
                newName: "Subscribers");

            migrationBuilder.RenameTable(
                name: "Limbo_Subscription_NewsletterQueueSubscriptionItem",
                newName: "NewsletterQueueSubscriptionItem");

            migrationBuilder.RenameTable(
                name: "Limbo_Subscription_NewsletterQueues",
                newName: "NewsletterQueues");

            migrationBuilder.RenameTable(
                name: "Limbo_Subscription_CategorySubscriptionItem",
                newName: "CategorySubscriptionItem");

            migrationBuilder.RenameTable(
                name: "Limbo_Subscription_CategorySubscriber",
                newName: "CategorySubscriber");

            migrationBuilder.RenameTable(
                name: "Limbo_Subscription_Categories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Limbo_Subscription_SubscriberSubscriptionItem_SubscriptionItemsId",
                table: "SubscriberSubscriptionItem",
                newName: "IX_SubscriberSubscriptionItem_SubscriptionItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_Limbo_Subscription_Subscribers_SubscriptionSystemId",
                table: "Subscribers",
                newName: "IX_Subscribers_SubscriptionSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_Limbo_Subscription_NewsletterQueueSubscriptionItem_SubscriptionItemsId",
                table: "NewsletterQueueSubscriptionItem",
                newName: "IX_NewsletterQueueSubscriptionItem_SubscriptionItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_Limbo_Subscription_CategorySubscriptionItem_SubscriptionItemsId",
                table: "CategorySubscriptionItem",
                newName: "IX_CategorySubscriptionItem_SubscriptionItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_Limbo_Subscription_CategorySubscriber_SubscribersId",
                table: "CategorySubscriber",
                newName: "IX_CategorySubscriber_SubscribersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionSystems",
                table: "SubscriptionSystems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionItems",
                table: "SubscriptionItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriberSubscriptionItem",
                table: "SubscriberSubscriptionItem",
                columns: new[] { "SubscribersId", "SubscriptionItemsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscribers",
                table: "Subscribers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsletterQueueSubscriptionItem",
                table: "NewsletterQueueSubscriptionItem",
                columns: new[] { "NewsletterQueuesId", "SubscriptionItemsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsletterQueues",
                table: "NewsletterQueues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategorySubscriptionItem",
                table: "CategorySubscriptionItem",
                columns: new[] { "CategoriesId", "SubscriptionItemsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategorySubscriber",
                table: "CategorySubscriber",
                columns: new[] { "CategoriesId", "SubscribersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubscriber_Categories_CategoriesId",
                table: "CategorySubscriber",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubscriber_Subscribers_SubscribersId",
                table: "CategorySubscriber",
                column: "SubscribersId",
                principalTable: "Subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubscriptionItem_Categories_CategoriesId",
                table: "CategorySubscriptionItem",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubscriptionItem_SubscriptionItems_SubscriptionItemsId",
                table: "CategorySubscriptionItem",
                column: "SubscriptionItemsId",
                principalTable: "SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsletterQueueSubscriptionItem_NewsletterQueues_NewsletterQueuesId",
                table: "NewsletterQueueSubscriptionItem",
                column: "NewsletterQueuesId",
                principalTable: "NewsletterQueues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsletterQueueSubscriptionItem_SubscriptionItems_SubscriptionItemsId",
                table: "NewsletterQueueSubscriptionItem",
                column: "SubscriptionItemsId",
                principalTable: "SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_SubscriptionSystems_SubscriptionSystemId",
                table: "Subscribers",
                column: "SubscriptionSystemId",
                principalTable: "SubscriptionSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberSubscriptionItem_Subscribers_SubscribersId",
                table: "SubscriberSubscriptionItem",
                column: "SubscribersId",
                principalTable: "Subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberSubscriptionItem_SubscriptionItems_SubscriptionItemsId",
                table: "SubscriberSubscriptionItem",
                column: "SubscriptionItemsId",
                principalTable: "SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
