using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciepe_Book
{
    class RecipeInfo
    {
        public string RecipeName {get; set;}
        public string RecipeInstructions { get; set; }
        public List<Ingredients> RecipeIngredients { get; set; }
    }
}
