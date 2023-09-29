
using Microsoft.EntityFrameworkCore;
using projeto.ApiUser.Context;
using projeto.ApiUser.Models;

namespace ApiUser.ApiEndpoints
{
    public static class UsersEndpoints
    {
     public static async void MapCategoriasEndpoints(this WebApplication app)
        {

            app.MapGet("/users", async (AppDbContext db) =>
               await db.Users.ToListAsync()).WithTags("Users").RequireAuthorization();

            app.MapGet("/users/{id:int}", async (int id, AppDbContext db)
                => {
                    return await db.Users.FindAsync(id)
                                 is Users users
                                 ? Results.Ok(users)
                                 : Results.NotFound();
                });
        }

    }
}
