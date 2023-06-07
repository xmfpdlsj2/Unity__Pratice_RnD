using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using DG.Tweening;
using System.Runtime.InteropServices;

public class Practice_CSharp_07_08 : MonoBehaviour
{


    private void Awake()
    {
        Main();
    }

    private void Main()
    {
        //RefnOut();

        NullMerge((isNull) =>
        {
            Debug.Log($"Call back is: {isNull}");
        });

        SystemaRange();
    }

    private void NullMerge(Action<bool> callBack)
    {
        callBack?.Invoke(true);

        List<string> list = new List<string>();

        //list[0] ??= "";
    }

    private void RefnOut()
    {
        int number = 0;
        ChangeNumger(number);
        Debug.Log($"valueType [{number}]");
        ChangeNumger_ref(ref number);
        Debug.Log($"reference Type [{number}]");

        Monster dragon = new Monster();
        dragon.id = 100;
        dragon.name = "Agryong";

        ChangeClass(dragon);
        Debug.Log($"junt class: {dragon.id}");
        ChangeClass_ref(ref dragon);
        Debug.Log($"ref class: {dragon.id}");
    }
    private void ChangeNumger(int num)
    {
        num = 250;
    }
    private void ChangeNumger_ref(ref int num)
    {
        num = 250;
    }

    private void ChangeClass(Monster monster)
    {
        monster.id = 200;

        monster = new Monster();
        monster.id = 300;
    }
    private void ChangeClass_ref(ref Monster monster)
    {
        monster.id = 200;

        monster = new Monster();
        monster.id = 300;
    }


    // 무시자 _=
    private void DiscardOperator()
    {
        var person = ("John", "Smith");
        var (first, _) = person;

        Debug.Log(first);
        //Debug.Log(_); // error why?
    }

    // System.Range
    private void SystemaRange()
    {
        int[] table = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int flexibleNum = UnityEngine.Random.Range(0, table.Length);

        var table2 = table[..flexibleNum];
        for (int i = 0; i < table2.Length; i++)
        {
            Debug.Log($"table2: [{table2[i]}]");
        }

        var table3 = table[2..^3];
        for (int i = 0; i < table3.Length; i++)
        {
            Debug.Log($"table3: [{table3[i]}]");
        }
    }

    // DoTween 딥한 예제들추가 공부
    private void Dootween()
    {
        var dgSequence = DOTween.Sequence();
        
        //DOTween.Append();
        //DOTween.AppendCallback();
        //DOTween.AppendInterval();
        //DOTween.Insert();
        //DOTween.InsertCallback();
        //DOTween.Join();
        //DOTween.Prepend();
        //DOTween.PrependCallback();
        //DOTween.PrependInterval();

        //DOTween.OnUpdate();
        //DOTween.OnStart();

        // 연수님은 커스텀으로도 트윈을 만들어사용하기도했다. 상속받아서 사용가능한듯 
    }

    // is or and etc
    private void IsOrAndETC()
    {
        string ascii = "ASCII";
        var ret = (ascii == "ASCII" || ascii == "BSCII");
        ret = ascii is "ASCII" or "BSCII";

    }

    // &= 연산자
    private bool GetBool()
    {
        bool answer = false;
        int one = 1;
        string some = "A";
        answer &= one == 1;
        answer &=  some != "B";
        // .... 보기 좋은것 외에 어떤 이유로 쓰는지 좀더 정의할 필요가 있겠다.
        return answer;
    }

    //Datetime and UTC and Tics
    private void DateTimePractice()
    {
        // DateTime class를 보통 만드는것이었나?
    }

    // 파이썬도 공부함.... 테스트오토메이터. ㅠㅠ 
    private void Python()
    {
        // 기본 문법들, 함수는 def 라고 정의, 좀당황스러운게 탭으로 범위가 결정되는듯
        // 함수 안에 함수는 대체?? 
    }

}

public class Monster
{
    public int id;
    public string name;
}
