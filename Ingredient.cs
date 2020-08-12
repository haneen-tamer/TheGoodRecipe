using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    public class Ingredient
    {
        #region Variables
        private int ID;
        private String unit;
        private String name;
        private float amount;
        #endregion

        #region Getters and Setters
        public int ID1 { get => ID; set => ID = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Name { get => name; set => name = value; }
        public float Amount { get => amount; set => amount = value; }
        #endregion

    }
}
