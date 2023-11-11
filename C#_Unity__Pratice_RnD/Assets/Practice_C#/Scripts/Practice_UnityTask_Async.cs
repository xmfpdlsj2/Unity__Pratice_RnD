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

    // -TextMeshProUGUI 와 TextMeshPro 의 차이점
    // TMP_Text is the base/parent class for two types
    // TextMeshProUGUI - replacing the now legacy UI.Text within a UI.Canvas
    // TextMeshPro - replacing the now legacy TextMesh for placing 3D text without using a UI.Canvas
    // This second one is where the name of the entire package originally comes from.
    // It was a custom improved TextMesh until Unity adopted it into the core.
    // So if you want to be more generic (loosely coupled) and make your component work
    // in theory with whatever will be used for displaying that text later you use TMP_Text so both can be used the same way.
    // 요약하면 TMP_Text 객체가 최상위 부모이고, 이걸쓰면 기존 레거시애들 다 쓸수있음. 
}

