using Inquiry.API.Post.Application;
using Inquiry.API.Post.Infrastructure.Configuration;
using Inquiry.API.Post.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Add AutoMapper
builder.Services.AddAutoMapper(typeof(CustomMap));

//Add DbContext
builder.Services.AddDbContext<InquiryPostContext>();

//Add LogService
builder.Services.AddScoped<LogService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add your service registration here
builder.Services.AddScoped<IInquiryPost, InquiryPost>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
