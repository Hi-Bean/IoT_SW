#include <iostream>
#include <stdio.h>
#include <cstring>
#include "MyGradeHeader.h"
using namespace std;

int main()
{
	string fname;
	fname = "table1.txt";


	int num;
	FILE* ftable = fopen(fname.c_str(), "r");			// 성적파일
	FILE* ftable_p = fopen("table1_p.txt", "r");		// 인적사항 파일
	FILE* ftable_w = fopen("table_gradeTest.rpt", "w+b");
	
	fscanf(ftable, "%d", &num);
	Student* STU = new Student[num];

	// char name[50];
	//fgets(name, 250, ftable);	// 첫 줄 무시 ==> file read pointer를 다음 줄로 이동

	// 인적사항 입력
	if (ftable_p != NULL)
	{
		for (int i = 0; i < num; i++)
		{
			char temp_name[50];
			fscanf(ftable_p, "%s", temp_name);
			STU[i].setName(temp_name);
		}
		for (int i = 0; i < num; i++)
		{
			int a;
			fscanf(ftable_p, "%d", &a);
			STU[i].setAge(a);
		}
	}
	fclose(ftable_p);

	// 성적 입력
	if (ftable != NULL)
	{
		for (int i = 0; i < num; i++)
		{
			char temp_name[50];
			fscanf(ftable, "%s", temp_name);
			if (strcmp(STU[i].getName(), temp_name) != 0) // 이름이 다르다면
			{
				cout << "이름 불일치 오류" << endl;
				return 0;
			}
		}

		for (int i = 0; i < num; i++)
		{
			int k;
			fscanf(ftable, "%d", &k);
			STU[i].setKor(k);
		}
			
		for (int i = 0; i < num; i++)
		{
			int e;
			fscanf(ftable, "%d", &e);
			STU[i].setEng(e);

		}

		/*for (int i = 0; i < num; i++)
		{
			printf("%s %d %d\n", STU[i].name, STU[i].kor, STU[i].eng);
		}*/
	}
	else // 그렇지않으면 오류문 출력 후 종료
		printf("입력 파일이 존재하지 않습니다.\n");

	fclose(ftable);

	// 각 학생별 평균 점수 계산 (클래스의 멤버함수)
	for (int i = 0; i < num; i++)
		STU[i].setAvg();

	printf("Original\n");
	for (int i = 0; i < num; i++)
		printf("%7s %7d %7d %7.2f\n", STU[i].getName(), STU[i].getKor(), STU[i].getEng(), STU[i].getAvg());
	printf("\n");
	
	// 평균 점수에 따른 내림차순 정렬
	sortEX(STU, num);


	// 정렬 정보 출력
	fprintf(ftable_w, "Sorted Grade\n");
	fprintf(ftable_w, "이름\t나이\t국어\t영어\t합계\t평균\n");
	printf("Sorted\n");
	for (int i = 0; i < num; i++)
	{
		fprintf(ftable_w, "%s\t%d\t%d\t%d\t%d\t%.2f\n", STU[i].getName(), STU[i].getAge(), STU[i].getKor(), STU[i].getEng(), STU[i].getTot(),STU[i].getAvg());
		printf("%7s %7d %7d %7.2f\n", (STU + i)->getName(), (STU + i)->getKor(), (STU + i)->getEng(), (STU + i)->getAvg());
	}
	fclose(ftable_w);

	return 0;
}