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
    public partial class BeverageControl1 : UserControl
    {
        public BeverageControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: \n ½ cup water or coconut water \n ½ cup plain low fat yogurt \n ½ cup fresh or frozen blueberries" +
                "\n½ overripe banana, peeled and sliced\n2 ice cubes\nInstructions:1.Put all the ingredients in the blender." +
                "\n2.Put the blender top on tightly.Turn the blender to a medium setting and blend until the mixture is smooth, about 2 minutes." +
                "\n3.Pour the smoothie into cups and scrape out the rest with a spoon.\n4.Serve in 4 ounce portions for children, 6 ounce portionsfor adolescents, or in 8 ounce portions for adults.You can " +
                "either serve right away, or store in a thermos or covered in the fridge up to 4 hours.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: \n2 cups chopped kale\n1 overripe banana, sliced\n1 apple, cored and chopped\n1 cup frozen blueberries\n1 cup plain low - fat yogurt" +
                "\n½ cup 100 % orange juice\n2 tablespoons toasted almonds or walnuts(optional)" +
                "\nInstructions:\n1.Put the kale, banana, apple, blueberries, yogurt, orange juice, and almonds(if you like) in the blender. Put the top on tightly." +
                "\n2.Turn the blender to medium and blend until the mixture is very smooth.\n3.Serve in 4 ounce portions for children, 6 ounce portions" +
                "for adolescents, or in 8 ounce portions for adults.You can either serve right away, or store in a thermos or covered in the fridge up to 4 hours.\nNote: \nFreeze the banana ahead of time for a slushier smoothie!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients:\n1 cup of watermelon pulp\n½ cup of fresh strawberries(washed and stem removed)" +
                "\nInstructions:\n1.Put all the ingredients in the blender.\n2.Put the top on tightly.Turn the blender to a medium setting and blend until the mixture is smooth, about 1 minute." +
                "\n3.Serve in 4 ounce portions for children, 6 ounce portions for adolescents, or in 8 ounce portions for adults.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients:\n ½ cup overripe banana slices\n1 tablespoon almond or peanut butter\n½ cup fresh, frozen or canned pineapple chunks\n1 orange\n2 ice cubes" +
                "\n3 / 4 cups plain low - fat yogurt\n1 tablespoon shredded, unsweetened coconut" +
                "\nInstructions:\n1.Put the banana, almond butter, pineapple and orange in the blender.Put the top on tightly.\n2.Turn the blender to medium and blend until the mixture is smooth. \n 3.Turn the machine off, and add the ice cubes, yogurt and coconut." +
                "\n4.Put the top on tightly, turn the blender to medium and blend until the ice is chopped and the mixture is smooth but still pulpy.\n5.Serve in 4 ounce portions for children, 6 ounce portions for adolescents, or in 8 ounce portions for adults.\nYou caneither serve right away, or store in a thermos or covered in the fridge up to 4 hours.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients:\n2 avocados\n1 handful spinach\n1 banana\n1 cup fresh pineapple\n1 cup low fat milk\n3 ice cubes" +
                "\nInstructions:\n1.Put all the ingredients in the blender.\n2.Put the top on tightly.Turn the blender to a medium setting and blend until the ice is chopped and the mixture is smooth, about 1 minute." +
                "\n3.Serve in 4 ounce portions for children, 6 ounce portions for adolescents, or in 8 ounce portions for adults.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients:\n½ cup 100 % orange juice\n½ cup plain low - fat yogurt\n1 ripe banana, peeled and sliced\n½ teaspoon vanilla extract\n2 ice cubes" +
                "\nInstructions:\n1.Put all the ingredients in the blender.\n2.Put the top on tightly.Turn the blender to a medium setting and blend until the ice is chopped and the mixture is smooth, about 1 minute." +
                "\n3.Serve in 4 ounce portions for children, 6 ounce portions for adolescents, or in 8 ounce portions for adults." +
                "\nYou can either serve right away, or store in a thermos or covered in the fridge up to 4 hours.\nNote:\nFreeze the banana ahead of time for a slushier smoothie!");
        }
    }
}
