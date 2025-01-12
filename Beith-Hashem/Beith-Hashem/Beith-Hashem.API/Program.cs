using Beith_Hashem.Core.Repositories;
using Beith_Hashem.Core.Services;
using Beith_Hashem.Data;
using Beith_Hashem.Data.Repositories;
using Beith_Hashem.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddScoped<IMemberRepository, MemberRepository> ();
builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataContext>();





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IMemberService, WorkerService>();
builder.Services.AddScoped<IMemberRepository, MemberRepository>();
builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddSingleton<DataContext>();

//builder.Services.AddDbContext<DataContex>(
//    options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=my_db"));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
