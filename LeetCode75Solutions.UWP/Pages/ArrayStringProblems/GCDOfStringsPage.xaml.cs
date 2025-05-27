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

namespace LeetCode75Solutions.UWP.Pages.ArrayStringProblems
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GCDOfStringsPage : Page
    {
        public GCDOfStringsPage()
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
        private void FindCommonTheme_Click(object sender, RoutedEventArgs e)
        {
            string playlist1 = Playlist1TextBox.Text.Trim();
            string playlist2 = Playlist2TextBox.Text.Trim();

            if (string.IsNullOrEmpty(playlist1) || string.IsNullOrEmpty(playlist2))
            {
                ResultTextBlock.Text = "Please enter both playlist strings.";
                return;
            }

            string commonTheme = GCDOfStrings.GcdOfStrings(playlist1, playlist2);
            ResultTextBlock.Text = string.IsNullOrEmpty(commonTheme)
                ? "No common repeating theme found between playlists."
                : $"Common repeating theme: {commonTheme}";
        }

    }
}
