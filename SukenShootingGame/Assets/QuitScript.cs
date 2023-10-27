using UnityEngine;



public class App : MonoBehaviour {
  // Quit() は省略
    
    public void Quit() {
    #if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
    #else
      Application.Quit();
    #endif
  }
  void Update() {
    if (Input.GetKeyDown(KeyCode.Escape)) {
      Quit();
    }
  }
}