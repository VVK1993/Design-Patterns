using UnityEngine;
using System.Collections;

public class WindowsFileSystem : FileSystem
{
    public override void SaveData()
    {
        base.SaveData();
        Debug.Log("-> Windows File System");
    }
}
