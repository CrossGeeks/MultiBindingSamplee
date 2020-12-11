using Xamarin.Forms;

namespace MultiBinding
{
    public partial class MainPage : ContentPage
    {
        public string FirstName { get; set; } = "Charlin";
        public string LastName { get; set; } = "Agramonte";

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
