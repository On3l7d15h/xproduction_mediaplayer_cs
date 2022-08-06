namespace WindowsFormsXproduction
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.gpnl_topBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_separator = new System.Windows.Forms.Label();
            this.lbl_archiveTitle = new System.Windows.Forms.Label();
            this.lbl_appTitle = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gdcl_topBar = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gpnl_bottomBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pcb_vol = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_endTime = new System.Windows.Forms.Label();
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.mtb_vol = new XComponent.SliderBar.MACTrackBar();
            this.mtb_main = new XComponent.SliderBar.MACTrackBar();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.tmSlider = new System.Windows.Forms.Timer(this.components);
            this.wmp_main = new AxWMPLib.AxWindowsMediaPlayer();
            this.gpnl_topBar.SuspendLayout();
            this.gpnl_bottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_vol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_main)).BeginInit();
            this.SuspendLayout();
            // 
            // gpnl_topBar
            // 
            this.gpnl_topBar.Controls.Add(this.btn_search);
            this.gpnl_topBar.Controls.Add(this.lbl_separator);
            this.gpnl_topBar.Controls.Add(this.lbl_archiveTitle);
            this.gpnl_topBar.Controls.Add(this.lbl_appTitle);
            this.gpnl_topBar.Controls.Add(this.btn_exit);
            this.gpnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpnl_topBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.gpnl_topBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.gpnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.gpnl_topBar.Name = "gpnl_topBar";
            this.gpnl_topBar.ShadowDecoration.Parent = this.gpnl_topBar;
            this.gpnl_topBar.Size = new System.Drawing.Size(958, 49);
            this.gpnl_topBar.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.AutoSize = true;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = global::WindowsFormsXproduction.Properties.Resources.search_ico;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btn_search.Location = new System.Drawing.Point(860, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(40, 40);
            this.btn_search.TabIndex = 4;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_separator
            // 
            this.lbl_separator.AutoSize = true;
            this.lbl_separator.BackColor = System.Drawing.Color.Transparent;
            this.lbl_separator.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.lbl_separator.Location = new System.Drawing.Point(149, 10);
            this.lbl_separator.Name = "lbl_separator";
            this.lbl_separator.Size = new System.Drawing.Size(18, 28);
            this.lbl_separator.TabIndex = 3;
            this.lbl_separator.Text = "|";
            // 
            // lbl_archiveTitle
            // 
            this.lbl_archiveTitle.AutoSize = true;
            this.lbl_archiveTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_archiveTitle.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_archiveTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.lbl_archiveTitle.Location = new System.Drawing.Point(165, 12);
            this.lbl_archiveTitle.MaximumSize = new System.Drawing.Size(700, 28);
            this.lbl_archiveTitle.MinimumSize = new System.Drawing.Size(0, 28);
            this.lbl_archiveTitle.Name = "lbl_archiveTitle";
            this.lbl_archiveTitle.Size = new System.Drawing.Size(90, 28);
            this.lbl_archiveTitle.TabIndex = 2;
            this.lbl_archiveTitle.Text = "Inactivo";
            // 
            // lbl_appTitle
            // 
            this.lbl_appTitle.AutoSize = true;
            this.lbl_appTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_appTitle.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.lbl_appTitle.Location = new System.Drawing.Point(12, 11);
            this.lbl_appTitle.Name = "lbl_appTitle";
            this.lbl_appTitle.Size = new System.Drawing.Size(136, 28);
            this.lbl_appTitle.TabIndex = 1;
            this.lbl_appTitle.Text = "Xproduction";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = global::WindowsFormsXproduction.Properties.Resources.cross_ico;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btn_exit.Location = new System.Drawing.Point(906, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 40);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gdcl_topBar
            // 
            this.gdcl_topBar.TargetControl = this.gpnl_topBar;
            // 
            // gpnl_bottomBar
            // 
            this.gpnl_bottomBar.Controls.Add(this.pcb_vol);
            this.gpnl_bottomBar.Controls.Add(this.label2);
            this.gpnl_bottomBar.Controls.Add(this.lbl_endTime);
            this.gpnl_bottomBar.Controls.Add(this.lbl_startTime);
            this.gpnl_bottomBar.Controls.Add(this.mtb_vol);
            this.gpnl_bottomBar.Controls.Add(this.mtb_main);
            this.gpnl_bottomBar.Controls.Add(this.btn_forward);
            this.gpnl_bottomBar.Controls.Add(this.btn_next);
            this.gpnl_bottomBar.Controls.Add(this.btn_play);
            this.gpnl_bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpnl_bottomBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gpnl_bottomBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gpnl_bottomBar.Location = new System.Drawing.Point(0, 496);
            this.gpnl_bottomBar.Name = "gpnl_bottomBar";
            this.gpnl_bottomBar.ShadowDecoration.Parent = this.gpnl_bottomBar;
            this.gpnl_bottomBar.Size = new System.Drawing.Size(958, 105);
            this.gpnl_bottomBar.TabIndex = 2;
            // 
            // pcb_vol
            // 
            this.pcb_vol.BackgroundImage = global::WindowsFormsXproduction.Properties.Resources.volume_ico;
            this.pcb_vol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcb_vol.Location = new System.Drawing.Point(235, 54);
            this.pcb_vol.Name = "pcb_vol";
            this.pcb_vol.Size = new System.Drawing.Size(45, 35);
            this.pcb_vol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcb_vol.TabIndex = 4;
            this.pcb_vol.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(96, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "|";
            // 
            // lbl_endTime
            // 
            this.lbl_endTime.AutoSize = true;
            this.lbl_endTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_endTime.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.lbl_endTime.Location = new System.Drawing.Point(107, 42);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(45, 22);
            this.lbl_endTime.TabIndex = 6;
            this.lbl_endTime.Text = "0:00";
            this.lbl_endTime.Click += new System.EventHandler(this.lbl_endTime_Click);
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_startTime.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.lbl_startTime.Location = new System.Drawing.Point(44, 42);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(45, 22);
            this.lbl_startTime.TabIndex = 2;
            this.lbl_startTime.Text = "0:00";
            this.lbl_startTime.Click += new System.EventHandler(this.lbl_startTime_Click);
            // 
            // mtb_vol
            // 
            this.mtb_vol.BackColor = System.Drawing.Color.Transparent;
            this.mtb_vol.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtb_vol.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_vol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtb_vol.IndentHeight = 6;
            this.mtb_vol.Location = new System.Drawing.Point(282, 54);
            this.mtb_vol.Maximum = 100;
            this.mtb_vol.Minimum = 0;
            this.mtb_vol.Name = "mtb_vol";
            this.mtb_vol.Size = new System.Drawing.Size(118, 28);
            this.mtb_vol.TabIndex = 5;
            this.mtb_vol.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtb_vol.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtb_vol.TickHeight = 2;
            this.mtb_vol.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtb_vol.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.mtb_vol.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtb_vol.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.mtb_vol.TrackLineHeight = 3;
            this.mtb_vol.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.mtb_vol.Value = 50;
            this.mtb_vol.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtb_vol_ValueChanged);
            // 
            // mtb_main
            // 
            this.mtb_main.BackColor = System.Drawing.Color.Transparent;
            this.mtb_main.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtb_main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtb_main.IndentHeight = 6;
            this.mtb_main.Location = new System.Drawing.Point(38, 9);
            this.mtb_main.Maximum = 100;
            this.mtb_main.Minimum = 0;
            this.mtb_main.Name = "mtb_main";
            this.mtb_main.Size = new System.Drawing.Size(875, 28);
            this.mtb_main.TabIndex = 4;
            this.mtb_main.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtb_main.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtb_main.TickHeight = 2;
            this.mtb_main.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtb_main.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.mtb_main.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtb_main.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.mtb_main.TrackLineHeight = 3;
            this.mtb_main.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.mtb_main.Value = 0;
            this.mtb_main.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtb_main_ValueChanged);
            // 
            // btn_forward
            // 
            this.btn_forward.AutoSize = true;
            this.btn_forward.BackColor = System.Drawing.Color.Transparent;
            this.btn_forward.BackgroundImage = global::WindowsFormsXproduction.Properties.Resources.angle_l_ico;
            this.btn_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_forward.FlatAppearance.BorderSize = 0;
            this.btn_forward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_forward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forward.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btn_forward.Location = new System.Drawing.Point(406, 52);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(51, 40);
            this.btn_forward.TabIndex = 3;
            this.btn_forward.UseVisualStyleBackColor = false;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_next
            // 
            this.btn_next.AutoSize = true;
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.BackgroundImage = global::WindowsFormsXproduction.Properties.Resources.angle_r_ico;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btn_next.Location = new System.Drawing.Point(531, 52);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(51, 40);
            this.btn_next.TabIndex = 2;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.AutoSize = true;
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BackgroundImage = global::WindowsFormsXproduction.Properties.Resources.play_ico;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btn_play.Location = new System.Drawing.Point(463, 47);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(62, 50);
            this.btn_play.TabIndex = 1;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // tmSlider
            // 
            this.tmSlider.Tick += new System.EventHandler(this.tmSlider_Tick);
            // 
            // wmp_main
            // 
            this.wmp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp_main.Enabled = true;
            this.wmp_main.Location = new System.Drawing.Point(0, 49);
            this.wmp_main.Name = "wmp_main";
            this.wmp_main.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_main.OcxState")));
            this.wmp_main.Size = new System.Drawing.Size(958, 447);
            this.wmp_main.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(958, 601);
            this.Controls.Add(this.wmp_main);
            this.Controls.Add(this.gpnl_bottomBar);
            this.Controls.Add(this.gpnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gpnl_topBar.ResumeLayout(false);
            this.gpnl_topBar.PerformLayout();
            this.gpnl_bottomBar.ResumeLayout(false);
            this.gpnl_bottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_vol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel gpnl_topBar;
        private Guna.UI2.WinForms.Guna2DragControl gdcl_topBar;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_appTitle;
        private Guna.UI2.WinForms.Guna2GradientPanel gpnl_bottomBar;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_next;
        private XComponent.SliderBar.MACTrackBar mtb_main;
        private XComponent.SliderBar.MACTrackBar mtb_vol;
        private System.Windows.Forms.Label lbl_endTime;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmSlider;
        private System.Windows.Forms.Label lbl_separator;
        private System.Windows.Forms.Label lbl_archiveTitle;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pcb_vol;
        private AxWMPLib.AxWindowsMediaPlayer wmp_main;
    }
}

