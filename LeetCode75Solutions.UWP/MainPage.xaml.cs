using LeetCode75Solutions.UWP.Pages;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LeetCode75Solutions.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ProblemsListView.ItemsSource = ProblemPages.PageMap.Keys.ToList();
        }



        private void ProblemsListView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ProblemsListView.SelectedItem is string selectedName &&
    ProblemPages.PageMap.TryGetValue(selectedName, out var pageType))
            {
                Frame.Navigate(pageType);
            }
        }
    }
}
