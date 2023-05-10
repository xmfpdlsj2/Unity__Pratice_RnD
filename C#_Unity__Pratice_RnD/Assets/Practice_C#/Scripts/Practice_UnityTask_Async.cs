using System;
using UnityEngine;
using Cysharp.Threading.Tasks;



public class Practice_UnityTask_Async : MonoBehaviour
{
    private void Awake()
    {
        
    }
    private async void Start()
    {
        Debug.Log("0");
        var a = Delay1();
        await a;
        Debug.Log("1");

        Delay1Async().Forget();
        Debug.Log("3");
    }

    private static UniTask Delay1()
    {
        return UniTask.Delay(1000);
        return UniTask.Delay(TimeSpan.FromSeconds(1));
    }

    private static async UniTask Delay1Async()
    {
        Debug.Log("4");
        await UniTask.Delay(1000);
        Debug.Log("5");
        await UniTask.Delay(1000);
        Delay1Void().Forget();
    }

    private static async UniTaskVoid Delay1Void()
    {
        await UniTask.Delay(1000);
        Debug.Log("6");
    }
}

