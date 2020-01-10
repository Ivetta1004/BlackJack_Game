# BlackJack_Game
My first game
###### A console application for the card game “21” with simple rules  

1. game has 36 cards;
1. cost of cards in points: 
  Ace - 11 points,
  King - 4 points,
  Lady - 3 points,
  Jack - 2 points,
  The other cards at their value;
1. 2 players (you and computer);
1. the goal of the game is to collect 21 points;
1. at first you should enter who receives first cards. You and computer receive 2 cards; 
1. after that one of you decide what do you want? Get one more card or stop receiving cards (depends on who started the game first);
1. also the computer must make the same decision;
1. if one of you receive 21 points or 2 aces, game is over and win player with 21 points or 2 aces;
1. if one of players receive more than 21 points game is over, but at the end of round 
(example: you receive first cards and after that receive third card and has more than 21 points, 
so in this way computer should also make decision stop receiving the third card or get one more 
because you received first cards, you started the game first);
1. if both of you have more than 21 points game is over and win player with fewer points;
1. after game make possible to continue and start new one 
(example: you or computer won the game and system ask you “Do you want to start new game? Yes\No”, 
you print “Yes” and new game is starting);
1. if you decide to completely stop the game (print “No”), you must view games score (example: you won 3 times, computer won 2 times).

We could use:
* struct
* enum
* arrays
* loops
* switch/if/else
* read/write from/to console
