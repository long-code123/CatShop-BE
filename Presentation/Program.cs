using Presentation.Installers;

namespace Presentation
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.InstallServicesInAssembly(builder.Configuration);

            var app = builder.Build();

            app.ConfigureRequestPiplineInAssembly();

            app.Run();
        }
    }
}
