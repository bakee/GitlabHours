using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GitlabHours
{
    public partial class MainPage : ContentPage
    {
        private readonly HourConverter _hourConverter;
        public MainPage()
        {
            InitializeComponent();
            _hourConverter = new HourConverter();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var input = entryHours.Text;
            var output = _hourConverter.Convert(input);
            labelHours.Text = output;
        }

        private void AppendUnit(string hourUnit)
        {
            var currentText = entryHours.Text;
            currentText += hourUnit + " ";
            entryHours.Text = currentText;
            entryHours.Focus();
            entryHours.CursorPosition = entryHours.Text.Length;
        }

        private void buttonMonth_Clicked(object sender, EventArgs e)
        {
            AppendUnit(LogUnit.Month);
        }

        private void buttonWeek_Clicked(object sender, EventArgs e)
        {
            AppendUnit(LogUnit.Week);
        }

        private void buttonDay_Clicked(object sender, EventArgs e)
        {
            AppendUnit(LogUnit.Day);
        }

        private void buttonHour_Clicked(object sender, EventArgs e)
        {
            AppendUnit(LogUnit.Hour);
        }

        private void buttonMinute_Clicked(object sender, EventArgs e)
        {
            AppendUnit(LogUnit.Minute);
        }

        private void buttonClear_Clicked(object sender, EventArgs e)
        {
            entryHours.Text = "";
            entryHours.Focus();
        }

        private void entryHours_TextChanged(object sender, TextChangedEventArgs e)
        {
            Button_Clicked(sender, e);
        }
    }
}
