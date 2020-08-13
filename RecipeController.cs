using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TheGoodRecipe
{
    public class RecipeController
    {
        #region Variables
        private List<Recipe> recipeList;
        private DataGridView dgv;
        //private RecipeStorageManager rsm;
        #endregion


        //hey, i am here, appreciate me.

        #region Functions
        public RecipeController(List<Recipe> recipeList, DataGridView dgv)
        {

            this.recipeList = recipeList;
            this.dgv = dgv;
            this.dgv.Rows.Clear();
            //bind dgv with recipelist
            dgv.ReadOnly = true;
            string[] columns = { "Title", "Rating", "Ready In Minutes" };
            dgv.ColumnCount = columns.Length+1;
            for(int i=0; i<columns.Length; i++)
            {
                dgv.Columns[i+1].Name = columns[i];
            }
            
            for (int i=0; i< this.recipeList.Count; i++)
            {
                List<string> row = new List<string>();
                row.Add("");
                row.Add(this.recipeList[i].Title);
                row.Add(this.recipeList[i].Rating.ToString());
                row.Add(this.recipeList[i].ReadyInMinutes.ToString());

                dgv.Rows.Add(row.ToArray());

            }
            
           // MessageBox.Show("here");
            //BindingSource bindingSource1 = new BindingSource();
            //bindingSource1.DataSource = recipeList;
            //dgv.DataSource = bindingSource1;
            
        }

        public Recipe getSelectedRecipe()
        {
            //return dgv.selected recipe
            if (dgv.SelectedCells.Count == 1)
            {
                return recipeList[dgv.SelectedCells[0].RowIndex];
            }
            else
                return null;
        }
        public void updateView(List<Recipe> rl)
        {
            this.recipeList = rl;
            dgv.Rows.Clear();
            for (int i = 0; i < recipeList.Count; i++)
            {
                List<string> row = new List<string>();
                row.Add(recipeList[i].ImageURL);
                row.Add(recipeList[i].Title);
                row.Add(recipeList[i].Rating.ToString());
                row.Add(recipeList[i].ReadyInMinutes.ToString());

                dgv.Rows.Add(row.ToArray());

            }
        }

        
        #endregion
    }
}
