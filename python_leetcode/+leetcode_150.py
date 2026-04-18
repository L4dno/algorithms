from typing import *

def evalRPN(tokens: List[str]) -> int:
    stack : List[int] = []
    for token in tokens:
        if token not in ['-', '+', '/', '*']:
            stack.append(int(token))
        else:
            r = stack.pop()
            l = stack.pop()
            if token == '-':
                stack.append(l-r)
            elif token == '+':
                stack.append(l+r)
            elif token == '/':
                stack.append(int(l/r))
            elif token=='*':
                stack.append(l*r)
    return stack.pop()
    
tokens=["4","13","5","/","+"]
print(evalRPN(tokens))