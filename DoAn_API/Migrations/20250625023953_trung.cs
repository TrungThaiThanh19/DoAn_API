using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAn_API.Migrations
{
    /// <inheritdoc />
    public partial class trung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    ID_KH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenKhach = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.ID_KH);
                });

            migrationBuilder.CreateTable(
                name: "MauSacs",
                columns: table => new
                {
                    ID_MS = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSacs", x => x.ID_MS);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    ID_SP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.ID_SP);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    ID_SIZE = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID_SIZE);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    ID_TK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.ID_TK);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieus",
                columns: table => new
                {
                    ID_TH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenTH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieus", x => x.ID_TH);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    ID_VCH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenVch = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhanTramGiam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HanSuDung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.ID_VCH);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    ID_NV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SoCccd = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ID_TK = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.ID_NV);
                    table.ForeignKey(
                        name: "FK_NhanViens_TaiKhoans_ID_TK",
                        column: x => x.ID_TK,
                        principalTable: "TaiKhoans",
                        principalColumn: "ID_TK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CTSanPhams",
                columns: table => new
                {
                    ID_CTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_SP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_MS = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SIZE = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_TH = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTSanPhams", x => x.ID_CTSP);
                    table.ForeignKey(
                        name: "FK_CTSanPhams_MauSacs_ID_MS",
                        column: x => x.ID_MS,
                        principalTable: "MauSacs",
                        principalColumn: "ID_MS",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CTSanPhams_SanPhams_ID_SP",
                        column: x => x.ID_SP,
                        principalTable: "SanPhams",
                        principalColumn: "ID_SP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTSanPhams_Sizes_ID_SIZE",
                        column: x => x.ID_SIZE,
                        principalTable: "Sizes",
                        principalColumn: "ID_SIZE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CTSanPhams_ThuongHieus_ID_TH",
                        column: x => x.ID_TH,
                        principalTable: "ThuongHieus",
                        principalColumn: "ID_TH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    ID_HD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_KH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_NV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_VCH = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.ID_HD);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_ID_KH",
                        column: x => x.ID_KH,
                        principalTable: "KhachHangs",
                        principalColumn: "ID_KH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_ID_NV",
                        column: x => x.ID_NV,
                        principalTable: "NhanViens",
                        principalColumn: "ID_NV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_Vouchers_ID_VCH",
                        column: x => x.ID_VCH,
                        principalTable: "Vouchers",
                        principalColumn: "ID_VCH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhaps",
                columns: table => new
                {
                    ID_PN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ID_NV = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhaps", x => x.ID_PN);
                    table.ForeignKey(
                        name: "FK_PhieuNhaps_NhanViens_ID_NV",
                        column: x => x.ID_NV,
                        principalTable: "NhanViens",
                        principalColumn: "ID_NV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CTHoaDons",
                columns: table => new
                {
                    ID_HDCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ID_HD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SP = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTHoaDons", x => x.ID_HDCT);
                    table.ForeignKey(
                        name: "FK_CTHoaDons_HoaDons_ID_HD",
                        column: x => x.ID_HD,
                        principalTable: "HoaDons",
                        principalColumn: "ID_HD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTHoaDons_SanPhams_ID_SP",
                        column: x => x.ID_SP,
                        principalTable: "SanPhams",
                        principalColumn: "ID_SP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CTPhieuNhaps",
                columns: table => new
                {
                    ID_CTPN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongNhap = table.Column<int>(type: "int", nullable: false),
                    ID_PN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SP = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTPhieuNhaps", x => x.ID_CTPN);
                    table.ForeignKey(
                        name: "FK_CTPhieuNhaps_PhieuNhaps_ID_PN",
                        column: x => x.ID_PN,
                        principalTable: "PhieuNhaps",
                        principalColumn: "ID_PN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTPhieuNhaps_SanPhams_ID_SP",
                        column: x => x.ID_SP,
                        principalTable: "SanPhams",
                        principalColumn: "ID_SP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTHoaDons_ID_HD",
                table: "CTHoaDons",
                column: "ID_HD");

            migrationBuilder.CreateIndex(
                name: "IX_CTHoaDons_ID_SP",
                table: "CTHoaDons",
                column: "ID_SP");

            migrationBuilder.CreateIndex(
                name: "IX_CTPhieuNhaps_ID_PN",
                table: "CTPhieuNhaps",
                column: "ID_PN");

            migrationBuilder.CreateIndex(
                name: "IX_CTPhieuNhaps_ID_SP",
                table: "CTPhieuNhaps",
                column: "ID_SP");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhams_ID_MS",
                table: "CTSanPhams",
                column: "ID_MS");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhams_ID_SIZE",
                table: "CTSanPhams",
                column: "ID_SIZE");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhams_ID_SP",
                table: "CTSanPhams",
                column: "ID_SP");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhams_ID_TH",
                table: "CTSanPhams",
                column: "ID_TH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_ID_KH",
                table: "HoaDons",
                column: "ID_KH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_ID_NV",
                table: "HoaDons",
                column: "ID_NV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_ID_VCH",
                table: "HoaDons",
                column: "ID_VCH");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_ID_TK",
                table: "NhanViens",
                column: "ID_TK");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhaps_ID_NV",
                table: "PhieuNhaps",
                column: "ID_NV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTHoaDons");

            migrationBuilder.DropTable(
                name: "CTPhieuNhaps");

            migrationBuilder.DropTable(
                name: "CTSanPhams");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "PhieuNhaps");

            migrationBuilder.DropTable(
                name: "MauSacs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "ThuongHieus");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "TaiKhoans");
        }
    }
}
