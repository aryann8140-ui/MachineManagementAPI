using MachineManagementAPI.Data;
using MachineManagementAPI.Repository;
using MachineManagementAPI.Repository.Interface;
using MachineManagementAPI.Services;
using MachineManagementAPI.Services.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EFContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IMachineRepo,MachineRepo>();
builder.Services.AddScoped<IMaintenanceRepo,MaintenanceRepo>();
builder.Services.AddScoped<IOperatorRepo,OperatorRepo>();
builder.Services.AddScoped<IMachineService,MachineService>();
builder.Services.AddScoped<IMaintenanceService,MaintenanceService>();
builder.Services.AddScoped<IOperatorService,Operatorservice>();


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();


