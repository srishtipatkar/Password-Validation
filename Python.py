password=input()
a=0
b=0
c=0
ch=['!', '@', '#', '$', '%', '&', '*']
for p in password :
    if p.isnumeric():
        a+=1
    if p in ch:
        b+=1
    c+=1
if a>=2 and b>=2 and c>=7:
    print ("Strong")
else :
    print ("Weak")
