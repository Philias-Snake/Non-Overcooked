using UnityEditor;
using UnityEngine;

public class TextureTypeFixer : Editor
{
    [MenuItem("Tools/Fix Cubemap Textures")]
    public static void FixCubemapTextures()
    {
        string[] guids = AssetDatabase.FindAssets("t:Texture");

        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            TextureImporter importer = AssetImporter.GetAtPath(path) as TextureImporter;

            if (importer != null && importer.textureShape == TextureImporterShape.TextureCube)
            {
                importer.textureShape = TextureImporterShape.Texture2D;
                importer.SaveAndReimport();
                Debug.Log($"Converted texture at {path} to 2D.");
            }
        }

        Debug.Log("All Cubemap textures have been checked and fixed if necessary.");
    }
}
