#include <iostream>
using namespace std;

int main()
{
	int  a=1, c, A, B, b=1;
	cin>>A>>B;
	while (2+2==4)
	{
		c=a+b;
		a=b;
		b=c;
		if (c>=A&&c<=B)cout<<c<<" ";
		else if (c>B)break;
	}
}
/* C# 
using System;
namespace Upr
{
	class Zadacha3
	{
		public static void Main()
		{
			int c;
			int A=int.Parse (Console.ReadLine());
			int B=int.Parse (Console.ReadLine());
			int b;
			while (true==true)
			{
				c=A+b;
				A=b;
				b=c;
				if (c<=B) Console.Write (c+ " ");
				else if (c>B) break;
			}
		}
	}
}*/
