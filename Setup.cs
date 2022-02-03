using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AeroPeek11
{
    public partial class Setup : Form
    {
        public static Peek PeekController = new Peek();

        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object Sender, EventArgs Event)
        {
            if(File.Exists("AeroPeek11.cfg") == true)
            {
                try
                {
                    this.Hide();
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.ShowInTaskbar = false;
                    this.Opacity = 0.0f;
                    this.WindowState = FormWindowState.Minimized;

                    var ReadData = File.ReadAllText("AeroPeek11.cfg");

                    var XPositionNoInteger = ReadData.ToString().Split('=')[0].ToString();
                    var YPositionNoInteger = ReadData.ToString().Split('=')[1].ToString();

                    int XPositionAsInteger = 0;
                    int YPositionAsInteger = 0;

                    PeekController.IsInSetupMode = false;
                    
                    if(int.TryParse(XPositionNoInteger.ToString(), out int XInteger) == true)
                    {
                        if(int.TryParse(YPositionNoInteger.ToString(), out int YInteger) == true)
                        {
                            XPositionAsInteger = XInteger;
                            YPositionAsInteger = YInteger;
                        }
                    }

                    Peek RealPeek = new Peek();
                    RealPeek.BackColor = Color.Maroon;
                    RealPeek.IsInSetupMode = false;
                    RealPeek.WindowState = FormWindowState.Normal;
                    RealPeek.StartPosition = FormStartPosition.Manual;
                    RealPeek.BringToFront();
                    RealPeek.Location = new Point(XPositionAsInteger, YPositionAsInteger);
                    RealPeek.Show();
                }
                catch(Exception ReadDataError)
                {
                    var ParseError = "Failed to properly read configuration settings. Here is the error report:\n\n" + ReadDataError.ToString();

                    MessageBox.Show("An error has occurred and the configuration file could not be read from. Make sure the program isn't in a place that it can't create files.\n\nAeroPeek11 should not be ran as an administrator. Place the program in a place that does not require administrator permissions to create, delete, or write files.", "AeroPeek11 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    DialogResult = MessageBox.Show("Would you like to view an error report? This could help for debugging purposes.\n\nThese error reports help if you are making an issue.", "View Error Report?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if(DialogResult == DialogResult.Yes == true)
                    {
                        MessageBox.Show(ParseError.ToString(), "Error Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void PositionButton_Click(object Sender, EventArgs Event)
        {
            SaveSettingsButton.Enabled = true;

            PeekController.IsInSetupMode = true;
            PeekController.Show();
        }

        private void HelpButton_Click(object Sender, EventArgs Event)
        {
            MessageBox.Show("Click the 'Position Peek' button. This will show a window. Move this window around and place it where the original Aero Peek position is. This position is usually at the end of the task-bar.\n\nOnce completed, click the 'Save Position Settings' button to save the position for future purposes. The program will automatically restart and the settings will take effect.\n\nTo change your settings, delete the configuration file that was created.", "AeroPeek11 Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveSettingsButton_Click(object Sender, EventArgs Event)
        {
            try
            {
                var PositionInformationNoFormat = PeekController.Location.X.ToString() + "=" + PeekController.Location.Y.ToString();
                var PositionInformationFormat = PositionInformationNoFormat.Split('=');

                var XPosition = PositionInformationFormat[0].ToString();
                var YPosition = PositionInformationFormat[1].ToString();

                MessageBox.Show("Your current settings for the X and Y position location for the peek area is as follows:\n\n" + "X Position: " + XPosition.ToString() + "\nY Position: " + YPosition.ToString() + "\n\nClick 'OK' to continue with these settings.", "Setting Overview", MessageBoxButtons.OK, MessageBoxIcon.Information);

                File.WriteAllText("AeroPeek11.cfg", XPosition.ToString() + "=" + YPosition.ToString());

                Application.Restart();
            }
            catch(Exception FailToSaveError)
            {
                var ParseError = "Failed to properly save configuration settings. Here is the error report:\n\n" + FailToSaveError.ToString();

                MessageBox.Show("An error has occurred and the configuration file could not be saved. Make sure the program isn't in a place that it can't create files.\n\nAeroPeek11 should not be ran as an administrator. Place the program in a place that does not require administrator permissions to create, delete, or write files.", "AeroPeek11 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult = MessageBox.Show("Would you like to view an error report? This could help for debugging purposes.\n\nThese error reports help if you are making an issue.", "View Error Report?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(DialogResult == DialogResult.Yes == true)
                {
                    MessageBox.Show(ParseError.ToString(), "Error Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }

                return;
            }
        }
    }
}