using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace APIreq
{
    class Helper
    {
        public static double ToC(double kelvin_temperature) {
            return kelvin_temperature - 273.15;
        }

        public static DateTime? ConvertUnixTimeStamp(long unixTimeStamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(unixTimeStamp));
        }
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    class FormatData
    {
        public double Lat;
        public double Lon;

        public string Timezone;
        public int TimezoneOffset;
        public Current Current;
        public List<MinutelyWeather> Minutely;
        public List<HourlyWeather> Hourly;
        public List<DailyWeather> Daily;
        public List<Alert> Alerts;
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    class CurrentWeather
    {
        public int Id;
        public string Main;
        public string Description;
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    class MinutelyWeather
    {
        public long Dt;
        public int Precipitation;    
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    class HourlyWeather 
    {
        public long Dt;
        public double Temp;
        public int Pressure;
        public int Humidity;
        public double WindSpeed;
        
        public List<CurrentWeather> Weather;
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    class FeelsLike
    {
        public double Day;
        public double Night;
        public double Eve;
        public double Morn;

        // Temperature t -> t.day_c;
        public double DayC {
            get => Helper.ToC(this.Day);
        }

        public double NightC {
            get => Helper.ToC(this.Night);
        }

        public double EveC {
            get => Helper.ToC(this.Eve);
        }
        
        public double MornC {
            get => Helper.ToC(this.Morn);
        }
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    class Temperature : FeelsLike
    {
        public double Min;
        public double Max;

        public double MinC {
            get => Helper.ToC(this.Min);
        }

        public double MaxC {
            get => Helper.ToC(this.Max);
        }
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    class DailyWeather
    {
        public long Dt;
        public long Sunrise;
        public long Sunset;
        public long Moonrise;
        public long Moonset;
        public double MoonPhase;
        public Temperature Temp;
        public FeelsLike FeelsLike;
        public int Pressure;
        public int Humidity;
        public double DewPoint;
        
        public List<CurrentWeather> Weather;
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    class Alert
    {
        public string SenderName;
        public string Event;
        public long Start;
        public long End;
        public string Description;
        public List<string> Tags;
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    class Current
    {
        public long Dt;
        public long Sunrise;
        public double Temp;
        public int Pressure;
        public int Humidity;

        public List<CurrentWeather> Weather;

        public CurrentWeather? CurrentWeather {
            get {
                if (this.Weather.Any()) {
                    return this.Weather.First();
                } else {
                    return null;
                }
            }
        }

        public double TempC {
            get => Helper.ToC(this.Temp);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
