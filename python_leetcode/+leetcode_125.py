import typing

class Solution:
    def isPalindrome(self, s: str) -> bool:
        l : int = 0
        r : int = len(s) - 1

        for l in range(0, r):
            if not s[l].isalnum():
                continue
            while not s[r].isalnum():
                r -= 1
            if s[l] != s[r]:
                return False
            else:
                r-=1
        return True
