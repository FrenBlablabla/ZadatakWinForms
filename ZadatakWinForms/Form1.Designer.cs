namespace ZadatakWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGet = new Button();
            buttonPost = new Button();
            cmbJmbag = new ComboBox();
            textRésultat = new TextBox();
            SuspendLayout();
            // 
            // buttonGet
            // 
            buttonGet.Location = new Point(210, 94);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(75, 23);
            buttonGet.TabIndex = 0;
            buttonGet.Text = "GET";
            buttonGet.UseVisualStyleBackColor = true;
            // 
            // buttonPost
            // 
            buttonPost.Location = new Point(473, 94);
            buttonPost.Name = "buttonPost";
            buttonPost.Size = new Size(75, 23);
            buttonPost.TabIndex = 1;
            buttonPost.Text = "POST";
            buttonPost.UseVisualStyleBackColor = true;
            // 
            // cmbJmbag
            // 
            cmbJmbag.FormattingEnabled = true;
            cmbJmbag.Location = new Point(325, 147);
            cmbJmbag.Name = "cmbJmbag";
            cmbJmbag.Size = new Size(121, 23);
            cmbJmbag.TabIndex = 2;
            // 
            // textRésultat
            // 
            textRésultat.Location = new Point(12, 203);
            textRésultat.Multiline = true;
            textRésultat.Name = "textRésultat";
            textRésultat.Size = new Size(776, 140);
            textRésultat.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textRésultat);
            Controls.Add(cmbJmbag);
            Controls.Add(buttonPost);
            Controls.Add(buttonGet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGet;
        private Button buttonPost;
        private ComboBox cmbJmbag;
        private TextBox textRésultat;
    }
}
