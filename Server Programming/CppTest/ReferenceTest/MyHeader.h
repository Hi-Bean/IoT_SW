// �Լ��� ����(prototype) ����
void SwapValue(int a, int b);
void SwapRef(int &a, int &b);
void SwapRef(int* a, int* b);

// class ����
class Point
{
private:
	int x;
	int y;

public:
	//Point(int x = 0, int y = 0)			// ������ (����Ʈ���� ����)
	//{
	//	this->x = x;
	//	this->y = y;
	//}

	Point(int x = 0, int y = 0) : x(x), y(y)	// ������ (�̴ϼȶ�������)
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
	
	Point operator * (int n)		// scalar ��
	{
		return Point(x * n, y * n);
	}

	Point operator += (Point P)
	{
		x += P.x;
		y += P.y;
		return *this;		// this�� �������̱� ������ �� ��ȯ�� ���� '*' ����
	}
};

class Point3D : public Point		// 2D Point class ���
{
private:
	int z;		// z��

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