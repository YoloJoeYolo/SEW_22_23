namespace LayoutAndNavigation;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
		Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Accelerometer.IsSupported)
        {
            Accelerometer.Start(SensorSpeed.UI);
        }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        Accelerometer.Stop();
    }

    private void Accelerometer_ReadingChanged(object? sender, AccelerometerChangedEventArgs e)
	{
		var data = e.Reading;
		lbX.Text = data.Acceleration.X.ToString();
		lbY.Text = data.Acceleration.Y.ToString();
		lbZ.Text = data.Acceleration.Z.ToString();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}