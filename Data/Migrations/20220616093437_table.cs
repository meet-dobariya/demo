using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace core_passport5.Data.Migrations
{
    public partial class table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "details",
                columns: table => new
                {
                    fnum = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Applyingfor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ifreissue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ifchange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    txt1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    toa14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    topb15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vr16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    anm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ali22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cnm23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dob24 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pob25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dt25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    st25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reg25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gen26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mst27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    czn28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pan29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vt210 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emp211 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    onm212 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pnt213 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edu214 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cat215 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vdm216 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    an217 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fnm31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mnm32 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lnm33 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    snm34 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fpn35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fnt35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mpn35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mnt35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    st41 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ct42 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dt43 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plcstn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    st44 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pin45 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eml46 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mob47 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel48 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isadd42 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passno61 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doi62 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    doe63 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    poi64 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isapp62 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthandyear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    poffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f711 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f712 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f713 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f714 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f715 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f716 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f717 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f718 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f719 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f720 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f721 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f722 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f723 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f724 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f725 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ddnum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    issuedate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expirydate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bankname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    branchname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ec1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    todaydate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sign2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_details", x => x.fnum);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "details");
        }
    }
}
