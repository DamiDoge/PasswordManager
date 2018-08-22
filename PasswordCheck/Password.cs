//Damien Moeller
//Cybersecurity Password Project
//Visual Studio C# Windows Form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCheck
{
    public partial class Password : Form
    {
        //Array to hold all dictionary words of length > 4
        private List<string> dictWords = new List<string>();
        //String to hold all screen output to print to a file
        private string passOutput = "";

        public Password()
        {
            InitializeComponent();
        }

        //Function to read in dictionary text file and stores them in an array
        private void ReadDictionary()
        {
            //Read in all words from dictionary file
            string[] tempWords = System.IO.File.ReadAllLines("./Dictionary20K.txt");

            //Look through all the dictionary words and extract only the ones with > 4 length
            for (int i = 0; i < tempWords.Length; i++)
            {
                if (tempWords[i].Length > 4)
                {
                    dictWords.Add(tempWords[i]);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Ensure that the passowrd minimum length can not fall below the total of its parts.
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(passLength.Value < (numUpper.Value + numLower.Value + numNumeric.Value + numSpecial.Value))
            {
                passLength.Value = numUpper.Value + numLower.Value + numNumeric.Value + numSpecial.Value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void numSpecial_ValueChanged(object sender, EventArgs e)
        {
            //Ensure that the minimum number of each part of the password 
            //adds up to the total minimun password lenght requirement.
            if ((numUpper.Value + numLower.Value + numNumeric.Value + numSpecial.Value) > passLength.Value)
            {
                numSpecial.Value = passLength.Value - numLower.Value - numNumeric.Value - numUpper.Value;
            }
        }

        private void numUpper_ValueChanged(object sender, EventArgs e)
        {
            //Ensure that the minimum number of each part of the password 
            //adds up to the total minimun password lenght requirement.
            if ((numUpper.Value + numLower.Value + numNumeric.Value + numSpecial.Value) > passLength.Value)
            {
                numUpper.Value = passLength.Value - numLower.Value - numNumeric.Value - numSpecial.Value;
            }
        }

        private void numLower_ValueChanged(object sender, EventArgs e)
        {
            //Ensure that the minimum number of each part of the password 
            //adds up to the total minimun password lenght requirement.
            if ((numUpper.Value + numLower.Value + numNumeric.Value + numSpecial.Value) > passLength.Value)
            {
                numLower.Value = passLength.Value - numUpper.Value - numNumeric.Value - numSpecial.Value;
            }
        }

        private void numNumeric_ValueChanged(object sender, EventArgs e)
        {
            //Ensure that the minimum number of each part of the password 
            //adds up to the total minimun password lenght requirement.
            if ((numUpper.Value + numLower.Value + numNumeric.Value + numSpecial.Value) > passLength.Value)
            {
                numNumeric.Value = passLength.Value - numLower.Value - numUpper.Value - numSpecial.Value;
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            //Message to build to give meaningful feedback to the user.
            string feedbackMessage = "\r\nPassword entered: " + inpassword.Text + "\r\n";
            //Assume the password is strong unless it fails to meet criteria.
            bool isStrong = true;
            //Holds the number of each type of character
            int upper = 0;
            int lower = 0;
            int numbers = 0;
            int special = 0;
            //Iterate through each character in the password string
            foreach(char c in inpassword.Text)
            {
                //Counts uppercase letters
                if(char.IsUpper(c))
                {
                    upper++;
                }
                //Counts lowercase letters
                else if(char.IsLower(c))
                {
                    lower++;
                }
                //Counts numerical symbols
                else if(char.IsNumber(c))
                {
                    numbers++;
                }
                //If it is none of the above assume it is a special character
                //Counts spaces as special characters
                else
                {
                    special++;
                }
            }

            //Check that the password meets the length specification
            if (inpassword.Text.Length < passLength.Value)
            {
                feedbackMessage += "The password must have more characters.\r\n";
                isStrong = false;
            }

            //Check if the number of lowercase characters is less than the minimun allowed
            //as specified by the user.
            if (lower < numLower.Value)
            {
                feedbackMessage += "The password must have more lowercase letters.\r\n";
                isStrong = false;
            }

            //Check if the number of uppercase characters is less than the minimun allowed
            //as specified by the user.
            if (upper < numUpper.Value)
            {
                feedbackMessage += "The password must have more uppercase letters.\r\n";
                isStrong = false;
            }

            //Check if the number of numeric characters is less than the minimun allowed
            //as specified by the user.
            if (numbers < numNumeric.Value)
            {
                feedbackMessage += "The password must have more numeric characters.\r\n";
                isStrong = false;
            }

            //Check if the number of special characters is less than the minimun allowed
            //as specified by the user.
            if (special < numSpecial.Value)
            {
                feedbackMessage += "The password must have more special characters.\r\n";
                isStrong = false;
            }

            //Used to check for substring with case insensitivity
            string checkpassword = inpassword.Text.ToLower();

            //Check for names inside password if option is selected.
            if (!isName.Checked)
            {
                //Check that the user put in their first and last name
                if (firstName.Text == "" || lastName.Text == "")
                {
                    feedbackMessage += "Please type in your first and last name.\r\n";
                    isStrong = false;
                }

                //Check for the substring put in the first and last names in the password.
                if (checkpassword.Contains(firstName.Text.ToLower()) || checkpassword.Contains(lastName.Text.ToLower()))
                {
                    feedbackMessage += "The password may not contain your name.\r\n";
                    isStrong = false;
                }
            }

            //Check if the user is allowing the user's email within the password.
            if (!isEmail.Checked)
            {
                //Make sure an e-mail has been entered.
                if (emailBox.Text == "")
                {
                    feedbackMessage += "Please type in your e-mail.\r\n";
                    isStrong = false;
                }
                //Something is entered in the e-mail text box.
                else
                {
                    //Check that the email is in the format x@site.ext
                    if (emailBox.Text.Contains('@'))
                    {
                        //We are only interested in everything before the @ for the check
                        //Find and store the index of the @ so that everything after can be removed
                        int atChar = emailBox.Text.IndexOf('@');
                        //Remoeve everything from the @ symbol to the end of the string
                        string email = emailBox.Text.Remove(atChar, (emailBox.Text.Length - atChar));
                        if (inpassword.Text.Contains(email))
                        {
                            feedbackMessage += "Your password may not contain an email.\r\n";
                            isStrong = false;
                        }
                    }
                    //Assume the user omitted the site and extension
                    else
                    {
                        if (checkpassword.Contains(emailBox.Text.ToLower()))
                        {
                            feedbackMessage += "Your password may not contain an email.\r\n";
                            isStrong = false;
                        }
                    }
                }
            }

            //Check if the user is allowing dictionary words.
            if(!isDictionary.Checked)
            {
                //Check the password for every dictionary word.
                foreach (string word in dictWords)
                {
                    if (checkpassword.Contains(word.ToLower()))
                    {
                        feedbackMessage += "The password may not contain dictionary words.\r\n";
                        isStrong = false;
                    }
                }
            }

            //If the password passes all checks 
            if(isStrong == true)
            {
                //If the password passes all checks then it is strong by users specs.
                feedbackMessage += "This password is strong.\r\n";
            }

            //Display to the user feedback about the password.
            DisplayFeedback(feedbackMessage);

            //Save all the output messages so they can be written to a file.
            passOutput += feedbackMessage;
        }

        //Funtion to output a message for a password that is not accepted.
        private void DisplayFeedback(string feedback)
        {
            var message = MessageBox.Show(this, feedback, "Password Strength");
        }

        //On program startup, read in the entire dictionary.
        private void Password_Load(object sender, EventArgs e)
        {
            ReadDictionary();
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void generatePass_Click(object sender, EventArgs e)
        {
            //Instantiate a random generator so random passwords can be created.
            Random rGenerator = new Random();
            //List to hold however many passwords that are generated.
            List<string> generatedWords = new List<string>();

            for (int i = 0; i < numPasswords.Value; i++)
            {
                //Set the length of the password to be generated to 12
                //if the password must be longer due to user requirements
                //that'll be handled later.
                int length = 12;
                string password = "";
                //Character array holds all the uppercase characters needed for the password.
                char[] upperCase = new char[(int)numUpper.Value];
                //Fills the array with random uppercase characters (ASCII value 65-90)
                for(int j = 0; j < upperCase.Length; j++)
                {
                    upperCase[j] = (char)rGenerator.Next(65, 90);
                }
                //Character array holds all the lowercase characters needed for the password.
                char[] lowerCase = new char[(int)numLower.Value];
                //Fills the array with random lowercase characters (ASCII value 97-122)
                for (int j = 0; j < lowerCase.Length; j++)
                {
                    lowerCase[j] = (char)rGenerator.Next(97, 122);
                }
                //Array which holds all numeric characters needed
                char[] numberic = new char[(int)numNumeric.Value];
                //Fills the array with random numeric characters (ASCII values 48-57)
                for (int j = 0; j < numberic.Length; j++)
                {
                    numberic[j] = (char)rGenerator.Next(48, 57);
                }
                //Array which holds all special characters needed
                char[] special = new char[(int)numSpecial.Value];
                //Fills the array with random special characters
                for (int j = 0; j < special.Length; j++)
                {
                    //Special characters are within 4 different ranges in the ASCII table
                    //Randomly generate a number from 1 to 4 to pick which range
                    int rand = rGenerator.Next(1, 4);
                    switch(rand)
                    {
                        case 1:
                            special[j] = (char)rGenerator.Next(33, 47);
                            break;
                        case 2:
                            special[j] = (char)rGenerator.Next(58, 64);
                            break;
                        case 3:
                            special[j] = (char)rGenerator.Next(91, 96);
                            break;
                        case 4:
                            special[j] = (char)rGenerator.Next(123, 126);
                            break;
                    }
                }
                //If the minimum required length is greater than this password length
                //then increase the length.
                if (length < passLength.Value)
                {
                    length = (int)passLength.Value;
                }
                //Put all of the randomly generated characters into the password.
                password += new string(lowerCase);
                password += new string(upperCase);
                password += new string(numberic);
                password += new string(special);
                //Fill the rest of the password with random characters until it meets criteria
                while (password.Length < length)
                {
                    password += (char)rGenerator.Next(33, 126);
                }
                //Change the string to manipulatable array
                char[] charPassword = password.ToArray<char>();
                //Scrammble up the characters in the password
                for (int j = 0; j < password.Length; j++)
                {
                    //Get the index of a random character within the array
                    int randchar1 = rGenerator.Next(0, password.Length - 1);
                    //Hold on to a copy of the random character for swapping
                    char temp = charPassword[randchar1];
                    //Swap the current character and a random character
                    charPassword[randchar1] = charPassword[j];
                    charPassword[j] = temp;
                }
                //Change the password back to a string
                password = new string(charPassword);
                //Place the password into the list off passwords
                generatedWords.Add(password);
            }
            //Place the list of passwords onto the GUI
            PasswordList.DataSource = generatedWords;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Code block from C# API 
            //msdn.microsoft.com/en-us/library/system.windows.forms.savefiledialog(v=vs.110).aspx
            //Stream to write passwords and dialog for saving the file.
            Stream wordStream;
            SaveFileDialog savePasswords = new SaveFileDialog();

            //Set properties of the save dialog.
            savePasswords.Filter = "txt files (*.txt)|*.txt";
            savePasswords.FilterIndex = 2;
            savePasswords.RestoreDirectory = true;

            if (savePasswords.ShowDialog() == DialogResult.OK)
            {
                if ((wordStream = savePasswords.OpenFile()) != null)
                {
                    //Create a stream writer so a file can be written to.
                    StreamWriter textW = new StreamWriter(wordStream);
                    textW.WriteLine("Damien Moeller\r\nGenerated Passwords:\n");
                    //Write every generated password to the specified file.
                    foreach(string s in PasswordList.Items)
                    {
                        textW.WriteLine(s);
                    }
                    //Close both streams so the file can write.
                    textW.Close();
                    wordStream.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Code block from C# API 
            //msdn.microsoft.com/en-us/library/system.windows.forms.savefiledialog(v=vs.110).aspx
            //Stream to write passwords and dialog for saving the file.
            Stream wordStream;
            SaveFileDialog savePasswords = new SaveFileDialog();

            //Set properties of the save dialog.
            savePasswords.Filter = "txt files (*.txt)|*.txt";
            savePasswords.FilterIndex = 2;
            savePasswords.RestoreDirectory = true;

            if (savePasswords.ShowDialog() == DialogResult.OK)
            {
                if ((wordStream = savePasswords.OpenFile()) != null)
                {
                    //Create a stream writer so a file can be written to.
                    StreamWriter textW = new StreamWriter(wordStream);
                    textW.WriteLine("Damien Moeller\n");
                    //Write the screen output onto a file for records
                    textW.WriteLine(passOutput);
                    //Close both streams so the file can write.
                    textW.Close();
                    wordStream.Close();
                }
            }
        }
    }
}
