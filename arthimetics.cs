using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public class arthimetics
    {
        public void main(object sender, RoutedEventArgs s, string textBoxs)
        {
            Button x = sender as Button;
            TextBox TextBox = sender as TextBox;
            this.checkTextBox(textBoxs, x.Content.ToString());
            
        }
        void checkTextBox(string textBox, string buttonPressed)
        {
            List<string> text = textBox.Split(' ').ToList();
            string[] arthi = { "x", "-", "+", "/" };
/*            if (arthi.Contains(buttonPressed))
            {
                for(int i = 0; i < text.Count; i++) {
                    MessageBox.Show(text[i]);
                }
            }*/
        }
    }
}
