using System;
using System.Collections.Generic;
using Models;
using UnityEngine;

namespace Controllers
{
    public class DatabaseController :MonoBehaviour
    {
        
        // Singleton
        public static DatabaseController Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        // Database connection

        public void OpenConnection()
        {
            // Open connection
        }

        public void CloseConnection()
        {
            // Close connection
        }

        public void ControlConnection()
        {
            // Control connection
        }

        public Song GetSong(int songID)
        {
            return new Song();
        }

        public Playlist GetPlaylist(int playlistID)
        {
            return new Playlist();
        }


        public List<Playlist> GetPlaylists(string username)
        {
            return new List<Playlist>();
        }

        public Album GetAlbum(int albumID)
        {
            return new Album();
        }

        public List<Album> GetAlbums(int artistID)
        {
            return new List<Album>();
        }

        public Artist GetArtist(int artistID)
        {
            return new Artist();
        }

        public Playlist UpdatePlaylist(Playlist playlist)
        {
            return playlist;
        }

        public Playlist CreatePlaylist(Playlist playlist)
        {
            return playlist;
        }

        public User GetUser(string userID)
        {
            return new User();
        }

        public User CreateUser(User user)
        {
            return user;
        }

        public bool DoesUsernameExists(string username)
        {
            return false;
        }

        public bool DoesEmailExists(string email)
        {
            return false;
        }
    }
}