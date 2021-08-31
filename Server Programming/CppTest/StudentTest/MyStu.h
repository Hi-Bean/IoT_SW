#include <iostream>
#include <string>
using namespace std;
class Person
{
private:
    int Number;  // 고유 번호
    char Name[20];  // 문자열을 담을 그릇 : 한글 10자
    int Age;

public:
    Person(int num, char* str = NULL, int a = 0) : Number(num), Age(a)
    {
        strcpy(Name, str);
    }
    Person(int num, const char* str = NULL, int a = 0) : Number(num), Age(a)
    {
        strcpy(Name, str);
    }
    int age() { return Age; }
    char* name() { return Name; }
    int number() { return Number; }
    void SetAge(int a) { Age = a; }
    void SetName(char* str)  // 기존 방을 비우고(delete) 새 방을 잡자. XXXXXXXXXX
    {
        strcpy(Name, str);
    }
};

class PersonEx
{
private:
    int Number;  // 고유 번호
    char* Name;  // 문자열을 담을 그릇은? ==> malloc 혹은 new 를 이용하여 동적으로 할당 필요
    int Age;

public:
    PersonEx(int num, char* str, int a) : Number(num), Age(a)
    {
        Name = new char[strlen(str)];
        strcpy(Name, str);
    }
    ~PersonEx()
    {
        delete[]Name;
    }
    int age() { return Age; }
    char* name() { return Name; }
    void SetAge(int a) { Age = a; }
    void SetName(char* str)  // 기존 방을 비우고(delete) 새 방을 잡자.
    {
        delete[]Name;
        Name = new char[strlen(str)];
        strcpy(Name, str);
    }
};

class Student : public Person
{
private:
    int Kor;
    int Eng;
    int Tot;
    double Avg;
    int Rank;
    void calc()
    {
        Tot = Kor + Eng;
        Avg = (double)Tot / 2.0;
    }
public:
    Student(int num, int kor, int eng, char* str = NULL, int age = 0) : Person(num, str, age)
    {
        this->Kor = kor;
        this->Eng = eng;
        calc();
    }
    Student(int num, int kor, int eng, const char* str = NULL, int age = 0) : Person(num, str, age)
    {
        this->Kor = kor;
        this->Eng = eng;
        calc();
    }
    Student(int num, int kor, int eng, string str = NULL, int age = 0) : Person(num, str.c_str(), age)
    {
        this->Kor = kor;
        this->Eng = eng;
        calc();
    }
    int kor() { return Kor; }
    int eng() { return Eng; }
    int tot() { return Tot; }
    double avg() { return Avg; }
    int rank() { return Rank; }
    void SetKor(int k) { Kor = k; calc(); }
    void SetEng(int e) { Eng = e; calc(); }
    void SetRank(int r) { Rank = r; }
};