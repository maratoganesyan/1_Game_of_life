using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Game_of_life
{
    public partial class game : Form
    {

        int height= 20; //height wid - размер одной клетки матрицы
        int widht = 20; //
        int ch = 0;
        int h, w; // количество клеток на panel
        Label[,] lab; // матрица из одной клетки сетки
        int col = 0; // выбор цвета
        Random rand = new Random(); //инициализирует новый экземляр Random класс с помощью начального значения по умолчанию, завис. от времени

        public game() 
        {
            InitializeComponent(); //метод для поддержки конструктора
            Game_area(); 
        }
        private void New_labels(int a, int c) // установка параметров на сетку в игровой области
        {
            lab[a, c] = new Label(); //массив/матрица из клеток
            lab[a, c].Parent = panel1; //назначает родительский контейнер элемента управлениz
            lab[a, c].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; //задает стиль для границы для эл-та управления (сетки)
            lab[a, c].BackColor = System.Drawing.Color.White ; //цвет фона в сетке
            lab[a, c].Location = new Point(a * widht, c * height); //указываем точку с параметрами ширины и высоты
            lab[a, c].Size = new System.Drawing.Size(widht + 1, height + 1);
            lab[a, c].Click += new EventHandler(this.label_Click);
        }

        private void Game_area() //метод создания сетки
        {
            w = 35; // количество клеток в строке
            h = 25;// количество клеток в столбике
            lab = new Label[w, h]; // инициализация массива
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    New_labels(i, j); // заполнение панели
                }
            }
        }
        private void bluecolor_Click(object sender, EventArgs e)
        {
            col = 1;
        }

        private void redcolor_Click(object sender, EventArgs e)
        {
            col = 2;
        }
        
        private int Blueneighbour(int a, int c) //метод проверки на нахождение синих клеток по соседству
        {
           ch = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }
                    if (Convert.ToInt32(lab[(a + i + w) % w, (c + j + h) % h].Tag) == 1) 
                    {
                        ch++;
                    }
                }
            }
            return ch;
        }
        private int Redneighbour(int a, int c) // метод нахождения красных клеток по соседству
        {
          ch = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }
                    if (Convert.ToInt32(lab[(a + i + w) % w, (c + j + h) % h].Tag) == 2) // проверка на соседние элементы красного цвета через края включительно
                    {
                        ch++;
                    }
                }
            }
            return ch;
        }

        private void start_button_Click_1(object sender, EventArgs e)
        {
            timer1.Start(); //время жизни начинается с нажатием кнопки старта, запускается таймер
            panel1.Enabled = false; //доступ к панели по время игры заблокирован
        }

        private void SearchBW()  //жизнь синих клеток
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    int sum = Blueneighbour(i, j); // количество элементов синего цвета вокруг клетки
                    if (sum == 3)
                    {
                        lab[i, j].BackColor = Color.Blue;
                        continue;
                    }
                    if ((sum == 2 || sum == 3) && Convert.ToInt32(lab[i, j].Tag) == 1)
                    {
                        lab[i, j].BackColor = Color.Blue;

                    }
                    else
                    {
                        if (lab[i, j].BackColor == Color.White|| lab[i, j].BackColor == Color.Red)
                        {
                            if (sum == 3)
                            {
                                lab[i, j].BackColor = Color.Blue;
                            }
                            continue;
                        }
                        lab[i, j].BackColor = Color.White;
                    }
                }
            }
        }
        private void SearchRW() // поиск красных клеток
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    int sum = Redneighbour(i, j); // количество красных клеток вокруг нынешней 
                    if (sum == 3)
                    {
                        lab[i, j].BackColor = Color.Red;
                        continue;
                    }
                    if ((sum == 2 || sum == 3) && Convert.ToInt32(lab[i, j].Tag) == 2)
                    {
                        lab[i, j].BackColor = Color.Red;
                    }
                    else
                    {
                        if (lab[i, j].BackColor == Color.Blue)
                        {
                            if (sum == 3)
                            {
                                lab[i, j].BackColor = Color.Red;
                            }
                            continue;
                        }
                        lab[i, j].BackColor = Color.White;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = rand.Next(1, 3);
            if (a == 1) //доминируют синие
            {
                SearchBW(); // вызов метода для смены цвета синих
                SearchRW(); // вызов метода для смены цвета красных
            }
            if (a == 2) //доминируют красные
            {
                SearchRW(); // вызов метода для смены цвета красных
                SearchBW(); // вызов метода для смены цвета синих
            }

            for (int i = 0; i < w; i++) //смена тэга
            {
                for (int j = 0; j < h; j++)
                {
                    if (lab[i, j].BackColor == Color.White)
                    {
                        lab[i, j].Tag = 0;
                    }
                    if (lab[i, j].BackColor == Color.Blue)
                    {
                        lab[i, j].Tag = 1;
                    }
                    if (lab[i, j].BackColor == Color.Red)
                    {
                        lab[i, j].Tag = 2;
                    }
                }
            }
        }
        private void label_Click(object sender, EventArgs e) //работа с закрашиванием красных или синих клеток на панели
        {
            int x = ((Label)sender).Location.X / widht; // определение позиции элемента в строке
            int y = ((Label)sender).Location.Y / height;// определение позиции элемента в столбце
            if (lab[x, y].BackColor == System.Drawing.Color.Red || lab[x, y].BackColor == System.Drawing.Color.Blue)
            {
                lab[x, y].Tag = 0;
                lab[x, y].BackColor = System.Drawing.Color.White; // возврат на белый цвет закрашенной клетки
                return;
            }
            if (col == 0) // если цвет не выбран
            {
                MessageBox.Show("Выберите цвет для жизни."); // сообщение пользователю
            }
            if (col == 1) // если выбран синий цвет
            {
                lab[x, y].BackColor = System.Drawing.Color.Blue; // закрасить синим
                lab[x, y].Tag = 1; // смена тэга
            }
            if (col == 2) // если выбран красный цвет
            {
                lab[x, y].BackColor = System.Drawing.Color.Red; // закрасить красным
                lab[x, y].Tag = 2; // смена тэга 
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // остановка таймера
            panel1.Enabled = true; // открытие панели

        }
    }
}
