using UnityEngine;
using UnityEditor;

public class ExampleWindow : CustomWebViewEditorWindow
{

    [MenuItem("Window / Example")]
    static void Open()
    {
        CreateWebViewEditorWindow<ExampleWindow>(
            "Example",
            Application.dataPath + "/HTML/index.html", 200, 530, 800, 600);
    }

    public void Play()
    {
        EditorApplication.isPlaying = !EditorApplication.isPlaying;
    }

    public void Pause()
    {
        EditorApplication.isPaused = !EditorApplication.isPaused;
    }

    public void Step()
    {
        EditorApplication.Step();
    }
}