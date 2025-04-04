using Microsoft.EntityFrameworkCore.Migrations;

namespace SerialMakerBlazor.Data.Migrations
{
    public partial class AddVClientVersionView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view VClientVersions as
select 
cv.*
,c.Name as ClientName
,c.PhoneNo
,st.SysName
,sv.VersionName
,sv.VersionNumber
from 
ClientVersions cv inner join Clients c on c.ID=cv.ClientId
inner join SystemTypes st on st.ID=cv.SysTypeId
inner join SysVersions sv on sv.ID=cv.VersionId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
