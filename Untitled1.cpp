#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<conio.h>
#define SIZE 100
int mahoa(char str_nguon[], char str_mahoa[], int len, int key)
{
    for (int i=0; i<len; i++)
    {
        char c=str_nguon[i];
        if (c >= 'A' && c <= 'Z')
        {
            str_mahoa[i] = (str_nguon[i] - 'A' + key) % 26 + 'A';
        }
        else if (c >= 'a' && c <= 'z')
        {
            str_mahoa[i] = (str_nguon[i] - 'a' + key) % 26 + 'a';
        }
        else 
            str_mahoa[i] = str_nguon[i];
    }
    return 0;
}

int khoitao(char str[])
{
    for (int i=0; i<SIZE; i++)
        str[i] = 0;
    return 0;
}

int giaima(char str_nguon[], char str_giaima[], int len, int key)
{
    
    for (int i=0; i<len; i++)
    {
        char c = str_nguon[i];
        if (c >= 'A' && c <= 'Z')
        {
            str_giaima[i] = abs((str_nguon[i] - 'A' - key))% 26 + 'A';
        }
        else if (c >= 'a' && c <= 'z')
        {
            str_giaima[i] = abs((str_nguon[i] - 'a' - key))% 26 + 'a';
        }
        else   
            str_giaima[i] = str_nguon[i];
    }
    return 0;
}

int main()
{
    char str[SIZE], str_mahoa[SIZE], str_giaima[SIZE];
    int len, key, n;
    printf("Nhap chuoi: ");
    scanf("%s", str);
    printf("Nhap so buoc nhay: ");
    scanf("%d", &key);
    len = strlen(str);
    khoitao(str_mahoa);
    khoitao(str_giaima);
    mahoa(str, str_mahoa, len, key);
    giaima(str, str_giaima, len, key);
    printf("Chon 1 de ma hoa/ Chon 2 de giai ma => ");
    scanf("%d", &n);
    switch(n)
    {
    	case 1:
    		printf("Chuoi %s da duoc ma hoa thanh ---> %s \n", str, str_mahoa);
    		break;
    	case 2:
    		printf("Chuoi %s da duoc giai ma thanh ---> %s \n", str, str_giaima);
    		break;
    	default:
    		printf("Ban da nhap sai lua chon !!!");
	}   
}
