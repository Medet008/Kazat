var builder = WebApplication.CreateBuilder(args);  // Создаем экземпляр приложения

// Add services to the container.
builder.Services.AddControllers();  // Добавляем контроллеры в контейнер зависимостей

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();  // Добавляем поддержку генерации документации для Swagger

builder.Services.AddSwaggerGen();  // Добавляем Swagger

var app = builder.Build();  // Создаем экземпляр приложения на основе настроек

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())  // Проверяем, что приложение находится в режиме разработки
{
    app.UseSwagger();  // Используем Swagger
    app.UseSwaggerUI();  // Используем Swagger UI
}

app.UseHttpsRedirection();  // Включаем перенаправление на HTTPS

app.UseAuthorization();  // Добавляем авторизацию

app.MapControllers();  // Добавляем контроллеры

app.Run();  // Запускаем приложение