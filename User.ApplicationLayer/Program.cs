using Microsoft.EntityFrameworkCore;
using User.ApplicationLayer.Controllers;
using User.BLL;
using User.BLL.Services;
using User.DAL.Data;
using User.DAL.Repository.IRepository;
using User.DAL.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerUI;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
	.WriteTo.File("log/UserProfile.txt",rollingInterval:RollingInterval.Day).CreateLogger();
builder.Host.UseSerilog();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<LocalUserService>();
builder.Services.AddScoped<LoginServices>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddResponseCaching();

 builder.Services.AddApiVersioning(options => {
	 options.AssumeDefaultVersionWhenUnspecified = true;
	 options.DefaultApiVersion = new ApiVersion(1, 0);
	 options.ReportApiVersions = true;
	 
});

builder.Services.AddVersionedApiExplorer(options =>
{
	options.GroupNameFormat = "'v'VVV";
	options.SubstituteApiVersionInUrl = true;
});







var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");
builder.Services.AddAuthentication(x =>
{
	x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
	.AddJwtBearer(x => {
		x.RequireHttpsMetadata = false;
		x.SaveToken = true;
		x.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateIssuerSigningKey = true,
			IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
			ValidateIssuer = false,
			ValidateAudience = false
		};
	});

builder.Services.AddSwaggerGen(options => {
	options.SwaggerDoc("v1", new OpenApiInfo
	{
		Version = "v1.0",
		Title = "OnlineBookStore V1",
	});
	options.SwaggerDoc("v2", new OpenApiInfo
	{
		Version = "v2.0",
		Title = "OnlineBookStore V2",
	});
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
	app.UseSwaggerUI(options => {
		
		options.SwaggerEndpoint("/swagger/v1/swagger.json", "OnlineBookStoreV1");
		options.SwaggerEndpoint("/swagger/v2/swagger.json", "OnlineBookStoreV2");

	});
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
