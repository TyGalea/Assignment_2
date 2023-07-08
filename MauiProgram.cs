using Microsoft.AspNetCore.Components.WebView.Maui;
using Assignment_2.Data;

namespace Assignment_2;

/// <summary>
/// MauiProgram for Traveless
/// </summary>
/// <remarks>Author: Tyler Galea</remarks>
/// <remarks>Date: July 7, 2023</remarks>
/// This blazor app allows the user to type a departure, destination, and day of the week. Pressing the
/// find flights button will produce a list of all flights the user specified that they can select to
/// populate the Reserve section with the flight’s info. The user can then fill in their name and citizenship
/// and press the Reserve button to save their reservation and get their reservation code. In the reservation tab 
/// the user can enter their reservation code, airline, or name to find their reservation. Pressing the
/// find reservations button will produce a list of all reservations the user specified that they can select to
/// populate the Reserve section with the reservation info. The user can edit their name, citizenship, and status and
/// press the Save button to update their reservation.

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		

		return builder.Build();
	}
}
