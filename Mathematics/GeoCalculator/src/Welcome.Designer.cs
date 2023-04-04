namespace NachhilfeGeometrie
{
    partial class Welcome
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
            btnFiguren = new Button();
            btnKoerper = new Button();
            SuspendLayout();
            // 
            // btnFiguren
            // 
            btnFiguren.BackColor = Color.DarkSeaGreen;
            btnFiguren.Location = new Point(22, 37);
            btnFiguren.Name = "btnFiguren";
            btnFiguren.Size = new Size(204, 46);
            btnFiguren.TabIndex = 0;
            btnFiguren.Text = "Figuren";
            btnFiguren.UseVisualStyleBackColor = false;
            btnFiguren.Click += btnFiguren_Click;
            // 
            // btnKoerper
            // 
            btnKoerper.BackColor = Color.DarkSeaGreen;
            btnKoerper.Location = new Point(22, 113);
            btnKoerper.Name = "btnKoerper";
            btnKoerper.Size = new Size(204, 46);
            btnKoerper.TabIndex = 1;
            btnKoerper.Text = "Körper";
            btnKoerper.UseVisualStyleBackColor = false;
            btnKoerper.Click += btnKoerper_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKoerper);
            Controls.Add(btnFiguren);
            Name = "Welcome";
            Text = "Willkommen bei Mathe Lerntool";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFiguren;
        private Button btnKoerper;
    }
}