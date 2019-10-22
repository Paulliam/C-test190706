
#include <stdio.h>
#include <stdlib.h>
#include "md5.h"
 
int main(int argc, char *argv[])
{
	int i;
	//unsigned char encrypt[] ="admin";//'a','d'//21232f297a57a5a743894a0e4a801fc3 "02180821"
	unsigned char encrypt[] = { 0x19, 0x06, 0x21, 0x14, 0x04, 0x05 };
	unsigned char decrypt[16];    
	MD5_CTX md5;  //MD5_CTX *md5=(MD5_CTX *)malloc(sizeof(MD5_CTX ));
	MD5Init(&md5);         		
	//MD5Update(&md5,encrypt,strlen((char *)encrypt));
	MD5Update(&md5, encrypt, sizeof(encrypt));
	MD5Final(&md5,decrypt);        
	printf("encrypt before£º%s\nencrypt after£º ",encrypt);
	for(i=0;i<16;i++)
	{
		printf("%02X",decrypt[i]);
	}
	
	getchar();
	
	return 0;
}
