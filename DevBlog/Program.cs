using DevBlog.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBlogRepository, BlogRepository>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.Run();