using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class ProjectBootstrap
{
    private const string ScenePath = "Assets/Scenes/Main.unity";

    public static void EnsureBuildScene()
    {
        if (!File.Exists(ScenePath))
        {
            var scene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);
            EditorSceneManager.SaveScene(scene, ScenePath);
        }

        EditorBuildSettings.scenes = new[]
        {
            new EditorBuildSettingsScene(ScenePath, true)
        };

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}