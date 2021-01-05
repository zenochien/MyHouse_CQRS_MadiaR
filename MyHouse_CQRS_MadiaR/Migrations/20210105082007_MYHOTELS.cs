using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyHouse_CQRS_MadiaR.Migrations
{
    public partial class MYHOTELS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCOde = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    HomePhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    CellularNumber = table.Column<string>(nullable: true),
                    eMailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestID);
                });

            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    HotelID = table.Column<Guid>(nullable: false),
                    HotelCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Motto = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCOde = table.Column<string>(nullable: true),
                    MainPhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    FaxNumber = table.Column<string>(nullable: true),
                    TooIIFreeNumber = table.Column<string>(nullable: true),
                    CompanyeMailAddress = table.Column<string>(nullable: true),
                    WebsiteAddress = table.Column<string>(nullable: true),
                    Main = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.HotelID);
                });

            migrationBuilder.CreateTable(
                name: "paymentTypes",
                columns: table => new
                {
                    PaymentTypeID = table.Column<Guid>(nullable: false),
                    PaymentType = table.Column<string>(nullable: true),
                    SortOrder = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentTypes", x => x.PaymentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionID = table.Column<Guid>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    SortOrder = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "rateTypes",
                columns: table => new
                {
                    RateTypeID = table.Column<Guid>(nullable: false),
                    RateType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SortOrder = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rateTypes", x => x.RateTypeID);
                });

            migrationBuilder.CreateTable(
                name: "reservationAgents",
                columns: table => new
                {
                    ReservationAgentID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCOde = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    HomePhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    CellularNumber = table.Column<string>(nullable: true),
                    eMailAddress = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationAgents", x => x.ReservationAgentID);
                });

            migrationBuilder.CreateTable(
                name: "roomsBookeds",
                columns: table => new
                {
                    RoomBookedID = table.Column<Guid>(nullable: false),
                    BookingID = table.Column<Guid>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    RoomsBookedRoomBookedID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomsBookeds", x => x.RoomBookedID);
                    table.ForeignKey(
                        name: "FK_roomsBookeds_roomsBookeds_RoomsBookedRoomBookedID",
                        column: x => x.RoomsBookedRoomBookedID,
                        principalTable: "roomsBookeds",
                        principalColumn: "RoomBookedID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "roomStatuses",
                columns: table => new
                {
                    RoomStatusID = table.Column<Guid>(nullable: false),
                    RoomsStatus = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SortOrder = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomStatuses", x => x.RoomStatusID);
                });

            migrationBuilder.CreateTable(
                name: "roomTypes",
                columns: table => new
                {
                    RoomTypeID = table.Column<Guid>(nullable: false),
                    RoomType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SortOrder = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomTypes", x => x.RoomTypeID);
                });

            migrationBuilder.CreateTable(
                name: "paymentStatuses",
                columns: table => new
                {
                    PaymentStatusID = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SortOrder = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true),
                    PaymentTypesPaymentTypeID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentStatuses", x => x.PaymentStatusID);
                    table.ForeignKey(
                        name: "FK_paymentStatuses_paymentTypes_PaymentTypesPaymentTypeID",
                        column: x => x.PaymentTypesPaymentTypeID,
                        principalTable: "paymentTypes",
                        principalColumn: "PaymentTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    StaffID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    PositionID = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCOde = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    HomePhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    CellularNumber = table.Column<string>(nullable: true),
                    eMailAddress = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_staffs_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookingStatuses",
                columns: table => new
                {
                    BookingStatusID = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SortOrder = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true),
                    BookingStatusID1 = table.Column<Guid>(nullable: true),
                    ReservationAgentsReservationAgentID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingStatuses", x => x.BookingStatusID);
                    table.ForeignKey(
                        name: "FK_bookingStatuses_bookingStatuses_BookingStatusID1",
                        column: x => x.BookingStatusID1,
                        principalTable: "bookingStatuses",
                        principalColumn: "BookingStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bookingStatuses_reservationAgents_ReservationAgentsReservationAgentID",
                        column: x => x.ReservationAgentsReservationAgentID,
                        principalTable: "reservationAgents",
                        principalColumn: "ReservationAgentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    RoomsID = table.Column<Guid>(nullable: false),
                    Floor = table.Column<string>(nullable: true),
                    RoomTypeID = table.Column<Guid>(nullable: false),
                    RoomNumber = table.Column<string>(nullable: true),
                    Desription = table.Column<string>(nullable: true),
                    RoomStatusID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.RoomsID);
                    table.ForeignKey(
                        name: "FK_rooms_roomStatuses_RoomStatusID",
                        column: x => x.RoomStatusID,
                        principalTable: "roomStatuses",
                        principalColumn: "RoomStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rooms_roomTypes_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "roomTypes",
                        principalColumn: "RoomTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingID = table.Column<Guid>(nullable: false),
                    HotelID = table.Column<Guid>(nullable: false),
                    GuestID = table.Column<Guid>(nullable: false),
                    ReservationAgentID = table.Column<Guid>(nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: true),
                    DateTo = table.Column<DateTime>(nullable: true),
                    RoomCount = table.Column<string>(nullable: true),
                    BookingStatusID = table.Column<Guid>(nullable: false),
                    RoomsBookedID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Bookings_bookingStatuses_BookingStatusID",
                        column: x => x.BookingStatusID,
                        principalTable: "bookingStatuses",
                        principalColumn: "BookingStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Guests_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guests",
                        principalColumn: "GuestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "hotels",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_reservationAgents_ReservationAgentID",
                        column: x => x.ReservationAgentID,
                        principalTable: "reservationAgents",
                        principalColumn: "ReservationAgentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_roomsBookeds_RoomsBookedID",
                        column: x => x.RoomsBookedID,
                        principalTable: "roomsBookeds",
                        principalColumn: "RoomBookedID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    PaymentID = table.Column<Guid>(nullable: false),
                    RoomID = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    Payment = table.Column<string>(nullable: true),
                    PaymentTypeID = table.Column<Guid>(nullable: false),
                    PaymentStatsID = table.Column<Guid>(nullable: false),
                    PaymentStatusID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_payments_paymentStatuses_PaymentStatusID",
                        column: x => x.PaymentStatusID,
                        principalTable: "paymentStatuses",
                        principalColumn: "PaymentStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payments_hotels_PaymentTypeID",
                        column: x => x.PaymentTypeID,
                        principalTable: "hotels",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payments_rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "rooms",
                        principalColumn: "RoomsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rates",
                columns: table => new
                {
                    RateID = table.Column<Guid>(nullable: false),
                    RoomID = table.Column<Guid>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: true),
                    ToDate = table.Column<DateTime>(nullable: true),
                    RateTypeID = table.Column<Guid>(nullable: false),
                    PositionsPositionID = table.Column<Guid>(nullable: true),
                    RoomsID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rates", x => x.RateID);
                    table.ForeignKey(
                        name: "FK_rates_Positions_PositionsPositionID",
                        column: x => x.PositionsPositionID,
                        principalTable: "Positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rates_rateTypes_RateTypeID",
                        column: x => x.RateTypeID,
                        principalTable: "rateTypes",
                        principalColumn: "RateTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rates_rooms_RoomsID",
                        column: x => x.RoomsID,
                        principalTable: "rooms",
                        principalColumn: "RoomsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "staffRooms",
                columns: table => new
                {
                    StaffRoomID = table.Column<Guid>(nullable: false),
                    RoomID = table.Column<Guid>(nullable: false),
                    StaffID = table.Column<Guid>(nullable: false),
                    StaffID1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffRooms", x => x.StaffRoomID);
                    table.ForeignKey(
                        name: "FK_staffRooms_rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "rooms",
                        principalColumn: "RoomsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_staffRooms_rates_StaffID",
                        column: x => x.StaffID,
                        principalTable: "rates",
                        principalColumn: "RateID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_staffRooms_staffs_StaffID1",
                        column: x => x.StaffID1,
                        principalTable: "staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookingStatusID",
                table: "Bookings",
                column: "BookingStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_GuestID",
                table: "Bookings",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_HotelID",
                table: "Bookings",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ReservationAgentID",
                table: "Bookings",
                column: "ReservationAgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomsBookedID",
                table: "Bookings",
                column: "RoomsBookedID");

            migrationBuilder.CreateIndex(
                name: "IX_bookingStatuses_BookingStatusID1",
                table: "bookingStatuses",
                column: "BookingStatusID1");

            migrationBuilder.CreateIndex(
                name: "IX_bookingStatuses_ReservationAgentsReservationAgentID",
                table: "bookingStatuses",
                column: "ReservationAgentsReservationAgentID");

            migrationBuilder.CreateIndex(
                name: "IX_payments_PaymentStatusID",
                table: "payments",
                column: "PaymentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_payments_PaymentTypeID",
                table: "payments",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_payments_RoomID",
                table: "payments",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_paymentStatuses_PaymentTypesPaymentTypeID",
                table: "paymentStatuses",
                column: "PaymentTypesPaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_rates_PositionsPositionID",
                table: "rates",
                column: "PositionsPositionID");

            migrationBuilder.CreateIndex(
                name: "IX_rates_RateTypeID",
                table: "rates",
                column: "RateTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_rates_RoomsID",
                table: "rates",
                column: "RoomsID");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_RoomStatusID",
                table: "rooms",
                column: "RoomStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_RoomTypeID",
                table: "rooms",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_roomsBookeds_RoomsBookedRoomBookedID",
                table: "roomsBookeds",
                column: "RoomsBookedRoomBookedID");

            migrationBuilder.CreateIndex(
                name: "IX_staffRooms_RoomID",
                table: "staffRooms",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_staffRooms_StaffID",
                table: "staffRooms",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_staffRooms_StaffID1",
                table: "staffRooms",
                column: "StaffID1");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_PositionID",
                table: "staffs",
                column: "PositionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "staffRooms");

            migrationBuilder.DropTable(
                name: "bookingStatuses");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "roomsBookeds");

            migrationBuilder.DropTable(
                name: "paymentStatuses");

            migrationBuilder.DropTable(
                name: "hotels");

            migrationBuilder.DropTable(
                name: "rates");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "reservationAgents");

            migrationBuilder.DropTable(
                name: "paymentTypes");

            migrationBuilder.DropTable(
                name: "rateTypes");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "roomStatuses");

            migrationBuilder.DropTable(
                name: "roomTypes");
        }
    }
}
