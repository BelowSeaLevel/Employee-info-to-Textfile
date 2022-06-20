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
        public static readonly string path = @"C:\Portfolio CSharp\Windows Forms App CSharp\New Employee Information ToTextFile";
        public static readonly string textFile = path + @"\EmployeeData.txt";


        private static readonly DateTime dt = DateTime.Now;
        readonly string dateOfMaking = dt.ToString("dd-MM-yyyy HH:mm");


        private int id;
        private string name;
        private string lastName;
        private string eMail;

        public Form1()
        {
            InitializeComponent();
        }

        

        public void CreateAndAppend(Person p, string dt)
        {
            string appendContent = $"ID: {p.ID} \nName: {p.NAME} \nLastName: {lastName} \nEmail: {p.EMAIL} \nDate Of Creation: {dt} \n\n";

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
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            
        }



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

        private void ButtonShowPeople_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        #endregion
    }
}
