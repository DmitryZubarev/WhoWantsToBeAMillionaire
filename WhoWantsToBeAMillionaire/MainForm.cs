using System;
using System.Collections.Generic;
using Dapper;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WhoWantsToBeAMillionaire
{
    public partial class MainForm : Form
    {
        int score = 0;
        string connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        private int idPerson;
        //private List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        private int level = 0;
        private Question currentQuestion;
        //private string currentQuestion;
        private bool rightOfMistake = false;
        int activated = 0;
        Dictionary<int, int> win = new Dictionary<int, int>()
        {
            {1, 500}, {2, 1000}, {3, 2000},
            {4, 3000}, {5, 5000}, {6, 10000},
            {7, 15000}, {8, 25000}, {9, 50000},
            {10, 100000}, {11, 200000}, {12, 400000},
            {13, 800000}, {14, 1500000}, {15, 3000000}
        };

        public void UpdateScore(int id, int score)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand(@"update Persons
                                                        set TopNumber=@score
                                                        where id=@id",
                                                        conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("score", score);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public MainForm(int id)
        {
            InitializeComponent();
            //ReadFile();
            StartGame();
            idPerson = id;
        }

        //private void ReadFile()
        //{
        //    string path = @"E:\VStudio\projects\WhoWantsToBeAMillionaire\WhoWantsToBeAMillionaire\files\Вопросы.txt";

        //    using (StreamReader sr = new StreamReader(path))
        //    {
        //        //string line;
        //        //while ((line = sr.ReadLine()) != null)
        //        //{
        //        //    questions.Add(new Question(line.Split('\t')));
        //        //}

        //        using (SQLiteConnection con = new SQLiteConnection(connection))
        //        {
        //            con.Open();
        //            SQLiteCommand del = new SQLiteCommand("delete from Questions", con);
        //            del.ExecuteNonQuery();
        //            string[] dataQuestion = new string[7];
        //            string line;
        //            while ((line = sr.ReadLine()) != null)
        //            {
        //                Question q = new Question(line.Split('\t'));
        //                SQLiteCommand cmd = new SQLiteCommand(@"insert into Questions
        //                                    (Question, Answer1, Answer2, Answer3, Answer4, RightAnswer, Level)
        //                                    values (@Question, @Answer1, @Answer2, @Answer3, @Answer4, @RightAnswer, @Level)",
        //                                    con);
        //                cmd.Parameters.AddWithValue("Question", q.Text);
        //                cmd.Parameters.AddWithValue("Answer1", q.Answers[0]);
        //                cmd.Parameters.AddWithValue("Answer2", q.Answers[1]);
        //                cmd.Parameters.AddWithValue("Answer3", q.Answers[2]);
        //                cmd.Parameters.AddWithValue("Answer4", q.Answers[3]);
        //                cmd.Parameters.AddWithValue("RightAnswer", q.RightAnswer);
        //                cmd.Parameters.AddWithValue("Level", q.Level);
        //                cmd.ExecuteNonQuery();
        //            }

        //            con.Close();
        //        }
        //    }
        //}

        private void ShowQuestion(Question question)
        {
            lblQuestion.Text = question.Text;
            btn1.Text = question.Answers[0];
            btn2.Text = question.Answers[1];
            btn3.Text = question.Answers[2];
            btn4.Text = question.Answers[3];
        }

        private Question GetQuestion(int level)
        {
            var questionsWithLvl = new List<Question>();
            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(@"select * from Question
                                                        where Level=@level",
                                                        con);
                cmd.Parameters.AddWithValue("level", level);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] s = { Convert.ToString(reader["question"]), Convert.ToString(reader["answer1"]),
                    Convert.ToString(reader["answer2"]), Convert.ToString(reader["answer3"]),
                    Convert.ToString(reader["answer4"]), Convert.ToString(reader["rightanswer"]),
                    Convert.ToString(reader["level"])};
                    questionsWithLvl.Add(new Question(s));
                }
                reader.Close();

                con.Close();
            }
            return questionsWithLvl[rnd.Next(questionsWithLvl.Count)];

        }

        private void NextStep()
        {
            Button[] btns = new Button[] { btn1, btn2, btn3, btn4 };

            foreach (Button btn in btns)
            {
                btn.Enabled = true;
            }
            if (level == 8) level = 13;
            else level++;
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
        }

        private void StartGame()
        {
            level = 0;
            activated = 0;
            NextStep();
            TruEnabled();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (rightOfMistake)
            {
                case true:
                    if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                    {
                        NextStep();
                    }
                    else
                    {
                        MessageBox.Show("Не угадал");
                        rightOfMistake = false;
                    }
                    break;

                case false:
                    if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                    {
                        NextStep();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный ответ");
                        score = level - 1;
                        UpdateScore(idPerson, score);
                        StartGame();
                    }
                    break;
            }
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            activated++;
            Button[] btns = new Button[] {btn1, btn2, btn3, btn4};
            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());

                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }
            if (activated > 3) FalsEnabled();
            else btn5050.Enabled = false;
        }

        private void btnChangeQuestion_Click(object sender, EventArgs e)
        {
            activated++;
            level--;
            NextStep();
            if (activated > 3) FalsEnabled();
            else btnChangeQuestion.Enabled = false;
        }

        private void btnHallSupport_Click(object sender, EventArgs e)
        {
            activated++;
            string name1 = btn1.Text;
            string name2 = btn2.Text;
            string name3 = btn3.Text;
            string name4 = btn4.Text;
            string[] ans = { name1, name2, name3, name4};

            int num1 = rnd.Next(0, 100);
            int num2 = rnd.Next(0, 100 - num1);
            int num3 = rnd.Next(0, 100 - num1 - num2);
            int num4 = 100 - num1 - num2 - num3;
            int[] choices = { num1, num2, num3, num4};

            MessageBox.Show($@"За {name1} проголосовало {num1}%
За {name2} проголосовало {num2}%
За {name3} проголосовало {num3}%
За {name4} проголосовало {num4}%");

            if (activated > 3) FalsEnabled();
            else btnHallSupport.Enabled = false;
        }

        private void btnCalling_Click(object sender, EventArgs e)
        {
            activated++;
            string name1 = btn1.Text;
            string name2 = btn2.Text;
            string name3 = btn3.Text;
            string name4 = btn4.Text;
            string[] ans = { name1, name2, name3, name4 };

            int index = rnd.Next(0,4);
            MessageBox.Show($"Твой кореш выбрал {ans[index]}");
            if (activated > 3) FalsEnabled();
            else btnCalling.Enabled = false;
        }

        private void btnMistake_Click(object sender, EventArgs e)
        {
            activated++;
            rightOfMistake = true;
            if (activated > 3) FalsEnabled();
            else btnMistake.Enabled = false;
        }

        private void FalsEnabled()
        {
            btn5050.Enabled = false;
            btnCalling.Enabled = false;
            btnChangeQuestion.Enabled = false;
            btnHallSupport.Enabled = false;
            btnMistake.Enabled = false;
        }

        private void TruEnabled()
        {
            btn5050.Enabled = true;
            btnCalling.Enabled = true;
            btnChangeQuestion.Enabled = true;
            btnHallSupport.Enabled = true;
            btnMistake.Enabled = true;
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            var frm = new Score();
            frm.Show();
        }
    }
}