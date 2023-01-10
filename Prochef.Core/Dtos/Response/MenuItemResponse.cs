using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prochef.Core.Dtos.Response
{
    public class MenuItemResponse
    {
        public string Section { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string TimeOfTheDay { get; set; }
        public string Description { get; set; }

        public  List<IngredientResponse> Ingredients { get; set; }

    }
}
