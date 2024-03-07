using System.Collections.Generic;
using System.Linq;

namespace Tutorial.MVVM.ViewModel
{
    internal class MetallicViewModel
    {
        // Define the list as a property with initialization
        public List<string> MetalObjects { get; private set; } = new List<string>
        {
            "Apparatus",
            "Bee Hive",
            "Brass Bell",
            "Cash Register",
            "Clown Horn",
            "Egg Beater",
            "Extension Ladder",
            "Fancy Lamp",
            "Flask",
            "Gold Bar",
            "Jetpack(Buyable)",
            "Large Axle",
            "Large Bolt",
            "Metal Sheet",
            "Radar-Booster(Buyable)",
            "Red Soda",
            "Robot Toy (Noisy)",
            "Shovel(Buyable)",
            "Stop Sign",
            "Tea Kettle",
            "Tzp-Inhalant(Buyable)",
            "V-Type Engine",
            "Wedding Ring",
            "Whoopie Cushion",
            "Yield Sign",
            "Zap Gun(Buyable)",
            "Key",
        }.OrderBy(s => s).ToList();
    }
}
