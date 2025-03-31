// 001_bmi.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <stdio.h>

int main()
{
	// 키와 체중을 입력받아서, bmi를 계산하고, 출력
	double h; // 키
	double w; // 체중

	printf("키(cm) : ");
	scanf_s("%lf", &h);

	printf("체중(kg) : ");
	scanf_s("%lf", &w);

	h /= 100;	// m로 환산

	double bmi = w / (h * h);
	printf("bmi = %lf\n", bmi);
}
