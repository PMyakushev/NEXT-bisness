HttpCliet hc = new HandleClient()
string url = "http://Localhost:5179/api/v2/WeatherForecast/getweather";
string json = hc.GetStringAsync(url).Result;
Systeam.Console.WriteLine(joson)