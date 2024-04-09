public void ConfigureServices(IServiceCollection services)
{
    services.AddCors();
}

public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    // ...

    // Shows UseCors with CorsPolicyBuilder.
    app.UseCors(builder =>
         builder.WithOrigins("https://black-pond-07bc3a803.5.azurestaticapps.net")
                .AllowAnyMethod()
                .AllowCredentials());

    app.UseMvc();

    // ...
}