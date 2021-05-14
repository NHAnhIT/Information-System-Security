#include<fstream>
#include<iostream>
#include<stdlib.h>
#include<time.h>
#include<math.h>
using namespace std;

#define PRIVATE_KEY_FILE "privateKey1.txt"
#define PUBLIC_KEY_FILE "publicKey1.txt"

// so nguyen to
bool isPrime(int p) {
	for (int i=2 ; i <= sqrt(p) ; i++)
		if (p%i == 0)
			return 0;
	return 1;
}

// Ghi File
int writeFile(int* a,int* b, int n, int m, int w) {
	ofstream f(PRIVATE_KEY_FILE);
	f << m << endl << w << endl;
	for (int i=0 ; i<n ; i++) {
		f << a[i] <<"\t";
	}
	f.close();

	f.open(PUBLIC_KEY_FILE);
	for (int i=0 ; i<n ; i++) {
		f << b[i] << endl;
	}
	return 0;
}

// tao vecto sieu tang
int createKey(int* a, int* b, int n, int& m, int& w) {
	// private key
	int t;
	srand(time(NULL));
	for ( int i = 0 ; i < n ; i++ ) {
		a[i] = rand() % 20 + 1 + t; //creat N* % 20 +1  < 20 => a = (1,2) ---- t = tong => = >20
		t += a[i];
	}

	++t;
	while (true) {
		++t;
		if (isPrime(t))
			break;
		++t;
	}
	m = t;

	w = rand() % m +1;

	// public key
	for (int i = 0; i<n ; i++) {
		b[i] = (w * a[i] ) % m;
	}

	return 0;
}
 


int main() {
	int n, m , w;
	int *a, *b;
	cout<<"Nhap n = ";
	cin>>n;
	a = new int[n]; // cap phat dong
	b = new int[n];


	createKey(a,b,n,m,w);
	writeFile(a,b,n,m,w);
	
	cout << " Private Key : " <<endl;
	for ( int i = 0 ; i < n ; i++ ) {
		cout << a[i]<< "\t";
	}
	cout<<endl;
	cout<< endl << "m = " << m << endl << "w = " << w << endl ;
	


	system("pause");
	return 0;
}
