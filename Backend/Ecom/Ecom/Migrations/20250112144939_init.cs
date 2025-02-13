using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tai_khoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mat_khau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngay_dinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dia_chi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gioi_tinh = table.Column<bool>(type: "bit", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trang_thai = table.Column<bool>(type: "bit", nullable: true),
                    so_dien_thoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_super_admin = table.Column<bool>(type: "bit", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "danh_muc_san_pham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ma_danh_muc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ten_danh_muc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danh_muc_san_pham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dvvc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dvvc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ma_giam_gia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    loai_giam_gia = table.Column<bool>(type: "bit", nullable: false),
                    giam_gia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    thoi_gian_ap_dung_tu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    thoi_gian_ap_dung_den = table.Column<DateTime>(type: "datetime2", nullable: true),
                    so_luong = table.Column<int>(type: "int", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ma_giam_gia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gio_hang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nguoi_dung_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gio_hang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gio_hang_account_accountId",
                        column: x => x.accountId,
                        principalTable: "account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "thong_bao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nguoi_dung_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    noi_dung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nhom = table.Column<int>(type: "int", nullable: false),
                    trang_thai = table.Column<bool>(type: "bit", nullable: false),
                    thoi_gian_doc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thong_bao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_thong_bao_account_accountId",
                        column: x => x.accountId,
                        principalTable: "account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "san_pham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    danh_muc_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ma_san_pham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ten_san_pham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mo_ta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xuat_xu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    luot_ban = table.Column<int>(type: "int", nullable: true),
                    danh_muc_san_phamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_san_pham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_san_pham_danh_muc_san_pham_danh_muc_san_phamId",
                        column: x => x.danh_muc_san_phamId,
                        principalTable: "danh_muc_san_pham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "account_giam_gia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    account_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ma_giam_gia_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ma_Giam_GiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_giam_gia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_account_giam_gia_account_accountId",
                        column: x => x.accountId,
                        principalTable: "account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_account_giam_gia_ma_giam_gia_ma_Giam_GiaId",
                        column: x => x.ma_Giam_GiaId,
                        principalTable: "ma_giam_gia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chuong_trinh_marketing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ma_giam_gia_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cong_cu = table.Column<int>(type: "int", nullable: true),
                    ma_giam_giaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chuong_trinh_marketing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chuong_trinh_marketing_ma_giam_gia_ma_giam_giaId",
                        column: x => x.ma_giam_giaId,
                        principalTable: "ma_giam_gia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "don_hang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nguoi_dung_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ma_don_hang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trang_thai = table.Column<int>(type: "int", nullable: false),
                    ngay_mua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tong_tien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    giam_gia_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    thanh_tien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dvvc_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ma_giam_giaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dvvcId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_don_hang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_don_hang_account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_don_hang_dvvc_dvvcId",
                        column: x => x.dvvcId,
                        principalTable: "dvvc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_don_hang_ma_giam_gia_ma_giam_giaId",
                        column: x => x.ma_giam_giaId,
                        principalTable: "ma_giam_gia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "anh_san_pham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    duong_dan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    san_pham_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    san_phamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anh_san_pham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_anh_san_pham_san_pham_san_phamId",
                        column: x => x.san_phamId,
                        principalTable: "san_pham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chi_tiet_san_pham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    san_pham_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    kho_hang = table.Column<int>(type: "int", nullable: false),
                    SKU_san_pham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    chieu_dai = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    chieu_rong = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    can_cang = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    gia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    gia_khuyen_mai = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    mau_sac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    San_PhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chi_tiet_san_pham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chi_tiet_san_pham_san_pham_San_PhamId",
                        column: x => x.San_PhamId,
                        principalTable: "san_pham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chi_tiet_don_hang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    don_hang_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    san_pham_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    so_luong = table.Column<int>(type: "int", nullable: true),
                    thanh_tien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Don_HangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    San_phamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chi_tiet_don_hang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chi_tiet_don_hang_don_hang_Don_HangId",
                        column: x => x.Don_HangId,
                        principalTable: "don_hang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chi_tiet_don_hang_san_pham_San_phamId",
                        column: x => x.San_phamId,
                        principalTable: "san_pham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chi_tiet_gio_hang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    chi_tiet_san_pham_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nguoi_dung_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    chi_tiet_san_phamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chi_tiet_gio_hang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chi_tiet_gio_hang_account_accountId",
                        column: x => x.accountId,
                        principalTable: "account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chi_tiet_gio_hang_chi_tiet_san_pham_chi_tiet_san_phamId",
                        column: x => x.chi_tiet_san_phamId,
                        principalTable: "chi_tiet_san_pham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "danh_gia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    chi_tiet_san_pham_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nguoi_dung_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    danh_gia_chat_luong = table.Column<int>(type: "int", nullable: false),
                    noi_dung_danh_gia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chi_Tiet_San_PhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danh_gia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_danh_gia_account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_danh_gia_chi_tiet_san_pham_Chi_Tiet_San_PhamId",
                        column: x => x.Chi_Tiet_San_PhamId,
                        principalTable: "chi_tiet_san_pham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "san_pham_marketing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    chuong_trinh_marketing_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    chi_tiet_san_pham_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    gia_goc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    gia_sau_giam = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    giam_gia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    so_luong = table.Column<int>(type: "int", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    Chuong_Trinh_MarketingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Chi_Tiet_San_PhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_san_pham_marketing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_san_pham_marketing_chi_tiet_san_pham_Chi_Tiet_San_PhamId",
                        column: x => x.Chi_Tiet_San_PhamId,
                        principalTable: "chi_tiet_san_pham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_san_pham_marketing_chuong_trinh_marketing_Chuong_Trinh_MarketingId",
                        column: x => x.Chuong_Trinh_MarketingId,
                        principalTable: "chuong_trinh_marketing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_account_giam_gia_accountId",
                table: "account_giam_gia",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_account_giam_gia_ma_Giam_GiaId",
                table: "account_giam_gia",
                column: "ma_Giam_GiaId");

            migrationBuilder.CreateIndex(
                name: "IX_anh_san_pham_san_phamId",
                table: "anh_san_pham",
                column: "san_phamId");

            migrationBuilder.CreateIndex(
                name: "IX_chi_tiet_don_hang_Don_HangId",
                table: "chi_tiet_don_hang",
                column: "Don_HangId");

            migrationBuilder.CreateIndex(
                name: "IX_chi_tiet_don_hang_San_phamId",
                table: "chi_tiet_don_hang",
                column: "San_phamId");

            migrationBuilder.CreateIndex(
                name: "IX_chi_tiet_gio_hang_accountId",
                table: "chi_tiet_gio_hang",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_chi_tiet_gio_hang_chi_tiet_san_phamId",
                table: "chi_tiet_gio_hang",
                column: "chi_tiet_san_phamId");

            migrationBuilder.CreateIndex(
                name: "IX_chi_tiet_san_pham_San_PhamId",
                table: "chi_tiet_san_pham",
                column: "San_PhamId");

            migrationBuilder.CreateIndex(
                name: "IX_chuong_trinh_marketing_ma_giam_giaId",
                table: "chuong_trinh_marketing",
                column: "ma_giam_giaId");

            migrationBuilder.CreateIndex(
                name: "IX_danh_gia_AccountId",
                table: "danh_gia",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_danh_gia_Chi_Tiet_San_PhamId",
                table: "danh_gia",
                column: "Chi_Tiet_San_PhamId");

            migrationBuilder.CreateIndex(
                name: "IX_don_hang_AccountId",
                table: "don_hang",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_don_hang_dvvcId",
                table: "don_hang",
                column: "dvvcId");

            migrationBuilder.CreateIndex(
                name: "IX_don_hang_ma_giam_giaId",
                table: "don_hang",
                column: "ma_giam_giaId");

            migrationBuilder.CreateIndex(
                name: "IX_gio_hang_accountId",
                table: "gio_hang",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_san_pham_danh_muc_san_phamId",
                table: "san_pham",
                column: "danh_muc_san_phamId");

            migrationBuilder.CreateIndex(
                name: "IX_san_pham_marketing_Chi_Tiet_San_PhamId",
                table: "san_pham_marketing",
                column: "Chi_Tiet_San_PhamId");

            migrationBuilder.CreateIndex(
                name: "IX_san_pham_marketing_Chuong_Trinh_MarketingId",
                table: "san_pham_marketing",
                column: "Chuong_Trinh_MarketingId");

            migrationBuilder.CreateIndex(
                name: "IX_thong_bao_accountId",
                table: "thong_bao",
                column: "accountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account_giam_gia");

            migrationBuilder.DropTable(
                name: "anh_san_pham");

            migrationBuilder.DropTable(
                name: "chi_tiet_don_hang");

            migrationBuilder.DropTable(
                name: "chi_tiet_gio_hang");

            migrationBuilder.DropTable(
                name: "danh_gia");

            migrationBuilder.DropTable(
                name: "gio_hang");

            migrationBuilder.DropTable(
                name: "san_pham_marketing");

            migrationBuilder.DropTable(
                name: "thong_bao");

            migrationBuilder.DropTable(
                name: "don_hang");

            migrationBuilder.DropTable(
                name: "chi_tiet_san_pham");

            migrationBuilder.DropTable(
                name: "chuong_trinh_marketing");

            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "dvvc");

            migrationBuilder.DropTable(
                name: "san_pham");

            migrationBuilder.DropTable(
                name: "ma_giam_gia");

            migrationBuilder.DropTable(
                name: "danh_muc_san_pham");
        }
    }
}
