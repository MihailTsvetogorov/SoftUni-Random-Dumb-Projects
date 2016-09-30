#include <iostream>
using namespace std;

int main ()
{
	int n, n1, br=0, maxbr=-99999999;
	for (int i=1;;i++)
	{
		cin>>n;
		if (i==1) n1=n;
		if (n==0) break;
		else 
		{
			if (n==n1) br++;
			else
			{
				if (br>maxbr) maxbr=br;
				br=0;
			}
		}
		n1=n;
	}
	cout<<maxbr;
}
