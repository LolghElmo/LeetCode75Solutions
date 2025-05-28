using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75Solutions.UWP.Pages
{
    public static class ProblemPages
    {
        public static readonly Dictionary<string, Type> PageMap = new Dictionary<string, Type>
        {
            { "Merge Strings", typeof(Pages.ArrayStringProblems.MergeStringsPage) },
            { "GCD Of Strings", typeof(Pages.ArrayStringProblems.GCDOfStringsPage) },
            { "Can Place Flowers", typeof(Pages.ArrayStringProblems.CanPlantFlower.CanPlaceFlowersPage) },
            { "Kids With Candies", typeof(Pages.ArrayStringProblems.KidsWithCandies.KidsWithCandiesPage) },

        };
    }
}
