# This program displays a rectangular pattern
# of asterisks.
rows = int(input('How many row?'))
cols = int(input('How many columns?'))

for r in range(rows):
    for c in range(cols):
        print('*', end='')
    print()