#include <iostream>
#include<ctype.h>
#include<string.h>
using namespace std;
class val
{
    private :
        int a,b,c,n;
        char x[7]={'!', '@', '#', '$', '%', '&', '*'},p[20];
    public :
        void valid(char p[],int n);
};
void val::valid (char p[],int n)
{
    a=b=c=0;
    for(int i=0;i<n;i++)
    {
        if(isdigit(p[i]))
        {
            a+=1;
        }
        for (int j=0;j<7;j++)
        {
        
            if(p[i]==x[j])
            {
                b+=1;
            }
        }
        c+=1;
    }
    if(a>=2&&b>=2&&c>=7)
    {
        cout<<"Strong";
    }
    else
    {
        cout<<"Weak";
    }
}
int main() 
{
    char password[20];
    int k;
    val V;
    cin>>password;
    k=strlen(password);
    V.valid(password,k);
    return 0;
}
