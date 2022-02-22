## 1.film tablosunda bulunan replacement_cost s�tununda bulunan birbirinden farkl� de�erleri s�ralay�n�z.

```
SELECT DISTINCT replacement_cost FROM film;
```

## 2.film tablosunda bulunan replacement_cost s�tununda birbirinden farkl� ka� tane veri vard�r?

```
SELECT COUNT(DISTINCT replacement_cost) FROM film;
```

## 3.film tablosunda bulunan film isimlerinde (title) ka� tanesini T karakteri ile ba�lar ve ayn� zamanda rating 'G' ye e�ittir?

```
SELECT COUNT title FROM film WHERE title LIKE 'T%' AND rating = 'G';
```

## 4.country tablosunda bulunan �lke isimlerinden (country) ka� tanesi 5 karakterden olu�maktad�r?

```
SELECT country FROM country WHERE country LIKE '_____';
```

## 5.city tablosundaki �ehir isimlerinin ka� tanesi 'R' veya r karakteri ile biter?

```
SELECT COUNT city_name FROM city WHERE city_name ILIKE '%R';
```