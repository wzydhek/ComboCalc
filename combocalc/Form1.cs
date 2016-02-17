using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace combocalc
{
    public partial class Form1 : Form
    {
        string[] resins = new string[] {
                "Anaxi",
                "Arconis",
                "Ash Palm",
                "Beetlenut",
                "Bloodbark",
                "Bottle Tree",
                "Bramble Hedge",
                "Broadleaf Palm",
                "Butterleaf Tree",
                "Cerulean Blue",
                "Chakkanut Tree",
                "Chicory",
                "Cinnar",
                "Coconut Palm",
                "Cricklewood",
                "Delta Palm",
                "Elephantia",
                "Feather Tree",
                "Fern Palm",
                "Folded Birch",
                "Giant Cricklewood",
                "Hawthorn",
                "Hokkaido",
                "Kaeshra",
                "Locust Palm",
                "Mini Palmetto",
                "Miniature Fern Palm",
                "Monkey Palm",
                "Oil Palm",
                "Oleaceae",
                "Orrorin",
                "Passam",
                "Phoenix Palm",
                "Pratyeka Tree",
                "Ranyahn",
                "Razor Palm",
                "Red Maple",
                "Royal Palm",
                "Savaka",
                "Spiked Fishtree",
                "Spindle Tree",
                "Stout Palm",
                "Tapacae Miralis",
                "Tiny Oil Palm",
                "Towering Palm",
                "Trilobellia",
                "Umbrella Palm",
                "Windriver Palm",
                "Powdered Diamond",
                "Powdered Emerald",
                "Powdered Opal",
                "Powdered Quartz",
                "Powdered Ruby",
                "Powdered Sapphire",
                "Powdered Topaz",
                "Powdered Amethyst",
                "Powdered Citrine",
                "Powdered Garnet",
                "Powdered Jade",
                "Powdered Lapis",
                "Powdered Sunstone",
                "Powdered Turquoise",
                "Salts Of Aluminum",
                "Salts Of Copper",
                "Salts Of Gold",
                "Salts Of Lead",
                "Salts Of Strontium",
                "Salts Of Tin",
                "Salts Of Tungsten"
            };
        int[,] vals = new int[,] { 
                {0,23,3,0,0,0,-2,-1,-3,0,0,0},    //Anaxi
                {1,76,-3,0,-1,0,-2,3,0,0,1,0},    //Arconis
                {2,26,0,0,2,3,-2,-1,0,1,0,0},    //Ash Palm
                {3,75,0,0,-1,0,-3,0,3,-2,1,0},    //Beetlenut
                {4,69,3,-3,-1,2,1,0,0,0,0,0},    //Bloodbark
                {5,34,0,-1,0,0,2,-3,-2,1,0,0},    //Bottle Tree
                {6,65,0,-1,0,3,-3,0,1,-2,0,0},    //Bramble Hedge
                {7,86,0,0,2,0,-2,0,0,-1,2,0},    //Broadleaf Palm
                {8,18,0,-2,0,-1,0,0,-3,2,0,0},    //Butterleaf Tree
                {9,55,0,0,-1,1,2,0,3,-2,0,0},    //Cerulean Blue
                {10,74,1,-3,0,-1,0,-2,0,2,1,0},    //Chakkanut Tree
                {11,20,0,0,0,-3,-1,2,1,0,0,0},    //Chicory
                {12,85,-2,0,0,-3,-1,3,0,1,2,0},    //Cinnar
                {13,24,1,2,0,0,0,-1,0,-2,0,0},    //Coconut Palm
                {14,78,0,0,-2,3,0,-1,1,-3,1,0},    //Cricklewood
                {15,74,-2,0,0,3,-1,0,1,0,1,0},    //Delta Palm
                {16,70,0,-3,-1,-2,0,1,0,3,0,0},    //Elephantia
                {17,86,-3,-1,-2,3,0,0,0,0,2,0},    //Feather Tree
                {18,18,-2,0,0,0,0,-1,-3,2,0,0},    //Fern Palm
                {19,11,2,-1,0,0,-3,0,0,-2,0,0},    //Folded Birch
                {20,18,0,0,1,0,0,-2,-3,-1,0,0},    //Giant Cricklewood
                {21,90,-1,0,-2,-3,3,0,0,1,2,0},    //Hawthorn
                {22,30,0,1,-3,0,0,-2,-1,0,0,0},    //Hokkaido
                {23,67,-1,-3,0,0,3,0,0,0,0,0},    //Kaeshra
                {24,61,-3,0,0,1,-1,0,-2,2,0,0},    //Locust Palm
                {25,41,0,-1,3,0,-2,0,0,0,0,0},    //Mini Palmetto
                {26,41,0,1,0,-2,-1,0,-3,0,0,0},    //Miniature Fern Palm
                {27,42,-2,1,-1,0,0,0,0,0,0,0},    //Monkey Palm
                {28,9,0,0,0,0,-3,0,-1,0,0,0},    //Oil Palm
                {29,86,-3,0,-2,3,1,0,-1,0,2,0},    //Oleaceae
                {30,14,1,-3,-2,0,2,-1,0,3,0,0},    //Orrorin
                {31,39,0,0,-2,-1,0,-3,1,0,0,0},    //Passam
                {32,55,2,0,-3,-2,1,-1,0,0,0,0},    //Phoenix Palm
                {33,12,0,3,2,-1,-3,0,0,-2,0,0},    //Pratyeka Tree
                {34,80,2,0,0,-3,0,-2,1,-1,2,0},    //Ranyahn
                {35,23,3,0,-1,-2,0,0,0,2,0,0},    //Razor Palm
                {36,87,3,-2,0,1,-3,0,-1,0,2,0},    //Red Maple
                {37,41,0,-1,-2,1,0,0,0,0,0,0},    //Royal Palm
                {38,22,0,-1,2,-2,1,-3,0,3,0,0},    //Savaka
                {39,24,3,-1,1,0,2,-2,0,0,0,0},    //Spiked Fishtree
                {40,50,3,2,-3,0,-1,1,0,0,0,0},    //Spindle Tree
                {41,5,-2,3,0,-1,0,0,0,0,0,0},    //Stout Palm
                {42,6,-3,0,3,-1,1,-2,0,0,0,0},    //Tapacae Miralis
                {43,37,3,-3,-2,1,-1,0,0,0,0,0},    //Tiny Oil Palm
                {44,72,-3,-1,0,1,0,0,-2,0,0,0},    //Towering Palm
                {45,8,1,0,-2,0,-1,2,-3,0,0,0},    //Trilobellia
                {46,88,0,0,0,1,-1,-3,-2,0,2,0},    //Umbrella Palm
                {47,27,0,0,1,0,0,3,-2,-1,0,0},    //Windriver Palm
                {48,36,1,2,0,0,3,0,-1,-2,3,0},    //Powdered Diamond
                {49,49,-1,0,1,0,-2,0,0,0,3,0},    //Powdered Emerald
                {50,83,-1,-3,3,0,0,0,0,2,4,0},    //Powdered Opal
                {51,47,-2,0,-1,2,-3,0,0,3,3,0},    //Powdered Quartz
                {52,10,3,2,0,0,0,-1,0,-3,3,0},    //Powdered Ruby
                {53,52,0,3,-1,1,0,-3,2,0,3,0},    //Powdered Sapphire
                {54,73,-1,0,0,0,-2,3,2,-3,3,0},    //Powdered Topaz
                {55,3,-2,0,0,0,-1,1,-3,2,3,0},    //Powdered Amethyst
                {56,83,-2,0,-3,0,0,0,-1,0,4,0},    //Powdered Citrine
                {57,6,3,1,0,0,-1,0,2,0,3,0},    //Powdered Garnet
                {58,49,0,2,3,1,-3,-1,0,0,3,0},    //Powdered Jade
                {59,43,0,2,-2,0,-1,0,0,0,3,0},    //Powdered Lapis
                {60,9,-1,1,-2,0,0,3,2,-3,3,0},    //Powdered Sunstone
                {61,68,0,0,-1,-2,0,2,3,-3,3,0},    //Powdered Turquoise
                {69,89,0,3,-1,0,0,-2,1,-3,12,0},    //Salts Of Aluminum
                {71,71,-2,0,2,0,-1,0,3,1,6,0},    //Salts Of Copper
                {72,85,-1,-3,0,-2,0,1,0,2,12,0},    //Salts Of Gold
                {74,68,-2,-3,1,0,3,-1,0,2,6,0},    //Salts Of Lead
                {79,68,1,0,3,-3,-2,-1,0,0,6,0},    //Salts Of Strontium
                {80,81,-1,0,0,-3,0,1,0,-2,6,0},    //Salts Of Tin
                {82,89,-3,-1,0,1,-2,0,0,0,12,0}    //Salts Of Tungsten

            };

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (string r in resins)
            {
                listBox1.Items.Add(r);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Visible = false;

            List<compound> list = new List<compound>();

            int cost = int.Parse(textBox10.Text);

            for (int a1 = 0; a1 < resins.Length - 3; a1++)
            {
                if (vals[a1, 11] == -1)
                    continue;
                for (int a2 = a1 + 1; a2 < resins.Length - 2; a2++)
                {
                    if (vals[a2, 11] == -1)
                        continue;
                    for (int a3 = a2 + 1; a3 < resins.Length - 1; a3++)
                    {
                        if (vals[a3, 11] == -1)
                            continue;
                        label1.Text = list.Count.ToString();
                        Application.DoEvents();
                        for (int a4 = a3 + 1; a4 < resins.Length; a4++)
                        {
                            if (vals[a4, 11] == -1)
                                continue;

                            //for (int a5 = a4 + 1; a5 < vals.Length; a5++)
                            //{
                            if (vals[a1, 10] <= cost && vals[a2, 10] <= cost && vals[a3, 10] <= cost && vals[a4, 10] <= cost)
                            {
                                //if (a1 == 2 && a2 == 14 && a3 == 26 && a4 == 35)
                                //{
                                //    int r = 1;
                                //}
                                compound c = new compound();
                                c.Ingredient1 = a1;
                                c.Ingredient2 = a2;
                                c.Ingredient3 = a3;
                                c.Ingredient4 = a4;
                                //c.Ingredient5 = a5;
                                c.Ar = vals[a1, 2] + vals[a2, 2] + vals[a3, 2] + vals[a4, 2];
                                c.As = vals[a1, 3] + vals[a2, 3] + vals[a3, 3] + vals[a4, 3];
                                c.Bi = vals[a1, 4] + vals[a2, 4] + vals[a3, 4] + vals[a4, 4];
                                c.Sa = vals[a1, 5] + vals[a2, 5] + vals[a3, 5] + vals[a4, 5];
                                c.So = vals[a1, 6] + vals[a2, 6] + vals[a3, 6] + vals[a4, 6];
                                c.Sp = vals[a1, 7] + vals[a2, 7] + vals[a3, 7] + vals[a4, 7];
                                c.Sw = vals[a1, 8] + vals[a2, 8] + vals[a3, 8] + vals[a4, 8];
                                c.To = vals[a1, 9] + vals[a2, 9] + vals[a3, 9] + vals[a4, 9];
                                list.Add(c);
                                //}
                            }
                        }
                    }
                }
            }
            List<string> data = new List<string>();
            StringBuilder sb = new StringBuilder();
            int found = 0;
            foreach (compound c in list)
            {
                if (
                    (string.IsNullOrEmpty(textBox2.Text) || int.Parse(textBox2.Text) == c.Ar) &&
                    (string.IsNullOrEmpty(textBox3.Text) || int.Parse(textBox3.Text) == c.As) &&
                    (string.IsNullOrEmpty(textBox4.Text) || int.Parse(textBox4.Text) == c.Bi) &&
                    (string.IsNullOrEmpty(textBox5.Text) || int.Parse(textBox5.Text) == c.Sa) &&
                    (string.IsNullOrEmpty(textBox6.Text) || int.Parse(textBox6.Text) == c.So) &&
                    (string.IsNullOrEmpty(textBox7.Text) || int.Parse(textBox7.Text) == c.Sp) &&
                    (string.IsNullOrEmpty(textBox8.Text) || int.Parse(textBox8.Text) == c.Sw) &&
                    (string.IsNullOrEmpty(textBox9.Text) || int.Parse(textBox9.Text) == c.To)
                )
                {

                    //listBox1.Items.Add(string.Format("{0}-{1}-{2}-{3} {4},{5},{6},{7},{8},{9},{10},{11}", resins[c.Ingredient1], resins[c.Ingredient2], resins[c.Ingredient3], resins[c.Ingredient4], c.Ar, c.As, c.Bi, c.Sa, c.So, c.Sp, c.Sw, c.To));
                    //data.Add(string.Format("{0}-{1}-{2}-{3} {4},{5},{6},{7},{8},{9},{10},{11}", resins[c.Ingredient1], resins[c.Ingredient2], resins[c.Ingredient3], resins[c.Ingredient4], c.Ar, c.As, c.Bi, c.Sa, c.So, c.Sp, c.Sw, c.To));
                    sb.AppendLine(string.Format("{0}-{1}-{2}-{3} {4},{5},{6},{7},{8},{9},{10},{11}", resins[c.Ingredient1], resins[c.Ingredient2], resins[c.Ingredient3], resins[c.Ingredient4], c.Ar, c.As, c.Bi, c.Sa, c.So, c.Sp, c.Sw, c.To));
                    found++;
                }
            }
            textBox1.Text = sb.ToString();
            label1.Text = found.ToString();
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
                return;

            string[] items = new string[listBox2.SelectedItems.Count];
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                items[i] = (string)listBox2.SelectedItems[i];
            }
            foreach (string itm in items)
            {
                listBox1.Items.Add(itm);
                listBox2.Items.Remove(itm);
                int idx = Array.IndexOf(resins, itm);
                vals[idx, 11] = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
                return;

            string[] items = new string[listBox1.SelectedItems.Count];
            for (int i=0; i<listBox1.SelectedItems.Count; i++)
            {
                items[i] = (string)listBox1.SelectedItems[i];
            }
            foreach (string itm in items)
            {
                listBox2.Items.Add(itm);
                listBox1.Items.Remove(itm);
                int idx = Array.IndexOf(resins, itm);
                vals[idx, 11] = -1;
            }
        }
    }
    public struct compound
    {
        public int Ingredient1;
        public int Ingredient2;
        public int Ingredient3;
        public int Ingredient4;
        //public int Ingredient5;
        public int Ar;
        public int As;
        public int Bi;
        public int Sa;
        public int So;
        public int Sp;
        public int Sw;
        public int To;
    }
}
