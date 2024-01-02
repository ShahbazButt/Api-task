using System.Collections.Generic;

namespace Api task.Server
{
    public class DbContext
{
    public DbContext(DbContextOptions<DbContext> options) : base(options) { }

    public DbSet<DbContext> YourModels { get; set; }
}
}
// Startup.cs
public void ConfigureServices(IServiceCollection services)
{
    // ...

    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
    });
}

public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    // ...

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
    });
}

