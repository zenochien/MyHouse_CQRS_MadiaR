﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Service.Data;

namespace MyHouse_CQRS_MadiaR.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20210106042644_changeKey")]
    partial class changeKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Service.Data.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingStatusID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<int>("ReservationAgentID")
                        .HasColumnType("int");

                    b.Property<string>("RoomCount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomsBookedID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("BookingStatusID");

                    b.HasIndex("GuestID");

                    b.HasIndex("HotelID");

                    b.HasIndex("ReservationAgentID");

                    b.HasIndex("RoomsBookedID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Service.Data.BookingStatus", b =>
                {
                    b.Property<int>("BookingStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BookingStatusID1")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservationAgentsReservationAgentID")
                        .HasColumnType("int");

                    b.Property<string>("SortOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingStatusID");

                    b.HasIndex("BookingStatusID1");

                    b.HasIndex("ReservationAgentsReservationAgentID");

                    b.ToTable("bookingStatuses");
                });

            modelBuilder.Entity("Service.Data.Guests", b =>
                {
                    b.Property<int>("GuestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellularNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCOde")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eMailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("GuestID");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("Service.Data.Hotels", b =>
                {
                    b.Property<int>("HotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyeMailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Main")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Motto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TooIIFreeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCOde")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelID");

                    b.ToTable("hotels");
                });

            modelBuilder.Entity("Service.Data.PaymentStatus", b =>
                {
                    b.Property<int>("PaymentStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaymentTypesPaymentTypeID")
                        .HasColumnType("int");

                    b.Property<string>("SortOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentStatusID");

                    b.HasIndex("PaymentTypesPaymentTypeID");

                    b.ToTable("paymentStatuses");
                });

            modelBuilder.Entity("Service.Data.PaymentTypes", b =>
                {
                    b.Property<int>("PaymentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SortOrder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypeID");

                    b.ToTable("paymentTypes");
                });

            modelBuilder.Entity("Service.Data.Payments", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Payment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentStatsID")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentStatusID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentTypeID")
                        .HasColumnType("int");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("PaymentStatusID");

                    b.HasIndex("PaymentTypeID");

                    b.HasIndex("RoomID");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("Service.Data.Positions", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SortOrder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Service.Data.RateTypes", b =>
                {
                    b.Property<int>("RateTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RateType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SortOrder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RateTypeID");

                    b.ToTable("rateTypes");
                });

            modelBuilder.Entity("Service.Data.Rates", b =>
                {
                    b.Property<int>("RateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PositionsPositionID")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("RateTypeID")
                        .HasColumnType("int");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int?>("RoomsID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RateID");

                    b.HasIndex("PositionsPositionID");

                    b.HasIndex("RateTypeID");

                    b.HasIndex("RoomsID");

                    b.ToTable("rates");
                });

            modelBuilder.Entity("Service.Data.ReservationAgents", b =>
                {
                    b.Property<int>("ReservationAgentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellularNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCOde")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eMailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservationAgentID");

                    b.ToTable("reservationAgents");
                });

            modelBuilder.Entity("Service.Data.RoomStatus", b =>
                {
                    b.Property<int>("RoomStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomsStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SortOrder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomStatusID");

                    b.ToTable("roomStatuses");
                });

            modelBuilder.Entity("Service.Data.RoomTypes", b =>
                {
                    b.Property<int>("RoomTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SortOrder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeID");

                    b.ToTable("roomTypes");
                });

            modelBuilder.Entity("Service.Data.Rooms", b =>
                {
                    b.Property<int>("RoomsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomStatusID")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeID")
                        .HasColumnType("int");

                    b.HasKey("RoomsID");

                    b.HasIndex("RoomStatusID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("Service.Data.RoomsBooked", b =>
                {
                    b.Property<int>("RoomBookedID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int?>("RoomsBookedRoomBookedID")
                        .HasColumnType("int");

                    b.HasKey("RoomBookedID");

                    b.HasIndex("RoomsBookedRoomBookedID");

                    b.ToTable("roomsBookeds");
                });

            modelBuilder.Entity("Service.Data.Staff", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellularNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCOde")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eMailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffID");

                    b.HasIndex("PositionID");

                    b.ToTable("staffs");
                });

            modelBuilder.Entity("Service.Data.StaffRooms", b =>
                {
                    b.Property<int>("StaffRoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.Property<int?>("StaffID1")
                        .HasColumnType("int");

                    b.HasKey("StaffRoomID");

                    b.HasIndex("RoomID");

                    b.HasIndex("StaffID");

                    b.HasIndex("StaffID1");

                    b.ToTable("staffRooms");
                });

            modelBuilder.Entity("Service.Data.Booking", b =>
                {
                    b.HasOne("Service.Data.BookingStatus", "BookingStatus")
                        .WithMany()
                        .HasForeignKey("BookingStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Data.Guests", "Guests")
                        .WithMany("Bookings")
                        .HasForeignKey("GuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Data.Hotels", "Hotels")
                        .WithMany("Bookings")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Data.ReservationAgents", "ReservationAgents")
                        .WithMany()
                        .HasForeignKey("ReservationAgentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Data.RoomsBooked", "RoomsBookeds")
                        .WithMany()
                        .HasForeignKey("RoomsBookedID");
                });

            modelBuilder.Entity("Service.Data.BookingStatus", b =>
                {
                    b.HasOne("Service.Data.BookingStatus", null)
                        .WithMany("BookingStatuses")
                        .HasForeignKey("BookingStatusID1");

                    b.HasOne("Service.Data.ReservationAgents", null)
                        .WithMany("Bookings")
                        .HasForeignKey("ReservationAgentsReservationAgentID");
                });

            modelBuilder.Entity("Service.Data.PaymentStatus", b =>
                {
                    b.HasOne("Service.Data.PaymentTypes", null)
                        .WithMany("PaymentStatuses")
                        .HasForeignKey("PaymentTypesPaymentTypeID");
                });

            modelBuilder.Entity("Service.Data.Payments", b =>
                {
                    b.HasOne("Service.Data.PaymentStatus", "PaymentStatus")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentStatusID");

                    b.HasOne("Service.Data.Hotels", "PaymentTypes")
                        .WithMany()
                        .HasForeignKey("PaymentTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Data.Rooms", "Rooms")
                        .WithMany("Payments")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Service.Data.Rates", b =>
                {
                    b.HasOne("Service.Data.Positions", null)
                        .WithMany("Staffs")
                        .HasForeignKey("PositionsPositionID");

                    b.HasOne("Service.Data.RateTypes", "RateTypes")
                        .WithMany("Rates")
                        .HasForeignKey("RateTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Data.Rooms", null)
                        .WithMany("Rates")
                        .HasForeignKey("RoomsID");
                });

            modelBuilder.Entity("Service.Data.Rooms", b =>
                {
                    b.HasOne("Service.Data.RoomStatus", null)
                        .WithMany("Rooms")
                        .HasForeignKey("RoomStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Data.RoomTypes", "RoomTypes")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Service.Data.RoomsBooked", b =>
                {
                    b.HasOne("Service.Data.RoomsBooked", null)
                        .WithMany("Bookingrooms")
                        .HasForeignKey("RoomsBookedRoomBookedID");
                });

            modelBuilder.Entity("Service.Data.Staff", b =>
                {
                    b.HasOne("Service.Data.Positions", "Positions")
                        .WithMany()
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Service.Data.StaffRooms", b =>
                {
                    b.HasOne("Service.Data.Rooms", "Rooms")
                        .WithMany("StaffRooms")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Data.Rates", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Data.Staff", null)
                        .WithMany("StaffRooms")
                        .HasForeignKey("StaffID1");
                });
#pragma warning restore 612, 618
        }
    }
}
