//================================================
//##		디자인 패턴 싱글톤 (Singleton)		##
//================================================

/*
 * <싱글톤 패턴>
 * 오직 한개의 클래스 인스턴스만을 갖도록 보장
 * 이에 대한 전역전인 접근점을 제공
 * 
 *  구현
 * 1. 생성자의 접근권한을 외부에서 생성할 수 없도록 제한
 * 2. 정적변수를 활용하여 캡슐화를 진행
 * 3. 전역에서 접근 가능한 인스턴스를 갖기 위해 정적변수를 사용
 * 4. GetInstance 함수를 통해서 단일 객체가 없는 경우 생성
 * 5. 단일 객체가 있는 경우는 단일객체를 반환해 주도록 구현
 * 
 *  장점
 * 1. 하나뿐인 존재로 주요 클래스, 관리자의 역할을 함
 * 2. 전역전 접근으로 참조에 필요한 작업이 없이 빠른접근가능
 * 3. 인스턴스들이 싱글톤을 통하여 데이터를 공유하기 쉬워짐
 * 
 *  단점
 * 1. 싱글톤이 너무 많은 책임을 짊어지는 경우를 주의해야함
 * 2. 싱글톤의 남발로 전역접근이 많아지게 되는 경우, 참조한 코드의 결합도가 높아짐
 */

public class Singleton
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }

        return instance;
    }
}