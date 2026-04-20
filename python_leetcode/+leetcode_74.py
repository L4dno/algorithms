from typing import *

def searchMatrix(matrix: List[List[int]], target: int) -> bool:
    h = len(matrix)
    w = len(matrix[0])
    
    l = -1
    r = h*w

    while r > l+1:
        m = (l+r)//2
        i = m//w
        j = m%w
        if matrix[i][j] > target:
            r = m
        else:
            l = m

    i = l//w
    j = l%w
    if l > -1 and matrix[i][j]==target:
        return True
    else:
        return False
    
print(searchMatrix([[1,2,4,8],[10,11,12,13],[14,20,30,40]], 15))