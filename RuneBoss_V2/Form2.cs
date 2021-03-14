using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.Configuration;
using System.IO;

namespace RuneBoss_V2
{


    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        /*
            Call the Web Scraper function to scrape bosses
            and slayer tasks from the OSRS Wiki.
         */
        private void Form2_Load(object sender, EventArgs e)
        {
            
            Form1 lastForm = Application.OpenForms[Application.OpenForms.Count - 2] as Form1;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument bossSite = web.Load("https://oldschool.runescape.wiki/w/Boss#List_of_bosses");
            HtmlAgilityPack.HtmlDocument slayerTasksSite = web.Load("https://oldschool.runescape.wiki/w/Slayer_task");
            HtmlAgilityPack.HtmlDocument skillsSite = web.Load("https://oldschool.runescape.wiki/w/Skills");

            var bossNode = bossSite.DocumentNode.SelectNodes("//tr").ToList();
            var slayerNode = slayerTasksSite.DocumentNode.SelectNodes("//tr").ToList();
            var skillsNode = skillsSite.DocumentNode.SelectNodes("//tr").ToList();


            List<string> elements = new List<string>();

            foreach (var boss in GetEntityList(bossNode, elements, bossSite))
            {
                cbBosses.Items.Add(boss);
                elements.Clear();
            }

            foreach (var task in GetEntityList(slayerNode, elements, slayerTasksSite))
            {
                if (task != "(unf)")
                {
                    cbSlayer.Items.Add(task);
              
                }
                elements.Clear();
            }

        }

        /*
            Web Scraper function to get the boss and slayer task lists
            from the OSRS wiki.
         */
        private List<String> GetEntityList(List<HtmlNode> scrape, List<string> items, HtmlAgilityPack.HtmlDocument site)
        {
            List<string> allBosses = new List<string>();

            for (int i = 0; i < scrape.Count; i++)
            {
                items.Add(scrape[i].InnerText);
            }

            foreach (var f in items)
            {
                var a = f.Split('\n');
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[1] != "Name")
                    {
                        string toAdd = RemoveSpecialCharacters(a[1]);
                        allBosses.Add(toAdd);
                        break;
                    }
                    
                }

            }
            
            allBosses.Sort();
            allBosses.RemoveRange(0, 3);
            return allBosses;
        }

        /*
            Saves items to text files, updates the main form
            toolstrip and clears all items
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            Form1 lastForm = Application.OpenForms[Application.OpenForms.Count - 2] as Form1;
            WriteItems();
            BuildToolstripItems();
            lastForm.WipeForm();
        }

        /*
            Updates the toolstrip with new entires
         */
        private void BuildToolstripItems()
        {
            Form1 lastForm = Application.OpenForms[Application.OpenForms.Count - 2] as Form1;
            string bossInput = cbBosses.Text;
            string slayerInput = cbSlayer.Text;
            string skillInput = cbSkilling.Text;
            

            if (bossInput != "")
            {
                lastForm.BuildMenuItems(bossInput, lblBosses.Text);

            }

            if (slayerInput != "")
            {
                lastForm.BuildMenuItems(slayerInput, lblSlayer.Text);
            }


            if (skillInput != "")
            {
                lastForm.BuildMenuItems(skillInput, lblSkilling.Text);
            }

            this.Close();
 
        }

        /*
            Writes items in inventory and gear to text files
            Naming convention is important here
         */
        private void WriteItems()
        {
            Form1 mainForm = Application.OpenForms[Application.OpenForms.Count - 2] as Form1;
            List<string> invImagesAsStrings = new List<string>();
            List<string> gearImagesAsStrings = new List<string>();
            

            try
            {
                StreamWriter swBossInv = new StreamWriter(StreamWriter.Null.BaseStream);
                StreamWriter swSlayerInv = new StreamWriter(StreamWriter.Null.BaseStream);
                StreamWriter swSkillInv = new StreamWriter(StreamWriter.Null.BaseStream);

                StreamWriter swBossGear = new StreamWriter(StreamWriter.Null.BaseStream);
                StreamWriter swSlayerGear = new StreamWriter(StreamWriter.Null.BaseStream);
                StreamWriter swSkillGear = new StreamWriter(StreamWriter.Null.BaseStream);

                if (cbBosses.Text != "")
                {
                    swBossInv = new StreamWriter(Directory.GetCurrentDirectory() + $"\\boss_{cbBosses.Text}.txt");
                    swBossGear = new StreamWriter(Directory.GetCurrentDirectory() + $"\\g_{cbBosses.Text}.txt");
                }
                if (cbSlayer.Text != "")
                {
                    swSlayerInv = new StreamWriter(Directory.GetCurrentDirectory() + $"\\slay_{cbSlayer.Text}.txt");
                    swSlayerGear = new StreamWriter(Directory.GetCurrentDirectory() + $"\\g_{cbSlayer.Text}.txt");
                }
                if (cbSkilling.Text != "")
                {
                    swSkillInv = new StreamWriter(Directory.GetCurrentDirectory() + $"\\skil_{cbSkilling.Text}.txt");
                    swSkillGear = new StreamWriter(Directory.GetCurrentDirectory() + $"\\g_{cbSkilling.Text}.txt");
                }                              

                foreach (var item in mainForm.inv)
                {
                    invImagesAsStrings.Add(mainForm.GetStringFromImage(item.BackgroundImage));
                }

                foreach (var eq in mainForm.gear)
                {
                    gearImagesAsStrings.Add(mainForm.GetStringFromImage(eq.BackgroundImage));
                }

                foreach (var inv in invImagesAsStrings)
                {
                    if (cbBosses.Text != "")
                    {
                        swBossInv.WriteLine(inv);
                    }
                    if (cbSlayer.Text != "")
                    {
                        swSlayerInv.WriteLine(inv);
                    }
                    if (cbSkilling.Text != "")
                    {
                        swSkillInv.WriteLine(inv);
                    }
                }

                foreach (var gr in gearImagesAsStrings)
                {
                    if (cbBosses.Text != "")
                    {
                        swBossGear.WriteLine(gr);
                    }
                    if (cbSlayer.Text != "")
                    {
                        swSlayerGear.WriteLine(gr);
                    }
                    if (cbSkilling.Text != "")
                    {
                        swSkillGear.WriteLine(gr);
                    }
                }

                swBossInv.Close();
                swSlayerInv.Close();
                swSkillInv.Close();

                swBossGear.Close();
                swSlayerGear.Close();
                swSkillGear.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            
        }

        /*
            Code stolen from StackOverflow.
            Removes special characters from strings
         */
        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c == ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

    }

}
