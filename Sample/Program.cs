using Application.Concrete;
using Application.Contracts;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete;
using Repository.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connString = builder.Configuration.GetConnectionString("MyConnection");
builder.Services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(connString, b => b.MigrationsAssembly("Sample")));

builder.Services.AddAutoMapper(typeof(Application.DomainTransferObjects.LenderTypePostDTO));
builder.Services.AddControllersWithViews();


builder.Services.AddScoped<ILenderRepository, LenderRepository>();
builder.Services.AddScoped<ILenderService, LenderService>();

builder.Services.AddScoped<ILenderTypeRepository, LenderTypeRepository>();
builder.Services.AddScoped<ILenderTypeService, LenderTypeService>();

builder.Services.AddScoped<ILoanRepository, LoanRepository>();
builder.Services.AddScoped<ILoanService, LoanService>();

builder.Services.AddScoped<ILoanStatusRepository, LoanStatusRepository>();
builder.Services.AddScoped<ILoanStatusService, LoanStatusService>();

builder.Services.AddScoped<ILenderTypeLocalizationRepository, LenderTypeLocalizationRepository>();
builder.Services.AddScoped<ILenderTypeLocalizationService, LenderTypeLocalizationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
