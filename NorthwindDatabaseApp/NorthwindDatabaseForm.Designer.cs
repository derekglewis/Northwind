
namespace NorthwindDatabaseApp
{
    partial class formDatabaseViewer
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
            this.buttonCustomerCount = new System.Windows.Forms.Button();
            this.labelCustomerCount = new System.Windows.Forms.Label();
            this.labelCustomerCountResult = new System.Windows.Forms.Label();
            this.labelCompanyNames = new System.Windows.Forms.Label();
            this.buttonGetCompanyNames = new System.Windows.Forms.Button();
            this.textBoxQueryResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCustomerCount
            // 
            this.buttonCustomerCount.Location = new System.Drawing.Point(239, 122);
            this.buttonCustomerCount.Name = "buttonCustomerCount";
            this.buttonCustomerCount.Size = new System.Drawing.Size(263, 56);
            this.buttonCustomerCount.TabIndex = 0;
            this.buttonCustomerCount.Text = "Get Customer Count";
            this.buttonCustomerCount.UseVisualStyleBackColor = true;
            this.buttonCustomerCount.Click += new System.EventHandler(this.buttonCustomerCount_Click);
            // 
            // labelCustomerCount
            // 
            this.labelCustomerCount.AutoSize = true;
            this.labelCustomerCount.Location = new System.Drawing.Point(47, 138);
            this.labelCustomerCount.Name = "labelCustomerCount";
            this.labelCustomerCount.Size = new System.Drawing.Size(167, 25);
            this.labelCustomerCount.TabIndex = 1;
            this.labelCustomerCount.Text = "Customer Count";
            // 
            // labelCustomerCountResult
            // 
            this.labelCustomerCountResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCustomerCountResult.Location = new System.Drawing.Point(543, 122);
            this.labelCustomerCountResult.Name = "labelCustomerCountResult";
            this.labelCustomerCountResult.Size = new System.Drawing.Size(234, 56);
            this.labelCustomerCountResult.TabIndex = 3;
            this.labelCustomerCountResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCompanyNames
            // 
            this.labelCompanyNames.AutoSize = true;
            this.labelCompanyNames.Location = new System.Drawing.Point(47, 219);
            this.labelCompanyNames.Name = "labelCompanyNames";
            this.labelCompanyNames.Size = new System.Drawing.Size(176, 25);
            this.labelCompanyNames.TabIndex = 1;
            this.labelCompanyNames.Text = "Company Names";
            // 
            // buttonGetCompanyNames
            // 
            this.buttonGetCompanyNames.Location = new System.Drawing.Point(239, 203);
            this.buttonGetCompanyNames.Name = "buttonGetCompanyNames";
            this.buttonGetCompanyNames.Size = new System.Drawing.Size(263, 56);
            this.buttonGetCompanyNames.TabIndex = 0;
            this.buttonGetCompanyNames.Text = "Get Company Names";
            this.buttonGetCompanyNames.UseVisualStyleBackColor = true;
            this.buttonGetCompanyNames.Click += new System.EventHandler(this.buttonGetCompanyNames_Click);
            // 
            // textBoxQueryResults
            // 
            this.textBoxQueryResults.Location = new System.Drawing.Point(535, 201);
            this.textBoxQueryResults.Multiline = true;
            this.textBoxQueryResults.Name = "textBoxQueryResults";
            this.textBoxQueryResults.ReadOnly = true;
            this.textBoxQueryResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQueryResults.Size = new System.Drawing.Size(1291, 946);
            this.textBoxQueryResults.TabIndex = 4;
            this.textBoxQueryResults.Text = "Query Results...";
            // 
            // formDatabaseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 1176);
            this.Controls.Add(this.textBoxQueryResults);
            this.Controls.Add(this.labelCustomerCountResult);
            this.Controls.Add(this.labelCompanyNames);
            this.Controls.Add(this.labelCustomerCount);
            this.Controls.Add(this.buttonGetCompanyNames);
            this.Controls.Add(this.buttonCustomerCount);
            this.Name = "formDatabaseViewer";
            this.Text = "Northwind Database Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomerCount;
        private System.Windows.Forms.Label labelCustomerCount;
        private System.Windows.Forms.Label labelCustomerCountResult;
        private System.Windows.Forms.Label labelCompanyNames;
        private System.Windows.Forms.Button buttonGetCompanyNames;
        private System.Windows.Forms.TextBox textBoxQueryResults;
    }
}

