using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PastriesControl1 : UserControl
    {
        public PastriesControl1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients/Equipments: Flour, Baking Soda, Salt, Baking Powder, Eggs, vanilla, butter. pans, oven,thermometer" +
                "\n Peparations: \n1. Preheat the oven to 375 degrees F. Line the baking pan with parchment paper and set aside" +
                "\n 2. Mix the flour, baking soda, baking powder and salt in a bowl and set aside." +
                "\n 3. Cream together butter and sugar till they combine" +
                "\n 4. Add 12 oz package of chocolate chips and mix well" +
                "\n 5. Roll your dough(as you wish) into balls and space evenly in the oven" +
                "\n 6. Bake in a preheated oven for 8-10 mins, dont forget to turn over at intervals. After let it cool. Brunch is served");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: chocolate, 12 tablespoon of melted butter, 1.25 cups sugar, 2 eggs, 2 spoons of vanilla extract," +
                "\n cups of flour(90g), cocoa powder(30g)\nOptional(Bush)\n Procedures:" +
                "\n1. Preheat the oven to 175 degrees Celsius. Grease the pan to be used" +
                "\n2. Combined the melted butter,sugar,cocoa powder,vanilla extract,eggs,flour,baking powder and salt. Whisk till soot" +
                "\n3. Bake in Preheated oven for 20 minutes or until a toothpick inserted in the center comes out with crumbs" +
                "\n Voila! If you have bush in yours, Happy Fuckery!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients/Equips: 1.25 cups of water, 4.5 cups of bread flour, 3 tablespoon white sugar, 1 teaspoon salt, 2 table spoon vegetable oil, 1 table spoon yeast, 1 cup honey" +
                "\n Oven, Pans,Whisker\n Instructions: \n1. Mix the flour,1.25 cups of water , salt ,vegetable oil,yeast and sugar in a bowl. Mix slowly for 7 minutes and make into straight doughs, if it tear, means it needs more kneading" +
                "\n2. Transfer the dough to a lightly oiled bowl, cover it with plastic wrap and let it rise for 2 hours. \n3. Shape your dough into your preffered shape of bagels \n4. Preheat oven to 475 degrees F. \n 5.Wet the bagels with honey and bake for 15/20 minutes...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: Cherry Tomatoes, Freta Cheese, Vegetable Oil\n Equipments: A pan, Oven \n Instructions: 1. Rinse your tomatoes under a running tap" +
                "\n2. Rinse the pans/Clean the oven\n3. Put your cheese and tomatoes in the oven, add a little oil and roast for 10 mins.\n Brunch is Ready!");
        }
    }
}
