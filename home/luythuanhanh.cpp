#include<iostream>
using namespace std;
main(){
	long a, x, n, r = 1 ;
	cout<<"Nhap a = " ;cin>>a;
	cout<<"Nhap x = " ; cin>>x;
	cout<<"Nhap n = " ; cin>>n;
	while(x>0){
		if(x%2 == 1)
			r = (r*a) % n;
		a = (a*a) % n;
		x = x/2;
	}
	cout << "a^x mod n = "<<r;
	
}
