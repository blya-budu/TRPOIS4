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



    }
}
