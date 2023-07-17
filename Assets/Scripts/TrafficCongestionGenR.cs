using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCongestionGenR : MonoBehaviour
{
    private int carCount = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Vehicle"))
        {
            carCount++;
            UpdateTraffic();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Vehicle"))
        {
            carCount--;
            UpdateTraffic();
        }
    }

    private void UpdateTraffic()
    {
        // 교통 혼잡도에 따른 처리를 여기에 추가할 수 있습니다.
        // 예를 들어, 혼잡도에 따라 신호를 변경하거나 다른 동작을 수행할 수 있습니다.
        Debug.Log("Current car count: " + carCount);
    }
}
