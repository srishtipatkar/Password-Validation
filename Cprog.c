#include <stdio.h>
#include <ctype.h>
#include <string.h>
int main() 
{
    int a=0,b=0,c=0,n;
    char password[20], arr[7]={'!', '@', '#', '$', '%', '&', '*'};
    
    scanf("%s",password);
    n=strlen(password);
    for(int i=0;i<n;i++)
    {
        if(isdigit(password[i]))
        {
            a+=1;
        }
        for (int j=0;j<7;j++)
        {
        ;
            if(password[i]==arr[j])
            {
                b+=1;
            }
        }
        c+=1;
    }
    if(a>=2&&b>=2&&c>=7)
    {
        printf ("Strong");
    }
    else
    {
        printf ("Weak");
    }
    return 0;
}
