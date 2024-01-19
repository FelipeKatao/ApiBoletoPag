using ApiPag.Data.Bano_dados;
using ApiPag.Data.Boleto_Dados;
using ApiPag.Dominio.Banco;
using ApiPag.Dominio.Boletos;
using ApiPag.Dominio.Cliente;
using ApiPag.Repository.Bancos;
using ApiPag.Repository.Boletos;
using ApiPag.Repository.Cliente;
using ApiPag.Repository.Interfaces;
using ApiPag.Service.Banco;
using ApiPag.Service.boleto;
using ApiPag.Service.Cliente;
using ApiPag.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ApiPag;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
    {
        new OpenApiSecurityScheme
        {
        Reference = new OpenApiReference
            {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
            },
            Scheme = "oauth2",
            Name = "Bearer",
            In = ParameterLocation.Header,

        },
        new List<string>()
        }
    });


});

builder.Services.AddEntityFrameworkNpgsql()
.AddDbContext<ClienteContext>(
    options => {
        options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"));
    }
);

builder.Services.AddScoped<IClienteService,ClienteService>();
builder.Services.AddScoped<ICliente,ClienteRepository>();
builder.Services.AddScoped<ClienteDominio>();

builder.Services.AddEntityFrameworkNpgsql()
.AddDbContext<BoletosContext>(
    options => {
        options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"));
    }
);

builder.Services.AddScoped<IBoletoService,BoletoService>();
builder.Services.AddScoped<IBoletos,BoletoRepository>();
builder.Services.AddScoped<BoletoDominio>();

builder.Services.AddEntityFrameworkNpgsql()
.AddDbContext<BancoContext>(
    options => {
        options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"));
    }
);

builder.Services.AddScoped<IBancoService,BancoService>();
builder.Services.AddScoped<IBanco,BancosRepository>();
builder.Services.AddScoped<BancoDominio>();

var key = Encoding.ASCII.GetBytes(Key.secret);

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});


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
