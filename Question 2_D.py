"""
Author: Jimmy Arnott
Date: 06/07/2016
Purpose:
"""

Amount = int(input("Please enter the amount"))
Years = int(input("Please enter the number of years"))
Interest = 0
Value_For_year = 0

print("")
print("Year | ","Start | ","Paid in | ","Interest | ","Final  ")

#Year_1
Interest = Amount * 0.1
Value_For_Year = Amount + Interest
print("1    | "+" 0.00  |  "+str(Amount)+"     |"+"   "+str(Interest)+"    |"+"   "+str(Value_For_Year))

#Year_2
print("2    | "+" 110.0 |  "+str(Amount)+"     |"+"   "+str(Interest)+"    |"+"   "+str(Value_For_Year))


#Year_3
print("3    | "+" 110.0 |  "+str(Amount)+"     |"+"   "+str(Interest)+"    |"+"   "+str(Value_For_Year))


#Year_4
print("4    | "+" 110.0 |  "+str(Amount)+"     |"+"   "+str(Interest)+"    |"+"   "+str(Value_For_Year))


#Year_5
print("5    | "+" 110.0 |  "+str(Amount)+"     |"+"   "+str(Interest)+"    |"+"   "+str(Value_For_Year))
