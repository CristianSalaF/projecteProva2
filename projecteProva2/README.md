## Exercici 1

### num = 3
retorna 3 ja que busca els mòduls del nombre entre 10

### num = 11
- farà dos cicles al while el primer assignarà 1 al total (0+1) i el nombre pasarà a ser el resultat de dividir (11/10 = 1)
- el segon cicle, tindrà un 1 al num: la divisió donarà 0, el mòdul donarà 1. Per tant el total serà 1+1 = 2
- el num passarà a ser 0 i sortirà del loop, tornant a repetir RecMethod(total), i retornarà un 2


La funcionalitat diria que es trobar quantes vegades es pot multiplicar un nombre entre 10 i retornar-ho com a valor int.

## Exercici 2

### a
He escollit SearchClass.BinarySearch perquè cerca i retorna la posició, com demana el enunciat.

### b
He escollit FirstSort.Order perquè ordena de menor a major

## Exercici 4
> CMP -> 00 MOV-> 01 ADD -> 10  BEQ -> 11
> Hex to bin by 4-bits: 
> 8 4 2 1
> (ho faig directe, transformant de cap el valor hex a decimal i d'allà a binari amb la "taula" de la linia a sobre)


- CMP 3F, 45
00 00111111, 01000101

- MOV AE, 94
01 10101110, 10010100


- ADD 11, A3
10 00010001, 10100011

- MOV 8A, 77
01 10001010, 01110111