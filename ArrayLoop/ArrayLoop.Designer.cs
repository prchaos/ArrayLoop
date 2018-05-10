namespace ArrayLoop
{
    partial class ArrayLoop
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
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.richTxtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lstNames
            // 
            this.lstNames.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 25;
            this.lstNames.Location = new System.Drawing.Point(0, 0);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(229, 294);
            this.lstNames.TabIndex = 1;
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(608, 12);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(100, 35);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // richTxtResult
            // 
            this.richTxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtResult.Location = new System.Drawing.Point(415, 83);
            this.richTxtResult.Name = "richTxtResult";
            this.richTxtResult.Size = new System.Drawing.Size(293, 199);
            this.richTxtResult.TabIndex = 4;
            this.richTxtResult.Text = "";
            // 
            // ArrayLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 294);
            this.Controls.Add(this.richTxtResult);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.lstNames);
            this.Name = "ArrayLoop";
            this.Text = "ArrayLoop";
            this.Load += new System.EventHandler(this.ArrayLoop_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.RichTextBox richTxtResult;
    }
}

