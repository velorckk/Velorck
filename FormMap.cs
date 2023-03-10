using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittyGame
{
    public partial class FormMap : Form
    {
        private Button[,] _cells;
        private Point heroPosition = new Point(5,0);
        private Hero hero;
        private Button[] buttons;


        public FormMap(string heroName)
        {
            InitializeComponent();

            _cells = new Button[,]
            {
                { button_0_0 , button_0_1 , button_0_2, button_0_3, button_0_4, button_0_5, button_0_6, button_0_7, button_0_8, button_0_9 },
                { button_1_0 , button_1_1 , button_1_2, button_1_3, button_1_4, button_1_5, button_1_6, button_1_7, button_1_8, button_1_9  },
                { button_2_0 , button_2_1 , button_2_2, button_2_3, button_2_4, button_2_5, button_2_6, button_2_7, button_2_8, button_2_9  },
                { button_3_0 , button_3_1 , button_3_2, button_3_3, button_3_4, button_3_5, button_3_6, button_3_7, button_3_8, button_3_9  },
                { button_4_0 , button_4_1 , button_4_2, button_4_3, button_4_4, button_4_5, button_4_6, button_4_7, button_4_8, button_4_9  },
                { button_5_0 , button_5_1 , button_5_2, button_5_3, button_5_4, button_5_5, button_5_6, button_5_7, button_5_8, button_5_9  },
            };

            buttons = new Button[]
            {
                button4,button6,button8,button10,button3,button5,button7,button9

            };

            //отрис интерфейс героя
            labelName.Text = heroName;
     

            pictureBoxAvatar.Image = Image.FromFile("Assets/Images/mainHero.jpg");

            //отрисовываем героя на карте
            hero = new Hero(heroName,heroPosition);
            DrawOnCell(heroPosition.X, heroPosition.Y, "Assets/Images/mainHero.jpg");

            //отрисовываем предметы на карте
            foreach(var item in ItemFactory.Items)
            {
                DrawOnCell(item.Location.X, item.Location.Y, item.Image);
            }

        }

        private void DrawOnCell(int x, int y, string image)
        {
            _cells[x, y].BackgroundImage = Image.FromFile(image);
            _cells[x, y].BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void MoveHero(int x, int y)
        {
            _cells[heroPosition.X, heroPosition.Y].BackgroundImage = null;
            _cells[heroPosition.X, heroPosition.Y].BackgroundImageLayout = ImageLayout.Zoom;

            heroPosition = new Point(x,y);

            DrawOnCell(heroPosition.X, heroPosition.Y, "Assets/Images/mainHero.jpg");

            //логика подбора предметов
            if (ItemFactory.Items.Any(x => x.Location==heroPosition))
            {

                var button = buttons.First(x => !hero.Items.Any(q => q.Button.Name == x.Name));

                var item = ItemFactory.Items.First(x => x.Location == heroPosition);
                item.Button = button;
                hero.Items.Add(item);
                hero.Hp += item.Hp;
                hero.Hungry += item.Hungry;
                hero.Damage += item.Damage;




                button.BackgroundImage = Image.FromFile(item.Image);
                button.BackgroundImageLayout = ImageLayout.Zoom;

                if (buttons.Length > 8)
                {
                    MessageBox.Show("Больше предметов брать нельзя!");
                }

            }


        }

        private void MoveHeroVertical(int x)
        {

            MoveHero( x , heroPosition.Y );
        }


        private void MoveHeroHorizontal(int y)
        {

            MoveHero(heroPosition.X, y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        bool IsReadyMove = true;

        private async void button_Click(object sender, EventArgs e) //движение //async Task - синхр
        {
            if ( !IsReadyMove)
            {
                return;
            }

            IsReadyMove = false;

            var button = (Button)sender;
            var x = int.Parse(button.Name.Split("_")[1]);
            var y = int.Parse(button.Name.Split("_")[2]);

            //ДВИЖЕНИЕ по верт
            while (heroPosition.X != x)
            {

                if(heroPosition.X < x) //движение вниз
                {
                    MoveHeroVertical(heroPosition.X + 1);
                    await Task.Delay(300); //установка задержки
                }

                if (heroPosition.X > x) //движение вверх
                {
                    MoveHeroVertical(heroPosition.X - 1);
                    await Task.Delay(300); //установка задержки
                }
            }



            //ДВИЖЕНИЕ по гориз
            while (heroPosition.Y != y)
            {

                if (heroPosition.Y < y) //движение вниз
                {
                    MoveHeroHorizontal(heroPosition.Y + 1);
                    await Task.Delay(300); //установка задержки
                }

                if (heroPosition.Y > y) //движение вверх
                {
                    MoveHeroHorizontal(heroPosition.Y - 1);
                    await Task.Delay(300); //установка задержки
                }
            }


            IsReadyMove = true;


        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {
                    }

        private void button61_Click(object sender, EventArgs e)
        {

        }

        private void button89_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Damage_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
