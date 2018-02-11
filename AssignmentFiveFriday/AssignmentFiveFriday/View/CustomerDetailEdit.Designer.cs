namespace AssignmentFiveFriday
{
    partial class CustomerDetailEdit
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
            this.dgvContactDetails = new System.Windows.Forms.DataGridView();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpContactDetails = new System.Windows.Forms.GroupBox();
            this.btnContactNew = new System.Windows.Forms.Button();
            this.btnContactAdd = new System.Windows.Forms.Button();
            this.txtSelectedEmail = new System.Windows.Forms.TextBox();
            this.txtSelectedContactNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactDetails)).BeginInit();
            this.grpContactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContactDetails
            // 
            this.dgvContactDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactDetails.Location = new System.Drawing.Point(6, 213);
            this.dgvContactDetails.MultiSelect = false;
            this.dgvContactDetails.Name = "dgvContactDetails";
            this.dgvContactDetails.Size = new System.Drawing.Size(510, 180);
            this.dgvContactDetails.TabIndex = 21;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(118, 57);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(199, 20);
            this.txtLongitude.TabIndex = 20;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(118, 33);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(199, 20);
            this.txtLatitude.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 18;
            // 
            // grpContactDetails
            // 
            this.grpContactDetails.Controls.Add(this.btnContactNew);
            this.grpContactDetails.Controls.Add(this.btnContactAdd);
            this.grpContactDetails.Controls.Add(this.txtSelectedEmail);
            this.grpContactDetails.Controls.Add(this.txtSelectedContactNo);
            this.grpContactDetails.Controls.Add(this.lblEmail);
            this.grpContactDetails.Controls.Add(this.lblContactNo);
            this.grpContactDetails.Location = new System.Drawing.Point(6, 93);
            this.grpContactDetails.Name = "grpContactDetails";
            this.grpContactDetails.Size = new System.Drawing.Size(510, 102);
            this.grpContactDetails.TabIndex = 17;
            this.grpContactDetails.TabStop = false;
            this.grpContactDetails.Text = "Contact Details";
            // 
            // btnContactNew
            // 
            this.btnContactNew.Location = new System.Drawing.Point(388, 15);
            this.btnContactNew.Name = "btnContactNew";
            this.btnContactNew.Size = new System.Drawing.Size(108, 36);
            this.btnContactNew.TabIndex = 13;
            this.btnContactNew.Text = "New";
            this.btnContactNew.UseVisualStyleBackColor = true;
            // 
            // btnContactAdd
            // 
            this.btnContactAdd.Enabled = false;
            this.btnContactAdd.Location = new System.Drawing.Point(388, 57);
            this.btnContactAdd.Name = "btnContactAdd";
            this.btnContactAdd.Size = new System.Drawing.Size(108, 36);
            this.btnContactAdd.TabIndex = 12;
            this.btnContactAdd.Text = "Add";
            this.btnContactAdd.UseVisualStyleBackColor = true;
            // 
            // txtSelectedEmail
            // 
            this.txtSelectedEmail.Location = new System.Drawing.Point(112, 48);
            this.txtSelectedEmail.Name = "txtSelectedEmail";
            this.txtSelectedEmail.Size = new System.Drawing.Size(199, 20);
            this.txtSelectedEmail.TabIndex = 10;
            // 
            // txtSelectedContactNo
            // 
            this.txtSelectedContactNo.Location = new System.Drawing.Point(112, 24);
            this.txtSelectedContactNo.Name = "txtSelectedContactNo";
            this.txtSelectedContactNo.Size = new System.Drawing.Size(199, 20);
            this.txtSelectedContactNo.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(5, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(5, 27);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(64, 13);
            this.lblContactNo.TabIndex = 7;
            this.lblContactNo.Text = "Contact No:";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(11, 36);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(51, 13);
            this.lblLatitude.TabIndex = 16;
            this.lblLatitude.Text = "Latitude: ";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(12, 60);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(57, 13);
            this.lblLongitude.TabIndex = 15;
            this.lblLongitude.Text = "Longitude:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Customer Name: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(394, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 34);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CustomerDetailEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 452);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvContactDetails);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpContactDetails);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblName);
            this.Name = "CustomerDetailEdit";
            this.ShowIcon = false;
            this.Text = "CustomerDetailEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactDetails)).EndInit();
            this.grpContactDetails.ResumeLayout(false);
            this.grpContactDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactDetails;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpContactDetails;
        private System.Windows.Forms.Button btnContactNew;
        private System.Windows.Forms.Button btnContactAdd;
        private System.Windows.Forms.TextBox txtSelectedEmail;
        private System.Windows.Forms.TextBox txtSelectedContactNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}