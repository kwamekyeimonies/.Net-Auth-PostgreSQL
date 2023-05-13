using Microsoft.EntityFrameworkCore;

namespace Auth.System.DbConnector{
    public class ApiDbContext : DbContext{
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){

        }

        //Migrations/DB setup
    }
}