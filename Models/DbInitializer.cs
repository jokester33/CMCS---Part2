using System.Linq;

namespace CMCS.Models
{
    public static class DbInitializer
    {
        public static void Initialize(CMCSContext context)
        {
            // Making sure database is created
            context.Database.EnsureCreated();

            // If users already exist, skip seeding
            if (context.Users.Any())
                return;

            var users = new[]
            {
                new User { Username = "lecturer", Password = "123", Role = "Lecturer" },
                new User { Username = "coordinator", Password = "123", Role = "Coordinator" },
                new User { Username = "manager", Password = "123", Role = "Manager" }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
