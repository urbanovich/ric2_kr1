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
    public class SaveButton: Button
    {
       public TextBox title {get; set;}
       public TextBox price {get; set;}
       public TextBox startTime {get; set;}
       public TextBox endTime {get; set;}

        public SaveButton()
        {
            this.Text = "Save"; 
            this.AutoSize = true;

            this.Click += this.ClickHandler;
        }
        
        private void ClickHandler(Object sender, EventArgs e)
        {
            string title = this.title.Text;
            string price = this.price.Text;
            string startTime = this.startTime.Text;
            string endTime = this.endTime.Text;

            Subscribe subscribe = new Subscribe();
            subscribe.title = title;
            subscribe.price = price;
            subscribe.startTime = startTime;
            subscribe.endTime = endTime;
            DataFile.Write(subscribe);
            MessageBox.Show("Saved");
        }
    }
}