using System;
using ApiUser.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using projeto.ApiUser.Context;
using projeto.ApiUser.Models;

namespace ApiUser.ApiEndpoints
{
    public static class AutenticacaoEndpoints
    {
        
        public static void MapAutenticacaoEndpoints(this WebApplication app)
        {
            //endpoint para login
            app.MapPost("/login", [AllowAnonymous] ([FromServices] AppDbContext context,
            [FromBody] UserModel model, ITokenService tokenService) =>
            {

            var todo = context.Users.FirstOrDefault(x => x.Carteira == model.Carteira && x.Senha == model.Senha);
                

                if (todo != null )
                {
                    var tokenString = tokenService.GerarToken(app.Configuration["Jwt:Key"],
                        app.Configuration["Jwt:Issuer"],
                        app.Configuration["Jwt:Audience"],
                        model);
                    return Results.Ok(new { token = tokenString });
                }
                else
                {
                    return Results.BadRequest("Login Inválido");
                }
            }).Produces(StatusCodes.Status400BadRequest)
                          .Produces(StatusCodes.Status200OK)
                          .WithName("Login")
                          .WithTags("Autenticacao");
        }
    }
}
