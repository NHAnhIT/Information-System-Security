// xu ly viet chu IN HOA
#include<iostream>
#include<string.h>
#include<stdlib.h>
using namespace std;
string encryption(string p)
{
    string CT = "";
    int a = 5;
    int b = 6;
    for (int i = 0; i < p.length(); i++)
    {
        CT = CT + (char) ((((a * p[i] -65) + b) % 26) + 65);
        
    }
    return CT;
}
 
 int euclid_morong(int a, int m)
        {
            int x, y, z, r, q, bandau = m;
            x = 0; y = 1; z = 0;
 
            while (a > 0)
            {
                r = m % a;
                if (r != 0)
                {
                    q = m / a;
                    z = x - (y * q);
                    m = a;
                    a = r;
                    x = y;
                    y = z;
                }
                else break;
            }
            return (z > 0 ? z  : bandau + z);
        }
        
string decryption(string CT)
{
    string p = "";
    int a = 5;
    int b = 6;
    
    for (int i = 0; i < CT.length(); i++)
    {
        p = p + (char) (((euclid_morong(a,26) * ((char)CT[i] - 65 - b +
		208)) % 26) + 65);
    }
    return p;
}
int main()
{
    cout << "PlainText: ";
    string message;
    cin >> message;
    cout << "PlainText is :" << message;
    cout << "\nEncrypted PlainText is : " << encryption(message);
 
    cout << "\nDecrypted PlainText is: " << decryption(
            encryption(message));
}
