﻿using SeenIT.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SeenIT.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}