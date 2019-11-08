using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ASControllerSDK;

namespace ControllerSample2
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        AromaShooterController controller = AromaShooterController.SharedInstance;

        List<AromaPort> ports = new List<AromaPort>();
        List<int> intPorts = new List<int>();

        TextBox[] txtBoxIntensities = new TextBox[8];
        TextBox txtBoxDuration;

        int duration = 0;
        int boosterIntensity = 0;
        int fanIntensity = 0;

        public MainWindow()
        {
            InitializeComponent();
            controller.Setup();
        }

        private void BtnDiffuseWithIntensity_Click(object sender, RoutedEventArgs e)
        {
            ports.Clear();

            Grid grid = (sender as Button).Parent as Grid;
            txtBoxDuration = grid.Children[12] as TextBox;

            try
            {
                duration = Int32.Parse(txtBoxDuration.Text);
            }
            catch (Exception x)
            {
                duration = 0;
                System.Diagnostics.Debug.Write(x.StackTrace);
            }

            txtBoxIntensities[0] = grid.Children[11] as TextBox;
            txtBoxIntensities[1] = grid.Children[13] as TextBox;
            txtBoxIntensities[2] = grid.Children[14] as TextBox;
            txtBoxIntensities[3] = grid.Children[15] as TextBox;
            txtBoxIntensities[4] = grid.Children[16] as TextBox;
            txtBoxIntensities[5] = grid.Children[17] as TextBox;
            txtBoxIntensities[6] = grid.Children[18] as TextBox;
            txtBoxIntensities[7] = grid.Children[19] as TextBox;
            TextBox txtBoxPortList = grid.Children[21] as TextBox;


            char[] separator = { ',' };
            String[] portNumbers = txtBoxPortList.Text.Split(separator);

            foreach (String portNumber in portNumbers)
            {
                int number = -1;
                int intensity = 0;
                Boolean parseSuccess = false;
                try
                {
                    number = Int32.Parse(portNumber);
                    parseSuccess = true;
                }
                catch (Exception x)
                {
                    System.Diagnostics.Debug.Write(x.StackTrace);
                }

                if (parseSuccess)
                {
                    if (number >= 1 && number <= 6)
                    {
                        AromaPort port = new AromaPort();
                        port.number = number;

                        try
                        {
                            intensity = Int32.Parse(txtBoxIntensities[number].Text);
                        }
                        catch (Exception x)
                        {
                            intensity = 0;
                            System.Diagnostics.Debug.Write(x.StackTrace);
                        }

                        port.intensity = intensity;

                        ports.Add(port);
                    }
                    else if (number == 0) // booster
                    {
                        try
                        {
                            boosterIntensity = Int32.Parse(txtBoxIntensities[0].Text);
                        }
                        catch (Exception x)
                        {
                            boosterIntensity = 0;
                            System.Diagnostics.Debug.Write(x.StackTrace);
                        }
                    }
                    else if (number == 7) // dcfan
                    {
                        try
                        {
                            fanIntensity = Int32.Parse(txtBoxIntensities[7].Text);
                        }
                        catch (Exception x)
                        {
                            fanIntensity = 0;
                            System.Diagnostics.Debug.Write(x.StackTrace);
                        }
                    }
                }
            }

            controller.Diffuse(duration, ports, boosterIntensity, fanIntensity);
        }

        private void BtnStopAll_Click(object sender, RoutedEventArgs e)
        {
            controller.Stop();
            //controller.Stop("ASN2A000X4");
            //controller.Stop("ASN2A000X4", new int[] { 1, 2 }, true, true);
            //controller.Stop(new int[] { 1, 2 }, true, true);
        }

        private void BtnDiffuse_Click(object sender, RoutedEventArgs e)
        {
            Boolean booster = false;

            intPorts.Clear();

            Grid grid = (sender as Button).Parent as Grid;
            txtBoxDuration = grid.Children[12] as TextBox;

            try
            {
                duration = Int32.Parse(txtBoxDuration.Text);
            }
            catch (Exception x)
            {
                duration = 0;
                System.Diagnostics.Debug.Write(x.StackTrace);
            }

            TextBox txtBoxPortList = grid.Children[21] as TextBox;

            char[] separator = { ',' };
            String[] portNumbers = txtBoxPortList.Text.Split(separator);

            foreach (String portNumber in portNumbers)
            {
                int number = -1;
                Boolean parseSuccess = false;
                try
                {
                    number = Int32.Parse(portNumber);
                    parseSuccess = true;
                }
                catch (Exception x)
                {
                    System.Diagnostics.Debug.Write(x.StackTrace);
                }

                if (parseSuccess)
                {
                    if (number >= 1 && number <= 6)
                    {
                        intPorts.Add(number);
                    }
                    else if (number == 0)
                    {
                        booster = true;
                    }
                }
            }

            controller.Diffuse(duration, intPorts.ToArray(), booster);
        }
    }
}
