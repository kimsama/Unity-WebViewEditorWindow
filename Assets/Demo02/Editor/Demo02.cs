using UnityEngine;
using UnityEditor;

public class Example02Window : CustomWebViewEditorWindow
{
    [MenuItem("Window/Example02")]
    static void Open()
    {
        string path = Application.dataPath + "/Demo02/index.html";
        var w = CreateWebViewEditorWindow<Example02Window>("Example", path, 200, 530, 800, 600);

        EditorApplication.update += () => w.InvokeJSMethod("example", "changeText", Time.realtimeSinceStartup.ToString());
    }
}
