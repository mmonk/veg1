using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace veg1.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }

        [Required]
        [Display(Name = "Recipe Name")]
        public string RecipeName { get; set; }

        [Required]
        [Display(Name = "Ingredients")]
        [DataType(DataType.MultilineText)]
        public string Ingredients { get; set; }

        [Required]
        [Display(Name = "Ingredient Instructions")]
        [DataType(DataType.MultilineText)]
        public string RecipeInstructions { get; set; }
    }
}