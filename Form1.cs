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

            Subscribe subscribe = DataFile.Read();
            Label titleLavel = new Label();

            titleLavel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            titleLavel.ImageAlign = ContentAlignment.TopLeft;
            titleLavel.UseMnemonic = true;
            titleLavel.Text = "Newspaper Title:";
            
            titleLavel.Size = new Size (titleLavel.PreferredWidth, titleLavel.PreferredHeight);
            titleLavel.Location = new Point(10, 10);
            this.Controls.Add(titleLavel);

            TextBox title = new System.Windows.Forms.TextBox();
            title.AcceptsReturn = true;
            title.AcceptsTab = true;
            title.Multiline = true;
            title.Location = new Point(10, 40);
            title.Size = new Size(300, 30);

            title.Text = subscribe.title;
            
            this.Controls.Add(title);

            Label priceLavel = new Label();

            priceLavel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            priceLavel.ImageAlign = ContentAlignment.TopLeft;
            priceLavel.UseMnemonic = true;
            priceLavel.Text = "Price:";
            
            priceLavel.Size = new Size (priceLavel.PreferredWidth, priceLavel.PreferredHeight);
            priceLavel.Location = new Point(10, 80);
            this.Controls.Add(priceLavel);

            TextBox price = new System.Windows.Forms.TextBox();
            price.AcceptsReturn = true;
            price.AcceptsTab = true;
            price.Multiline = true;
            price.Location = new Point(10, 110);
            price.Size = new Size(300, 30);

            price.Text = subscribe.price;
            
            this.Controls.Add(price);

            Label startTimeLabel = new Label();

            startTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            startTimeLabel.ImageAlign = ContentAlignment.TopLeft;
            startTimeLabel.UseMnemonic = true;
            startTimeLabel.Text = "Start Time Sabscribe:";
            
            startTimeLabel.Size = new Size (startTimeLabel.PreferredWidth, startTimeLabel.PreferredHeight);
            startTimeLabel.Location = new Point(10, 150);
            this.Controls.Add(startTimeLabel);

            TextBox startTime = new System.Windows.Forms.TextBox();
            startTime.AcceptsReturn = true;
            startTime.AcceptsTab = true;
            startTime.Multiline = true;
            startTime.Location = new Point(10, 180);
            startTime.Size = new Size(300, 30);

            startTime.Text = subscribe.startTime;
            
            this.Controls.Add(startTime);


            Label endTimeLabel = new Label();

            endTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            endTimeLabel.ImageAlign = ContentAlignment.TopLeft;
            endTimeLabel.UseMnemonic = true;
            endTimeLabel.Text = "End Time Subscribe:";
            
            endTimeLabel.Size = new Size (endTimeLabel.PreferredWidth, endTimeLabel.PreferredHeight);
            endTimeLabel.Location = new Point(10, 210);
            this.Controls.Add(endTimeLabel);

            TextBox endTime = new System.Windows.Forms.TextBox();
            endTime.AcceptsReturn = true;
            endTime.AcceptsTab = true;
            endTime.Multiline = true;
            endTime.Location = new Point(10, 240);
            endTime.Size = new Size(300, 30);

            endTime.Text = subscribe.endTime;
            
            this.Controls.Add(endTime);
    
            // Creating and setting the properties of Button 
            SaveButton SaveButton = new SaveButton();
            SaveButton.title = title;
            SaveButton.price = price;
            SaveButton.startTime = startTime;
            SaveButton.endTime = endTime;
            SaveButton.Location = new Point(420, 390);  

            // Adding this button to form 
            this.Controls.Add(SaveButton); 
        } 

    }
}
