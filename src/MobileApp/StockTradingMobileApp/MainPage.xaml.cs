using System;
using Microsoft.Maui.Controls;

namespace StockTradingMobileApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void LoginBtn_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            DisplayAlert("Error", "Please enter both username and password.", "OK");
            return;
        }

        Console.WriteLine($"Attempting login for user: {username}");
        LoginBtn.Text = "Logging in...";

        // TODO: Add authentication logic here
    }

    private async void FaceIdTapped(object sender, EventArgs e)
    {
        bool isAuthenticated = await AuthenticateWithFaceId();

        if (isAuthenticated)
        {
            await DisplayAlert("Success", "Face ID authentication successful!", "OK");
            Console.WriteLine("User authenticated with Face ID");
        }
        else
        {
            await DisplayAlert("Error", "Face ID authentication failed.", "OK");
        }
    }

    private async Task<bool> AuthenticateWithFaceId()
    {
        // TODO: Placeholder for Face ID authentication logic
        // In a real implementation, you'd use Microsoft.Maui.Essentials for biometric authentication
        await Task.Delay(1000); // Simulate Face ID processing
        return true; // Simulated success
    }

	private async void ForgotPasswordTapped(object sender, EventArgs e)
	{
		await DisplayAlert("Forgot Password", "Redirecting to password reset page...", "OK");
		
		// TODO: Navigate to the actual password reset page
	}

	private async void RegisterTapped(object sender, EventArgs e)
	{
		await DisplayAlert("Register", "Redirecting to registration page...", "OK");
		Console.WriteLine("Navigating to registration page...");
	}

}
