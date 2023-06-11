using Chapter.Contexts;
using Chapter.Interfaces;
using Chapter.Repositories;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddCors(options  =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy.WithOrigins("https://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
}
);
builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = "JwtBearer";
    options.DefaultAuthenticateScheme = "JwtBearer";
}).AddJwtBearer("JwtBearer", options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("chapter-chave-autenticacao")),
        ClockSkew = TimeSpan.FromMinutes(60),
        ValidAudience = "chapter.webapi",
        ValidIssuer = "chapter.webapi"

    };
});



builder.Services.AddScoped<Sqlcontext, Sqlcontext>();
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Cors
//app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
