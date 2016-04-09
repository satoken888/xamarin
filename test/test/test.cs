using System;

using Xamarin.Forms;

namespace test
{
	public class App : Application
	{
		public App ()
		{
			var button = new Button{ 
				Text = "Enter"
			};
			var datePicker = new DatePicker{ };

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						datePicker,
						button

					}


				}
			};

			button.Clicked += (sender, e) => {

				MainPage = App.getSecondPage(datePicker.Date);
			};
				
		}

		public static ContentPage getSecondPage(DateTime selectDate){
		
			return new ContentPage {
				Content = new Label{
					Text = selectDate.ToString(),
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand
				},
				BackgroundColor = Color.Yellow
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

