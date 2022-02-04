using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLooptoOtherLoops
{
    public partial class ForLoopsToOthers2 : Form
    {
        public ForLoopsToOthers2()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        string[] arrstr = { "Beşiktaş", "Galatasaray", "Fenerbahçe", "TrabzonSpor", "Falan", "Filan" };
        int[] arrint = { 1, 2, 3, 6, 2, 4, 5, 54, 78, 65, 21, 104, 100 };
        private void btnAddTeamsToList_Click(object sender, EventArgs e)
        {
            Clear();
            ListTeamsWhile(arrstr);
            ListTeamsDoWhile(arrstr);
            ListTeamsForEach(arrstr);
        }

        private void btnShowBiggest_Click(object sender, EventArgs e)
        {
            Clear();
            MessageBox.Show("While " + BiggestNumberWhile(arrint) + " en büyük sayıdır.");
            MessageBox.Show("Do While " + BiggestNumberDoWhile(arrint) + " en büyük sayıdır.");
            MessageBox.Show("For Each " + BiggestNumberForEach(arrint) + " en büyük sayıdır.");
        }

        private void btnShowNumberOfEvensOdds_Click(object sender, EventArgs e)
        {
            Clear();
            EvenOddCounterMessager("While");
            EvenOddCounterMessager("DoWhile");
            EvenOddCounterMessager("ForEach");
        }

        private void btnReverseName_Click(object sender, EventArgs e)
        {
            Clear();
            MessageBox.Show("While " + ReversedNameWhile("Kelam"));
            MessageBox.Show("Do While " + ReversedNameDoWhile("Kelam"));
            MessageBox.Show("For Each " + ReversedNameForEach("Kelam"));
        }

        private void btnRandomNumbersToList_Click(object sender, EventArgs e)
        {
            Clear();
            RandomNumbersWhile();
            RandomNumbersDoWhile();
            RandomNumbersForEach();
        }

        private void btnChangeButtonStyles_Click(object sender, EventArgs e)
        {
            Button[] buttons = { btnShowNumberOfEvensOdds, btnShowBiggest, btnReverseName, btnRandomNumbersToList, btnChangeButtonStyles, btnAddTeamsToList, btnAddChars };
            Clear();
            ButtonColorWhile(buttons);
            ButtonColorWhile();
            ButtonColorDoWhile(buttons);
            ButtonColorDoWhile();
            ButtonColorForEach(buttons);
            ButtonColorForEach();
        }

        private void btnAddChars_Click(object sender, EventArgs e)
        {
            Clear();
            MessageBox.Show("While " + SumNumbersWhile(txtNumbers.Text).ToString());
            MessageBox.Show("Do While " + SumNumbersDoWhile(txtNumbers.Text).ToString());
            MessageBox.Show("For Each " + SumNumbersForEach(txtNumbers.Text).ToString());
        }

        void Clear()
        {
            lsWhileLoop.Items.Clear();
            lsDoWhileLoop.Items.Clear();
            lsForEachLoop.Items.Clear();
        }

        int SumNumbersWhile(string number)
        {
            int result = 0;

            int i = 0;
            while(i < number.Length)
            {
                result += Convert.ToInt32(number[i].ToString());
                i++;
            }

            return result;
        }

        int SumNumbersDoWhile(string number)
        {
            int result = 0;

            if (number.Length > 0)
            {
                
                int i = 0;
                do
                {
                    result += Convert.ToInt32(number[i].ToString());
                    i++;
                } while (i < number.Length);

            }
           

            return result;
        }

        int SumNumbersForEach(string number)
        {
            int result = 0;

            foreach (char num in number)
            {
                result += Convert.ToInt32(num.ToString());
            }

            return result;
        }

        void ButtonColorWhile(Button[] btns)
        {
            int i = 0;
            while (i < btns.Length)
            {
                btns[i].ForeColor = Color.Aqua;
                i++;
            }
        }

        void ButtonColorWhile()
        {
            int i = 0;
            while (i < this.Controls.Count)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.Chocolate;
                }
                else if (this.Controls[i] is ListBox)
                {
                    this.Controls[i].BackColor = Color.DarkGoldenrod;
                }
                i++;
            }
        }

        void ButtonColorDoWhile(Button[] btns)
        {
            int i = 0;
            do
            {
                btns[i].ForeColor = Color.Aqua;
                i++;
            } while (i < btns.Length);
        }

        void ButtonColorDoWhile()
        {
            int i = 0;
            do
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.Chocolate;
                }
                else if (this.Controls[i] is ListBox)
                {
                    this.Controls[i].BackColor = Color.DarkGoldenrod;
                }
                i++;
            } while (i < this.Controls.Count);
        }

        void ButtonColorForEach(Button[] btns)
        {
            foreach (Button btn in btns)
            {
                btn.ForeColor = Color.Aqua;
            }
        }

        void ButtonColorForEach()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.Chocolate;
                }
                else if (control is ListBox)
                {
                    control.BackColor = Color.DarkGoldenrod;
                }
            }
        }

        void ListTeamsWhile(string[] teams)
        {
            int i = 0;
            while (i < teams.Length)
            {
                lsWhileLoop.Items.Add(teams[i]);
                i++;
            }
        }

        void ListTeamsDoWhile(string[] teams)
        {
            int i = 0;
            do
            {
                lsDoWhileLoop.Items.Add(teams[i]);
                i++;
            } while (i < teams.Length);
        }

        void ListTeamsForEach(string[] teams)
        {
            foreach (string team in teams)
            {
                lsForEachLoop.Items.Add(team);
            }
        }

        int BiggestNumberWhile(int[] numbers)
        {
            int result = 0;

            int i = 0;
            while (i < numbers.Length)
            {
                if (numbers[i] > result)
                {
                    result = numbers[i];
                }
                i++;
            }

            return result;
        }

        int BiggestNumberDoWhile(int[] numbers)
        {
            int result = 0;

            int i = 0;
            do
            {
                if (numbers[i] > result)
                {
                    result = numbers[i];
                }
                i++;
            } while (i < numbers.Length);

            return result;
        }

        int BiggestNumberForEach(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                if (number > result)
                {
                    result = number;
                }
            }

            return result;
        }

        void EvenOddCounterMessager(string method)
        {
            if(method == "While")
            {
                MessageBox.Show("While Bu dizide " + EvensOddsCounterWhile(arrint)[0] + " kadar çift, " + EvensOddsCounterWhile(arrint)[1] + " kadar da tek sayı bulunmaktadır.");
            }
            else if (method == "DoWhile")
            {
                MessageBox.Show("Do While Bu dizide " + EvensOddsCounterDoWhile(arrint)[0] + " kadar çift, " + EvensOddsCounterDoWhile(arrint)[1] + " kadar da tek sayı bulunmaktadır.");
            }
            else
            {
                MessageBox.Show("For Each Bu dizide " + EvensOddsCounterForEach(arrint)[0] + " kadar çift, " + EvensOddsCounterForEach(arrint)[1] + " kadar da tek sayı bulunmaktadır.");
            }
            
        }

        int[] EvensOddsCounterWhile(int[] numbers)
        {
            int[] result = new int[2];
            int evens = 0;
            int odds = 0;

            int i = 0;
            while (i < numbers.Length)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens++;
                }
                else
                {
                    odds++;
                }
                i++;
            }

            result[0] = evens;
            result[1] = odds;
            return result;
        }

        int[] EvensOddsCounterDoWhile(int[] numbers)
        {
            int[] result = new int[2];
            int evens = 0;
            int odds = 0;

            int i = 0;
            while (i < numbers.Length)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens++;
                }
                else
                {
                    odds++;
                }
                i++;
            }

            result[0] = evens;
            result[1] = odds;
            return result;
        }

        int[] EvensOddsCounterForEach(int[] numbers)
        {
            int[] result = new int[2];
            int evens = 0;
            int odds = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens++;
                }
                else
                {
                    odds++;
                }
            }

            result[0] = evens;
            result[1] = odds;
            return result;
        }

        void RandomNumbersWhile()
        {
            int[] numbers = new int[10];

            int i = 0;
            while (i < numbers.Length)
            {
                numbers[i] = rnd.Next(1, 101);
                lsWhileLoop.Items.Add(numbers[i]);
                i++;
            }
        }

        void RandomNumbersDoWhile()
        {
            int[] numbers = new int[10];

            int i = 0;
            do
            {
                numbers[i] = rnd.Next(1, 101);
                lsDoWhileLoop.Items.Add(numbers[i]);
                i++;
            } while (i < numbers.Length);
        }
        void RandomNumbersForEach()
        {
            int[] numbers = new int[10];

            int i = 0;
            foreach (int number in numbers)
            {
                numbers[i] = rnd.Next(1, 101);
                lsForEachLoop.Items.Add(numbers[i]);
                i++;
            }
        }

        string ReversedNameWhile(string name)
        {
            string result = "";

            int i = name.Length - 1;

            while (i >= 0)
            {
                result += name[i];
                i--;
            }

            return result;
        }

        string ReversedNameDoWhile(string name)
        {
            string result = "";

            int i = name.Length - 1;

            do
            {
                result += name[i];
                i--;
            } while (i >= 0);

            return result;
        }

        string ReversedNameForEach(string name)
        {
            string result = "";


            foreach (char spell in name)
            {
                result = result.Insert(0, spell.ToString());
            }
 
            return result;
        }
    }
}
