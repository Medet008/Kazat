// ��������� ������������ ����, � ������� ��������� �����
namespace API
{
    // ���������� ����� "WeatherForecast"
    public class WeatherForecast
    {
        // ���������� �������� "Date", ������� ���� "DateOnly"
        public DateOnly Date { get; set; }

        // ���������� �������� "TemperatureC", ������� ���� "int"
        public int TemperatureC { get; set; }

        // ���������� �������� "TemperatureF", ������� ���� "int" � ����������� �� ������ �������� "TemperatureC"
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        // ���������� �������� "Summary", ������� ���� "string" � ����� ���� ������ (nullable)
        public string? Summary { get; set; }
    }
}