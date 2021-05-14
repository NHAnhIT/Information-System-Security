#include<fstream>
#include<iostream>
#include<stdlib.h>
#include<time.h>
#include<math.h>
using namespace std;

#define PRIVATE_KEY_FILE "privateKey.txt"
#define PUBLIC_KEY_FILE "publicKey.txt"

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
	//srand(time(NULL));
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
 
int encryption(int *a,int *c,int *d, int n, int m){
	int sum = 0;
	for (int i=0 ; i<n ; i++){
		c[i] = (d[i] * a[i]);
		sum = (sum + c[i]) % m;
	}

	return sum;
	
}
int euclid_morong(int w, int m)
        {
            int x, y, z, r, q, bandau = m;
            x = 0; y = 1; z = 0;
 
            while (w > 0)
            {
                r = m % w;
                if (r != 0)
                {
                    q = m / w;
                    z = x - (y * q);
                    m = w;
                    w = r;
                    x = y;
                    y = z;
                }
                else break;
            }
            return (z > 0 ? z  : bandau + z);
        }

int decryption(int *a,int *b,int *c,int *d,int *e, int w, int m, int n ){
	int t1 = 0, t2 = 0;
	t1 = encryption(a,c,d,n,m);
	t2 = ( t1 * euclid_morong(w,m)) % m;
	for(int i=n-1; i>0 ; i--){
		if(e[i] > t1){
			e[i] = 0;
		}
		else{
			e[i] = 1;
			t2 -= e[i];
		}
	}
	return 0;
	
}

int main() {
	int n, m , w, sum;
	int *a, *b, *c, *d, *e;
	cout<<"Nhap n = ";
	cin>>n;
	a = new int[n]; // cap phat dong
	b = new int[n];
	c = new int[n];
	d = new int[n];
	e = new int[n];
	for(int i=0 ; i<n ; i++){
		cout<<"M["<<i<<"] = ";
		cin>>d[i];
		
	}
	createKey(a,b,n,m,w);
	writeFile(a,b,n,m,w);
	decryption(a,b,c,d,e,w,m,n);
	
	cout << " Private Key : " <<endl;
	for ( int i = 0 ; i < n ; i++ ) {
		cout << a[i]<< "\t";
	}
	cout<<endl;
	cout<< endl << "m = " << m << endl << "w = " << w << endl ;
	
	cout<< "Encryption : T = " <<encryption(a,c,d,n,m)<<endl;
	
	cout<<"w^-1 = "<<euclid_morong(w, m)<<endl;
	
	cout<<"Decryption : ";
	for ( int i = 1 ; i < n ; i++ ) {
		cout<<e[i];
	}
	cout <<endl;
	
	system("pause");
	return 0;
}
