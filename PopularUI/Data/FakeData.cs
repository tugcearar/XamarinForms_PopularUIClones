using System.Collections.Generic;
using System.Threading.Tasks;

namespace PopularUI.Data
{
    public class Movie
    {
        public string Name { get; set; }
        public string Poster { get; set; }
        public bool NewEpisodes { get; set; }
    }

    public class ContinueMovie
    {
        public string Name { get; set; }
        public string Poster { get; set; }
        public string CurrentEpisode { get; set; }
        public double Progress { get; set; }
    }

    public class SoonMovie
    {
        public string Name { get; set; }
        public string VideoUrl { get; set; }
        public string DateText { get; set; }
        public string Description { get; set; }
        public List<string> Genres { get; set; }
        public string Poster { get; set; }
        public string Logo { get; internal set; }
        public double Opacity { get; internal set; }
    }

    public interface IApiManager
    {
        Task<List<Movie>> GetSpecialMoviesAsync();

        Task<List<Movie>> GetMyListAsync();

        Task<List<Movie>> GetAgendaAsync();

        Task<List<Movie>> GetNetflixOriginalsAsync();

        Task<List<ContinueMovie>> GetContinueToWatchAsync();

        Task<List<SoonMovie>> GetSoonMoviesAsync();
    }

    public class ApiMockManager : IApiManager
    {
        public async Task<List<Movie>> GetSpecialMoviesAsync()
        {
            await Task.Delay(1000);

            var movies = new List<Movie>();
            movies.Add(new Movie() { Poster = "fantastic", Name = "Fantastic Beasts And Where To Find Them" });
            movies.Add(new Movie() { Poster = "crazy_ex", Name = "Crazy Ex-Girlfriend" });
            movies.Add(new Movie() { Poster = "sherlock", Name = "Sherlock Holmes" });
            movies.Add(new Movie() { Poster = "himym", Name = "How I Met Your Mother" });

            return movies;
        }

        public async Task<List<Movie>> GetMyListAsync()
        {
            await Task.Delay(1000);

            var movies = new List<Movie>();
            movies.Add(new Movie() { Poster = "sherlock", Name = "Sherlock Holmes", NewEpisodes = true });
            movies.Add(new Movie() { Poster = "violet_evergarden", Name = "Violet Evergarden" });
            movies.Add(new Movie() { Poster = "troy", Name = "Troy" });
            movies.Add(new Movie() { Poster = "himym", Name = "How I Met Your Mother", NewEpisodes = true }); ;

            return movies;
        }

        public async Task<List<Movie>> GetAgendaAsync()
        {
            await Task.Delay(1000);

            var movies = new List<Movie>();
            movies.Add(new Movie() { Poster = "after_life", Name = "After Life", NewEpisodes = true });
            movies.Add(new Movie() { Poster = "brookly_nine_nine", Name = "Brooklyn Nine Nine" });
            movies.Add(new Movie() { Poster = "last_kingdom", Name = "The Last Kingdom", NewEpisodes = true });
            movies.Add(new Movie() { Poster = "himym", Name = "How I Met Your Mother" }); ;

            return movies;
        }

        public async Task<List<Movie>> GetNetflixOriginalsAsync()
        {
            await Task.Delay(1000);

            var movies = new List<Movie>();
            movies.Add(new Movie() { Poster = "sabrina", Name = "After Life", NewEpisodes = true });
            movies.Add(new Movie() { Poster = "unfortunate_events", Name = "Brooklyn Nine Nine" });
            movies.Add(new Movie() { Poster = "crown", Name = "Crown", NewEpisodes = true });

            return movies;
        }

        public async Task<List<ContinueMovie>> GetContinueToWatchAsync()
        {
            await Task.Delay(1000);

            var movies = new List<ContinueMovie>();
            movies.Add(new ContinueMovie() { Poster = "sherlock", Name = "Sherlock Holmes", CurrentEpisode = "2.S:B:3", Progress = 60 });
            movies.Add(new ContinueMovie() { Poster = "violet_evergarden", Name = "Violet Evergarden", CurrentEpisode = "1.S:B:7", Progress = 80 });
            movies.Add(new ContinueMovie() { Poster = "himym", Name = "How I Met Your Mother", CurrentEpisode = "8.S:B:5", Progress = 10 });
            movies.Add(new ContinueMovie() { Poster = "last_kingdom", Name = "The Last Kingdom", CurrentEpisode = "1.S:B:5", Progress = 30 });
            return movies;
        }

        public async Task<List<SoonMovie>> GetSoonMoviesAsync()
        {
            await Task.Delay(1000);

            var movies = new List<SoonMovie>();
            movies.Add(new SoonMovie() { Name = "History 101", VideoUrl = "https://www.youtube.com/watch?v=han4ZONppi8", DateText = "Season 1 Coming Friday", Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy", Genres = new List<string> { "Captivating", "Social&Cultural", "TV Program", "British", "Historical" }, Poster = "history_soon", Logo = "history_logo" });
            movies.Add(new SoonMovie() { Name = "The Witcher", VideoUrl = "https://www.youtube.com/watch?v=ndl1W4ltcmg&t=3s", DateText = "Season 1 Coming December 20", Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy", Genres = new List<string> { "Fantastic", "Drama", "Action", "Adventure" }, Poster = "witcher_soon", Logo = "witcher_logo" });
            return movies;
        }
    }
}