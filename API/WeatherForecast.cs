// указываем пространство имен, в котором находится класс
namespace API
{
    // определяем класс "WeatherForecast"
    public class WeatherForecast
    {
        // определяем свойство "Date", которое типа "DateOnly"
        public DateOnly Date { get; set; }

        // определяем свойство "TemperatureC", которое типа "int"
        public int TemperatureC { get; set; }

        // определяем свойство "TemperatureF", которое типа "int" и вычисляется на основе свойства "TemperatureC"
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        // определяем свойство "Summary", которое типа "string" и может быть пустым (nullable)
        public string? Summary { get; set; }
    }
}