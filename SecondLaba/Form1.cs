namespace SecondLaba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //���������� ��������� "�������",
        //������� ��������� ���������� ����� � ��������� TRichEdit
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ��������� �����, ��� ������ ������� �����, � ���� ���� ������,
            // �� ��������� ������ ������������ ������
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // ����������� ��� ���������� �����
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                // ������� ��������� �� ������
                richTextBox1.Text = string.Empty;
                // ����������� �� ������� � ���������� �����
                foreach (string line in lines)
                {
                    // ��������� ��������� ���������� ����� � ���������
                    richTextBox1.AppendText(line + '\n');
                }
            }
        }

        //���������� ��������� "���������", ������� ��������� ����� �� TRichEdit � ���� 
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���������� ������ � ����
            File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
        }

        //���������� ��������� "�������", ������� ���������� ������ � ������
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ������� ��������� �� ������
            richTextBox1.Text = string.Empty;
            // ���������� ��� �������, ��������� � ������
            openFileDialog1.Dispose();

        }

        //���������� ��������� "�������" � PopupMenu
        private void �������PopupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ��������� �����, ��� ������ ������� �����, � ���� ���� ������,
            // �� ��������� ������ ������������ ������
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // ����������� ��� ���������� �����
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                // ������� ��������� �� ������
                richTextBox1.Text = string.Empty;
                // ����������� �� ������� � ���������� �����
                foreach (string line in lines)
                {
                    // ��������� ��������� ���������� ����� � ���������
                    richTextBox1.AppendText(line + '\n');
                }
            }
        }
        //���������� ��������� "���������" � PopupMenu
        private void ���������PopupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���������� ������ � ����
            File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
        }
        //���������� ��������� "�������" � PopupMenu
        private void �������PopupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // ������� ��������� �� ������
            richTextBox1.Text = string.Empty;
            // ���������� ��� �������, ��������� � ������
            openFileDialog1.Dispose();
        }

        //���������� ��������� "�������" � ������ ������������
        private void �������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // ��������� �����, ��� ������ ������� �����, � ���� ���� ������,
            // �� ��������� ������ ������������ ������
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // ����������� ��� ���������� �����
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                // ������� ��������� �� ������
                richTextBox1.Text = string.Empty;
                // ����������� �� ������� � ���������� �����
                foreach (string line in lines)
                {
                    // ��������� ��������� ���������� ����� � ���������
                    richTextBox1.AppendText(line + '\n');
                }
            }
        }

        //���������� ��������� "���������" � ������ ������������
        private void ���������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //���������� ������ � ����
            File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
        }

        //���������� ��������� "�������" � ������ ������������
        private void �������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // ������� ��������� �� ������
            richTextBox1.Text = string.Empty;
            // ���������� ��� �������, ��������� � ������
            openFileDialog1.Dispose();
        }

        //���������� ��������� ��������� �������� ����
        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���� �������� ������� ��������, ��...
            if (�����������ToolStripMenuItem.Checked)
            {
                //�������� ���������� �������� ����
                richTextBox1.Visible = false;
                statusStrip1.Visible = false;
                //������� �������
                �����������ToolStripMenuItem.Checked = false;
            }
            //� ��������� ������
            else
            {
                // ���������� ������� ����
                richTextBox1.Visible = true;
                statusStrip1.Visible = true;
                // ������ �������
                �����������ToolStripMenuItem.Checked = true;
            }
        }

        // ���������� ��������� ��������� ���������� RichEdit
        private void richEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ���� �������� ������� ��������, ��...
            if (richEditToolStripMenuItem.Checked)
            {
                //�������� ��������� RichEdit
                richTextBox1.Visible = false;
                //������� �������
                richEditToolStripMenuItem.Checked = false;
            }
            // � ��������� ������
            else
            {
                // ���������� ��������� RichEdit
                richTextBox1.Visible = true;
                // ������ �������
                richEditToolStripMenuItem.Checked = true;
            }
        }

        // ���������� ��������� ��������� ������ ���������
        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ���� �������� ������� ��������, ��...
            if (���������������ToolStripMenuItem.Checked)
            {
                //�������� ������ ���������
                statusStrip1.Visible = false;
                //������� �������
                ���������������ToolStripMenuItem.Checked = false;
            }
            // � ��������� ������
            else
            {
                // ���������� ������ ���������
                statusStrip1.Visible = true;
                // ������ �������
                ���������������ToolStripMenuItem.Checked = true;
            }
        }

        // ���������� ��������� ������� ������ � TRichEdit
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            // ����������� ��������� ������������� ������ ������
            Int16 fontSize = Int16.Parse(toolStripComboBox1.Text);
            // ���� ����������� ������ ���, ��...
            if (richTextBox1.SelectedText == "")
            {
                // ������ ������ ����� ������
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, fontSize);
            } 
            // � ��������� ������
            else
            {
                // ������ ������ ����������� ������
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, fontSize);
            }
        }

        // ���������� ������ ������
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "���������� ���� ��������: " + richTextBox1.Text.Length;
            toolStripStatusLabel2.Text = "���������� �������� � ����� �������� ������: " + getAmountOfCharactersInTheShortestLine();
            toolStripStatusLabel3.Text = "���������� �������� � ����� ������� ������: " + getAmountOfCharactersInTheLongestLine();
        }

        // ����� ��������� ���� �������� � ����� �������� ������
        private int getAmountOfCharactersInTheShortestLine()
        {
            // �������������� ������������ ������������� ������
            int characters = int.MaxValue;

            // ����������� �� ������
            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                // ���� ����� ������ ������ � ��� �� ����� ����
                if (richTextBox1.Lines[i].Length < characters && richTextBox1.Lines[i].Length != 0)
                {
                    // ��������� � ���������� ���������� ��������� ������
                    characters = richTextBox1.Lines[i].Length;
                }
            }
            return characters;
        }

        // ����� ��������� ���� �������� � ����� ������� ������
        private int getAmountOfCharactersInTheLongestLine()
        {
            // �������������� ����������� �������� ������
            int characters = 0;
            // ����������� �� ������
            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                // ���� ����� ������ ������ � ��� �� ����� ����
                if (richTextBox1.Lines[i].Length > characters && richTextBox1.Lines[i].Length != 0)
                {
                    // ��������� � ���������� ���������� ��������� ������
                    characters = richTextBox1.Lines[i].Length;
                }
            }
            return characters;
        }
    }
}