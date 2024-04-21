using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class WelcomeToMySite
    {
        [Display(Name = "Enter your name:")]
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        public WelcomeToMySite()
        {
            Name = "Guest";
        }
        public WelcomeToMySite(string name)
        {
            Name = name;
        }
    }
}
