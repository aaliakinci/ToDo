using AKNProje.ToDo.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.Entities.Concrete
{
    public class AppUser : IdentityUser<int>,ITablo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PictureUrl { get; set; } = "user.png";
        public List<Gorev> Gorevler { get; set; }

    }
}
