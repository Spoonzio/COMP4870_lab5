using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TemperatureWeb.Models;
using Temperature;


namespace TemperatureWeb.Controllers;

public class ConvertController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public List<string> TemperatureUnits = new List<string>(){"Celsius", "Fahrenheit", "Kelvin"};

    public ConvertController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["ToTempValue"] = null;
        return View();
    }

    [HttpPost]
    public IActionResult Index(int fromTempValue, String fromTempUnit, String toTempUnit)
    {
        Conversion c = new Conversion();
        char fromTempChar = fromTempUnit[0];
        char toTempChar = toTempUnit[0];
        double result = 0.0;

        //====================================
        //  Done is better than perfect!
        //====================================

        if(fromTempChar == toTempChar){
            ViewData["FromTempValue"] = fromTempValue;
            ViewData["ToTempValue"] = fromTempValue;
            return View(); 
        }

        switch (fromTempChar) {
            case 'C':
                switch (toTempChar) {
                    case 'K':
                        result = c.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, fromTempValue);
                        break;
                    case 'F':
                        result = c.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, fromTempValue);
                        break;
                }
                break;
            case 'K':
                switch (toTempChar) {
                    case 'C':
                        result = c.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, fromTempValue);
                        break;
                    case 'F':
                        result = c.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, fromTempValue);
                        break;
                }
                break;
            case 'F':
                switch (toTempChar) {
                    case 'C':
                        result = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, fromTempValue);
                        break;
                    case 'K':
                        result = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, fromTempValue);
                        break;
                }
                break;
        }

        Console.WriteLine(result);
        ViewData["FromTempValue"] = fromTempValue;
        ViewData["ToTempValue"] = result;
        return View(); 
    }

}
