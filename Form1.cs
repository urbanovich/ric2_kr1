using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ric2_kr_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e) 
        { 

            this.Text = "RIC KR 1";

            TextBox textBox1 = new System.Windows.Forms.TextBox();
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.Multiline = true;
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox1.Location = new Point(10, 10);
            textBox1.Size = new Size(400, 400);

            textBox1.Text = DataFile.Read();
            
            this.Controls.Add(textBox1);
    
            // Creating and setting the properties of Button 
            SaveButton SaveButton = new SaveButton();
            SaveButton.TextBoxField = textBox1;
            SaveButton.Location = new Point(420, 390);  

            // Adding this button to form 
            this.Controls.Add(SaveButton); 
        } 

    }
}
