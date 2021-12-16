using Microsoft.Extensions.DependencyInjection;
using System;
using UniversityManager.Service;

namespace DeepL
{
    class Program
    {

        static void Main(string[] args)
        {
            // Create service collection
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Create service provider
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            try
            {
                //serviceProvider.GetService<IStudentService>().Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }


        internal static void ConfigureServices(IServiceCollection services)
        {
            //AutoMapper
            //services.AddAutoMapper(typeof(AutoMapperProfile));

            //// Build configuration
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            //    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
            //    .Build();

            //// Add context for database
            //services.AddDbContext<OdysseeDbContext>(options => { options.UseSqlServer(configuration.GetConnectionString("OdysseeConnection")); });

            //ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            //{
            //    builder.AddFilter("Microsoft", LogLevel.Warning)
            //            .AddFilter("System", LogLevel.Warning)
            //            .AddConsole(configure => {
            //                configure.FormatterName = ConsoleFormatterNames.Systemd;
            //            });
            //});
            //loggerFactory.AddGelf(new GelfLoggerOptions
            //{
            //    LogSource = configuration.GetSection("GELF")["LogSource"],
            //    Host = configuration.GetSection("GELF")["Host"]
            //});


            ////Add grayLog Factory
            //services.AddSingleton(loggerFactory);

            //// Add logging
            //services.AddLogging();

            ////Add smtp connexion
            //services.TryAddSingleton(new SmtpClient()
            //{
            //    Host = configuration.GetSection("SmtpConnexion")["Host"],
            //    Port = Convert.ToInt32(configuration.GetSection("SmtpConnexion")["Port"])
            //});

            ////Add mail's informations
            //services.TryAddSingleton(new EmailAddress()
            //{
            //    FromEmail = configuration.GetSection("EmailAddress")["FromEmail"],
            //    DestinationEmails = configuration.GetSection("EmailAddress")["DestinationEmails"].Split(';').ToList()
            //});

            ////Add sftp's information
            //services.TryAddSingleton(new SftpClient(
            //    configuration.GetSection("SftpConnexion")["Host"],
            //    Convert.ToInt32(configuration.GetSection("SftpConnexion")["Port"]),
            //    configuration.GetSection("SftpConnexion")["UserName"],
            //    configuration.GetSection("SftpConnexion")["Password"]
            //    ));
            //ExcelGenerator.CflDestinationPath = configuration.GetSection("SftpConnexion")["Path"];

            //// Add google api service
            //services.TryAddSingleton<IGoogleGeocodingApi>(new GoogleGeocodingApi(
            //    configuration.GetSection("GoogleAPI")["Url"],
            //    configuration.GetSection("GoogleAPI")["Key"]));

            ////Add Stockage Network folders
            //services.TryAddSingleton(new StockageConfiguration()
            //{
            //    ArchiveDirectory = configuration.GetSection("StockageConfiguration")["ArchiveDirectory"],
            //    StockageDirectory = configuration.GetSection("StockageConfiguration")["StockageDirectory"]
            //});

            // Add Services
            services.AddServices();

        }

    }
}
