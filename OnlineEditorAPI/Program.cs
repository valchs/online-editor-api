using OnlineEditor.Repository.Files;
using OnlineEditor.Services.Interfaces;
using OnlineEditor.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "myCors",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000", "https://nice-sea-0e687dd03.4.azurestaticapps.net")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                      });
});

builder.Services.AddSignalR();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IFileService, FileService>();
builder.Services.AddTransient<IFileRepository, FileRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("myCors");

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<SignalRHub>("/hub");
});

app.Run();
