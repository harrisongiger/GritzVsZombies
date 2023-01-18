using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapscript : MonoBehaviour
{
    [SerializeField]
    Image tile;

    void Start()
    {
        Instantiate(tile);
        Debug.Log("boob");          
    }

    void Update()
    {
        
    }
}
