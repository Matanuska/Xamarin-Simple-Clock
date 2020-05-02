using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Simple_Clock
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    lblclock.Text = DateTime.Now.ToString("hh:mm:ss:f");
                });
                return true;
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            lblresult.Text = string.Concat(lblresult.Text, lblclock.Text, Environment.NewLine);

        }
    }
}
