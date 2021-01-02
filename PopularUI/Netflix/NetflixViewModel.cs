using MvvmHelpers;
using PopularUI.Data;
using System.Collections.ObjectModel;

namespace PopularUI.Netflix
{
    internal class NetflixViewModel : BaseViewModel
    {
        public IApiManager Api { get; set; }

        private ObservableCollection<Movie> movies;
        private ObservableCollection<Movie> myList;
        private ObservableCollection<Movie> agenda;
        private ObservableCollection<Movie> netflixOriginal;
        private ObservableCollection<ContinueMovie> continueToWatch;
        private ObservableCollection<SoonMovie> soonMovies;

        public ObservableCollection<Movie> Movies
        {
            get => movies; set
            {
                movies = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<SoonMovie> SoonMovies
        {
            get => soonMovies; set
            {
                soonMovies = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Movie> Agenda
        {
            get => movies; set
            {
                movies = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<ContinueMovie> ContinueToWatch
        {
            get => continueToWatch; set
            {
                continueToWatch = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Movie> NetflixOriginal
        {
            get => movies; set
            {
                movies = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Movie> MyList
        {
            get => myList; set
            {
                myList = value;
                OnPropertyChanged();
            }
        }

        public NetflixViewModel()
        {
            Api = new ApiMockManager();
            GetSpecialMovies();
            GetMyList();
            GetAgendaAsync();
            GetNetflixOriginalsAsync();
            GetContinueToWatchAsync();
            GetSoonMovies();
        }

        private async void GetSoonMovies()
        {
            IsBusy = true;
            var movies = await Api.GetSoonMoviesAsync();
            if (movies != null)
            {
                SoonMovies = new ObservableCollection<SoonMovie>(movies);
            }

            IsBusy = false;
        }

        private async void GetSpecialMovies()
        {
            IsBusy = true;
            var movies = await Api.GetSpecialMoviesAsync();
            if (movies != null)
            {
                Movies = new ObservableCollection<Movie>(movies);
            }

            IsBusy = false;
        }

        private async void GetMyList()
        {
            IsBusy = true;
            var list = await Api.GetMyListAsync();
            if (list != null)
            {
                MyList = new ObservableCollection<Movie>(list);
            }

            IsBusy = false;
        }

        private async void GetAgendaAsync()
        {
            IsBusy = true;
            var list = await Api.GetAgendaAsync();
            if (list != null)
            {
                Agenda = new ObservableCollection<Movie>(list);
            }

            IsBusy = false;
        }

        private async void GetNetflixOriginalsAsync()
        {
            IsBusy = true;
            var list = await Api.GetNetflixOriginalsAsync();
            if (list != null)
            {
                NetflixOriginal = new ObservableCollection<Movie>(list);
            }

            IsBusy = false;
        }

        private async void GetContinueToWatchAsync()
        {
            IsBusy = true;
            var list = await Api.GetContinueToWatchAsync();
            if (list != null)
            {
                ContinueToWatch = new ObservableCollection<ContinueMovie>(list);
            }

            IsBusy = false;
        }
    }
}