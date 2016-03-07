using UnityEngine;
using System.Collections;

public class FileSystemManager : MonoBehaviour
{
    public void SaveData()
    {
        FileSystem.Instance().SaveData();
    }
}
