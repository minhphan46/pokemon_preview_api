using PokemonPreview.Models;

namespace PokemonPreview.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
