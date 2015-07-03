using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace PlayAudio
{
    public class PlayAudio : ContentPage
    {
        public PlayAudio()
        {
            var lblTitle = new Label
            {
                Text = "Audio player",
                FontSize = 36,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var btnPlay = new Button
            {
                Text = "Play audio file"
            };
            btnPlay.Clicked += delegate
            {
                DependencyService.Get<IPlayAudio>().PlayAudio();
            };

            Content = new StackLayout
            {
                Orientation =StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
					lblTitle,
                    btnPlay
				}
            };
        }
    }
}
