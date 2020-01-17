# money-class

Tenth programming exercise in Chapter Four

Note that IncrementMoney() and DecrementMoney() methods
needed to be refactored to increment and decrement dollars
appropriately when cents greater than 100 are specified.

An alternative approach would be to accept a double as an
argument, instead of two integer arguments, and process
accordingly. (This approach works in the single-argument
constructor, but it did not work on my first try with the
increment and decrement methods, so I used two integers.)

## Example output
```
$ dotnet bin/Debug/netcoreapp2.1/money-class.dll
aMoney: $46.50

aMoney.IncrementMoney(1, 117): $48.67

Dollars: 48
Quarters: 2
Dimes: 1
Nickels: 1
Pennies: 2

aMoney.DecrementMoney(2, 17): $46.50

bMoney: $3.25

bMoney.IncrementMoney(2, 17): $5.42

Dollars: 5
Quarters: 1
Dimes: 1
Nickels: 1
Pennies: 2

bMoney.DecrementMoney(1, 117): $3.25

cMoney: $17.75

cMoney.IncrementMoney(2, 17): $19.92

Dollars: 19
Quarters: 3
Dimes: 1
Nickels: 1
Pennies: 2

cMoney.DecrementMoney(0, 217): $17.75
```
