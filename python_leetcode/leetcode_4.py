from typing import *

def findMedianSortedArrays(nums1: List[int], nums2: List[int]) -> float:
    l : int = min(nums1[0], nums2[0])
    r : int = max(nums1[-1], nums2[-1])

    while (r-l > 1):
        m = (l+r)/2

    return 2

print(findMedianSortedArrays([1,3],[2,4]))