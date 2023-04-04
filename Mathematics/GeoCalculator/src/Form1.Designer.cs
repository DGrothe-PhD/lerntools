namespace NachhilfeGeometrie
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cmbObjekt = new ComboBox();
            btnCalculate = new Button();
            txtAusgabe = new TextBox();
            lblMass1 = new Label();
            lblMass2 = new Label();
            lblMass3 = new Label();
            txtAnsArea = new TextBox();
            lblArea = new Label();
            txtAnsCircum = new TextBox();
            lblCircum = new Label();
            label4 = new Label();
            numMass1 = new NumericUpDown();
            numMass2 = new NumericUpDown();
            numMass3 = new NumericUpDown();
            numShift1 = new NumericUpDown();
            numAngle1 = new NumericUpDown();
            chkShift1 = new CheckBox();
            chkAngle1 = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            allesAufNullSetzenToolStripMenuItem = new ToolStripMenuItem();
            punktestandAnzeigenToolStripMenuItem = new ToolStripMenuItem();
            debugModeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numMass1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMass2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMass3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numShift1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAngle1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Objekt";
            // 
            // cmbObjekt
            // 
            cmbObjekt.FormattingEnabled = true;
            cmbObjekt.Location = new Point(26, 44);
            cmbObjekt.Name = "cmbObjekt";
            cmbObjekt.Size = new Size(189, 28);
            cmbObjekt.TabIndex = 1;
            cmbObjekt.SelectedValueChanged += prepareSettings;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.RosyBrown;
            btnCalculate.Location = new Point(316, 411);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "OK";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += calculateObject;
            // 
            // txtAusgabe
            // 
            txtAusgabe.Location = new Point(440, 43);
            txtAusgabe.Multiline = true;
            txtAusgabe.Name = "txtAusgabe";
            txtAusgabe.Size = new Size(330, 396);
            txtAusgabe.TabIndex = 3;
            // 
            // lblMass1
            // 
            lblMass1.AutoSize = true;
            lblMass1.Location = new Point(26, 99);
            lblMass1.Name = "lblMass1";
            lblMass1.Size = new Size(49, 20);
            lblMass1.TabIndex = 4;
            lblMass1.Text = "Länge";
            // 
            // lblMass2
            // 
            lblMass2.AutoSize = true;
            lblMass2.Location = new Point(26, 141);
            lblMass2.Name = "lblMass2";
            lblMass2.Size = new Size(48, 20);
            lblMass2.TabIndex = 5;
            lblMass2.Text = "Breite";
            // 
            // lblMass3
            // 
            lblMass3.AutoSize = true;
            lblMass3.Location = new Point(26, 192);
            lblMass3.Name = "lblMass3";
            lblMass3.Size = new Size(45, 20);
            lblMass3.TabIndex = 8;
            lblMass3.Text = "Höhe";
            // 
            // txtAnsArea
            // 
            txtAnsArea.Location = new Point(128, 371);
            txtAnsArea.Name = "txtAnsArea";
            txtAnsArea.Size = new Size(172, 27);
            txtAnsArea.TabIndex = 10;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(26, 378);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(51, 20);
            lblArea.TabIndex = 11;
            lblArea.Text = "Fläche";
            // 
            // txtAnsCircum
            // 
            txtAnsCircum.Location = new Point(128, 412);
            txtAnsCircum.Name = "txtAnsCircum";
            txtAnsCircum.Size = new Size(172, 27);
            txtAnsCircum.TabIndex = 12;
            // 
            // lblCircum
            // 
            lblCircum.AutoSize = true;
            lblCircum.Location = new Point(26, 415);
            lblCircum.Name = "lblCircum";
            lblCircum.Size = new Size(62, 20);
            lblCircum.TabIndex = 13;
            lblCircum.Text = "Umfang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 343);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 14;
            label4.Text = "Gib die Antwort hier:";
            // 
            // numMass1
            // 
            numMass1.DecimalPlaces = 2;
            numMass1.Location = new Point(238, 97);
            numMass1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMass1.Name = "numMass1";
            numMass1.Size = new Size(172, 27);
            numMass1.TabIndex = 19;
            numMass1.TextAlign = HorizontalAlignment.Right;
            // 
            // numMass2
            // 
            numMass2.DecimalPlaces = 2;
            numMass2.Location = new Point(238, 139);
            numMass2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMass2.Name = "numMass2";
            numMass2.Size = new Size(172, 27);
            numMass2.TabIndex = 20;
            numMass2.TextAlign = HorizontalAlignment.Right;
            // 
            // numMass3
            // 
            numMass3.DecimalPlaces = 2;
            numMass3.Location = new Point(238, 190);
            numMass3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMass3.Name = "numMass3";
            numMass3.Size = new Size(172, 27);
            numMass3.TabIndex = 21;
            numMass3.TextAlign = HorizontalAlignment.Right;
            // 
            // numShift1
            // 
            numShift1.DecimalPlaces = 2;
            numShift1.Location = new Point(295, 240);
            numShift1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numShift1.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numShift1.Name = "numShift1";
            numShift1.Size = new Size(115, 27);
            numShift1.TabIndex = 22;
            numShift1.TextAlign = HorizontalAlignment.Right;
            // 
            // numAngle1
            // 
            numAngle1.DecimalPlaces = 2;
            numAngle1.Location = new Point(295, 283);
            numAngle1.Maximum = new decimal(new int[] { 1799, 0, 0, 65536 });
            numAngle1.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numAngle1.Name = "numAngle1";
            numAngle1.Size = new Size(115, 27);
            numAngle1.TabIndex = 23;
            numAngle1.TextAlign = HorizontalAlignment.Right;
            numAngle1.Value = new decimal(new int[] { 90, 0, 0, 0 });
            // 
            // chkShift1
            // 
            chkShift1.AutoSize = true;
            chkShift1.Location = new Point(39, 241);
            chkShift1.Name = "chkShift1";
            chkShift1.Size = new Size(119, 24);
            chkShift1.TabIndex = 24;
            chkShift1.Text = "Verschiebung";
            chkShift1.UseVisualStyleBackColor = true;
            chkShift1.CheckedChanged += allowOnlyOneParam;
            // 
            // chkAngle1
            // 
            chkAngle1.AutoSize = true;
            chkAngle1.Location = new Point(39, 284);
            chkAngle1.Name = "chkAngle1";
            chkAngle1.Size = new Size(95, 24);
            chkAngle1.TabIndex = 25;
            chkAngle1.Text = "Eckwinkel";
            chkAngle1.UseVisualStyleBackColor = true;
            chkAngle1.CheckedChanged += allowOnlyOneParam;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { allesAufNullSetzenToolStripMenuItem, punktestandAnzeigenToolStripMenuItem, debugModeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(223, 76);
            // 
            // allesAufNullSetzenToolStripMenuItem
            // 
            allesAufNullSetzenToolStripMenuItem.Name = "allesAufNullSetzenToolStripMenuItem";
            allesAufNullSetzenToolStripMenuItem.Size = new Size(222, 24);
            allesAufNullSetzenToolStripMenuItem.Text = "Alles auf Null setzen";
            allesAufNullSetzenToolStripMenuItem.Click += allesAufNullSetzenToolStripMenuItem_Click;
            // 
            // punktestandAnzeigenToolStripMenuItem
            // 
            punktestandAnzeigenToolStripMenuItem.Name = "punktestandAnzeigenToolStripMenuItem";
            punktestandAnzeigenToolStripMenuItem.Size = new Size(222, 24);
            punktestandAnzeigenToolStripMenuItem.Text = "Punktestand anzeigen";
            // 
            // debugModeToolStripMenuItem
            // 
            debugModeToolStripMenuItem.Name = "debugModeToolStripMenuItem";
            debugModeToolStripMenuItem.Size = new Size(222, 24);
            debugModeToolStripMenuItem.Text = "Debug-Mode";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(chkAngle1);
            Controls.Add(chkShift1);
            Controls.Add(numAngle1);
            Controls.Add(numShift1);
            Controls.Add(numMass3);
            Controls.Add(numMass2);
            Controls.Add(numMass1);
            Controls.Add(label4);
            Controls.Add(lblCircum);
            Controls.Add(txtAnsCircum);
            Controls.Add(lblArea);
            Controls.Add(txtAnsArea);
            Controls.Add(lblMass3);
            Controls.Add(lblMass2);
            Controls.Add(lblMass1);
            Controls.Add(txtAusgabe);
            Controls.Add(btnCalculate);
            Controls.Add(cmbObjekt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Geometrische Figuren";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numMass1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMass2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMass3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numShift1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAngle1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbObjekt;
        private Button btnCalculate;
        private TextBox txtAusgabe;
        private Label lblMass1;
        private Label lblMass2;
        private Label lblMass3;
        private TextBox txtAnsArea;
        private Label lblArea;
        private TextBox txtAnsCircum;
        private Label lblCircum;
        private Label label4;
        private NumericUpDown numMass1;
        private NumericUpDown numMass2;
        private NumericUpDown numMass3;
        private NumericUpDown numShift1;
        private NumericUpDown numAngle1;
        private CheckBox chkShift1;
        private CheckBox chkAngle1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem allesAufNullSetzenToolStripMenuItem;
        private ToolStripMenuItem punktestandAnzeigenToolStripMenuItem;
        private ToolStripMenuItem debugModeToolStripMenuItem;
    }
}