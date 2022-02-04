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
    public partial class ForLoopsToOthers1 : Form
    {
        public ForLoopsToOthers1()
        {
            InitializeComponent();
        }

        private void btnOneToThousand_Click(object sender, EventArgs e)
        {
            Clear();
            OneToNumberWhile(1000);
            OneToNumberDoWhile(1000);
            OneToNumberForEach(1000);
        }

        private void btnThousandToOne_Click(object sender, EventArgs e)
        {
            Clear();
            NumberToOneWhile(1000);
            NumberToOneDoWhile(1000);
            NumberToOneForEach(1000);
        }

        private void btnEvensToThousands_Click(object sender, EventArgs e)
        {
            Clear();
            EvensOneToNumberWhile(1000);
            EvensOneToNumberDoWhile(1000);
            EvensOneToNumberForEach(1000);
        }

        private void btnAlphabethWithAscii_Click(object sender, EventArgs e)
        {
            Clear();
            PrintAtoZWhile();
            PrintAtoZDoWhile();
            PrintAtoZForEach();
        }

        private void buttonOneToHundred_Click(object sender, EventArgs e)
        {
            Clear();
            AddOneToNumberWhile(100);
            AddOneToNumberDoWhile(100);
            AddOneToNumberForEach(100);
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Clear();
            OperationOneToNumberWhile(100);
            OperationOneToNumberDoWhile(100);
            OperationOneToNumberForEach(100);
        }

        private void btnYears_Click(object sender, EventArgs e)
        {
            Clear();
            YearListWhile();
            YearListDoWhile();
            YearListForEach();
        }

        void Clear()
        {
            lsWhileLoops.Items.Clear();
            lsForEachLoops.Items.Clear();
            lsDoWhileLoops.Items.Clear();
        }

        void OneToNumberWhile(int limit)
        {
            int i = 1;
            while (i <= limit)
            {
                lsWhileLoops.Items.Add(i);
                i++;
            }
        }

        void OneToNumberDoWhile(int limit)
        {
            int i = 1;
            do
            {
                lsDoWhileLoops.Items.Add(i);
                i++;
            } while (i <= limit);
        }

        void OneToNumberForEach(int limit)
        {
            byte[] indexes = new byte[limit];
            int i = 1;
            foreach(byte index in indexes)
            {
                lsForEachLoops.Items.Add(i);
                i++;
            }
            
        }


        void NumberToOneWhile(int limit)
        {
            int i = limit;
            while (i > 0)
            {
                lsWhileLoops.Items.Add(i);
                i--;
            }
        }

        void NumberToOneDoWhile(int limit)
        {
            int i = limit;
            do
            {
                lsDoWhileLoops.Items.Add(i);
                i--;
            } while (i > 0);
        }

        void NumberToOneForEach(int limit)
        {
            byte[] indexes = new byte[limit];
            int i = limit;
            foreach (byte index in indexes)
            {
                lsForEachLoops.Items.Add(i);
                i--;
            }
        }

        void EvensOneToNumberWhile(int limit)
        {
            //Way1
            //int i = 1;
            //while (i <= limit)
            //{
            //    if (i % 2 == 0)
            //        lsbxResılts.Items.Add(i);
            //    i++;
            //}
            int i = 2;
            while (i <= limit)
            {
                lsWhileLoops.Items.Add(i);
                i += 2;
            }
        }

        void EvensOneToNumberDoWhile(int limit)
        {
            //Way1
            //int i = 1;
            //do
            //{
            //    if (i % 2 == 0)
            //        lsDoWhileLoops.Items.Add(i);
            //    i++;
            //}while (i <= limit);
            int i = 2;
            do
            {
                lsDoWhileLoops.Items.Add(i);
                i += 2;
            } while (i <= limit);
        }

        void EvensOneToNumberForEach(int limit)
        {
            //Way1
            //byte[] indexes = new byte[limit];
            //int i = 1;
            //foreach (byte index in indexes)
            //{
            //    if (i % 2 == 0)
            //        lsForEachLoops.Items.Add(i);
            //    i++;
            //}
            byte[] indexes = new byte[limit/2];
            int i = 2;
            foreach (byte index in indexes)
            {
                lsForEachLoops.Items.Add(i);
                i += 2;
            }
        }

        void AddOneToNumberWhile(int limit)
        {
            int results = 0;
            int i = 1;
            while (i <= limit)
            {
                results += i;
                lsWhileLoops.Items.Add(results);
                i++;
            }
        }

        void AddOneToNumberDoWhile(int limit)
        {
            int results = 0;
            int i = 1;
            do
            {
                results += i;
                lsDoWhileLoops.Items.Add(results);
                i++;
            } while (i <= limit);
        }

        void AddOneToNumberForEach(int limit)
        {
            int results = 0;
            int i = 1;
            byte[] indexes = new byte[limit];

            foreach (byte index in indexes)
            {
                results += i;
                lsForEachLoops.Items.Add(results);
                i ++;
            }
        }

        void OperationOneToNumberWhile(int limit)
        {

            int evens = 0;
            int odds = 0;
            int operation = 0;

            int i = 1;
            while (i <= limit)
            {
                if (i % 2 == 0)
                {
                    evens += i;
                }
                else
                {
                    odds += i;
                }
                i++;
            }

            operation = evens - odds;
            lsWhileLoops.Items.Add(Math.Pow(operation, 2));
        }

        void OperationOneToNumberDoWhile(int limit)
        {

            int evens = 0;
            int odds = 0;
            int operation = 0;

            int i = 1;
            while (i <= limit)
            {
                if (i % 2 == 0)
                {
                    evens += i;
                }
                else
                {
                    odds += i;
                }
                i++;
            }

            operation = evens - odds;
            lsDoWhileLoops.Items.Add(Math.Pow(operation, 2));
        }

        void OperationOneToNumberForEach(int limit)
        {

            int evens = 0;
            int odds = 0;
            int operation = 0;

            int i = 1;
            byte[] indexes = new byte[limit];

            foreach (byte index in indexes)
            {

                if (i % 2 == 0)
                {
                    evens += i;
                }
                else
                {
                    odds += i;
                }
                i++;
            }

            operation = evens - odds;
            lsForEachLoops.Items.Add(Math.Pow(operation, 2));
        }

        void YearListWhile()
        {
            int i = 1945;
            while (i <= DateTime.Now.Year)
            {
                if (i > 1945 && i < 1965)
                {
                    lsWhileLoops.Items.Add(i + " 1945 ile 1965 arası.");
                }
                if (i > 1950 && i != 1965)
                {
                    lsWhileLoops.Items.Add(i.ToString());
                }
                i++;
            }
        }

        void YearListDoWhile()
        {
            int i = 1945;
            do
            {
                if (i > 1945 && i < 1965)
                {
                    lsDoWhileLoops.Items.Add(i + " 1945 ile 1965 arası.");
                }
                if (i > 1950 && i != 1965)
                {
                    lsDoWhileLoops.Items.Add(i.ToString());
                }
                i++;
            } while (i <= DateTime.Now.Year);
        }

        void YearListForEach()
        {
            int i = 1945;
            byte[] indexes = new byte[DateTime.Now.Year - (i-1)];

            foreach (byte index in indexes)
            {

                if (i > 1945 && i < 1965)
                {
                    lsForEachLoops.Items.Add(i + " 1945 ile 1965 arası.");
                }
                if (i > 1950 && i != 1965)
                {
                    lsForEachLoops.Items.Add(i.ToString());
                }
                i++;
            }

        }

        void PrintAtoZWhile()
        {
            char chr = 'A';
            while (chr <= 'Z')
            {
                lsWhileLoops.Items.Add(chr + " - " + Convert.ToInt32(chr));
                chr++;
            }
        }

        void PrintAtoZDoWhile()
        {
            char chr = 'A';
            do
            {
                lsDoWhileLoops.Items.Add(chr + " - " + Convert.ToInt32(chr));
                chr++;
            } while (chr <= 'Z');
        }

        void PrintAtoZForEach()
        {
            string str = "qwertyuıopğüasdfghjklşi,zxcvbnmöç.QWERTYUIOPĞÜASDFGHJKLŞİ;>ZXCVBNMÖÇ:";
            foreach(char s in str){
                lsForEachLoops.Items.Add(s + " - " + Convert.ToInt32(s));
            }
        }
    }
}
