using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using DG.Tweening;
using System.Runtime.InteropServices;
using System.Linq;
using Cysharp.Threading.Tasks;

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

    private void RefnInOut()
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

        // 추가적으로 구조체를 생성해서 함수내부에서 사용할때도 ref 타입으로 받아서 사용하더라. 
        // ref 는 참조로 주고 받을수있으며 in으로 매개변수로 받으면 C++의 const &와 같다. 
        // out도 전달될떄는 참조형으로 전달된다. 명시적인 효과들을 누릴수 있는 부분.
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
    // 단순히 값을 버리고자 할때만 사용. 
    private void DiscardOperator()
    {
        var person = ("John", "Smith");
        var (first, _) = person;
        Debug.Log(first);
        _ = 1;
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

    // is or and etc and as 
    // 추가로 from 은 기본인건가?
    private void IsOrAndETC()
    {
        string ascii = "ASCII";
        var ret = (ascii == "ASCII" || ascii == "BSCII");
        ret = ascii is "ASCII" or "BSCII";

        // as 연산자는 형변환이며 실패하면 null 반환. 안전하게 형변환하고자 하는 용도.
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

    // 해쉬셋 및 자료구조 
    // 일반적은로 std::unordered_set 과 같은것 같다.
    private void STLpractice()
    {
        var hash = new HashSet<int>();
        var isAdd = hash.Add(1);    // -> true
        isAdd = hash.Add(1);        // -> false
        // 해쉬셋에 들어가는 타입이 클래스고 기반클래스로 생성하고 파생클래스가 다르면 add로 들어갈때 서로 다르게 들어간다.

        // List<T>().ForEach() 함수
        List<int> numList = new List<int>() { 1, 2, 3, 4 };
        numList.ForEach(num => Debug.Log($"num[{num}]"));
    }

    //linq 관련해서도 자료구조처럼 많이 알아둘 필요가 있다.
    private void LinqPractice()
    {
        // linq .Where() -> 조건식을 람다식으로 넣을수 있고 조건에 따라 iEnumerator 컬렉션을 반환해주는 함수. 

        // 랜덤 뽑기
        List<int> numList = new List<int>() { 1, 2, 3, 4 };
        System.Random random = new System.Random(); // C# random
        var takeTwo = numList.OrderBy(x => random.Next()).Take(2).ToArray();
    }

    // string 포맷 관련
    private void StringFormatTest()
    {
        int max = 2147483647;
        string table = max.ToString("N0"); // 숫자를 쉼표를 추가하고 소숫점느 없는 포맷
    }

    // 인터페이스를 상속받은 클래스에서 구현한 인터페이스함수를 자식 클래스에서 오버라이당하려면
    // 부모클래스의 인터페이스 함수에 virtual 키워드를 붙여주고 자식에서 오버라이드 함수로 받는다.
    // 다른 방법으로는 함수명 앞에 인터페이스명.함수명 으로 명시할수도 있다.
    //

    // 유니티의 드로우콜의 배치 수는 하이어라키를 우선으로 그리면서도 아틀라스, 렌더큐를 잘 고려해야 배치를줄일수있다.
    // 같은 아틀라스에 있더라도 렌더큐가 같은 다른 렌더링 오브젝트가 있다면 배치가 늘어날수 있다.


    // 유니티 TextMeshProUGUI 와 TextMeshPro 객체의 차이점 상속관계가 있다. TMP_Text 객체가 최상위 부모이고, 이걸쓰면 기존 레거시애들 다 쓸수있음. 

    // string.Format("{0:n0}", num) 와 같이 n0, d0 과 같은 숫자포맷등 다양한 스트링 포맷이 있다. 예제를 알고있는게 표현에 좋을듯
    // n0 은 숫자표현을 천단위로하고 ,를 넣어주며 소수점 0자리까지 표현하겠다는 의미
    // 0.## 은 소수점이 있으면 표현하고 2번째 까지 표현하겠다는 의미 #의 갯수만큼 표현된다.  
}

public class Monster
{
    public int id;
    public string name;
}
