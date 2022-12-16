using DevBlog.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBlogRepository, MockBlogRepository>();

var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.Run();