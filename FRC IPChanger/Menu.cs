using System;
using System.Windows.Forms;
using System.Collections;
using System.Management;
using System.Threading;

namespace FRC_IPChanger
{
    public partial class IPChanger : Form
    {
        public void AppendStatus(string statusadd)
        {
            statusbox.AppendText(statusadd +"\n");
        }

        class NetworkManagement
        { 
            public static void resetIP()
            {
                ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMC.GetInstances();

                foreach (ManagementObject objMO in objMOC)
                {
                    var management = new ManagementClass("Win32_NetworkAdapterConfiguration");
                    var moc = management.GetInstances();

                    foreach (var o in moc)
                    {
                        var mo = (ManagementObject)o;
                        // if (!(bool)mo["IPEnabled"]) continue;
                        //AppendStatus("Setting DHCP on " + mo.ToString());
                        mo.InvokeMethod("EnableDHCP", null, null);
                    }
                }
            }
            /// <summary>
            /// Set's a new IP Address and it's Submask of the local machine
            /// </summary>
            /// <param name="ip_address">The IP Address</param>
            /// <param name="subnet_mask">The Submask IP Address</param>
            /// <remarks>Requires a reference to the System.Management namespace</remarks>
            /// const string networcCardName = "[00000007] Intel(R) Ethernet Connection I217-LM"; //Example NIC name
            
        public static void setIP(string ip_address, string subnet_mask, string nicName)
            {
                ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMC.GetInstances();

                foreach (ManagementObject objMO in objMOC)
                {
                    if ((bool)objMO["IPEnabled"] || (bool)Properties.Settings.Default["adapterListLimit"])
                      {
                    if (objMO["Caption"].Equals(nicName))
                        {
                            
                            try
                            {
                                ManagementBaseObject setIP;
                                ManagementBaseObject newIP =
                                    objMO.GetMethodParameters("EnableStatic");

                                newIP["IPAddress"] = new string[] { ip_address };
                                newIP["SubnetMask"] = new string[] { subnet_mask };

                                setIP = objMO.InvokeMethod("EnableStatic", newIP, null);
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }


                   }
                }
            }
            /// <summary>
            /// Set's a new Gateway address of the local machine
            /// </summary>
            /// <param name="gateway">The Gateway IP Address</param>
            /// <remarks>Requires a reference to the System.Management namespace</remarks>
            public static void setGateway(string gateway, string nicName)
            {
                ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMC.GetInstances();

                foreach (ManagementObject objMO in objMOC)
                {
                    if ((bool)objMO["IPEnabled"] || !(bool)Properties.Settings.Default["adapterListLimit"])
                    {
                        if (objMO["Caption"].Equals(nicName))
                        {
                            try
                            {
                                ManagementBaseObject setGateway;
                                ManagementBaseObject newGateway =
                                    objMO.GetMethodParameters("SetGateways");

                                newGateway["DefaultIPGateway"] = new string[] { gateway };
                                newGateway["GatewayCostMetric"] = new int[] { 1 };

                                setGateway = objMO.InvokeMethod("SetGateways", newGateway, null);
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                    }
                }
            }
            /// <summary>
            /// Set's the DNS Server of the local machine
            /// </summary>
            /// <param name="NIC">NIC address</param>
            /// <param name="DNS">DNS server address</param>
            /// <remarks>Requires a reference to the System.Management namespace</remarks>
            public static void setDNS(string NIC, string DNS)
            {
                ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMC.GetInstances();

                foreach (ManagementObject objMO in objMOC)
                {
                   if ((bool)objMO["IPEnabled"] || !(bool)Properties.Settings.Default["adapterListLimit"])
                    {
                        // if you are using the System.Net.NetworkInformation.NetworkInterface you'll need to change this line to if (objMO["Caption"].ToString().Contains(NIC)) and pass in the Description property instead of the name 
                        if (objMO["Caption"].Equals(NIC))
                        {
                            try
                            {
                                ManagementBaseObject newDNS =
                                    objMO.GetMethodParameters("SetDNSServerSearchOrder");
                                newDNS["DNSServerSearchOrder"] = DNS.Split(',');
                                ManagementBaseObject setDNS =
                                    objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                    }
                }
            }
            /// <summary>
            /// Set's WINS of the local machine
            /// </summary>
            /// <param name="NIC">NIC Address</param>
            /// <param name="priWINS">Primary WINS server address</param>
            /// <param name="secWINS">Secondary WINS server address</param>
            /// <remarks>Requires a reference to the System.Management namespace</remarks>
            public static void setWINS(string NIC, string priWINS, string secWINS)
            {
                ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMC.GetInstances();

                foreach (ManagementObject objMO in objMOC)
                {
                    if ((bool)objMO["IPEnabled"] || !(bool)Properties.Settings.Default["adapterListLimit"])
                    {
                        if (objMO["Caption"].Equals(NIC))
                        {
                            try
                            {
                                ManagementBaseObject setWINS;
                                ManagementBaseObject wins =
                                objMO.GetMethodParameters("SetWINSServer");
                                wins.SetPropertyValue("WINSPrimaryServer", priWINS);
                                wins.SetPropertyValue("WINSSecondaryServer", secWINS);

                                setWINS = objMO.InvokeMethod("SetWINSServer", wins, null);
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                            //  }
                        }
                    }
                }
            }
            public static ArrayList GetNICNames()
            {
                ArrayList nicNames = new ArrayList();

                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["ipEnabled"] || !(bool)Properties.Settings.Default["adapterListLimit"])
                    {
                        nicNames.Add(mo["Caption"]);
                    }
                }

                return nicNames;
            }
        }
        private void loadNICs()
        {
            // get the NIC names
            ArrayList nicNames = NetworkManagement.GetNICNames();

            // populate the NIC list
            adapterComboBox.Items.Clear();
            foreach (string name in nicNames)
                adapterComboBox.Items.Add(name);

            // if NIC found, select the first one
            if (adapterComboBox.Items.Count > 0)
            {
                adapterComboBox.SelectedIndex = 0;
                adapterComboBox.Enabled = true;
            }
        }
        public IPChanger()
        {
            InitializeComponent();
            loadNICs();
            team1Button.Text = Properties.Settings.Default["team1name"].ToString();
            team2Button.Text = Properties.Settings.Default["team2name"].ToString();
            team3Button.Text = Properties.Settings.Default["team3name"].ToString();
        }

        private void team1Button_Click(object sender, EventArgs e)
        {
            string nicName = adapterComboBox.SelectedItem.ToString();
            string subnetMask = Properties.Settings.Default["team1sub"].ToString();
            string iP = Properties.Settings.Default["team1ip"].ToString();
            string gateway = Properties.Settings.Default["team1gat"].ToString();
            NetworkManagement.setIP(iP, subnetMask, nicName);
            NetworkManagement.setGateway(gateway, nicName);
            AppendStatus("Setting " + nicName + " to IP " + iP + " to Gateway " + gateway +  " and to Subnet " + subnetMask);
        }

        private void team2Button_Click(object sender, EventArgs e)
        {
            string nicName = adapterComboBox.SelectedItem.ToString();
            string subnetMask = Properties.Settings.Default["team2sub"].ToString();
            string iP = Properties.Settings.Default["team2ip"].ToString();
            string gateway = Properties.Settings.Default["team2gat"].ToString();
            NetworkManagement.setIP(iP, subnetMask, nicName);
            NetworkManagement.setGateway(gateway, nicName);
            AppendStatus("Setting " + nicName + " to IP " + iP + " to Gateway " + gateway + " and to Subnet " + subnetMask);
        }

        private void team3Button_Click(object sender, EventArgs e)
        {
            string nicName = adapterComboBox.SelectedItem.ToString();
            string subnetMask = Properties.Settings.Default["team3sub"].ToString();
            string iP = Properties.Settings.Default["team3ip"].ToString();
            string gateway = Properties.Settings.Default["team3gat"].ToString();
            NetworkManagement.setIP(iP, subnetMask, nicName);
            NetworkManagement.setGateway(gateway, nicName);
            AppendStatus("Setting " + nicName + " to IP " + iP + " to Gateway " + gateway + " and to Subnet " + subnetMask);
           
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            AppendStatus("Opening Config Menu");
            var config = new Config();
            config.Show();
        }
        private void config_close(object sender, EventArgs e)
        {
            team1Button.Text = Properties.Settings.Default["team1name"].ToString();
            team2Button.Text = Properties.Settings.Default["team2name"].ToString();
            team3Button.Text = Properties.Settings.Default["team3name"].ToString();
            loadNICs();
        }

        private void resetipbutton_Click(object sender, EventArgs e)
        {
            AppendStatus("Setting ALL Adapters to DHCP Mode");
            Thread resetIPThread = new Thread(ResetIpCall);
            resetIPThread.Start();
        }
        private void ResetIpCall()
        {
            NetworkManagement.resetIP();
        }
        private void refreshnalist_Click(object sender, EventArgs e)
        {
            AppendStatus("Refreshing Network Adapters");
            loadNICs();
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            AppendStatus("Opening Help Menu");
            var HelpForm1 = new HelpForm();
            HelpForm1.Show();

        }

        private void IPChanger_Load(object sender, EventArgs e)
        {

        }
    }
}
