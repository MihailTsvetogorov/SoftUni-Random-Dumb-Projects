#include <iostream>
using namespace std;

int main()
{
	int a,sum=0,ch;
	cin>>a;
	while (a!=0)
	{
		ch=a%10;
		a=a/10;
		sum=sum+ch;
	}
	cout<<"Sum ="<<sum;
}
/* C# 
using System;
namespace Upr
{
	class Zadacha2
	{
		public static void Main()
		{
			int sum=0;
			int ch;
			int a=int.Parse(Console.ReadLine());
			while (a!=0)
			{
				ch=a%10;
				a=a/10;
				sum=sum+ch;
			}
			Console.Write ("Sum = " + sum);
		}
	}
}*/
					
