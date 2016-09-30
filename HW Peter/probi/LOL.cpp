#include <iostream>
using namespace std;

int main ()
{
	int n,col=1, row=1;
	cin>>n;
	while (col<=n)
	{
		while (row<=n)
		{
		cout<<"* ";
		row++;
		}
		col++;
		row=1;
		cout<<endl;
	}
}
