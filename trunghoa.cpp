#include<iostream>
using namespace std;

int nghichdao(int a, int b) {

        int x = 0, y = 0;
        int x2 = 1, x1 = 0, y2 = 0, y1 = 1;
        if (b == 0) {
            int d = a;
            x = 1;
            y = 0;
            return 0;
        }
        while (b > 0) {
            int q = a / b;
            int r = a - q * b;
            x = x2 - q * x1;
            y = y2 - q * y1;
            a = b;
            b = r;
            x2 = x1;
            x1 = x;
            y2 = y1;
            y1 = y;
        }
        int d = a;
        x = x2;
        y = y2;

        if (d > 1) 
            return 0;
        else {
            return x; 
        }

    }
int main(){
	int a1, a2, a3, m1 , m2 , m3, n, n1, n2, n3, y1, y2, y3;
	cout<<"nhap a1 = "; cin>>a1;
	cout<<"nhap a2 = "; cin>>a2;
	cout<<"nhap a3 = "; cin>>a3;
	cout<<"nhap m1 = "; cin>>m1;
	cout<<"nhap m2 = "; cin>>m2;
	cout<<"nhap m3 = "; cin>>m3;
	
	n = m1 * m2 * m3;
	n1 = n / m1;
	n2 = n / m2;
	n3 = n / m3;
	
	y1 = nghichdao(n1, m1);

	y2 = nghichdao(n2, m2);

	y3 = nghichdao(n3, m3);

	
	int x = a1*n1*y1 + a2*n2*y2 + a3 *n3*y3;
	
	cout<<"x = "<<x <<"+"<< n <<"k";
	
	
}
