#include<bits/stdc++.h> 
using namespace std;

string key(string p, string encrypt, int m){
	string key_result;
	char x;
	for( int i=0; i< m; i++){
		x = (encrypt[i] - p[i]) % 26;
		//x = x + 'A';
		if(x < 0){
			x = x + 26;
		}
		x = x + 'A';	
		
		key_result.push_back(x);
	}
	
	return key_result;
}



int main(){
	string plaintext, encrypt ;
	int length;
	cout<< "Plaintext, please ! :  ";
	cin>> plaintext;
	cout<< "Encrypt, please ! :  ";
	cin>> encrypt;
	cout<< "Length, please ! : ";
	cin>> length;
	
	string Key = key(plaintext,encrypt,length);
	
	
	cout<<"Keyword : "<<Key << "\n";
	
	return 0;
}
