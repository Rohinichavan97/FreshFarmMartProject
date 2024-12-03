using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AdminTbl",
            //    columns: table => new
            //    {
            //        AdminId = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AdminTbl", x => x.AdminId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CountryTbl",
            //    columns: table => new
            //    {
            //        CountryID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CountryTbl", x => x.CountryID);
            //    });

            migrationBuilder.CreateTable(
                name: "DispatchAgencyTbl",
                columns: table => new
                {
                    DispatchAgencyID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispatchAgencyTbl", x => x.DispatchAgencyID);
                });

            //migrationBuilder.CreateTable(
            //    name: "FarmerTermsConditionTbl",
            //    columns: table => new
            //    {
            //        TraderFarmerTermsConditionID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TermsConditionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        TermsConditionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FarmerTermsConditionTbl", x => x.TraderFarmerTermsConditionID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MainCategoryTbl",
            //    columns: table => new
            //    {
            //        MainCategoryID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MainCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MainCategoryTbl", x => x.MainCategoryID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UnitTbl",
            //    columns: table => new
            //    {
            //        UnitID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        QtyPerUnit = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UnitTbl", x => x.UnitID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserTermsConditionTbl",
            //    columns: table => new
            //    {
            //        UserTermsConditionID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TermsConditionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        TermsConditionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserTermsConditionTbl", x => x.UserTermsConditionID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "StateTbl",
            //    columns: table => new
            //    {
            //        StateID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        StateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CountryID = table.Column<long>(type: "bigint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_StateTbl", x => x.StateID);
            //        table.ForeignKey(
            //            name: "FK_StateTbl_CountryTbl_CountryID",
            //            column: x => x.CountryID,
            //            principalTable: "CountryTbl",
            //            principalColumn: "CountryID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CategoryTbl",
            //    columns: table => new
            //    {
            //        CategoryID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        MainCategoryID = table.Column<long>(type: "bigint", nullable: false),
            //        PurchaseLimitInQty = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CategoryTbl", x => x.CategoryID);
            //        table.ForeignKey(
            //            name: "FK_CategoryTbl_MainCategoryTbl_MainCategoryID",
            //            column: x => x.MainCategoryID,
            //            principalTable: "MainCategoryTbl",
            //            principalColumn: "MainCategoryID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CityTbl",
            //    columns: table => new
            //    {
            //        CityID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        StateID = table.Column<long>(type: "bigint", nullable: false),
            //        CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CityTbl", x => x.CityID);
            //        table.ForeignKey(
            //            name: "FK_CityTbl_StateTbl_StateID",
            //            column: x => x.StateID,
            //            principalTable: "StateTbl",
            //            principalColumn: "StateID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TraderFarmerTbl",
            //    columns: table => new
            //    {
            //        TraderFarmerID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CityID = table.Column<long>(type: "bigint", nullable: false),
            //        ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ActiveFlag = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TraderFarmerTbl", x => x.TraderFarmerID);
            //        table.ForeignKey(
            //            name: "FK_TraderFarmerTbl_CityTbl_CityID",
            //            column: x => x.CityID,
            //            principalTable: "CityTbl",
            //            principalColumn: "CityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        UserID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Gender = table.Column<int>(type: "int", nullable: false),
            //        CityID = table.Column<long>(type: "bigint", nullable: false),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.UserID);
            //        table.ForeignKey(
            //            name: "FK_Users_CityTbl_CityID",
            //            column: x => x.CityID,
            //            principalTable: "CityTbl",
            //            principalColumn: "CityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductTbl",
            //    columns: table => new
            //    {
            //        ProductID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ProductDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CategoryID = table.Column<long>(type: "bigint", nullable: false),
            //        UnitID = table.Column<long>(type: "bigint", nullable: false),
            //        Qty = table.Column<int>(type: "int", nullable: false),
            //        Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        MainPhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        TraderFarmerID = table.Column<long>(type: "bigint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductTbl", x => x.ProductID);
            //        table.ForeignKey(
            //            name: "FK_ProductTbl_CategoryTbl_CategoryID",
            //            column: x => x.CategoryID,
            //            principalTable: "CategoryTbl",
            //            principalColumn: "CategoryID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductTbl_TraderFarmerTbl_TraderFarmerID",
            //            column: x => x.TraderFarmerID,
            //            principalTable: "TraderFarmerTbl",
            //            principalColumn: "TraderFarmerID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductTbl_UnitTbl_UnitID",
            //            column: x => x.UnitID,
            //            principalTable: "UnitTbl",
            //            principalColumn: "UnitID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            migrationBuilder.CreateTable(
                name: "CartTbl",
                columns: table => new
                {
                    CartID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartTbl", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_CartTbl_ProductTbl_ProductID",
                        column: x => x.ProductID,
                        principalTable: "ProductTbl",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartTbl_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            //migrationBuilder.CreateTable(
            //    name: "ProductDiscountTbl",
            //    columns: table => new
            //    {
            //        ProductDiscountID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProductID = table.Column<long>(type: "bigint", nullable: false),
            //        DiscountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        IsPercentile = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductDiscountTbl", x => x.ProductDiscountID);
            //        table.ForeignKey(
            //            name: "FK_ProductDiscountTbl_ProductTbl_ProductID",
            //            column: x => x.ProductID,
            //            principalTable: "ProductTbl",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductPhotoTbl",
            //    columns: table => new
            //    {
            //        ProudctPhotoID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProductID = table.Column<long>(type: "bigint", nullable: false),
            //        PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductPhotoTbl", x => x.ProudctPhotoID);
            //        table.ForeignKey(
            //            name: "FK_ProductPhotoTbl_ProductTbl_ProductID",
            //            column: x => x.ProductID,
            //            principalTable: "ProductTbl",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductReviewTbl",
            //    columns: table => new
            //    {
            //        ProductReviewID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProductID = table.Column<long>(type: "bigint", nullable: false),
            //        UserID = table.Column<long>(type: "bigint", nullable: false),
            //        ReviewDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Rating = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductReviewTbl", x => x.ProductReviewID);
            //        table.ForeignKey(
            //            name: "FK_ProductReviewTbl_ProductTbl_ProductID",
            //            column: x => x.ProductID,
            //            principalTable: "ProductTbl",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductReviewTbl_Users_UserID",
            //            column: x => x.UserID,
            //            principalTable: "Users",
            //            principalColumn: "UserID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserOrderTbl",
            //    columns: table => new
            //    {
            //        UserOrderID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserID = table.Column<long>(type: "bigint", nullable: false),
            //        OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        IsPaid = table.Column<bool>(type: "bit", nullable: false),
            //        TraderFarmerID = table.Column<long>(type: "bigint", nullable: false),
            //        ProductID = table.Column<long>(type: "bigint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserOrderTbl", x => x.UserOrderID);
            //        table.ForeignKey(
            //            name: "FK_UserOrderTbl_ProductTbl_ProductID",
            //            column: x => x.ProductID,
            //            principalTable: "ProductTbl",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_UserOrderTbl_TraderFarmerTbl_TraderFarmerID",
            //            column: x => x.TraderFarmerID,
            //            principalTable: "TraderFarmerTbl",
            //            principalColumn: "TraderFarmerID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_UserOrderTbl_Users_UserID",
            //            column: x => x.UserID,
            //            principalTable: "Users",
            //            principalColumn: "UserID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            migrationBuilder.CreateTable(
                name: "OrderDispatchTbl",
                columns: table => new
                {
                    OrderDispatchID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserOrderID = table.Column<long>(type: "bigint", nullable: false),
                    DispatchAgencyID = table.Column<long>(type: "bigint", nullable: false),
                    DocketNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DispatchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedReachDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDispatchTbl", x => x.OrderDispatchID);
                    table.ForeignKey(
                        name: "FK_OrderDispatchTbl_DispatchAgencyTbl_DispatchAgencyID",
                        column: x => x.DispatchAgencyID,
                        principalTable: "DispatchAgencyTbl",
                        principalColumn: "DispatchAgencyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDispatchTbl_UserOrderTbl_UserOrderID",
                        column: x => x.UserOrderID,
                        principalTable: "UserOrderTbl",
                        principalColumn: "UserOrderID",
                        onDelete: ReferentialAction.Restrict);
                });

            //migrationBuilder.CreateTable(
            //    name: "UserOrderComplaintTbl",
            //    columns: table => new
            //    {
            //        UserOrderComplaintID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserOrderID = table.Column<long>(type: "bigint", nullable: false),
            //        ComplaintDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ComplaintDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserOrderComplaintTbl", x => x.UserOrderComplaintID);
            //        table.ForeignKey(
            //            name: "FK_UserOrderComplaintTbl_UserOrderTbl_UserOrderID",
            //            column: x => x.UserOrderID,
            //            principalTable: "UserOrderTbl",
            //            principalColumn: "UserOrderID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserOrderDetTbl",
            //    columns: table => new
            //    {
            //        UserOrderDetID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserOrderID = table.Column<long>(type: "bigint", nullable: false),
            //        ProductID = table.Column<long>(type: "bigint", nullable: false),
            //        Qty = table.Column<int>(type: "int", nullable: false),
            //        Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        DiscountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DiscountApplied = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        IsPercentile = table.Column<bool>(type: "bit", nullable: false),
            //        ActualDiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserOrderDetTbl", x => x.UserOrderDetID);
            //        table.ForeignKey(
            //            name: "FK_UserOrderDetTbl_UserOrderTbl_UserOrderID",
            //            column: x => x.UserOrderID,
            //            principalTable: "UserOrderTbl",
            //            principalColumn: "UserOrderID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserOrderPaymentTbl",
            //    columns: table => new
            //    {
            //        UserOrderPaymentID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserOrderID = table.Column<long>(type: "bigint", nullable: false),
            //        PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        PaymentMode = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserOrderPaymentTbl", x => x.UserOrderPaymentID);
            //        table.ForeignKey(
            //            name: "FK_UserOrderPaymentTbl_UserOrderTbl_UserOrderID",
            //            column: x => x.UserOrderID,
            //            principalTable: "UserOrderTbl",
            //            principalColumn: "UserOrderID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "WishListTbl",
            //    columns: table => new
            //    {
            //        WishListID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        WishListDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserOrderID = table.Column<long>(type: "bigint", nullable: false),
            //        ProductID = table.Column<long>(type: "bigint", nullable: false),
            //        AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_WishListTbl", x => x.WishListID);
            //        table.ForeignKey(
            //            name: "FK_WishListTbl_ProductTbl_ProductID",
            //            column: x => x.ProductID,
            //            principalTable: "ProductTbl",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_WishListTbl_UserOrderTbl_UserOrderID",
            //            column: x => x.UserOrderID,
            //            principalTable: "UserOrderTbl",
            //            principalColumn: "UserOrderID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserOrderComplaintSolutionTbl",
            //    columns: table => new
            //    {
            //        UserOrderComplaintSolutionID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserOrderComplaintID = table.Column<long>(type: "bigint", nullable: false),
            //        SolutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        SolutionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserOrderComplaintSolutionTbl", x => x.UserOrderComplaintSolutionID);
            //        table.ForeignKey(
            //            name: "FK_UserOrderComplaintSolutionTbl_UserOrderComplaintTbl_UserOrderComplaintID",
            //            column: x => x.UserOrderComplaintID,
            //            principalTable: "UserOrderComplaintTbl",
            //            principalColumn: "UserOrderComplaintID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ComplaintRefundTbl",
            //    columns: table => new
            //    {
            //        ComplaintRefundID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserOrderComplaintSolutionID = table.Column<long>(type: "bigint", nullable: false),
            //        RefundAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        ReundDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        PaymentMode = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ComplaintRefundTbl", x => x.ComplaintRefundID);
            //        table.ForeignKey(
            //            name: "FK_ComplaintRefundTbl_UserOrderComplaintSolutionTbl_UserOrderComplaintSolutionID",
            //            column: x => x.UserOrderComplaintSolutionID,
            //            principalTable: "UserOrderComplaintSolutionTbl",
            //            principalColumn: "UserOrderComplaintSolutionID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.InsertData(
            //    table: "AdminTbl",
            //    columns: new[] { "AdminId", "Address", "ContactPerson", "EmailID", "FirstName", "LastName", "MobileNo", "Password" },
            //    values: new object[] { 1L, null, null, "pravinchavan@gmail.com", "Pravin", "Chavan", "98745635487", "abcd" });

            //migrationBuilder.InsertData(
            //    table: "CountryTbl",
            //    columns: new[] { "CountryID", "CountryName" },
            //    values: new object[] { 1L, "India" });

            //migrationBuilder.InsertData(
            //    table: "StateTbl",
            //    columns: new[] { "StateID", "CountryID", "StateName" },
            //    values: new object[] { 1L, 1L, "Maharashtra" });

            //migrationBuilder.InsertData(
            //    table: "CityTbl",
            //    columns: new[] { "CityID", "CityName", "StateID" },
            //    values: new object[] { 1L, "Pune", 1L });

            //migrationBuilder.InsertData(
            //    table: "TraderFarmerTbl",
            //    columns: new[] { "TraderFarmerID", "ActiveFlag", "Address", "CityID", "ContactPerson", "EmailID", "MobileNo", "Password", "PinCode", "RegistrationDate", "TradeName" },
            //    values: new object[] { 1L, true, "Kolhapur", 1L, "Minal", "rahul@gmail.com", "9874587658", "acbd", "416209", new DateTime(2024, 11, 15, 15, 6, 4, 47, DateTimeKind.Local).AddTicks(2471), "Rahul" });

            migrationBuilder.CreateIndex(
                name: "IX_CartTbl_ProductID",
                table: "CartTbl",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_CartTbl_UserID",
                table: "CartTbl",
                column: "UserID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CategoryTbl_MainCategoryID",
            //    table: "CategoryTbl",
            //    column: "MainCategoryID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CityTbl_StateID",
            //    table: "CityTbl",
            //    column: "StateID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ComplaintRefundTbl_UserOrderComplaintSolutionID",
            //    table: "ComplaintRefundTbl",
            //    column: "UserOrderComplaintSolutionID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDispatchTbl_DispatchAgencyID",
                table: "OrderDispatchTbl",
                column: "DispatchAgencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDispatchTbl_UserOrderID",
                table: "OrderDispatchTbl",
                column: "UserOrderID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductDiscountTbl_ProductID",
            //    table: "ProductDiscountTbl",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductPhotoTbl_ProductID",
            //    table: "ProductPhotoTbl",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductReviewTbl_ProductID",
            //    table: "ProductReviewTbl",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductReviewTbl_UserID",
            //    table: "ProductReviewTbl",
            //    column: "UserID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductTbl_CategoryID",
            //    table: "ProductTbl",
            //    column: "CategoryID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductTbl_TraderFarmerID",
            //    table: "ProductTbl",
            //    column: "TraderFarmerID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductTbl_UnitID",
            //    table: "ProductTbl",
            //    column: "UnitID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StateTbl_CountryID",
            //    table: "StateTbl",
            //    column: "CountryID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TraderFarmerTbl_CityID",
            //    table: "TraderFarmerTbl",
            //    column: "CityID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOrderComplaintSolutionTbl_UserOrderComplaintID",
            //    table: "UserOrderComplaintSolutionTbl",
            //    column: "UserOrderComplaintID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOrderComplaintTbl_UserOrderID",
            //    table: "UserOrderComplaintTbl",
            //    column: "UserOrderID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOrderDetTbl_UserOrderID",
            //    table: "UserOrderDetTbl",
            //    column: "UserOrderID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOrderPaymentTbl_UserOrderID",
            //    table: "UserOrderPaymentTbl",
            //    column: "UserOrderID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOrderTbl_ProductID",
            //    table: "UserOrderTbl",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOrderTbl_TraderFarmerID",
            //    table: "UserOrderTbl",
            //    column: "TraderFarmerID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOrderTbl_UserID",
            //    table: "UserOrderTbl",
            //    column: "UserID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_CityID",
            //    table: "Users",
            //    column: "CityID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_WishListTbl_ProductID",
            //    table: "WishListTbl",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_WishListTbl_UserOrderID",
            //    table: "WishListTbl",
            //    column: "UserOrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTbl");

            migrationBuilder.DropTable(
                name: "CartTbl");

            migrationBuilder.DropTable(
                name: "ComplaintRefundTbl");

            migrationBuilder.DropTable(
                name: "FarmerTermsConditionTbl");

            migrationBuilder.DropTable(
                name: "OrderDispatchTbl");

            migrationBuilder.DropTable(
                name: "ProductDiscountTbl");

            migrationBuilder.DropTable(
                name: "ProductPhotoTbl");

            migrationBuilder.DropTable(
                name: "ProductReviewTbl");

            migrationBuilder.DropTable(
                name: "UserOrderDetTbl");

            migrationBuilder.DropTable(
                name: "UserOrderPaymentTbl");

            migrationBuilder.DropTable(
                name: "UserTermsConditionTbl");

            migrationBuilder.DropTable(
                name: "WishListTbl");

            migrationBuilder.DropTable(
                name: "UserOrderComplaintSolutionTbl");

            migrationBuilder.DropTable(
                name: "DispatchAgencyTbl");

            migrationBuilder.DropTable(
                name: "UserOrderComplaintTbl");

            migrationBuilder.DropTable(
                name: "UserOrderTbl");

            migrationBuilder.DropTable(
                name: "ProductTbl");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CategoryTbl");

            migrationBuilder.DropTable(
                name: "TraderFarmerTbl");

            migrationBuilder.DropTable(
                name: "UnitTbl");

            migrationBuilder.DropTable(
                name: "MainCategoryTbl");

            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "StateTbl");

            migrationBuilder.DropTable(
                name: "CountryTbl");
        }
    }
}
