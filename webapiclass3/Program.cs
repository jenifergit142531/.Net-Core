using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.OData;

using webapiclass3.Model;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//configuring the OData


builder.Services.AddControllers().
    AddOData(options => options
    .Select()
    .Filter()
    .OrderBy()
    .Count()
    .Expand()
    );









//builder.Services.AddSwaggerGen();

// service to add routing

//builder.Services.AddRouting();

/*
//xml formatter
builder.Services.AddControllers().AddXmlSerializerFormatters();

//Json formatter
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});

//Accepting to all browers

builder.Services.AddControllers(options =>
{
    options.RespectBrowserAcceptHeader = true;

});
*/

//Remove the formatter

/*builder.Services.AddControllers(options =>
{
    options.OutputFormatters.RemoveType<StringOutputFormatter>();
    options.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
    options.OutputFormatters.RemoveType<XmlSerializerOutputFormatter>();
    options.OutputFormatters.RemoveType<TextOutputFormatter>();
    //options.OutputFormatters.RemoveType<SystemTextJsonOutputFormatter>();
});*/






//adding DI to the middleware
builder.Services.AddScoped<IParking, ParkingInformation>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   // app.UseSwagger();
   // app.UseSwaggerUI();
}

/*var route = new RouteBuilder(app);
route.MapGet("", context => context.Response.WriteAsync("This is a default Route"));
route.MapGet("info/details", context => context.Response.WriteAsync("This is a Route details on the parking"));
route.MapGet("info/show", context => context.Response.WriteAsync("This is a string method "));

app.UseRouter(route.Build());*/


//app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
