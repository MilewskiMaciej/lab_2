import sys

liczba = input('Wprowadz liczbe: ')
print(liczba)

sys.stdout.write('Wprowadz liczbe: ')
liczba = sys.stdin.readline()
liczba = int(liczba)
print(liczba + 'to wczytana liczba')

print("Kys Mr Milewski")