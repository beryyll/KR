
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System;
using System.IO;
using static System.Windows.Forms.DataFormats;


namespace WinFormsApp4
{

    // ����������� ������ ����� MemoryGameForm
    public partial class MemoryGameForm : Form
    {

        // �������� ���������� ������ Random ��� ��������� ��������� �����
        Random random = new Random();
        // ���������� ��� �������� ���������� �����
        private int moves = 0;
        // ������ ��������� �������, ������� ����� �������������� � ����
        List<string> icons = new List<string>()
        {
        "b", "b", "Z", "Z",
        ",", ",", "%", "%",
        "O", "O", "Y", "Y",
        "j", "j", "$", "$",
        };

        // ���� ��� �������� ������ �� ������ � ������ ��������� �����
        Label firstClicked, secondCliked;

        // ����������� ������ MemoryGameForm
        public MemoryGameForm()
        {
            // ������������� ����������� �����
            InitializeComponent();
            // ����� ������ ��� ���������� ������� ������
            IconAssign();
        }

        // ����� ��� ���������� ������� ������
        private void IconAssign()
        {
            Label label;
            int randomNumber;
            // ������ �� ���� ��������� � tableLayoutPanel1
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                // ��������, �������� �� ������� ������� ������
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;
                // ��������� ���������� ����� ��� ������ ������ �� ������
                randomNumber = random.Next(0, icons.Count);
                // ���������� ���������� ������ ������ ����� � �������� ��� �� ������, ����� �������� ���������� �������������
                label.Text = icons[randomNumber];
                icons.RemoveAt(randomNumber);
            }
        }

        // ���������� ������� Click ��� ����� � ����
        private void lable_Click(object sender, EventArgs e)
        {
            // ���������� ����������� ������� � ���� Label � ���������� ��� � ���������� clickedLabel
            Label clickedLabel = sender as Label;

            // ��������, ��� �� ��������� �������� clickedLabel � ���� Label
            if (clickedLabel == null)
                return;

            // ��������, ����� �� ����� ���� ������ ������ (��� �������)
            if (clickedLabel.ForeColor == Color.Black)
                return;

            // ��������, ������� �� ��� ��� �����
            if (firstClicked != null && secondCliked != null)
                return;

            // ���������� ���������� �����
            moves++;
            // ���������� ����� ��� ����������� ���������� �����
            label17.Text = "����: " + moves / 2;

            // ��������, ������� �� ������ �����
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            // ���������� ������ ��������� ����� ������ �� ������ ��������� ����� � ��������� ����� ������
            secondCliked = clickedLabel;
            secondCliked.ForeColor = Color.Black;

            // �������� �� ������� ����������
            CheckForWinner();

            // ��������, ��������� �� ������ �� ��������� ������
            if (firstClicked.Text == secondCliked.Text)
            {
                firstClicked = null;
                secondCliked = null;
            }
            else
                // ������ ������� ��� ������� ����������� �������� �����
                timer2.Start();
        }

        // ����� ��� �������� ������� ���������� �� �����
        private BestScore LoadBestScore()
        {
            // �������� ������� ����� bestscore.txt
            if (File.Exists("bestscore.txt"))
            {
                // ������ ���� ����� �� �����
                string[] lines = File.ReadAllLines("bestscore.txt");

                // ��������, �������� �� ���� ��� ������
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

        // ���������� ������� Click ��� ����������� ������� ����������
        private void bestScoreLabel_Click(object sender, EventArgs e)
        {
            // �������� ������� ���������� �� ����� � ����������� ��� �� ����� bestScoreLabel
            BestScore bestScore = LoadBestScore();
            if (bestScore != null)
            {
                bestScoreLabel.Text = $"������ ���������: {bestScore.PlayerName} - {bestScore.Moves} �����";
            }
        }

        // ����� ��� ���������� ������� ���������� � ����
        private void SaveBestScore(string playerName, int moves)
        {
            File.WriteAllText("bestscore.txt", $"{playerName}\n{moves}");
        }

        private void CheckForWinner()
        {
            // ��������� ���������� ����� �� ������� button2_Click
            int movesBeforeClick = moves / 2;

            Label label;
            // ��������� ��� ����� � tableLayoutPanel1
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                // ���������, ���� ����� �� ����� null � ���� ������ ����� ����� ����
                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }

            // ���������� ��������� � ���������� ���� � ���������� �����
            MessageBox.Show("���� ��������! ���������� �����: " + moves / 2);
            BestScore bestScore = LoadBestScore();
            // ���������, ���������� �� ����� ������
            if (bestScore == null || movesBeforeClick < bestScore.Moves)
            {
                // ����������� ��� � ������������ � ��������� ����� ������
                string playerName = Microsoft.VisualBasic.Interaction.InputBox("�����������! �� ���������� ����� ������! ������� ���� ���:", "����� ������");
                SaveBestScore(playerName, movesBeforeClick);
            }
            // ��������� �����
            System.Windows.Forms.Application.Exit();
        }

        // ������, ������� ����� ������������ ����� ��������� ��������
        private void timer2_Tick(object sender, EventArgs e)
        {
            // ������������� ������
            timer2.Stop();

            // �������� ���� ������ ������ ��������� �����
            firstClicked.ForeColor = firstClicked.BackColor;
            // �������� ���� ������ ������ ��������� �����
            secondCliked.ForeColor = secondCliked.BackColor;

            // ���������� ����������, �������� ��������� �����
            firstClicked = null;
            secondCliked = null;
        }

        // ���������� ������� Click ��� ������ ������
        private void exitButton_Click(object sender, EventArgs e)
        {
            // ������� �����
            System.Windows.Forms.Application.Exit();
        }

        //������ ��������
        private void button1_Click(object sender, EventArgs e)
        {
            // ������� ����� � ������������� ���� �� ��������� ��� ���� �����
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                control.Text = "";
                control.ForeColor = Color.Red; // ������������� ���� �� ��������� ��� ���� �����
            }

            // ������ ������ �� ����� "tableLayoutData.txt" � ��������� ������
            List<string> cellContents = new List<string>(System.IO.File.ReadAllLines("tableLayoutData.txt"));
            // �������� �� ���� ��������� ���������� � ������� � ��������� �� ���������� �� �����
            for (int i = 0; i < tableLayoutPanel1.Controls.Count && i < cellContents.Count; i++)
            {
                // ��������� ������ �� ����� �� �����, ��������� ����������� ";"
                string[] parts = cellContents[i].Split(';');
                // ������������� ����� ������ �� ������ ����� ������
                tableLayoutPanel1.Controls[i].Text = parts[0];
                // ���� ������ ����� ������ ����� "Black", ������������� ���� ������ ������ � ������
                if (parts[1] == "Black")
                {
                    tableLayoutPanel1.Controls[i].ForeColor = Color.Black;
                }
            }
            // ������������� ���������� �����
            if (cellContents.Count > 0)
            {
                moves = int.Parse(cellContents[cellContents.Count - 1]) * 2; // ������������� ���������� �����
            }
        }

        // ���������� ������� ������ ����������
        private void button2_Click(object sender, EventArgs e)
        {
            // ��������� ������ �� ����� � ���� "tableLayoutData.txt"
            List<string> cellContents = new List<string>();
            foreach (Label label in tableLayoutPanel1.Controls)
            {
                // ��������� ���������� ������ � ������� "������;����"
                string cellContent = label.Text + ";" + (label.ForeColor == Color.Black ? "Black" : "NotBlack");
                cellContents.Add(cellContent);
            }
            // ��������� ���������� ����� � ����� ������
            cellContents.Add((moves / 2).ToString());
            // ���������� ��� ���������� ������ � ����
            System.IO.File.WriteAllLines("tableLayoutData.txt", cellContents);
        }
    }
    // ���������� ����� BestScore ��� �������� ������ �����������
    public class BestScore
    {
        // �������� ��� �������� ����� ������
        public string PlayerName { get; set; }

        // �������� ��� �������� ���������� �����
        public int Moves { get; set; }
    }
}




