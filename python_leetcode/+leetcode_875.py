from typing import *

def good(piles, h, m):
    cur_h = 0
    for pile in piles:
        cur_h += (pile + m - 1) // m
    print(cur_h)
    return cur_h <= h

def minEatingSpeed(piles: List[int], h: int) -> int:
    piles.sort()

    l = 0
    r = 10**10

    for i in range(100):
        m = (l+r)//2
        if good(piles, h, m):
            r=m
        else:
            l=m
    return r

print(minEatingSpeed([25,10,23,4], 4))