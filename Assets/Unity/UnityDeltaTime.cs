using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityDeltaTime : MonoBehaviour
{
    /************************************************************************
	 * 프레임과 단위시간 (Frame & DeltaTime)
	 * 
	 * 프레임(Frame) : 정지된 게임상황
	 * FPS(Frame per Second) : 1초 동안 표현한 프레임수
	 * 단위시간(DeltaTime) : 1프레임 동안 소모한 시간
	 * DeltaTime == 1 / FPS
	 ************************************************************************/

    // <프레임>
    // 만화영화의 움직이는 그림들은 연속된 정지 그림들을 빠르게 전환하며 보여주어 움직이는 듯한 착각을 일으키는 방법
    // 게임도 마찬가지로 정지된 게임상황을 연속적으로 빠르게 교체하여 움직이는 게임상황처럼 표현함
    // 이 각각의 정지 게임상황을 '프레임(Frame)'이라함
    // Unity의 경우 1프레임 당 1Update 가 진행됨

    // <FPS>
    // 1초 동안 표현한 프레임수
    // 보통의 경우 30FPS 이상일 경우 움직이는 듯한 시각효과를 보여주며,
    // 30FPS 이하일 경우 눈으로도 게임의 정지상황을 포착할 수 있게 됨

    // <단위시간>
    // 1프레임 동안 소모한 시간
    // 단위시간 == 1 / FPS

    // <시간동기화>
    // 게임의 FPS은 가변적이며 확정되어 있지 않음
    // 컴퓨터의 사양에 따라 처리시간이 다르거나, 외부의 요인으로 지연시간이 발생할 수 있음
    // 게임이 다양한 상황에 따라 처리시간이 다를 수 있지만, 어떠한 기기에서든 동일한 게임진행이 되어야함
    // 단위시간을 기반으로 게임을 구성할 경우 처리시간과 무관하게 모든 기기에서 동인한 게임진행이 가능함

    // ex)
    // 게임이 10FPS 일 경우 : 1 / 10초마다 10번씩 움직임 -> 결과는 1초동안 1 움직임
    // 게임이 100FPS 일 경우 : 1 / 100초마다 100번씩 움직임 -> 결과는 1초동안 1 움직임
    // 게임이 x FPS 일 경우 : 1 / x 초마다 x번씩 움직임 -> 결과는 1초동안 1 움직임
}
