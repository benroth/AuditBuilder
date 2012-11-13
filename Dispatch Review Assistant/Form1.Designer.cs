namespace AuditBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlCheckBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.auditBox = new System.Windows.Forms.TextBox();
            this.lblCheckboxes = new System.Windows.Forms.Label();
            this.lblAuditContent = new System.Windows.Forms.Label();
            this.btnBuildAudit = new System.Windows.Forms.Button();
            this.pnlAuditTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAuditTypes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCheckBoxes
            // 
            this.pnlCheckBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCheckBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckBoxes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlCheckBoxes.Location = new System.Drawing.Point(16, 58);
            this.pnlCheckBoxes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCheckBoxes.Name = "pnlCheckBoxes";
            this.pnlCheckBoxes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlCheckBoxes.Size = new System.Drawing.Size(153, 437);
            this.pnlCheckBoxes.TabIndex = 0;
            // 
            // auditBox
            // 
            this.auditBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auditBox.Location = new System.Drawing.Point(186, 58);
            this.auditBox.Multiline = true;
            this.auditBox.Name = "auditBox";
            this.auditBox.Size = new System.Drawing.Size(232, 437);
            this.auditBox.TabIndex = 1;
            // 
            // lblCheckboxes
            // 
            this.lblCheckboxes.AutoSize = true;
            this.lblCheckboxes.Location = new System.Drawing.Point(13, 42);
            this.lblCheckboxes.Name = "lblCheckboxes";
            this.lblCheckboxes.Size = new System.Drawing.Size(69, 13);
            this.lblCheckboxes.TabIndex = 2;
            this.lblCheckboxes.Text = "Audit Criteria:";
            // 
            // lblAuditContent
            // 
            this.lblAuditContent.AutoSize = true;
            this.lblAuditContent.Location = new System.Drawing.Point(183, 42);
            this.lblAuditContent.Name = "lblAuditContent";
            this.lblAuditContent.Size = new System.Drawing.Size(72, 13);
            this.lblAuditContent.TabIndex = 3;
            this.lblAuditContent.Text = "Audit Results:";
            // 
            // btnBuildAudit
            // 
            this.btnBuildAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuildAudit.Location = new System.Drawing.Point(16, 501);
            this.btnBuildAudit.Name = "btnBuildAudit";
            this.btnBuildAudit.Size = new System.Drawing.Size(75, 23);
            this.btnBuildAudit.TabIndex = 4;
            this.btnBuildAudit.Text = "Build Audit";
            this.btnBuildAudit.UseVisualStyleBackColor = true;
            this.btnBuildAudit.Click += new System.EventHandler(this.btnBuildAudit_Click);
            // 
            // pnlAuditTypes
            // 
            this.pnlAuditTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuditTypes.Location = new System.Drawing.Point(76, 8);
            this.pnlAuditTypes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAuditTypes.Name = "pnlAuditTypes";
            this.pnlAuditTypes.Size = new System.Drawing.Size(342, 24);
            this.pnlAuditTypes.TabIndex = 5;
            // 
            // lblAuditTypes
            // 
            this.lblAuditTypes.AutoSize = true;
            this.lblAuditTypes.Location = new System.Drawing.Point(13, 13);
            this.lblAuditTypes.Name = "lblAuditTypes";
            this.lblAuditTypes.Size = new System.Drawing.Size(61, 13);
            this.lblAuditTypes.TabIndex = 6;
            this.lblAuditTypes.Text = "Audit Type:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 25);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAuditTypes);
            this.Controls.Add(this.pnlAuditTypes);
            this.Controls.Add(this.btnBuildAudit);
            this.Controls.Add(this.lblAuditContent);
            this.Controls.Add(this.lblCheckboxes);
            this.Controls.Add(this.auditBox);
            this.Controls.Add(this.pnlCheckBoxes);
            this.MinimumSize = new System.Drawing.Size(446, 504);
            this.Name = "Form1";
            this.Text = "Audit Builder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlCheckBoxes;
        private System.Windows.Forms.TextBox auditBox;
        private System.Windows.Forms.Label lblCheckboxes;
        private System.Windows.Forms.Label lblAuditContent;
        private System.Windows.Forms.Button btnBuildAudit;
        private System.Windows.Forms.FlowLayoutPanel pnlAuditTypes;
        private System.Windows.Forms.Label lblAuditTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

