using System.Diagnostics;

namespace TestMauiButton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageBtn_Pressed(object sender, EventArgs e)
        {
            Debug.WriteLine("ImageButton pressed");
        }

        private void ImageBtn_Released(object sender, EventArgs e)
        {
            Debug.WriteLine("ImageButton released");
        }

        private void Btn_Pressed(object sender, EventArgs e)
        {
            Debug.WriteLine("Button pressed");
        }

        private void Btn_Released(object sender, EventArgs e)
        {
            Debug.WriteLine("Button released");
        }
    }
}
