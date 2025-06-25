using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAn_API.Migrations
{
    /// <inheritdoc />
    public partial class khanh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    ID_GioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.ID_GioHang);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToans",
                columns: table => new
                {
                    ID_ThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenPT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToans", x => x.ID_ThanhToan);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucVanChuyens",
                columns: table => new
                {
                    ID_VanChuyen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenPT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucVanChuyens", x => x.ID_VanChuyen);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    ID_SP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThuongHieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiThieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.ID_SP);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    ID_TK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.ID_TK);
                });

            migrationBuilder.CreateTable(
                name: "TheTichs",
                columns: table => new
                {
                    ID_TheTich = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenTheTich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheTichs", x => x.ID_TheTich);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    ID_VCH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhanTramGiam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiSua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.ID_VCH);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    ID_NguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_TK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenND = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.ID_NguoiDung);
                    table.ForeignKey(
                        name: "FK_NguoiDungs_TaiKhoans_ID_TK",
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
                    ID_SP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_ThuTich = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTSanPhams", x => x.ID_CTSP);
                    table.ForeignKey(
                        name: "FK_CTSanPhams_SanPhams_ID_SP",
                        column: x => x.ID_SP,
                        principalTable: "SanPhams",
                        principalColumn: "ID_SP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTSanPhams_TheTichs_ID_ThuTich",
                        column: x => x.ID_ThuTich,
                        principalTable: "TheTichs",
                        principalColumn: "ID_TheTich",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiaChis",
                columns: table => new
                {
                    ID_DiaChi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_NguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChis", x => x.ID_DiaChi);
                    table.ForeignKey(
                        name: "FK_DiaChis_NguoiDungs_ID_NguoiDung",
                        column: x => x.ID_NguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "ID_NguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangCTs",
                columns: table => new
                {
                    ID_GioHangCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_GioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangCTs", x => x.ID_GioHangCT);
                    table.ForeignKey(
                        name: "FK_GioHangCTs_CTSanPhams_ID_SPCT",
                        column: x => x.ID_SPCT,
                        principalTable: "CTSanPhams",
                        principalColumn: "ID_CTSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangCTs_GioHangs_ID_GioHang",
                        column: x => x.ID_GioHang,
                        principalTable: "GioHangs",
                        principalColumn: "ID_GioHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    ID_HD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_NguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_VCH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_ThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_VanChuyen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_DiaChi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.ID_HD);
                    table.ForeignKey(
                        name: "FK_HoaDons_DiaChis_ID_DiaChi",
                        column: x => x.ID_DiaChi,
                        principalTable: "DiaChis",
                        principalColumn: "ID_DiaChi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_NguoiDungs_ID_NguoiDung",
                        column: x => x.ID_NguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "ID_NguoiDung",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_PhuongThucThanhToans_ID_ThanhToan",
                        column: x => x.ID_ThanhToan,
                        principalTable: "PhuongThucThanhToans",
                        principalColumn: "ID_ThanhToan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_PhuongThucVanChuyens_ID_VanChuyen",
                        column: x => x.ID_VanChuyen,
                        principalTable: "PhuongThucVanChuyens",
                        principalColumn: "ID_VanChuyen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_Vouchers_ID_VCH",
                        column: x => x.ID_VCH,
                        principalTable: "Vouchers",
                        principalColumn: "ID_VCH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CTHoaDons",
                columns: table => new
                {
                    ID_HDCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_HD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_CTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTHoaDons", x => x.ID_HDCT);
                    table.ForeignKey(
                        name: "FK_CTHoaDons_CTSanPhams_ID_CTSP",
                        column: x => x.ID_CTSP,
                        principalTable: "CTSanPhams",
                        principalColumn: "ID_CTSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTHoaDons_HoaDons_ID_HD",
                        column: x => x.ID_HD,
                        principalTable: "HoaDons",
                        principalColumn: "ID_HD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTHoaDons_ID_CTSP",
                table: "CTHoaDons",
                column: "ID_CTSP");

            migrationBuilder.CreateIndex(
                name: "IX_CTHoaDons_ID_HD",
                table: "CTHoaDons",
                column: "ID_HD");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhams_ID_SP",
                table: "CTSanPhams",
                column: "ID_SP");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhams_ID_ThuTich",
                table: "CTSanPhams",
                column: "ID_ThuTich");

            migrationBuilder.CreateIndex(
                name: "IX_DiaChis_ID_NguoiDung",
                table: "DiaChis",
                column: "ID_NguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCTs_ID_GioHang",
                table: "GioHangCTs",
                column: "ID_GioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCTs_ID_SPCT",
                table: "GioHangCTs",
                column: "ID_SPCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_ID_DiaChi",
                table: "HoaDons",
                column: "ID_DiaChi");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_ID_NguoiDung",
                table: "HoaDons",
                column: "ID_NguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_ID_ThanhToan",
                table: "HoaDons",
                column: "ID_ThanhToan");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_ID_VanChuyen",
                table: "HoaDons",
                column: "ID_VanChuyen");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_ID_VCH",
                table: "HoaDons",
                column: "ID_VCH");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDungs_ID_TK",
                table: "NguoiDungs",
                column: "ID_TK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTHoaDons");

            migrationBuilder.DropTable(
                name: "GioHangCTs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "CTSanPhams");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "DiaChis");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToans");

            migrationBuilder.DropTable(
                name: "PhuongThucVanChuyens");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "TheTichs");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "TaiKhoans");
        }
    }
}
