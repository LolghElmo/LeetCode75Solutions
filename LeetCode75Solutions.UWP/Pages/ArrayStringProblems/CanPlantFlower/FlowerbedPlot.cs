using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75Solutions.UWP.Pages.ArrayStringProblems.CanPlantFlower
{
    public class FlowerbedPlot
    {
        public int Index { get; set; }
        public bool IsPlanted { get; set; }
        public string Image => IsPlanted ? "ms-appx:///Assets/plant.png" : "ms-appx:///Assets/soil.png";
    }
}
