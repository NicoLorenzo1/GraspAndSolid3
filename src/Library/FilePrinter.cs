using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clse FilePrinter la cual usa la interfaz IPrinter. Cumple con SRP debido a que tiene una responsabilidad única.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}