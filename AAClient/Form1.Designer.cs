﻿namespace AAClient
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
            this.ResultsGridView = new System.Windows.Forms.DataGridView();
            this.StarVelocityObserved_textbox = new System.Windows.Forms.TextBox();
            this.StarVelocity_label = new System.Windows.Forms.Label();
            this.StarDistance_label = new System.Windows.Forms.Label();
            this.StarDistanceArchseconds_textbox = new System.Windows.Forms.TextBox();
            this.Temperature_label = new System.Windows.Forms.Label();
            this.TemperatureKelvin_textbox = new System.Windows.Forms.TextBox();
            this.EventHorizen_label = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.EnglishButton = new System.Windows.Forms.Button();
            this.FrenchButton = new System.Windows.Forms.Button();
            this.GermanButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ColorPickerButton = new System.Windows.Forms.Button();
            this.FontPickerButton = new System.Windows.Forms.Button();
            this.ThemePickerButton = new System.Windows.Forms.Button();
            this.StarVelocity_btn = new System.Windows.Forms.Button();
            this.StarDistance_btn = new System.Windows.Forms.Button();
            this.TemperatureKelvin_btn = new System.Windows.Forms.Button();
            this.EventHorizon_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.StarVelocityRest_textbox = new System.Windows.Forms.TextBox();
            this.Connection_label = new System.Windows.Forms.Label();
            this.Connection_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsGridView
            // 
            this.ResultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsGridView.Location = new System.Drawing.Point(368, 12);
            this.ResultsGridView.Name = "ResultsGridView";
            this.ResultsGridView.Size = new System.Drawing.Size(375, 317);
            this.ResultsGridView.TabIndex = 0;
            // 
            // StarVelocityObserved_textbox
            // 
            this.StarVelocityObserved_textbox.Location = new System.Drawing.Point(46, 124);
            this.StarVelocityObserved_textbox.Name = "StarVelocityObserved_textbox";
            this.StarVelocityObserved_textbox.Size = new System.Drawing.Size(128, 20);
            this.StarVelocityObserved_textbox.TabIndex = 1;
            // 
            // StarVelocity_label
            // 
            this.StarVelocity_label.AutoSize = true;
            this.StarVelocity_label.Location = new System.Drawing.Point(106, 108);
            this.StarVelocity_label.Name = "StarVelocity_label";
            this.StarVelocity_label.Size = new System.Drawing.Size(66, 13);
            this.StarVelocity_label.TabIndex = 2;
            this.StarVelocity_label.Text = "Star Velocity";
            // 
            // StarDistance_label
            // 
            this.StarDistance_label.AutoSize = true;
            this.StarDistance_label.Location = new System.Drawing.Point(103, 182);
            this.StarDistance_label.Name = "StarDistance_label";
            this.StarDistance_label.Size = new System.Drawing.Size(71, 13);
            this.StarDistance_label.TabIndex = 4;
            this.StarDistance_label.Text = "Star Distance";
            // 
            // StarDistanceArchseconds_textbox
            // 
            this.StarDistanceArchseconds_textbox.Location = new System.Drawing.Point(46, 198);
            this.StarDistanceArchseconds_textbox.Name = "StarDistanceArchseconds_textbox";
            this.StarDistanceArchseconds_textbox.Size = new System.Drawing.Size(184, 20);
            this.StarDistanceArchseconds_textbox.TabIndex = 5;
            // 
            // Temperature_label
            // 
            this.Temperature_label.AutoSize = true;
            this.Temperature_label.Location = new System.Drawing.Point(106, 265);
            this.Temperature_label.Name = "Temperature_label";
            this.Temperature_label.Size = new System.Drawing.Size(67, 13);
            this.Temperature_label.TabIndex = 6;
            this.Temperature_label.Text = "Temperature";
            // 
            // TemperatureKelvin_textbox
            // 
            this.TemperatureKelvin_textbox.Location = new System.Drawing.Point(46, 281);
            this.TemperatureKelvin_textbox.Name = "TemperatureKelvin_textbox";
            this.TemperatureKelvin_textbox.Size = new System.Drawing.Size(184, 20);
            this.TemperatureKelvin_textbox.TabIndex = 7;
            // 
            // EventHorizen_label
            // 
            this.EventHorizen_label.AutoSize = true;
            this.EventHorizen_label.Location = new System.Drawing.Point(103, 348);
            this.EventHorizen_label.Name = "EventHorizen_label";
            this.EventHorizen_label.Size = new System.Drawing.Size(74, 13);
            this.EventHorizen_label.TabIndex = 8;
            this.EventHorizen_label.Text = "Event Horizon";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(46, 391);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 9;
            // 
            // EnglishButton
            // 
            this.EnglishButton.Location = new System.Drawing.Point(388, 348);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(75, 23);
            this.EnglishButton.TabIndex = 11;
            this.EnglishButton.Text = "English(UK)";
            this.EnglishButton.UseVisualStyleBackColor = true;
            this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click);
            // 
            // FrenchButton
            // 
            this.FrenchButton.Location = new System.Drawing.Point(388, 377);
            this.FrenchButton.Name = "FrenchButton";
            this.FrenchButton.Size = new System.Drawing.Size(75, 23);
            this.FrenchButton.TabIndex = 12;
            this.FrenchButton.Text = "French";
            this.FrenchButton.UseVisualStyleBackColor = true;
            this.FrenchButton.Click += new System.EventHandler(this.FrenchButton_Click);
            // 
            // GermanButton
            // 
            this.GermanButton.Location = new System.Drawing.Point(388, 406);
            this.GermanButton.Name = "GermanButton";
            this.GermanButton.Size = new System.Drawing.Size(75, 23);
            this.GermanButton.TabIndex = 13;
            this.GermanButton.Text = "German";
            this.GermanButton.UseVisualStyleBackColor = true;
            this.GermanButton.Click += new System.EventHandler(this.GermanButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(228, 51);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(83, 23);
            this.CalculateButton.TabIndex = 14;
            this.CalculateButton.Text = "Calculate All";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ColorPickerButton
            // 
            this.ColorPickerButton.Location = new System.Drawing.Point(638, 377);
            this.ColorPickerButton.Name = "ColorPickerButton";
            this.ColorPickerButton.Size = new System.Drawing.Size(88, 23);
            this.ColorPickerButton.TabIndex = 15;
            this.ColorPickerButton.Text = "Pick Colors";
            this.ColorPickerButton.UseVisualStyleBackColor = true;
            this.ColorPickerButton.Click += new System.EventHandler(this.ColorPickerButton_Click);
            // 
            // FontPickerButton
            // 
            this.FontPickerButton.Location = new System.Drawing.Point(638, 406);
            this.FontPickerButton.Name = "FontPickerButton";
            this.FontPickerButton.Size = new System.Drawing.Size(88, 23);
            this.FontPickerButton.TabIndex = 16;
            this.FontPickerButton.Text = "Pick Fonts";
            this.FontPickerButton.UseVisualStyleBackColor = true;
            // 
            // ThemePickerButton
            // 
            this.ThemePickerButton.Location = new System.Drawing.Point(638, 348);
            this.ThemePickerButton.Name = "ThemePickerButton";
            this.ThemePickerButton.Size = new System.Drawing.Size(88, 23);
            this.ThemePickerButton.TabIndex = 17;
            this.ThemePickerButton.Text = "Pick Themes";
            this.ThemePickerButton.UseVisualStyleBackColor = true;
            // 
            // StarVelocity_btn
            // 
            this.StarVelocity_btn.Location = new System.Drawing.Point(236, 124);
            this.StarVelocity_btn.Name = "StarVelocity_btn";
            this.StarVelocity_btn.Size = new System.Drawing.Size(75, 23);
            this.StarVelocity_btn.TabIndex = 18;
            this.StarVelocity_btn.Text = "Calculate";
            this.StarVelocity_btn.UseVisualStyleBackColor = true;
            this.StarVelocity_btn.Click += new System.EventHandler(this.StarVelocity_btn_Click);
            // 
            // StarDistance_btn
            // 
            this.StarDistance_btn.Location = new System.Drawing.Point(236, 198);
            this.StarDistance_btn.Name = "StarDistance_btn";
            this.StarDistance_btn.Size = new System.Drawing.Size(75, 23);
            this.StarDistance_btn.TabIndex = 19;
            this.StarDistance_btn.Text = "Calculate";
            this.StarDistance_btn.UseVisualStyleBackColor = true;
            this.StarDistance_btn.Click += new System.EventHandler(this.StarDistance_btn_Click);
            // 
            // TemperatureKelvin_btn
            // 
            this.TemperatureKelvin_btn.Location = new System.Drawing.Point(236, 278);
            this.TemperatureKelvin_btn.Name = "TemperatureKelvin_btn";
            this.TemperatureKelvin_btn.Size = new System.Drawing.Size(75, 23);
            this.TemperatureKelvin_btn.TabIndex = 20;
            this.TemperatureKelvin_btn.Text = "Calculate";
            this.TemperatureKelvin_btn.UseVisualStyleBackColor = true;
            this.TemperatureKelvin_btn.Click += new System.EventHandler(this.TemperatureKelvin_btn_Click);
            // 
            // EventHorizon_btn
            // 
            this.EventHorizon_btn.Location = new System.Drawing.Point(236, 375);
            this.EventHorizon_btn.Name = "EventHorizon_btn";
            this.EventHorizon_btn.Size = new System.Drawing.Size(75, 23);
            this.EventHorizon_btn.TabIndex = 21;
            this.EventHorizon_btn.Text = "Calculate";
            this.EventHorizon_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "X 10";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(46, 366);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(184, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // StarVelocityRest_textbox
            // 
            this.StarVelocityRest_textbox.Location = new System.Drawing.Point(178, 124);
            this.StarVelocityRest_textbox.Name = "StarVelocityRest_textbox";
            this.StarVelocityRest_textbox.Size = new System.Drawing.Size(56, 20);
            this.StarVelocityRest_textbox.TabIndex = 2;
            // 
            // Connection_label
            // 
            this.Connection_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_label.Location = new System.Drawing.Point(12, 14);
            this.Connection_label.Name = "Connection_label";
            this.Connection_label.Size = new System.Drawing.Size(299, 34);
            this.Connection_label.TabIndex = 26;
            this.Connection_label.Text = "Connection";
            // 
            // Connection_btn
            // 
            this.Connection_btn.Location = new System.Drawing.Point(12, 50);
            this.Connection_btn.Name = "Connection_btn";
            this.Connection_btn.Size = new System.Drawing.Size(145, 23);
            this.Connection_btn.TabIndex = 25;
            this.Connection_btn.Text = "Check Server";
            this.Connection_btn.UseVisualStyleBackColor = true;
            this.Connection_btn.Click += new System.EventHandler(this.Connection_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Connection_btn);
            this.Controls.Add(this.Connection_label);
            this.Controls.Add(this.StarVelocityRest_textbox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventHorizon_btn);
            this.Controls.Add(this.TemperatureKelvin_btn);
            this.Controls.Add(this.StarDistance_btn);
            this.Controls.Add(this.StarVelocity_btn);
            this.Controls.Add(this.ThemePickerButton);
            this.Controls.Add(this.FontPickerButton);
            this.Controls.Add(this.ColorPickerButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.GermanButton);
            this.Controls.Add(this.FrenchButton);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.textBox4);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button EnglishButton;
        private System.Windows.Forms.Button FrenchButton;
        private System.Windows.Forms.Button GermanButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ColorPickerButton;
        private System.Windows.Forms.Button FontPickerButton;
        private System.Windows.Forms.Button ThemePickerButton;
        private System.Windows.Forms.Button StarVelocity_btn;
        private System.Windows.Forms.Button StarDistance_btn;
        private System.Windows.Forms.Button TemperatureKelvin_btn;
        private System.Windows.Forms.Button EventHorizon_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox StarVelocityRest_textbox;
        private System.Windows.Forms.Label Connection_label;
        private System.Windows.Forms.Button Connection_btn;
    }
}

