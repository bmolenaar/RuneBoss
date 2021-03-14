using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Reflection;


namespace RuneBoss_V2
{

    public partial class Form1 : Form
    {
        string dir = Directory.GetCurrentDirectory() + "\\Images";
        int BTN_WIDTH = 60;
        int BTN_HEIGHT = 60;
        int INVENTORY_SIZE = 28;
        List<String> itemNames = new List<string>();
        public List<Button> items = new List<Button>();
        public List<PictureBox> inv = new List<PictureBox>();
        public List<PictureBox> gear = new List<PictureBox>();


        public Form1()
        {
            InitializeComponent();
            
        }

        /*
         The main loading class 
         Contains all calls to methods which populate various
         part of the application.
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            
            AllowDrop = true;
            tpMelee.AutoScroll = true;
            tpRanged.AutoScroll = true;
            tpMage.AutoScroll = true;
            PictureBox[] equippedItems = { pbHead, pbNeck, pbAmmo, pbCape, pbBody, pbWeapon, pbShield, pbLegs, pbFeet, pbRing, pbHands };
            gear.AddRange(equippedItems);

            CreateButtons(dir + "\\Supplies", Directory.GetFiles(dir + "\\Supplies", "*").Length, tcItemList.TabPages["tpSupplies"]);
            CreateButtons(dir + "\\MageGear", Directory.GetFiles(dir + "\\MageGear", "*").Length, tcItemList.TabPages["tpMage"]);
            CreateButtons(dir + "\\MeleeGear", Directory.GetFiles(dir + "\\MeleeGear", "*").Length, tcItemList.TabPages["tpMelee"]);
            CreateButtons(dir + "\\RangeGear", Directory.GetFiles(dir + "\\RangeGear", "*").Length, tcItemList.TabPages["tpRanged"]);
            CreateButtons(dir + "\\Misc", Directory.GetFiles(dir + "\\Misc", "*").Length, tcItemList.TabPages["tpMisc"]);

            CreateItemList(dir + "\\Supplies");
            CreateItemList(dir + "\\MageGear");
            CreateItemList(dir + "\\MeleeGear");

            MakeGearPanel();
            CreateBoxes(INVENTORY_SIZE);
            gbInv.SendToBack();

            BuildToolstrip();

        }

         /*
         The button creation class
         Creates item buttons to drag/drop
         Parameters: location = filesystem location of images to load
                     amtButtons = amount of buttons to create
                     control = where to add the buttons
         */
        private void CreateButtons(string location, int amtButtons, Control control)
        {
            var loc = tcItemList.Location;
            var xLoc = loc.X - 10;
            var yLoc = loc.Y - 60;

            for (int i = 0; i < amtButtons; i++)
            {
                Button btn = new Button();
                btn.Width = BTN_WIDTH;
                btn.Height = BTN_HEIGHT;
                btn.Location = new Point(xLoc, yLoc);
                btn.BringToFront();
                btn.BackgroundImage = Image.FromFile(ImagePaths(location)[i]);
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.Transparent;
                btn.Name = Path.GetFileNameWithoutExtension(ImagePaths(location)[i]);
                MyToolTip.SetToolTip(btn, Path.GetFileNameWithoutExtension(ImagePaths(location)[i]));
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.MouseDown += new MouseEventHandler(btn_MouseDown);
                items.Add(btn);

                
                if (xLoc < 300)
                {
                    xLoc += 65;
                }
                else
                {
                    xLoc = loc.X - 10;
                    yLoc += 60;
                }
                control.Controls.Add(btn);
            }

        }

         /*
         The Inventory creation class
         Creates an array of PictureBoxes which take drag/drop input
         Parameters: amtButtons = amount of buttons to create
         */
        private void CreateBoxes(int amtButtons)
        {
            var loc = gbInv.Location;
            var xLoc = loc.X + 10;
            var yLoc = loc.Y + 20;

            for (int i = 0; i < amtButtons; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = BTN_WIDTH;
                pb.Height = BTN_HEIGHT;
                pb.Location = new Point(xLoc, yLoc);
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.AllowDrop = true;
                pb.DragEnter += new DragEventHandler(picDropTarget_DragEnter);
                pb.DragDrop += new DragEventHandler(picDropTarget_DragDrop);

                pb.BackgroundImageLayout = ImageLayout.Stretch;
                pb.MouseDown += new MouseEventHandler(pb_MouseDown);
                
                if (xLoc < 650)
                {
                    xLoc += 65;
                }
                else
                {
                    xLoc = loc.X + 10;
                    yLoc += 70;
                }
                inv.Add(pb);
                this.Controls.Add(pb);
            }
            
        }

         /*
         The Gear panel creation class
         Creates the gear panel and populates with some default images
         */
        private void MakeGearPanel()
        {
            
            string[] imgs = Directory.GetFiles(dir, "*.jpg");

            for (int i = 0; i < gear.Count; i++)
            {
                for (int j = 0; j < imgs.Length; j++)
                {
                    if (imgs[i].Contains(gear[j].Name.Substring(2)) )
                    {
                        gear[j].BackgroundImage = Image.FromFile(imgs[i]);
                        gear[j].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
            }

            foreach (var pb in gear)
            {
                pb.AllowDrop = true;
                pb.DragEnter += new DragEventHandler(picDropTarget_DragEnter);
                pb.DragDrop += new DragEventHandler(picDropTarget_DragDrop1);
            }
        }

        /*
         Gets all image names from the specified location
         and adds them to a List
         Parameters: path = Filesystem path of the images
         */
        private void CreateItemList(string path)
        {
            foreach (var item in Directory.GetFiles(path, "*.jpg"))
            {
                itemNames.Add(Path.GetFileNameWithoutExtension(item));
            }
        }

        /*
         Updates the showiung images depending on the text
         the user has entered into the search box. Sets the
         visibility of items if they contain the string
         */
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in items)
            {

                if (!item.Name.ToUpper().Contains(tbSearch.Text.ToUpper()))
                {
                    item.Visible = false;
                }
                else
                {
                    item.Visible = true;
                }

                if (tbSearch.Text == "" || tbSearch.Text == null)
                {
                    item.Visible = true;
                }
            }

        }

        /*
         Enables the button drag/drop effect on click
         */
        void btn_MouseDown(object sender, EventArgs e)
        {
            Button destination = (Button)sender;
            DoDragDrop(destination.BackgroundImage, DragDropEffects.Copy);
        }

        /*
         Enables drag/drop for inventory and clears the
         image on right click
         */
        void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox destination = (PictureBox)sender;
            if (destination.BackgroundImage != null)
            {
                DoDragDrop(destination.BackgroundImage, DragDropEffects.Copy);
            }

            if (e.Button == MouseButtons.Right)
            {
                destination.BackgroundImage = null;
                              
            }

        }

         /*
         Accepts the drag/drop if it is the correct format
         */
        private void picDropTarget_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

         /*
            Changes background image on drop
         */
        private void picDropTarget_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox destination = (PictureBox)sender;
            destination.BackgroundImage = (Bitmap)e.Data.GetData(typeof(Bitmap));
        }

        private void picDropTarget_DragDrop1(object sender, DragEventArgs e)
        {
            PictureBox destination = (PictureBox)sender;
            destination.BackgroundImage = (Bitmap)e.Data.GetData(typeof(Bitmap));
        }

        /*
            Gets all files from the specified path
            Paramters: path = where to get the images
         */
        private static string[] ImagePaths(string path)
        {
            return Directory.GetFiles(path, "*.jpg");
        }

        /*
            Converts a bitmap image to a hashed string
            for storing into a text file
            Paramters: image = image to convert
         */
        public string GetStringFromImage(Image image)
        {
            using (MemoryStream m = new MemoryStream())
            {
                if (image != null)
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
                else
                {
                    return null;
                }

            }

           
        }

        /*
            Converts a hashed string to a bitmap image
            for reading from a text file
            Paramters: base64String = string to convert
         */
        public Image GetImageFromString(string base64String)
        {
            if (!string.IsNullOrWhiteSpace(base64String))
            {
                Byte[] buffer = Convert.FromBase64String(base64String);
                if (buffer != null)
                {
                    ImageConverter ic = new ImageConverter();
                    return ic.ConvertFrom(buffer) as Image;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /*
            Open the save form
         */
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        /*
            Method for building the toolstrip items on form load
            and on save. Fairly rigid and hard-coded but it works
            for now. 
            Parameters: menuItem = Toolstrip item to create
                        activity = Header to create the item under
         */
        public void BuildMenuItems(string menuItem, string activity)
        {
            switch (activity)
            {
                case "Boss":
                    bool found = false;
                    for (int i = 0; i < tsBoss.DropDownItems.Count; i++)
                    {
                        
                        if (tsBoss.DropDownItems[i].Text == menuItem)
                        {
                            found = true;
                        }
                    }

                    if (!found == true)
                    {
                        tsBoss.DropDownItems.Add(menuItem);
                    }

                    for (int i = 0; i < tsBoss.DropDownItems.Count; i++)
                    {

                        tsBoss.DropDownItems[i].Click -= new EventHandler(button1_Click_1);
                        tsBoss.DropDownItems[i].Click += new EventHandler(button1_Click_1);
                        tsBoss.DropDownItems[i].Tag = "boss";

                    }

                    break;

                case "Slayer":
                    found = false;
                    for (int i = 0; i < tsSlayer.DropDownItems.Count; i++)
                    {

                        if (tsSlayer.DropDownItems[i].Text == menuItem)
                        {
                            found = true;
                        }
                    }

                    if (!found == true)
                    {
                        tsSlayer.DropDownItems.Add(menuItem);
                    }

                    for (int i = 0; i < tsSlayer.DropDownItems.Count; i++)
                    {

                        tsSlayer.DropDownItems[i].Click -= new EventHandler(button1_Click_1);
                        tsSlayer.DropDownItems[i].Click += new EventHandler(button1_Click_1);
                        tsSlayer.DropDownItems[i].Tag = "slay";

                    }
                    break;

                case "Skilling":

                    found = false;
                    for (int i = 0; i < tsSkilling.DropDownItems.Count; i++)
                    {

                        if (tsSkilling.DropDownItems[i].Text == menuItem)
                        {
                            found = true;
                        }
                    }

                    if (!found == true)
                    {
                        tsSkilling.DropDownItems.Add(menuItem);
                    }

                    for (int i = 0; i < tsSkilling.DropDownItems.Count; i++)
                    {

                        tsSkilling.DropDownItems[i].Click -= new EventHandler(button1_Click_1);
                        tsSkilling.DropDownItems[i].Click += new EventHandler(button1_Click_1);
                        tsSkilling.DropDownItems[i].Tag = "skil";

                    }
                    break;

                default:
                    break;
            }

        }

        
        private void btnResetInv_Click(object sender, EventArgs e)
        {
            ResetInventory();
        }

        
        private void btnResetGear_Click(object sender, EventArgs e)
        {
            ResetGear();
        }


        private void btnResetAll_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        /*
            Clears all the inventory images
         */
        private void ResetInventory()
        {
            foreach (var item in inv)
            {
                item.BackgroundImage = null;
            }
            for (int i = 0; i < inv.Count; i++)
            {
                if (inv[i].BackgroundImage == null)
                {
                    Properties.Settings.Default.Inventory[i] = null;
                }
            }
            Properties.Settings.Default.Save();

        }

        /*
            Resets all gear images back to default
         */
        private void ResetGear()
        {
            MakeGearPanel();
        }

        /*
            Resets entire form back to default
         */
        public void ResetAll()
        {
            ResetInventory();
            ResetGear();
        }


        public string menuName;
        public string equipName;

        /*
            Sets variables so the correct file is read depending
            on which menu item is pressed. Fairly rigid but it works.
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedButton = (ToolStripMenuItem)sender;
            menuName = clickedButton.Tag + "_" + clickedButton.Text;
            equipName = "g_" + clickedButton.Text;
            Form3 f3 = new Form3();
            f3.Show();
        }

        /*
            Build the toolstrip items on form load from
            pre-existing saved items. Hard-coded
         */
        private void BuildToolstrip()
        {
            List<string> txtFiles = new List<string>();

            txtFiles.AddRange(Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt"));

            foreach (var f in txtFiles)
            {
                string sub = Path.GetFileNameWithoutExtension(f).Substring(5);

                if (f.Contains("boss"))
                {
                    BuildMenuItems(sub, "Boss");
                }
                else if (f.Contains("slay"))
                {
                    BuildMenuItems(sub, "Slayer");
                }
                else if (f.Contains("skil"))
                {
                    BuildMenuItems(sub, "Skilling");
                }
            }
        }

        /*
            Resets entire form back to default
         */
        public void WipeForm()
        {
            for (int i = 0; i < inv.Count; i++)
            {
                inv[i].BackgroundImage = null;
            }
            MakeGearPanel();
        }

        /*
            Exits the form
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
