EXTERNAL Name(charName)
//EXTERNAL Icon(charName)
//EXTERNAL CharAnimation(charName, animationName)

{Name("River")}
//{Icon("Monster")}
//{CharAnimation("Monster","MonsterIdle")}
Ooooh hello!
{Name("Salamander")}
//{CharAnimation("Monster","MonsterTalking")}
Oh another one. Much younger though. Greetings. You may ask me some questions, so choose wisely.
-> questions

=== questions ===
What would you like to know?
* [What do you mean by “another one”?]-> C2
* [What can you tell me about the creature who inhabits the creak?] -> C1
* [Who are you?]-> C3
* [No more questions] Alright. Since you're so young, I'll give you a chance to make your way out. Follow me.-> END

=== C1 ===
So you do know about Huba Hub- I mean, the Great Huba.
        + [What are they like to do?] -> C1_1
	            
        + [How are they dangerous?] -> C1_2
	        

=== C1_1 ===
Huba likes to train their brain. They are out of games these days and are kinda getting on our nerves.
+[Ask another question]-> questions


=== C1_2 ===
It really depends on your definition of dangerous.
+[Ask another question]-> questions


=== C2 ===
Well there was this funny boy who came around some time ago. Albeit out of crippling fear, he was wise enough to leave rather quickly.
	        + [Is this place dangerous?] -> C2_1
			
	        + [That lying coward... Oly never met any of you?] -> C2_2
           

=== C2_1 ===
Curiosity did kill the Cat.
+[Ask another question]-> questions

=== C2_2 ===
Nope and good riddance.
+[Ask another question]-> questions

=== C3 ===
I happen to be a Salamander who speaks, genius.
+[Ask another question]-> questions

	
	


	
	
	