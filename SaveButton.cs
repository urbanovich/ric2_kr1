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
       public TextBox TextBoxField {get; set;}

        public SaveButton()
        {
            this.Text = "Save"; 
            this.AutoSize = true;

            this.Click += this.ClickHandler;
        }
        
        private void ClickHandler(Object sender, EventArgs e)
        {
            DataFile.Write(this.TextBoxField.Text);
            MessageBox.Show("Saved");
        }
    }
}