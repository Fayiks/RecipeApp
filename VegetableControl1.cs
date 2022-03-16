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
    public partial class VegetableControl1 : UserControl
    {
        public VegetableControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients:\n1 cup cooked kidney beans(canned is fine)\n1 mango, peeled, seeded and diced\n1 avocado, diced\n2 large tomatoes, diced\n1 capsicum diced" +
                "\n¼ – ½ cup red onion, finely diced(or 2 spring onions)\n1 cup cooked corn\n½ cup chopped fresh coriander\n3 cloves garlic, crushed\n3 Tbsp fresh lime or lemon juice" +
                "\n1 Tbsp oil\n1 chilli, seeded and sliced" +
                "\nPreparation:\nMix all the ingredients together and chill before serving.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients:\n¼ green or red cabbage, sliced\n1 corn cob, cooked and kernels sliced off\n1 ½ Tbsp lime juice\n1 tsp sesame oil\n1 tsp chopped red chilli\n2 tsp fish sauce\n2 Tbsp chopped coriander" +
                "\nPreparation:\n1.Heat non - stick frying pan over medium heat.\n2.Cook cabbage for 3 minutes or until wilted." +
                "\n3. Stir through other ingredients,heat and serve.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients:\n½ butternut or buttercup pumpkin(approx. 400g)\n2 tsp sesame oil\n2 tsp ground cumin \n100g baby spinach or other dark green lettuce leaves" +
                "\n2 Tbsp pumpkin seeds, toasted(optional)\n50g salt - reduced feta cheese, crumbled" +
                "\nPreparation:\n1.Heat oven to 180°C.\n2.Peel, de - seed, and cut pumpkin into chunks or slices and place on a non - stick baking tray.Brush lightly with" +
                "sesame oil and sprinkle with cumin.\n3.Bake for 20–30 minutes, until tender.\n4.Serve warm pumpkin on a bed of baby spinach leaves.Top with pumpkin" +
                "seeds and feta, and drizzle with vinaigrette of choice or lemon juice");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients:\n1 tsp oil\n1 onion, finely diced\n2 cloves garlic, crushed\n1 medium potato, peeled\n2 tsp vegetable stock powder\n500ml boiling water" +
                "\n1 cup frozen peas\n2½ cups or 100g watercress(or puha)\n½ cup cultured buttermilk" +
                "\nPreparation:\n1.Heat saucepan over medium heat.Wipe oil over bottom of pan. Add onion and garlic and cook until opaque, about 4–5 minutes." +
                "\n2.Rinse and remove watercress leaves from main stems.\n3.Cut potatoes into 1cm cubes. Add potatoes, stock and water to saucepan and cook over medium heat until tender, about 10 minutes." +
                "\n4.Add peas and watercress, cook 3 minutes.\n5.Puree or blend mixture, and stir through buttermilk.");
        }
    }
}
