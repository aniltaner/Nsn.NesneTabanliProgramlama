using Nsn.Application;
using Nsn.Application.Exceptions;
using Nsn.Mapper;
using Nsn.Persistance;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// OpenAPI (Swagger yerine yeni nesil) yapılandırması
builder.Services.AddOpenApi();

var env = builder.Environment;

// Appsettings yapılandırması
builder.Configuration
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

// Senin projendeki servis kayıtları (Extension metotlar üzerinden)
builder.Services.AddPersistance(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddCustomMapper();

var app = builder.Build();

// HTTP request pipeline yapılandırması
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// SwaggerUI yerine hocanın kullandığı Scalar arayüzü
app.MapScalarApiReference(options =>
{
    options.Title = "Nesne Programlama Projesi";
    options.Theme = ScalarTheme.Default;
});

// Hocanın yazdığı hata yakalama middleware'i
app.ConfigureExceptionHandlingMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
