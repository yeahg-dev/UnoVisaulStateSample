namespace VisualStateSample;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void Button_Click_Highlighted(object sender, RoutedEventArgs e)
    {
        VisualStateManager.GoToState(this, "Highlighted", true);
    }

    private void Button_Click_Loading(object sender, RoutedEventArgs e)
    {
        VisualStateManager.GoToState(this, "Loading", true);
    }
}
