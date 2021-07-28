#include <assert.h>
#include <limits.h>
#include <math.h>
#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    float totalcost=0;
    float mealcost,tip,tax;
    scanf("%f%f%f",&mealcost,&tip,&tax);
    tip=tip*mealcost/100;
    tax=tax*mealcost/100;
    totalcost=mealcost+tip+tax;
    printf("The total meal cost is %d dollars.", (int)round(totalcost));
    return 0;
}