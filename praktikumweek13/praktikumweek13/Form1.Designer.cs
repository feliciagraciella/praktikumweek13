namespace praktikumweek13
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
            this.labelInputData = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.labelTulisan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.Location = new System.Drawing.Point(24, 26);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(63, 13);
            this.labelInputData.TabIndex = 0;
            this.labelInputData.Text = "Input Data :";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(27, 42);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(334, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(27, 81);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(75, 23);
            this.buttonProses.TabIndex = 2;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // labelTulisan
            // 
            this.labelTulisan.AutoSize = true;
            this.labelTulisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTulisan.Location = new System.Drawing.Point(24, 127);
            this.labelTulisan.Name = "labelTulisan";
            this.labelTulisan.Size = new System.Drawing.Size(85, 24);
            this.labelTulisan.TabIndex = 3;
            this.labelTulisan.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 184);
            this.Controls.Add(this.labelTulisan);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInputData);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.Label labelTulisan;
    }
}

