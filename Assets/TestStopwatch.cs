using System.Diagnostics;
using UnityEngine;
using TMPro;

public class TestStopwatch : MonoBehaviour
{
    public TMP_Text text;
    Stopwatch stopwatch;

    public void BtnStart()
    {
        text.text = "Started";
        stopwatch = Stopwatch.StartNew();
    }

    public void BtnStop()
    {
        stopwatch.Stop();
        text.text = stopwatch.ElapsedMilliseconds.ToString();
    }
}
