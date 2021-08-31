#include <iostream>
#include <cstdio>
#include <cmath>
#include "MyHeader.h"
using namespace std;

//		reference 예제 / 포인터와 레퍼런스 이해하기
//		2D 두 점과 3D 두 점의 거리 구하기 등
//int main()
//{
//	//cout << "Hello C plus plus World!\n\n";
//	//int a, b;
//	//a = 10;
//	//b = 20;
//	//cout << "초기값은 a = " << a << ", b = " << b << endl;
//	//SwapValue(a, b);
//	//cout << "결과값(SwapValue)은 a = " << a << ", b = " << b << endl << endl;
//	//SwapRef(a, b);	// reference type 호출 => 실변수를 인자로 사용
//	//printf("결과값(SwapRef : reference type)은 a = %d, b = %d\n\n", a, b);
//	////cout << "결과값(SwapRef)은 a = " << a << ", b = " << b << endl;
//	//SwapRef(&a, &b); // pointer type 호출
//	//printf("결과값(SwapRef : pointer type)은 a = %d, b = %d\n\n", a, b);
//
//	// 2D class Point
//	Point p1;		// p(0,0)
//	Point p2(10,20);
//	Point* pp3 = new Point(20, 30);	// 동적할당
//	Point& p3 = *pp3;	// reference = 별명
//
//	printf("Point class 변수의 동적 할당 : p3(%d, %d)\n", pp3->X(), pp3->Y());
//
//	printf("두 점 p1(%d, %d)과 p2(%d, %d)의 거리는 %f 입니다.\n\n",
//		p1.X(), p1.Y(), p2.X(), p2.Y(), p1.distance(p2));
//
//	Point p4 = p1 + p2;
//	printf("두 점 p1(%d, %d)과 p2(%d, %d)의 합은 (%d, %d) 입니다.\n\n",
//		p1.X(), p1.Y(), p2.X(), p2.Y(), p4.X(), p4.Y());
//
//	// Point p4 = p2 + pp3;			// error
//	p4 = p2 + *pp3;
//	/*printf("두 점 p2(%d, %d)와 p3(%d, %d)의 합은 (%d, %d) 입니다.\n\n",
//		p2.X(), p2.Y(), pp3->X(), pp3->Y(), p4.X(), p4.Y());*/
//	printf("두 점 p2(%d, %d)와 p3(%d, %d)의 합은 (%d, %d) 입니다.\n\n",
//		p2.X(), p2.Y(), pp3->X(), (*pp3).Y(), p4.X(), p4.Y());
//
//	/*p4 = p2 + p3;
//	printf("두 점 p2(%d, %d)와 p3(%d, %d)의 합은 (%d, %d) 입니다.\n\n",
//		p2.X(), p2.Y(), p3.X(), p3.Y(), p4.X(), p4.Y());*/
//
//	Point p5 = p2 * 3;
//	printf("점 p2(%d, %d)의 n = %d인 스칼라 곱은 (%d, %d) 입니다.\n\n",
//		p2.X(), p2.Y(), 3, p5.X(), p5.Y());
//
//
//	// 3D class Point
//	//Point3D pp1;
//	//Point3D pp2(10, 20, 30);
//	//Point3D* pp3 = new Point3D(40,50,60);
//
//	//printf("Point3D class 변수의 동적 할당 : pp3(%d, %d, %d)\n", pp3->X(), pp3->Y(), pp3->Z());
//
//	//printf("두 점 pp3(%d, %d, %d)과 pp2(%d, %d, %d)의 거리는 %f 입니다.\n\n",
//	//	pp3->X(), pp3->Y(), pp3->Z(), pp2.X(), pp2.Y(), pp2.Z(), pp3->distance(pp2));
//	////pp2.distance(*pp3)
//	//
//
//	return 0;
//}

int main()
{
	string str1 = "hello, ";
	string str2 = "world";
	cout << Add<int>(20, 30) << endl;
	cout << Add<double>(3.14, 2.9) << endl;
	cout << Add<string>(str1, str2) << endl;


	return 0;
}
