using Xunit;
using Temperature;


namespace TemperatureTests;

public class UnitTest
{
  [Fact]
  public void Given0CelciusOutput32Fahrenheit()
  {
    Conversion conversion = new Conversion();
    double expected = 32;
    double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100CelciusOutput212Fahrenheit()
  {
    Conversion conversion = new Conversion();
    double expected = 212;
    double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given0KelvinOutput_4594Fahrenheit()
  {
    Conversion conversion = new Conversion();
    double expected = -459.4;
    double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100KelvinOutput_2794Fahrenheit()
  {
    Conversion conversion = new Conversion();
    double expected = -279.4;
    double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given32FahrenheitOutput0Celcius()
  {
    Conversion conversion = new Conversion();
    double expected = 0;
    double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, 32);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100FahrenheitOutput3778Celcius()
  {
    Conversion conversion = new Conversion();
    double expected = 37.78;
    double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given0CelciusOutput273Kelvin()
  {
    Conversion conversion = new Conversion();
    double expected = 273;
    double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100CelciusOutput373Kelvin()
  {
    Conversion conversion = new Conversion();
    double expected = 373;
    double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given0KelvinOutput_273Celcius()
  {
    Conversion conversion = new Conversion();
    double expected = -273;
    double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100KelvinOutput_173Celcius()
  {
    Conversion conversion = new Conversion();
    double expected = -173;
    double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given0FahrenheightOutput25522Kelvin()
  {
    Conversion conversion = new Conversion();
    double expected = 255.22;
    double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100FahrenheitOutput31078Kelvin()
  {
    Conversion conversion = new Conversion();
    double expected = 3;
    double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, 100);
    Assert.Equal(expected, actual);
  }
}