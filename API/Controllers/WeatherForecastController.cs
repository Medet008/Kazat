using Microsoft.AspNetCore.Mvc; // Подключаем пространство имен Microsoft.AspNetCore.Mvc для доступа к типам контроллеров

namespace API.Controllers // Определяем пространство имен и название класса контроллера
{
    [ApiController] // Указываем, что данный контроллер является атрибутом API-контроллера
    [Route("[controller]")] // Указываем маршрут к этому контроллеру (в данном случае, это будет /WeatherForecast)
    public class WeatherForecastController : ControllerBase // Определяем класс контроллера, наследуемый от базового класса ControllerBase
    {
        private static readonly string[] Summaries = new[] // Определяем массив строк, который будет использоваться для генерации случайных описаний погоды
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger; // Определяем логгер для контроллера

        public WeatherForecastController(ILogger<WeatherForecastController> logger) // Определяем конструктор контроллера
        {
            _logger = logger; // Инициализируем логгер контроллера
        }

        [HttpGet(Name = "GetWeatherForecast")] // Определяем метод обработки HTTP GET-запросов к этому контроллеру
        public IEnumerable<WeatherForecast> Get() // Определяем возвращаемый тип - коллекцию объектов класса WeatherForecast
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast // Генерируем 5 объектов класса WeatherForecast и возвращаем их в виде коллекции
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)), // Определяем дату для каждого объекта класса WeatherForecast
                TemperatureC = Random.Shared.Next(-20, 55), // Определяем температуру в градусах Цельсия для каждого объекта класса WeatherForecast
                Summary = Summaries[Random.Shared.Next(Summaries.Length)] // Определяем случайное описание погоды для каждого объекта класса WeatherForecast, используя массив строк Summaries
            })
            .ToArray(); // Преобразуем коллекцию в массив и возвращаем его
        }
    }
}