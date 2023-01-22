#!/usr/bin/python

from fractions import Fraction
def F(val,limit_denom=1000):
    s = str(Fraction(val).limit_denominator(limit_denom))
    t= s.replace(", ","/").strip("Fraction()")
    return t

F('120/300')