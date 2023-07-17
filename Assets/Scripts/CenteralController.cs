using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenteralController : MonoBehaviour
{
    private LStraight LStraight;
    private LTurn LTurn;
    private RStraight RStraight;
    private RTurn RTurn;
    private D2L D2L;
    private D2R D2R;

    private bool LSGO;

    void Start()
    {
        LStraight LStraight = GameObject.Find("LStraight").GetComponent<LStraight>();
        LSGO = LStraight.LSGO;
    }

    void Update()
    {
        if (LStraight != null && LStraight.LSGO)
        {
            LStraightGO();
        }
    }

    private void LStraightGO()
    {
        LStraight.LSGO = false;
    }
}