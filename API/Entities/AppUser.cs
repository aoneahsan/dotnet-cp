using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {
        public AppUser()
        {
            UserName = "No Username Provided";
        }

        public AppUser(string name)
        {
            UserName = name;
        }

        // Add your fields, methods, and properties here
        [Key] // we can skip this here because we used the word "Id" with type "int" which is a convention and will be treated as "primary key" automatically by entity framework.
        public int Id { get; set; }

        public string? UserName { get; set; }


    }
}