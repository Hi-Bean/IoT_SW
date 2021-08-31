#include "MyHeader.h"
#include <cmath>

void SwapValue(int a, int b)
{
	int temp = a;
	a = b; b = temp;
}

void SwapRef(int& a, int& b)	// 포인터를 사용하지 않음, reference기반의 Call-by-Ref!
{
	//printf("reference type 호출\n");
	int temp = a;
	a = b; b = temp;
}

void SwapRef(int* a, int* b)	// 포인터 사용 - SwapRef 함수 오버로딩
{
	//printf("pointer type 호출\n");
	int temp = *a;
	*a = *b; *b = temp;
}

double Point::distance(Point p)	// Point p와의 거리
{
	double x2 = pow(this->x - p.x, 2);		// x의 제곱
	double y2 = pow(this->y - p.y, 2);		// y의 제곱

	return sqrt(x2 + y2);
}

double Point3D::distance(Point3D p)	// Point3D p와의 거리
{
	double x2 = pow(this->X() - p.X(), 2);		// x,y는 접근불가 멤버 (상속받은)
	double y2 = pow(this->Y() - p.Y(), 2);		// 따라서 멤버함수로 접근
	double z2 = pow(this->z - p.z, 2);			// z는 Point3D의 멤버이므로 직접 접근 가능

	return sqrt(x2 + y2 + z2);
}