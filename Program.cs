using MultiShop.DataAccesLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MultiShopContext>();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
app.Run();



