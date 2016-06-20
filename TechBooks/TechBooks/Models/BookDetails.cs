using System.ComponentModel;

namespace TechBooks.Models
{
    public class BookDetails : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private long id;
        public long ID
        {
            get { return id; }
            set
            {
                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ID)));
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        private string subtitle;
        public string SubTitle
        {
            get { return subtitle; }
            set
            {
                subtitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SubTitle)));
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
            }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Author)));
            }
        }

        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set
            {
                isbn = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ISBN)));
            }
        }

        private string page;
        public string Page
        {
            get { return page; }
            set
            {
                page = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Page)));
            }
        }

        private string year;
        public string Year
        {
            get { return year; }
            set
            {
                year = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Year)));
            }
        }

        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set
            {
                publisher = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Publisher)));
            }
        }

        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Image)));
            }
        }

        private string download;
        public string Download
        {
            get { return download; }
            set
            {
                download = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Download)));
            }
        }
    }
}
