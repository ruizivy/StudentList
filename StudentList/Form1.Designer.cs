
namespace StudentList
{
    partial class frmStudent
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
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddr = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(41, 42);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(84, 19);
            this.lblLName.TabIndex = 0;
            this.lblLName.Text = "Lastname: ";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(125, 39);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(216, 23);
            this.txtLName.TabIndex = 1;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(477, 42);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(246, 23);
            this.txtFName.TabIndex = 3;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(393, 46);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(78, 19);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "Firstname:";
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(863, 43);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(138, 23);
            this.txtMName.TabIndex = 5;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(750, 46);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(107, 19);
            this.lblMName.TabIndex = 4;
            this.lblMName.Text = "Middle Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 92);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(598, 23);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(41, 96);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(69, 19);
            this.lblAddr.TabIndex = 6;
            this.lblAddr.Text = "Address: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(796, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmLName,
            this.clmFName,
            this.clmMName,
            this.clmAddr});
            this.lstUsers.FullRowSelect = true;
            this.lstUsers.GridLines = true;
            this.lstUsers.HideSelection = false;
            this.lstUsers.Location = new System.Drawing.Point(45, 184);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(956, 505);
            this.lstUsers.TabIndex = 9;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            this.lstUsers.Click += new System.EventHandler(this.lstUsers_Click);
            this.lstUsers.DoubleClick += new System.EventHandler(this.lstUsers_DoubleClick);
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 0;
            // 
            // clmLName
            // 
            this.clmLName.Text = "Last Name";
            this.clmLName.Width = 161;
            // 
            // clmFName
            // 
            this.clmFName.Text = "First Name";
            this.clmFName.Width = 171;
            // 
            // clmMName
            // 
            this.clmMName.Text = "Middle Name";
            this.clmMName.Width = 117;
            // 
            // clmAddr
            // 
            this.clmAddr.Text = "Address";
            this.clmAddr.Width = 478;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(108, 149);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 23);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(41, 149);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 19);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search:";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 725);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmLName;
        private System.Windows.Forms.ColumnHeader clmFName;
        private System.Windows.Forms.ColumnHeader clmMName;
        private System.Windows.Forms.ColumnHeader clmAddr;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

