using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms_dz2
{
    //     Задание 1
    // Создайте приложение размером до 720х480 пикселов и разместите
    // на главной форме необходимые элементы управления для получения информации:
    // ■ Фамилия
    // ■ Имя
    // ■ Отчество
    // ■ Пол
    // ■ Год и дата рождения
    // ■ Семейный статус
    // ■ Дополнительная информация
    // Добавьте кнопку Save и обработчик нажатия кнопки для сохранения информации
    // из элементов управления в файл.
    // Добавьте кнопку Load и обработчик нажатия кнопки для восстановления
    // информации из файла в элементы управления.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 480;  // ширина рабочей области
            this.Height = 720;  // высота рабочей области
            // текс для кнопки "Инструкция"
            label_manual.Text = "Заполните поля формы. \nНажмите 'Save', чтобы сохранить данные в файл" +
                "\nили 'Load', чтобы загрузить данные из файла.";          
        }

        private void button_save_Click(object sender, EventArgs e)  // обработчик клика на кнопку Save
        {
            string my_file = "Form.txt";
            using (FileStream fs = new FileStream(my_file, FileMode.Create,
                FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(textBox_f_name.Text);
                    sw.WriteLine(textBox_l_name.Text);
                    sw.WriteLine(textBox_age.Text);
                    sw.WriteLine(textBox_gender.Text);
                    sw.WriteLine(textBox_date_of_birth.Text);
                    sw.WriteLine(textBox_marital_status.Text);
                    sw.WriteLine(textBox_add_info.Text);
                }
            }
        }
        private void button_load_Click(object sender, EventArgs e)  // обработчик клика на кнопку Load
        {
            string my_file = "Form.txt";
            using (FileStream fs = new FileStream(my_file, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                {
                    textBox_f_name.Text = sr.ReadLine();
                    textBox_l_name.Text = sr.ReadLine();
                    textBox_age.Text = sr.ReadLine();
                    textBox_gender.Text = sr.ReadLine();
                    textBox_date_of_birth.Text = sr.ReadLine();
                    textBox_marital_status.Text = sr.ReadLine();
                    textBox_add_info.Text = sr.ReadLine();
                }
            }
        }
    }
}
