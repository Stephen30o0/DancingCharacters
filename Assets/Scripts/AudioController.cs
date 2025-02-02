using UnityEngine;

public class AudioController : MonoBehaviour {
    public AudioSource backgroundMusic;
    public AudioSource[] characterSongs;

    // Add this missing method
    public void PlayCharacterSong(int characterIndex) {
        StopBackgroundMusic();
        StopAllCharacterSongs();
        
        if (characterIndex >= 0 && characterIndex < characterSongs.Length) {
            characterSongs[characterIndex].Play();
        }
    }

    // Rest of your existing methods...
    public void StopBackgroundMusic() {
        if (backgroundMusic != null && backgroundMusic.isPlaying) {
            backgroundMusic.Stop();
        }
    }

    private void StopAllCharacterSongs() {
        foreach (AudioSource song in characterSongs) {
            if (song != null && song.isPlaying) {
                song.Stop();
            }
        }
    }

    public void ResetToIdleState() {
        StopAllCharacterSongs();
        PlayBackgroundMusic();
    }

    void Start() {
        PlayBackgroundMusic();
    }

    public void PlayBackgroundMusic() {
        StopAllCharacterSongs();
        if (backgroundMusic != null && !backgroundMusic.isPlaying) {
            backgroundMusic.Play();
        }
    }
}