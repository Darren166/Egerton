Prime Tables
============

How To Run
----------
Runs as a console app.  
Type the size of the grid required and press return. 
0, negative number or non numeric exits.

What I'm Pleased With
---------------------
- The simplicity of the ProductGrid class
- Separation Of Concerns (prime generation is external - however see below)
- ProductGrid class is written in a way that would allow it to be easily converted to a base class with overwriteable header and non header cell setting
- Tests are self explanatory

What I Would Do Given More Time
-------------------------------
- Make the ProductGrid class take an injectable sequencer instead of using a static Primes class
(Tests for main grid would not have to include primes as could pass any sequence into headers)
- Create a grid service that could create grids of different types, not just primes
- Improve the prime generation instead of using a brute force method
- Allow injectable non header cell setting so that you could have non header cells be whatever you wanted.

Overall this took approx two hours but unfortunately I had to step out just after the initial commit to bring in a Waitrose delivery!
