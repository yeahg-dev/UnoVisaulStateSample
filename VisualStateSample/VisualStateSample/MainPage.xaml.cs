namespace VisualStateSample;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        VisualStateManager.GoToState(this, "Highlighted", true);
    }
}
