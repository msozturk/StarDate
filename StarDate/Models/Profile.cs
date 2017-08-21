using StarDate.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarDate.Models
{
    public enum SmokerType
    {
        No,
        Occasional,
        Regular,
        Heavy
    }

    public enum Gender
    {
        Male,
        Female
    }
    public class Profile
    {
       
        public int Id { get; set; }

        public Gender Gender { get; set; }

        [Display(Name = "Display name")]
        public string DisplayName { get; set; }

        public DateTime BirthDate { get; set; }

        [Display(Name = "Height (cm)")]
        public int Height { get; set; }

        public string Description { get; set; }

        public string Occupation { get; set; }

        [Display(Name ="Profil Picture")]
        public string ProfilePicture { get; set; }

        public SmokerType Smoking { get; set; }

        public ApplicationUser User { get; set; }
        

        

        


    }
}
