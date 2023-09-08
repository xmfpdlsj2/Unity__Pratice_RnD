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

    // task 와 when all 함수 예제 추가하기 

    // 유니티 프로젝트에서 Editor 폴더 하위는 빌드에 포함되지 않는다.
    

    // 코루틴과 유니테스크를 사용할때, 모노비헤이비어 쪽에서 관리되는 애들이며, 파괴가 잦은 애들은
    // 굳이 캐슬토큰을 사용하느니 코루틴을 쓰는게 좋아보인다는 시니어의 의견. 
}

