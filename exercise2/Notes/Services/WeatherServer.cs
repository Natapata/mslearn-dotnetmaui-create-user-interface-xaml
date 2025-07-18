﻿using Notes.Models;

namespace Notes.Services
{
    internal static class WeatherServer
    {
        public static async Task<WeatherData> GetWeather(string postalCode)
        {
            // Random generate an enum value
            int totalWeatherTypes = Enum.GetNames<WeatherType>().Length;

            // Delay 2 seconds to simulate talking to a remote server
            await Task.Delay(TimeSpan.FromSeconds(2));

            WeatherData data = new()
            {
                Temperature = Random.Shared.Next(10, 40),
                Condition = (WeatherType)Random.Shared.Next(0, totalWeatherTypes),
                Humidity = Random.Shared.Next(0, 101),
                Precipitation = Random.Shared.Next(0, 101),
                Wind = Random.Shared.Next(0, 30)
            };

            // Return the weather type
            return data;
        }
    }
}
