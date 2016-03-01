using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRC_IPChanger
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            team1IPBox.Text = Properties.Settings.Default["team1ip"].ToString();
            team2IPBox.Text = Properties.Settings.Default["team2ip"].ToString();
            team3IPBox.Text = Properties.Settings.Default["team3ip"].ToString();
            team1SubNetBox.Text = Properties.Settings.Default["team1sub"].ToString();
            team2SubNetBox.Text = Properties.Settings.Default["team2sub"].ToString();
            team3SubNetBox.Text = Properties.Settings.Default["team3sub"].ToString();
            team1DefGatewayBox.Text = Properties.Settings.Default["team1gat"].ToString();
            team2DefGatewayBox.Text = Properties.Settings.Default["team2gat"].ToString();
            team3DefGatewayBox.Text = Properties.Settings.Default["team3gat"].ToString();
            team1nameBox.Text = Properties.Settings.Default["team1name"].ToString();
            team2nameBox.Text = Properties.Settings.Default["team2name"].ToString();
            team3nameBox.Text = Properties.Settings.Default["team3name"].ToString();
            checkBox1.Checked = (bool)Properties.Settings.Default["adapterListLimit"];
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["team1ip"] = team1IPBox.Text;
            Properties.Settings.Default["team2ip"] = team2IPBox.Text;
            Properties.Settings.Default["team3ip"] = team3IPBox.Text;
            Properties.Settings.Default["team1sub"] = team1SubNetBox.Text;
            Properties.Settings.Default["team2sub"] = team2SubNetBox.Text;
            Properties.Settings.Default["team3sub"] = team3SubNetBox.Text;
            Properties.Settings.Default["team1gat"] = team1DefGatewayBox.Text;
            Properties.Settings.Default["team2gat"] = team2DefGatewayBox.Text;
            Properties.Settings.Default["team3gat"] = team3DefGatewayBox.Text;
            Properties.Settings.Default["team1name"] = team1nameBox.Text;
            Properties.Settings.Default["team2name"] = team2nameBox.Text;
            Properties.Settings.Default["team3name"] = team3nameBox.Text;
            Properties.Settings.Default["adapterListLimit"] = checkBox1.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void resetConfig_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            team1IPBox.Text = Properties.Settings.Default["team1ip"].ToString();
            team2IPBox.Text = Properties.Settings.Default["team2ip"].ToString();
            team3IPBox.Text = Properties.Settings.Default["team3ip"].ToString();
            team1SubNetBox.Text = Properties.Settings.Default["team1sub"].ToString();
            team2SubNetBox.Text = Properties.Settings.Default["team2sub"].ToString();
            team3SubNetBox.Text = Properties.Settings.Default["team3sub"].ToString();
            team1DefGatewayBox.Text = Properties.Settings.Default["team1gat"].ToString();
            team2DefGatewayBox.Text = Properties.Settings.Default["team2gat"].ToString();
            team3DefGatewayBox.Text = Properties.Settings.Default["team3gat"].ToString();
            team1nameBox.Text = Properties.Settings.Default["team1name"].ToString();
            team2nameBox.Text = Properties.Settings.Default["team2name"].ToString();
            team3nameBox.Text = Properties.Settings.Default["team3name"].ToString();
            checkBox1.Checked = (bool)Properties.Settings.Default["adapterListLimit"];
        }
    }
}
