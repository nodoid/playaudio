
using Android.Media;
using PlayAudio.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(PlayAudio_Droid))]
namespace PlayAudio.Droid
{
    class PlayAudio_Droid : IPlayAudio
    {
        MediaPlayer player = new MediaPlayer();

        public PlayAudio_Droid()
        {
        }

        public void PlayAudio()
        {
            if (player.IsPlaying)
                player.Stop();

            using (var audioFile = Forms.Context.Assets.OpenFd("speech.wav"))
                player.SetDataSource(audioFile.FileDescriptor, audioFile.StartOffset, audioFile.Length);

            player.Prepare();
            player.SetVolume(1f, 1f);
            player.Looping = true;
            player.Start();
        }
    }
}