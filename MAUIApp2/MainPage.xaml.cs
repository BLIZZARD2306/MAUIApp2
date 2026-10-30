namespace MAUIApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Changes Peter to Reality
        private void OnPeterClicked(object? sender, EventArgs e)
        {
            PeterImageBtn.Source = "peter_reality2.png";
            PeterLabel.Text = "Reality";
        }

        // Changes Stewie to Reality
        private void OnStewieClicked(object? sender, EventArgs e)
        {
            StewieImageBtn.Source = "stewie_reality.png";
            StewieLabel.Text = "Reality";
        }
    }
}