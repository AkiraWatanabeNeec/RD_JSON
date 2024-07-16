using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonScene
{
    public string name;
}

public class JSON_Reader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 入力データパス名「 Assets/Resource/out.json 」
        string json_string = Resources.Load<TextAsset>("out").ToString();
        JsonScene jsonScene = JsonUtility.FromJson<JsonScene>(json_string);
        Debug.Log(jsonScene.name);
        // Debug.Log(json_string);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
