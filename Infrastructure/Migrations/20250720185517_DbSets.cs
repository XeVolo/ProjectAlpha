using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversation_Project_ProjectId",
                table: "Conversation");

            migrationBuilder.DropForeignKey(
                name: "FK_ConversationMember_Conversation_ConversationId",
                table: "ConversationMember");

            migrationBuilder.DropForeignKey(
                name: "FK_ConversationMember_Users_UserId",
                table: "ConversationMember");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitation_Project_ProjectId",
                table: "Invitation");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitation_Users_UserId",
                table: "Invitation");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Conversation_ConversationId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Users_UserId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectFile_Project_ProjectId",
                table: "ProjectFile");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectFile_Users_UserId",
                table: "ProjectFile");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMember_Project_ProjectId",
                table: "ProjectMember");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMember_Users_UserId",
                table: "ProjectMember");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTask_ToDoList_ToDoListId",
                table: "ProjectTask");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTask_Users_UserId",
                table: "ProjectTask");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskDistribution_ProjectTask_TaskId",
                table: "TaskDistribution");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskDistribution_Users_UserId",
                table: "TaskDistribution");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoList_Project_ProjectId",
                table: "ToDoList");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoList_Users_UserId",
                table: "ToDoList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskDistribution",
                table: "TaskDistribution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectTask",
                table: "ProjectTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectMember",
                table: "ProjectMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectFile",
                table: "ProjectFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invitation",
                table: "Invitation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConversationMember",
                table: "ConversationMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conversation",
                table: "Conversation");

            migrationBuilder.RenameTable(
                name: "ToDoList",
                newName: "ToDoLists");

            migrationBuilder.RenameTable(
                name: "TaskDistribution",
                newName: "TaskDistributions");

            migrationBuilder.RenameTable(
                name: "ProjectTask",
                newName: "ProjectTasks");

            migrationBuilder.RenameTable(
                name: "ProjectMember",
                newName: "ProjectMembers");

            migrationBuilder.RenameTable(
                name: "ProjectFile",
                newName: "ProjectFiles");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameTable(
                name: "Invitation",
                newName: "Invitations");

            migrationBuilder.RenameTable(
                name: "ConversationMember",
                newName: "ConversationMembers");

            migrationBuilder.RenameTable(
                name: "Conversation",
                newName: "Conversations");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoList_UserId",
                table: "ToDoLists",
                newName: "IX_ToDoLists_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoList_ProjectId",
                table: "ToDoLists",
                newName: "IX_ToDoLists_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskDistribution_UserId",
                table: "TaskDistributions",
                newName: "IX_TaskDistributions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskDistribution_TaskId",
                table: "TaskDistributions",
                newName: "IX_TaskDistributions_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTask_UserId",
                table: "ProjectTasks",
                newName: "IX_ProjectTasks_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTask_ToDoListId",
                table: "ProjectTasks",
                newName: "IX_ProjectTasks_ToDoListId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectMember_UserId",
                table: "ProjectMembers",
                newName: "IX_ProjectMembers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectMember_ProjectId",
                table: "ProjectMembers",
                newName: "IX_ProjectMembers_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectFile_UserId",
                table: "ProjectFiles",
                newName: "IX_ProjectFiles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectFile_ProjectId",
                table: "ProjectFiles",
                newName: "IX_ProjectFiles_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_UserId",
                table: "Messages",
                newName: "IX_Messages_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_ConversationId",
                table: "Messages",
                newName: "IX_Messages_ConversationId");

            migrationBuilder.RenameIndex(
                name: "IX_Invitation_UserId",
                table: "Invitations",
                newName: "IX_Invitations_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Invitation_ProjectId",
                table: "Invitations",
                newName: "IX_Invitations_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ConversationMember_UserId",
                table: "ConversationMembers",
                newName: "IX_ConversationMembers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ConversationMember_ConversationId",
                table: "ConversationMembers",
                newName: "IX_ConversationMembers_ConversationId");

            migrationBuilder.RenameIndex(
                name: "IX_Conversation_ProjectId",
                table: "Conversations",
                newName: "IX_Conversations_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskDistributions",
                table: "TaskDistributions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectTasks",
                table: "ProjectTasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectMembers",
                table: "ProjectMembers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectFiles",
                table: "ProjectFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invitations",
                table: "Invitations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConversationMembers",
                table: "ConversationMembers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conversations",
                table: "Conversations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConversationMembers_Conversations_ConversationId",
                table: "ConversationMembers",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConversationMembers_Users_UserId",
                table: "ConversationMembers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Conversations_Projects_ProjectId",
                table: "Conversations",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invitations_Projects_ProjectId",
                table: "Invitations",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invitations_Users_UserId",
                table: "Invitations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Conversations_ConversationId",
                table: "Messages",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectFiles_Projects_ProjectId",
                table: "ProjectFiles",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectFiles_Users_UserId",
                table: "ProjectFiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_Projects_ProjectId",
                table: "ProjectMembers",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_Users_UserId",
                table: "ProjectMembers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_ToDoLists_ToDoListId",
                table: "ProjectTasks",
                column: "ToDoListId",
                principalTable: "ToDoLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Users_UserId",
                table: "ProjectTasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDistributions_ProjectTasks_TaskId",
                table: "TaskDistributions",
                column: "TaskId",
                principalTable: "ProjectTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDistributions_Users_UserId",
                table: "TaskDistributions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoLists_Projects_ProjectId",
                table: "ToDoLists",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoLists_Users_UserId",
                table: "ToDoLists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConversationMembers_Conversations_ConversationId",
                table: "ConversationMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_ConversationMembers_Users_UserId",
                table: "ConversationMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Conversations_Projects_ProjectId",
                table: "Conversations");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitations_Projects_ProjectId",
                table: "Invitations");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitations_Users_UserId",
                table: "Invitations");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Conversations_ConversationId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectFiles_Projects_ProjectId",
                table: "ProjectFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectFiles_Users_UserId",
                table: "ProjectFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_Projects_ProjectId",
                table: "ProjectMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_Users_UserId",
                table: "ProjectMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_ToDoLists_ToDoListId",
                table: "ProjectTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Users_UserId",
                table: "ProjectTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskDistributions_ProjectTasks_TaskId",
                table: "TaskDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskDistributions_Users_UserId",
                table: "TaskDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoLists_Projects_ProjectId",
                table: "ToDoLists");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoLists_Users_UserId",
                table: "ToDoLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskDistributions",
                table: "TaskDistributions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectTasks",
                table: "ProjectTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectMembers",
                table: "ProjectMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectFiles",
                table: "ProjectFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invitations",
                table: "Invitations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conversations",
                table: "Conversations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConversationMembers",
                table: "ConversationMembers");

            migrationBuilder.RenameTable(
                name: "ToDoLists",
                newName: "ToDoList");

            migrationBuilder.RenameTable(
                name: "TaskDistributions",
                newName: "TaskDistribution");

            migrationBuilder.RenameTable(
                name: "ProjectTasks",
                newName: "ProjectTask");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "ProjectMembers",
                newName: "ProjectMember");

            migrationBuilder.RenameTable(
                name: "ProjectFiles",
                newName: "ProjectFile");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "Invitations",
                newName: "Invitation");

            migrationBuilder.RenameTable(
                name: "Conversations",
                newName: "Conversation");

            migrationBuilder.RenameTable(
                name: "ConversationMembers",
                newName: "ConversationMember");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoLists_UserId",
                table: "ToDoList",
                newName: "IX_ToDoList_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoLists_ProjectId",
                table: "ToDoList",
                newName: "IX_ToDoList_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskDistributions_UserId",
                table: "TaskDistribution",
                newName: "IX_TaskDistribution_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskDistributions_TaskId",
                table: "TaskDistribution",
                newName: "IX_TaskDistribution_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTasks_UserId",
                table: "ProjectTask",
                newName: "IX_ProjectTask_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTasks_ToDoListId",
                table: "ProjectTask",
                newName: "IX_ProjectTask_ToDoListId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectMembers_UserId",
                table: "ProjectMember",
                newName: "IX_ProjectMember_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectMembers_ProjectId",
                table: "ProjectMember",
                newName: "IX_ProjectMember_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectFiles_UserId",
                table: "ProjectFile",
                newName: "IX_ProjectFile_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectFiles_ProjectId",
                table: "ProjectFile",
                newName: "IX_ProjectFile_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_UserId",
                table: "Message",
                newName: "IX_Message_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_ConversationId",
                table: "Message",
                newName: "IX_Message_ConversationId");

            migrationBuilder.RenameIndex(
                name: "IX_Invitations_UserId",
                table: "Invitation",
                newName: "IX_Invitation_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Invitations_ProjectId",
                table: "Invitation",
                newName: "IX_Invitation_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Conversations_ProjectId",
                table: "Conversation",
                newName: "IX_Conversation_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ConversationMembers_UserId",
                table: "ConversationMember",
                newName: "IX_ConversationMember_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ConversationMembers_ConversationId",
                table: "ConversationMember",
                newName: "IX_ConversationMember_ConversationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskDistribution",
                table: "TaskDistribution",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectTask",
                table: "ProjectTask",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectMember",
                table: "ProjectMember",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectFile",
                table: "ProjectFile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invitation",
                table: "Invitation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conversation",
                table: "Conversation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConversationMember",
                table: "ConversationMember",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Conversation_Project_ProjectId",
                table: "Conversation",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConversationMember_Conversation_ConversationId",
                table: "ConversationMember",
                column: "ConversationId",
                principalTable: "Conversation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConversationMember_Users_UserId",
                table: "ConversationMember",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invitation_Project_ProjectId",
                table: "Invitation",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invitation_Users_UserId",
                table: "Invitation",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Conversation_ConversationId",
                table: "Message",
                column: "ConversationId",
                principalTable: "Conversation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Users_UserId",
                table: "Message",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectFile_Project_ProjectId",
                table: "ProjectFile",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectFile_Users_UserId",
                table: "ProjectFile",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMember_Project_ProjectId",
                table: "ProjectMember",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMember_Users_UserId",
                table: "ProjectMember",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTask_ToDoList_ToDoListId",
                table: "ProjectTask",
                column: "ToDoListId",
                principalTable: "ToDoList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTask_Users_UserId",
                table: "ProjectTask",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDistribution_ProjectTask_TaskId",
                table: "TaskDistribution",
                column: "TaskId",
                principalTable: "ProjectTask",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDistribution_Users_UserId",
                table: "TaskDistribution",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoList_Project_ProjectId",
                table: "ToDoList",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoList_Users_UserId",
                table: "ToDoList",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
