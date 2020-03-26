using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace MindfulnessDribble.Controller
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabsController : ContentView
    {
        public TabsController()
        {
            InitializeComponent();
        }
        private async void LifeGratitude(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}