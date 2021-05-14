#include<iostream>
using namespace std;

int main(){
	
	int a, b, d, e;
	float c;
	do{
	
		cout<< "a = "; 
		cin>>a;
		cout<< "b = ";
		cin>>b;
		
		if( a >= 0){
		c = a % b;
		}else {
		e = a % b;
		c = b + e;
		}
		cout<< a << " mod " << b << " = " << c <<"\n";
		cout<< "Stop => d = 0 --- Continue => d != 0 \n";
		cout<< "d = ";
		cin>>d;
		cout<<"---------------------------------------------------***---------------------------------------------- \n";
	}while(d != 0);	
	
	//cout<< a << " mod " << b << " = " << c ;

}
