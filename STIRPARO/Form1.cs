//#define STIRPARO

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using NgFramework;

namespace STIRPARO
{
    public partial class Form1 : Form
    {
        NgFramework.AGMng AGq = null;
        Ping ping = new Ping();
        PingReply reply;
        string ipAddress = "10.0.0.80";
        bool aspoPanelEnabled = false;
        bool straightenerlEnabled = false;
        bool profilingPanelEnabled = false;
        bool shearPanelEnabled = false;
        public Form1()
        {
            InitializeComponent();
        }

        public void creaoggetto()
        {
            AGq = new NgFramework.AGMng();
            AGq.IpAddr = "10.0.0.80";
            AGq.IPPort = 6000;
            AGq.PortType = NgFramework.AGMng.TpcCon.ETHERNET;
            try
            {
                AGq.Connect();
            }
            catch (System.Exception)
            {
                MessageBox.Show("PLC non connesso.", "Error");

            }
        }


        private void aspoEnableButton_Click(object sender, EventArgs e)
        {
            if (!aspoPanelEnabled)
            {
                aspoPanel.Enabled = true;
                aspoEnableButton.Text = "DISABLE";
                aspoPanelEnabled = true;
            }
            else
            {
                aspoPanel.Enabled = false;
                aspoEnableButton.Text = "ENABLE";
                aspoPanelEnabled = false;
            }
        }

        private void straightenerEnableButton_Click(object sender, EventArgs e)
        {
            if (!straightenerlEnabled)
            {
                straightenerPanel.Enabled = true;
                straightenerEnableButton.Text = "DISABLE";
                straightenerlEnabled = true;

            }
            else
            {
                straightenerPanel.Enabled = false;
                straightenerEnableButton.Text = "ENABLE";
                straightenerlEnabled = false;
            }
        }

        private void profilingEnableButton_Click(object sender, EventArgs e)
        {
            if (!profilingPanelEnabled)
            {
                profilingPanel.Enabled = true;
                profilingEnableButton.Text = "DISABLE";
                profilingPanelEnabled = true;

            }
            else
            {
                profilingPanel.Enabled = false;
                profilingEnableButton.Text = "ENABLE";
                profilingPanelEnabled = false;
            }
        }

        private void shearEnableButton_Click(object sender, EventArgs e)
        {
            if (!shearPanelEnabled)
            {
                shearPanel.Enabled = true;
                shearEnableButton.Text = "DISABLE";
                shearPanelEnabled = true;

            }
            else
            {
                shearPanel.Enabled = false;
                shearEnableButton.Text = "ENABLE";
                shearPanelEnabled = false;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            reply = ping.Send(ipAddress);
            if (reply.Status == IPStatus.Success)
            {
                AGq.Connect();
                string message = "Connesso";
                string title = "Connesso";
                DialogResult result = MessageBox.Show(message, title);
            }
            else
            {
                string message = "Macchina non connessa";
                string title = "Errore di connessione";
                DialogResult result = MessageBox.Show(message, title);
            }
#endif
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }


        private void aspoRightButton_MouseDown(object sender, EventArgs e)
        {
            aspoRightButton.BackColor = Color.Green;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_AVANZA_COIL = 1;
#endif
        }

        private void aspoRightButton_MouseUp(object sender, EventArgs e)
        {
            aspoRightButton.BackColor = Color.Red ;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 0;
            AGq.VARS.VAR_ASPO_AVANZA_COIL = 0;
#endif
        }
        private void aspoRightButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_AVANZA_COIL = 1;
#endif

        }

        private void aspoLeftButton_MouseDown(object sender, EventArgs e)
        {
            aspoLeftButton.BackColor = Color.Green;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_INDIETRO_COIL = 1;
#endif
        }

        private void aspoLeftButton_MouseUp(object sender, EventArgs e)
        {
            aspoLeftButton.BackColor = Color.Red;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 0;
            AGq.VARS.VAR_ASPO_INDIETRO_COIL = 0;
#endif
        }
        private void aspoLeftButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_INDIETRO_COIL = 1;
#endif
        }


        private void aspoForwardButton_MouseDown(object sender, EventArgs e)
        {
            aspoForwardButton.BackColor = Color.Green;
#if STIRPARO
            //INVERTER ASPO AVANTI
            AGq.VARS.VAR_ASPO_START = 1;
#endif
        }

        private void aspoForwardButton_MouseUp(object sender, EventArgs e)
        {
            aspoForwardButton.BackColor = Color.Red;
#if STIRPARO
            //INVERTER ASPO AVANTI
            AGq.VARS.VAR_ASPO_START = 0;
#endif
        }
        private void aspoForwardButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            //INVERTER ASPO AVANTI
            AGq.VARS.VAR_ASPO_START = 1;
#endif
        }

        private void aspoBackwardButton_MouseDown(object sender, EventArgs e)
        {
            aspoBackwardButton.BackColor = Color.Green;
#if STIRPARO
            //INVERTER ASPO INDIETRO
            AGq.VARS.VAR_ASPO_START = 1;
#endif
        }

        private void aspoBackwardButton_MouseUp(object sender, EventArgs e)
        {
            aspoBackwardButton.BackColor = Color.Red;
#if STIRPARO
            //INVERTER ASPO INDIETRO
            AGq.VARS.VAR_ASPO_START = 0;
#endif
        }
        private void aspoBackwardButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            //INVERTER ASPO INDIETRO
            AGq.VARS.VAR_ASPO_START = 1;
#endif
        }
        private void aspoOpenButton_MouseDown(object sender, EventArgs e)
        {
            aspoOpenButton.BackColor = Color.Green;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_BLOCCA_COIL = 1;
#endif
        }

        private void aspoOpenButton_MouseUp(object sender, EventArgs e)
        {
            aspoOpenButton.BackColor = Color.Red;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 0;
            AGq.VARS.VAR_ASPO_BLOCCA_COIL = 0;
#endif
        }
        private void aspoOpenButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_BLOCCA_COIL = 1;
#endif
        }

        private void aspoCloseButton_MouseDown(object sender, EventArgs e)
        {
            aspoCloseButton.BackColor = Color.Green;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_SBLOCCA_COIL = 1;
#endif
        }

        private void aspoCloseButton_MouseUp(object sender, EventArgs e)
        {
            aspoCloseButton.BackColor = Color.Red;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 0;
            AGq.VARS.VAR_ASPO_SBLOCCA_COIL = 0;
#endif
        }
        private void aspoCloseButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_SBLOCCA_COIL = 1;
#endif
        }

        private void aspoUpButton_MouseDown(object sender, EventArgs e)
        {
            aspoUpButton.BackColor = Color.Green;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_ALZA_COIL = 1;
#endif
        }

        private void aspoUpButton_MouseUp(object sender, EventArgs e)
        {
            aspoUpButton.BackColor = Color.Red;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 0;
            AGq.VARS.VAR_ASPO_ALZA_COIL = 0;
#endif
        }
        private void aspoUpButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_ALZA_COIL = 1;
#endif
        }

        private void aspoDownButton_MouseDown(object sender, EventArgs e)
        {
            aspoDownButton.BackColor = Color.Green;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_ABBASSA_COIL = 1;
#endif
        }

        private void aspoDownButton_MouseUp(object sender, EventArgs e)
        {
            aspoDownButton.BackColor = Color.Red;
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_ABBASSA_COIL = 1;
#endif
        }
        private void aspoDownButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            AGq.VARS.VAR_ASPO_CENTRALINA_START = 1;
            AGq.VARS.VAR_ASPO_ABBASSA_COIL = 1;
#endif
        }



        private void straightnerBackwardButton_MouseDown(object sender, EventArgs e)
        {
            straightnerBackwardButton.BackColor = Color.Green;
#if STIRPARO
            //INVERTER RADDRIZZATRICE INDIETRO
            AGq.VARS.VAR_RADD_START = 1;
#endif
        }

        private void straightnerBackwardButton_MouseUp(object sender, EventArgs e)
        {
            straightnerBackwardButton.BackColor = Color.Red;
#if STIRPARO
            //INVERTER RADDRIZZATRICE INDIETRO
            AGq.VARS.VAR_RADD_START = 0;
#endif
        }
        private void straightnerBackwardButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            //INVERTER RADDRIZZATRICE INDIETRO
            AGq.VARS.VAR_RADD_START = 1;
#endif

        }
        private void straightnerForwardButton_MouseDown(object sender, EventArgs e)
        {
            straightnerForwardButton.BackColor = Color.Green;
#if STIRPARO
            //INVERTER RADDRIZZATRICE AVANTI
            AGq.VARS.VAR_RADD_START = 1;
#endif
        }

        private void straightnerForwardButton_MouseUp(object sender, EventArgs e)
        {
            straightnerForwardButton.BackColor = Color.Red;
#if STIRPARO
            //INVERTER RADDRIZZATRICE AVANTI
            AGq.VARS.VAR_RADD_START = 0;
#endif
        }
        private void straightnerForwardButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            //INVERTER RADDRIZZATRICE INDIETRO
            AGq.VARS.VAR_RADD_START = 1;
#endif
        }

        private void profilingForwardButton_MouseDown(object sender, EventArgs e)
        {
            profilingForwardButton.BackColor = Color.Green;
#if STIRPARO
            //INVERTER PROFILATRICE AVANTI
            AGq.VARS.VAR_PROF_START = 1;
#endif
        }

        private void profilingForwardButton_MouseUp(object sender, EventArgs e)
        {
            profilingForwardButton.BackColor = Color.Red;
#if STIRPARO
            //INVERTER PROFILATRICE AVANTI
            AGq.VARS.VAR_PROF_START = 0;
#endif
        }
        private void profilingForwardButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            //INVERTER PROFILATRICE AVANTI
            AGq.VARS.VAR_PROF_START = 1;
#endif
        }

        private void profilingBackwardButton_MouseDown(object sender, EventArgs e)
        {
            profilingBackwardButton.BackColor = Color.Green;
#if STIRPARO
            //INVERTER PROFILATRICE INDIETRO
            AGq.VARS.VAR_PROF_START = 1;
#endif
        }

        private void profilingBackwardButton_MouseUp(object sender, EventArgs e)
        {
            profilingBackwardButton.BackColor = Color.Red;
#if STIRPARO
            //INVERTER PROFILATRICE INDIETRO
            AGq.VARS.VAR_PROF_START = 0;
#endif
        }
        private void profilingBackwardButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            //INVERTER PROFILATRICE INDIETRO
            AGq.VARS.VAR_PROF_START = 1;
#endif
        }

        private void shearUpButton_MouseDown(object sender, EventArgs e)
        {
            shearUpButton.BackColor = Color.Green;
#if STIRPARO
            //INVERTER CESOIA SU
            //AGq.VARS.VAR_CESOIA_START = 1;
#endif
        }

        private void shearUpButton_MouseUp(object sender, EventArgs e)
        {
            shearUpButton.BackColor = Color.Red;
#if STIRPARO
            //INVERTER CESOIA SU
            //AGq.VARS.VAR_CESOIA_START = 0;
#endif
        }
        private void shearUpButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            //INVERTER CESOIA SU
            //AGq.VARS.VAR_CESOIA_START = 1;
#endif
        }

        private void shearDownButton_MouseDown(object sender, EventArgs e)
        {
            shearDownButton.BackColor = Color.Green;
#if STIRPARO
            //INVERTER CESOIA GIU
            //AGq.VARS.VAR_CESOIA_START = 1;
#endif
        }

        private void shearDownButton_MouseUp(object sender, EventArgs e)
        {
            shearDownButton.BackColor = Color.Red;
#if STIRPARO
            //INVERTER CESOIA GIU
            //AGq.VARS.VAR_CESOIA_START = 0;
#endif
        }
        private void shearDownButton_Click(object sender, EventArgs e)
        {
#if STIRPARO
            //INVERTER CESOIA GIU
            //AGq.VARS.VAR_CESOIA_START = 1;
#endif
        }

        private void straightenerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
