# Sub Explorer
Sub Explorer is an open world 3D submarine simulator. Explore the depths of the deep ocean, from the cockpit or from a view of the submarine!

## Specification
I wasn't able to add enemies or different gamemodes as basic movement scripts took a lot more time than I had anticipated. I thought I would be able to use the ThirdPersonController script as a base, but the reality was that it was so complicated and had a bunch of mixed in animation features that sifting through it would be harder than just writing a new one. And on top of that I had to work out Quaternion related things (with the help from some awesome people) to stabilize the submarine after it hit obstacles.

Because of this, I put a lot of thought and effort into my user experience (i.e. I added a first person cockpit view and a third person view, added some fog, custom particle effects, etc). I have a much more realistic understanding on the process of game design for the future, and I think that for the time I had, my original proposal was a bit ambitious.

## Credits and contributors
Some online stack exchange like websites such as StackOverflow and a couple unity forums were referenced, but most of the contribution was from specific people like DukeLaze. 

## Controls
Move with W A S D, ascend with Space, descend with Shift, toggle between cockpit and 3rd person view with mouse left click (defaults to third person view).