#include <iostream>
#include <cstdio>
#include <cmath>
#include "MyHeader.h"
using namespace std;

//		reference ���� / �����Ϳ� ���۷��� �����ϱ�
//		2D �� ���� 3D �� ���� �Ÿ� ���ϱ� ��
//int main()
//{
//	//cout << "Hello C plus plus World!\n\n";
//	//int a, b;
//	//a = 10;
//	//b = 20;
//	//cout << "�ʱⰪ�� a = " << a << ", b = " << b << endl;
//	//SwapValue(a, b);
//	//cout << "�����(SwapValue)�� a = " << a << ", b = " << b << endl << endl;
//	//SwapRef(a, b);	// reference type ȣ�� => �Ǻ����� ���ڷ� ���
//	//printf("�����(SwapRef : reference type)�� a = %d, b = %d\n\n", a, b);
//	////cout << "�����(SwapRef)�� a = " << a << ", b = " << b << endl;
//	//SwapRef(&a, &b); // pointer type ȣ��
//	//printf("�����(SwapRef : pointer type)�� a = %d, b = %d\n\n", a, b);
//
//	// 2D class Point
//	Point p1;		// p(0,0)
//	Point p2(10,20);
//	Point* pp3 = new Point(20, 30);	// �����Ҵ�
//	Point& p3 = *pp3;	// reference = ����
//
//	printf("Point class ������ ���� �Ҵ� : p3(%d, %d)\n", pp3->X(), pp3->Y());
//
//	printf("�� �� p1(%d, %d)�� p2(%d, %d)�� �Ÿ��� %f �Դϴ�.\n\n",
//		p1.X(), p1.Y(), p2.X(), p2.Y(), p1.distance(p2));
//
//	Point p4 = p1 + p2;
//	printf("�� �� p1(%d, %d)�� p2(%d, %d)�� ���� (%d, %d) �Դϴ�.\n\n",
//		p1.X(), p1.Y(), p2.X(), p2.Y(), p4.X(), p4.Y());
//
//	// Point p4 = p2 + pp3;			// error
//	p4 = p2 + *pp3;
//	/*printf("�� �� p2(%d, %d)�� p3(%d, %d)�� ���� (%d, %d) �Դϴ�.\n\n",
//		p2.X(), p2.Y(), pp3->X(), pp3->Y(), p4.X(), p4.Y());*/
//	printf("�� �� p2(%d, %d)�� p3(%d, %d)�� ���� (%d, %d) �Դϴ�.\n\n",
//		p2.X(), p2.Y(), pp3->X(), (*pp3).Y(), p4.X(), p4.Y());
//
//	/*p4 = p2 + p3;
//	printf("�� �� p2(%d, %d)�� p3(%d, %d)�� ���� (%d, %d) �Դϴ�.\n\n",
//		p2.X(), p2.Y(), p3.X(), p3.Y(), p4.X(), p4.Y());*/
//
//	Point p5 = p2 * 3;
//	printf("�� p2(%d, %d)�� n = %d�� ��Į�� ���� (%d, %d) �Դϴ�.\n\n",
//		p2.X(), p2.Y(), 3, p5.X(), p5.Y());
//
//
//	// 3D class Point
//	//Point3D pp1;
//	//Point3D pp2(10, 20, 30);
//	//Point3D* pp3 = new Point3D(40,50,60);
//
//	//printf("Point3D class ������ ���� �Ҵ� : pp3(%d, %d, %d)\n", pp3->X(), pp3->Y(), pp3->Z());
//
//	//printf("�� �� pp3(%d, %d, %d)�� pp2(%d, %d, %d)�� �Ÿ��� %f �Դϴ�.\n\n",
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
