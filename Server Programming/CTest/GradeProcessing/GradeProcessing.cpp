#include <stdio.h>
#include <corecrt_malloc.h>
// student 구조체를 이용하여 사용자 정의 자료형을 선언하고
// 10명의 학생에 대한 데이터를 입력한 후 정렬하여 출력하시오.
 
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
//     Prototype  :  swap(student* a, student* b)
// a와 b의 정보 바꾸기
void swap(student* a, student* b)
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
				swap(S + i, S + j);
			}
		}
	}

	return 0;
}

// function define 
//     Prototype  :  debugTest(student S[])
// student 변수끼리 swap해도 구조체의 모든 멤버가 바뀌는 것을 확인
void debugTest(student S[])
{
	printf("\n--debugging Test--\n Befor swap >>\n");
	student A = S[1];
	printf("% 7s % 7d % 7d % 7.2f\n", A.name, A.kor, A.eng, A.avg);
	student B = S[2];
	printf("% 7s % 7d % 7d % 7.2f\n", B.name, B.kor, B.eng, B.avg);
	
	//swap 과정
	student temp = A;
	A = B;
	B = temp;

	// swap 확인
	printf(" After swap >>\n");
	printf("% 7s % 7d % 7d % 7.2f\n", A.name, A.kor, A.eng, A.avg);
	printf("% 7s % 7d % 7d % 7.2f\n\n\n", B.name, B.kor, B.eng, B.avg);
}


// function define 
//     Prototype  :  StreamTest(student* S, int num)
// 텍스트파일의 정보를 읽어와 student 구조체에 저장하는 함수
int StreamTest(student* S, int num)
{
	// table1.txt 파일 포인터
	FILE* fftable = fopen("C:\\Users\\hallo\\table1.txt", "r");

	if (fftable != NULL) // 파일 존재하면 진행
	{
		for (int i = 0; i < num; i++)
			fscanf(fftable, "%s", S[i].name); // name은 배열이므로 &연산 사용 안함
	//		fscanf(fftable, "%s", (S + i)->name);

		for (int i = 0; i < num; i++)
			fscanf(fftable, "%d", &S[i].kor);

		for (int i = 0; i < num; i++)
			fscanf(fftable, "%d", &S[i].eng);

		/*for (int i = 0; i < num; i++)
		{
			printf("%s %d %d\n", S[i].name, S[i].kor, S[i].eng);
		}*/
	}
	else // 그렇지않으면 오류문 출력 후 종료
		printf("입력 파일이 존재하지 않습니다.\n");

	fclose(fftable);

	return 0;
}


int main()
{
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
	// table1.txt 파일로 부터 정보 읽어오기
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