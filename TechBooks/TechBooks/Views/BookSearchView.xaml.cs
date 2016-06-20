using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TechBooks.Views
{
    public partial class BookSearchView : ContentPage
    {
        public BookSearchView()
        {
            InitializeComponent();

            this.BindingContext = new ViewModels.BookSearchViewModel();

            this.BooksSearchListView.ItemTapped += (sender, e) =>
            {
                var book = e.Item as Models.BookSearch;
                this.Navigation.PushAsync(new BookDetailsView(book));
            };
        }
    }
}
