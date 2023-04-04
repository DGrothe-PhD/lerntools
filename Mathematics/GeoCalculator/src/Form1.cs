namespace NachhilfeGeometrie
{
    public partial class Form1 : Form
    {
        Dictionary<string, IComputation> ObjekteDictionary;
        IComputation? currentObject;
        Circle k1; Rectangle r1; Trapezoid t1;

        public Form1()
        {
            InitializeComponent();
            ObjekteDictionary = new Dictionary<string, IComputation>();
            k1 = new Circle();
            r1 = new Rectangle();
            t1 = new Trapezoid();
        }

        public Form1(Welcome? caller) : this() { }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObjekteDictionary.Add("Kreis", k1);
            ObjekteDictionary.Add("Rechteck", r1);
            ObjekteDictionary.Add("Trapez", t1);

            cmbObjekt.Items.Clear();
            cmbObjekt.Items.AddRange(ObjekteDictionary.Keys.ToArray());

        }

        private void calculateObject(object sender, EventArgs e)
        {
            var geo = GeometricObject();
            if (geo != null)
                txtAusgabe.Text = geo.ComputeAndWrite();
        }

        private IComputation? GeometricObject()
        {
            btnCalculate.Enabled = true;

            if (currentObject == null)
            {
                btnCalculate.Enabled = false;
                return null;
            }

            if (currentObject is Circle)
            {
                k1.Radius = (double)numMass1.Value;
                return k1;
            }

            if (currentObject is Trapezoid)
            {
                t1.Width = (double)numMass1.Value;
                t1.UpperWidth = (double)numMass2.Value;
                t1.Height = (double)numMass3.Value;

                if (chkShift1.Checked)
                    t1.RightShift = (double)numShift1.Value;
                else if (chkAngle1.Checked)
                    t1.Angle = (double)numAngle1.Value;
                else
                    t1.MakeSymmetric();
                return t1;
            }

            if (currentObject is Rectangle)
            {
                r1.Height = (double)numMass1.Value;
                r1.Width = (double)numMass2.Value;
                return r1;
            }

            btnCalculate.Enabled = false;
            return null;
        }

        private void prepareSettings(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
            string? key = cmbObjekt?.SelectedItem?.ToString();
            if (key == null) return;

            currentObject = ObjekteDictionary[key];
            HideAllFields();

            if (currentObject is Circle)
            {
                turnOn(lblMass1, numMass1, "Radius");
            }
            else if (currentObject is Trapezoid)
            {
                turnOn(lblMass1, numMass1, "Grundseite");
                turnOn(lblMass2, numMass2, "Oberseite");
                turnOn(lblMass3, numMass3, "Höhe");
                turnOn(chkShift1, numShift1, "Verschiebung Oberseite");
                turnOn(chkAngle1, numAngle1, "Linker Winkel an Grundseite");
            }
            else if (currentObject is Rectangle)
            {
                turnOn(lblMass1, numMass1, "Länge");
                turnOn(lblMass2, numMass2, "Breite");
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void HideAllFields()
        {
            foreach (var nup in this.Controls.OfType<NumericUpDown>())
            {
                nup.Visible = false;
            }
            foreach (var lbl in this.Controls.OfType<Label>())
            {
                lbl.Visible = false;
            }
            foreach (var cbx in this.Controls.OfType<CheckBox>())
            {
                cbx.Visible = false;
            }
            lblCircum.Visible = true;
            lblArea.Visible = true;
        }

        private void allowOnlyOneParam(object sender, EventArgs e)
        {
            if (sender == chkAngle1 && chkAngle1.Checked)
            {
                numAngle1.Enabled = true;
                numShift1.Enabled = false;
                if (chkShift1.Visible) chkShift1.Checked = false;
            }
            else if (sender == chkShift1 && chkShift1.Checked)
            {
                numShift1.Enabled = true;
                numAngle1.Enabled = false;
                if (chkAngle1.Visible) chkAngle1.Checked = false;
            }
        }

        private void allesAufNullSetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var nup in this.Controls.OfType<NumericUpDown>())
            {
                if (nup.Minimum > 0) nup.Value = 90;
                else
                    nup.Value = 0;
            }
        }

        private void turnOn<TLabel, TControl>(TLabel label, TControl field, string what)
            where TControl : Control
            where TLabel : Control
        {
            label.Text = what;
            label.Visible = true;
            field.Visible = true;
        }

    }
}