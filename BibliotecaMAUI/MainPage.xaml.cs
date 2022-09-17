using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Views;

namespace BibliotecaMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
	CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		var snackBar = Snackbar.Make("Error");
		snackBar.Show(cancellationTokenSource.Token);

		
	}
}

