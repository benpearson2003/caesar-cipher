using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace CaesarCipher
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void encrypt_Click(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            int encryptionKey;
            int.TryParse(key.Text, out encryptionKey);

            foreach (char c in input.Text)
            {
                char letter = c;
                if (char.IsLetter(c))
                {
                    int num = (int)c;
                    letter = (char)(c + encryptionKey);
                    if (char.IsUpper(c))
                    {
                        if (letter > 'Z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else
                        {
                            if (letter < 'A')
                            {
                                letter = (char)(letter + 26);
                            }
                        }
                    }
                    else
                    {
                        if (char.IsLower(c))
                        {
                            if (letter > 'z')
                            {
                                letter = (char)(letter - 26);
                            }
                            else
                            {
                                if (letter < 'a')
                                {
                                    letter = (char)(letter + 26);
                                }
                            }
                        }
                    }
                    output.Text += letter;
                }
                else
                {
                    output.Text += c;
                }
            }
        }

        private void decrypt_Click(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            int encryptionKey;
            int.TryParse(key.Text, out encryptionKey);

            foreach (char c in input.Text)
            {
                char letter = c;
                if (char.IsLetter(c))
                {
                    int num = (int)c;
                    letter = (char)(c - encryptionKey);
                    if (char.IsUpper(c))
                    {
                        if (letter > 'Z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else
                        {
                            if (letter < 'A')
                            {
                                letter = (char)(letter + 26);
                            }
                        }
                    }
                    else
                    {
                        if (char.IsLower(c))
                        {
                            if (letter > 'z')
                            {
                                letter = (char)(letter - 26);
                            }
                            else
                            {
                                if (letter < 'a')
                                {
                                    letter = (char)(letter + 26);
                                }
                            }
                        }
                    }
                    output.Text += letter;
                }
                else
                {
                    output.Text += c;
                }
            }
        }
    }
}