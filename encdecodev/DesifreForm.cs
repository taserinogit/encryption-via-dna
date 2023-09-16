using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encdecodev
{
    public partial class DesifreForm : Form
    {
        public DesifreForm()
        {
            InitializeComponent();
        }


        // Function to convert a decimal number to a base-4 number
 

        // Function to convert a base-4 number to A, T, S, G

        private void BtnDecrypt_Click_1(object sender, EventArgs e)
        {
            string result = txtEncrypt.Text;
            string key = txtAnahtar.Text;
            string fourBit = "";
            for(int i=0; i < result.Length; i++)
            {
                fourBit += DecimalToBase4((int)result[i]);
            }

            string Nuc = "";
            for (int i = 0; i < fourBit.Length; i++)
            {
                Nuc += Base4ToNucleotide(fourBit[i]);
            }

            Nuc = Equall(Nuc);

            Nuc = NucleotideTobase4(Nuc);
            string Key4 = "";
            for (int i = 0; i < key.Length; i++)
            {
                Key4 += DecimalToBase4((int)key[i]);
            }
            Nuc = FourBitSub(Nuc, Key4);

            Nuc = ShiftCharsRight(Nuc);

            Nuc = CnvAsc(Nuc);

            txtDecrypt.Text = Nuc;





        }
        public static string FourBitSub(string Base1, string key)
        {
            string result = "";
            int j = 0;
            for (int i = 0; i < Base1.Length; i += 4)
            {
                string Key4 = "";
                while (Key4.Length < 4)
                {
                    if (j == key.Length)
                        j = 0;
                    Key4 += key[j];
                    j++;
                }
                string sub = Base1.Substring(i, 4);
                int num1 = FourthBaseToDecimal(sub);
                int num2 = FourthBaseToDecimal(Key4);
                int num = num1 - num2;
                if (num >= 256)
                    num = num % 256;
                string c = DecimalToBase4(num);
                result += c;
            }
            return result;

        }

        public static string ShiftCharsRight(string input)
        {
            string shifted = "";
            for (int i = 0; i < input.Length; i += 4)
            {
                string temp = "";
                temp += input[i + 3];
                temp += input[i];
                temp += input[i + 1];
                temp += input[i + 2];
                shifted += temp;
            }
            return shifted;
        }
        static string Equall(string result)
        {
            string temp = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == 'A')
                {
                    temp += "T";
                }
                else if (result[i] == 'T')
                {
                    temp += "A";
                }
                else if (result[i] == 'S')
                {
                    temp += "G";
                }
                else if (result[i] == 'G')
                {
                    temp += "S";
                }
            }
            return temp;
        }

        public static string DecimalToBase4(int decimalValue)
        {
            string base4Value = "";
            while (decimalValue > 0)
            {
                int remainder = decimalValue % 4;
                decimalValue /= 4;
                base4Value = remainder.ToString() + base4Value;
            }
            while (base4Value.Length < 4)
            {
                base4Value = "0" + base4Value;
            }
            return base4Value;
        }

        private void sifreleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.Show();
        }
        public static string Base4ToNucleotide(char base4Value)
        {
            string nucleotide = "";
            switch (base4Value)
            {
                case '0':
                    nucleotide = "A";
                    break;
                case '3':
                    nucleotide = "T";
                    break;
                case '2':
                    nucleotide = "S";
                    break;
                case '1':
                    nucleotide = "G";
                    break;
                default:
                    throw new ArgumentException("Invalid base-4 value: " + base4Value);
            }
            return nucleotide;
        }

        public static string CnvAsc(string input)
        {
            if (input.Length % 4 != 0)
            {
                throw new ArgumentException("Input string length must be a multiple of 4");
            }
            string result = "";
            for (int i = 0; i < input.Length; i += 4)
            {
                string sub = input.Substring(i, 4);
                int num = FourthBaseToDecimal(sub);
                char c = (char)num;
                result += c;
            }
            return result;
        }
        public static int FourthBaseToDecimal(string fourthBase)
        {
            int decimalNumber = 0;
            int power = 0;
            for (int i = fourthBase.Length - 1; i >= 0; i--)
            {
                decimalNumber += (int)(char.GetNumericValue(fourthBase[i]) * Math.Pow(4, power));
                power++;
            }
            return decimalNumber;
        }
        public static string NucleotideTobase4(string nuc)
        {
            string result = "";
            for (int i = 0; i < nuc.Length; i++)
            {
                switch (nuc[i])
                {
                    case 'A':
                        result += "0";
                        break;
                    case 'T':
                        result += "3";
                        break;
                    case 'S':
                        result += "2";
                        break;
                    case 'G':
                        result += "1";
                        break;
                }
            }
            return result;

        }

        private void sifreleme_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.ShowDialog();
            this.Close(); 
        }
    }
}
