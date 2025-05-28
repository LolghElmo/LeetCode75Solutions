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

namespace LeetCode75Solutions.UWP.Pages.ArrayStringProblems.KidsWithCandies
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KidsWithCandiesPage : Page
    {
        private List<KidPlot> kids;
        private int extraCandies = 0;

        public KidsWithCandiesPage()
        {
            this.InitializeComponent();
            InitializeKids();
        }

        private void InitializeKids()
        {
            var rand = new Random();
            kids = new List<KidPlot>();

            for (int i = 0; i < 5; i++)
            {
                kids.Add(new KidPlot
                {
                    Index = i,
                    Candies = rand.Next(1, 6)
                });
            }

            RefreshView();
        }

        private void RefreshView()
        {
            KidsItemsControl.ItemsSource = null;
            KidsItemsControl.ItemsSource = kids;
        }

        private void KidButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            int index = (int)button.Tag;
            kids[index].Candies++;
            RefreshView();
        }

        private void CheckCandies_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(ExtraCandiesTextBox.Text, out int extra))
            {
                ResultTextBlock.Text = "Please enter a valid number of extra candies.";
                return;
            }

            int[] currentCandies = kids.Select(k => k.Candies).ToArray();
            var result = GreatestKidsWithCandies.KidsWithCandies(currentCandies, extra);

            string message = "";
            for (int i = 0; i < result.Count; i++)
            {
                message += result[i]
                    ? $"✅ Kid {i + 1} could be the greatest with +{extra} candies.\n"
                    : $"❌ Kid {i + 1} still couldn't beat the others.\n";
            }

            ResultTextBlock.Text = message.TrimEnd();
        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }
    }
}
