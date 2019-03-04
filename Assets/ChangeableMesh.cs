using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeableMesh : MonoBehaviour
{
    [SerializeField]
    public GameObject[] GameObjects;
    [SerializeField]
    public Texture[] Textures;

    public int goIndex = 0;
    public int texIndex = 0;

    public GameObject go;
    public Texture tex;

    void Start()
    {
        go = GameObjects[0];
        tex = Textures[0];
    }

    void Update()
    {
        
    }
}
