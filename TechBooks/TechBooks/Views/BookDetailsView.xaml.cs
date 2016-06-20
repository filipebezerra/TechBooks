using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TechBooks.Views
{
    public partial class BookDetailsView : ContentPage
    {
        public BookDetailsView(Models.BookSearch bookSearch)
        {
            InitializeComponent();

            this.BindingContext = ViewModels.BookDetailsViewModel.NewInstance(bookSearch);
        }
    }
}
