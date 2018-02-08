using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class main : Form
    {
        // the variables declared below are used throughout the encryption/decryption process

        string text;
        string final;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        string[] rails;
        char[] alphabetOrig;

        int numshift;
        int numrails;
        int layer;

        bool isRunning;

        private Dictionary<char, char> alphabetDict;

        public main()
        {
            // when the program starts display the screen
            // and create a char array of the alphabet, and lowercase alphabet
            InitializeComponent();
            alphabetOrig = (alphabet.ToLower() + alphabet).ToCharArray();
        }

        // when the rail fence encrypt button is clicked, run the railfence function
        // this is run with the paramaters being true for encrypting and false for not being the mixed encryption
        private void RailfenceEncrypt_Click(object sender, EventArgs e)
        {
            RailFence(true, false);
        }

        // when the rail fence decrypt button is clicked, run the railfence function
        // this is run with the paramaters being false for not encrypting and false for not being the mixed encryption
        private void RailfenceDecrypt_Click(object sender, EventArgs e)
        {
            RailFence(false, false);
        }

        // when the caesar cipher encrypt button is clicked, run the caesar cipher function
        // this is run with the parameters being true for encrypting and false for not being the mixed encryption
        private void CaesarEncrypt_Click(object sender, EventArgs e)
        {
            CaesarCipher(true, false);
        }

        // when the caesar cipher decrypt button is clicked, run the caesar cipher function
        // this is run with the parameters being false for not encrypting and false for not being the mixed encryption
        private void CaesarDecrypt_Click(object sender, EventArgs e)
        {
            CaesarCipher(false, false);
        }

        /* 
         * when the mixed encrypt button is clicked the rail fence function is run
         * the caesar cipher function is run with the value returned from the rail fence cipher
         * all functions are run with true as the parameters because they are encrypting and it is the mixed cipher
         */
        private void MixedEncrypt_Click(object sender, EventArgs e)
        {
            string encryptedRail = RailFence(true, true);
            if (encryptedRail != "Error")
                CaesarCipher(true, true, encryptedRail);
        }

        /* 
         * when the mixed decrypt button is clicked the rail fence function is run
         * the caesar cipher function is run with the value returned from the rail fence cipher
         * all functions are run with false for not encrypting and true for being the mixed cipher
         */
        private void MixedDecrypt_Click(object sender, EventArgs e)
        {
            string decryptedRail = RailFence(false, true);

            if (decryptedRail != "Error")
                CaesarCipher(false, true, decryptedRail);
        }

        /* 
         * this function is used to go through the rail fence cipher
         * it takes two parameters, isEncrypt decides whether it is encrypting or decrypting
         * isMixed decides whether the function is being used for the mixed cipher
         */
        private string RailFence(bool isEncrypt, bool isMixed)
        {
            /*
             * in this part of the function, the program retrieves the input data from the user
             * first the program retrieves the input text from the textbox and then goes through verification methods
             * next the rails pop window is displayed where the user will enter the number of rails for the cipher
             */
            text = textbox.Text;
            final = "";

            if (text == "")
            {
                MessageBox.Show("You cannot input a blank string!");
                return "Error";
            }

            rails popup = new rails();
            DialogResult dialogresult = popup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                if (popup.numrails != "" && popup.numrails != "0" && (Convert.ToInt32(popup.numrails) > 0 && Convert.ToInt32(popup.numrails) < text.Length))
                {
                    numrails = Convert.ToInt32(popup.numrails);
                    isRunning = true;
                }
                else
                {
                    MessageBox.Show("Invalid input!");
                    return "Error";
                }
            }
            else if (dialogresult == DialogResult.Cancel)
                isRunning = false;

            // in the rail fence cipher, the process of encryption is very different to that of decryption
            // therefore there is an if statement to decide which procedure to use, which checks the parameter given
            if (isRunning)
            {
                if (isEncrypt)
                {
                    /*
                     * if the user wants to encrypt the data then the program...
                     *     creates an array with the same number of elements as the number of rails
                     *     loops over the characters in the input data and...
                     *         checks if there are more rails, if there are then...
                     *             it adds the current character to the next rail
                     *         otherwise...
                     *             it adds characters to previous rails
                     *     outputs the combined rails to the user
                     */
                    bool isSub = false;

                    rails = new string[numrails];
                    layer = 0;

                    foreach (char character in text)
                    {
                        rails[layer] += Convert.ToString(character);

                        if (layer >= (numrails - 1))
                            isSub = true;
                        else if (layer == 0)
                            isSub = false;

                        if (isSub)
                            layer -= 1;
                        else
                            layer += 1;
                    }

                    foreach (string item in rails)
                        final += item;

                    if (isMixed)
                        return final;
                    else
                        encryptedLabel.Text = final;
                }
                else
                {
                    /*
                     * if the user wants to decrypt the data then the program...
                     *     creates a two dimensional array with the same number of rows as the number of rails
                     *     and the same number of columns as the length of the input text
                     *     this array is filled with dots to represent a blank value
                     *     
                     *     the function then loops through the two dimensional array and then...
                     *         adds characters from the input text in a diagonal pattern to each rail
                     *         if the function is on the first or last rail then...
                     *             the next character in the input data is added to the rail
                     *             each character is separated by the same number of units as the variable init
                     *             if there is no more room in the rail for another character then it moves onto the next rail
                     *         otherwise...
                     *             the characters are added depending on the diagonal direction, this is calculated using the variables a, b and c
                     *     the data is read from left to right, up to down
                     *     this data is displayed back to the user
                     */
                    string[,] rfp = new string[numrails, text.Length];

                    for (int x = 0; x < numrails; x++)
                    {
                        for (int y = 0; y < text.Length; y++)
                            rfp[x, y] = ".";
                    }

                    int count = 0, b = 2, c = 1, init = (2 * numrails - 2);
                    int a = init - 2;

                    for (int i = 0; i < rfp.Length; i++)
                    {
                        c = 0;
                        for (int u = i; u < rfp.GetLength(1);)
                        {
                            if (count != text.Length)
                            {
                                if (i == 0 || i == (numrails - 1))
                                {
                                    rfp[i, u] = "" + text[count];
                                    u += init;
                                }
                                else
                                {
                                    rfp[i, u] = "" + text[count];
                                    if (c % 2 == 0)
                                        u += a;
                                    else if ((c % 2) == 1)
                                        u += b;
                                    c++;
                                }
                                count++;
                            }
                            else
                                break;
                        }

                        if (i != 0 && i != (numrails - 1))
                        {
                            a -= 2;
                            b += 2;
                        }
                    }

                    int move = 1;
                    count = 0;
                    string sb = "";

                    for (int i = 0; i < text.Length; i++)
                    {
                        if ((move % 2) != 0)
                        {
                            sb += rfp[count, i];
                            if (count == (numrails - 1))
                            {
                                move = 2;
                                count = (numrails - 2);
                            }
                            else
                                count++;
                        }
                        else if ((move % 2) == 0)
                        {
                            sb += rfp[count, i];
                            if (count == 0)
                            {
                                move = 1;
                                count = 1;
                            }
                            else
                                count--;
                        }
                    }
                    if (isMixed)
                        return sb;
                    else
                        decryptedLabel.Text = sb;
                }
            }
            return "";
        }

        // in the caesar cipher, the process of encryption is the same as decryption
        // the only difference is the order of the dictionary
        private void CaesarCipher(bool isEncrypt, bool isMixed, string input="")
        {
            /*
             * a dictionary is created with the key and pair depending on whether is encrypting or decrypting
             * if it is encrypting...
             *     the key is the predefined alphabet and the pair is a predefined string which is the alphabet shifted by three letters
             * otherwise...
             *     the key is the predefined shifted alphabet and the pair is the predefined alphabet
             * the function loops over each character in the input data and it is replaced with the pair in the dictionary
             * the replaced characters are displayed back to the user
             */
                if (isMixed)
                    text = input;
                else
                    text = textbox.Text;

                if (text == "")
                {
                    MessageBox.Show("You cannot input a blank string!");
                    return;
                }

                alphabetDict = new Dictionary<char, char>();
                string shifted = "defghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabc";

                for (int i = 0; i < shifted.Length; i++)
                {
                    if (isEncrypt)
                        alphabetDict.Add(alphabetOrig[i], shifted[i]);
                    else
                        alphabetDict.Add(shifted[i], alphabetOrig[i]);
                }
                string newTxt = "";

                foreach (var ch in text)
                {
                    if (ch == ' ')
                        newTxt += ' ';
                    else
                    {
                        newTxt += alphabetDict[ch];
                    }
                }

            if (isEncrypt)
                encryptedLabel.Text = newTxt;
            else
                decryptedLabel.Text = newTxt;  
        }
    }
}
