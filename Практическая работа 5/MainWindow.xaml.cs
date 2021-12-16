using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Практическая_работа_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }
        
        Triad chisla = new Triad();//объект, содержащий числа
        
        private void Сброс_Click(object sender, RoutedEventArgs e)
        {
            Ch1.Text = null;
            Ch2.Text = null;
            Ch3.Text = null;
            Plus1.Text = null;
            Plus10.Text = null;
        }

        private void Опрограмме_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполинл Потапкин. Задание:Использовать класс Triad (тройка чисел). Определить производный класс Date с полями: год, месяц и день.Переопределить методы увеличения полей на 1 иопределить метод увеличения даты на n дней");
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        Date data = new Date();
        private void Plus1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                data.One = Convert.ToInt32(Ch1.Text);//присваиваем значение из текст бокса
                data.Second = Convert.ToInt32(Ch2.Text);//присваиваем значение из текст бокса
                data.Third = Convert.ToInt32(Ch3.Text);//присваиваем значение из текст бокса
                data.Increment();//используем оператор
                Plus1.Text = data.One.ToString() + "." + data.Second.ToString() + "." + data.Third.ToString();
            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }
            }

        private void Plus10_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x1 = Convert.ToInt32(Ch1.Text);//присваиваем значение из текст бокса
                int x2 = Convert.ToInt32(Ch2.Text);//присваиваем значение из текст бокса
                int x3= Convert.ToInt32(Ch3.Text);//присваиваем значение из текст бокса
                chisla.SetParams(x1,x2,x3);//используем функцию
                chisla.SetParams();//
                Plus10.Text = chisla.One.ToString() + ";" + chisla.Second.ToString() + ";" + chisla.Third.ToString(); ;//записывем результат вычислений в текст бокс
            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }

        }

        

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                chisla.One = Convert.ToInt32(Ch1.Text);//присваиваем значение из текст бокса
                chisla.Second = Convert.ToInt32(Ch2.Text);//присваиваем значение из текст бокса
                chisla.Third = Convert.ToInt32(Ch3.Text);//присваиваем значение из текст бокса
                int val = Convert.ToInt32(Ch4.Text);//присваиваем значение из текст бокса
                int sum = chisla + val;//используем оператор
                Sum.Text = sum.ToString();//записывем результат вычислений в текст бокс
            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }
        }
       
       
        private void ChangeDate_Click(object sender, RoutedEventArgs e)
        {
            data.One = Convert.ToInt32(Ch1.Text);
            data.Second = Convert.ToInt32(Ch2.Text);
            data.Third = Convert.ToInt32(Ch3.Text);
            int n = Convert.ToInt32(N.Text);
            data.ChangeDate(n);
            ChangeDate.Text = data.One.ToString()+"."+data.Second.ToString() + "."+data.Third.ToString();
        }
    }
}
