using Infra;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(
     opt =>
     {
         opt.IdleTimeout = TimeSpan.FromMinutes(20);
         opt.Cookie.HttpOnly = true;
         opt.Cookie.IsEssential = true;
     }
    );
builder.Services.AddControllersWithViews();

string scon = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<Context>(
     opt => opt.UseLazyLoadingProxies().UseSqlServer(scon)
    );

builder.Services.AddScoped<IAdminRepo, AdminRepo>();
builder.Services.AddScoped<ICountryRepo, CountryRepo>();
builder.Services.AddScoped<IStateRepo, StateRepo>();
builder.Services.AddScoped<ICityRepo, CityRepo>();
builder.Services.AddScoped<ITraderFarmerRepo, TraderFarmerRepo>();
builder.Services.AddScoped<IMainCategoryRepo, MainCategoryRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<IUnitRepo, UnitRepo>();
builder.Services.AddScoped<ITraderFarmerTermsConditionRepo, TraderFarmerTermsConditionRepo>();
builder.Services.AddScoped<IProductRepo, ProductRep>();
builder.Services.AddScoped<IProductDiscountRepo, ProductDiscountRepo>();
builder.Services.AddScoped<IProductAndProductDiscountRepo, ProductAndProductDiscountRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<ISearchProductRepo, SearchProductRepo>();
builder.Services.AddScoped<IProductPhotoRepo, ProductPhotoRepo>();
builder.Services.AddScoped<IOrderRepo, OrderRepo>();
builder.Services.AddScoped<IProductReviewRepo, ProductReviewRepo>();
builder.Services.AddScoped<ICartRepo,CartRepo>();
builder.Services.AddScoped<IDispatchAgencyRepo, DispatchAgencyRepo>();
builder.Services.AddScoped<IWishListRepo, WishListRepo>();




var app = builder.Build();
app.UseSession();
app.UseStaticFiles();
app.MapControllerRoute("area", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();

app.Run();
