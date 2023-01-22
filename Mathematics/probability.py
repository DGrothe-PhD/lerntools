#!/usr/bin/python

def divisors(x):
    tset = set()
    for t in range(1, x+1):
        if x%t == 0:
            tset.add(t)
    return tset