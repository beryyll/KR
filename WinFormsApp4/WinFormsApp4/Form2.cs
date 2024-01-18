using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp4
{
    // Определяем класс формы MemoryGameForm2
    public partial class MemoryGameForm2 : Form
    {
        // Конструктор класса MemoryGameForm2
        public MemoryGameForm2()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        // Обработчик события нажатия кнопки PlayButton
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Создание экземпляра формы MemoryGameForm
            MemoryGameForm memoryGameForm = new MemoryGameForm();
            memoryGameForm.Show(); // Отображение формы MemoryGameForm
            this.Hide(); // Скрыть текущую форму
        }


        // Обработчик события нажатия кнопки ExitButton
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Завершение приложения
        }
    }

}
