using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Selection
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void compareClick(object sender, RoutedEventArgs e)
        {
            int diff = dateCompare(first, second);
            info.Text = "";
            show("firstDate == secondDate", diff == 0);
            show("firstDate != secondDate", diff != 0);
            show("firstDate <  secondDate", diff < 0);
            show("firstDate <= secondDate", diff <= 0);
            show("firstDate >  secondDate", diff > 0);
            show("firstDate >= secondDate", diff >= 0);
        }

        private void show(string exp, bool result)
        {
            info.Text += exp;
            info.Text += " : " + result.ToString();
            info.Text += "\n";
        }

        /// <summary>
        /// Goes through all the options, and assigns a specific number to result, since we don't
        /// only wanna know if the dates are the same, we also want to know if it's one is 
        /// an earlier or a later date.
        /// 
        /// We don't use the Date Compare method because this exercise is meant to show if/else if and boolean statements in general.
        /// </summary>
        /// <param name="leftHandSide">The first date parameter we pass, located on the left side of our program.</param>
        /// <param name="rightHandSide">The second date parameter we pass, located on the right side of our program.</param>
        /// <returns></returns>
        private int dateCompare(DateTime leftHandSide, DateTime rightHandSide)
        {
            int result;

            if (leftHandSide.Year < rightHandSide.Year)
            {
                result = -1;
            }
            else if (leftHandSide.Year > rightHandSide.Year)
            {
                result = 1;
            }
            else if (leftHandSide.Month < rightHandSide.Month)
            {
                result = -1;
            }
            else if (leftHandSide.Month > rightHandSide.Month)
            {
                result = 1;
            }
            else if (leftHandSide.Day < rightHandSide.Day)
            {
                result = -1;
            }
            else if (leftHandSide.Day > rightHandSide.Day)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            return result;
        }

        #region Conversion properties to cater for the deifferences betwwen the DatePicker control in Windows 7 and Windows 8.1
        private DateTime first
        {
            get { return this.firstDate.SelectedDate.GetValueOrDefault(this.firstDate.DisplayDate); }
        }

        private DateTime second
        {
            get { return this.secondDate.SelectedDate.GetValueOrDefault(this.secondDate.DisplayDate); }
        }
        #endregion
    }
}
