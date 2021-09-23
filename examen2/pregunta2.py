# -*- coding: utf-8 -*-
"""
Created on Thu Sep 23 13:03:55 2021

@author: RAUL
"""



from pyswip import Prolog
prolog=Prolog()
prolog.assertz("padre(juan,maria)")
prolog.assertz("padre(pablo,juan)")
prolog.assertz("padre(pablo,marcela)")
prolog.assertz("padre(carlos,debora)")

list(prolog.query("padre(juan,X)")) == [{'X':'maria'}]
list(prolog.query("padre(pablo,X)")) == [{'X':'juan'},{'X':'marcela'}]
list(prolog.query("padre(carlos,X)")) == [{'X':'debora'}]

for elemento in prolog.query("padrede(X,Y)"):
    print(elemento["X"],"es padre de",elemento["Y"])
    
    
