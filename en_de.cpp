#include<iostream>
#include<string>
#include<cstdlib>
#include<conio>
#define SIZE 100
using namespace std;
int encryption(char source[], char encrypt[], int length, int key)
{
    for (int i=0; i<length; i++)
    {
        char c=encrypt[i];
        if (c >= 'A' && c <= 'Z')
        {
            encrypt[i] = (source[i] - 'A' + key) % 26 + 'A';
        }
        else if (c >= 'a' && c <= 'z')
        {
            encrypt[i] = (source[i] - 'a' + key) % 26 + 'a';
        }
        else 
            encrypt[i] = source[i];
    }
    return 0;
}

int init(char str[])
{
    for (int i=0; i<SIZE; i++)
        str[i] = 0;
    return 0;
}

int decryption(char source[], char decrypt[], int length, int key)
{
    
    for (int i=0; i<length; i++)
    {
        char c = source[i];
        if (c >= 'A' && c <= 'Z')
        {
            decrypt[i] = abs((source[i] - 'A' - key))% 26 + 'A';
        }
        else if (c >= 'a' && c <= 'z')
        {
            decrypt[i] = abs((source[i] - 'a' - key))% 26 + 'a';
        }
        else   
            decrypt[i] = source[i];
    }
    return 0;
}

int main()
{
    char str[SIZE], encryption[SIZE], decryption[SIZE];
    int length, key, n;
    cout<< "string ?"; cin>>str;
    cout<<"key ?"; cin>>key;
    length = strlen(str);
    init(encryption);
    init(decryption);
    encryption(str, encrypt, length, key);
    decryption(str, decrypt, length, key);
    cout<<"1 : Encryption    ||     2 : Decryption "; cin>>n;
    switch(n)
    {
    	case 1:
    		cout<<str<<" has been encrypted " <<encrypt;
    		break;
    	case 2:
    		cout<<str<<" has been decrypted " <<decrypt;
    		break;
    	default:
    		cout<<"Again please ^^";
	}   
}
