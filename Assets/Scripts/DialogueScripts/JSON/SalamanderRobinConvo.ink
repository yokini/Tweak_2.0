EXTERNAL Name(charName)

{Name("Robin")}
Uh… hi?
{Name("Salamander")}
Ugh greetings oh skeptical one. You may ask me some questions, so choose wisely.
-> questions

=== questions ===
What would you like to know?
* [Is there really a Monster inhabiting this creak?]-> C1
* [Can you tell me more about this place?] -> C2
* [What are you exactly?]-> C3
* [No more questions.] Alright smartass. Since I don’t really wanna see you around, I'll give you a chance to make your way out.
Here's a minigame. Use the 1, 2, 3 and 4 keys to destroy the spiders on time. Aim at 1400 points. Each miss will cost you 20 points. Good Luck!-> END

=== C1 ===
 Who are you calling a Monster? Huba is a creature who is bound to this place, and maintains it.

        + [Pff Urban Legends. What are they like?] -> C1_1
	            
        + [Oh really. What do they look like then?] -> C1_2
	        

=== C1_1 ===
Nonsense. Huba happens to be a foodie with a particular sweet tooth. If I were them, I’d consider eating you too.
+[Ask another question]-> questions


=== C1_2 ===
You’ll eventually find that out, don’t you have better questions?.
+[Ask another question]-> questions


=== C2 ===
In all honesty, it’s a lovely but cursed place. Sucks to be you right now.

	        + [Are we in danger?] -> C2_1
			
	        + [What happens around here?] -> C2_2
           

=== C2_1 ===
One would be wise to leave, yes. But I am afraid that it is too late now.
+[Ask another question]-> questions

=== C2_2 ===
We play monopoly on Friday nights. You could be joining soon enough.
+[Ask another question]-> questions

=== C3 ===
Not to be confused with a lizard! Pinkies are overrated.
+[Ask another question]-> questions

	