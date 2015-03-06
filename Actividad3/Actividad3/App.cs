using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = "Este es el texto de un Label!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					XAlign = TextAlignment.End, 
					YAlign = TextAlignment.End, 
					BackgroundColor = Color.Gray, 
					TextColor = Color.Green
				},
			};
		}
	}
}

