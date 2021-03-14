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

namespace RuneBoss_V2
{
    public partial class Form3 : Form
    {
        int BTN_WIDTH = 60;
        int BTN_HEIGHT = 60;
        int INVENTORY_SIZE = 28;
        int formCounter = 2;
        public List<PictureBox> gear = new List<PictureBox>();
        string formName;


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 mainForm = Application.OpenForms[Application.OpenForms.Count - formCounter] as Form1;
            formName = mainForm.menuName.Substring(5);
            CreateBoxes(INVENTORY_SIZE);
            PictureBox[] equippedItems = { pbHead, pbNeck, pbAmmo, pbCape, pbBody, pbWeapon, pbShield, pbLegs, pbFeet, pbRing, pbHands };
            gear.AddRange(equippedItems);
            LoadGear();
            gbInv.SendToBack();
            formCounter++;
            this.Text = formName;
            label2.Text = formName;
        }

        private void CreateBoxes(int amtButtons)
        {
            var loc = gbInv.Location;
            var xLoc = loc.X + 10;
            var yLoc = loc.Y + 20;

            try
            {
                Form1 mainForm = Application.OpenForms[Application.OpenForms.Count - formCounter] as Form1;
                string[] lines = File.ReadAllLines($"{mainForm.menuName}.txt");

                for (int i = 0; i < amtButtons; i++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Width = BTN_WIDTH;
                    pb.Height = BTN_HEIGHT;
                    pb.Location = new Point(xLoc, yLoc);
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.BackgroundImage = mainForm.GetImageFromString(lines[i]);
                    pb.BackgroundImageLayout = ImageLayout.Stretch;

                    if (xLoc < 250)
                    {
                        xLoc += 65;
                    }
                    else
                    {
                        xLoc = loc.X + 10;
                        yLoc += 70;
                    }
                    this.Controls.Add(pb);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            

        }

        private void LoadGear()
        {
            try
            {
                Form1 mainForm = Application.OpenForms[Application.OpenForms.Count - formCounter] as Form1;
                string[] equipment = File.ReadAllLines($"{mainForm.equipName}.txt");

                for (int i = 0; i < gear.Count; i++)
                {
                    gear[i].BackgroundImage = mainForm.GetImageFromString(equipment[i]);
                    gear[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
           
        }
    }
}
