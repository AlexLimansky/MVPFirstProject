using System;
using Services.Interfaces;

namespace Services.Presenters
{
    public class BookPresenter
    {
        private IBooksModel _model;
        private IBooksView _view;

        public BookPresenter(IBooksModel model, IBooksView view)
        {
            _view = view;
            _model = model;
            _view.BooksList = _model.GetAllBooks();
            _view.SelectedIdChanged += _view_SelectedIdChanged;
            _model.BooksUpdated += _model_BooksUpdated;
            _view.BookCreated += _view_BookCreated;
            _view.BookDeleted += _view_BookDeleted;
            _view.BookUpdated += _view_BookUpdated;
        }

        private void _view_BookUpdated(object sender, BookEventArgs b)
        {
            _model.Update(b.Book);
        }

        private void _view_BookDeleted(object sender, int e)
        {
            _model.Delete(e);
        }

        private void _model_BooksUpdated(object sender, EventArgs e)
        {
            _view.BooksList = _model.GetAllBooks();
            _view.ShowAllBooks();
        }

        private void _view_BookCreated(object sender, BookEventArgs b)
        {
            _model.Create(b.Book);
        }

        private void _view_SelectedIdChanged(object sender, EventArgs e)
        {
            _view.CurrentBook = _model.GetBookById(_view.SelectedBookId);
        }

    }
}
