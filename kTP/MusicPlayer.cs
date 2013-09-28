using System.Runtime.InteropServices;
using System.Text;

namespace kTP
{
    public class MusicPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        private bool isPlaying = false;
        private int ffw5sec = 5000;

        public void Open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void Play()
        {
            isPlaying = true;
            string command = "play MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void Pause()
        {
            isPlaying = false;
            string command = "pause MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void Stop()
        {
            isPlaying = false;
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);

            command = "close MyMp3";
            mciSendString(command, null, 0, 0);
        }

            // return to start of song and resume playback
        public void ReturnToStart()
        {
            isPlaying = true;
            string command = "seek MyMp3 to start";
            mciSendString(command, null, 0, 0);

            command = "play MyMp3";
            mciSendString(command, null, 0, 0);
        }

            // Fast Forward
                // needs a better skip Implementation
        public void FFW()
        {
            if (isPlaying == true)
            {
                string command = "set MyMp3 time format ms";
                mciSendString(command, null, 0, 0);

                command = "seek MyMp3 to " + ffw5sec.ToString();
                mciSendString(command, null, 0, 0);

                command = "play MyMp3";
                mciSendString(command, null, 0, 0);

                ffw5sec += 5000;
            }
         }

    }
}
