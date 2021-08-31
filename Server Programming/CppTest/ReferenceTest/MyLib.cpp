#include "MyHeader.h"
#include <cmath>

void SwapValue(int a, int b)
{
	int temp = a;
	a = b; b = temp;
}

void SwapRef(int& a, int& b)	// �����͸� ������� ����, reference����� Call-by-Ref!
{
	//printf("reference type ȣ��\n");
	int temp = a;
	a = b; b = temp;
}

void SwapRef(int* a, int* b)	// ������ ��� - SwapRef �Լ� �����ε�
{
	//printf("pointer type ȣ��\n");
	int temp = *a;
	*a = *b; *b = temp;
}

double Point::distance(Point p)	// Point p���� �Ÿ�
{
	double x2 = pow(this->x - p.x, 2);		// x�� ����
	double y2 = pow(this->y - p.y, 2);		// y�� ����

	return sqrt(x2 + y2);
}

double Point3D::distance(Point3D p)	// Point3D p���� �Ÿ�
{
	double x2 = pow(this->X() - p.X(), 2);		// x,y�� ���ٺҰ� ��� (��ӹ���)
	double y2 = pow(this->Y() - p.Y(), 2);		// ���� ����Լ��� ����
	double z2 = pow(this->z - p.z, 2);			// z�� Point3D�� ����̹Ƿ� ���� ���� ����

	return sqrt(x2 + y2 + z2);
}