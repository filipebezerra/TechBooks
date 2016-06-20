using System.ComponentModel;

namespace TechBooks.ViewModels
{
    public class BookDetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Models.BookDetails bookDetails;
        public Models.BookDetails BookDetails
        {
            get { return bookDetails; }
            set
            {
                bookDetails = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BookDetails)));
            }
        }

        private Models.BookSearch bookSearch;

        public Models.BookSearch BookSearch
        {
            set
            {
                bookSearch = value;
                RequestBookDetails();
            }
        }

        public static BookDetailsViewModel NewInstance(Models.BookSearch bookSearch)
        {
            return new BookDetailsViewModel { BookSearch = bookSearch };
        }

        private async void RequestBookDetails()
        {
            BookDetails = await Web.BookWebApi.GetBookById(bookSearch.ID);
        }
    }
}
