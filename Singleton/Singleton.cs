using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
	// 자기 자신의 instance를 선언한다. 보안을 확실하게 하기 위해 private를 사용한다. 
    private static Singleton instance = null;

    void Awake()
    {	
    	// instance 값이 null일 경우 (인스턴스가 만들어져 있지 않은 경우), 자기 자신을 넣어준다. 
        // 또한, 이 오브젝트는 Scene 전환이 되어도 사라지면 안 되기 때문에, DontDestroyOnLoad를 사용하여 삭제되지 않도록 한다. 
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        // Scene 전환이 되었는데, 다른 인스턴스가 있는 경우 인스턴스를 삭제하여 단 하나만 존재하게 한다. 
        else
        {
            Destroy(this.gameObject);
        }
    }
    // static을 사용하여, 전역에서 접근할 수 있게 만들어준다. 이 함수를 사용하면, 다른 스크립터에서도 Singleton의 instance에 접근할 수 있다. 
    public static Singleton getInstance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
	// Singleton에 구현되어 있는 함수 중 하나 (예시)
    public void Function()
    {
        Debug.Log("Singleton 성공!");
    }
}