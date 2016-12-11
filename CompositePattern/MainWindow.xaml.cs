using CompositePattern.CompositeElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompositePattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            CompositeElement basicElement = new CompositeElement();
            
            BaseElement firstNameElement = new NameElement(firstNameTB.Text);
            BaseElement lastNameElement = new NameElement(lastNameTB.Text);
            BaseElement addressElement = new AddressElement(addressTB.Text);

            basicElement.Add(firstNameElement);
            basicElement.Add(lastNameElement);
            basicElement.Add(addressElement);

            if(basicElement.IsValid())
            {
                messageTBForm1.Text = "Basic Info Is Correct";
                messageTBForm1.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                messageTBForm1.Text = "Error in basic info:" + Environment.NewLine + basicElement.Message;
                messageTBForm1.Foreground = new SolidColorBrush(Colors.Red);
            }


            CompositeElement otherElement = new CompositeElement();

            BaseElement contactNumberElement = new ContactNumberElement(contactNumberTb.Text);
            BaseElement emailElement = new EmailElement(emailAddressTB.Text);
            BaseElement webElement = new WebElement(webTB.Text);

            otherElement.Add(contactNumberElement);
            otherElement.Add(emailElement);
            otherElement.Add(webElement);

            if (otherElement.IsValid())
            {
                messageTBForm2.Text = "Other Info Is Correct";
                messageTBForm2.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                messageTBForm2.Text = "Error in other info:" + Environment.NewLine + otherElement.Message;
                messageTBForm2.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
