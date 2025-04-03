using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace main
{
    public partial class Шифры_замены : UserControl
    {
        public Шифры_замены()
        {
            InitializeComponent();
        }

        private void buttonSUBD_Click(object sender, EventArgs e)
        {
            string message = originalMessage.Text.ToString().ToUpper();
            string key = textBoxKey.Text.ToString().ToUpper();
            textBoxCaesar.Text = Caesar(message);
            textBoxAtbash.Text = Atbash(message);
            textBoxLosung.Text = Losung(message, key);
            textBoxPlebey.Text = PlebeySquad(message);
            textBoxSystemOfTreesemus.Text = SystemOfTreesemus(message, key);
            textBoxPlayfair.Text = Playfair(message, key);
        }


        public string Caesar(string message) {

            string cipherAlphabet = "EFGHIJKLMNOPQRSTUVWXYZABCD";
            char [] cipher = message.ToCharArray();

            for (int i = 0; i < message.Length; i++)
            {
                int n = message[i];
                if (n >= 65 && n <= 90)
                {
                    n -= 65;
                    cipher[i] = cipherAlphabet[n];
                }
            }


            string MESS = new string(cipher);

            return MESS;
        }
        public string Atbash(string message)
        {

            string cipherAlphabet = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
            char[] cipher = message.ToCharArray();

            for (int i = 0; i < message.Length; i++)
            {
                int n = message[i];
                if (n >= 65 && n <= 90)
                {
                    n -= 65;
                    cipher[i] = cipherAlphabet[n];
                }
            }


            string MESS = new string(cipher);

            return MESS;
        }
        public string Losung(string message, string key)
        {


            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] array = key.ToCharArray();
            char[] cipherAlphabet = new char[26];
            int count = 0;
            for (int i = 0; i < key.Length; i++)
            {
                
                if (Array.IndexOf(cipherAlphabet, array[i]) < 0)
                {
                    cipherAlphabet[count] = array[i];
                    count = count + 1;
                }
            }

            for (int i = 0; i < alphabet.Length; i++)
            {

                if (Array.IndexOf(cipherAlphabet, alphabet[i]) < 0)
                {
                    cipherAlphabet[count] = alphabet[i];
                    count = count + 1;
                }

            }


            char[] cipher = message.ToCharArray();

            for (int i = 0; i < message.Length; i++)
            {
                int n = message[i];
                if (n >= 65 && n <= 90)
                {
                    n -= 65;
                    cipher[i] = cipherAlphabet[n];
                }
            }







            string MESS = new string(cipher);
            return MESS;
        }
        public string PlebeySquad(string message)
        {
            

            char[] cipher = new char[message.Length * 2];

            int count = 0;

            for (int i = 0; i < message.Length; i++)
            {

                int n = message[i];
                if (n >= 65 && n <= 90)
                {
                    n -= 65;
                    string temp = ((n / 6) + 1).ToString();
                    cipher[count] = temp[0];
                    count++;
                    temp = ((n % 6) + 1).ToString();
                    cipher[count] = temp[0];
                } else
                {
                    cipher[count] = message[i];
                }
                count++;
            }



            string MESS = new string(cipher);
            return MESS;


        }
        public string SystemOfTreesemus(string message, string key) {

            char[] cipher = message.ToCharArray();

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEF";
            char[] array = key.ToCharArray();
            char[] cipherAlphabet = new char[32];
            int count = 0;
            for (int i = 0; i < key.Length; i++)
            {

                if (Array.IndexOf(cipherAlphabet, array[i]) < 0)
                {
                    cipherAlphabet[count] = key[i];
                    count = count + 1;
                }
            }

            for (int i = 0; i < 26; i++)
            {

                if (Array.IndexOf(cipherAlphabet, alphabet[i]) < 0)
                {
                    cipherAlphabet[count] = alphabet[i];
                    if (count < 6)
                    {
                        cipherAlphabet[count + 26] = alphabet[i];
                    }
                    count = count + 1;
                }

            }


            for (int i = 0; i < 4; i++)
            {
                cipherAlphabet[i + 26] = cipherAlphabet[i + 2];
            }

            cipherAlphabet[0 + 30] = cipherAlphabet[0];
            cipherAlphabet[1 + 30] = cipherAlphabet[1];


            for (int i = 0; i < message.Length; i++)
            {
                int n = message[i];
                if (n >= 65 && n <= 90)
                {
                    n -= 65;
                    cipher[i] = cipherAlphabet[n+6];
                }
            }


            
            string MESS = new string(cipher);
            return MESS;
        }
        public string Playfair(string message, string key) {
            char[] cipher = message.ToCharArray();
            String array = "";


            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZCDEFAB!@#$";
            char[] cipherAlphabet = new char[36];
            int count = 0;
            for (int i = 0; i < key.Length; i++)
            {

                if (Array.IndexOf(cipherAlphabet, array[i]) < 0)
                {
                    cipherAlphabet[count] = key[i];
                    count = count + 1;
                }
            }

            for (int i = 0; i < 26; i++)
            {

                if (Array.IndexOf(cipherAlphabet, alphabet[i]) < 0)
                {
                    cipherAlphabet[count] = alphabet[i];
                    if (count < 6)
                    {
                        cipherAlphabet[count + 26] = alphabet[i];
                    }
                    count = count + 1;
                }

            }


            for (int i = 0; i < 4; i++)
            {
                cipherAlphabet[i + 26] = cipherAlphabet[i+2];
            }

            cipherAlphabet[0 + 30] = cipherAlphabet[0];
            cipherAlphabet[1 + 30] = cipherAlphabet[1];




            String[] matrix = new String[7];



            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[j] += alphabet[i * 6 + j];
                }
            }

            for (int i = 0; i < 6; i++)
            {
                matrix[6] += matrix[i][0];
            }

            






            for (int i = 0; i < message.Length; i++)
            {
                if (cipher[i] >= 65 &&  cipher[i] <= 90)
                {
                    array += cipher[i];
                }
            }


            if (array.Length % 2 == 1) array += "Q";






            String modified = "";

            

            for (int i = 0; i < array.Length; i+=2)
            {
                if (array[i] == array[i+1])
                {
                    modified += array[i];
                    modified += "S";
                    modified += array[i+1];
                    modified += "W";
                }
                else
                {
                    modified += array[i];
                    modified += array[i + 1];
                }
            }




            char[] finalmessage = modified.ToCharArray();


            


            for (int i = 0; i < modified.Length; i+=2)
            {
                int firstColumns = Array.IndexOf(cipherAlphabet, modified[i]);
                int secondColumns = Array.IndexOf(cipherAlphabet, modified[i+1]);
                firstColumns = firstColumns % 6;
                secondColumns = secondColumns % 6;
                int firstRows = Array.IndexOf(cipherAlphabet, modified[i]);
                int secondRows = Array.IndexOf(cipherAlphabet, modified[i+1]);
                firstRows = firstRows / 6;
                secondRows = secondRows / 6;

                if (firstRows == secondRows)
                {
                    finalmessage[i] = matrix[firstColumns + 1][firstRows];
                    finalmessage[i + 1] = matrix[secondColumns + 1][secondRows];
                }

                else if (firstColumns == secondColumns)
                {
                    finalmessage[i] = matrix[firstColumns][firstRows + 1];
                    finalmessage[i + 1] = matrix[secondColumns][secondRows + 1];
                }

                else
                {
                    finalmessage[i] = matrix[secondColumns][firstRows];
                    finalmessage[i + 1] = matrix[firstColumns][secondRows];
                }
            }










            string MESS = new string(finalmessage);
            return MESS;
        }

    }
}
