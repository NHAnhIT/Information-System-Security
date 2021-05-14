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

   main() {
        int a,b;
        cout<<"nhap a = "; cin>>a;
        cout<<"nhap b = "; cin>>b;
       
        int r = nghichdao(a, b);
        if (r == 0) {
           cout<<"khong tim thay phan tu nghich dao tren vanh Zn";
        } else {
            if (r < 0) {
                while (r < 0) 
                    r = r + b;
                cout<<"phan tu nghich dao tren Zn la : "<<r;
            } else
                cout<<"phan tu nghich dao tren Zn la : "<<r;
        }

    }
