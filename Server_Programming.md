# Server Programming (C/C++, C#)
## Day02 : 헤더, 함수, 변수


+ 처음 프로젝트 생성시 볼 수 있는 코드
``` C
#include <stdio.h>  // #include : preprocess = header, stdio.h : 파일(file)명
int main(void)
{
	printf(“Hello World! \n”);
	return 0;
}
```
</br>

+ 헤더 파일의 이해
	- stdio.h = std(standard, 표준) + io(input & output, 입출력) + .h(헤더파일)
	- stdlib.h = std + lib(library, 라이브러리)
	- conio.h = con(console, 콘솔) + io
</br>

+ 함수
	- 적절한 입력과 그에 따른 출력이 존재 하는 것을 가리켜 함수라고 함
	- main, printf, return 등등
</br>

+ 간단한 입출력 코드 작성 및 해석 : [Hello.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/Hello/Hello.cpp)

</br>


## Day03 : 변수와 연산자
+ 자료형과 자료형의 크기를 확인하는 코드 : [DataType.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/DataType/DataType.cpp)
	- sizeof() 함수 사용
</br>

## Day04 : 반복문 & 조건문
+ 반복문의 기능 : 특정 영역을 특정 조건이 만족하는 동안 반복 실행하기 위한 문장
	- while / do~while / for
	- 구구단 프로그램: [gugudan.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/gugudan/gugudan.cpp)
</br>

+ 조건문 : 실행 조건이 만족되는 경우 코드문 진행
	- if문 / switch문
	- 1~9까지의 숫자를 입력받아 영어로 출력하는 프로그램(0은 종료) : [numToenglish.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/numToenglish/numToenglish.cpp) 주석처리 부분 참고
	- (심화) 0~9까지의 숫자를 입력받아 영어로 출력, 이외의 문자 또는 숫자는 종료 : [numToenglish.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/numToenglish/numToenglish.cpp)
</br>

## Day05 : 함수
+ main 함수
``` C
#include <stdio.h>
int main(void)
{
	printf(“Hello World! \n”);
	return 0;
}
```
	- 반환 형태 : int
	- 함수 이름 : main
	- 입력 형태 : (void)
</br>

+ 함수 예제 코드 : [FuncTest.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/FuncTest/FuncTest.cpp)
	-  Function Test 프로그램 : 키보드에서 단일 문자를 입력받고 해당 문자가 대(0)/소문자(1)/특수(2)/숫자키(3) 임을 분류
	-  'z'를 입력받으면 프로그램 종료 
</br>


## Day06 : 배열
* 1차원 배열
	- int array[10];
	- 배열 요소 자료형 : 배열을 구성하는 변수의 자료형
	- 배열 이름 : 배열에 접근할 때 사용되는 이름
	- 배열 길이 : 배열을 구성하는 변수 개수 (반드시 상수 사용)
	  => const를 사용하여 변수를 상수 처리해 배열 길이를 수정할 

``` C
const int student = 10;
int main(void) 
{
	// int array[10];
	int array[student];
}
```
</br>

+ 문자열과 char형 배열의 차이점 -> pdf파일 확인
</br>

+ 다차원 배열 : 인덱스가 여러개
+ 배열을 사용한 여러가지 함수 예제 코드 : [ArrayTest.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/ArrayTest/ArrayTest.cpp)
</br>

## Day07 : 다차원 배열과 포인터
* 포인터 : **주소**를 가리키는 **변수**
* 포인터 사용방법
	- 변수의 주소 값 : &a
	- 포인터를 사용해 주소 값의 데이터 값을 참조 : *a
	- swap()예제로 이해하는 포인터 사용법 : [SortTest.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/SortTest/SortTest.cpp)
``` C
void swap(int* a, int* b)	// a,b를 포인터로 선언하고 전달된 매개변수 값으로 설정(초기화)
{			// 포인터 사용방법 - 포인터가 가리키는 주소의 값 :*p
			//                 - 주소 자체 : p
	// 여기서 a와 b는 주소 값임을 주의하자!
	int temp;
	printf("	input>  a(%08x) : %d,  b(%08x) : %d\n", a, *a, b, *b);
	temp = *a;	// *a 포인터가 가리키는 주소의 값을 가져오기 위함
	//a = b;     warning! (a의 주소값이 b를 가리키게 되어 b값이 바뀌면 a도 동기화됨)
	*a = *b;
	*b = temp;
	printf("	result>  a(%08x) : %d,  b(%08x) : %d\n", a, *a, b, *b);
}
int SwapTest()
{
	int a = 50, b = 60;

	// %x : 16진수 출력, %8x : 8자리로 16진수 출력, %08x : 빈자리는 0으로 채움
	printf("original>  a(%08x) : %d,  b(%08x) : %d\n", &a ,a, &b, b);

	//swap a & b
	//swap(a, b);     warning! (a, b가 변하지 않음)
	swap(&a, &b);	//주소값 전달을 위해 &를 붙여줌

	printf("after swap>  a(%08x) : %d,  b(%08x) : %d\n", &a ,a, &b, b);

	return 0;
}
```
</br>

## Day08 : 포인터 배열과 함수, 그리고 void
* 포인터 배열
``` C
const char* arr[] = {“A”, “B”, “C”};
```
	- char* : **string 배열**
* SortTest.cpp에서 string형 name2를 swap하기 위한 swapEX2() 이해하기 : [SortTest.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/SortTest/SortTest.cpp)
</br>

* 포인터와 함수에 대한 이해
	- 값의 복사에 의한 전달 (call-by-value)
	- 배열 이름(주소, 포인터)에 의한 전달 (=참조에 의한 전달, call-by-reference)
</br>

* 포인터와 포인터 : 더블 포인터 / 문자열배열(string), 2차원 배열 등에서 사용됨
	- 구현 사례 : 더블포인터 입장에서의 swap
	- 잘못된 예시 : 주소값을 바꾼 것, 값이 바뀌지 않음
	``` C
	void swapEx2(const char** a, const char** b) // 문자열 swap : string * (스트링 포인터)
	{
		const char **temp;
		temp = a;
		a = b;
		b = temp;
	}
	```
	- 올바른 예시
	```C
	void swapEx2(const char** a, const char** b) // 문자열 swap : string * (스트링 포인터)
	{
		const char *temp;
		temp = *a;
		*a = *b;
		*b = temp;
	}
	```
</br>

* void 포인터
	- type이 없는 포인터
	- 자료형에 대한 정보가 제외된 주소 정보를 담을 수 있는 형태의 변수
	- 임시로 선언해놓고 -> casting(강제 형 변환)을 수행하여 사용
```C
int main()
{
	char c = ‘a’;
	int n = 10;
	void* vp;	// void pointer
	vp = &c;	// char형 변수 c의 주소 값을 가짐
	vp = &n;	// int형 변수 n의 주소 값을 가짐
	...
}
```
</br>

* void pointer 예시
	* [ArrayTest.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/ArrayTest/ArrayTest.cpp) : VoidTest() 참고
	```C
	void AllSwap(void* a, void* b, int i)
	{
	int itemp; double dtemp; char ctemp;
	if (i == 1) // 1바이트 :  char
	{
		ctemp = *(char*)a;
		*(char*)a = *(char*)b;
		*(char*)b = ctemp;
	}
	else if (i == 4) // 4바이트 : int, float, const char*(strig)
	{
		itemp = *(int*)a;
		*(int*)a = *(int*)b;
		*(int*)b = itemp;
	}
	else if (i == 8) // 8바이트 : double
	{
		dtemp = *(double*)a;
		*(double*)a = *(double*)b;
		*(double*)b = dtemp;
	}
	}
	```
</br>

* void pointer를 사용하여 [SortTest.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/SortTest/SortTest.cpp)의 swap함수 합치기
	- SortTest.cpp에서 자료형에 따라 swap함수를 여러 개 선언한 것을 하나로 합치기
		  ex) swapEx(int), swapEx1(double), swapEx2(const char*)
      	=> AllSwap(void* a, void* b, int i)  : i는 자료형을 구분하기 위한 인자
	``` C
	void AllSwap(void* a, void* b, int i)
	{
	int itemp; double dtemp; char ctemp;
	if (i == 1) // 1바이트 :  char
	{
		ctemp = *(char*)a;
		*(char*)a = *(char*)b;
		*(char*)b = ctemp;
	}
	else if (i == 4) // 4바이트 : int, float, const char*(strig)
	{
		itemp = *(int*)a;
		*(int*)a = *(int*)b;
		*(int*)b = itemp;
	}
	else if (i == 8) // 8바이트 : double
	{
		dtemp = *(double*)a;
		*(double*)a = *(double*)b;
		*(double*)b = dtemp;
	}
	}
	```
</br>

## Day09 : 구조체
- 구조체 정의와 접근(access)
```C
struct point		// point라는 이름의 구조체 선언
{
	int x;		// 구조체 멤버 int x
	int y;		// 구조체 멤버 int y
};
int main()
{
	struct point p1;
	p1.x = 10;
	p1.y = 20;
	...
	return 0;
}
```
</br>

- 구조체 변수의 초기화
	- 배열 초기화 문법과 일치
	- **배열이랑 구조체 차이점??** 배열은 동일한 data type의 집합/구조체는 동일하지 않은 data type의 집합
</br>

- 중첩된 구조체
	- 구조체의 멤버로 구조체 변수가 오는 경우
	``` C
	struct point {
		int x;
		int y;
	};
	struct circle {
	struct point p;
	double radius;
	};

	int main()
	{
	//struct circle c = {1, 2, 3.0};
	struct circle c = { (1, 2), 3.0};
	//두 개는 동일하지만, 아래의 경우로 쓰길 권장
	}
	```

- **typedef** : 자료형의 이름을 새롭게 지어주기 위한 키워드
	- case1과 2는 동일한 구조체 => 대게 case2처럼 사용 (자세한 내용은 pdf파일 참고)
``` C
// case 1
struct point {
	int x;
	int y;
};
typedef struct point point;

// case 2
typedef struct{
	int x;
	int y;
} point;
```
</br>

- union : 공용체 (C언어에서만 사용하는 키워드)
	- 공용체의 특성 : 하나의 메모리 공간을 둘 이상의 변수가 공유하는 형태
- enum (enumeric) : 열거형
	- 열거형의 정의와 의미 : 정수의 값에 이름을 붙여준다고 생각하자!
	- 열거형 사용 이유 : 특정 정수 값에 의미 부여 가능 / 프로그램의 가독성을 높이는데 도움이 됨
</br></br>

### Q. student 구조체를 이용하여 사용자 정의 자료형을 선언하고 10명의 학생에 대한 데이터를 입력한 후 정렬하여 출력하시오.
- 이전 SortTest().cpp를 기반으로 문제를 풀어보자! : [GradeProcessing.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/GradeProcessing/GradeProcessing.cpp)


## Day10 & 11 : C 표준 함수
- C 표준 함수는 **모든 플랫폼**(H/W : PC, Mac, 라즈베리 등 / OS : 윈도우, 맥OS, 리눅스 등)에서 사용 가능
- 문자와 문자열 처리 함수(표준함수) : strlen() 문자열 반환, strcpy() 문자열 복사

- 입출력의 이해 : 파일, 콘솔, 소켓 입출력
</br>

- 파일 입력 & 출력함수 (예제코드 : [ArrayTest.cpp_StreamTest()](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CTest/ArrayTest/ArrayTest.cpp))
	- fopen() 으로 파일 포인터를 설정
	- fgetc() : 단일문자, fgets() : 문자열, fscanf() : 형식 지정 입력 함수
	- fputc(), fputs(), fprintf()
	- fopen()으로 열어줬으면 fclose()를 항상 불러주자 (or fcloseall())
</br></br>

## Day12 : C 표준 함수_문자열함수 / 동적할당 / 모듈화 프로그래밍
### 문자열 함수
- 문자열 복사 함수 : **strcpy()**
	- 문자열은 대입 연산자를 사용할 수 없기 때문에 문자열 복사 함수를 사용
	- strncpy(char* dest, const char* src, size_t n)  : ‘\0’이 포함되지 않음
	```C
	int main()
	{
		...
		for(int I=0; i<num; I++)
		{
			student[i].kor = kor[i];
			student[i].eng = eng[i];
			strcpy(student[i].name, name[i]);
		}
	}
	```
</br>

- 문자열 결합 함수 : **strcat(), strncat()**
- 문자열 비교 함수 : int **strcmp()**  =>  조건문에서 자주 사용됨
	- strcmp(str1, str2)는 –1, 0, 1 을 반환함
	- str1 < str2 => -1 반환 / str1 == str2 => 0 반환 / str1 > str2 => 1 반환
- 문자열을 숫자로 변환하는 함수 : **atoi(), atol(), atof()**   ==>  **<stdlib.h>**
	- int atoi(char* ptr); 	// ascii to integer, 문자열을 int형으로 데이터 변환
	- long atol(char* ptr); 	// ascii to long, 문자열을 long형으로 데이터 변환
	- **double** atof(char* ptr); 	// ascii to float, 문자열을 double형으로 데이터 변환
- 대소문자의 변환을 처리하는 함수들 : **toupper(), tolower()**   ==>  **<ctypes.h>**
	- int toupper(int c);	//소문자를 대문자로
	- int tolower(int c);	//대문자를 소문자로
</br>

### 메모리 관리와 동적 할당
- 스택, 힙 그리고 데이터 영역
	- 프로그램의 실행을 위해 기본적으로 할당하는 메모리 공간
	- 컴파일 타임에 함수에서 요구하는 스택의 크기 결정되어야함
		- 데이터 영역 : 전역변수, static 변수 (고정된 영역, 컴파일러가 정해주기 때문)
		- 힙(heap) 영역 : 프로그래머 할당
		- 스택(stack) 영역 : 지역변수, 매개변수
</br>

- 메모리 동적 할당 => **malloc** : memory + allocation
	- **void***(포인터 연산, value 참조 불가 => 따라서 cast필요-❷) **반환하는 메모리 확보 함수**
	- 크기 7인 student 자료형(구조체)의 배열을 동적 할당하라 (GradeProcessing.cpp)
	``` C
	int main()
	{
	int num;
	student* Students;	// malloc를 통해 메모리 확보
	...
	fscanf(fftable, "%d", &num);// 파일입출력을 통해 num=7 read
	Students = (student*)malloc(sizeof(student) * num);
	...
	}
	```
	
	- student* Students = (student*)malloc(sizeof(student) * num);
		- (student*) : malloc의 반환형이 void* 이므로 (student*)형태로 형 변환 해달라는 것
		- sizeof(studnet) : sizeof()는 괄호 안에 자료형 타입을 바이트로 연산해주는 연산자
		- sizeof(studnet)*num : Students[num]과 동일한 크기의 메모리 할당을 위한 것
</br>

- '#' 으로 시작하는 전처리기 지시자
	- #include <> : 뒤에 나오는 시스템 헤더<>를 포함시키는 지시자
		- 프로그래머가 만든 헤더를 사용할 때는 “”를 사용
	- #define PI(매크로) 3.1415(대체리스트)
		- 컴파일러에 의해 처리되는 것이 아님
		- 전처리기에게 단순 치환 작업을 요청할 때 사용되는 지시자 (=변수 선언과 비슷)

- 매크로 함수란? : 매크로를 기반으로 정의되는 함수 / 함수가 아니라 매크로다!! 다만 함수의 특성을 지닐 뿐
	- #define SQUARE(x) x*x		// x : 매크로함수 인자
</br></br>

## DAY13 : C++
### C++  특징 이해하기
- 함수 오버로딩
	- 매개 변수의 선언이 다르면, 동일한 이름의 함수 정의 가능
- 매개변수의 **디폴트** 값
	- 인자를 전달하지 않은 경우, 디폴트 값으로 저장 됨
	- 디폴트 값을 지정할 때는, 뒤에서부터 설정해야한다!
	```C
	int YourFunc(int num1, int num2, int num3 = 10) { ... }		// OK
	int YourFunc(int num1 = 50, int num2, int num3) { ... }		// Error
	```
</br></br>

## DAY14
### Reference &
- reference의 이해
 	- reference는 기존에 선언된 변수에 붙이는 ‘별칭’, 변수 이름과 별 차이 없음
	- 하나의 공간에 여러개의 이름이 붙는다고 생각하자
```C
int num1 = 10;		// 변수 선언으로 num1이라는 메로리 공긴이 할당
int &num2 = num1;	// reference의 선언으로 num1의 메모리 공간에 num2라는 이름이 추가로 붙음
```
</br>

- reference기반의 Call-by-reference : [ReferenceTest.cpp](https://github.com/Hi-Bean/IoT_SW_Programming/blob/main/Server%20Programming/CppTest/ReferenceTest/ReferenceTest.cpp)
- return 값이 reference인 경우
	- int& RefRetFuncOne(int &ref) { ... }  => 반환형이 reference인 경우에 받는 변수는 일반, ref 모두 가능!
	- return 값이 ref인 경우, 일반적으로 반환은 함수에 사용된 ref 인자여야 함
	```C
	int& num2 = RefRetFuncOne(num1);	// OK, 잘 사용하진 않음
	int num2 = RefRetFuncOne(num1);		// OK
	```
	
	- int RefRetFuncOne(int &ref) { ... }  => 받는 변수는 무조건 일반 value값을 가져야함
	```C
	int& num2 = RefRetFuncOne(num1);	// Error
	int num2 = RefRetFuncOne(num1);		// OK
	```
	</br>

### new & delete
- new : malloc을 대신하는 메모리 동적 할당 방법, 변수형으로 선언해줌 (malloc은 void 포인터)
- delete : 동적 할당된 메모리 해제
</br>

### C++에서의 구조체 : CLASS
- 구조체의 등장배경
	- 구조체는 연관있는 데이터를 하나로 묶는 문법적 장치
	- C++에서는 구조체 변수 선언시, struct 키워드의 생략을 위한 typedef 선언이 불필요하다!
	- 데이터 뿐만 아니라, 해당 데이터와 연관 있는 함수들도 포함시킬 수 있음! => C++에서는 CLASS라 칭함
- 구조체 안에 함수 삽입하기
	- C++에서는 구조체 안에 함수 삽입이 가능 -> 함께 선언된 변수에는 직접 접근이 가능함
	- 함수 본체를 선언할 수도 있지만, 프로토타입만 작성하고 외부로 뺄 수 있음 (이 때, 함수이름 앞에 소속(클래스)을 명시 해줘야함)
- 구조체 안에 enum 상수 선언
	- 구조체 안에 enum을 선언함으로써 잘못된 외부 접근을 제한할 수 있음
</br>


### 클래스(class)와 객체(object)
- 클래스와 구조체의 차이점
	- class로 선언된 멤버는 main함수에서 직접 접근이 불가능함
	 => 접근제어와 관련된 함수 선언이 필요

- 접근제어 지시자 (변수, 함수 모두 적용)
	- public : 어디서든 접근 허용
	- protected : 상속관계에 놓여있을 때, 유도 클래스에서의 접근 허용
	- private : 클래스 내(클래스 내에 정의된 함수)에서만 접근 허용

- 용어 정리
	- 객체(object) : =클래스 / 클래스를 대상으로 생성된 변수를 객체라고 함
	- 멤버 변수 : 클래스 내에 선언된 변수 (attribute)
	- 멤버 함수 : 클래스 내에 정의된 함수 (method)
