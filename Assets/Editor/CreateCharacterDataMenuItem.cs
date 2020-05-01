using Channel3.ScriptableObjects;
using UnityEditor;
using UnityEngine;

public class CreateCharacterDataMenuItem
{
    private const string FileDirectoryPath = "ScriptableObjects/CharactersData/";
    private const string File = "CharactersData.asset";

    [MenuItem("Channel 3/Create Character Data")]
    public static void CharactersDataFile()
    {
        CharacterData characterData = Editor.CreateInstance<CharacterData>();
        System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Application.dataPath, FileDirectoryPath));
        AssetDatabase.CreateAsset(characterData, "Assets/" + FileDirectoryPath + File);
    }
}