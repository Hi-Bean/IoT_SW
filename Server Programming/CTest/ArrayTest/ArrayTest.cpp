#include <stdio.h>
#include <stdlib.h>		// srand(), rand()
#include <time.h>		//time()
#include <conio.h>
#include <string.h>

// 1. score
const int score_stu = 20;  // 학생 수는 상수로 지정
int score()
{
	double avg = 0, tot = 0, all_tot = 0; // 평균, 합
	double kor[score_stu], eng[score_stu], mat[score_stu];		// 각 학생들의 국어, 영어, 수학 점수를 위한 배열

	srand(time(NULL));
	for (int i = 0; i < score_stu; i++)
	{
		// kor[i] = (rand() % 1000 + 1) / 10;  
		//   -> rand()는 정수 난수를 발생하기 때문에 소숫점이하가 모두 0으로 저장됨
		//      따라서 형변환이 아래와 같이 필요함
		kor[i] = (double)(rand() % 1000 + 1) / 10;  // rand() : 난수 발생기 (정수)
		eng[i] = (double)(rand() % 1000 + 1) / 10;
		mat[i] = (double)(rand() % 1000 + 1) / 10;

	}
	printf("국어  영어  수학 /  총합  / 평균\n");
	printf("---------------------------------\n");
	for (int i = 0; i < score_stu; i++)
	{
		tot = kor[i] + eng[i] + mat[i];
		all_tot += tot;
		avg = tot / 3;
		printf("%4.1f  %4.1f  %4.1f / %6.1f / %4.1f\n", kor[i], eng[i], mat[i], tot, avg);
	}

	printf("\t\t  반 평균 : %4.1f\n", all_tot / (score_stu * 3));

	return 0;
}

// 2. Good
int Good()
{
	int i, j, k;
	char good[5] = "Good";
	char mon[] = "morning";
	char noon[] = "afternoon";
	char even[] = "evening";

	while (1)
	{
		
		printf("지금 몇시죠? "); scanf("%d", &k);
		if (k == 0) break;

		if (k >= 7 && k < 12)
		{
			printf("%s %s \n ", good, mon);
		}
		else if (k >= 12 && k < 18)
		{
			printf("%s %s \n ", good, noon);
		}
		else if (k >= 18 && k < 23)
		{
			printf("%s %s \n ", good, even);
		}
		else
		{
			printf("Hi!\n ");
		}
	}

	return 0;
}

// 3. Pointer Test
int PointerTest()
{
	int a[3][2] = { 1, 2, 3, 4, 5, 6 };

	printf("a[0] : %x \n", a[0]);
	printf("a[1] : %x \n", a[1]);
	printf("a[2] : %x \n", a[2]);
	printf("a    : %x \n\n\n\n", a);

	printf("a   : %x \n", a);
	printf("a+1 : %x \n", a + 1);
	printf("a+2 : %x \n", a + 2);

	return 0;
}
// function define 
//     Prototype  :  int str_len(char *str)
// 문자열 str을 받아서 해당 문자열의 길이를 되돌려 줌.
int str_len(char* str)  // 배열이 아닌 포인터로 받음  int str_len(char str[])과 동일 (배열과 포인터 혼용가능)
{
	int ret = 0;
	//	while (*(str + ret++)); return ret;
	while (1)
	{
		if (str[ret] != 0) ret++;
		else break;
	}
	return ret;

	// return strlen(str);    // <string.h> 파일에 포함된 문자열 길이 반환 함수
}

// 4. solution1()
int solution1()
{
	//문1) scanf 함수를 이용하여 문자열을 입력후
	//    해당 문자열을 한 글자씩 공백(_)을 삽입하여
	//	  출력하시오.
	//    > 12345   ==>  1_2_3_4_5
	//문2) scanf 함수를 이용하여 문자열을 입력후
	//     getch() 함수를 이용하여 숫자 키를 누르면
	//	   해당 위치의 문자를 출력하시오

	char buf[100];  //	buffer : 버퍼 : 배열의 이름 == 포인터
	int i, str_length, input_num;

	printf("문자열을 입력하세요 : "); scanf("%s", buf);
	printf("입력문자열 [%s] 의 길이는 %d 입니다 \n", buf, str_length = str_len(buf));
	for (i = 0; i < str_length; i++)
	{
		printf("%c_", buf[i]);
	}
	printf("\n");
	while (1)
	{
		input_num = getch() - 0x30;   // 0 ~ 9 숫자키 (    ) 입력
		if (input_num >= 0 && input_num <= 9)
		{
			printf("%c\n", buf[input_num]);
			continue;
		}
		break;
	}

	return 0;
}

// 5. SwapTest()
// function define 
//     Prototype  :  int swap(int a, int b)
// 정수 변수 a와 b의 값을 교환
void swap(int* a, int* b)	// a,b를 포인터로 선언하고 전달된 매개변수 값으로 설정(초기화)
{							// 포인터 사용방법 - 포인터가 가리키는 주소의 값 :*p
							//				   - 주소 자체 : p
	// 여기서 a와 b는 주소 값임을 주의하자!
	int temp;
	//printf("	input>  a(%08x) : %d,  b(%08x) : %d\n", a, *a, b, *b);
	temp = *a;	// *a 포인터가 가리키는 주소의 값을 가져오기 위함
	//a = b;     warning! (a의 주소값이 b를 가리키게 되어 b값이 바뀌면 a도 동기화됨)
	*a = *b;
	*b = temp;
	//printf("	result>  a(%08x) : %d,  b(%08x) : %d\n", a, *a, b, *b);
}
int SwapTest()
{
	int a = 50, b = 60;

	// %x : 16진수 출력, %8x : 8자리로 16진수 출력, %08x : 빈자리는 0으로 채움
	printf("original>  a(%08x) : %d,  b(%08x) : %d\n", &a ,a, &b, b);

	//swap a & b
	//swap(a, b);     warning! (해당 함수에서는 a, b가 변하지 않음)
	swap(&a, &b);	//주소값 전달을 위해 &를 붙여줌

	printf("after swap>  a(%08x) : %d,  b(%08x) : %d\n", &a, a, &b, b);

	return 0;
}

// 6. SortTest()
int sort(int *a, int n)
{
	for (int i = 0; i < n; i++)
		for(int j = i + 1; j < n; j++)
		{
			if (a[i] < a[j])
				//swap(&a[i], &a[j]);  //아래와 동일함
				swap(a + i, a + j);
		}

	return 0;
}
int sortTest()
{
	int nArr = 11;  // arr의 개수
	int arr[] = {25, 27, 30, 47, 35, 68, 40, 79, 45, 85, 50};
	
	// print original data
	printf("original : ");
	for (int i = 0; i < nArr; i++)
		printf("%d  ", arr[i]);
	printf("\n");

	sort(arr, nArr);

	// print sorted data
	printf("sorted : ");
	for (int i = 0; i < nArr; i++)
		printf("%d  ", arr[i]);
	printf("\n");

	return 0;
}

// 7. VoidTest()
void VoidPrint(void* p, int i) // argument : void pointer
{
	if (i == 1)
	{
		char* cp = (char*)p;  // char형으로 casting
		printf("%c\n", *cp);
	}
	else if (i == 2)
		printf("%d\n", *(int*)p);	// int형으로 casting
	else if (i == 3)
		printf("%f\n", *(double*)p);	// double형으로 casting
}
void VoidTest()
{
	char c = 'z';
	int n = 10;
	double a = 1.414;
	
	// void 포인터
	void* vp;
	VoidPrint(vp = &c, 1);
	VoidPrint(vp = &n, 2);
	VoidPrint(vp = &a, 3);
}

// 8. StreamTest()
void StreamTest()
{
	char buf[1024];
	int i;
	float a;
	// "r" : 읽기전용, "w" : 쓰기용(overwrite : 기존 내용을 지우고 새롭게 작성)
	// "a" : append 모드 - 기존 파일을 보존하며 뒤에 추가하는 방식

	// f, fout1, fout2, fout3 : file pointer
	FILE* fin =  fopen("C:\\Users\\hallo\\aa.txt","r"); //파일 이름은 포인터로 정의해야함
	// 입력용일 때, 없는 파일에 접근하게 된다면 fopen()은 NULL을 반환
	/*FILE* fout1 = fopen("C:\\Users\\hallo\\aa.o1", "w");
	FILE* fout2 = fopen("C:\\Users\\hallo\\aa.o2", "a");*/
	FILE* fout = fopen("C:\\Users\\hallo\\aa.o3", "w+b");  // b : 바이너리모드 출력

	if (fin != NULL) // 파일 존재하면 진행
	{
		fscanf(fin, "%d %f %s", &i, &a, buf);
		fprintf(fout,"정수 : %d\n실수 : %f\n문자열 : %s\n", i, a, buf);
		printf("정수 : %d\n실수 : %f\n문자열 : %s\n", i, a, buf);
		//while (1)
		//{
		//	if (fgets(buf, 1024, fin) == NULL) break;
		//	
		//	fputs(buf, stdout);	// 모니터로 출력하도록 stdout을 사용함
		//	
		//	
		//	fputs(buf, fout);
		//}
	}
	else // 그렇지않으면 오류문 출력 후 종료
		printf("입력 파일이 존재하지 않습니다.\n");

}

// 9. sortTestEX()
// structure define 
//     Prototype  :  데이터메모리공간(26비트 : 10 + 4 + 4 + 8)
// 학생 정보 구조체 (이름, 국어성적, 영어성적)
typedef struct {
	char name[10];
	int kor;
	int eng;
	double avg;
} student;
// function define 
//     Prototype  :  swap2(student* a, student* b)
// a와 b의 정보 바꾸기
void swap2(student* a, student* b)
{
	student temp = *a;
	*a = *b;
	*b = temp;
}
// function define 
//     Prototype  :  SortEX(student* S, int n)
// 평균 점수를 기준으로 내림 차순 정렬
int SortEX(student* S, int n)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			//if (S[i].avg < S[j].avg)
			if ((S + i)->avg < (S + j)->avg)
			{
				swap2(S + i, S + j);
			}
		}
	}

	return 0;
}

//const int num = 7;

//student Students[num] = {
//	{"홍길동", 82, 76},
//	{"홍길이", 93, 91},
//	{"홍길삼", 71, 67},
//	{"홍길사", 69, 73},
//	{"홍길오", 78, 86},
//	{"김육", 84, 63},
//	{"김칠", 75, 83} };

//student Students[num];
int num;		// file에서 read
student* Students;	// malloc을 통해서 메모리 확보

int sortTestEX()
{
	FILE* fftable = fopen("C:\\Users\\hallo\\table1.txt", "r");	// table1.txt 파일 포인터 (읽기전용)
	FILE* fftable_w = fopen("C:\\Users\\hallo\\table1.rpt", "w+b");

	fscanf(fftable, "%d", &num);
	Students = (student*)malloc(sizeof(student) * num);		// malloc을 통해서 메모리 확보

	if (fftable != NULL) // 파일 존재하면 진행
	{
		for (int i = 0; i < num; i++)
			fscanf(fftable, "%s", Students[i].name); // name은 배열이므로 &연산 사용 안함
	//		fscanf(fftable, "%s", (S + i)->name);

		for (int i = 0; i < num; i++)
			fscanf(fftable, "%d", &Students[i].kor);

		for (int i = 0; i < num; i++)
			fscanf(fftable, "%d", &Students[i].eng);

		/*for (int i = 0; i < num; i++)
		{
			printf("%s %d %d\n", S[i].name, S[i].kor, S[i].eng);
		}*/
	}
	else // 그렇지않으면 오류문 출력 후 종료
		printf("입력 파일이 존재하지 않습니다.\n");

	fclose(fftable);

	//StreamTest(Student, num);

	// 가중치에 따른 평균 구하기 (국어 0.3, 영어 0.7)
	for (int i = 0; i < num; i++)
		Students[i].avg = Students[i].kor * 0.3 + Students[i].eng * 0.7;

	// 모든 학생들의 이름, 국어, 영어, 평균 점수 출력하기
	printf("Original\n");
	for (int i = 0; i < num; i++)
		printf("%7s %7d %7d %7.2f\n", Students[i].name, Students[i].kor, Students[i].eng, Students[i].avg);
	printf("\n");

	//debugTest(Students);

	// 평균점수를 기준으로 내림차순 정렬
	SortEX(Students, num);


	// 정렬된 정보 출력
	fprintf(fftable_w, "Sorted Grade\n");
	printf("Sorted\n");
	for (int i = 0; i < num; i++)
	{
		fprintf(fftable_w, "%s\t%d\t%d\t%.2f\n", Students[i].name, Students[i].kor, Students[i].eng, Students[i].avg);
		//printf("%7s %7d %7d %7.2f\n", Students[i].name, Students[i].kor, Students[i].eng, Students[i].avg);
		printf("%7s %7d %7d %7.2f\n", (Students + i)->name, (Students + i)->kor, (Students + i)->eng, (Students + i)->avg);
	}
	fclose(fftable_w);

	return 0;
}

#define KBD_BUF_SIZE 20
#define MAX(x,y)	(x>y)?x:y	// x>y true -> x 반환 / false -> y 반환
#define MIN(x,y)	(x<y)?x:y	// 매크로함수 : 데이터 타입에 제한 받지 않음
int StringParse()	// 문자열을 입력받아서 int,  double, 문자열 입력을 수행(scanf 미사용)
{
	while (1)
	{
		int k;
		char b[5];
		printf("\n\n\n === 문자열 변환 테스트 + @===\n"
			"	1. 정수 (int)\n"
			"	2. 실수 (double)\n"
			"	3. 문자열 (공백포함)\n"
			"	4. 매크로 함수 테스트\n"
			" =================== \n"
			"	Select Menu		");
		//fgets(b, 5, stdin);
		scanf("%d", &k);	// 최종 kbd buffer의 [Enter]키 처리 필요
		while (getchar() != '\n');
		//fflush(stdin);		// kbd buffer를 모두 clear 시켜주는 함수, 시스템에 따라 비정상 작동 가능성 있음

		if (k == 0) break;

		if (k == 1)
		{
			char buf[KBD_BUF_SIZE];
			printf("정수를 입력하세요	: ");	// prompt message
			//scanf("%s", buf);
			fgets(buf, KBD_BUF_SIZE, stdin);	// stdin : keyboard
			int n = atoi(buf);
			printf("변환된 정수 값은 %d 입니다\n\n", n);
		}
		else if (k == 2)
		{
			char buf[KBD_BUF_SIZE];
			printf("실수를 입력하세요	: ");	// prompt message
			fgets(buf, KBD_BUF_SIZE, stdin);	// stdin : keyboard until [Enter]
			double d = atof(buf);
			printf("변환된 실수 값은 %f 입니다\n\n", d);
		}
		else if (k == 3)
		{
			char buf[KBD_BUF_SIZE];
			printf("문자열을 입력하세요	: ");	// prompt message
			fgets(buf, KBD_BUF_SIZE, stdin);	// stdin : keyboard until [Enter]
			printf("변환된 문자열은 %s 입니다\n\n", buf);
		}
		else if (k == 4)
		{
			int x, y;
			double dx, dy;
			printf("두 개의 정수를 입력하세요	: ");
			scanf("%d %d", &x, &y);
			printf("두 개의 정수 %d와 %d 중 큰 수 는 %d 입니다.\n", x, y, MAX(x,y));

			printf("두 개의 실수를 입력하세요	: ");
			scanf("%lf %lf", &dx, &dy);
			printf("두 개의 실수 %f와 %f 중 작은 수 는 %f 입니다.\n", dx, dy, MIN(dx, dy));
		}

	}
	return 0;
}


int main()
{
	int k;
	while (1)
	{
		printf("\n\n =================== \n"
			"	 1. score();\n"
			"	 2. Good();\n "
			"	 3. PointerTest();\n"
			"	 4. solution1();\n"
			"	 5. SwapTest();\n"
			"	 6. sortTest();\n"
			"	 7. VoidTest();\n"
			"	 8. StreamTest();\n"
			"	 9. sortTestEX();\n"
			"	10.StringParse();\n"
			"	0. Exit\n\n"
			" =================== "
			"	Select Menu		");

		scanf("%d", &k);

		if (k == 0)	break;

		switch (k)
		{
		case 1:
			score();
			break;
		case 2:
			Good();
			break;
		case 3:
			PointerTest();
			break;
		case 4:
			solution1();
			break;
		case 5:
			SwapTest();
			break;
		case 6:
			sortTest();
			break;
		case 7:
			VoidTest();
			break;
		case 8:
			StreamTest();
			break;
		case 9:
			sortTestEX();
			break;
		case 10:
			StringParse();
			break;
		default:
			return 0;
		}
	}
	//score();
	//Good();
	//PointerTest();
	//solution1();
	//SwapTest();
	//sortTest();
	//VoidTest();
	//StreamTest();

	return 0;
}