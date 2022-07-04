using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace New_Employee_Information_ToTextFile
{
    public partial class Form1 : Form
    {
        // The path where we want to save the text file.
        public static readonly string path = @"C:\Portfolio CSharp\Windows Forms App CSharp\New Employee Information ToTextFile";
        // Path + File name.
        public static readonly string textFile = path + @"\EmployeeData.txt";

        // Gets the date & Time
        private static readonly DateTime dt = DateTime.Now;
        // Converts 'dt' into the correct format of date and time.
        readonly string dateOfMaking = dt.ToString("dd-MM-yyyy HH:mm");

        // Fiels for the employee information.
        private int id;
        private string name;
        private string lastName;
        private string eMail;

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Creates the file & path. And appends the employee information to this file.
        /// </summary>
        public void CreateAndAppend(Person p, string dt)
        {
            // Formats the information into a string
            string appendContent = $"ID: {p.ID} \nName: {p.NAME} \nLastName: {lastName} \nEmail: {p.EMAIL} \nDate Of Creation: {dt} \n\n";


            // Creates a path & file if it doesn't exist yet.
            // Or just appends the employee information to the text file, if the path already exists.
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    File.WriteAllText(textFile, appendContent);
                }
                else
                {
                    File.AppendAllText(textFile, appendContent);
                }
            }
            // Catches any Exceptions, and displays it to the user.
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            
        }


        /// <summary>
        /// Reads the employee file.
        /// </summary>
        public void ReadFile()
        {
            try
            {
                string read = File.ReadAllText(textFile);
                RichTextBox.Text = read;
            }
            catch (Exception)
            {
                MessageBox.Show("No file to read from.");
            }
        }


        #region TextBoxes

        /// <summary>
        /// Checks all changes to the ID Textbox.
        /// </summary>
        private void TextBoxId_TextChanged(object sender, EventArgs e)
        {
            if(TextBoxId.Text == "")
            {
                
            }
            else
            {
                try
                {
                    id = int.Parse(TextBoxId.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("This field requires numbers.");
                    TextBoxId.Clear();
                }
                
            }
            
            
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            name = TextBoxName.Text;
        }

        private void TextBoxLastname_TextChanged(object sender, EventArgs e)
        {
            lastName = TextBoxLastname.Text;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            eMail = TextBoxEmail.Text;
        }



        #endregion


        #region Buttons

        /// <summary>
        /// Creates a person object. And then adds it to the employee file.
        /// </summary>
        private void ButtonAddNewPerson_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                ID = id,
                NAME = name,
                LASTNAME = lastName,
                EMAIL = eMail
            };

            CreateAndAppend(person, dateOfMaking);

            MessageBox.Show("New person added.");
        }

        /// <summary>
        /// Calls the 'ReadFile' method to read the employee file.
        /// </summary>
        private void ButtonShowPeople_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        #endregion
    }
}
