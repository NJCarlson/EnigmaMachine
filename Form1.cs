using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    public partial class EnigmaMachine : Form
    {
        public EnigmaMachine()
        {
            InitializeComponent();

            //Set Starting Variables:
            comboBox1.Items.Insert(0, "Brittany's Algorithm");

            //to change which item is selected in the combo box:
            comboBox1.SelectedIndex = 0;

            //set the example key:
            textBox1.Text = " [XZNLWEBGJHQDYVTKFUOMPCIASRxznlwebgjhqdyvtkfuompciasr";

            //to add more options to the combo box:
            //comboBox1.Items.Insert(1, "");
        }

        //DECRYPTION:
        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        string alphabet = " [abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        string key = textBox1.Text;
                        string encrypted_message = richTextBox1.Text;
                        string decrypted_message = "";

                        for (int i = 0; i < encrypted_message.Length; i++)
                        {
                            int position = -1;

                            for (int j = 0; j < key.Length; j++)
                            {
                                if (key[j] == encrypted_message[i]) 
                                {
                                    position = j;
                                    break;
                                }
                            }

                            if (position != -1)
                            {
                                char new_char = alphabet[position];
                                decrypted_message += new_char;
                            }
                            else
                            {
                                decrypted_message += encrypted_message[i];
                            }
                        }

                        richTextBox1.Text = decrypted_message;

                    }
                        break;
                        default:
                    break;
                    
            }
        }

        //ENCRYPTION:
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        string alphabet = " [abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        string key = textBox1.Text;
                        string encrypted_message = "";
                        string decrypted_message = richTextBox1.Text;

                        for (int i = 0; i < decrypted_message.Length; i++)
                        {
                            int position = -1;

                            for (int j = 0; j < key.Length; j++)
                            {
                                if (alphabet[j] == decrypted_message[i])
                                {
                                    position = j;
                                    break;
                                }
                            }

                            if (position != -1)
                            {
                                char new_char = key[position];
                                encrypted_message += new_char;
                            }
                            else
                            {
                                encrypted_message += decrypted_message[i];
                            }
                        }

                        richTextBox1.Text = encrypted_message;

                    }
                    break;
                    default:
                    break;

            }
        }
    }
}

