using Microsoft.AspNetCore.ResponseCompression;
using Sundhed.Bmi.Application.Command;
using Sundhed.Bmi.Application.Command.Implementation;
using Sundhed.Bmi.Application.Repositories;
using Sundhed.Bmi.Infrastructor.Rpositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


// clean architecture
builder.Services.AddScoped<ICreateBmiCommand, CreateBmiCommand>();
builder.Services.AddScoped<IBmiRepository, BmiRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
