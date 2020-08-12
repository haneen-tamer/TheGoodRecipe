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
            this.txt_SourceURL = new System.Windows.Forms.TextBox();
            this.txt_publisher = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.list_ingredients = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.list_instructions = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_NumOfServings = new System.Windows.Forms.TextBox();
            this.Calculate_ingredients_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Review_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PostView_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
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
            this.picture_recipe.Size = new System.Drawing.Size(403, 261);
            this.picture_recipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_recipe.TabIndex = 0;
            this.picture_recipe.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 63);
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
            this.RecipeName.Location = new System.Drawing.Point(460, 12);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(234, 42);
            this.RecipeName.TabIndex = 2;
            this.RecipeName.Text = "RecipeName";
            this.RecipeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SourceURL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Publisher";
            // 
            // txt_SourceURL
            // 
            this.txt_SourceURL.Location = new System.Drawing.Point(91, 279);
            this.txt_SourceURL.Name = "txt_SourceURL";
            this.txt_SourceURL.ReadOnly = true;
            this.txt_SourceURL.Size = new System.Drawing.Size(125, 20);
            this.txt_SourceURL.TabIndex = 9;
            this.txt_SourceURL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_publisher
            // 
            this.txt_publisher.Location = new System.Drawing.Point(302, 279);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.ReadOnly = true;
            this.txt_publisher.Size = new System.Drawing.Size(132, 20);
            this.txt_publisher.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ingredients";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // list_ingredients
            // 
            this.list_ingredients.FormattingEnabled = true;
            this.list_ingredients.Location = new System.Drawing.Point(31, 354);
            this.list_ingredients.Name = "list_ingredients";
            this.list_ingredients.Size = new System.Drawing.Size(185, 108);
            this.list_ingredients.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Instructions";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // list_instructions
            // 
            this.list_instructions.FormattingEnabled = true;
            this.list_instructions.Location = new System.Drawing.Point(249, 354);
            this.list_instructions.Name = "list_instructions";
            this.list_instructions.Size = new System.Drawing.Size(185, 108);
            this.list_instructions.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "NumberOfServings";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_NumOfServings
            // 
            this.txt_NumOfServings.Location = new System.Drawing.Point(566, 375);
            this.txt_NumOfServings.Name = "txt_NumOfServings";
            this.txt_NumOfServings.Size = new System.Drawing.Size(188, 20);
            this.txt_NumOfServings.TabIndex = 24;
            // 
            // Calculate_ingredients_btn
            // 
            this.Calculate_ingredients_btn.Location = new System.Drawing.Point(795, 373);
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
            this.label13.Location = new System.Drawing.Point(28, 473);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Review";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Review_richTextBox
            // 
            this.Review_richTextBox.Location = new System.Drawing.Point(31, 489);
            this.Review_richTextBox.Name = "Review_richTextBox";
            this.Review_richTextBox.Size = new System.Drawing.Size(403, 96);
            this.Review_richTextBox.TabIndex = 27;
            this.Review_richTextBox.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(464, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Recipe Reviews";
            // 
            // PostView_btn
            // 
            this.PostView_btn.Location = new System.Drawing.Point(359, 562);
            this.PostView_btn.Name = "PostView_btn";
            this.PostView_btn.Size = new System.Drawing.Size(75, 23);
            this.PostView_btn.TabIndex = 30;
            this.PostView_btn.Text = "Post Review";
            this.PostView_btn.UseVisualStyleBackColor = true;
            this.PostView_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(795, 562);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 31;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // Reviews_dgv
            // 
            this.Reviews_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reviews_dgv.Location = new System.Drawing.Point(467, 135);
            this.Reviews_dgv.Name = "Reviews_dgv";
            this.Reviews_dgv.Size = new System.Drawing.Size(403, 228);
            this.Reviews_dgv.TabIndex = 35;
            // 
            // recipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 598);
            this.Controls.Add(this.Reviews_dgv);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.PostView_btn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Review_richTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Calculate_ingredients_btn);
            this.Controls.Add(this.txt_NumOfServings);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.list_instructions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.list_ingredients);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_publisher);
            this.Controls.Add(this.txt_SourceURL);
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
        private System.Windows.Forms.TextBox txt_SourceURL;
        private System.Windows.Forms.TextBox txt_publisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox list_ingredients;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox list_instructions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_NumOfServings;
        private System.Windows.Forms.Button Calculate_ingredients_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox Review_richTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button PostView_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView Reviews_dgv;
    }
}