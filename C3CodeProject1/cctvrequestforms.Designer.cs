namespace C3CodeProject1
{
    partial class cctvrequestforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cctvrequestforms));
            this.lbl_case = new System.Windows.Forms.Label();
            this.info_caseno = new System.Windows.Forms.Label();
            this.grp_reqinfo = new System.Windows.Forms.GroupBox();
            this.picker_recorded = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.txt_contactno = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_officeorg = new System.Windows.Forms.Label();
            this.txt_officeorg = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.grp_detailsofreport = new System.Windows.Forms.GroupBox();
            this.lbl_camera = new System.Windows.Forms.Label();
            this.drop_camera = new System.Windows.Forms.ComboBox();
            this.radio_notcaptured = new System.Windows.Forms.RadioButton();
            this.radio_captured = new System.Windows.Forms.RadioButton();
            this.lbl_outcome = new System.Windows.Forms.Label();
            this.check_screenshot = new System.Windows.Forms.CheckBox();
            this.check_viewing = new System.Windows.Forms.CheckBox();
            this.check_video = new System.Windows.Forms.CheckBox();
            this.lbl_typeofrequest = new System.Windows.Forms.Label();
            this.lbl_accompanied = new System.Windows.Forms.Label();
            this.txt_accompanied = new System.Windows.Forms.TextBox();
            this.lbl_brgy = new System.Windows.Forms.Label();
            this.drop_brgy = new System.Windows.Forms.ComboBox();
            this.lbl_location = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.lbl_typeofincident = new System.Windows.Forms.Label();
            this.drop_typeofincident = new System.Windows.Forms.ComboBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_timeofincident = new System.Windows.Forms.TextBox();
            this.picker_dateofincident = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateofincident = new System.Windows.Forms.Label();
            this.grp_additional = new System.Windows.Forms.GroupBox();
            this.lbl_character10k = new System.Windows.Forms.Label();
            this.txt_additional = new System.Windows.Forms.RichTextBox();
            this.grp_remarks = new System.Windows.Forms.GroupBox();
            this.lbl_characters5k = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.RichTextBox();
            this.grp_released = new System.Windows.Forms.GroupBox();
            this.drop_released = new System.Windows.Forms.ComboBox();
            this.grp_statis = new System.Windows.Forms.GroupBox();
            this.radio_cancelled = new System.Windows.Forms.RadioButton();
            this.radio_notreleased = new System.Windows.Forms.RadioButton();
            this.radio_released = new System.Windows.Forms.RadioButton();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_searchcase = new System.Windows.Forms.Label();
            this.txt_searchbox = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.grp_reqinfo.SuspendLayout();
            this.grp_detailsofreport.SuspendLayout();
            this.grp_additional.SuspendLayout();
            this.grp_remarks.SuspendLayout();
            this.grp_released.SuspendLayout();
            this.grp_statis.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_case
            // 
            this.lbl_case.AutoSize = true;
            this.lbl_case.Location = new System.Drawing.Point(151, 44);
            this.lbl_case.Name = "lbl_case";
            this.lbl_case.Size = new System.Drawing.Size(51, 13);
            this.lbl_case.TabIndex = 0;
            this.lbl_case.Text = "Case no:";
            // 
            // info_caseno
            // 
            this.info_caseno.AutoSize = true;
            this.info_caseno.Location = new System.Drawing.Point(208, 44);
            this.info_caseno.Name = "info_caseno";
            this.info_caseno.Size = new System.Drawing.Size(35, 13);
            this.info_caseno.TabIndex = 1;
            this.info_caseno.Text = "####";
            // 
            // grp_reqinfo
            // 
            this.grp_reqinfo.Controls.Add(this.picker_recorded);
            this.grp_reqinfo.Controls.Add(this.label1);
            this.grp_reqinfo.Controls.Add(this.lbl_email);
            this.grp_reqinfo.Controls.Add(this.txt_email);
            this.grp_reqinfo.Controls.Add(this.lbl_contact);
            this.grp_reqinfo.Controls.Add(this.txt_contactno);
            this.grp_reqinfo.Controls.Add(this.lbl_address);
            this.grp_reqinfo.Controls.Add(this.txt_address);
            this.grp_reqinfo.Controls.Add(this.lbl_officeorg);
            this.grp_reqinfo.Controls.Add(this.txt_officeorg);
            this.grp_reqinfo.Controls.Add(this.lbl_fname);
            this.grp_reqinfo.Controls.Add(this.txt_fname);
            this.grp_reqinfo.Controls.Add(this.lbl_lname);
            this.grp_reqinfo.Controls.Add(this.txt_lname);
            this.grp_reqinfo.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_reqinfo.Location = new System.Drawing.Point(154, 75);
            this.grp_reqinfo.Name = "grp_reqinfo";
            this.grp_reqinfo.Size = new System.Drawing.Size(676, 290);
            this.grp_reqinfo.TabIndex = 0;
            this.grp_reqinfo.TabStop = false;
            this.grp_reqinfo.Text = "Requester\'s Information";
            // 
            // picker_recorded
            // 
            this.picker_recorded.Location = new System.Drawing.Point(31, 37);
            this.picker_recorded.Name = "picker_recorded";
            this.picker_recorded.Size = new System.Drawing.Size(200, 22);
            this.picker_recorded.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date Recorded:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(28, 239);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(80, 13);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email address:";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Location = new System.Drawing.Point(31, 255);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(590, 15);
            this.txt_email.TabIndex = 6;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(28, 205);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(93, 13);
            this.lbl_contact.TabIndex = 11;
            this.lbl_contact.Text = "Contact number:";
            // 
            // txt_contactno
            // 
            this.txt_contactno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contactno.Location = new System.Drawing.Point(31, 221);
            this.txt_contactno.Name = "txt_contactno";
            this.txt_contactno.Size = new System.Drawing.Size(590, 15);
            this.txt_contactno.TabIndex = 5;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(28, 171);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(51, 13);
            this.lbl_address.TabIndex = 9;
            this.lbl_address.Text = "Address:";
            // 
            // txt_address
            // 
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Location = new System.Drawing.Point(31, 187);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(590, 15);
            this.txt_address.TabIndex = 4;
            // 
            // lbl_officeorg
            // 
            this.lbl_officeorg.AutoSize = true;
            this.lbl_officeorg.Location = new System.Drawing.Point(28, 137);
            this.lbl_officeorg.Name = "lbl_officeorg";
            this.lbl_officeorg.Size = new System.Drawing.Size(113, 13);
            this.lbl_officeorg.TabIndex = 7;
            this.lbl_officeorg.Text = "Office/Organization:";
            // 
            // txt_officeorg
            // 
            this.txt_officeorg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_officeorg.Location = new System.Drawing.Point(31, 153);
            this.txt_officeorg.Name = "txt_officeorg";
            this.txt_officeorg.Size = new System.Drawing.Size(590, 15);
            this.txt_officeorg.TabIndex = 3;
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(28, 103);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(63, 13);
            this.lbl_fname.TabIndex = 5;
            this.lbl_fname.Text = "First name:";
            // 
            // txt_fname
            // 
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fname.Location = new System.Drawing.Point(31, 119);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(590, 15);
            this.txt_fname.TabIndex = 2;
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(28, 69);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(61, 13);
            this.lbl_lname.TabIndex = 3;
            this.lbl_lname.Text = "Last name:";
            // 
            // txt_lname
            // 
            this.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lname.Location = new System.Drawing.Point(31, 85);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(590, 15);
            this.txt_lname.TabIndex = 1;
            // 
            // grp_detailsofreport
            // 
            this.grp_detailsofreport.Controls.Add(this.lbl_camera);
            this.grp_detailsofreport.Controls.Add(this.drop_camera);
            this.grp_detailsofreport.Controls.Add(this.radio_notcaptured);
            this.grp_detailsofreport.Controls.Add(this.radio_captured);
            this.grp_detailsofreport.Controls.Add(this.lbl_outcome);
            this.grp_detailsofreport.Controls.Add(this.check_screenshot);
            this.grp_detailsofreport.Controls.Add(this.check_viewing);
            this.grp_detailsofreport.Controls.Add(this.check_video);
            this.grp_detailsofreport.Controls.Add(this.lbl_typeofrequest);
            this.grp_detailsofreport.Controls.Add(this.lbl_accompanied);
            this.grp_detailsofreport.Controls.Add(this.txt_accompanied);
            this.grp_detailsofreport.Controls.Add(this.lbl_brgy);
            this.grp_detailsofreport.Controls.Add(this.drop_brgy);
            this.grp_detailsofreport.Controls.Add(this.lbl_location);
            this.grp_detailsofreport.Controls.Add(this.txt_location);
            this.grp_detailsofreport.Controls.Add(this.lbl_typeofincident);
            this.grp_detailsofreport.Controls.Add(this.drop_typeofincident);
            this.grp_detailsofreport.Controls.Add(this.lbl_time);
            this.grp_detailsofreport.Controls.Add(this.txt_timeofincident);
            this.grp_detailsofreport.Controls.Add(this.picker_dateofincident);
            this.grp_detailsofreport.Controls.Add(this.lbl_dateofincident);
            this.grp_detailsofreport.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_detailsofreport.Location = new System.Drawing.Point(836, 75);
            this.grp_detailsofreport.Name = "grp_detailsofreport";
            this.grp_detailsofreport.Size = new System.Drawing.Size(676, 458);
            this.grp_detailsofreport.TabIndex = 7;
            this.grp_detailsofreport.TabStop = false;
            this.grp_detailsofreport.Text = "Details of the Request";
            // 
            // lbl_camera
            // 
            this.lbl_camera.AutoSize = true;
            this.lbl_camera.Location = new System.Drawing.Point(39, 253);
            this.lbl_camera.Name = "lbl_camera";
            this.lbl_camera.Size = new System.Drawing.Size(114, 13);
            this.lbl_camera.TabIndex = 27;
            this.lbl_camera.Text = "Primary camera used:";
            // 
            // drop_camera
            // 
            this.drop_camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_camera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_camera.FormattingEnabled = true;
            this.drop_camera.Items.AddRange(new object[] {
            "MONITOR 1",
            "D1\tAurora Corner Angles St. (back of Catholic Center)",
            "D2\tAurora St. (ACS Annex)",
            "D3\tAngeles St. (OLACCDI 2)",
            "D4\tIskong bantay Co. Angeles St. (Dimayuga Alum. Supply)",
            "D5\tIskong bantay  St.  (Kalabaw)",
            "D6\tLeon Guinto BLVD 1 (Blvd Parking near Fish Port)",
            "D7\tLeon Guinto Cor. Gov Castro St. (Gumaca Terminal)",
            "D8\tLeon Guinto Corner Regino St. (BRGY HALL ZONE 4)",
            "D9\tLeon Guinto BLVD Corner Rizal St. (Fish Port Crossing)",
            "D10\tLeon Guinto Corner Zamora St. (Ice Brooker)",
            "D11\tFishing Port 1 (Pandawan Kaliwa)",
            "D12\tFishing Port 2 (Pandawan Kanan)",
            "D13\tPTZ Caltex",
            "D14\tF Diestro St.F. (Bagumbayan Libro)",
            "D15\tRicafor Extenstion (Bagumbayan Dulo)",
            "D16\tGov Castro Corner Bonifacio St. (Likod ng Munisipyo 1)",
            "D17\tGov Castro Corner Bonifacio St. (Tonyo\'s Chicken)",
            "D18\t",
            "D19\t",
            "D20\tMunicipal Building Annex (Prio/Menro/Peso Blg.)",
            "D21\tPNB Parking (Loob ng Simbahan)",
            "========================================",
            "MONITOR 2",
            "D1\tANPR Cam Tagbakin (Andoks)",
            "D2\tOld Municipal Building (old Munisipyo Tagbakin)",
            "D3\tAh26 Municipal Building (Cias Talyer)",
            "D4\tPTZ Tagbakin (Tagbakin Triangle)",
            "D5\tAH26 Tagbakin CSTC (Harap ng CSTC)",
            "D6\tTagbakin Superlines",
            "D7\tRizal Corner Soler St. 2 (Veranga\'s Store)",
            "D8\tRizal Corner Soler St. 1 (Motorlandia)",
            "D9\tSoler Co. Rizal St. (Soler Sagingan)",
            "D10\tRizal St. QCRB (Novo/Mariel)",
            "D11\tRizal St. Motortrade (Oppo/ RR Ihawan)",
            "D12\tOsmena Co. Rizal St. (Perez Bakery)",
            "D13\tOsmena Co. Rizal St (Pares ni Peso)",
            "D14\tOsmena Co. J Andres (Aries Sticker)",
            "D15\tJ. Andres Co. Osmena St. (Falcon Greenhouse)",
            "D16\tTAYTAY (paahon ng Taytay)",
            "D17\tGov Castro Co. Mabini St (Manolet Mansion)",
            "D18\t",
            "D19\tAnpr Caltex (Angeles Triangle)",
            "D20\tAnpr Lavides Bridge (Ilog Maling Tulay)",
            "========================================",
            "MONITOR 3",
            "D1\tRizal corner Quezon St. 1 (Red Ribbon)",
            "D2\tRizal corner Quezon ST. 2 (A1E/ Landbank)",
            "D3\tMunicipal Hall Front (New Municipal Blg. Entrance)",
            "D4\tQuezon  corner Rizal St. (Ink ni Juan)",
            "D5\tPTZ Municipal ",
            "D6\tG. Castro Corner Quezon St.1 (Gilid Caparros)",
            "D7\tR Diaz St Pagasa (Gilid Pag-asa)",
            "D8\tZamora Corner Quezon St (Manila Dental)",
            "D9\tQuezon Corner J.Andres St (Western Union)",
            "D10\tQuezon St .Lavides Bridge (BDO Tulay)",
            "D11\tLavides Bridge River Side (Jomalig Pantalan)",
            "D12\tPantalan River Side (Lumang Pantalan)",
            "D13\tZone 3 Riverside",
            "D14\tLavides Bridge ",
            "D15\tEnriquez Co. Zamora St. (Amparo Bakery)",
            "D16\tPTZ Public Market",
            "D17\tEnriquez St. Market (Prime Water)",
            "D18\tWet market (Talipapa)",
            "D19\tAmado corner Ricafort (Likod ng Balagtas)",
            "D20\tBulwagang balagtas",
            "D21\tJuez Andres Co. Iskong Bantay (TMU Office)",
            "D22\tIskong Bantay Co. J andres (Maries Furniture)",
            "D23\tIskong Bantay cor. Rizal St. (Kastler Water Refilling)",
            "D24\tIskong Bantay St. (Decano\'s Talyer)",
            "D25\tP. Enriquez St. K Annes (Tapsico)",
            "========================================",
            "MONITOR 4",
            "D1\tBaypark 2 ",
            "D2\tBaypark 1",
            "D3\tPolice Station Back",
            "D4\tMdrrmo Entrance",
            "D5\tLeon Guinto BLVD RHU",
            "D6\tLeon Guinto Nation Agency",
            "D7\tRHU front",
            "D8\tLeon Guint BLVD ALTT",
            "D9\tLeon Guint BLVD ALTT 2",
            "D10\tAtimonan LTT ",
            "D11\tAltt Feeder Port Entrance",
            "D12\tQuezon Co. Cerrudo St 1",
            "D13\tQuezon St. Exit (Bahay ni Mayor)",
            "D14\tQuezon St. Villajuana (Villajuana Subd.)",
            "D15\tQuezon Co. Cerrudo St 2 (Emil Joana Entrance)",
            "D16\tCerrudo Co. Quezon St. 3 (Brgy. Hall zone 1)",
            "========================================",
            "MONITOR 5",
            "D1\tCerrudo Co. Iskong Bantay (Vulcanizing Zone 1)",
            "D2\tCerrudo St. 1 (old Carismatic House)",
            "D3\tCerrudo St. 2",
            "D4\tQuezon Ave. Co. Orda St. (Tricycle Terminal)",
            "D5\tOrda Co. Quezon Avenue (Bethel Condo)",
            "D6\tQuezon Ave. Co.Aguinaldo St. (Micos Intersection)",
            "D7\tQuezon Ave. (Kabayan Bank)",
            "D8\tAguinaldo Co. Quezon Ave (Marivic old Sinehan)",
            "D9\tAguinaldo St. (Quezelco - I)",
            "D10\tDe Gracia St 1. (Belsa Bakery)",
            "D11\tDe Gracia St 2 (Cervantes Alum. Supply)",
            "D12\tDe Gracia St. 3 ",
            "D13\tDegracia 4 St. (Nombrefia Bakery)",
            "D14\tLeon Guinto BLVD (Card Bank Staff House)",
            "D15\tLeon Guinto BLVD 2 (Blvd Slide)",
            "D16\tAguinaldo Co. Leon Guinto St (Am- am Store)",
            "D17\tGov. Castro cor. Mabini St. (Car Wash sa Zone 3)",
            "D18\tVillamiel St.",
            "D19\tVillamiel cor. Gov. Castro (Kap. Zoen House)",
            "========================================",
            "MONITOR 6",
            "D1\tSoler St (dating pulpolan)",
            "D2\tSoler St 2 (Sergio Restaurant)",
            "D3\tDecembrana St.1 (Juego\'s Water Refilling)",
            "D4\tDecembrana St. 2 (Imprentahan)",
            "D5\tMabini St. (LGMC)",
            "D6\tOsmena St 1 (Dimsum Panda)",
            "D7\tAguinaldo Cor. Osmena (Aglipay Church)",
            "D8\tOsmena St. 2 (Volet\'s Eatery)",
            "D9\tAguinaldo St. (??? Bar)",
            "D10\tSoler St Co. Orda (Lumbera House)",
            "D11\tDona Marta Hospital",
            "D12\tSoler Co. Orda (Doña Marta Trike Terminal)",
            "D13\tOrda St (Bilyaran)",
            "D14\tOsmena St 3 (Gate ng Campo Rizal)",
            "D15\tSoler St 3 (QEC Basketball Court)",
            "D16\tSoler Extension ANCHS (Site Entranda)",
            "========================================",
            "MONITOR 7",
            "========================================",
            "MONITOR 8"});
            this.drop_camera.Location = new System.Drawing.Point(42, 269);
            this.drop_camera.Name = "drop_camera";
            this.drop_camera.Size = new System.Drawing.Size(590, 21);
            this.drop_camera.TabIndex = 12;
            // 
            // radio_notcaptured
            // 
            this.radio_notcaptured.AutoSize = true;
            this.radio_notcaptured.Location = new System.Drawing.Point(262, 420);
            this.radio_notcaptured.Name = "radio_notcaptured";
            this.radio_notcaptured.Size = new System.Drawing.Size(95, 17);
            this.radio_notcaptured.TabIndex = 18;
            this.radio_notcaptured.TabStop = true;
            this.radio_notcaptured.Text = "Not Captured";
            this.radio_notcaptured.UseVisualStyleBackColor = true;
            // 
            // radio_captured
            // 
            this.radio_captured.AutoSize = true;
            this.radio_captured.Location = new System.Drawing.Point(183, 420);
            this.radio_captured.Name = "radio_captured";
            this.radio_captured.Size = new System.Drawing.Size(73, 17);
            this.radio_captured.TabIndex = 17;
            this.radio_captured.TabStop = true;
            this.radio_captured.Text = "Captured";
            this.radio_captured.UseVisualStyleBackColor = true;
            // 
            // lbl_outcome
            // 
            this.lbl_outcome.AutoSize = true;
            this.lbl_outcome.Location = new System.Drawing.Point(39, 420);
            this.lbl_outcome.Name = "lbl_outcome";
            this.lbl_outcome.Size = new System.Drawing.Size(133, 13);
            this.lbl_outcome.TabIndex = 23;
            this.lbl_outcome.Text = "Outcome of the request:";
            // 
            // check_screenshot
            // 
            this.check_screenshot.AutoSize = true;
            this.check_screenshot.Location = new System.Drawing.Point(120, 366);
            this.check_screenshot.Name = "check_screenshot";
            this.check_screenshot.Size = new System.Drawing.Size(118, 17);
            this.check_screenshot.TabIndex = 15;
            this.check_screenshot.Text = "Screenshot/Image";
            this.check_screenshot.UseVisualStyleBackColor = true;
            // 
            // check_viewing
            // 
            this.check_viewing.AutoSize = true;
            this.check_viewing.Location = new System.Drawing.Point(120, 389);
            this.check_viewing.Name = "check_viewing";
            this.check_viewing.Size = new System.Drawing.Size(68, 17);
            this.check_viewing.TabIndex = 16;
            this.check_viewing.Text = "Viewing";
            this.check_viewing.UseVisualStyleBackColor = true;
            // 
            // check_video
            // 
            this.check_video.AutoSize = true;
            this.check_video.Location = new System.Drawing.Point(120, 343);
            this.check_video.Name = "check_video";
            this.check_video.Size = new System.Drawing.Size(102, 17);
            this.check_video.TabIndex = 14;
            this.check_video.Text = "Video Footage";
            this.check_video.UseVisualStyleBackColor = true;
            // 
            // lbl_typeofrequest
            // 
            this.lbl_typeofrequest.AutoSize = true;
            this.lbl_typeofrequest.Location = new System.Drawing.Point(39, 327);
            this.lbl_typeofrequest.Name = "lbl_typeofrequest";
            this.lbl_typeofrequest.Size = new System.Drawing.Size(89, 13);
            this.lbl_typeofrequest.TabIndex = 14;
            this.lbl_typeofrequest.Text = "Type of request:";
            // 
            // lbl_accompanied
            // 
            this.lbl_accompanied.AutoSize = true;
            this.lbl_accompanied.Location = new System.Drawing.Point(39, 293);
            this.lbl_accompanied.Name = "lbl_accompanied";
            this.lbl_accompanied.Size = new System.Drawing.Size(94, 13);
            this.lbl_accompanied.TabIndex = 15;
            this.lbl_accompanied.Text = "Accompanied by:";
            // 
            // txt_accompanied
            // 
            this.txt_accompanied.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_accompanied.Location = new System.Drawing.Point(42, 309);
            this.txt_accompanied.Name = "txt_accompanied";
            this.txt_accompanied.Size = new System.Drawing.Size(590, 15);
            this.txt_accompanied.TabIndex = 13;
            // 
            // lbl_brgy
            // 
            this.lbl_brgy.AutoSize = true;
            this.lbl_brgy.Location = new System.Drawing.Point(39, 213);
            this.lbl_brgy.Name = "lbl_brgy";
            this.lbl_brgy.Size = new System.Drawing.Size(136, 13);
            this.lbl_brgy.TabIndex = 19;
            this.lbl_brgy.Text = "Barangay of the incident:";
            // 
            // drop_brgy
            // 
            this.drop_brgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_brgy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_brgy.FormattingEnabled = true;
            this.drop_brgy.Items.AddRange(new object[] {
            "ZONE 1 POBLACION",
            "ZONE 2 POBLACION",
            "ZONE 3 POBLACION",
            "ZONE 4 POBLACION",
            "TAGBAKIN",
            "===============",
            "ANGELES",
            "BALUBAD",
            "BALUGOHIN",
            "BUHANGIN",
            "CARIDAD IBABA",
            "CARIDAD ILAYA",
            "HABINGAN",
            "INACLAGAN",
            "INALIG",
            "KILAIT",
            "KULAWIT",
            "LAKIP",
            "LUBI",
            "LUMUTAN",
            "MAGSAYSAY",
            "MALINAO IBABA",
            "MALINAO ILAYA",
            "MALUSAK",
            "MANGGALAYAN BUNDOK",
            "MANGGALAYAN LABAK",
            "MATANAG",
            "MONTES BALAON",
            "MONTES KALLAGAN",
            "PONON",
            "RIZAL",
            "SAN ANDRES BUNDOK",
            "SAN ANDRES LABAK",
            "SAN ISIDRO",
            "SAN JOSE BALATOK",
            "SAN RAFAEL",
            "STA. CATALINA",
            "SAPAAN",
            "SOKOL",
            "TALABA",
            "TINANDOG",
            "VILLA IBABA",
            "VILLA ILAYA"});
            this.drop_brgy.Location = new System.Drawing.Point(42, 229);
            this.drop_brgy.Name = "drop_brgy";
            this.drop_brgy.Size = new System.Drawing.Size(590, 21);
            this.drop_brgy.TabIndex = 11;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(39, 179);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(217, 13);
            this.lbl_location.TabIndex = 15;
            this.lbl_location.Text = "Location/Area of the incident took place:";
            // 
            // txt_location
            // 
            this.txt_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_location.Location = new System.Drawing.Point(42, 195);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(590, 15);
            this.txt_location.TabIndex = 10;
            // 
            // lbl_typeofincident
            // 
            this.lbl_typeofincident.AutoSize = true;
            this.lbl_typeofincident.Location = new System.Drawing.Point(39, 139);
            this.lbl_typeofincident.Name = "lbl_typeofincident";
            this.lbl_typeofincident.Size = new System.Drawing.Size(92, 13);
            this.lbl_typeofincident.TabIndex = 17;
            this.lbl_typeofincident.Text = "Type of Incident:";
            // 
            // drop_typeofincident
            // 
            this.drop_typeofincident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_typeofincident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_typeofincident.FormattingEnabled = true;
            this.drop_typeofincident.Items.AddRange(new object[] {
            "Assault",
            "Destruction to property",
            "Fire Disaster",
            "Hold-up",
            "Missing Person",
            "Missing Item",
            "Murder",
            "Natural Disaster",
            "Public Scandal",
            "Profiling",
            "Road Crash",
            "Robbery",
            "Self-Accident",
            "Theft",
            "Trespassing",
            "Vandalism",
            "Others - Explain in Additional Information"});
            this.drop_typeofincident.Location = new System.Drawing.Point(42, 155);
            this.drop_typeofincident.Name = "drop_typeofincident";
            this.drop_typeofincident.Size = new System.Drawing.Size(590, 21);
            this.drop_typeofincident.TabIndex = 9;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(39, 105);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(113, 13);
            this.lbl_time.TabIndex = 15;
            this.lbl_time.Text = "Time of the incident:";
            // 
            // txt_timeofincident
            // 
            this.txt_timeofincident.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_timeofincident.Location = new System.Drawing.Point(42, 121);
            this.txt_timeofincident.Name = "txt_timeofincident";
            this.txt_timeofincident.Size = new System.Drawing.Size(590, 15);
            this.txt_timeofincident.TabIndex = 8;
            // 
            // picker_dateofincident
            // 
            this.picker_dateofincident.Location = new System.Drawing.Point(42, 69);
            this.picker_dateofincident.Name = "picker_dateofincident";
            this.picker_dateofincident.Size = new System.Drawing.Size(200, 22);
            this.picker_dateofincident.TabIndex = 7;
            // 
            // lbl_dateofincident
            // 
            this.lbl_dateofincident.AutoSize = true;
            this.lbl_dateofincident.Location = new System.Drawing.Point(39, 50);
            this.lbl_dateofincident.Name = "lbl_dateofincident";
            this.lbl_dateofincident.Size = new System.Drawing.Size(113, 13);
            this.lbl_dateofincident.TabIndex = 14;
            this.lbl_dateofincident.Text = "Date of the Incident:";
            // 
            // grp_additional
            // 
            this.grp_additional.Controls.Add(this.lbl_character10k);
            this.grp_additional.Controls.Add(this.txt_additional);
            this.grp_additional.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_additional.Location = new System.Drawing.Point(154, 371);
            this.grp_additional.Name = "grp_additional";
            this.grp_additional.Size = new System.Drawing.Size(676, 350);
            this.grp_additional.TabIndex = 19;
            this.grp_additional.TabStop = false;
            this.grp_additional.Text = "Additional Information";
            // 
            // lbl_character10k
            // 
            this.lbl_character10k.AutoSize = true;
            this.lbl_character10k.Location = new System.Drawing.Point(476, 327);
            this.lbl_character10k.Name = "lbl_character10k";
            this.lbl_character10k.Size = new System.Drawing.Size(155, 13);
            this.lbl_character10k.TabIndex = 20;
            this.lbl_character10k.Text = "Characters Remaining: 10000";
            // 
            // txt_additional
            // 
            this.txt_additional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_additional.Location = new System.Drawing.Point(41, 28);
            this.txt_additional.MaxLength = 10000;
            this.txt_additional.Name = "txt_additional";
            this.txt_additional.Size = new System.Drawing.Size(590, 296);
            this.txt_additional.TabIndex = 19;
            this.txt_additional.Text = "";
            this.txt_additional.TextChanged += new System.EventHandler(this.txt_additional_TextChanged);
            // 
            // grp_remarks
            // 
            this.grp_remarks.Controls.Add(this.lbl_characters5k);
            this.grp_remarks.Controls.Add(this.txt_remarks);
            this.grp_remarks.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_remarks.Location = new System.Drawing.Point(836, 539);
            this.grp_remarks.Name = "grp_remarks";
            this.grp_remarks.Size = new System.Drawing.Size(676, 182);
            this.grp_remarks.TabIndex = 20;
            this.grp_remarks.TabStop = false;
            this.grp_remarks.Text = "Remarks";
            // 
            // lbl_characters5k
            // 
            this.lbl_characters5k.AutoSize = true;
            this.lbl_characters5k.Location = new System.Drawing.Point(477, 159);
            this.lbl_characters5k.Name = "lbl_characters5k";
            this.lbl_characters5k.Size = new System.Drawing.Size(149, 13);
            this.lbl_characters5k.TabIndex = 21;
            this.lbl_characters5k.Text = "Characters Remaining: 5000";
            // 
            // txt_remarks
            // 
            this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_remarks.Location = new System.Drawing.Point(41, 28);
            this.txt_remarks.MaxLength = 5000;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(590, 128);
            this.txt_remarks.TabIndex = 20;
            this.txt_remarks.Text = "";
            this.txt_remarks.TextChanged += new System.EventHandler(this.txt_remarks_TextChanged);
            // 
            // grp_released
            // 
            this.grp_released.Controls.Add(this.drop_released);
            this.grp_released.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_released.Location = new System.Drawing.Point(154, 727);
            this.grp_released.Name = "grp_released";
            this.grp_released.Size = new System.Drawing.Size(676, 72);
            this.grp_released.TabIndex = 21;
            this.grp_released.TabStop = false;
            this.grp_released.Text = "Footage is review/released by";
            // 
            // drop_released
            // 
            this.drop_released.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_released.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_released.FormattingEnabled = true;
            this.drop_released.Items.AddRange(new object[] {
            "ANDA, BYRON GLENN",
            "AMPARO, MELQUI ELIOENAI",
            "DE TORRES, JOHN MICHAEL",
            "LASHERAS, JOHN PHILLIP",
            "LASQUETY, MELMA",
            "ROLDAN, GEOFREY VEIN"});
            this.drop_released.Location = new System.Drawing.Point(41, 31);
            this.drop_released.Name = "drop_released";
            this.drop_released.Size = new System.Drawing.Size(590, 21);
            this.drop_released.TabIndex = 21;
            // 
            // grp_statis
            // 
            this.grp_statis.Controls.Add(this.radio_cancelled);
            this.grp_statis.Controls.Add(this.radio_notreleased);
            this.grp_statis.Controls.Add(this.radio_released);
            this.grp_statis.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_statis.Location = new System.Drawing.Point(154, 805);
            this.grp_statis.Name = "grp_statis";
            this.grp_statis.Size = new System.Drawing.Size(676, 72);
            this.grp_statis.TabIndex = 22;
            this.grp_statis.TabStop = false;
            this.grp_statis.Text = "Status of the Request";
            // 
            // radio_cancelled
            // 
            this.radio_cancelled.AutoSize = true;
            this.radio_cancelled.Location = new System.Drawing.Point(223, 35);
            this.radio_cancelled.Name = "radio_cancelled";
            this.radio_cancelled.Size = new System.Drawing.Size(75, 17);
            this.radio_cancelled.TabIndex = 24;
            this.radio_cancelled.TabStop = true;
            this.radio_cancelled.Text = "Cancelled";
            this.radio_cancelled.UseVisualStyleBackColor = true;
            // 
            // radio_notreleased
            // 
            this.radio_notreleased.AutoSize = true;
            this.radio_notreleased.Location = new System.Drawing.Point(124, 35);
            this.radio_notreleased.Name = "radio_notreleased";
            this.radio_notreleased.Size = new System.Drawing.Size(93, 17);
            this.radio_notreleased.TabIndex = 23;
            this.radio_notreleased.TabStop = true;
            this.radio_notreleased.Text = "Not Released";
            this.radio_notreleased.UseVisualStyleBackColor = true;
            // 
            // radio_released
            // 
            this.radio_released.AutoSize = true;
            this.radio_released.Location = new System.Drawing.Point(47, 35);
            this.radio_released.Name = "radio_released";
            this.radio_released.Size = new System.Drawing.Size(71, 17);
            this.radio_released.TabIndex = 22;
            this.radio_released.TabStop = true;
            this.radio_released.Text = "Released";
            this.radio_released.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_submit.Image = ((System.Drawing.Image)(resources.GetObject("btn_submit.Image")));
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit.Location = new System.Drawing.Point(1373, 805);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btn_submit.Size = new System.Drawing.Size(139, 72);
            this.btn_submit.TabIndex = 28;
            this.btn_submit.Text = "Submit";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(1228, 805);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btn_edit.Size = new System.Drawing.Size(139, 72);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(1083, 805);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btn_delete.Size = new System.Drawing.Size(139, 72);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(935, 805);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btn_reset.Size = new System.Drawing.Size(139, 72);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_searchcase
            // 
            this.lbl_searchcase.AutoSize = true;
            this.lbl_searchcase.Location = new System.Drawing.Point(1022, 36);
            this.lbl_searchcase.Name = "lbl_searchcase";
            this.lbl_searchcase.Size = new System.Drawing.Size(89, 13);
            this.lbl_searchcase.TabIndex = 15;
            this.lbl_searchcase.Text = "Search case no.:";
            // 
            // txt_searchbox
            // 
            this.txt_searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_searchbox.Location = new System.Drawing.Point(1117, 36);
            this.txt_searchbox.Name = "txt_searchbox";
            this.txt_searchbox.Size = new System.Drawing.Size(250, 15);
            this.txt_searchbox.TabIndex = 29;
            this.txt_searchbox.TextChanged += new System.EventHandler(this.txt_searchbox_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_search.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(1373, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btn_search.Size = new System.Drawing.Size(139, 72);
            this.btn_search.TabIndex = 30;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cctvrequestforms
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1671, 899);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_searchcase);
            this.Controls.Add(this.txt_searchbox);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.grp_statis);
            this.Controls.Add(this.grp_released);
            this.Controls.Add(this.grp_remarks);
            this.Controls.Add(this.grp_additional);
            this.Controls.Add(this.grp_detailsofreport);
            this.Controls.Add(this.grp_reqinfo);
            this.Controls.Add(this.info_caseno);
            this.Controls.Add(this.lbl_case);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cctvrequestforms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cctvrequestforms";
            this.grp_reqinfo.ResumeLayout(false);
            this.grp_reqinfo.PerformLayout();
            this.grp_detailsofreport.ResumeLayout(false);
            this.grp_detailsofreport.PerformLayout();
            this.grp_additional.ResumeLayout(false);
            this.grp_additional.PerformLayout();
            this.grp_remarks.ResumeLayout(false);
            this.grp_remarks.PerformLayout();
            this.grp_released.ResumeLayout(false);
            this.grp_statis.ResumeLayout(false);
            this.grp_statis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_case;
        private System.Windows.Forms.Label info_caseno;
        private System.Windows.Forms.GroupBox grp_reqinfo;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.TextBox txt_contactno;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_officeorg;
        private System.Windows.Forms.TextBox txt_officeorg;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.GroupBox grp_detailsofreport;
        private System.Windows.Forms.RadioButton radio_notcaptured;
        private System.Windows.Forms.RadioButton radio_captured;
        private System.Windows.Forms.Label lbl_outcome;
        private System.Windows.Forms.CheckBox check_screenshot;
        private System.Windows.Forms.CheckBox check_viewing;
        private System.Windows.Forms.CheckBox check_video;
        private System.Windows.Forms.Label lbl_typeofrequest;
        private System.Windows.Forms.Label lbl_accompanied;
        private System.Windows.Forms.TextBox txt_accompanied;
        private System.Windows.Forms.Label lbl_brgy;
        private System.Windows.Forms.ComboBox drop_brgy;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label lbl_typeofincident;
        private System.Windows.Forms.ComboBox drop_typeofincident;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_timeofincident;
        private System.Windows.Forms.DateTimePicker picker_dateofincident;
        private System.Windows.Forms.Label lbl_dateofincident;
        private System.Windows.Forms.Label lbl_camera;
        private System.Windows.Forms.ComboBox drop_camera;
        private System.Windows.Forms.GroupBox grp_additional;
        private System.Windows.Forms.RichTextBox txt_additional;
        private System.Windows.Forms.GroupBox grp_remarks;
        private System.Windows.Forms.RichTextBox txt_remarks;
        private System.Windows.Forms.GroupBox grp_released;
        private System.Windows.Forms.ComboBox drop_released;
        private System.Windows.Forms.GroupBox grp_statis;
        private System.Windows.Forms.RadioButton radio_cancelled;
        private System.Windows.Forms.RadioButton radio_notreleased;
        private System.Windows.Forms.RadioButton radio_released;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_searchcase;
        private System.Windows.Forms.TextBox txt_searchbox;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_character10k;
        private System.Windows.Forms.Label lbl_characters5k;
        private System.Windows.Forms.DateTimePicker picker_recorded;
        private System.Windows.Forms.Label label1;
    }
}