namespace SecondLaba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Обработчик подпункта "Открыть",
        //который загружает содержимое файла в компонент TRichEdit
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Запускает форму, для поиска нужного файла, и если файл выбран,
            // то запускаем логику вытаскивания данных
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // вытаскиваем все содержимое файла
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                // очищаем компонент от текста
                richTextBox1.Text = string.Empty;
                // итерируемся по массиву с содержимым файла
                foreach (string line in lines)
                {
                    // Добавляем построчно содержимое файла в компонент
                    richTextBox1.AppendText(line + '\n');
                }
            }
        }

        //Обработчик подпункта "Сохранить", который сохраняет текст из TRichEdit в файл 
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сохранение текста в файл
            File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
        }

        //Обработчик подпункта "Закрыть", который прекращает работу с файлом
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // очищаем компонент от текста
            richTextBox1.Text = string.Empty;
            // уничтожаем все ресурсы, связанные с файлом
            openFileDialog1.Dispose();

        }

        //Обработчик подпункта "Открыть" в PopupMenu
        private void открытьPopupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Запускает форму, для поиска нужного файла, и если файл выбран,
            // то запускаем логику вытаскивания данных
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // вытаскиваем все содержимое файла
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                // очищаем компонент от текста
                richTextBox1.Text = string.Empty;
                // итерируемся по массиву с содержимым файла
                foreach (string line in lines)
                {
                    // Добавляем построчно содержимое файла в компонент
                    richTextBox1.AppendText(line + '\n');
                }
            }
        }
        //Обработчик подпункта "Сохранить" в PopupMenu
        private void сохранитьPopupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сохранение текста в файл
            File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
        }
        //Обработчик подпункта "Закрыть" в PopupMenu
        private void закрытьPopupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // очищаем компонент от текста
            richTextBox1.Text = string.Empty;
            // уничтожаем все ресурсы, связанные с файлом
            openFileDialog1.Dispose();
        }

        //Обработчик подпункта "Открыть" в панели инструментов
        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Запускает форму, для поиска нужного файла, и если файл выбран,
            // то запускаем логику вытаскивания данных
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // вытаскиваем все содержимое файла
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                // очищаем компонент от текста
                richTextBox1.Text = string.Empty;
                // итерируемся по массиву с содержимым файла
                foreach (string line in lines)
                {
                    // Добавляем построчно содержимое файла в компонент
                    richTextBox1.AppendText(line + '\n');
                }
            }
        }

        //Обработчик подпункта "Сохранить" в панели инструментов
        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Сохранение текста в файл
            File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
        }

        //Обработчик подпункта "Закрыть" в панели инструментов
        private void закрытьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // очищаем компонент от текста
            richTextBox1.Text = string.Empty;
            // уничтожаем все ресурсы, связанные с файлом
            openFileDialog1.Dispose();
        }

        //Обработчик подпункта видимости главного меню
        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Если подпункт отмечен галочкой, то...
            if (главноеМенюToolStripMenuItem.Checked)
            {
                //скрываем компоненты главного окна
                richTextBox1.Visible = false;
                statusStrip1.Visible = false;
                //убираем галочку
                главноеМенюToolStripMenuItem.Checked = false;
            }
            //в противном случае
            else
            {
                // показываем главное окно
                richTextBox1.Visible = true;
                statusStrip1.Visible = true;
                // ставим галочку
                главноеМенюToolStripMenuItem.Checked = true;
            }
        }

        // Обработчик подпункта видимости компонента RichEdit
        private void richEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Если подпункт отмечен галочкой, то...
            if (richEditToolStripMenuItem.Checked)
            {
                //скрываем компонент RichEdit
                richTextBox1.Visible = false;
                //убираем галочку
                richEditToolStripMenuItem.Checked = false;
            }
            // в противном случае
            else
            {
                // показываем компонент RichEdit
                richTextBox1.Visible = true;
                // ставим галочку
                richEditToolStripMenuItem.Checked = true;
            }
        }

        // Обработчик подпункта видимости строки состояния
        private void строкаСостоянияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Если подпункт отмечен галочкой, то...
            if (строкаСостоянияToolStripMenuItem.Checked)
            {
                //скрываем строку состояния
                statusStrip1.Visible = false;
                //убираем галочку
                строкаСостоянияToolStripMenuItem.Checked = false;
            }
            // в противном случае
            else
            {
                // показываем строку состояния
                statusStrip1.Visible = true;
                // ставим галочку
                строкаСостоянияToolStripMenuItem.Checked = true;
            }
        }

        // Обработчик изменения размера текста в TRichEdit
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            // Вытаскиваем выбранный пользователем размер текста
            Int16 fontSize = Int16.Parse(toolStripComboBox1.Text);
            // Если выделенного текста нет, то...
            if (richTextBox1.SelectedText == "")
            {
                // меняем размер всего текста
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, fontSize);
            } 
            // В противном случае
            else
            {
                // меняем размер выделенного текста
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, fontSize);
            }
        }

        // Обработчик метрик текста
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Количество всех символов: " + richTextBox1.Text.Length;
            toolStripStatusLabel2.Text = "Количество символов в самой короткой строке: " + getAmountOfCharactersInTheShortestLine();
            toolStripStatusLabel3.Text = "Количество символов в самой длинной строке: " + getAmountOfCharactersInTheLongestLine();
        }

        // метод получения всех символов в самой короткой строке
        private int getAmountOfCharactersInTheShortestLine()
        {
            // инициализируем максимальным целочисленным числом
            int characters = int.MaxValue;

            // итерируемся по линиям
            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                // если длина строки меньше и она не равна нулю
                if (richTextBox1.Lines[i].Length < characters && richTextBox1.Lines[i].Length != 0)
                {
                    // сохраняем в переменную количество элементов строки
                    characters = richTextBox1.Lines[i].Length;
                }
            }
            return characters;
        }

        // метод получения всех символов в самой длинной строке
        private int getAmountOfCharactersInTheLongestLine()
        {
            // инициализируем минимальным размером строки
            int characters = 0;
            // итерируемся по линиям
            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                // если длина строки больше и она не равна нулю
                if (richTextBox1.Lines[i].Length > characters && richTextBox1.Lines[i].Length != 0)
                {
                    // сохраняем в переменную количество элементов строки
                    characters = richTextBox1.Lines[i].Length;
                }
            }
            return characters;
        }
    }
}