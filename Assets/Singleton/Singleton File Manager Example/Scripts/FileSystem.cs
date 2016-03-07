using UnityEngine;
using System.Collections;

public class FileSystem
{
    private static FileSystem instance;

    public static FileSystem Instance()
    {
        // Lazy initialize.
        if (instance == null)
        {
#if UNITY_EDITOR
            instance = new UnityFileSystem();
            Debug.Log("Initializing Unity Editor File System");
#elif UNITY_STANDALONE_WIN
            instance = new WindowsFileSystem();
            Debug.Log("Initializing Windows File System");
#endif
        }
        return instance;
    }

    public virtual void SaveData()
    {
        Debug.Log("Saving data with ->");
    }
}
