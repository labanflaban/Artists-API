namespace LangateWrapUpDbApi;

using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using LangateWrapUpDbApi.Data;
using LangateWrapUpDbApi.Migrations;

class Program
{
    
    AudioDbContext context = new AudioDbContext();
    static async Task Main()
    {
        Program program = new Program();

        Console.WriteLine("1. Search for a Artists\n2. Artist Database");
        string input = "-1";
        while (input != "0")
        {

            input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Enter the name of the artits/band you want to get data of");
                var artitsInput = Console.ReadLine();
                if (program.existsIsTrue(artitsInput))
                {
                    //display from dbn 
               
                    program.displayArtist(artitsInput);
                }
                else
                {
                    Console.WriteLine("Getting data from api and adding it to the db");
                    await program.getArtistFromAPI(artitsInput);
                    program.displayArtist(artitsInput);
                }
                

            }
            else if (input == "2")
            {

                program.diplayAllArtists();
            }
            Console.WriteLine("1. You can search for an artist and I will check our database.");
        }
        
    }
    private void diplayAllArtists()
    {
        foreach (var artists in context.Artists)
        {
            Console.WriteLine(artists.strArtist);
        }
    }
    private void displayArtist(string artistInput)
    {
        var artist = context.Artists.FirstOrDefault(artist => artist.strArtist == artistInput);
        Console.WriteLine(artist.strArtist);
        Console.WriteLine(artist.strBiographyEN);

    }
    private bool existsIsTrue(string searchedArtist)
    {
        
        bool exists = context.Artists.Any(i => i.strArtist == searchedArtist);

        return exists;
    }
    //Serialize data from the API
    private async Task getArtistFromAPI(string artitsInput)
    {
        using var client = new HttpClient()
        {
            BaseAddress = new Uri("https://theaudiodb.p.rapidapi.com")
        };

        client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "1b3ec1e580mshff5a91450a7fcc0p14660djsn011a1c884c5d");

        var artists = await client.GetFromJsonAsync<Response>($"/search.php?s={artitsInput}");
        var artist = artists.Artists.FirstOrDefault();
        //Checks if input is valid
        if (artist.idArtist == null)
        {
            Console.WriteLine("Artist does not exists");
        }
        else
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize<Artist>(artists.Artists[0], options);
            
            context.Artists.Add(artist);
            context.SaveChanges();
        }
    }

}

