using System.Diagnostics;

namespace TestMauiButton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CounterBtn_Pressed(object sender, EventArgs e)
        {
            Debug.WriteLine("pressed");
        }

        private void CounterBtn_Released(object sender, EventArgs e)
        {
            Debug.WriteLine("released");
        }
    }
}
