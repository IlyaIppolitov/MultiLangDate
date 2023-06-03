using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
// builder - паттерн проектирование Строитель (Builder)

var app = builder.Build();

app.MapGet("/local_date", (string? lang) => (getDateString(lang)));

app.Run();

string getDateString(string? language)
{
    var _cultureInfo = new CultureInfo("ru");
    if (language is not null)
    {
        _cultureInfo = new CultureInfo(language);
    }
    return DateTime.Now.ToString("D",_cultureInfo);
}