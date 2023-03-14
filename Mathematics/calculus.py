#!/usr/bin/python
import primefac
from fractions import Fraction

# Sum of digits
def SumOfDigits(i):
    t=str(i)
    summe = 0
    for j in range(0,len(t)):
        summe += int(t[j])
    return summe

# Returns all divisors of a number.
def divisors(x):
    tset = set()
    for t in range(1, x+1):
        if x%t == 0:
            tset.add(t)
    return tset

# Common divisors of two numbers
divisors(24) & divisors(18)

# Returns all prime factors of a number.
list(primefac.primefac(250))

# Calculus with fractions
def F(val,limit_denom=1000):
    s = str(Fraction(val).limit_denominator(limit_denom))
    t= s.replace(", ","/").strip("Fraction()")
    return t

F('120/300')