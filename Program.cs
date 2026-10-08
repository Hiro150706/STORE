using Store_Tec_API_GET.Data;
var builder = WebApplication.CreateBuilder(args); builder.Services.AddControllers(); builder.Services.AddSingleton<StoreData>(); var app=builder.Build(); app.MapControllers(); app.Run();
