using App20220513_3.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages().AddRazorPagesOptions(options => {
   options.Conventions.AddPageRoute("/Arduino", "/");
});

builder.Services.AddSingleton<ArduinoService>();

var app = builder.Build();

app.MapControllers();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
