using Project.Application;
using Project.Application.BMF;
using Project.Application.Reports;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Register the IReportFactory implementation
builder.Services.AddScoped<IReportFactory, ReportFactory>();
builder.Services.AddScoped<IReports, ReportBMF>();
builder.Services.AddScoped<IReports, ReportBolsa>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
