namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private static readonly Dictionary<string, List<string>> _categorias = new()
        {
            ["Arquitectura"] = new() { "arquitectura", "componente", "descomposición", "dependencia", "acoplamiento" },
            ["POO"]          = new() { "polimorfismo", "encapsulamiento", "herencia", "abstracción", "clase" },
            [".NET"]         = new() { "ensamblado", "namespace", "interfaz", "delegado", "middleware" }
        };

        private readonly List<string> _palabras;

        public PalabrasEnMemoria(string categoria)
        {
            _palabras = _categorias[categoria];
        }

        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();
            return _palabras[random.Next(_palabras.Count)];
        }

        public static IEnumerable<string> ObtenerCategorias() => _categorias.Keys;
    }
}
//Hola