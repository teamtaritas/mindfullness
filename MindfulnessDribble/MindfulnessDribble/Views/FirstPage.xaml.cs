using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace MindfulnessDribble
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            SleepFrame.BackgroundColor = Color.Transparent;
            InnerFrame.BackgroundColor = Color.Transparent;
            StressFrame.BackgroundColor = Color.Transparent;
            AnxietyFrame.BackgroundColor = Color.Transparent;
            PeaceFrame.BackgroundColor = Color.Transparent;

        }
        private void SleepGesture(object sender, EventArgs e)
        {
            SleepFrame.IsVisible = true;
            SleepFrame.BackgroundColor = Color.FromHex("#4F3C75");
            SleepLabel.TextColor = Color.White;
            InnerFrame.BackgroundColor = Color.Transparent;
            StressFrame.BackgroundColor = Color.Transparent;
            AnxietyFrame.BackgroundColor = Color.Transparent;
            PeaceFrame.BackgroundColor = Color.Transparent;
            InnerLabel.TextColor = Color.FromHex("#4F3C75");
            StressLabel.TextColor = Color.FromHex("#4F3C75");
            AnxietyLabel.TextColor = Color.FromHex("#4F3C75");
            PeaceLabel.TextColor = Color.FromHex("#4F3C75");
        }
        private void InnerGesture(object sender, EventArgs e)
        {
            InnerFrame.IsVisible = true;
            InnerFrame.BackgroundColor = Color.FromHex("#4F3C75");
            InnerLabel.TextColor = Color.White;

            SleepFrame.BackgroundColor = Color.Transparent;
            StressFrame.BackgroundColor = Color.Transparent;
            AnxietyFrame.BackgroundColor = Color.Transparent;
            PeaceFrame.BackgroundColor = Color.Transparent;
            SleepLabel.TextColor = Color.FromHex("#4F3C75");
            StressLabel.TextColor = Color.FromHex("#4F3C75");
            AnxietyLabel.TextColor = Color.FromHex("#4F3C75");
            PeaceLabel.TextColor = Color.FromHex("#4F3C75");
        }
        private void StressGesture(object sender, EventArgs e)
        {
            StressFrame.IsVisible = true;
            StressFrame.BackgroundColor = Color.FromHex("#4F3C75");
            StressLabel.TextColor = Color.White;
            InnerFrame.BackgroundColor = Color.Transparent;
            SleepFrame.BackgroundColor = Color.Transparent;
            AnxietyFrame.BackgroundColor = Color.Transparent;
            PeaceFrame.BackgroundColor = Color.Transparent;
            InnerLabel.TextColor = Color.FromHex("#4F3C75");
            SleepLabel.TextColor = Color.FromHex("#4F3C75");
            AnxietyLabel.TextColor = Color.FromHex("#4F3C75");
            PeaceLabel.TextColor = Color.FromHex("#4F3C75");
        }
        private void AnxietyGesture(object sender, EventArgs e)
        {
            AnxietyFrame.IsVisible = true;
            AnxietyFrame.BackgroundColor = Color.FromHex("#4F3C75");
            AnxietyLabel.TextColor = Color.White;
            InnerFrame.BackgroundColor = Color.Transparent;
            StressFrame.BackgroundColor = Color.Transparent;
            SleepFrame.BackgroundColor = Color.Transparent;
            PeaceFrame.BackgroundColor = Color.Transparent;
            InnerLabel.TextColor = Color.FromHex("#4F3C75");
            StressLabel.TextColor = Color.FromHex("#4F3C75");
            SleepLabel.TextColor = Color.FromHex("#4F3C75");
            PeaceLabel.TextColor = Color.FromHex("#4F3C75");
        }
        private void PeaceGesture(object sender, EventArgs e)
        {
            PeaceFrame.IsVisible = true;
            PeaceFrame.BackgroundColor = Color.FromHex("#4F3C75");
            PeaceLabel.TextColor = Color.White;
            InnerFrame.BackgroundColor = Color.Transparent;
            StressFrame.BackgroundColor = Color.Transparent;
            AnxietyFrame.BackgroundColor = Color.Transparent;
            SleepFrame.BackgroundColor = Color.Transparent;
            InnerLabel.TextColor = Color.FromHex("#4F3C75");
            StressLabel.TextColor = Color.FromHex("#4F3C75");
            AnxietyLabel.TextColor = Color.FromHex("#4F3C75");
            SleepLabel.TextColor = Color.FromHex("#4F3C75");
        }
    }
}