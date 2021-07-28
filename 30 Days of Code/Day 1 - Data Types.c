#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main()
{
    int i = 4;
    double d = 4.0;
    char s[] = "HackerRank ";
    int i1;
    double d1;
    char s1[100];
    scanf("%d", &i1);
    scanf("%lf", &d1);
    scanf("%*[\n] %[^\n]",s1);
    printf("%d\n", i + i1);
    printf("%.01lf\n", d + d1);
    printf("%s%s", s, s1);
    return 0;
}