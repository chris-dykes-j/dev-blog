using DevBlog.Context;
using DevBlog.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBlogRepository, BlogRepository>();

builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("BlogEntryConnection")));

var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.Run();