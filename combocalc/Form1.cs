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
                "Salts Of Antimony",
                "Salts Of Copper",
                "Salts Of Gold",
                "Salts Of Iron",
                "Salts Of Lead",
                "Salts Of Lithium",
                "Salts Of Magnesium",
                "Salts Of Platinum",
                "Salts Of Strontium",
                "Salts Of Silver",
                "Salts Of Tin",
                "Salts Of Titanium",
                "Salts Of Tungsten",
                "Salts Of Zinc",
                "Powdered Aqua Pearl",
                "Powdered Black Pearl",
                "Powdered Coral Pearl",
                "Powdered Pink Pearl",
                "Powdered Smoke Pearl",
                "Powdered White Pearl",
                "Oyster Shell Marble Dust",
                "Bee Balm",
                "Black Pepper Plant",
                "Bluebottle Clover",
                "Bucklerleaf",
                "Cardamom",
                "Chatinabrae",
                "Chives",
                "Cinnamon",
                "Common Basil",
                "Common Rosemary",
                "Common Sage",
                "Covage",
                "Crampbark",
                "Crimson Lettuce",
                "Crumpled Leaf Basil",
                "Daggerleaf",
                "Dark Ochoa",
                "Digweed",
                "Discorea",
                "Dwarf Hogweed",
                "Finlow",
                "Fire Allspice",
                "Fleabane",
                "Fool's Agar",
                "Ginger Root",
                "Glechoma",
                "Harebell",
                "Hazlewort",
                "Houseleek",
                "Hyssop",
                "Indigo Damia",
                "Lemondrop",
                "Lythrum",
                "Mariae",
                "Meadowsweet",
                "Mindanao",
                "Morpha",
                "Motherwort",
                "Mountain Mint",
                "Myristica",
                "Pale Dhamasa",
                "Pale Russet",
                "Panoe",
                "Pippali",
                "Pulmonaria Opal",
                "Satsatchi",
                "Shrub Sage",
                "Shrubby Basil",
                "Silvertongue Damia",
                "Soapwort",
                "Sorrel",
                "Spinach",
                "Steel Bladegrass",
                "Stickler Hedge",
                "Strawberry Tea",
                "Sweetflower",
                "Sweetgrass",
                "Thyme",
                "Tiny Clover",
                "True Tarragon",
                "Tsangto",
                "Verdant Squill",
                "Weeping Patala",
                "Wild Lettuce",
                "Wild Onion",
                "Xanosi",
                "Yigory"
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
                {70,7,-1,0,0,2,-2,0,0,0,6,0},    //Salts Of Antimony
                {71,71,-2,0,2,0,-1,0,3,1,6,0},    //Salts Of Copper
                {72,85,-1,-3,0,-2,0,1,0,2,12,0},    //Salts Of Gold
                {73,38,0,0,-2,0,3,0,-3,-1,6,0},    //Salts Of Iron
                {74,68,-2,-3,1,0,3,-1,0,2,6,0},    //Salts Of Lead
                {75,25,0,0,-3,-2,0,-1,0,2,6,0},    //Salts Of Lithium
                {76,19,-1,0,-3,2,0,0,0,-2,6,0},    //Salts Of Magnesium
                {77,25,3,0,0,-1,-3,0,0,1,6,0},    //Salts Of Platinum
                {78,20,0,3,-2,0,0,-3,-1,1,6,0},    //Salts Of Silver
                {79,68,1,0,3,-3,-2,-1,0,0,6,0},    //Salts Of Strontium
                {80,81,-1,0,0,-3,0,1,0,-2,6,0},    //Salts Of Tin
                {81,22,-2,1,0,0,2,-1,0,-3,6,0},    //Salts Of Titanium
                {82,89,-3,-1,0,1,-2,0,0,0,12,0},    //Salts Of Tungsten
                {83,23,0,-3,-2,0,-1,0,1,2,6,0},    //Salts Of Zinc
                {62,81,2,-1,-2,0,1,0,0,3,17,0},    //Powdered Aqua Pearl
                {64,16,1,-2,3,0,-1,-3,0,0,17,0},    //Powdered Black Pearl
                {65,77,-1,1,0,0,3,2,-2,-3,17,0},    //Powdered Coral Pearl
                {66,2,0,0,-1,-3,-2,2,3,0,17,0},    //Powdered Pink Pearl
                {67,3,-3,0,1,3,-2,-1,0,2,17,0},    //Powdered Smoke Pearl
                {68,69,1,-1,-2,-3,2,0,0,0,17,0},    //Powdered White Pearl
                {103,85,-1,2,-2,3,0,-3,0,1,14,0},    //Oyster Shell Marble Dust 
                {98,87,1,-1,0,0,0,3,2,-3,24,0},    //Bee Balm
                {104,55,-3,0,2,0,3,-2,-1,1,10,0},    //Black Pepper Plant
                {115,71,1,-2,0,0,-1,0,0,2,9,0},    //Bluebottle Clover
                {119,70,-1,0,-2,3,0,0,0,-3,9,0},    //Bucklerleaf
                {127,48,2,1,0,0,0,-1,0,-2,10,0},    //Cardamom
                {130,43,1,2,-1,0,0,0,-2,3,11,0},    //Chatinabrae
                {131,73,-2,0,0,-3,-1,0,1,2,9,0},    //Chives
                {134,78,2,0,-2,1,0,3,-1,-3,10,0},    //Cinnamon
                {138,28,0,-3,-2,0,1,3,0,-1,8,0},    //Common Basil
                {139,58,3,-2,-1,1,0,0,-3,0,8,0},    //Common Rosemary
                {140,32,3,-3,-1,-2,0,0,0,0,9,0},    //Common Sage
                {142,74,0,-1,2,0,0,-2,0,0,11,0},    //Covage
                {143,84,3,-3,0,-2,0,-1,0,0,20,0},    //Crampbark
                {148,0,0,3,0,2,-3,-1,0,0,10,0},    //Crimson Lettuce
                {152,49,0,0,0,-3,0,-1,3,-2,12,0},    //Crumpled Leaf Basil
                {155,75,-3,0,-1,0,2,0,0,-2,10,0},    //Daggerleaf
                {159,21,1,0,0,-1,-3,0,-2,3,9,0},    //Dark Ochoa
                {165,63,1,0,0,-1,3,-2,-3,0,12,0},    //Digweed
                {166,52,0,2,0,1,-1,3,-3,0,8,0},    //Discorea
                {169,19,0,-1,0,-2,0,-3,1,0,10,0},    //Dwarf Hogweed
                {174,67,0,0,0,3,-1,1,-2,-3,12,0},    //Finlow
                {175,20,0,-2,-3,-1,0,0,3,2,12,0},    //Fire Allspice
                {180,10,-2,2,0,1,0,0,-1,-3,10,0},    //Fleabane
                {181,40,-1,0,0,0,3,-2,0,-3,9,0},    //Fool's Agar
                {185,65,0,-2,3,1,-3,0,-1,0,11,0},    //Ginger Root
                {188,56,0,-3,0,-2,-1,3,1,2,9,0},    //Glechoma
                {198,20,0,0,2,0,-1,0,-2,0,11,0},    //Harebell
                {200,32,3,0,0,0,0,0,-1,2,10,0},    //Hazlewort
                {206,66,0,0,-2,1,-3,0,-1,2,10,0},    //Houseleek
                {207,25,3,0,-1,2,-3,0,0,-2,10,0},    //Hyssop
                {211,51,3,1,0,-1,2,0,-2,0,9,0},    //Indigo Damia
                {227,59,0,-2,0,2,1,0,-1,0,9,0},    //Lemondrop
                {231,3,3,-1,0,-3,0,2,0,-2,10,0},    //Lythrum
                {236,89,0,0,3,0,-1,1,0,2,20,0},    //Mariae
                {237,48,-3,-2,1,0,2,0,-1,3,10,0},    //Meadowsweet
                {239,22,2,0,-1,1,-3,0,0,0,10,0},    //Mindanao
                {244,66,0,1,-1,0,-2,0,-3,0,10,0},    //Morpha
                {245,9,-3,-1,0,1,0,0,0,0,10,0},    //Motherwort
                {246,38,0,-3,0,0,3,-2,-1,0,9,0},    //Mountain Mint
                {247,70,0,-2,-1,1,0,0,0,-3,9,0},    //Myristica
                {256,29,-3,0,0,0,1,0,-1,-2,9,0},    //Pale Dhamasa
                {258,68,1,0,-1,-2,-3,0,0,0,11,0},    //Pale Russet
                {260,23,-1,1,0,0,2,-2,0,0,11,0},    //Panoe
                {264,1,0,0,-1,1,0,2,-2,0,11,0},    //Pippali
                {268,45,0,-2,-3,-1,0,1,2,0,11,0},    //Pulmonaria Opal
                {281,19,0,-2,0,0,-1,1,3,0,10,0},    //Satsatchi
                {284,9,1,3,0,-2,2,0,-3,-1,10,0},    //Shrub Sage
                {285,14,0,-2,-1,1,2,0,0,3,11,0},    //Shrubby Basil
                {289,69,3,0,0,-3,0,-1,0,0,10,0},    //Silvertongue Damia
                {292,69,1,0,-2,-1,0,0,-3,0,11,0},    //Soapwort
                {293,68,-2,0,0,1,0,0,-3,-1,10,0},    //Sorrel
                {294,70,0,-2,1,2,0,-1,0,0,11,0},    //Spinach
                {297,75,3,0,-3,0,-1,-2,2,1,11,0},    //Steel Bladegrass
                {298,69,-2,0,3,0,-1,1,0,2,10,0},    //Stickler Hedge
                {299,65,3,0,0,-1,1,-2,0,-3,10,0},    //Strawberry Tea
                {303,15,0,-2,0,3,0,0,-1,1,11,0},    //Sweetflower
                {304,87,2,0,0,0,-1,1,0,-3,20,0},    //Sweetgrass
                {310,49,0,-2,0,3,-1,-3,0,0,8,0},    //Thyme
                {311,89,0,0,1,0,-1,0,-2,-3,18,0},    //Tiny Clover
                {314,65,0,0,-1,1,-3,3,0,0,11,0},    //True Tarragon
                {315,66,1,-2,0,3,-1,-3,0,2,10,0},    //Tsangto
                {321,40,0,2,0,0,-3,-2,1,-1,8,0},    //Verdant Squill
                {324,50,1,-2,-1,0,0,3,0,0,12,0},    //Weeping Patala
                {328,48,0,-3,1,-2,0,2,3,-1,8,0},    //Wild Lettuce
                {329,40,0,-1,-2,3,1,0,0,-3,11,0},    //Wild Onion
                {333,30,-2,0,0,0,0,3,-1,-3,10,0},    //Xanosi
                {337,70,-1,-2,1,2,0,0,-3,0,11,0}    //Yigory
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
