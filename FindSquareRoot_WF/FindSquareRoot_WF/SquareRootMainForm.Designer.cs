namespace FindSquareRoot_WF
{
    partial class SquareRootMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginalNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a number and I will calculate the square root: ";
            // 
            // txtOriginalNumber
            // 
            this.txtOriginalNumber.Location = new System.Drawing.Point(400, 26);
            this.txtOriginalNumber.Name = "txtOriginalNumber";
            this.txtOriginalNumber.Size = new System.Drawing.Size(100, 22);
            this.txtOriginalNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "The approximate sqaure root of the number is: ";
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(369, 45);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(100, 22);
            this.txtRoot.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(13, 13);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.txtOriginalNumber);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtRoot);
            this.splitContainer1.Size = new System.Drawing.Size(531, 209);
            this.splitContainer1.SplitterDistance = 104;
            this.splitContainer1.TabIndex = 5;
            // 
            // SquareRootMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 249);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SquareRootMainForm";
            this.Text = "Find The Square Root";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginalNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

