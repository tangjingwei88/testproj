/***
 * Author:TSoft
 * Title:  Panel类型：UIPanelType  
 * Date: 18-7-19
 * 
 * **/
using UnityEngine;
using System.Collections;

public class UIPanelType : MonoBehaviour {

    //prefab 路径
    public string Path { get; private set; }

    //prefab名字
    public string Name { get; private set; }

    public UIPanelType(string path)
    {
        Path = path;
        Name = path.Substring(path.LastIndexOf('/') + 1);
       // Debug.LogError("##" + Path + Name);
    }

    public override string ToString()
    {
        return string.Format("path:{0} name:{1}",Path,Name);
    }


    public static readonly UIPanelType ChatPanel = new UIPanelType("UIPrefab/ChatPanel");
    public static readonly UIPanelType GamePanel = new UIPanelType("UIPrefab/gamePanel");
    public static readonly UIPanelType LoginPanel = new UIPanelType("UIPrefab/LoginPanel");
    public static readonly UIPanelType PackagePanel = new UIPanelType("UIPrefab/PackagePanel");
}
