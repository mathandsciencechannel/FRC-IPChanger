namespace FRC_IPChanger
{
    partial class Config
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
            this.label1 = new System.Windows.Forms.Label();
            this.team1IPBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveConfig = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.team1DefGatewayBox = new System.Windows.Forms.TextBox();
            this.team1SubNetBox = new System.Windows.Forms.TextBox();
            this.team1panel = new System.Windows.Forms.Panel();
            this.team1nameBox = new System.Windows.Forms.TextBox();
            this.team2panel = new System.Windows.Forms.Panel();
            this.team2nameBox = new System.Windows.Forms.TextBox();
            this.team2DefGatewayBox = new System.Windows.Forms.TextBox();
            this.team2SubNetBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.team2IPBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.team3panel = new System.Windows.Forms.Panel();
            this.team3nameBox = new System.Windows.Forms.TextBox();
            this.team3DefGatewayBox = new System.Windows.Forms.TextBox();
            this.team3SubNetBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.team3IPBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.resetConfig = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.team1panel.SuspendLayout();
            this.team2panel.SuspendLayout();
            this.team3panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team 1";
            // 
            // team1IPBox
            // 
            this.team1IPBox.Location = new System.Drawing.Point(88, 51);
            this.team1IPBox.Name = "team1IPBox";
            this.team1IPBox.Size = new System.Drawing.Size(176, 20);
            this.team1IPBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP";
            // 
            // saveConfig
            // 
            this.saveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveConfig.Location = new System.Drawing.Point(12, 522);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(279, 48);
            this.saveConfig.TabIndex = 9;
            this.saveConfig.Text = "Save";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sub Mask";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Def Gateway";
            // 
            // team1DefGatewayBox
            // 
            this.team1DefGatewayBox.Location = new System.Drawing.Point(88, 127);
            this.team1DefGatewayBox.Name = "team1DefGatewayBox";
            this.team1DefGatewayBox.Size = new System.Drawing.Size(176, 20);
            this.team1DefGatewayBox.TabIndex = 12;
            // 
            // team1SubNetBox
            // 
            this.team1SubNetBox.Location = new System.Drawing.Point(88, 89);
            this.team1SubNetBox.Name = "team1SubNetBox";
            this.team1SubNetBox.Size = new System.Drawing.Size(176, 20);
            this.team1SubNetBox.TabIndex = 13;
            // 
            // team1panel
            // 
            this.team1panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.team1panel.Controls.Add(this.team1nameBox);
            this.team1panel.Controls.Add(this.team1DefGatewayBox);
            this.team1panel.Controls.Add(this.team1SubNetBox);
            this.team1panel.Controls.Add(this.label1);
            this.team1panel.Controls.Add(this.team1IPBox);
            this.team1panel.Controls.Add(this.label5);
            this.team1panel.Controls.Add(this.label4);
            this.team1panel.Controls.Add(this.label7);
            this.team1panel.Location = new System.Drawing.Point(12, 12);
            this.team1panel.Name = "team1panel";
            this.team1panel.Size = new System.Drawing.Size(279, 163);
            this.team1panel.TabIndex = 17;
            // 
            // team1nameBox
            // 
            this.team1nameBox.Location = new System.Drawing.Point(154, 11);
            this.team1nameBox.Name = "team1nameBox";
            this.team1nameBox.Size = new System.Drawing.Size(100, 20);
            this.team1nameBox.TabIndex = 14;
            // 
            // team2panel
            // 
            this.team2panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.team2panel.Controls.Add(this.team2nameBox);
            this.team2panel.Controls.Add(this.team2DefGatewayBox);
            this.team2panel.Controls.Add(this.team2SubNetBox);
            this.team2panel.Controls.Add(this.label2);
            this.team2panel.Controls.Add(this.team2IPBox);
            this.team2panel.Controls.Add(this.label3);
            this.team2panel.Controls.Add(this.label65);
            this.team2panel.Controls.Add(this.label8);
            this.team2panel.Location = new System.Drawing.Point(12, 181);
            this.team2panel.Name = "team2panel";
            this.team2panel.Size = new System.Drawing.Size(279, 163);
            this.team2panel.TabIndex = 18;
            // 
            // team2nameBox
            // 
            this.team2nameBox.Location = new System.Drawing.Point(154, 11);
            this.team2nameBox.Name = "team2nameBox";
            this.team2nameBox.Size = new System.Drawing.Size(100, 20);
            this.team2nameBox.TabIndex = 15;
            // 
            // team2DefGatewayBox
            // 
            this.team2DefGatewayBox.Location = new System.Drawing.Point(88, 127);
            this.team2DefGatewayBox.Name = "team2DefGatewayBox";
            this.team2DefGatewayBox.Size = new System.Drawing.Size(176, 20);
            this.team2DefGatewayBox.TabIndex = 12;
            // 
            // team2SubNetBox
            // 
            this.team2SubNetBox.Location = new System.Drawing.Point(88, 89);
            this.team2SubNetBox.Name = "team2SubNetBox";
            this.team2SubNetBox.Size = new System.Drawing.Size(176, 20);
            this.team2SubNetBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team 2";
            // 
            // team2IPBox
            // 
            this.team2IPBox.Location = new System.Drawing.Point(88, 51);
            this.team2IPBox.Name = "team2IPBox";
            this.team2IPBox.Size = new System.Drawing.Size(176, 20);
            this.team2IPBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Def Gateway";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(4, 54);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(17, 13);
            this.label65.TabIndex = 4;
            this.label65.Text = "IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sub Mask";
            // 
            // team3panel
            // 
            this.team3panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.team3panel.Controls.Add(this.team3nameBox);
            this.team3panel.Controls.Add(this.team3DefGatewayBox);
            this.team3panel.Controls.Add(this.team3SubNetBox);
            this.team3panel.Controls.Add(this.label9);
            this.team3panel.Controls.Add(this.team3IPBox);
            this.team3panel.Controls.Add(this.label10);
            this.team3panel.Controls.Add(this.label11);
            this.team3panel.Controls.Add(this.label12);
            this.team3panel.Location = new System.Drawing.Point(12, 350);
            this.team3panel.Name = "team3panel";
            this.team3panel.Size = new System.Drawing.Size(279, 163);
            this.team3panel.TabIndex = 18;
            // 
            // team3nameBox
            // 
            this.team3nameBox.Location = new System.Drawing.Point(154, 11);
            this.team3nameBox.Name = "team3nameBox";
            this.team3nameBox.Size = new System.Drawing.Size(100, 20);
            this.team3nameBox.TabIndex = 15;
            // 
            // team3DefGatewayBox
            // 
            this.team3DefGatewayBox.Location = new System.Drawing.Point(88, 127);
            this.team3DefGatewayBox.Name = "team3DefGatewayBox";
            this.team3DefGatewayBox.Size = new System.Drawing.Size(176, 20);
            this.team3DefGatewayBox.TabIndex = 12;
            // 
            // team3SubNetBox
            // 
            this.team3SubNetBox.Location = new System.Drawing.Point(88, 89);
            this.team3SubNetBox.Name = "team3SubNetBox";
            this.team3SubNetBox.Size = new System.Drawing.Size(176, 20);
            this.team3SubNetBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Team 3";
            // 
            // team3IPBox
            // 
            this.team3IPBox.Location = new System.Drawing.Point(88, 51);
            this.team3IPBox.Name = "team3IPBox";
            this.team3IPBox.Size = new System.Drawing.Size(176, 20);
            this.team3IPBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Def Gateway";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "IP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Sub Mask";
            // 
            // resetConfig
            // 
            this.resetConfig.Location = new System.Drawing.Point(114, 576);
            this.resetConfig.Name = "resetConfig";
            this.resetConfig.Size = new System.Drawing.Size(75, 23);
            this.resetConfig.TabIndex = 19;
            this.resetConfig.Text = "Reset";
            this.resetConfig.UseVisualStyleBackColor = true;
            this.resetConfig.Click += new System.EventHandler(this.resetConfig_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(62, 605);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Limit Adapter List To Connected";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 631);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.resetConfig);
            this.Controls.Add(this.team3panel);
            this.Controls.Add(this.team2panel);
            this.Controls.Add(this.team1panel);
            this.Controls.Add(this.saveConfig);
            this.Name = "Config";
            this.Text = "Config © 2016 Justin Newberry";
            this.Load += new System.EventHandler(this.Config_Load);
            this.team1panel.ResumeLayout(false);
            this.team1panel.PerformLayout();
            this.team2panel.ResumeLayout(false);
            this.team2panel.PerformLayout();
            this.team3panel.ResumeLayout(false);
            this.team3panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox team1IPBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox team1DefGatewayBox;
        private System.Windows.Forms.TextBox team1SubNetBox;
        private System.Windows.Forms.Panel team1panel;
        private System.Windows.Forms.Panel team2panel;
        private System.Windows.Forms.TextBox team2DefGatewayBox;
        private System.Windows.Forms.TextBox team2SubNetBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox team2IPBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel team3panel;
        private System.Windows.Forms.TextBox team3DefGatewayBox;
        private System.Windows.Forms.TextBox team3SubNetBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox team3IPBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox team1nameBox;
        private System.Windows.Forms.TextBox team2nameBox;
        private System.Windows.Forms.TextBox team3nameBox;
        private System.Windows.Forms.Button resetConfig;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}