using LeetCode75Solutions.ClassLibrary.ArrayStringProblems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LeetCode75Solutions.UWP.Pages.ArrayStringProblems.CanPlantFlower
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CanPlaceFlowersPage : Page
    {
        private List<FlowerbedPlot> flowerbed;

        public CanPlaceFlowersPage()
        {
            this.InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            flowerbed = new List<FlowerbedPlot>();

            for (int i = 0; i < 7; i++)
                flowerbed.Add(new FlowerbedPlot { Index = i, IsPlanted = false });

            FlowerbedItemsControl.ItemsSource = flowerbed;
        }

        private void FlowerbedToggle_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as ToggleButton;
            int index = (int)btn.Tag;
            flowerbed[index].IsPlanted = !flowerbed[index].IsPlanted;
            FlowerbedItemsControl.ItemsSource = null;
            FlowerbedItemsControl.ItemsSource = flowerbed;
        }
        private void CheckPlanting_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(FlowersToPlantTextBox.Text, out int n))
            {
                ResultTextBlock.Text = "Please enter a valid number.";
                return;
            }

            int[] flowerbedArray = flowerbed.Select(p => p.IsPlanted ? 1 : 0).ToArray();
            bool canPlant = PlaceFlowers.CanPlaceFlowers((int[])flowerbedArray.Clone(), n);

            ResultTextBlock.Text = canPlant
                ? $"✅ Yes, you can plant {n} flower(s)!"
                : $"❌ No, there's not enough space!";
        }

    }
}
