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
        // DoJump 는 말 그대로 점프 하는 듯한게 아니었다. 직선으로 움직이는게 당연.. 용도가 대체? 
        // 점프하는 듯하는걸 쓸려면 즉 곡선움직임은 DoPath를 사용해야한다. Gpt가 알려줌 ㄷㄷ. 

        // 애니메이터에서 클립에 도트그래프 상단에 우클릭으로 스크립트 이벤트를 심을수 있다. 이것과 
        // 두트윈의 연계를 고민해봐야한다. 
    }

    // is or and etc 
    // 추가로 from 은 기본인건가?
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

    // params
    // 오브젝트 타입으로 주고 받는거랑 파람 이라는 타입의 차이?? 
    private void ParamsPractice(object p)
    {
        // c++ 의 ... 같은 거인듯.  찾아보자.
        // params 매개변수를 파람으로 받는것과 오브젝트의 관계
    }

    //linq 관련해서도 자료구조처럼 많이 알아둘 필요가 있다.
    private void LinqPractice()
    {
        // 링큐 추가부터 
        // linq .Where() -> 조건식을 람다식으로 넣을수 있고 조건에 따라 iEnumerator 컬렉션을 반환해주는 함수. 
    }

    // 싱글톤으로 클래스를 static 객체로 만들때 해당 클래스의 멤버 변수를 전역으로 할당하는 곳에서 
    // getter로 받는거랑 그냥 배정 연산자로 할당하는거랑 차이가 있나? 
    public string key = GetStringByKey();
    public string key2 => GetStringByKey();
    private static string GetStringByKey()
    {
        // 회사에서 비슷한 이슈로 배정 연산자로 변수를 할당하는 과정에서 빌드 에러가 나서 해당 NULL 예외가 뜸... 
        // 2번이 되는지는 한번 확인해보긴해야됨. 
        // 이거 생각해보면 당연한것이 클래스 객체를만들때 전자는 변수에 해당함수를통해 실제 값을 부여해야하니까 Awake같은 타이밍 이슈가 있을수있음
        // 후자는 getter처럼 무명함수로 호출하는 형태기때문에 타이밍 이슈가 없을것 같다.
        return "Nice";
    }

    // C#9.0 패턴매칭 도 정리해보자

    // 상속구조에서 where 
    // 상속받을때 상속 매개변수, 제네릭 타입을 where 로 특정 할 수 있다. 
}

public class Monster
{
    public int id;
    public string name;
}
