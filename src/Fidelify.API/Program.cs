using Fidelify.Infrastructure;
using Fidelify.Application;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();

    builder.Services.AddApplication();
    builder.Services.AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
    app.MapControllers();
    app.UseHttpsRedirection();
    app.Run();
}


