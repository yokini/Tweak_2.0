EXTERNAL Name(charName)

{Name("Skyler")}
H-Hello?
{Name("Salamander")}
Hell-oh Sweet Child, this is unfortunate. Well, you may ask me some questions, so choose wisely.

-> questions

=== questions ===
What would you like to know?
* [Does the Monster exist?]-> C1
* [W-why Unfortunate?] -> C2
* [Who are you?]-> C3
* [No more questions, thank you.] Daww, I'd hate to see you end up like me. I'll give you a chance to make your way out.
Here's a minigame. Use the mouse to aim at the evil clouds and click to hit them with the boomerang. Try to avoid them (WASD keys). Resist until the time is over. Good Luck!
-> END

=== C1 ===
 I wouldn’t call them a Monster Darling. Huba is very much misunderstood.

        + [How so?] -> C1_1
	            
        + [Can we help them?] -> C1_2
	        

=== C1_1 ===
Huba is feared by most. And I understand why. But they are just lonely and want to have friends.
+[Ask another question]-> questions


=== C1_2 ===
Well, Huba does hate the deathening silence at night, and it often makes it hard for them to fall asleep.
+[Ask another question]-> questions


=== C2 ===
Most who enter the creek don’t make it out.
	        + [Is there a way out?] -> C2_1
			
	        + [What happens to them?] -> C2_2
           

=== C2_1 ===
Only if you are able to offer him what he seeks.
+[Ask another question]-> questions

=== C2_2 ===
The answer to your question is right before your eyes.
+[Ask another question]-> questions

=== C3 ===
Just another old, lost soul, who’s made the mistake of venturing into this place as a curious mortal being. 

+[Ask another question]-> questions

	