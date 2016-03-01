namespace FRC_IPChanger
{
    partial class IPChanger
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
            this.adapterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.team1Button = new System.Windows.Forms.Button();
            this.team3Button = new System.Windows.Forms.Button();
            this.team2Button = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.resetallbutton = new System.Windows.Forms.Button();
            this.refreshnalist = new System.Windows.Forms.Button();
            this.statusbox = new System.Windows.Forms.TextBox();
            this.helpbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adapterComboBox
            // 
            this.adapterComboBox.FormattingEnabled = true;
            this.adapterComboBox.Location = new System.Drawing.Point(12, 37);
            this.adapterComboBox.Name = "adapterComboBox";
            this.adapterComboBox.Size = new System.Drawing.Size(383, 21);
            this.adapterComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Network Adapter";
            // 
            // team1Button
            // 
            this.team1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.team1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Button.Location = new System.Drawing.Point(12, 91);
            this.team1Button.Name = "team1Button";
            this.team1Button.Size = new System.Drawing.Size(193, 85);
            this.team1Button.TabIndex = 3;
            this.team1Button.Text = "Team 1";
            this.team1Button.UseVisualStyleBackColor = false;
            this.team1Button.Click += new System.EventHandler(this.team1Button_Click);
            // 
            // team3Button
            // 
            this.team3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.team3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team3Button.Location = new System.Drawing.Point(670, 91);
            this.team3Button.Name = "team3Button";
            this.team3Button.Size = new System.Drawing.Size(193, 85);
            this.team3Button.TabIndex = 4;
            this.team3Button.Text = "Team 3";
            this.team3Button.UseVisualStyleBackColor = false;
            this.team3Button.Click += new System.EventHandler(this.team3Button_Click);
            // 
            // team2Button
            // 
            this.team2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.team2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Button.Location = new System.Drawing.Point(341, 91);
            this.team2Button.Name = "team2Button";
            this.team2Button.Size = new System.Drawing.Size(193, 85);
            this.team2Button.TabIndex = 5;
            this.team2Button.Text = "Team 2";
            this.team2Button.UseVisualStyleBackColor = false;
            this.team2Button.Click += new System.EventHandler(this.team2Button_Click);
            // 
            // configButton
            // 
            this.configButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.configButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configButton.Location = new System.Drawing.Point(734, 9);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(129, 49);
            this.configButton.TabIndex = 6;
            this.configButton.Text = "Config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // resetallbutton
            // 
            this.resetallbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetallbutton.Location = new System.Drawing.Point(401, 35);
            this.resetallbutton.Name = "resetallbutton";
            this.resetallbutton.Size = new System.Drawing.Size(110, 23);
            this.resetallbutton.TabIndex = 7;
            this.resetallbutton.Text = "Auto-Config All";
            this.resetallbutton.UseVisualStyleBackColor = true;
            this.resetallbutton.Click += new System.EventHandler(this.resetipbutton_Click);
            // 
            // refreshnalist
            // 
            this.refreshnalist.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.refreshnalist.Location = new System.Drawing.Point(320, 8);
            this.refreshnalist.Name = "refreshnalist";
            this.refreshnalist.Size = new System.Drawing.Size(75, 23);
            this.refreshnalist.TabIndex = 8;
            this.refreshnalist.Text = "Refresh";
            this.refreshnalist.UseVisualStyleBackColor = true;
            this.refreshnalist.Click += new System.EventHandler(this.refreshnalist_Click);
            // 
            // statusbox
            // 
            this.statusbox.BackColor = System.Drawing.Color.Silver;
            this.statusbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.statusbox.Location = new System.Drawing.Point(13, 183);
            this.statusbox.Multiline = true;
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(850, 89);
            this.statusbox.TabIndex = 9;
            // 
            // helpbutton
            // 
            this.helpbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.helpbutton.Location = new System.Drawing.Point(530, 35);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(75, 23);
            this.helpbutton.TabIndex = 10;
            this.helpbutton.Text = "Help";
            this.helpbutton.UseVisualStyleBackColor = true;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // IPChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 284);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.refreshnalist);
            this.Controls.Add(this.resetallbutton);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.team2Button);
            this.Controls.Add(this.team3Button);
            this.Controls.Add(this.team1Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adapterComboBox);
            this.Name = "IPChanger";
            this.Text = "FRC IPChanger © 2016 Justin Newberry";
            this.Load += new System.EventHandler(this.IPChanger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox adapterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button team1Button;
        private System.Windows.Forms.Button team3Button;
        private System.Windows.Forms.Button team2Button;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button resetallbutton;
        private System.Windows.Forms.Button refreshnalist;
        private System.Windows.Forms.TextBox statusbox;
        private System.Windows.Forms.Button helpbutton;
    }
}

