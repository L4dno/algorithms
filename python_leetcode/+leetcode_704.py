def search(nums, target) -> int:
    l = -1
    r = len(nums)

    while r>l+1:
        m = (l+r)//2
        if nums[m] > target:
            r = m
        else:
            l = m
    if l > -1 and nums[l]==target:
        return l
    else:
        return -1
    
print(search([-1,0,2,4,6,8], 3))
