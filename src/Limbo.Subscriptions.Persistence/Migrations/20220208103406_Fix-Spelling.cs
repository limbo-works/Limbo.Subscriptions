using Microsoft.EntityFrameworkCore.Migrations;

namespace Limbo.Subscriptions.Persistence.Migrations {
    /// <summary>
    /// 
    /// </summary>
    public partial class FixSpelling : Migration {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_SubscriptionSystems_subscriptionSystemId",
                table: "Subscribers");

            migrationBuilder.RenameColumn(
                name: "subscriptionSystemId",
                table: "Subscribers",
                newName: "SubscriptionSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscribers_subscriptionSystemId",
                table: "Subscribers",
                newName: "IX_Subscribers_SubscriptionSystemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_SubscriptionSystems_SubscriptionSystemId",
                table: "Subscribers",
                column: "SubscriptionSystemId",
                principalTable: "SubscriptionSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_SubscriptionSystems_SubscriptionSystemId",
                table: "Subscribers");

            migrationBuilder.RenameColumn(
                name: "SubscriptionSystemId",
                table: "Subscribers",
                newName: "subscriptionSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscribers_SubscriptionSystemId",
                table: "Subscribers",
                newName: "IX_Subscribers_subscriptionSystemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_SubscriptionSystems_subscriptionSystemId",
                table: "Subscribers",
                column: "subscriptionSystemId",
                principalTable: "SubscriptionSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
