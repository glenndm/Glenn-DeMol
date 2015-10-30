namespace Yahtzeee
{
    partial class Yahtzee
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
            this.btnWerpAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWerpAll
            // 
            this.btnWerpAll.Location = new System.Drawing.Point(28, 232);
            this.btnWerpAll.Name = "btnWerpAll";
            this.btnWerpAll.Size = new System.Drawing.Size(147, 40);
            this.btnWerpAll.TabIndex = 0;
            this.btnWerpAll.Text = "werp allen";
            this.btnWerpAll.UseVisualStyleBackColor = true;
            this.btnWerpAll.Click += new System.EventHandler(this.btnWerpAll_Click);
            // 
            // Yahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(452, 286);
            this.Controls.Add(this.btnWerpAll);
            this.Name = "Yahtzee";
            this.Text = "Yahtzee";
            this.Load += new System.EventHandler(this.Yahtzee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWerpAll;
    }
}

