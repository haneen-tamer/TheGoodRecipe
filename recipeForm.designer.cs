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
            this.RecipeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ReadyInMinutes = new System.Windows.Forms.TextBox();
            this.txt_PricePerServing = new System.Windows.Forms.TextBox();
            this.txt_Servings = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.list_ingredients = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.list_instructions = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_HealthScore = new System.Windows.Forms.TextBox();
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
            this.IngredientsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.IngredientsAmount = new System.Windows.Forms.ListBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_recipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reviews_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_recipe
            // 
            this.picture_recipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_recipe.Location = new System.Drawing.Point(41, 15);
            this.picture_recipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture_recipe.Name = "picture_recipe";
            this.picture_recipe.Size = new System.Drawing.Size(618, 269);
            this.picture_recipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_recipe.TabIndex = 0;
            this.picture_recipe.TabStop = false;
            // 
            // RecipeName
            // 
            this.RecipeName.AutoSize = true;
            this.RecipeName.BackColor = System.Drawing.Color.Transparent;
            this.RecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.RecipeName.Location = new System.Drawing.Point(697, 15);
            this.RecipeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(234, 42);
            this.RecipeName.TabIndex = 2;
            this.RecipeName.Text = "RecipeName";
            this.RecipeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(703, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(41, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "ReadyInMinutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(356, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "PricePerServing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(356, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Servings";
            // 
            // txt_ReadyInMinutes
            // 
            this.txt_ReadyInMinutes.Location = new System.Drawing.Point(189, 311);
            this.txt_ReadyInMinutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ReadyInMinutes.Name = "txt_ReadyInMinutes";
            this.txt_ReadyInMinutes.ReadOnly = true;
            this.txt_ReadyInMinutes.Size = new System.Drawing.Size(140, 22);
            this.txt_ReadyInMinutes.TabIndex = 9;
            this.txt_ReadyInMinutes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_PricePerServing
            // 
            this.txt_PricePerServing.Location = new System.Drawing.Point(507, 308);
            this.txt_PricePerServing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PricePerServing.Name = "txt_PricePerServing";
            this.txt_PricePerServing.ReadOnly = true;
            this.txt_PricePerServing.Size = new System.Drawing.Size(152, 22);
            this.txt_PricePerServing.TabIndex = 11;
            // 
            // txt_Servings
            // 
            this.txt_Servings.Location = new System.Drawing.Point(507, 384);
            this.txt_Servings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Servings.Name = "txt_Servings";
            this.txt_Servings.ReadOnly = true;
            this.txt_Servings.Size = new System.Drawing.Size(152, 22);
            this.txt_Servings.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(63, 437);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ingredients";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // list_ingredients
            // 
            this.list_ingredients.FormattingEnabled = true;
            this.list_ingredients.HorizontalScrollbar = true;
            this.list_ingredients.ItemHeight = 16;
            this.list_ingredients.Location = new System.Drawing.Point(44, 462);
            this.list_ingredients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_ingredients.Name = "list_ingredients";
            this.list_ingredients.Size = new System.Drawing.Size(285, 164);
            this.list_ingredients.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(369, 437);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Instructions";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // list_instructions
            // 
            this.list_instructions.FormattingEnabled = true;
            this.list_instructions.HorizontalScrollbar = true;
            this.list_instructions.ItemHeight = 16;
            this.list_instructions.Location = new System.Drawing.Point(360, 462);
            this.list_instructions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_instructions.Name = "list_instructions";
            this.list_instructions.Size = new System.Drawing.Size(299, 164);
            this.list_instructions.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(41, 386);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "HealthScore";
            // 
            // txt_HealthScore
            // 
            this.txt_HealthScore.Location = new System.Drawing.Point(185, 378);
            this.txt_HealthScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_HealthScore.Name = "txt_HealthScore";
            this.txt_HealthScore.ReadOnly = true;
            this.txt_HealthScore.Size = new System.Drawing.Size(144, 22);
            this.txt_HealthScore.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(703, 220);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "NumberOfServings";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_NumOfServings
            // 
            this.txt_NumOfServings.Location = new System.Drawing.Point(875, 217);
            this.txt_NumOfServings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NumOfServings.Name = "txt_NumOfServings";
            this.txt_NumOfServings.Size = new System.Drawing.Size(185, 22);
            this.txt_NumOfServings.TabIndex = 24;
            // 
            // Calculate_ingredients_btn
            // 
            this.Calculate_ingredients_btn.Location = new System.Drawing.Point(1099, 214);
            this.Calculate_ingredients_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Calculate_ingredients_btn.Name = "Calculate_ingredients_btn";
            this.Calculate_ingredients_btn.Size = new System.Drawing.Size(100, 28);
            this.Calculate_ingredients_btn.TabIndex = 25;
            this.Calculate_ingredients_btn.Text = "Calculate";
            this.Calculate_ingredients_btn.UseVisualStyleBackColor = true;
            this.Calculate_ingredients_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(303, 630);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "Review";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Review_richTextBox
            // 
            this.Review_richTextBox.Location = new System.Drawing.Point(45, 655);
            this.Review_richTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Review_richTextBox.Name = "Review_richTextBox";
            this.Review_richTextBox.Size = new System.Drawing.Size(613, 132);
            this.Review_richTextBox.TabIndex = 27;
            this.Review_richTextBox.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.Location = new System.Drawing.Point(715, 431);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "Recipe Reviews";
            // 
            // PostView_btn
            // 
            this.PostView_btn.Location = new System.Drawing.Point(507, 795);
            this.PostView_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostView_btn.Name = "PostView_btn";
            this.PostView_btn.Size = new System.Drawing.Size(119, 28);
            this.PostView_btn.TabIndex = 30;
            this.PostView_btn.Text = "Post Review";
            this.PostView_btn.UseVisualStyleBackColor = true;
            this.PostView_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(1200, 132);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(88, 28);
            this.back_btn.TabIndex = 31;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // UsersRatingradioBtn
            // 
            this.UsersRatingradioBtn.AutoSize = true;
            this.UsersRatingradioBtn.BackColor = System.Drawing.Color.Transparent;
            this.UsersRatingradioBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.UsersRatingradioBtn.Location = new System.Drawing.Point(707, 137);
            this.UsersRatingradioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsersRatingradioBtn.Name = "UsersRatingradioBtn";
            this.UsersRatingradioBtn.Size = new System.Drawing.Size(121, 25);
            this.UsersRatingradioBtn.TabIndex = 32;
            this.UsersRatingradioBtn.TabStop = true;
            this.UsersRatingradioBtn.Text = "Users rating";
            this.UsersRatingradioBtn.UseVisualStyleBackColor = false;
            this.UsersRatingradioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // HealthRatingradioBtn
            // 
            this.HealthRatingradioBtn.AutoSize = true;
            this.HealthRatingradioBtn.BackColor = System.Drawing.Color.Transparent;
            this.HealthRatingradioBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.HealthRatingradioBtn.Location = new System.Drawing.Point(707, 165);
            this.HealthRatingradioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HealthRatingradioBtn.Name = "HealthRatingradioBtn";
            this.HealthRatingradioBtn.Size = new System.Drawing.Size(132, 25);
            this.HealthRatingradioBtn.TabIndex = 33;
            this.HealthRatingradioBtn.TabStop = true;
            this.HealthRatingradioBtn.Text = "Health Rating";
            this.HealthRatingradioBtn.UseVisualStyleBackColor = false;
            this.HealthRatingradioBtn.CheckedChanged += new System.EventHandler(this.HealthRatingradioBtn_CheckedChanged);
            // 
            // txt_rating
            // 
            this.txt_rating.Location = new System.Drawing.Point(888, 135);
            this.txt_rating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_rating.Name = "txt_rating";
            this.txt_rating.ReadOnly = true;
            this.txt_rating.Size = new System.Drawing.Size(132, 22);
            this.txt_rating.TabIndex = 34;
            // 
            // Reviews_dgv
            // 
            this.Reviews_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Reviews_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reviews_dgv.Location = new System.Drawing.Point(707, 455);
            this.Reviews_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reviews_dgv.Name = "Reviews_dgv";
            this.Reviews_dgv.RowHeadersWidth = 51;
            this.Reviews_dgv.Size = new System.Drawing.Size(549, 342);
            this.Reviews_dgv.TabIndex = 35;
            this.Reviews_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Reviews_dgv_CellContentClick);
            // 
            // IngredientsPanel
            // 
            this.IngredientsPanel.Location = new System.Drawing.Point(789, 260);
            this.IngredientsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IngredientsPanel.Name = "IngredientsPanel";
            this.IngredientsPanel.Size = new System.Drawing.Size(355, 146);
            this.IngredientsPanel.TabIndex = 36;
            // 
            // IngredientsAmount
            // 
            this.IngredientsAmount.FormattingEnabled = true;
            this.IngredientsAmount.ItemHeight = 16;
            this.IngredientsAmount.Location = new System.Drawing.Point(789, 260);
            this.IngredientsAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IngredientsAmount.Name = "IngredientsAmount";
            this.IngredientsAmount.Size = new System.Drawing.Size(353, 148);
            this.IngredientsAmount.TabIndex = 16;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(1200, 81);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(88, 28);
            this.login_btn.TabIndex = 37;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(1200, 81);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(88, 28);
            this.logout_btn.TabIndex = 38;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // recipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheGoodRecipe.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1500, 838);
            this.Controls.Add(this.IngredientsAmount);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.IngredientsPanel);
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
            this.Controls.Add(this.txt_HealthScore);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.list_instructions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.list_ingredients);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Servings);
            this.Controls.Add(this.txt_PricePerServing);
            this.Controls.Add(this.txt_ReadyInMinutes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.picture_recipe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label RecipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ReadyInMinutes;
        private System.Windows.Forms.TextBox txt_PricePerServing;
        private System.Windows.Forms.TextBox txt_Servings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox list_ingredients;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox list_instructions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_HealthScore;
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
        private System.Windows.Forms.FlowLayoutPanel IngredientsPanel;
        private System.Windows.Forms.ListBox IngredientsAmount;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button logout_btn;
    }
}