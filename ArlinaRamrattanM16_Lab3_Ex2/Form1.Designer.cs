namespace ArlinaRamrattanM16_Lab3_Ex2
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
            this.gbManageLearners = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbLearnerInfo = new System.Windows.Forms.GroupBox();
            this.tbFavDrink = new System.Windows.Forms.TextBox();
            this.tbFavMovie = new System.Windows.Forms.TextBox();
            this.tbLearnerAge = new System.Windows.Forms.TextBox();
            this.lblFavDrink = new System.Windows.Forms.Label();
            this.lblFavMovie = new System.Windows.Forms.Label();
            this.lblLearnerAge = new System.Windows.Forms.Label();
            this.tbLearnerName = new System.Windows.Forms.TextBox();
            this.lblLearnerName = new System.Windows.Forms.Label();
            this.tbLearnerId = new System.Windows.Forms.TextBox();
            this.lblLearnId = new System.Windows.Forms.Label();
            this.gbManageLearners.SuspendLayout();
            this.gbLearnerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbManageLearners
            // 
            this.gbManageLearners.Controls.Add(this.btnClose);
            this.gbManageLearners.Controls.Add(this.btnClear);
            this.gbManageLearners.Controls.Add(this.btnSearch);
            this.gbManageLearners.Controls.Add(this.btnUpdate);
            this.gbManageLearners.Controls.Add(this.btnDelete);
            this.gbManageLearners.Controls.Add(this.btnCreate);
            this.gbManageLearners.Location = new System.Drawing.Point(324, 14);
            this.gbManageLearners.Name = "gbManageLearners";
            this.gbManageLearners.Size = new System.Drawing.Size(210, 236);
            this.gbManageLearners.TabIndex = 3;
            this.gbManageLearners.TabStop = false;
            this.gbManageLearners.Text = "Manage Learners Information";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(59, 207);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(59, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Boxes";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(59, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Find Learner";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(59, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 22);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Learner";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(59, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Learner";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(59, 64);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Add Learner";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbLearnerInfo
            // 
            this.gbLearnerInfo.Controls.Add(this.tbFavDrink);
            this.gbLearnerInfo.Controls.Add(this.tbFavMovie);
            this.gbLearnerInfo.Controls.Add(this.tbLearnerAge);
            this.gbLearnerInfo.Controls.Add(this.lblFavDrink);
            this.gbLearnerInfo.Controls.Add(this.lblFavMovie);
            this.gbLearnerInfo.Controls.Add(this.lblLearnerAge);
            this.gbLearnerInfo.Controls.Add(this.tbLearnerName);
            this.gbLearnerInfo.Controls.Add(this.lblLearnerName);
            this.gbLearnerInfo.Controls.Add(this.tbLearnerId);
            this.gbLearnerInfo.Controls.Add(this.lblLearnId);
            this.gbLearnerInfo.Location = new System.Drawing.Point(75, 14);
            this.gbLearnerInfo.Name = "gbLearnerInfo";
            this.gbLearnerInfo.Size = new System.Drawing.Size(217, 236);
            this.gbLearnerInfo.TabIndex = 2;
            this.gbLearnerInfo.TabStop = false;
            this.gbLearnerInfo.Text = "Learner Information";
            // 
            // tbFavDrink
            // 
            this.tbFavDrink.Location = new System.Drawing.Point(111, 125);
            this.tbFavDrink.Name = "tbFavDrink";
            this.tbFavDrink.Size = new System.Drawing.Size(100, 20);
            this.tbFavDrink.TabIndex = 9;
            // 
            // tbFavMovie
            // 
            this.tbFavMovie.Location = new System.Drawing.Point(111, 98);
            this.tbFavMovie.Name = "tbFavMovie";
            this.tbFavMovie.Size = new System.Drawing.Size(100, 20);
            this.tbFavMovie.TabIndex = 8;
            // 
            // tbLearnerAge
            // 
            this.tbLearnerAge.Location = new System.Drawing.Point(111, 72);
            this.tbLearnerAge.Name = "tbLearnerAge";
            this.tbLearnerAge.Size = new System.Drawing.Size(100, 20);
            this.tbLearnerAge.TabIndex = 7;
            // 
            // lblFavDrink
            // 
            this.lblFavDrink.AutoSize = true;
            this.lblFavDrink.Location = new System.Drawing.Point(10, 132);
            this.lblFavDrink.Name = "lblFavDrink";
            this.lblFavDrink.Size = new System.Drawing.Size(79, 13);
            this.lblFavDrink.TabIndex = 6;
            this.lblFavDrink.Text = "Favourite Drink";
            // 
            // lblFavMovie
            // 
            this.lblFavMovie.AutoSize = true;
            this.lblFavMovie.Location = new System.Drawing.Point(10, 105);
            this.lblFavMovie.Name = "lblFavMovie";
            this.lblFavMovie.Size = new System.Drawing.Size(83, 13);
            this.lblFavMovie.TabIndex = 5;
            this.lblFavMovie.Text = "Favourite Movie";
            // 
            // lblLearnerAge
            // 
            this.lblLearnerAge.AutoSize = true;
            this.lblLearnerAge.Location = new System.Drawing.Point(10, 79);
            this.lblLearnerAge.Name = "lblLearnerAge";
            this.lblLearnerAge.Size = new System.Drawing.Size(65, 13);
            this.lblLearnerAge.TabIndex = 4;
            this.lblLearnerAge.Text = "Learner Age";
            // 
            // tbLearnerName
            // 
            this.tbLearnerName.Location = new System.Drawing.Point(111, 46);
            this.tbLearnerName.Name = "tbLearnerName";
            this.tbLearnerName.Size = new System.Drawing.Size(100, 20);
            this.tbLearnerName.TabIndex = 3;
            // 
            // lblLearnerName
            // 
            this.lblLearnerName.AutoSize = true;
            this.lblLearnerName.Location = new System.Drawing.Point(10, 53);
            this.lblLearnerName.Name = "lblLearnerName";
            this.lblLearnerName.Size = new System.Drawing.Size(74, 13);
            this.lblLearnerName.TabIndex = 2;
            this.lblLearnerName.Text = "Learner Name";
            // 
            // tbLearnerId
            // 
            this.tbLearnerId.Location = new System.Drawing.Point(111, 17);
            this.tbLearnerId.Name = "tbLearnerId";
            this.tbLearnerId.Size = new System.Drawing.Size(100, 20);
            this.tbLearnerId.TabIndex = 1;
            // 
            // lblLearnId
            // 
            this.lblLearnId.AutoSize = true;
            this.lblLearnId.Location = new System.Drawing.Point(10, 24);
            this.lblLearnId.Name = "lblLearnId";
            this.lblLearnId.Size = new System.Drawing.Size(57, 13);
            this.lblLearnId.TabIndex = 0;
            this.lblLearnId.Text = "Learner ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 265);
            this.Controls.Add(this.gbManageLearners);
            this.Controls.Add(this.gbLearnerInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbManageLearners.ResumeLayout(false);
            this.gbLearnerInfo.ResumeLayout(false);
            this.gbLearnerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageLearners;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gbLearnerInfo;
        private System.Windows.Forms.TextBox tbFavDrink;
        private System.Windows.Forms.TextBox tbFavMovie;
        private System.Windows.Forms.TextBox tbLearnerAge;
        private System.Windows.Forms.Label lblFavDrink;
        private System.Windows.Forms.Label lblFavMovie;
        private System.Windows.Forms.Label lblLearnerAge;
        private System.Windows.Forms.TextBox tbLearnerName;
        private System.Windows.Forms.Label lblLearnerName;
        private System.Windows.Forms.TextBox tbLearnerId;
        private System.Windows.Forms.Label lblLearnId;

    }
}

