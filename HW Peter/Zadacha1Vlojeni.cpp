#include <iostream>
using namespace std;

int main()
{
	int n, max,n1, br=0;
	for (int i=1;;i++)
	{
		cin>>n;
		if (n==0) break;
		else
		{
			if (i==1) n1=n;
			else
			{
				if (n==n1) br++;
				else
				{
					max=br;
					br=0;
				}
				n1=n;
			}
		}
	}
	cout<<max;	
}
