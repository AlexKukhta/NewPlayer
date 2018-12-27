using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewPlayer
{
    class Player
    {
        private int _volume;
        public Song[] Songs;

        private bool _locked;
        private bool _playing;

        public bool Playing
        {
            get { return _playing; }
        }

        const int MIN_VOLUME = 0;
        const int MAX_VOLUME = 300;

        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value < MIN_VOLUME)
                {
                    _volume = MIN_VOLUME;
                }
                else if (value > MAX_VOLUME)
                {
                    _volume = MAX_VOLUME;
                }
                else
                {
                    value = _volume;
                }
            }
        }

        public void VolumeUp()
        {
            if (_locked == false)
            {
                _volume++;
                Console.WriteLine(_volume);
            }

        }

        public void VolumeDown()
        {
            if (_locked == false)
            {
                _volume--;
                Console.WriteLine(_volume);
            }

        }

        public void VolumeChange(int step)
        {
            if (_locked == false)
            {
                _volume += step;
                Console.WriteLine(_volume);
            }

        }

        public Song[] songs { get; private set; }

        public void Locked()
        {
            _locked = true;
        }

        public void Unlock()
        {
            _locked = false;
        }
        public void Play()
        {
            if (_locked)
            {
                return;
            }
            _playing = true;
            for (int i = 0; i < Songs.Length; i++)
            {
                Console.WriteLine($"Player is Playing: {Songs[i].name}, Duration: {Songs[i].Duration}" );
            }

        }

        public void Stop()
        {
            if (_locked)
            {
                return;
            }
            _playing = false;
            Console.WriteLine("Player has Stopped");
        }

        public void Add(params Song[] songArr)
        {
            Songs = songArr;
        }
    }
}
