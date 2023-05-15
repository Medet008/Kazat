using Microsoft.AspNetCore.Mvc; // ���������� ������������ ���� Microsoft.AspNetCore.Mvc ��� ������� � ����� ������������

namespace API.Controllers // ���������� ������������ ���� � �������� ������ �����������
{
    [ApiController] // ���������, ��� ������ ���������� �������� ��������� API-�����������
    [Route("[controller]")] // ��������� ������� � ����� ����������� (� ������ ������, ��� ����� /WeatherForecast)
    public class WeatherForecastController : ControllerBase // ���������� ����� �����������, ����������� �� �������� ������ ControllerBase
    {
        private static readonly string[] Summaries = new[] // ���������� ������ �����, ������� ����� �������������� ��� ��������� ��������� �������� ������
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger; // ���������� ������ ��� �����������

        public WeatherForecastController(ILogger<WeatherForecastController> logger) // ���������� ����������� �����������
        {
            _logger = logger; // �������������� ������ �����������
        }

        [HttpGet(Name = "GetWeatherForecast")] // ���������� ����� ��������� HTTP GET-�������� � ����� �����������
        public IEnumerable<WeatherForecast> Get() // ���������� ������������ ��� - ��������� �������� ������ WeatherForecast
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast // ���������� 5 �������� ������ WeatherForecast � ���������� �� � ���� ���������
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)), // ���������� ���� ��� ������� ������� ������ WeatherForecast
                TemperatureC = Random.Shared.Next(-20, 55), // ���������� ����������� � �������� ������� ��� ������� ������� ������ WeatherForecast
                Summary = Summaries[Random.Shared.Next(Summaries.Length)] // ���������� ��������� �������� ������ ��� ������� ������� ������ WeatherForecast, ��������� ������ ����� Summaries
            })
            .ToArray(); // ����������� ��������� � ������ � ���������� ���
        }
    }
}