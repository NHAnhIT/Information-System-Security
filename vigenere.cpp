#include<bits/stdc++.h> 
using namespace std;

string key( string p, string key ){
	int x = p.size();
	for(int i = 0 ; ; i++){
		if(x == i)
			i = 0 ;
		if(key.size() == p.size())
			break;
			key.push_back(key[i]);
	}
	return key;
}

string encryption(string p, string key){
	string encrypt_result;
	char x;
	for( int i=0; i< p.size(); i++){
		x = (p[i] + key[i]) % 26;
		x = x + 'A';
		encrypt_result.push_back(x);
	}
	return encrypt_result;
}

string decryption(string encrypt_result, string key){
	string decrypt_result;
	char x;
	for( int i = 0; i < encrypt_result.size(); i++){
		x = (encrypt_result[i] - key[i] + 26) % 26;
		x = x + 'A';
		decrypt_result.push_back(x);
	}
	return decrypt_result;
}

int main(){
	string plaintext, keyword;
	cout<< "Plaintext, please ! :  ";
	cin>> plaintext;
	cout<< "Keyword, please ! :  ";
	cin>> keyword;
	
	string Key = key(plaintext,keyword);
	string Encryption = encryption(plaintext,Key);
	
	cout<<"Encyption : "<<Encryption << "\n";
	cout<<"Decryption : "<<decryption(Encryption,Key);
	return 0;
}
