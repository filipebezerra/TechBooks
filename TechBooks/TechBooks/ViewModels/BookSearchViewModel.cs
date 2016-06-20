using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TechBooks.ViewModels
{
    public class BookSearchViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SearchText)));
            }
        }

        private ObservableCollection<Models.BookSearch> bookSearchList;
        public ObservableCollection<Models.BookSearch> BookSearchList
        {
            get { return bookSearchList; }
            set
            {
                bookSearchList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BookSearchList)));
            }
        }

        private Xamarin.Forms.Command searchCommand;
        public System.Windows.Input.ICommand SearchCommand
        {
            get
            {
                return searchCommand ?? new Xamarin.Forms.Command(async () =>
                    {
                        var books = await Web.BookWebApi.GetBooksByQuery(SearchText);
                        BookSearchList = new ObservableCollection<Models.BookSearch>(books);
                    }
                );
            }
        }
    }
}
