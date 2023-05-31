using Core.Attribute;
using System;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace Core.Entities
{
    public class Personne
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }
        [Required]
        [DateOfBirth(MinAge = 0, MaxAge = 150)]
        public DateTime DateDeNaissance { get; set; }
    }
}
