using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour
{

    public Transform CellPrefab;
    public Vector3 Size;
        
    void Start()
    {
        CreateGrid();
    }

       void CreateGrid()  {
        for (int x = 0; x < Size.x; x++) {
            for (int z = 0; z < Size.z; z++) {
                Transform newCell; 
                newCell = (Transform)Instantiate(CellPrefab, new Vector3 (x, 0, z), Quaternion.identity);
                newCell.name = string.Format("({0}, 0, {1})", x, z);
                newCell.parent = transform;
            }
        }
    }
}
