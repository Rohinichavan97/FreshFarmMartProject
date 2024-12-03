using Core;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class Context:DbContext

    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            modelBuilder.Entity<Country>().HasData(
                new Country() { CountryID = 1, CountryName = "India" }
               );

            modelBuilder.Entity<State>().HasData(
                 new State() { StateID = 1, StateName = "Maharashtra", CountryID = 1 }
                );

            modelBuilder.Entity<City>().HasData(
                 new City() { CityID = 1, CityName = "Pune", StateID = 1 }
                );
            modelBuilder.Entity<Admin>().HasData(
                new Admin() { AdminId = 1, FirstName = "Pravin", LastName = "Chavan", EmailID = "pravinchavan@gmail.com",
                    MobileNo = "98745635487", Password = "abcd" }
             );
            modelBuilder.Entity<TraderFarmer>().HasData(
               new TraderFarmer()
               {
                   TraderFarmerID = 1,
                   TradeName = "Rahul",
                   Address = "Kolhapur",
                   Password="acbd",
                   EmailID ="rahul@gmail.com",
                   MobileNo="9874587658",
                   PinCode = "416209",
                   CityID = 1,
                   ContactPerson = "Minal",
                   RegistrationDate=DateTime.Now,
                   ActiveFlag=true
               }
            );
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> states { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<TraderFarmer> TraderFarmers { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<TraderFarmerTermsCondition> TraderFarmerTermsConditions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
        public DbSet<UserOrderComplaint> UserOrderComplaints { get; set; }
        public DbSet<UserOrderComplaintSolution> UserOrderComplaintSolutions { get; set; }
        public DbSet<UserOrderDet> UserOrderDets { get; set; }
        public DbSet<UserOrderPayment> UserOrderPayments { get; set; }
        public DbSet<UserTermsCondition> UserTermsConditions { get; set; }
        public DbSet<ComplaintRefund> ComplaintRefunds { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<OrderDispatch> OrderDispatches { get; set; }
        public DbSet<DispatchAgency> DispatchAgencies { get; set; }
    }
}
