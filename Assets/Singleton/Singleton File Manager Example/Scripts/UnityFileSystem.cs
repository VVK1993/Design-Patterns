using UnityEngine;
using System.Collections;

public class UnityFileSystem : FileSystem
{
    public override void SaveData()
    {
        base.SaveData();
        Debug.Log("-> Unity File System");
    }
}
