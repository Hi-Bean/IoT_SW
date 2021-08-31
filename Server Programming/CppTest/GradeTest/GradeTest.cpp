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
	FILE* ftable = fopen(fname.c_str(), "r");			// ��������
	FILE* ftable_p = fopen("table1_p.txt", "r");		// �������� ����
	FILE* ftable_w = fopen("table_gradeTest.rpt", "w+b");
	
	fscanf(ftable, "%d", &num);
	Student* STU = new Student[num];

	// char name[50];
	//fgets(name, 250, ftable);	// ù �� ���� ==> file read pointer�� ���� �ٷ� �̵�

	// �������� �Է�
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

	// ���� �Է�
	if (ftable != NULL)
	{
		for (int i = 0; i < num; i++)
		{
			char temp_name[50];
			fscanf(ftable, "%s", temp_name);
			if (strcmp(STU[i].getName(), temp_name) != 0) // �̸��� �ٸ��ٸ�
			{
				cout << "�̸� ����ġ ����" << endl;
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
	else // �׷��������� ������ ��� �� ����
		printf("�Է� ������ �������� �ʽ��ϴ�.\n");

	fclose(ftable);

	// �� �л��� ��� ���� ��� (Ŭ������ ����Լ�)
	for (int i = 0; i < num; i++)
		STU[i].setAvg();

	printf("Original\n");
	for (int i = 0; i < num; i++)
		printf("%7s %7d %7d %7.2f\n", STU[i].getName(), STU[i].getKor(), STU[i].getEng(), STU[i].getAvg());
	printf("\n");
	
	// ��� ������ ���� �������� ����
	sortEX(STU, num);


	// ���� ���� ���
	fprintf(ftable_w, "Sorted Grade\n");
	fprintf(ftable_w, "�̸�\t����\t����\t����\t�հ�\t���\n");
	printf("Sorted\n");
	for (int i = 0; i < num; i++)
	{
		fprintf(ftable_w, "%s\t%d\t%d\t%d\t%d\t%.2f\n", STU[i].getName(), STU[i].getAge(), STU[i].getKor(), STU[i].getEng(), STU[i].getTot(),STU[i].getAvg());
		printf("%7s %7d %7d %7.2f\n", (STU + i)->getName(), (STU + i)->getKor(), (STU + i)->getEng(), (STU + i)->getAvg());
	}
	fclose(ftable_w);

	return 0;
}