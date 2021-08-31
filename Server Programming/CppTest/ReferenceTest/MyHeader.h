// 함수의 원형(prototype) 선언
void SwapValue(int a, int b);
void SwapRef(int &a, int &b);
void SwapRef(int* a, int* b);

// class 선언
class Point
{
private:
	int x;
	int y;

public:
	//Point(int x = 0, int y = 0)			// 생성자 (디폴트값도 정의)
	//{
	//	this->x = x;
	//	this->y = y;
	//}

	Point(int x = 0, int y = 0) : x(x), y(y)	// 생성자 (이니셜라이즈사용)
	{}
	int X() { return x; }
	int Y() { return y; }
	void setX(int x) { this->x = x; }
	void setY(int y) { this->y = y; }
	double distance(Point p);

	Point operator + (Point &P)
	{
		return Point(x + P.x, y + P.y);
	}
	
	Point operator * (int n)		// scalar 곱
	{
		return Point(x * n, y * n);
	}

	Point operator += (Point P)
	{
		x += P.x;
		y += P.y;
		return *this;		// this는 포인터이기 때문에 값 반환을 위해 '*' 붙임
	}
};

class Point3D : public Point		// 2D Point class 상속
{
private:
	int z;		// z축

public:
	Point3D(int x = 0, int y = 0, int z = 0) : Point(x, y)
	{
		this->z = z;
	}
	int Z() { return z; }
	void setZ(int z) { this->z = z; }
	double distance(Point3D p);
};

template <typename T>
T Add(T num1, T num2)
{
	return num1 + num2;
}