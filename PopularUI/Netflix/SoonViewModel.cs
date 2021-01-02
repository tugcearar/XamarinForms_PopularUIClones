using MvvmHelpers;
using PopularUI.Data;
using System.Collections.ObjectModel;

namespace PopularUI.Netflix
{
    internal class SoonViewModel : BaseViewModel
    {
        public IApiManager Api { get; set; }
        private ObservableCollection<SoonMovie> soonMovies;

        public ObservableCollection<SoonMovie> SoonMovies
        {
            get => soonMovies; set
            {
                soonMovies = value;
                OnPropertyChanged();
            }
        }

        public SoonViewModel()
        {
            Api = new ApiMockManager();
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
    }
}