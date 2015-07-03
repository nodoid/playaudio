using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayAudio;
using PlayAudio.WinPhone;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework;

[assembly: Xamarin.Forms.Dependency(typeof(PlayAudio_WinMobile))]
namespace PlayAudio.WinPhone
{
    public class PlayAudio_WinMobile : IPlayAudio
    {
        public PlayAudio_WinMobile()
        {
        }

        public void PlayAudio()
        {
            var soundFile = App.GetResourceStream(new Uri("Assets/speech.wav", UriKind.Relative));
            var effect = SoundEffect.FromStream(soundFile.Stream);
            FrameworkDispatcher.Update();
            effect.Play();
        }
    }
}
