namespace TheGoodRecipe
{
    partial class Form1
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ViewRecipeCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.sViewRecipeCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchedRecipeTxt = new System.Windows.Forms.TextBox();
            this.logout_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(572, 10);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(148, 29);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewRecipeCol});
            this.dgv1.Location = new System.Drawing.Point(65, 121);
            this.dgv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(656, 274);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // ViewRecipeCol
            // 
            this.ViewRecipeCol.HeaderText = "View Recipe";
            this.ViewRecipeCol.MinimumWidth = 6;
            this.ViewRecipeCol.Name = "ViewRecipeCol";
            this.ViewRecipeCol.ReadOnly = true;
            this.ViewRecipeCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewRecipeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ViewRecipeCol.Text = "View Recipe";
            this.ViewRecipeCol.UseColumnTextForButtonValue = true;
            this.ViewRecipeCol.Width = 125;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.backBtn);
            this.panel.Controls.Add(this.dgvSearch);
            this.panel.Location = new System.Drawing.Point(39, 121);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(708, 337);
            this.panel.TabIndex = 6;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(573, 10);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 29);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sViewRecipeCol});
            this.dgvSearch.Location = new System.Drawing.Point(15, 10);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersWidth = 62;
            this.dgvSearch.RowTemplate.Height = 28;
            this.dgvSearch.Size = new System.Drawing.Size(522, 316);
            this.dgvSearch.TabIndex = 0;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
            // 
            // sViewRecipeCol
            // 
            this.sViewRecipeCol.HeaderText = "View Recipe";
            this.sViewRecipeCol.MinimumWidth = 6;
            this.sViewRecipeCol.Name = "sViewRecipeCol";
            this.sViewRecipeCol.ReadOnly = true;
            this.sViewRecipeCol.Text = "View Recipe";
            this.sViewRecipeCol.UseColumnTextForButtonValue = true;
            this.sViewRecipeCol.Width = 125;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(222, 21);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(134, 25);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search Recipe";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchedRecipeTxt
            // 
            this.searchedRecipeTxt.Location = new System.Drawing.Point(73, 25);
            this.searchedRecipeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchedRecipeTxt.Name = "searchedRecipeTxt";
            this.searchedRecipeTxt.Size = new System.Drawing.Size(126, 22);
            this.searchedRecipeTxt.TabIndex = 8;
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(748, 10);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(146, 29);
            this.logout_btn.TabIndex = 9;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 548);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.searchedRecipeTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.loginBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchedRecipeTxt;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.DataGridViewButtonColumn ViewRecipeCol;
        private System.Windows.Forms.DataGridViewButtonColumn sViewRecipeCol;
        private System.Windows.Forms.Button logout_btn;
    }
}

