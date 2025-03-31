using System;
using System.Windows.Forms;

namespace BodyStatsCalculator
{
    public partial class MainForm : Form
    {
        private ComboBox cmb_unit;
        private Label lbl_units;
        private Label lbl_gender;
        private Button btn_calc;
        private TextBox txt_age;
        private TextBox txt_ft_height;
        private Label lbl_age;
        private Label lbl_height;
        private RadioButton rad_male;
        private RadioButton rad_female;
        private Label lbl_ft;
        private TextBox txt_in_height;
        private Label lbl_in;
        private Label txt_age_suffix;
        private Label lbl_title;
        private Label lbl_res_title;
        private Label lbl_weight;
        private TextBox txt_lbs_weight;
        private Label lbl_lbs;
        private TextBox txt_cm_height;
        private Label lbl_cm;
        private TextBox txt_kg_weight;
        private Label lbl_kg;

        // Init global variables
        private string selected_gender = "Male";
        private Label lbl_results;
        private int selected_age = 0;

        public MainForm()
        {
            InitializeComponent();

            // Init default selections
            cmb_unit.SelectedIndex = 1;
            rad_male.Checked = true;
        }

        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.cmb_unit = new System.Windows.Forms.ComboBox();
            this.lbl_units = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_ft_height = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.lbl_ft = new System.Windows.Forms.Label();
            this.txt_in_height = new System.Windows.Forms.TextBox();
            this.lbl_in = new System.Windows.Forms.Label();
            this.txt_age_suffix = new System.Windows.Forms.Label();
            this.lbl_res_title = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txt_lbs_weight = new System.Windows.Forms.TextBox();
            this.lbl_lbs = new System.Windows.Forms.Label();
            this.txt_cm_height = new System.Windows.Forms.TextBox();
            this.lbl_cm = new System.Windows.Forms.Label();
            this.txt_kg_weight = new System.Windows.Forms.TextBox();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.lbl_results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(386, 25);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Health and Body Information Calculator";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_unit
            // 
            this.cmb_unit.FormattingEnabled = true;
            this.cmb_unit.Items.AddRange(new object[] {
            "Imperial",
            "Metric"});
            this.cmb_unit.Location = new System.Drawing.Point(224, 168);
            this.cmb_unit.MaxDropDownItems = 2;
            this.cmb_unit.Name = "cmb_unit";
            this.cmb_unit.Size = new System.Drawing.Size(138, 21);
            this.cmb_unit.TabIndex = 2;
            this.cmb_unit.SelectedIndexChanged += new System.EventHandler(this.Unit_SelectedIndexChanged);
            // 
            // lbl_units
            // 
            this.lbl_units.AutoSize = true;
            this.lbl_units.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_units.Location = new System.Drawing.Point(219, 140);
            this.lbl_units.Name = "lbl_units";
            this.lbl_units.Size = new System.Drawing.Size(61, 25);
            this.lbl_units.TabIndex = 4;
            this.lbl_units.Text = "Units";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(219, 51);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(83, 25);
            this.lbl_gender.TabIndex = 5;
            this.lbl_gender.Text = "Gender";
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(137, 266);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(121, 32);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // txt_age
            // 
            this.txt_age.AccessibleName = "Age Input";
            this.txt_age.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txt_age.Location = new System.Drawing.Point(17, 79);
            this.txt_age.MaxLength = 3;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(55, 20);
            this.txt_age.TabIndex = 7;
            this.txt_age.WordWrap = false;
            // 
            // txt_ft_height
            // 
            this.txt_ft_height.Location = new System.Drawing.Point(18, 168);
            this.txt_ft_height.Name = "txt_ft_height";
            this.txt_ft_height.Size = new System.Drawing.Size(50, 20);
            this.txt_ft_height.TabIndex = 8;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(17, 48);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(50, 25);
            this.lbl_age.TabIndex = 9;
            this.lbl_age.Text = "Age";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(17, 140);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(74, 25);
            this.lbl_height.TabIndex = 10;
            this.lbl_height.Text = "Height";
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad_male.Location = new System.Drawing.Point(224, 81);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(48, 17);
            this.rad_male.TabIndex = 12;
            this.rad_male.TabStop = true;
            this.rad_male.Tag = "Male";
            this.rad_male.Text = "Male";
            this.rad_male.UseVisualStyleBackColor = true;
            this.rad_male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad_female.Location = new System.Drawing.Point(224, 104);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(59, 17);
            this.rad_female.TabIndex = 13;
            this.rad_female.TabStop = true;
            this.rad_female.Tag = "Female";
            this.rad_female.Text = "Female";
            this.rad_female.UseVisualStyleBackColor = true;
            this.rad_female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // lbl_ft
            // 
            this.lbl_ft.AutoSize = true;
            this.lbl_ft.Location = new System.Drawing.Point(70, 171);
            this.lbl_ft.Name = "lbl_ft";
            this.lbl_ft.Size = new System.Drawing.Size(13, 13);
            this.lbl_ft.TabIndex = 14;
            this.lbl_ft.Text = "ft";
            // 
            // txt_in_height
            // 
            this.txt_in_height.Location = new System.Drawing.Point(89, 169);
            this.txt_in_height.Name = "txt_in_height";
            this.txt_in_height.Size = new System.Drawing.Size(50, 20);
            this.txt_in_height.TabIndex = 15;
            // 
            // lbl_in
            // 
            this.lbl_in.AutoSize = true;
            this.lbl_in.Location = new System.Drawing.Point(145, 172);
            this.lbl_in.Name = "lbl_in";
            this.lbl_in.Size = new System.Drawing.Size(15, 13);
            this.lbl_in.TabIndex = 16;
            this.lbl_in.Text = "in";
            // 
            // txt_age_suffix
            // 
            this.txt_age_suffix.AutoSize = true;
            this.txt_age_suffix.Location = new System.Drawing.Point(78, 83);
            this.txt_age_suffix.Name = "txt_age_suffix";
            this.txt_age_suffix.Size = new System.Drawing.Size(53, 13);
            this.txt_age_suffix.TabIndex = 17;
            this.txt_age_suffix.Text = "Years Old";
            // 
            // lbl_res_title
            // 
            this.lbl_res_title.AutoSize = true;
            this.lbl_res_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_res_title.Location = new System.Drawing.Point(12, 321);
            this.lbl_res_title.Name = "lbl_res_title";
            this.lbl_res_title.Size = new System.Drawing.Size(187, 25);
            this.lbl_res_title.TabIndex = 18;
            this.lbl_res_title.Text = "Results Window:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.Location = new System.Drawing.Point(17, 207);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(79, 25);
            this.lbl_weight.TabIndex = 19;
            this.lbl_weight.Text = "Weight";
            // 
            // txt_lbs_weight
            // 
            this.txt_lbs_weight.Location = new System.Drawing.Point(17, 235);
            this.txt_lbs_weight.Name = "txt_lbs_weight";
            this.txt_lbs_weight.Size = new System.Drawing.Size(50, 20);
            this.txt_lbs_weight.TabIndex = 20;
            // 
            // lbl_lbs
            // 
            this.lbl_lbs.AutoSize = true;
            this.lbl_lbs.Location = new System.Drawing.Point(70, 238);
            this.lbl_lbs.Name = "lbl_lbs";
            this.lbl_lbs.Size = new System.Drawing.Size(20, 13);
            this.lbl_lbs.TabIndex = 21;
            this.lbl_lbs.Text = "lbs";
            // 
            // txt_cm_height
            // 
            this.txt_cm_height.Location = new System.Drawing.Point(17, 169);
            this.txt_cm_height.Name = "txt_cm_height";
            this.txt_cm_height.Size = new System.Drawing.Size(122, 20);
            this.txt_cm_height.TabIndex = 22;
            // 
            // lbl_cm
            // 
            this.lbl_cm.AutoSize = true;
            this.lbl_cm.Location = new System.Drawing.Point(145, 172);
            this.lbl_cm.Name = "lbl_cm";
            this.lbl_cm.Size = new System.Drawing.Size(21, 13);
            this.lbl_cm.TabIndex = 23;
            this.lbl_cm.Text = "cm";
            // 
            // txt_kg_weight
            // 
            this.txt_kg_weight.Location = new System.Drawing.Point(17, 235);
            this.txt_kg_weight.Name = "txt_kg_weight";
            this.txt_kg_weight.Size = new System.Drawing.Size(50, 20);
            this.txt_kg_weight.TabIndex = 24;
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Location = new System.Drawing.Point(70, 238);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(19, 13);
            this.lbl_kg.TabIndex = 25;
            this.lbl_kg.Text = "kg";
            // 
            // lbl_results
            // 
            this.lbl_results.AutoSize = true;
            this.lbl_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_results.Location = new System.Drawing.Point(13, 359);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Size = new System.Drawing.Size(35, 20);
            this.lbl_results.TabIndex = 26;
            this.lbl_results.Text = "N/A";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(410, 500);
            this.Controls.Add(this.lbl_results);
            this.Controls.Add(this.lbl_kg);
            this.Controls.Add(this.txt_kg_weight);
            this.Controls.Add(this.lbl_cm);
            this.Controls.Add(this.txt_cm_height);
            this.Controls.Add(this.lbl_lbs);
            this.Controls.Add(this.txt_lbs_weight);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_res_title);
            this.Controls.Add(this.txt_age_suffix);
            this.Controls.Add(this.lbl_in);
            this.Controls.Add(this.txt_in_height);
            this.Controls.Add(this.lbl_ft);
            this.Controls.Add(this.rad_female);
            this.Controls.Add(this.rad_male);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.txt_ft_height);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_units);
            this.Controls.Add(this.cmb_unit);
            this.Controls.Add(this.lbl_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Event Handlers

        private void Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_unit = cmb_unit.SelectedItem?.ToString();

            if (selected_unit == "Metric")
            {
                lbl_cm.Visible = true;
                txt_cm_height.Visible = true;
                lbl_kg.Visible = true;
                txt_kg_weight.Visible = true;

                txt_ft_height.Visible = false;
                txt_in_height.Visible = false;
                lbl_ft.Visible = false;
                lbl_in.Visible = false;
                txt_lbs_weight.Visible = false;
                lbl_lbs.Visible = false;
            }
            else if (selected_unit == "Imperial")
            {
                lbl_cm.Visible = false;
                txt_cm_height.Visible = false;
                lbl_kg.Visible = false;
                txt_kg_weight.Visible = false;

                txt_ft_height.Visible = true;
                txt_in_height.Visible = true;
                lbl_ft.Visible = true;
                lbl_in.Visible = true;
                txt_lbs_weight.Visible = true;
                lbl_lbs.Visible = true;
            }
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            rad_female.Checked = false;
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        { 
            rad_male.Checked = false;
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (!rad_female.Checked && !rad_male.Checked)
            {
                MessageBox.Show("Gender not selected. Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selected_age;
            if (!int.TryParse(txt_age.Text, out selected_age) || selected_age <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double height_cm = GetHeightInCm();
            double weight_kg = GetWeightInKg();

            if (height_cm <= 0 || weight_kg <= 0)
            {
                MessageBox.Show("Please ensure valid age, height, and weight are entered.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = BodyCalcHelper.CalculateBodyStats(weight_kg, height_cm, selected_age, selected_gender);

            lbl_results.Text = result;
        }




        private double GetHeightInCm()
        {
            string selected_unit = cmb_unit.SelectedItem?.ToString();

            if (selected_unit == "Metric")
            {
                if (double.TryParse(txt_cm_height.Text, out double height_cm))
                {
                    return height_cm;
                }
                else
                {
                    MessageBox.Show("Please enter a valid height in cm.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0.0;
                }
            }
            else if (selected_unit == "Imperial")
            {
                bool ft_parsed = double.TryParse(txt_ft_height.Text, out double feet);
                bool in_parsed = double.TryParse(txt_in_height.Text, out double inches);

                if (!ft_parsed)
                {
                    feet = 0;
                }

                if (!in_parsed)
                {
                    inches = 0;
                }

                double total_inches = (feet * 12) + inches;
                double height_cm = total_inches * 2.54;

                return height_cm;
            }

            return 0.0;
        }

        private double GetWeightInKg()
        {
            string selected_unit = cmb_unit.SelectedItem?.ToString();

            if (selected_unit == "Metric")
            {
                if (double.TryParse(txt_kg_weight.Text, out double weight_kg))
                {
                    return weight_kg;
                }
                else
                {
                    MessageBox.Show("Please enter a valid weight in kg.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0.0;
                }

            }
            else if (selected_unit == "Imperial")
            {
                if (double.TryParse(txt_lbs_weight.Text, out double weight_lbs))
                {
                    return weight_lbs * 0.453592;
                }
                else
                {
                    MessageBox.Show("Please enter a valid weight in lbs.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0.0;
                }
            }

                return 0.0;
        }
    }
}
