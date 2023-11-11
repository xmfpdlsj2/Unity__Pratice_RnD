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

    // task �� when all �Լ� ���� �߰��ϱ� 

    // ����Ƽ ������Ʈ���� Editor ���� ������ ���忡 ���Ե��� �ʴ´�.
    

    // �ڷ�ƾ�� �����׽�ũ�� ����Ҷ�, �������̺�� �ʿ��� �����Ǵ� �ֵ��̸�, �ı��� ���� �ֵ���
    // ���� ĳ����ū�� ����ϴ��� �ڷ�ƾ�� ���°� ���ƺ��δٴ� �ôϾ��� �ǰ�. 

    // -TextMeshProUGUI �� TextMeshPro �� ������
    // TMP_Text is the base/parent class for two types
    // TextMeshProUGUI - replacing the now legacy UI.Text within a UI.Canvas
    // TextMeshPro - replacing the now legacy TextMesh for placing 3D text without using a UI.Canvas
    // This second one is where the name of the entire package originally comes from.
    // It was a custom improved TextMesh until Unity adopted it into the core.
    // So if you want to be more generic (loosely coupled) and make your component work
    // in theory with whatever will be used for displaying that text later you use TMP_Text so both can be used the same way.
    // ����ϸ� TMP_Text ��ü�� �ֻ��� �θ��̰�, �̰ɾ��� ���� ���Žþֵ� �� ��������. 
}

