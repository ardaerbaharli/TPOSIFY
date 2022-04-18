using System.Collections.Generic;
using UnityEngine.UI;

public class Album
{
    private string name;
    private List<Song> songs;
    private int albumId;
    private Image albumImage;
    private int albumYear;
    private string albumGenre;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public List<Song> Songs
    {
        get => songs;
        set => songs = value;
    }

    public int AlbumId
    {
        get => albumId;
        set => albumId = value;
    }

    public Image AlbumImage
    {
        get => albumImage;
        set => albumImage = value;
    }

    public int AlbumYear
    {
        get => albumYear;
        set => albumYear = value;
    }

    public string AlbumGenre
    {
        get => albumGenre;
        set => albumGenre = value;
    }
}