using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    public GameObject blockPrefab;

    private void Awake()
    {
        for(float i = -2.4f ; i <=2.4f ; i=i+0.6f)
        {
            for(float j = 1.2f ; j <= 4.6f ; j=j+0.6f)
            {
                Instantiate(blockPrefab,new Vector3(i,j,0),Quaternion.identity);
            }
        }
    }
    
}
