using API.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);  // ������� ��������� ����������

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultDbContext"));
});

builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
// Add services to the container.
builder.Services.AddControllers();  // ��������� ����������� � ��������� ������������

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();  // ��������� ��������� ��������� ������������ ��� Swagger

builder.Services.AddSwaggerGen();  // ��������� Swagger

var app = builder.Build();  // ������� ��������� ���������� �� ������ ��������

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())  // ���������, ��� ���������� ��������� � ������ ����������
{
    app.UseSwagger();  // ���������� Swagger
    app.UseSwaggerUI();  // ���������� Swagger UI
}

app.UseHttpsRedirection();  // �������� ��������������� �� HTTPS

app.UseAuthorization();  // ��������� �����������

app.MapControllers();  // ��������� �����������

app.Run();  // ��������� ����������