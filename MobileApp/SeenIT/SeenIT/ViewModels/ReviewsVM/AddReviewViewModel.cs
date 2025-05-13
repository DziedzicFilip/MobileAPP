using SeenIT.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SeenIT.ViewModels.ReviewsVM
{
    public class AddReviewViewModel : BaseViewModel, IQueryAttributable
    {
        private int filmId;
        // ... pozostałe właściwości

        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            if (query.ContainsKey("filmId"))
                filmId = int.Parse(query["filmId"]);
        }

        // W metodzie dodawania recenzji użyj filmId
    }
}
