using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomService : MonoBehaviour
{
    // Start is called before the first frame update
public static int GetRandomIndex(int start, int end)
    {
        return Random.Range(start, end);
    }
}
