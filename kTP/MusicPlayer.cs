using System.Runtime.InteropServices;
using System.Text;

namespace kTP
{
    class MusicPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback); 
    

        public void Open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void Play()
        {
            string command = "play MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void Pause()
        {
            string command = "pause MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void Stop()
        {
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);

            command = "close MyMp3";
            mciSendString(command, null, 0, 0);
        }

            // return to start of song and resume playback
        public void ReturnToStart()
        {
            string command = "seek MyMp3 to start";
            mciSendString(command, null, 0, 0);

            command = "play MyMp3";
            mciSendString(command, null, 0, 0);
        }

            // TODO: add a loop to increase the "ms value for each keypress"
        public void FFW()
        {
            string command = "set MyMp3 time format ms";
            mciSendString(command, null, 0, 0);

            command = "seek MyMp3 to 10000";
            mciSendString(command, null, 0, 0);
        }

    }
}
