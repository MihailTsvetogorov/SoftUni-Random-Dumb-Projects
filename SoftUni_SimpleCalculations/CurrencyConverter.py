amount = float(input())
CurrencyFrom = str(input())
CurrencyTo = str(input())
CurrencyFrom.capitalize()
CurrencyTo.capitalize()
USDtoBGN = amount*1.79549
EURtoBGN = amount*1.95583
GBPtoBGN = amount*2.53405
if CurrencyFrom == 'BGN':
    if CurrencyTo == 'USD':
        print(round(amount/1.79549, 2))
    elif CurrencyTo == 'EUR':
        print(round(amount/1.95583, 2))
    elif CurrencyTo == 'GBP':
        print(round(amount/2.53405, 2))
elif CurrencyFrom == 'USD':
    if CurrencyTo == 'BGN':
        print(round(USDtoBGN, 2))
    elif CurrencyTo == 'EUR':
        print(round(USDtoBGN/1.95583, 2))
    elif CurrencyTo == 'GBP':
        print(round(USDtoBGN/2.53405, 2))
elif CurrencyFrom == 'EUR':
    if CurrencyTo == 'USD':
        print(round(EURtoBGN/1.79549, 2))
    elif CurrencyTo == 'BGN':
        print(round(EURtoBGN, 2))
    elif CurrencyTo == 'GBP':
        print(round(EURtoBGN/2.53405, 2))
elif CurrencyFrom == 'GBP':
    if CurrencyTo == 'USD':
        print(round(GBPtoBGN/1.79549, 2))
    elif CurrencyTo == 'EUR':
        print(round(GBPtoBGN/1.95583, 2))
    elif CurrencyTo == 'BGN':
        print(round(GBPtoBGN, 2))