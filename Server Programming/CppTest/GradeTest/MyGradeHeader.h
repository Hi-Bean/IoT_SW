#include <cString>                               
class Person
{
private:
	char name[50];
	int age;

public:
	// »ý¼ºÀÚ

	//Person(const char* p_name, int p_age = 0) : age(p_age) 
	//{
	//	strcpy(name, p_name);
	//}

	char* getName() { return name; }
	int getAge() { return age; }
	void setName(char* n) { strcpy(this->name, n); }
	void setAge(int a) { this->age = a; }
};

class Student : public Person
{
private:
	int kor;
	int eng;
	int tot;
	double avg;

public:
	/*
	Student(char* p_name, int p_age, int p_kor, int p_eng) : Person(p_name, p_age)
	{
		this->kor = p_kor;
		this->eng = p_eng;
	}*/

	int getKor() { return kor; }
	int getEng() { return eng; }
	int getTot() { return tot; }
	double getAvg() { return avg; }
	void setKor(int kor) { this->kor = kor; }
	void setEng(int eng) { this->eng = eng; }
	void setAvg()
	{
		tot = kor + eng;
		avg = kor * 0.3 + eng * 0.7;
	}
};

void swap(Student* a, Student* b);
void sortEX(Student* S, int n);
