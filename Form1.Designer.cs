namespace LapFour
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOperators = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.btnActMeth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section 1 Lap Four";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "All Operators";
            // 
            // btnOperators
            // 
            this.btnOperators.Location = new System.Drawing.Point(398, 115);
            this.btnOperators.Name = "btnOperators";
            this.btnOperators.Size = new System.Drawing.Size(314, 83);
            this.btnOperators.TabIndex = 1;
            this.btnOperators.Text = "Check Operator";
            this.btnOperators.UseVisualStyleBackColor = true;
            this.btnOperators.Click += new System.EventHandler(this.btnOperators_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Methods";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(465, 308);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(145, 18);
            this.lblMethod.TabIndex = 0;
            this.lblMethod.Text = "Method Temp Code";
            // 
            // btnActMeth
            // 
            this.btnActMeth.Location = new System.Drawing.Point(398, 353);
            this.btnActMeth.Name = "btnActMeth";
            this.btnActMeth.Size = new System.Drawing.Size(314, 82);
            this.btnActMeth.TabIndex = 2;
            this.btnActMeth.Text = "Activate Method";
            this.btnActMeth.UseVisualStyleBackColor = true;
            this.btnActMeth.Click += new System.EventHandler(this.btnActMeth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 658);
            this.Controls.Add(this.btnActMeth);
            this.Controls.Add(this.btnOperators);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOperators;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Button btnActMeth;
    }
}

