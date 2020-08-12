namespace TheGoodRecipe
{
    partial class recipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture_recipe = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RecipeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ReadyInMinutes = new System.Windows.Forms.TextBox();
            this.txt_cuisines = new System.Windows.Forms.TextBox();
            this.txt_PricePerServing = new System.Windows.Forms.TextBox();
            this.txt_DishTypes = new System.Windows.Forms.TextBox();
            this.txt_Servings = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.list_ingredients = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.list_instructions = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_HealthScore = new System.Windows.Forms.TextBox();
            this.txt_Calories = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_NumOfServings = new System.Windows.Forms.TextBox();
            this.Calculate_ingredients_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Review_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PostView_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.UsersRatingradioBtn = new System.Windows.Forms.RadioButton();
            this.HealthRatingradioBtn = new System.Windows.Forms.RadioButton();
            this.txt_rating = new System.Windows.Forms.TextBox();
            this.Reviews_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picture_recipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reviews_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_recipe
            // 
            this.picture_recipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_recipe.Location = new System.Drawing.Point(31, 12);
            this.picture_recipe.Name = "picture_recipe";
            this.picture_recipe.Size = new System.Drawing.Size(403, 219);
            this.picture_recipe.TabIndex = 0;
            this.picture_recipe.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Favourite";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RecipeName
            // 
            this.RecipeName.AutoSize = true;
            this.RecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeName.Location = new System.Drawing.Point(469, 12);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(234, 42);
            this.RecipeName.TabIndex = 2;
            this.RecipeName.Text = "RecipeName";
            this.RecipeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ReadyInMinutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "cuisines";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "PricePerServing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DishTypes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Servings";
            // 
            // txt_ReadyInMinutes
            // 
            this.txt_ReadyInMinutes.Location = new System.Drawing.Point(123, 253);
            this.txt_ReadyInMinutes.Name = "txt_ReadyInMinutes";
            this.txt_ReadyInMinutes.ReadOnly = true;
            this.txt_ReadyInMinutes.Size = new System.Drawing.Size(100, 20);
            this.txt_ReadyInMinutes.TabIndex = 9;
            this.txt_ReadyInMinutes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_cuisines
            // 
            this.txt_cuisines.Location = new System.Drawing.Point(123, 281);
            this.txt_cuisines.Name = "txt_cuisines";
            this.txt_cuisines.ReadOnly = true;
            this.txt_cuisines.Size = new System.Drawing.Size(100, 20);
            this.txt_cuisines.TabIndex = 10;
            // 
            // txt_PricePerServing
            // 
            this.txt_PricePerServing.Location = new System.Drawing.Point(334, 250);
            this.txt_PricePerServing.Name = "txt_PricePerServing";
            this.txt_PricePerServing.ReadOnly = true;
            this.txt_PricePerServing.Size = new System.Drawing.Size(100, 20);
            this.txt_PricePerServing.TabIndex = 11;
            // 
            // txt_DishTypes
            // 
            this.txt_DishTypes.Location = new System.Drawing.Point(334, 281);
            this.txt_DishTypes.Name = "txt_DishTypes";
            this.txt_DishTypes.ReadOnly = true;
            this.txt_DishTypes.Size = new System.Drawing.Size(100, 20);
            this.txt_DishTypes.TabIndex = 12;
            // 
            // txt_Servings
            // 
            this.txt_Servings.Location = new System.Drawing.Point(334, 310);
            this.txt_Servings.Name = "txt_Servings";
            this.txt_Servings.ReadOnly = true;
            this.txt_Servings.Size = new System.Drawing.Size(100, 20);
            this.txt_Servings.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ingredients";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // list_ingredients
            // 
            this.list_ingredients.FormattingEnabled = true;
            this.list_ingredients.Location = new System.Drawing.Point(34, 390);
            this.list_ingredients.Name = "list_ingredients";
            this.list_ingredients.Size = new System.Drawing.Size(185, 108);
            this.list_ingredients.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Instructions";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // list_instructions
            // 
            this.list_instructions.FormattingEnabled = true;
            this.list_instructions.Location = new System.Drawing.Point(249, 390);
            this.list_instructions.Name = "list_instructions";
            this.list_instructions.Size = new System.Drawing.Size(185, 108);
            this.list_instructions.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "HealthScore";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Calories";
            // 
            // txt_HealthScore
            // 
            this.txt_HealthScore.Location = new System.Drawing.Point(122, 310);
            this.txt_HealthScore.Name = "txt_HealthScore";
            this.txt_HealthScore.ReadOnly = true;
            this.txt_HealthScore.Size = new System.Drawing.Size(101, 20);
            this.txt_HealthScore.TabIndex = 21;
            // 
            // txt_Calories
            // 
            this.txt_Calories.Location = new System.Drawing.Point(122, 342);
            this.txt_Calories.Name = "txt_Calories";
            this.txt_Calories.ReadOnly = true;
            this.txt_Calories.Size = new System.Drawing.Size(100, 20);
            this.txt_Calories.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(473, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "NumberOfServings";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_NumOfServings
            // 
            this.txt_NumOfServings.Location = new System.Drawing.Point(575, 509);
            this.txt_NumOfServings.Name = "txt_NumOfServings";
            this.txt_NumOfServings.Size = new System.Drawing.Size(158, 20);
            this.txt_NumOfServings.TabIndex = 24;
            // 
            // Calculate_ingredients_btn
            // 
            this.Calculate_ingredients_btn.Location = new System.Drawing.Point(803, 506);
            this.Calculate_ingredients_btn.Name = "Calculate_ingredients_btn";
            this.Calculate_ingredients_btn.Size = new System.Drawing.Size(75, 23);
            this.Calculate_ingredients_btn.TabIndex = 25;
            this.Calculate_ingredients_btn.Text = "Calculate";
            this.Calculate_ingredients_btn.UseVisualStyleBackColor = true;
            this.Calculate_ingredients_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 516);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Review";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Review_richTextBox
            // 
            this.Review_richTextBox.Location = new System.Drawing.Point(34, 532);
            this.Review_richTextBox.Name = "Review_richTextBox";
            this.Review_richTextBox.Size = new System.Drawing.Size(351, 96);
            this.Review_richTextBox.TabIndex = 27;
            this.Review_richTextBox.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(473, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Recipe Reviews";
            // 
            // PostView_btn
            // 
            this.PostView_btn.Location = new System.Drawing.Point(391, 605);
            this.PostView_btn.Name = "PostView_btn";
            this.PostView_btn.Size = new System.Drawing.Size(75, 23);
            this.PostView_btn.TabIndex = 30;
            this.PostView_btn.Text = "Post Review";
            this.PostView_btn.UseVisualStyleBackColor = true;
            this.PostView_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(869, 605);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 31;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // UsersRatingradioBtn
            // 
            this.UsersRatingradioBtn.AutoSize = true;
            this.UsersRatingradioBtn.Location = new System.Drawing.Point(476, 111);
            this.UsersRatingradioBtn.Name = "UsersRatingradioBtn";
            this.UsersRatingradioBtn.Size = new System.Drawing.Size(81, 17);
            this.UsersRatingradioBtn.TabIndex = 32;
            this.UsersRatingradioBtn.TabStop = true;
            this.UsersRatingradioBtn.Text = "Users rating";
            this.UsersRatingradioBtn.UseVisualStyleBackColor = true;
            this.UsersRatingradioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // HealthRatingradioBtn
            // 
            this.HealthRatingradioBtn.AutoSize = true;
            this.HealthRatingradioBtn.Location = new System.Drawing.Point(476, 134);
            this.HealthRatingradioBtn.Name = "HealthRatingradioBtn";
            this.HealthRatingradioBtn.Size = new System.Drawing.Size(90, 17);
            this.HealthRatingradioBtn.TabIndex = 33;
            this.HealthRatingradioBtn.TabStop = true;
            this.HealthRatingradioBtn.Text = "Health Rating";
            this.HealthRatingradioBtn.UseVisualStyleBackColor = true;
            this.HealthRatingradioBtn.CheckedChanged += new System.EventHandler(this.HealthRatingradioBtn_CheckedChanged);
            // 
            // txt_rating
            // 
            this.txt_rating.Location = new System.Drawing.Point(633, 111);
            this.txt_rating.Name = "txt_rating";
            this.txt_rating.ReadOnly = true;
            this.txt_rating.Size = new System.Drawing.Size(100, 20);
            this.txt_rating.TabIndex = 34;
            // 
            // Reviews_dgv
            // 
            this.Reviews_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reviews_dgv.Location = new System.Drawing.Point(476, 196);
            this.Reviews_dgv.Name = "Reviews_dgv";
            this.Reviews_dgv.Size = new System.Drawing.Size(468, 287);
            this.Reviews_dgv.TabIndex = 35;
            // 
            // recipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 639);
            this.Controls.Add(this.Reviews_dgv);
            this.Controls.Add(this.txt_rating);
            this.Controls.Add(this.HealthRatingradioBtn);
            this.Controls.Add(this.UsersRatingradioBtn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.PostView_btn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Review_richTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Calculate_ingredients_btn);
            this.Controls.Add(this.txt_NumOfServings);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Calories);
            this.Controls.Add(this.txt_HealthScore);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.list_instructions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.list_ingredients);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Servings);
            this.Controls.Add(this.txt_DishTypes);
            this.Controls.Add(this.txt_PricePerServing);
            this.Controls.Add(this.txt_cuisines);
            this.Controls.Add(this.txt_ReadyInMinutes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture_recipe);
            this.Name = "recipeForm";
            this.Text = "recipeForm";
            this.Load += new System.EventHandler(this.recipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_recipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reviews_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_recipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RecipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ReadyInMinutes;
        private System.Windows.Forms.TextBox txt_cuisines;
        private System.Windows.Forms.TextBox txt_PricePerServing;
        private System.Windows.Forms.TextBox txt_DishTypes;
        private System.Windows.Forms.TextBox txt_Servings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox list_ingredients;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox list_instructions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_HealthScore;
        private System.Windows.Forms.TextBox txt_Calories;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_NumOfServings;
        private System.Windows.Forms.Button Calculate_ingredients_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox Review_richTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button PostView_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.RadioButton UsersRatingradioBtn;
        private System.Windows.Forms.RadioButton HealthRatingradioBtn;
        private System.Windows.Forms.TextBox txt_rating;
        private System.Windows.Forms.DataGridView Reviews_dgv;
    }
}