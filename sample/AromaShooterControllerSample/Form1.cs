using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Import Controller SDK*/
using ASControllerSDK; 

namespace ControllerSample
{
    public partial class Form1 : Form
    {
        //Get AromaShooterController references
        private AromaShooterController aromaShooterController = AromaShooterController.sharedInstance;
        public Form1()
        {
            InitializeComponent();

            //Initalize 
            aromaShooterController.setup();
        }

        /// <summary>
        /// 
        /// Diffuse scent APIs
        /// diffuse(duration,speed,ports)
        /// - duration: time (unit: milliseconds)
        /// - ports: Array of ports to diffuse at the same time. Port: 1~6
        /// - booster: To strong push aroma
        /// </summary>
     

        private void Cartridge1_Click(object sender, EventArgs e)
        {
            aromaShooterController.diffuse(3000, new int[] { 1 }, false);
        }

        private void Cartridge2_Click(object sender, EventArgs e)
        {
            aromaShooterController.diffuse(3000, new int[] { 2}, true);
        }

        private void Cartridge3_Click(object sender, EventArgs e)
        {
            aromaShooterController.diffuse(3000, new int[] { 3 }, true);
        }

        private void Cartridge4_Click(object sender, EventArgs e)
        {
            aromaShooterController.diffuse(3000, new int[] { 4 }, true);
        }

        private void Cartridge5_Click(object sender, EventArgs e)
        {
            aromaShooterController.diffuse(3000, new int[] { 5 }, true);
        }

        private void Cartridge6_Click(object sender, EventArgs e)
        {
            aromaShooterController.diffuse(3000, new int[] { 6 }, true);
        }
    }
}
