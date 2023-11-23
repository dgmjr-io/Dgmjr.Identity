// See https://aka.ms/new-console-template for more information

var db =
    new Dgmjr.Identity.EntityFrameworkCore.IdentityDbContextDesignTimeFactory().CreateDbContext(
        args
    );
db.Database.EnsureCreated();
db.Database.Migrate();
db.Dispose();
