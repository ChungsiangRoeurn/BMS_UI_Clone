using BMS_Clone.Models;
using BMS_Clone.Services;
using BMS_Clone.Views.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;


namespace BMS_Clone.ViewModels
{
    public partial class GridViewViewModel : ObservableObject
    {
        private readonly SentraView sentraView = new SentraView();
        private readonly LeafView leafView = new LeafView();
        private readonly KiaView kiaView = new KiaView();
        private readonly PorscheView porscheView = new PorscheView();
        private readonly LamboView lamboView = new LamboView();

        private readonly ApiService _apiService = new();

        [ObservableProperty]
        public ObservableCollection<ProductModel> products = new();


        [ObservableProperty]
        private object? currentPage;

        public GridViewViewModel()
        {
            CurrentPage = sentraView;

            _ = LoadProductsAsync();
        }

        private async Task LoadProductsAsync()
        {
            var result = await _apiService.GetProductsAsync();

            Products.Clear();

            foreach(var product in result)
            {
                Products.Add(product);
            }
        }

        partial void OnSearchTextChanged(string value)
        {
            _ = SearchAsync(value);
        }

        [ObservableProperty]
        private string searchText = "";

        private async Task SearchAsync(string keyword)
        {
            List<ProductModel> result;

            if (string.IsNullOrEmpty(keyword))
            {
                result = await _apiService.GetProductsAsync();
            }
            else
            {
                result = await _apiService.SearchProductAsync(keyword);
            }

            Products.Clear();

            foreach (var product in result)
            {
                Products.Add(product);
            }
        }

        [RelayCommand]
        private void GoSentra()
        {
            CurrentPage = sentraView ;
        }

        [RelayCommand]
        private void GoLeaf()
        {
            CurrentPage = leafView;
        }

        [RelayCommand]
        private void GoKia()
        {
            CurrentPage = kiaView;
        }

        [RelayCommand]
        private void GoPorsche()
        {
            CurrentPage = porscheView;
        }

        [RelayCommand]
        private void GoLambo()
        {
            CurrentPage = lamboView;
        }

        [ObservableProperty]
        private string carImage = "/Assets/tesla_red.png";

        [RelayCommand]
        private void Blue()
        {
            CarImage = "/Assets/tesla_blue.png";
        }

        [RelayCommand]
        private void White()
        {
            CarImage = "/Assets/tesla_white.png";
        }

        [RelayCommand]
        private void Black()
        {
            CarImage = "/Assets/tesla_black.png";
        }

        [RelayCommand]
        private void Yellow()
        {
            CarImage = "/Assets/tesla_yellow.png";
        }


        [RelayCommand]
        private void Red()
        {
            CarImage = "/Assets/tesla_red.png";
        }


    }
}
