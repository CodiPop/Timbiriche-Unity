using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public static GameManager Instance;
    public int Width = 4;
    public int Height = 4;
    public Point PointPrefab;




    private void Awake()
    {
        Instance = this;
    }


    private void GenerateBoard()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                var p = new Vector2(i,j);
                Instantiate(PointPrefab, p, Quaternion.identity);
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        GenerateBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
