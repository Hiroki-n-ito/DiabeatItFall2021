
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueMusicIntro : MonoBehaviour
{
  public AudioSource bgMusic;
  public static bool playing = false;
  private void Awake() {
    GameObject[] musicObj = GameObject.FindGameObjectsWithTag("backgroundMusic");
    if(musicObj.Length > 1) {
      Destroy(this.gameObject);
    }
    DontDestroyOnLoad(this.gameObject);
    SceneManager.sceneLoaded += OnSceneLoaded;
  }
  void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
    if(scene.name == "Main Menu") {
      Destroy(this.gameObject);
    }
  }
  public void Start() {
    if (!playing) {
      bgMusic.Play();
      playing = true;
    }
  }
}
