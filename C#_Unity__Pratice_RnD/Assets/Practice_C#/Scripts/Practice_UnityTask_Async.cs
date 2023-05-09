using System;
using UnityEngine;
using Cysharp.Threading.Tasks;



public class Practice_UnityTask_Async : MonoBehaviour
{
    private void Awake()
    {
        
    }
    private void Start()
    {
        
    }

    private static UniTask Delay1()
    {
        return UniTask.Delay(1000);
        return UniTask.Delay(TimeSpan.FromSeconds(1));
    }

    private static async UniTask Delay1Async()
    {
        await UniTask.Delay(1000);
        await UniTask.Delay(1000);
        Delay1Void().Forget();
    }

    private static async UniTaskVoid Delay1Void()
    {
        await UniTask.Delay(1000);
    }
}

