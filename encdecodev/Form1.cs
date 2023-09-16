using System.Text;

namespace encdecodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            string result = "";
            // Get input string from txtValue
            string input = txtValue.Text;
            string fourth = To4thBase(input);
            string fourthBase = ShiftCharsLeft(fourth);
            string Key = txtAnahtar.Text;
            
            string Key4 = To4thBase(Key);
            fourthBase = FourBitAdder(fourthBase, Key4);

            for (int i = 0; i < fourthBase.Length; i += 1)
            {
               char s = fourthBase[i];
               string nucleotide = Base4ToNucleotide(s);
               result += nucleotide;
            }

                    // Display result in txtResult
                    string equal = Equall(result);
                    txtEncrypt.Text = "Þifreniz:" + CnvAsc(equal);
        }
        public static string CnvAsc(string input)
        {
            if (input.Length % 4 != 0)
            {
                throw new ArgumentException("Input string length must be a multiple of 4");
            }
            string result = "";
            string fourBit = NucleotideTobase4(input);
            for (int i = 0; i < input.Length; i += 4)
            {
                string sub = fourBit.Substring(i, 4);   
                int num = FourthBaseToDecimal(sub);
                char c = (char)num;
                result += c;
            }
            return result;
        }
        public static string FourthBaseToAscii(string fourthBase)
        {
            string ascii = "";
            for (int i = 0; i < fourthBase.Length; i += 4)
            {
                string fourBits = fourthBase.Substring(i, 4);
                int decimalValue = 0;
                for (int j = 0; j < 4; j++)
                {
                    decimalValue += (int)(Char.GetNumericValue(fourBits[j]) * Math.Pow(4, 3 - j));
                }
                ascii += (char)decimalValue;
            }
            return ascii;
        }

        public static string NucleotideTobase4(string nuc)
        {
            string result = "";
            for(int i=0; i<nuc.Length; i++)
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
        public static string FourBitAdder(string Base1, string key)
        {
            string result = "";
            int j = 0;
            for (int i = 0; i < Base1.Length; i += 4)
            {
                string Key4 = "";
                while(Key4.Length < 4)
                {
                    if (j == key.Length)
                        j = 0;
                    Key4 += key[j];
                    j++;
                }
                string sub = Base1.Substring(i, 4);
                int num1 = FourthBaseToDecimal(sub);
                int num2 = FourthBaseToDecimal(Key4);
                int num = num1 + num2;
                if (num >= 256)
                    num = num % 256;
                string c = DecimalToBase4(num);
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


        public static string To4thBase(string input)
        {
            string result = "";
            string[] fourBase = { "0", "1", "2", "3" };
            foreach (char c in input)
            {
                int num = (int)c;
                string tempResult = "";
                while (num > 0)
                {
                    tempResult = fourBase[num % 4] + tempResult;
                    num /= 4;
                }
                while (tempResult.Length < 4)
                {
                    tempResult = "0" + tempResult;
                }
                result += tempResult;
            }
            return result;
        }
        public static string ShiftCharsLeft(string input)
        {
            string shifted = "";
            for (int i = 0; i < input.Length; i+=4)
            {
                string temp = "";
                temp += input[i + 1];
                temp += input[i + 2];
                temp += input[i + 3];
                temp += input[i];
                shifted += temp;
            }
            return shifted;
        }
        // Function to convert a decimal number to a base-4 number
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

        // Function to convert a base-4 number to A, T, S, G
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

        public static string Equall(string result)
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

        private void txtEncrypt_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtAnahtar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void Desifreleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            DesifreForm fr2 = new DesifreForm();
            fr2.ShowDialog();
            this.Close();

            
        }
    }
}