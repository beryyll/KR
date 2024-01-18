
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System;
using System.IO;
using static System.Windows.Forms.DataFormats;


namespace WinFormsApp4
{

    // Определение класса формы MemoryGameForm
    public partial class MemoryGameForm : Form
    {

        // Создание экземпляра класса Random для генерации случайных чисел
        Random random = new Random();
        // Переменная для хранения количества ходов
        private int moves = 0;
        // Список строковых значков, которые будут использоваться в игре
        List<string> icons = new List<string>()
        {
        "b", "b", "Z", "Z",
        ",", ",", "%", "%",
        "O", "O", "Y", "Y",
        "j", "j", "$", "$",
        };

        // Поля для хранения ссылок на первую и вторую выбранные метки
        Label firstClicked, secondCliked;

        // Конструктор класса MemoryGameForm
        public MemoryGameForm()
        {
            // Инициализация компонентов формы
            InitializeComponent();
            // Вызов метода для назначения значков меткам
            IconAssign();
        }

        // Метод для назначения значков меткам
        private void IconAssign()
        {
            Label label;
            int randomNumber;
            // Проход по всем элементам в tableLayoutPanel1
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                // Проверка, является ли текущий элемент меткой
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;
                // Генерация случайного числа для выбора значка из списка
                randomNumber = random.Next(0, icons.Count);
                // Присвоение выбранного значка тексту метки и удаление его из списка, чтобы избежать повторного использования
                label.Text = icons[randomNumber];
                icons.RemoveAt(randomNumber);
            }
        }

        // Обработчик события Click для меток в игре
        private void lable_Click(object sender, EventArgs e)
        {
            // Приведение отправителя события к типу Label и сохранение его в переменной clickedLabel
            Label clickedLabel = sender as Label;

            // Проверка, был ли правильно приведен clickedLabel к типу Label
            if (clickedLabel == null)
                return;

            // Проверка, имеет ли метка цвет текста черный (уже открыта)
            if (clickedLabel.ForeColor == Color.Black)
                return;

            // Проверка, выбраны ли уже две метки
            if (firstClicked != null && secondCliked != null)
                return;

            // Увеличение количества ходов
            moves++;
            // Обновление метки для отображения количества ходов
            label17.Text = "Ходы: " + moves / 2;

            // Проверка, выбрана ли первая метка
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            // Присвоение второй выбранной метке ссылки на вторую выбранную метку и изменение цвета текста
            secondCliked = clickedLabel;
            secondCliked.ForeColor = Color.Black;

            // Проверка на наличие победителя
            CheckForWinner();

            // Проверка, совпадают ли значки на выбранных метках
            if (firstClicked.Text == secondCliked.Text)
            {
                firstClicked = null;
                secondCliked = null;
            }
            else
                // Запуск таймера для скрытия неправильно открытых меток
                timer2.Start();
        }

        // Метод для загрузки лучшего результата из файла
        private BestScore LoadBestScore()
        {
            // Проверка наличия файла bestscore.txt
            if (File.Exists("bestscore.txt"))
            {
                // Чтение всех строк из файла
                string[] lines = File.ReadAllLines("bestscore.txt");

                // Проверка, содержит ли файл две строки
                if (lines.Length == 2)
                {
                    return new BestScore
                    {
                        PlayerName = lines[0],
                        Moves = int.Parse(lines[1])
                    };
                }
            }
            return null;
        }

        // Обработчик события Click для отображения лучшего результата
        private void bestScoreLabel_Click(object sender, EventArgs e)
        {
            // Загрузка лучшего результата из файла и отображение его на метке bestScoreLabel
            BestScore bestScore = LoadBestScore();
            if (bestScore != null)
            {
                bestScoreLabel.Text = $"Лучший результат: {bestScore.PlayerName} - {bestScore.Moves} ходов";
            }
        }

        // Метод для сохранения лучшего результата в файл
        private void SaveBestScore(string playerName, int moves)
        {
            File.WriteAllText("bestscore.txt", $"{playerName}\n{moves}");
        }

        private void CheckForWinner()
        {
            // Сохраняем количество ходов до нажатия button2_Click
            int movesBeforeClick = moves / 2;

            Label label;
            // Проверяем все метки в tableLayoutPanel1
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                // Проверяем, если метка не равна null и цвет текста равен цвету фона
                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }

            // Отображаем сообщение о завершении игры и количестве ходов
            MessageBox.Show("Игра окончена! Количество ходов: " + moves / 2);
            BestScore bestScore = LoadBestScore();
            // Проверяем, установлен ли новый рекорд
            if (bestScore == null || movesBeforeClick < bestScore.Moves)
            {
                // Запрашиваем имя у пользователя и сохраняем новый рекорд
                string playerName = Microsoft.VisualBasic.Interaction.InputBox("Поздравляем! Вы установили новый рекорд! Введите ваше имя:", "Новый рекорд");
                SaveBestScore(playerName, movesBeforeClick);
            }
            // Закрываем форму
            System.Windows.Forms.Application.Exit();
        }

        // Таймер, который через определенное время закрывает карточки
        private void timer2_Tick(object sender, EventArgs e)
        {
            // Останавливаем таймер
            timer2.Stop();

            // Скрываем цвет текста первой выбранной метки
            firstClicked.ForeColor = firstClicked.BackColor;
            // Скрываем цвет текста второй выбранной метки
            secondCliked.ForeColor = secondCliked.BackColor;

            // Сбрасываем переменные, хранящие выбранные метки
            firstClicked = null;
            secondCliked = null;
        }

        // Обработчик события Click для кнопки выхода
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Закрыть форму
            System.Windows.Forms.Application.Exit();
        }

        //Кнопка загрузки
        private void button1_Click(object sender, EventArgs e)
        {
            // Очищаем текст и устанавливаем цвет по умолчанию для всех ячеек
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                control.Text = "";
                control.ForeColor = Color.Red; // Устанавливаем цвет по умолчанию для всех ячеек
            }

            // Читаем данные из файла "tableLayoutData.txt" и заполняем ячейки
            List<string> cellContents = new List<string>(System.IO.File.ReadAllLines("tableLayoutData.txt"));
            // Проходим по всем элементам управления в таблице и заполняем их содержимым из файла
            for (int i = 0; i < tableLayoutPanel1.Controls.Count && i < cellContents.Count; i++)
            {
                // Разделяем строку из файла на части, используя разделитель ";"
                string[] parts = cellContents[i].Split(';');
                // Устанавливаем текст ячейки из первой части строки
                tableLayoutPanel1.Controls[i].Text = parts[0];
                // Если вторая часть строки равна "Black", устанавливаем цвет текста ячейки в черный
                if (parts[1] == "Black")
                {
                    tableLayoutPanel1.Controls[i].ForeColor = Color.Black;
                }
            }
            // Устанавливаем количество ходов
            if (cellContents.Count > 0)
            {
                moves = int.Parse(cellContents[cellContents.Count - 1]) * 2; // Устанавливаем количество ходов
            }
        }

        // Обработчик нажатия кнопки сохранения
        private void button2_Click(object sender, EventArgs e)
        {
            // Сохраняем данные из ячеек в файл "tableLayoutData.txt"
            List<string> cellContents = new List<string>();
            foreach (Label label in tableLayoutPanel1.Controls)
            {
                // Формируем содержимое ячейки в формате "символ;цвет"
                string cellContent = label.Text + ";" + (label.ForeColor == Color.Black ? "Black" : "NotBlack");
                cellContents.Add(cellContent);
            }
            // Добавляем количество ходов в конец списка
            cellContents.Add((moves / 2).ToString());
            // Записываем все содержимое списка в файл
            System.IO.File.WriteAllLines("tableLayoutData.txt", cellContents);
        }
    }
    // Определяем класс BestScore для хранения лучших результатов
    public class BestScore
    {
        // Свойство для хранения имени игрока
        public string PlayerName { get; set; }

        // Свойство для хранения количества ходов
        public int Moves { get; set; }
    }
}




