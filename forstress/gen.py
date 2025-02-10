import random

t = random.randint(1, 6)
print(t)

for i in range(t):
    a,b = [random.randint(-9, 10) for _ in range(2)]
    print (a,b)
