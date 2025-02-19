﻿//Tworzenie konfiguracji dla aplikacji konsolowej
using Microsoft.Extensions.Configuration;

IConfigurationBuilder builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddUserSecrets(typeof(Program).Assembly, optional:true);

IConfigurationRoot config = builder.Build();
//Koniec tworzenia konfiguracji

Console.WriteLine("I think the password is... " + config["Password"]);
