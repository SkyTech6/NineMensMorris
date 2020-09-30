# NineMensMorris
This is a testing projec to see if I create an Artifical Neural Network that plays Nine Men's Morris. The expectation is that this ML Agent would be best created with
Adversarial self-play. 

This project relies on Unity 2020.1, Tensorflow, and Unity's ML Agents. 

# Nine Men's Morris Rules
## Phase 1 - Piece Placement
The game begins with an empty board. The players determine who plays first, then take turns placing their men one per play on empty points. If a player is able to place three of their pieces on contiguous points in a straight line, vertically or horizontally, they have formed a mill and may remove one of their opponent's pieces from the board and the game, with the caveat that a piece in an opponent's mill can only be removed if no other pieces are available. After all men have been placed, phase two begins.

## Phase 2 - Piece Movement
Players continue to alternate moves, this time moving a man to an adjacent point. A piece may not "jump" another piece. Players continue to try to form mills and remove their opponent's pieces as in phase one. A player can "break" a mill by moving one of his pieces out of an existing mill, then moving it back to form the same mill a second time (or any number of times), each time removing one of his opponent's men. The act of removing an opponent's man is sometimes called "pounding" the opponent. When one player has been reduced to three men, phase three begins.

## Phase 3 - "Flying"
When a player is reduced to three pieces, there is no longer a limitation on that player of moving to only adjacent points: The player's men may "fly" (or "hop", or "jump") from any point to any vacant point.

NOTE: Some rules sources say this is the way the game is played, some treat it as a variation, and some do not mention it at all. A 19th-century games manual calls this the "truly rustic mode of playing the game". Flying was introduced to compensate when the weaker side is one man away from losing the game. As such, I may not implement flying as part of the ruleset as I'm attempting to emulate the play during it's peak in medieval England. 

 
