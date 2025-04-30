using Microsoft.AspNetCore.Mvc;
using tjmod9_2311104042.Models;

namespace tjmod9_2311104042.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string>{"Tim Robbins", "Morgan Freeman"},
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
            },
            new Movie {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string>{"Marlon Brando", "Al Pacino"},
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son."
            },
            new Movie {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string>{"Christian Bale", "Heath Ledger"},
                Description = "When the menace known as the Joker emerges, he wreaks havoc and chaos on the people of Gotham."
            }
        };

        [HttpGet]
        public ActionResult<List<Movie>> GetMovies()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            if (id < 0 || id >= movies.Count)
            {
                return NotFound();
            }
            return Ok(movies[id]);
        }

        [HttpPost]
        public ActionResult<Movie> CreateMovie(Movie newMovie)
        {
            movies.Add(newMovie);
            return Ok(newMovie);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= movies.Count)
            {
                return NotFound();
            }
            movies.RemoveAt(id);
            return NoContent();
        }
    }
}