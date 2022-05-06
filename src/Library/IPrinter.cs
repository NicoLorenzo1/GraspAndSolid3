/// <summary>
/// Interfaz creada para cumplir con el Patron de polimorfismo. Las clases que la implementan manejan el
/// metodo PrintRecipe variando el lugar de salida pero sin modificar la forma en la que se imprime (cumpliendo con el principio LSP).
/// </summary>
namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        public void PrintRecipe(Recipe recipe);
    }
}