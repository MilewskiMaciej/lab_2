"""
import sys

def zad1():
    fraza = input('Wprowadz wyrazenie: ')
    licznik = 0
    licz = fraza.split()
    for i in licz:
        licznik += 1
    print('Ilosc slow:', licznik)

def zad2():
    sys.stdout.write('Wprowadz pierwsza liczbe: ')
    pierwsza = sys.stdin.readline()
    pierwsza = int(pierwsza)
    sys.stdout.write('Wprowadz druga liczbe: ')
    druga = sys.stdin.readline()
    sys.stdout.write('Wprowadz trzecia liczbe: ')
    trzecia = sys.stdin.readline()
    trzecia = int(trzecia)
    print((pierwsza**druga)+trzecia)

def zad3():
    slowo = input('Wprowadz slowo: ')
    pal = list(slowo)
    sprawdz = pal[::-1]
    if pal == sprawdz:
        print('Podane slowo jest palindromem')
    else:
        print('Podane slowo nie jest palindromem')

def zad4():
    li_pierw = int(input('Podaj liczbe: '))
    if li_pierw == 1 or li_pierw == 0:
        print('Nie jest to liczba pierwsza')
    else:
        for m in range(2, li_pierw):
            if li_pierw % m == 0:
                print('Nie jest to liczba pierwsza')
                break
            else:
                print('Jest to liczba pierwsza')
                break

def zad5():
    lim = 1000
    dz = []
    for o in range(2, lim + 1):
        suma = 0
        for p in range(1, o):
            if o % p == 0:
                suma += p
        if suma == o:
            dz.append(o)
    print(dz)

def zad6():
    li_cal = []
    c = int(input('Podaj ilosc liczb calkowitych: '))
    for l in range(c):
        licz_cal = float(input('Podaj liczbe calkowita: '))
        li_cal.append(licz_cal**2)
    print(li_cal)

def zad7():
    dz_liczby = []
    licznik = 0
    while licznik < 10:
        dz_licz = int(input('Podaj liczbe: '))
        if dz_licz % 2 == 0:
            dz_liczby.append(dz_licz)
        licznik += 1
    print(dz_liczby)

def main():
    zad1()
    zad2()
    zad3()
    zad4()
    zad5()
    zad6()
    zad7()
main()
"""
