namespace C3CodeProject1
{
    partial class sitrepform
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
            this.previewbox_generate = new System.Windows.Forms.RichTextBox();
            this.grp_reportingtools = new System.Windows.Forms.GroupBox();
            this.lbl_preview = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_headergenerate = new System.Windows.Forms.Button();
            this.lbl_weather = new System.Windows.Forms.Label();
            this.btn_genweather = new System.Windows.Forms.Button();
            this.txt_weather = new System.Windows.Forms.TextBox();
            this.btn_pagasa = new System.Windows.Forms.Button();
            this.radio_yes = new System.Windows.Forms.RadioButton();
            this.lbl_anyincident = new System.Windows.Forms.Label();
            this.radio_no = new System.Windows.Forms.RadioButton();
            this.grp_incidentreports = new System.Windows.Forms.GroupBox();
            this.lbl_what = new System.Windows.Forms.Label();
            this.txt_what = new System.Windows.Forms.TextBox();
            this.lbl_when = new System.Windows.Forms.Label();
            this.txt_when = new System.Windows.Forms.TextBox();
            this.lbl_where = new System.Windows.Forms.Label();
            this.txt_where = new System.Windows.Forms.TextBox();
            this.lbl_natureofillness = new System.Windows.Forms.Label();
            this.txt_natureofillness = new System.Windows.Forms.TextBox();
            this.lbl_cause = new System.Windows.Forms.Label();
            this.txt_cause = new System.Windows.Forms.TextBox();
            this.lbl_numofinjured = new System.Windows.Forms.Label();
            this.txt_numofinjured = new System.Windows.Forms.TextBox();
            this.lbl_responders = new System.Windows.Forms.Label();
            this.check_mdrrmomedic = new System.Windows.Forms.CheckBox();
            this.check_mdrrmovolunteer = new System.Windows.Forms.CheckBox();
            this.check_bfp = new System.Windows.Forms.CheckBox();
            this.check_pnp = new System.Windows.Forms.CheckBox();
            this.lbl_actions = new System.Windows.Forms.Label();
            this.txt_actions = new System.Windows.Forms.TextBox();
            this.btn_addincident = new System.Windows.Forms.Button();
            this.btn_addno = new System.Windows.Forms.Button();
            this.grp_lifelines = new System.Windows.Forms.GroupBox();
            this.btn_lifeadd = new System.Windows.Forms.Button();
            this.txt_power = new System.Windows.Forms.TextBox();
            this.lbl_power = new System.Windows.Forms.Label();
            this.check_power = new System.Windows.Forms.CheckBox();
            this.check_water = new System.Windows.Forms.CheckBox();
            this.txt_water = new System.Windows.Forms.TextBox();
            this.lbl_water = new System.Windows.Forms.Label();
            this.check_comms = new System.Windows.Forms.CheckBox();
            this.txt_comms = new System.Windows.Forms.TextBox();
            this.lbl_comms = new System.Windows.Forms.Label();
            this.check_roadconditions = new System.Windows.Forms.CheckBox();
            this.txt_roadcondition = new System.Windows.Forms.TextBox();
            this.lbl_roadcondition = new System.Windows.Forms.Label();
            this.check_seatravel = new System.Windows.Forms.CheckBox();
            this.txt_seatravel = new System.Windows.Forms.TextBox();
            this.lbl_seatravel = new System.Windows.Forms.Label();
            this.btn_footergenerate = new System.Windows.Forms.Button();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.btn_portofatimonan = new System.Windows.Forms.Button();
            this.btn_clipboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vehicle = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.grp_reportingtools.SuspendLayout();
            this.grp_incidentreports.SuspendLayout();
            this.grp_lifelines.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewbox_generate
            // 
            this.previewbox_generate.Location = new System.Drawing.Point(733, 50);
            this.previewbox_generate.Name = "previewbox_generate";
            this.previewbox_generate.Size = new System.Drawing.Size(916, 761);
            this.previewbox_generate.TabIndex = 0;
            this.previewbox_generate.Text = "";
            // 
            // grp_reportingtools
            // 
            this.grp_reportingtools.Controls.Add(this.btn_footergenerate);
            this.grp_reportingtools.Controls.Add(this.lbl_footer);
            this.grp_reportingtools.Controls.Add(this.grp_lifelines);
            this.grp_reportingtools.Controls.Add(this.btn_addno);
            this.grp_reportingtools.Controls.Add(this.grp_incidentreports);
            this.grp_reportingtools.Controls.Add(this.radio_no);
            this.grp_reportingtools.Controls.Add(this.lbl_anyincident);
            this.grp_reportingtools.Controls.Add(this.radio_yes);
            this.grp_reportingtools.Controls.Add(this.btn_pagasa);
            this.grp_reportingtools.Controls.Add(this.txt_weather);
            this.grp_reportingtools.Controls.Add(this.btn_genweather);
            this.grp_reportingtools.Controls.Add(this.lbl_weather);
            this.grp_reportingtools.Controls.Add(this.btn_headergenerate);
            this.grp_reportingtools.Controls.Add(this.lbl_header);
            this.grp_reportingtools.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_reportingtools.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_reportingtools.Location = new System.Drawing.Point(12, 3);
            this.grp_reportingtools.Name = "grp_reportingtools";
            this.grp_reportingtools.Size = new System.Drawing.Size(680, 884);
            this.grp_reportingtools.TabIndex = 1;
            this.grp_reportingtools.TabStop = false;
            this.grp_reportingtools.Text = "Sit Rep Tools";
            // 
            // lbl_preview
            // 
            this.lbl_preview.AutoSize = true;
            this.lbl_preview.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_preview.Location = new System.Drawing.Point(733, 31);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(49, 13);
            this.lbl_preview.TabIndex = 2;
            this.lbl_preview.Text = "Preview:";
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(31, 41);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(106, 13);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "1. Generate Header";
            // 
            // btn_headergenerate
            // 
            this.btn_headergenerate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_headergenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_headergenerate.Location = new System.Drawing.Point(143, 36);
            this.btn_headergenerate.Name = "btn_headergenerate";
            this.btn_headergenerate.Size = new System.Drawing.Size(88, 23);
            this.btn_headergenerate.TabIndex = 1;
            this.btn_headergenerate.Text = "Generate";
            this.btn_headergenerate.UseVisualStyleBackColor = true;
            this.btn_headergenerate.Click += new System.EventHandler(this.btn_headergenerate_Click);
            // 
            // lbl_weather
            // 
            this.lbl_weather.AutoSize = true;
            this.lbl_weather.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weather.Location = new System.Drawing.Point(31, 82);
            this.lbl_weather.Name = "lbl_weather";
            this.lbl_weather.Size = new System.Drawing.Size(118, 13);
            this.lbl_weather.TabIndex = 2;
            this.lbl_weather.Text = "2. Weather Condition";
            // 
            // btn_genweather
            // 
            this.btn_genweather.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genweather.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_genweather.Location = new System.Drawing.Point(314, 107);
            this.btn_genweather.Name = "btn_genweather";
            this.btn_genweather.Size = new System.Drawing.Size(88, 23);
            this.btn_genweather.TabIndex = 3;
            this.btn_genweather.Text = "Add to sitrep";
            this.btn_genweather.UseVisualStyleBackColor = true;
            this.btn_genweather.Click += new System.EventHandler(this.btn_genweather_Click);
            // 
            // txt_weather
            // 
            this.txt_weather.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weather.Location = new System.Drawing.Point(155, 79);
            this.txt_weather.Name = "txt_weather";
            this.txt_weather.Size = new System.Drawing.Size(247, 22);
            this.txt_weather.TabIndex = 4;
            // 
            // btn_pagasa
            // 
            this.btn_pagasa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pagasa.Location = new System.Drawing.Point(408, 79);
            this.btn_pagasa.Name = "btn_pagasa";
            this.btn_pagasa.Size = new System.Drawing.Size(88, 23);
            this.btn_pagasa.TabIndex = 5;
            this.btn_pagasa.Text = "Go to PAGASA";
            this.btn_pagasa.UseVisualStyleBackColor = true;
            this.btn_pagasa.Click += new System.EventHandler(this.btn_pagasa_Click);
            // 
            // radio_yes
            // 
            this.radio_yes.AutoSize = true;
            this.radio_yes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_yes.Location = new System.Drawing.Point(155, 151);
            this.radio_yes.Name = "radio_yes";
            this.radio_yes.Size = new System.Drawing.Size(40, 17);
            this.radio_yes.TabIndex = 6;
            this.radio_yes.Text = "Yes";
            this.radio_yes.UseVisualStyleBackColor = true;
            this.radio_yes.CheckedChanged += new System.EventHandler(this.radio_yes_CheckedChanged);
            // 
            // lbl_anyincident
            // 
            this.lbl_anyincident.AutoSize = true;
            this.lbl_anyincident.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anyincident.Location = new System.Drawing.Point(31, 135);
            this.lbl_anyincident.Name = "lbl_anyincident";
            this.lbl_anyincident.Size = new System.Drawing.Size(137, 13);
            this.lbl_anyincident.TabIndex = 7;
            this.lbl_anyincident.Text = "3. Are there any incident?";
            // 
            // radio_no
            // 
            this.radio_no.AutoSize = true;
            this.radio_no.Checked = true;
            this.radio_no.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_no.Location = new System.Drawing.Point(155, 174);
            this.radio_no.Name = "radio_no";
            this.radio_no.Size = new System.Drawing.Size(40, 17);
            this.radio_no.TabIndex = 8;
            this.radio_no.TabStop = true;
            this.radio_no.Text = "No";
            this.radio_no.UseVisualStyleBackColor = true;
            this.radio_no.CheckedChanged += new System.EventHandler(this.radio_no_CheckedChanged);
            // 
            // grp_incidentreports
            // 
            this.grp_incidentreports.Controls.Add(this.txt_vehicle);
            this.grp_incidentreports.Controls.Add(this.label1);
            this.grp_incidentreports.Controls.Add(this.btn_addincident);
            this.grp_incidentreports.Controls.Add(this.txt_actions);
            this.grp_incidentreports.Controls.Add(this.lbl_actions);
            this.grp_incidentreports.Controls.Add(this.check_pnp);
            this.grp_incidentreports.Controls.Add(this.check_bfp);
            this.grp_incidentreports.Controls.Add(this.check_mdrrmovolunteer);
            this.grp_incidentreports.Controls.Add(this.check_mdrrmomedic);
            this.grp_incidentreports.Controls.Add(this.lbl_responders);
            this.grp_incidentreports.Controls.Add(this.txt_numofinjured);
            this.grp_incidentreports.Controls.Add(this.lbl_numofinjured);
            this.grp_incidentreports.Controls.Add(this.txt_cause);
            this.grp_incidentreports.Controls.Add(this.lbl_cause);
            this.grp_incidentreports.Controls.Add(this.txt_natureofillness);
            this.grp_incidentreports.Controls.Add(this.lbl_natureofillness);
            this.grp_incidentreports.Controls.Add(this.txt_where);
            this.grp_incidentreports.Controls.Add(this.lbl_where);
            this.grp_incidentreports.Controls.Add(this.txt_when);
            this.grp_incidentreports.Controls.Add(this.lbl_when);
            this.grp_incidentreports.Controls.Add(this.txt_what);
            this.grp_incidentreports.Controls.Add(this.lbl_what);
            this.grp_incidentreports.Enabled = false;
            this.grp_incidentreports.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_incidentreports.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_incidentreports.Location = new System.Drawing.Point(6, 203);
            this.grp_incidentreports.Name = "grp_incidentreports";
            this.grp_incidentreports.Size = new System.Drawing.Size(668, 324);
            this.grp_incidentreports.TabIndex = 9;
            this.grp_incidentreports.TabStop = false;
            this.grp_incidentreports.Text = "Incident Reports";
            // 
            // lbl_what
            // 
            this.lbl_what.AutoSize = true;
            this.lbl_what.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_what.Location = new System.Drawing.Point(37, 31);
            this.lbl_what.Name = "lbl_what";
            this.lbl_what.Size = new System.Drawing.Size(38, 13);
            this.lbl_what.TabIndex = 8;
            this.lbl_what.Text = "What:";
            // 
            // txt_what
            // 
            this.txt_what.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_what.Location = new System.Drawing.Point(40, 47);
            this.txt_what.Name = "txt_what";
            this.txt_what.Size = new System.Drawing.Size(247, 22);
            this.txt_what.TabIndex = 10;
            // 
            // lbl_when
            // 
            this.lbl_when.AutoSize = true;
            this.lbl_when.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_when.Location = new System.Drawing.Point(37, 72);
            this.lbl_when.Name = "lbl_when";
            this.lbl_when.Size = new System.Drawing.Size(41, 13);
            this.lbl_when.TabIndex = 11;
            this.lbl_when.Text = "When:";
            // 
            // txt_when
            // 
            this.txt_when.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_when.Location = new System.Drawing.Point(40, 88);
            this.txt_when.Name = "txt_when";
            this.txt_when.Size = new System.Drawing.Size(247, 22);
            this.txt_when.TabIndex = 12;
            // 
            // lbl_where
            // 
            this.lbl_where.AutoSize = true;
            this.lbl_where.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_where.Location = new System.Drawing.Point(37, 113);
            this.lbl_where.Name = "lbl_where";
            this.lbl_where.Size = new System.Drawing.Size(44, 13);
            this.lbl_where.TabIndex = 13;
            this.lbl_where.Text = "Where:";
            // 
            // txt_where
            // 
            this.txt_where.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_where.Location = new System.Drawing.Point(40, 129);
            this.txt_where.Name = "txt_where";
            this.txt_where.Size = new System.Drawing.Size(247, 22);
            this.txt_where.TabIndex = 14;
            // 
            // lbl_natureofillness
            // 
            this.lbl_natureofillness.AutoSize = true;
            this.lbl_natureofillness.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_natureofillness.Location = new System.Drawing.Point(37, 154);
            this.lbl_natureofillness.Name = "lbl_natureofillness";
            this.lbl_natureofillness.Size = new System.Drawing.Size(94, 13);
            this.lbl_natureofillness.TabIndex = 15;
            this.lbl_natureofillness.Text = "Nature of Illness:";
            // 
            // txt_natureofillness
            // 
            this.txt_natureofillness.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_natureofillness.Location = new System.Drawing.Point(40, 170);
            this.txt_natureofillness.Name = "txt_natureofillness";
            this.txt_natureofillness.Size = new System.Drawing.Size(247, 22);
            this.txt_natureofillness.TabIndex = 16;
            // 
            // lbl_cause
            // 
            this.lbl_cause.AutoSize = true;
            this.lbl_cause.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cause.Location = new System.Drawing.Point(37, 195);
            this.lbl_cause.Name = "lbl_cause";
            this.lbl_cause.Size = new System.Drawing.Size(96, 13);
            this.lbl_cause.TabIndex = 17;
            this.lbl_cause.Text = "Cause/s of injury:";
            // 
            // txt_cause
            // 
            this.txt_cause.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cause.Location = new System.Drawing.Point(40, 211);
            this.txt_cause.Name = "txt_cause";
            this.txt_cause.Size = new System.Drawing.Size(247, 22);
            this.txt_cause.TabIndex = 18;
            // 
            // lbl_numofinjured
            // 
            this.lbl_numofinjured.AutoSize = true;
            this.lbl_numofinjured.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numofinjured.Location = new System.Drawing.Point(37, 276);
            this.lbl_numofinjured.Name = "lbl_numofinjured";
            this.lbl_numofinjured.Size = new System.Drawing.Size(105, 13);
            this.lbl_numofinjured.TabIndex = 19;
            this.lbl_numofinjured.Text = "Number of injured:";
            // 
            // txt_numofinjured
            // 
            this.txt_numofinjured.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numofinjured.Location = new System.Drawing.Point(40, 292);
            this.txt_numofinjured.Name = "txt_numofinjured";
            this.txt_numofinjured.Size = new System.Drawing.Size(247, 22);
            this.txt_numofinjured.TabIndex = 20;
            // 
            // lbl_responders
            // 
            this.lbl_responders.AutoSize = true;
            this.lbl_responders.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_responders.Location = new System.Drawing.Point(376, 31);
            this.lbl_responders.Name = "lbl_responders";
            this.lbl_responders.Size = new System.Drawing.Size(71, 13);
            this.lbl_responders.TabIndex = 21;
            this.lbl_responders.Text = "Responders:";
            // 
            // check_mdrrmomedic
            // 
            this.check_mdrrmomedic.AutoSize = true;
            this.check_mdrrmomedic.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_mdrrmomedic.Location = new System.Drawing.Point(437, 49);
            this.check_mdrrmomedic.Name = "check_mdrrmomedic";
            this.check_mdrrmomedic.Size = new System.Drawing.Size(111, 17);
            this.check_mdrrmomedic.TabIndex = 22;
            this.check_mdrrmomedic.Text = "MDRRMO Medic";
            this.check_mdrrmomedic.UseVisualStyleBackColor = true;
            // 
            // check_mdrrmovolunteer
            // 
            this.check_mdrrmovolunteer.AutoSize = true;
            this.check_mdrrmovolunteer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_mdrrmovolunteer.Location = new System.Drawing.Point(437, 72);
            this.check_mdrrmovolunteer.Name = "check_mdrrmovolunteer";
            this.check_mdrrmovolunteer.Size = new System.Drawing.Size(135, 17);
            this.check_mdrrmovolunteer.TabIndex = 23;
            this.check_mdrrmovolunteer.Text = "MDRRMO Volunteers";
            this.check_mdrrmovolunteer.UseVisualStyleBackColor = true;
            // 
            // check_bfp
            // 
            this.check_bfp.AutoSize = true;
            this.check_bfp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_bfp.Location = new System.Drawing.Point(437, 95);
            this.check_bfp.Name = "check_bfp";
            this.check_bfp.Size = new System.Drawing.Size(44, 17);
            this.check_bfp.TabIndex = 24;
            this.check_bfp.Text = "BFP";
            this.check_bfp.UseVisualStyleBackColor = true;
            // 
            // check_pnp
            // 
            this.check_pnp.AutoSize = true;
            this.check_pnp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_pnp.Location = new System.Drawing.Point(437, 118);
            this.check_pnp.Name = "check_pnp";
            this.check_pnp.Size = new System.Drawing.Size(46, 17);
            this.check_pnp.TabIndex = 25;
            this.check_pnp.Text = "PNP";
            this.check_pnp.UseVisualStyleBackColor = true;
            // 
            // lbl_actions
            // 
            this.lbl_actions.AutoSize = true;
            this.lbl_actions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actions.Location = new System.Drawing.Point(376, 138);
            this.lbl_actions.Name = "lbl_actions";
            this.lbl_actions.Size = new System.Drawing.Size(80, 13);
            this.lbl_actions.TabIndex = 26;
            this.lbl_actions.Text = "Actions taken:";
            // 
            // txt_actions
            // 
            this.txt_actions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_actions.Location = new System.Drawing.Point(379, 154);
            this.txt_actions.Multiline = true;
            this.txt_actions.Name = "txt_actions";
            this.txt_actions.Size = new System.Drawing.Size(247, 79);
            this.txt_actions.TabIndex = 27;
            // 
            // btn_addincident
            // 
            this.btn_addincident.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addincident.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addincident.Location = new System.Drawing.Point(538, 252);
            this.btn_addincident.Name = "btn_addincident";
            this.btn_addincident.Size = new System.Drawing.Size(88, 23);
            this.btn_addincident.TabIndex = 28;
            this.btn_addincident.Text = "Add to sitrep";
            this.btn_addincident.UseVisualStyleBackColor = true;
            this.btn_addincident.Click += new System.EventHandler(this.btn_addincident_Click);
            // 
            // btn_addno
            // 
            this.btn_addno.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addno.Location = new System.Drawing.Point(201, 174);
            this.btn_addno.Name = "btn_addno";
            this.btn_addno.Size = new System.Drawing.Size(88, 23);
            this.btn_addno.TabIndex = 10;
            this.btn_addno.Text = "Add to sitrep";
            this.btn_addno.UseVisualStyleBackColor = true;
            this.btn_addno.Click += new System.EventHandler(this.btn_addno_Click);
            // 
            // grp_lifelines
            // 
            this.grp_lifelines.Controls.Add(this.btn_portofatimonan);
            this.grp_lifelines.Controls.Add(this.check_seatravel);
            this.grp_lifelines.Controls.Add(this.txt_seatravel);
            this.grp_lifelines.Controls.Add(this.lbl_seatravel);
            this.grp_lifelines.Controls.Add(this.check_roadconditions);
            this.grp_lifelines.Controls.Add(this.txt_roadcondition);
            this.grp_lifelines.Controls.Add(this.lbl_roadcondition);
            this.grp_lifelines.Controls.Add(this.check_comms);
            this.grp_lifelines.Controls.Add(this.txt_comms);
            this.grp_lifelines.Controls.Add(this.lbl_comms);
            this.grp_lifelines.Controls.Add(this.check_water);
            this.grp_lifelines.Controls.Add(this.txt_water);
            this.grp_lifelines.Controls.Add(this.lbl_water);
            this.grp_lifelines.Controls.Add(this.check_power);
            this.grp_lifelines.Controls.Add(this.btn_lifeadd);
            this.grp_lifelines.Controls.Add(this.txt_power);
            this.grp_lifelines.Controls.Add(this.lbl_power);
            this.grp_lifelines.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_lifelines.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_lifelines.Location = new System.Drawing.Point(6, 533);
            this.grp_lifelines.Name = "grp_lifelines";
            this.grp_lifelines.Size = new System.Drawing.Size(668, 308);
            this.grp_lifelines.TabIndex = 11;
            this.grp_lifelines.TabStop = false;
            this.grp_lifelines.Text = "Lifelines";
            // 
            // btn_lifeadd
            // 
            this.btn_lifeadd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lifeadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_lifeadd.Location = new System.Drawing.Point(538, 278);
            this.btn_lifeadd.Name = "btn_lifeadd";
            this.btn_lifeadd.Size = new System.Drawing.Size(88, 23);
            this.btn_lifeadd.TabIndex = 28;
            this.btn_lifeadd.Text = "Add to sitrep";
            this.btn_lifeadd.UseVisualStyleBackColor = true;
            this.btn_lifeadd.Click += new System.EventHandler(this.btn_lifeadd_Click);
            // 
            // txt_power
            // 
            this.txt_power.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_power.Location = new System.Drawing.Point(40, 47);
            this.txt_power.Name = "txt_power";
            this.txt_power.Size = new System.Drawing.Size(247, 22);
            this.txt_power.TabIndex = 10;
            // 
            // lbl_power
            // 
            this.lbl_power.AutoSize = true;
            this.lbl_power.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_power.Location = new System.Drawing.Point(37, 31);
            this.lbl_power.Name = "lbl_power";
            this.lbl_power.Size = new System.Drawing.Size(42, 13);
            this.lbl_power.TabIndex = 8;
            this.lbl_power.Text = "Power:";
            // 
            // check_power
            // 
            this.check_power.AutoSize = true;
            this.check_power.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_power.Location = new System.Drawing.Point(293, 49);
            this.check_power.Name = "check_power";
            this.check_power.Size = new System.Drawing.Size(112, 17);
            this.check_power.TabIndex = 29;
            this.check_power.Text = "No Interruptions";
            this.check_power.UseVisualStyleBackColor = true;
            this.check_power.CheckedChanged += new System.EventHandler(this.check_power_CheckedChanged);
            // 
            // check_water
            // 
            this.check_water.AutoSize = true;
            this.check_water.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_water.Location = new System.Drawing.Point(295, 90);
            this.check_water.Name = "check_water";
            this.check_water.Size = new System.Drawing.Size(112, 17);
            this.check_water.TabIndex = 32;
            this.check_water.Text = "No Interruptions";
            this.check_water.UseVisualStyleBackColor = true;
            this.check_water.CheckedChanged += new System.EventHandler(this.check_water_CheckedChanged);
            // 
            // txt_water
            // 
            this.txt_water.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_water.Location = new System.Drawing.Point(42, 88);
            this.txt_water.Name = "txt_water";
            this.txt_water.Size = new System.Drawing.Size(247, 22);
            this.txt_water.TabIndex = 31;
            // 
            // lbl_water
            // 
            this.lbl_water.AutoSize = true;
            this.lbl_water.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_water.Location = new System.Drawing.Point(39, 72);
            this.lbl_water.Name = "lbl_water";
            this.lbl_water.Size = new System.Drawing.Size(41, 13);
            this.lbl_water.TabIndex = 30;
            this.lbl_water.Text = "Water:";
            // 
            // check_comms
            // 
            this.check_comms.AutoSize = true;
            this.check_comms.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_comms.Location = new System.Drawing.Point(295, 131);
            this.check_comms.Name = "check_comms";
            this.check_comms.Size = new System.Drawing.Size(112, 17);
            this.check_comms.TabIndex = 35;
            this.check_comms.Text = "No Interruptions";
            this.check_comms.UseVisualStyleBackColor = true;
            this.check_comms.CheckedChanged += new System.EventHandler(this.check_comms_CheckedChanged);
            // 
            // txt_comms
            // 
            this.txt_comms.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comms.Location = new System.Drawing.Point(42, 129);
            this.txt_comms.Name = "txt_comms";
            this.txt_comms.Size = new System.Drawing.Size(247, 22);
            this.txt_comms.TabIndex = 34;
            // 
            // lbl_comms
            // 
            this.lbl_comms.AutoSize = true;
            this.lbl_comms.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comms.Location = new System.Drawing.Point(39, 113);
            this.lbl_comms.Name = "lbl_comms";
            this.lbl_comms.Size = new System.Drawing.Size(91, 13);
            this.lbl_comms.TabIndex = 33;
            this.lbl_comms.Text = "Communication:";
            // 
            // check_roadconditions
            // 
            this.check_roadconditions.AutoSize = true;
            this.check_roadconditions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_roadconditions.Location = new System.Drawing.Point(295, 172);
            this.check_roadconditions.Name = "check_roadconditions";
            this.check_roadconditions.Size = new System.Drawing.Size(138, 17);
            this.check_roadconditions.TabIndex = 38;
            this.check_roadconditions.Text = "All roads are passable";
            this.check_roadconditions.UseVisualStyleBackColor = true;
            this.check_roadconditions.CheckedChanged += new System.EventHandler(this.check_roadconditions_CheckedChanged);
            // 
            // txt_roadcondition
            // 
            this.txt_roadcondition.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_roadcondition.Location = new System.Drawing.Point(42, 170);
            this.txt_roadcondition.Name = "txt_roadcondition";
            this.txt_roadcondition.Size = new System.Drawing.Size(247, 22);
            this.txt_roadcondition.TabIndex = 37;
            // 
            // lbl_roadcondition
            // 
            this.lbl_roadcondition.AutoSize = true;
            this.lbl_roadcondition.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roadcondition.Location = new System.Drawing.Point(39, 154);
            this.lbl_roadcondition.Name = "lbl_roadcondition";
            this.lbl_roadcondition.Size = new System.Drawing.Size(95, 13);
            this.lbl_roadcondition.TabIndex = 36;
            this.lbl_roadcondition.Text = "Road conditions:";
            // 
            // check_seatravel
            // 
            this.check_seatravel.AutoSize = true;
            this.check_seatravel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_seatravel.Location = new System.Drawing.Point(439, 213);
            this.check_seatravel.Name = "check_seatravel";
            this.check_seatravel.Size = new System.Drawing.Size(92, 17);
            this.check_seatravel.TabIndex = 41;
            this.check_seatravel.Text = "No sea travel";
            this.check_seatravel.UseVisualStyleBackColor = true;
            this.check_seatravel.CheckedChanged += new System.EventHandler(this.check_seatravel_CheckedChanged);
            // 
            // txt_seatravel
            // 
            this.txt_seatravel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seatravel.Location = new System.Drawing.Point(42, 211);
            this.txt_seatravel.Multiline = true;
            this.txt_seatravel.Name = "txt_seatravel";
            this.txt_seatravel.Size = new System.Drawing.Size(391, 90);
            this.txt_seatravel.TabIndex = 40;
            // 
            // lbl_seatravel
            // 
            this.lbl_seatravel.AutoSize = true;
            this.lbl_seatravel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seatravel.Location = new System.Drawing.Point(39, 195);
            this.lbl_seatravel.Name = "lbl_seatravel";
            this.lbl_seatravel.Size = new System.Drawing.Size(59, 13);
            this.lbl_seatravel.TabIndex = 39;
            this.lbl_seatravel.Text = "Sea travel:";
            // 
            // btn_footergenerate
            // 
            this.btn_footergenerate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_footergenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_footergenerate.Location = new System.Drawing.Point(143, 847);
            this.btn_footergenerate.Name = "btn_footergenerate";
            this.btn_footergenerate.Size = new System.Drawing.Size(88, 23);
            this.btn_footergenerate.TabIndex = 13;
            this.btn_footergenerate.Text = "Generate";
            this.btn_footergenerate.UseVisualStyleBackColor = true;
            this.btn_footergenerate.Click += new System.EventHandler(this.btn_footergenerate_Click);
            // 
            // lbl_footer
            // 
            this.lbl_footer.AutoSize = true;
            this.lbl_footer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer.Location = new System.Drawing.Point(31, 852);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(103, 13);
            this.lbl_footer.TabIndex = 12;
            this.lbl_footer.Text = "6. Generate Footer";
            // 
            // btn_portofatimonan
            // 
            this.btn_portofatimonan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_portofatimonan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_portofatimonan.Location = new System.Drawing.Point(537, 225);
            this.btn_portofatimonan.Name = "btn_portofatimonan";
            this.btn_portofatimonan.Size = new System.Drawing.Size(88, 47);
            this.btn_portofatimonan.TabIndex = 42;
            this.btn_portofatimonan.Text = "Go to Port of Atimonan";
            this.btn_portofatimonan.UseVisualStyleBackColor = true;
            this.btn_portofatimonan.Click += new System.EventHandler(this.btn_portofatimonan_Click);
            // 
            // btn_clipboard
            // 
            this.btn_clipboard.Location = new System.Drawing.Point(1449, 817);
            this.btn_clipboard.Name = "btn_clipboard";
            this.btn_clipboard.Size = new System.Drawing.Size(200, 70);
            this.btn_clipboard.TabIndex = 3;
            this.btn_clipboard.Text = "Copy to clipboard";
            this.btn_clipboard.UseVisualStyleBackColor = true;
            this.btn_clipboard.Click += new System.EventHandler(this.btn_clipboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Vehicle/s involved:";
            // 
            // txt_vehicle
            // 
            this.txt_vehicle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicle.Location = new System.Drawing.Point(40, 253);
            this.txt_vehicle.Name = "txt_vehicle";
            this.txt_vehicle.Size = new System.Drawing.Size(247, 22);
            this.txt_vehicle.TabIndex = 30;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(733, 817);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(200, 70);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset Form";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // sitrepform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1671, 899);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_clipboard);
            this.Controls.Add(this.lbl_preview);
            this.Controls.Add(this.grp_reportingtools);
            this.Controls.Add(this.previewbox_generate);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sitrepform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sitrepform";
            this.grp_reportingtools.ResumeLayout(false);
            this.grp_reportingtools.PerformLayout();
            this.grp_incidentreports.ResumeLayout(false);
            this.grp_incidentreports.PerformLayout();
            this.grp_lifelines.ResumeLayout(false);
            this.grp_lifelines.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox previewbox_generate;
        private System.Windows.Forms.GroupBox grp_reportingtools;
        private System.Windows.Forms.Label lbl_preview;
        private System.Windows.Forms.Button btn_headergenerate;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_genweather;
        private System.Windows.Forms.Label lbl_weather;
        private System.Windows.Forms.TextBox txt_weather;
        private System.Windows.Forms.Button btn_pagasa;
        private System.Windows.Forms.GroupBox grp_incidentreports;
        private System.Windows.Forms.TextBox txt_actions;
        private System.Windows.Forms.Label lbl_actions;
        private System.Windows.Forms.CheckBox check_pnp;
        private System.Windows.Forms.CheckBox check_bfp;
        private System.Windows.Forms.CheckBox check_mdrrmovolunteer;
        private System.Windows.Forms.CheckBox check_mdrrmomedic;
        private System.Windows.Forms.Label lbl_responders;
        private System.Windows.Forms.TextBox txt_numofinjured;
        private System.Windows.Forms.Label lbl_numofinjured;
        private System.Windows.Forms.TextBox txt_cause;
        private System.Windows.Forms.Label lbl_cause;
        private System.Windows.Forms.TextBox txt_natureofillness;
        private System.Windows.Forms.Label lbl_natureofillness;
        private System.Windows.Forms.TextBox txt_where;
        private System.Windows.Forms.Label lbl_where;
        private System.Windows.Forms.TextBox txt_when;
        private System.Windows.Forms.Label lbl_when;
        private System.Windows.Forms.TextBox txt_what;
        private System.Windows.Forms.Label lbl_what;
        private System.Windows.Forms.RadioButton radio_no;
        private System.Windows.Forms.Label lbl_anyincident;
        private System.Windows.Forms.RadioButton radio_yes;
        private System.Windows.Forms.Button btn_addincident;
        private System.Windows.Forms.Button btn_addno;
        private System.Windows.Forms.GroupBox grp_lifelines;
        private System.Windows.Forms.CheckBox check_power;
        private System.Windows.Forms.Button btn_lifeadd;
        private System.Windows.Forms.TextBox txt_power;
        private System.Windows.Forms.Label lbl_power;
        private System.Windows.Forms.CheckBox check_seatravel;
        private System.Windows.Forms.TextBox txt_seatravel;
        private System.Windows.Forms.Label lbl_seatravel;
        private System.Windows.Forms.CheckBox check_roadconditions;
        private System.Windows.Forms.TextBox txt_roadcondition;
        private System.Windows.Forms.Label lbl_roadcondition;
        private System.Windows.Forms.CheckBox check_comms;
        private System.Windows.Forms.TextBox txt_comms;
        private System.Windows.Forms.Label lbl_comms;
        private System.Windows.Forms.CheckBox check_water;
        private System.Windows.Forms.TextBox txt_water;
        private System.Windows.Forms.Label lbl_water;
        private System.Windows.Forms.Button btn_footergenerate;
        private System.Windows.Forms.Label lbl_footer;
        private System.Windows.Forms.Button btn_portofatimonan;
        private System.Windows.Forms.Button btn_clipboard;
        private System.Windows.Forms.TextBox txt_vehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
    }
}