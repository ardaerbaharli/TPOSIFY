using Models;
using UnityEngine;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Queue queue;

        public Queue Queue
        {
            get => queue;
            set => queue = value;
        }


        public void PlaySong(Song song)
        {
        }

        public void StopPlaying()
        {
        }

        public void ResumePlaying()
        {
        }

        public void NextSong()
        {
        }

        public void PreviousSong()
        {
        }
    }

    public class SongController : MonoBehaviour
    {
        private PlayerController player;
        
        
        
        public void SongOptionsClicked()
        {
        }

        public void SongSelectionToggle()
        {
        }

        public void SongShifter()
        {
        }

        public void LikeSongToggle()
        {
        }

        public void PlaySong()
        {
            
        }
    }
}