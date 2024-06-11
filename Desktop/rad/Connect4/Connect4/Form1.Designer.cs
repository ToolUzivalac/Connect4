namespace Connect4
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
            this.prvi = new System.Windows.Forms.Button();
            this.drugi = new System.Windows.Forms.Button();
            this.treci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prvi
            // 
            this.prvi.Location = new System.Drawing.Point(32, 156);
            this.prvi.Name = "prvi";
            this.prvi.Size = new System.Drawing.Size(119, 102);
            this.prvi.TabIndex = 0;
            this.prvi.Text = "6x7";
            this.prvi.UseVisualStyleBackColor = true;
            this.prvi.Click += new System.EventHandler(this.prvi_Click);
            // 
            // drugi
            // 
            this.drugi.Location = new System.Drawing.Point(188, 156);
            this.drugi.Name = "drugi";
            this.drugi.Size = new System.Drawing.Size(119, 102);
            this.drugi.TabIndex = 1;
            this.drugi.Text = "6x5";
            this.drugi.UseVisualStyleBackColor = true;
            this.drugi.Click += new System.EventHandler(this.drugi_Click);
            // 
            // treci
            // 
            this.treci.Location = new System.Drawing.Point(341, 156);
            this.treci.Name = "treci";
            this.treci.Size = new System.Drawing.Size(119, 102);
            this.treci.TabIndex = 2;
            this.treci.Text = "10x7";
            this.treci.UseVisualStyleBackColor = true;
            this.treci.Click += new System.EventHandler(this.treci_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberite velicinu table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treci);
            this.Controls.Add(this.drugi);
            this.Controls.Add(this.prvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prvi;
        private System.Windows.Forms.Button drugi;
        private System.Windows.Forms.Button treci;
        private System.Windows.Forms.Label label1;
    }
}

