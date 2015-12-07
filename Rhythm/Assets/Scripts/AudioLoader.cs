using UnityEngine;
using System.Collections;
using System;
using UnityEditor;

public class AudioLoader : MonoBehaviour {

    System.IO.DirectoryInfo MusicFolder;
    WWW myClip;
    String myPath;
 
    void Start()
    {
        LoadFile();
    }

    void LoadFile()
    {
        myPath = "C:\\Users\\Public\\Music\\Sample Music";
        #if UNITY_ANDROID 
        myPath = "/mnt/sdcard/music"; //Para moviles
        #endif
        MusicFolder = new System.IO.DirectoryInfo(myPath);
        String myPath2 = EditorUtility.OpenFilePanel("", myPath, "mp3");
        if (myPath2 != "")
        {
            myClip = new WWW("file:///" + myPath2);
            this.gameObject.GetComponent<AudioSource>().clip = myClip.GetAudioClip(false, false);
        }
    }
    
}
