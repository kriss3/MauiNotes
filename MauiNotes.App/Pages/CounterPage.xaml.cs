namespace MauiNotes.App.Pages;

public partial class CounterPage : ContentPage
{
	private int _initCount = 0;

	public CounterPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e) 
	{
		_initCount++;

		CounterLabel.Text = _initCount == 1
			? "Clicked 1 time."
			: $"Clicked {_initCount} times.";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}