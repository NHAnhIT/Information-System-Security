#include<bits/stdc++.h> 

using namespace std;

string encryption(string p, unsigned int off){
	for(int i = 0; p[i] != 0; i++){
		if( p[i] == ' ')
			continue;
			char fp = islower(p[i]) ? 'a' : 'A';
			unsigned int
				ao = p[i] - fp,
				nao = ao + off;
				p[i] = fp + nao%26;
	}
	return p;
	
}

string decryption(string p, unsigned int off){
	for(int i = 0; p[i] != 0; i++){
		if( p[i] == ' ')
			continue;
			char fp = islower(p[i]) ? 'a' : 'A';
			unsigned int ao = p[i] - fp;
			int nao = ao + off;
			if(nao < 0){
				nao += 26;
			}
			p[i] = fp
			 + (nao % 26);
	}
	return p;
}

int main(){
	string plaintext; unsigned int offset;
	cout<< "Plaintext , please :  ";
	cin>> plaintext;
	cout<<"offset , please  : ";
	cin>>offset; // offset is  Z+
	
	cout<<"Your plantext : "<<plaintext<<"\n";
	
	cout<<"Encyption:  "<<encryption(plaintext,offset)<<"\n";
	cout<<"Decryption:  "<<decryption(encryption(plaintext,offset),offset);
	return 0;
	
}
