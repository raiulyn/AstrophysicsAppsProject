namespace AAClient
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
            System.Windows.Forms.Label Company_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ResultsGridView = new System.Windows.Forms.DataGridView();
            this.StarVelocityObserved_textbox = new System.Windows.Forms.TextBox();
            this.StarVelocity_label = new System.Windows.Forms.Label();
            this.StarDistance_label = new System.Windows.Forms.Label();
            this.StarDistanceArchseconds_textbox = new System.Windows.Forms.TextBox();
            this.Temperature_label = new System.Windows.Forms.Label();
            this.TemperatureKelvin_textbox = new System.Windows.Forms.TextBox();
            this.EventHorizen_label = new System.Windows.Forms.Label();
            this.EventHorizon_textbox = new System.Windows.Forms.TextBox();
            this.EnglishButton = new System.Windows.Forms.Button();
            this.FrenchButton = new System.Windows.Forms.Button();
            this.GermanButton = new System.Windows.Forms.Button();
            this.CalculateAll_Button = new System.Windows.Forms.Button();
            this.ColorPicker_Button = new System.Windows.Forms.Button();
            this.FontPicker_Button = new System.Windows.Forms.Button();
            this.BackgroundPicker_Button = new System.Windows.Forms.Button();
            this.StarVelocity_btn = new System.Windows.Forms.Button();
            this.StarDistance_btn = new System.Windows.Forms.Button();
            this.TemperatureKelvin_btn = new System.Windows.Forms.Button();
            this.EventHorizon_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EventHorizon_updown = new System.Windows.Forms.NumericUpDown();
            this.StarVelocityRest_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.DefaultTheme_Button = new System.Windows.Forms.Button();
            this.BlackTheme_Button = new System.Windows.Forms.Button();
            this.RedTheme_Button = new System.Windows.Forms.Button();
            Company_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventHorizon_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Company_Label
            // 
            Company_Label.AutoSize = true;
            Company_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Company_Label.Location = new System.Drawing.Point(12, 12);
            Company_Label.Name = "Company_Label";
            Company_Label.Size = new System.Drawing.Size(118, 39);
            Company_Label.TabIndex = 31;
            Company_Label.Text = "MSSS";
            // 
            // ResultsGridView
            // 
            this.ResultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsGridView.Location = new System.Drawing.Point(368, 12);
            this.ResultsGridView.Name = "ResultsGridView";
            this.ResultsGridView.Size = new System.Drawing.Size(468, 317);
            this.ResultsGridView.TabIndex = 0;
            // 
            // StarVelocityObserved_textbox
            // 
            this.StarVelocityObserved_textbox.Location = new System.Drawing.Point(50, 99);
            this.StarVelocityObserved_textbox.Name = "StarVelocityObserved_textbox";
            this.StarVelocityObserved_textbox.Size = new System.Drawing.Size(128, 20);
            this.StarVelocityObserved_textbox.TabIndex = 1;
            this.StarVelocityObserved_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyInput);
            // 
            // StarVelocity_label
            // 
            this.StarVelocity_label.AutoSize = true;
            this.StarVelocity_label.Location = new System.Drawing.Point(110, 83);
            this.StarVelocity_label.Name = "StarVelocity_label";
            this.StarVelocity_label.Size = new System.Drawing.Size(66, 13);
            this.StarVelocity_label.TabIndex = 2;
            this.StarVelocity_label.Text = "Star Velocity";
            // 
            // StarDistance_label
            // 
            this.StarDistance_label.AutoSize = true;
            this.StarDistance_label.Location = new System.Drawing.Point(107, 157);
            this.StarDistance_label.Name = "StarDistance_label";
            this.StarDistance_label.Size = new System.Drawing.Size(71, 13);
            this.StarDistance_label.TabIndex = 4;
            this.StarDistance_label.Text = "Star Distance";
            // 
            // StarDistanceArchseconds_textbox
            // 
            this.StarDistanceArchseconds_textbox.Location = new System.Drawing.Point(50, 173);
            this.StarDistanceArchseconds_textbox.Name = "StarDistanceArchseconds_textbox";
            this.StarDistanceArchseconds_textbox.Size = new System.Drawing.Size(184, 20);
            this.StarDistanceArchseconds_textbox.TabIndex = 5;
            this.StarDistanceArchseconds_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyInput);
            // 
            // Temperature_label
            // 
            this.Temperature_label.AutoSize = true;
            this.Temperature_label.Location = new System.Drawing.Point(110, 240);
            this.Temperature_label.Name = "Temperature_label";
            this.Temperature_label.Size = new System.Drawing.Size(67, 13);
            this.Temperature_label.TabIndex = 6;
            this.Temperature_label.Text = "Temperature";
            // 
            // TemperatureKelvin_textbox
            // 
            this.TemperatureKelvin_textbox.Location = new System.Drawing.Point(50, 256);
            this.TemperatureKelvin_textbox.Name = "TemperatureKelvin_textbox";
            this.TemperatureKelvin_textbox.Size = new System.Drawing.Size(184, 20);
            this.TemperatureKelvin_textbox.TabIndex = 7;
            this.TemperatureKelvin_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyInput);
            // 
            // EventHorizen_label
            // 
            this.EventHorizen_label.AutoSize = true;
            this.EventHorizen_label.Location = new System.Drawing.Point(107, 323);
            this.EventHorizen_label.Name = "EventHorizen_label";
            this.EventHorizen_label.Size = new System.Drawing.Size(74, 13);
            this.EventHorizen_label.TabIndex = 8;
            this.EventHorizen_label.Text = "Event Horizon";
            // 
            // EventHorizon_textbox
            // 
            this.EventHorizon_textbox.Location = new System.Drawing.Point(50, 341);
            this.EventHorizon_textbox.Name = "EventHorizon_textbox";
            this.EventHorizon_textbox.Size = new System.Drawing.Size(148, 20);
            this.EventHorizon_textbox.TabIndex = 9;
            this.EventHorizon_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyInput);
            // 
            // EnglishButton
            // 
            this.EnglishButton.Location = new System.Drawing.Point(417, 348);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(75, 23);
            this.EnglishButton.TabIndex = 11;
            this.EnglishButton.Text = "English(UK)";
            this.EnglishButton.UseVisualStyleBackColor = true;
            this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click);
            // 
            // FrenchButton
            // 
            this.FrenchButton.Location = new System.Drawing.Point(417, 377);
            this.FrenchButton.Name = "FrenchButton";
            this.FrenchButton.Size = new System.Drawing.Size(75, 23);
            this.FrenchButton.TabIndex = 12;
            this.FrenchButton.Text = "French";
            this.FrenchButton.UseVisualStyleBackColor = true;
            this.FrenchButton.Click += new System.EventHandler(this.FrenchButton_Click);
            // 
            // GermanButton
            // 
            this.GermanButton.Location = new System.Drawing.Point(417, 406);
            this.GermanButton.Name = "GermanButton";
            this.GermanButton.Size = new System.Drawing.Size(75, 23);
            this.GermanButton.TabIndex = 13;
            this.GermanButton.Text = "German";
            this.GermanButton.UseVisualStyleBackColor = true;
            this.GermanButton.Click += new System.EventHandler(this.GermanButton_Click);
            // 
            // CalculateAll_Button
            // 
            this.CalculateAll_Button.Location = new System.Drawing.Point(182, 46);
            this.CalculateAll_Button.Name = "CalculateAll_Button";
            this.CalculateAll_Button.Size = new System.Drawing.Size(133, 23);
            this.CalculateAll_Button.TabIndex = 14;
            this.CalculateAll_Button.Text = "Calculate All";
            this.CalculateAll_Button.UseVisualStyleBackColor = true;
            this.CalculateAll_Button.Click += new System.EventHandler(this.CalculateAll_Button_Click);
            // 
            // ColorPicker_Button
            // 
            this.ColorPicker_Button.Location = new System.Drawing.Point(667, 377);
            this.ColorPicker_Button.Name = "ColorPicker_Button";
            this.ColorPicker_Button.Size = new System.Drawing.Size(166, 23);
            this.ColorPicker_Button.TabIndex = 15;
            this.ColorPicker_Button.Text = "Pick Colors";
            this.ColorPicker_Button.UseVisualStyleBackColor = true;
            this.ColorPicker_Button.Click += new System.EventHandler(this.ColorPickerButton_Click);
            // 
            // FontPicker_Button
            // 
            this.FontPicker_Button.Location = new System.Drawing.Point(667, 406);
            this.FontPicker_Button.Name = "FontPicker_Button";
            this.FontPicker_Button.Size = new System.Drawing.Size(166, 23);
            this.FontPicker_Button.TabIndex = 16;
            this.FontPicker_Button.Text = "Pick Fonts";
            this.FontPicker_Button.UseVisualStyleBackColor = true;
            this.FontPicker_Button.Click += new System.EventHandler(this.FontPickerButton_Click);
            // 
            // BackgroundPicker_Button
            // 
            this.BackgroundPicker_Button.Location = new System.Drawing.Point(667, 348);
            this.BackgroundPicker_Button.Name = "BackgroundPicker_Button";
            this.BackgroundPicker_Button.Size = new System.Drawing.Size(166, 23);
            this.BackgroundPicker_Button.TabIndex = 17;
            this.BackgroundPicker_Button.Text = "Pick Background";
            this.BackgroundPicker_Button.UseVisualStyleBackColor = true;
            this.BackgroundPicker_Button.Click += new System.EventHandler(this.BackgroundPickerButton_Click);
            // 
            // StarVelocity_btn
            // 
            this.StarVelocity_btn.Location = new System.Drawing.Point(240, 99);
            this.StarVelocity_btn.Name = "StarVelocity_btn";
            this.StarVelocity_btn.Size = new System.Drawing.Size(75, 23);
            this.StarVelocity_btn.TabIndex = 18;
            this.StarVelocity_btn.Text = "Calculate";
            this.StarVelocity_btn.UseVisualStyleBackColor = true;
            this.StarVelocity_btn.Click += new System.EventHandler(this.StarVelocity_btn_Click);
            // 
            // StarDistance_btn
            // 
            this.StarDistance_btn.Location = new System.Drawing.Point(240, 173);
            this.StarDistance_btn.Name = "StarDistance_btn";
            this.StarDistance_btn.Size = new System.Drawing.Size(75, 23);
            this.StarDistance_btn.TabIndex = 19;
            this.StarDistance_btn.Text = "Calculate";
            this.StarDistance_btn.UseVisualStyleBackColor = true;
            this.StarDistance_btn.Click += new System.EventHandler(this.StarDistance_btn_Click);
            // 
            // TemperatureKelvin_btn
            // 
            this.TemperatureKelvin_btn.Location = new System.Drawing.Point(240, 253);
            this.TemperatureKelvin_btn.Name = "TemperatureKelvin_btn";
            this.TemperatureKelvin_btn.Size = new System.Drawing.Size(75, 23);
            this.TemperatureKelvin_btn.TabIndex = 20;
            this.TemperatureKelvin_btn.Text = "Calculate";
            this.TemperatureKelvin_btn.UseVisualStyleBackColor = true;
            this.TemperatureKelvin_btn.Click += new System.EventHandler(this.TemperatureKelvin_btn_Click);
            // 
            // EventHorizon_btn
            // 
            this.EventHorizon_btn.Location = new System.Drawing.Point(240, 338);
            this.EventHorizon_btn.Name = "EventHorizon_btn";
            this.EventHorizon_btn.Size = new System.Drawing.Size(75, 23);
            this.EventHorizon_btn.TabIndex = 21;
            this.EventHorizon_btn.Text = "Calculate";
            this.EventHorizon_btn.UseVisualStyleBackColor = true;
            this.EventHorizon_btn.Click += new System.EventHandler(this.EventHorizon_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "X 10";
            // 
            // EventHorizon_updown
            // 
            this.EventHorizon_updown.Enabled = false;
            this.EventHorizon_updown.Location = new System.Drawing.Point(50, 367);
            this.EventHorizon_updown.Name = "EventHorizon_updown";
            this.EventHorizon_updown.Size = new System.Drawing.Size(184, 20);
            this.EventHorizon_updown.TabIndex = 23;
            this.EventHorizon_updown.Visible = false;
            // 
            // StarVelocityRest_textbox
            // 
            this.StarVelocityRest_textbox.Location = new System.Drawing.Point(182, 99);
            this.StarVelocityRest_textbox.Name = "StarVelocityRest_textbox";
            this.StarVelocityRest_textbox.Size = new System.Drawing.Size(56, 20);
            this.StarVelocityRest_textbox.TabIndex = 2;
            this.StarVelocityRest_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyInput);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(376, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 22);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(376, 375);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 25);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(376, 406);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 23);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(12, 421);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.Size = new System.Drawing.Size(340, 20);
            this.MessageBox.TabIndex = 30;
            // 
            // DefaultTheme_Button
            // 
            this.DefaultTheme_Button.Location = new System.Drawing.Point(530, 348);
            this.DefaultTheme_Button.Name = "DefaultTheme_Button";
            this.DefaultTheme_Button.Size = new System.Drawing.Size(75, 23);
            this.DefaultTheme_Button.TabIndex = 32;
            this.DefaultTheme_Button.Text = "Default";
            this.DefaultTheme_Button.UseVisualStyleBackColor = true;
            this.DefaultTheme_Button.Click += new System.EventHandler(this.DefaultTheme_Button_Click);
            // 
            // BlackTheme_Button
            // 
            this.BlackTheme_Button.Location = new System.Drawing.Point(530, 377);
            this.BlackTheme_Button.Name = "BlackTheme_Button";
            this.BlackTheme_Button.Size = new System.Drawing.Size(75, 23);
            this.BlackTheme_Button.TabIndex = 32;
            this.BlackTheme_Button.Text = "Black";
            this.BlackTheme_Button.UseVisualStyleBackColor = true;
            this.BlackTheme_Button.Click += new System.EventHandler(this.BlackTheme_Button_Click);
            // 
            // RedTheme_Button
            // 
            this.RedTheme_Button.Location = new System.Drawing.Point(530, 406);
            this.RedTheme_Button.Name = "RedTheme_Button";
            this.RedTheme_Button.Size = new System.Drawing.Size(75, 23);
            this.RedTheme_Button.TabIndex = 32;
            this.RedTheme_Button.Text = "Red";
            this.RedTheme_Button.UseVisualStyleBackColor = true;
            this.RedTheme_Button.Click += new System.EventHandler(this.RedTheme_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.RedTheme_Button);
            this.Controls.Add(this.BlackTheme_Button);
            this.Controls.Add(this.DefaultTheme_Button);
            this.Controls.Add(Company_Label);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StarVelocityRest_textbox);
            this.Controls.Add(this.EventHorizon_updown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventHorizon_btn);
            this.Controls.Add(this.TemperatureKelvin_btn);
            this.Controls.Add(this.StarDistance_btn);
            this.Controls.Add(this.StarVelocity_btn);
            this.Controls.Add(this.BackgroundPicker_Button);
            this.Controls.Add(this.FontPicker_Button);
            this.Controls.Add(this.ColorPicker_Button);
            this.Controls.Add(this.CalculateAll_Button);
            this.Controls.Add(this.GermanButton);
            this.Controls.Add(this.FrenchButton);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.EventHorizon_textbox);
            this.Controls.Add(this.EventHorizen_label);
            this.Controls.Add(this.TemperatureKelvin_textbox);
            this.Controls.Add(this.Temperature_label);
            this.Controls.Add(this.StarDistanceArchseconds_textbox);
            this.Controls.Add(this.StarDistance_label);
            this.Controls.Add(this.StarVelocity_label);
            this.Controls.Add(this.StarVelocityObserved_textbox);
            this.Controls.Add(this.ResultsGridView);
            this.Name = "Form1";
            this.Text = "AstrophysicsApps Client";
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventHorizon_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultsGridView;
        private System.Windows.Forms.TextBox StarVelocityObserved_textbox;
        private System.Windows.Forms.Label StarVelocity_label;
        private System.Windows.Forms.Label StarDistance_label;
        private System.Windows.Forms.TextBox StarDistanceArchseconds_textbox;
        private System.Windows.Forms.Label Temperature_label;
        private System.Windows.Forms.TextBox TemperatureKelvin_textbox;
        private System.Windows.Forms.Label EventHorizen_label;
        private System.Windows.Forms.TextBox EventHorizon_textbox;
        private System.Windows.Forms.Button EnglishButton;
        private System.Windows.Forms.Button FrenchButton;
        private System.Windows.Forms.Button GermanButton;
        private System.Windows.Forms.Button CalculateAll_Button;
        private System.Windows.Forms.Button ColorPicker_Button;
        private System.Windows.Forms.Button FontPicker_Button;
        private System.Windows.Forms.Button BackgroundPicker_Button;
        private System.Windows.Forms.Button StarVelocity_btn;
        private System.Windows.Forms.Button StarDistance_btn;
        private System.Windows.Forms.Button TemperatureKelvin_btn;
        private System.Windows.Forms.Button EventHorizon_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EventHorizon_updown;
        private System.Windows.Forms.TextBox StarVelocityRest_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Button DefaultTheme_Button;
        private System.Windows.Forms.Button BlackTheme_Button;
        private System.Windows.Forms.Button RedTheme_Button;
    }
}

