using Foundation;
using AudioToolbox;
using PlayAudio.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(PlayAudio_iOS))]
namespace PlayAudio.iOS
{
    public class PlayAudio_iOS : IPlayAudio
    {
        public PlayAudio_iOS()
        {
        }

        public void PlayAudio()
        {
            var audioFile = NSBundle.MainBundle.PathForResource("speech", "wav");
            var playAudio = SystemSound.FromFile(new NSUrl(audioFile, false));
            playAudio.PlaySystemSound();
        }
    }
}

