using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Data;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
    public class PokemonDetailsModel : PageModel
    {
        private readonly AppDbContext context;
        public PokemonRoot? Pokemon { get; set; }

        public PokemonDetailsModel(AppDbContext context)
        {
            this.context = context;
        }

        //public async Task OnGet(string name)
        //{
        //    try
        //    {

        //        PokemonRoot response = await new APIcaller().MakeCall<PokemonRoot>($"v2/pokemon/{name}");
        //        Pokemon = response;
        //        Pokemon1 newPokemon = new();
        //        newPokemon.Name = Pokemon.Name;

        //        context.Add(newPokemon);
        //        context.SaveChanges();


        //    }
        //    catch (Exception ex)
        //    {

        //    }


    }
}
}
