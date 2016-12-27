coderetreat-templates
=====================
This project contains various sample templates to use during a code retreat.
Each subfolder is dedicated to a particular language and contains a very basic starter test file.
The starter test contains a simple failing test.  Build/run your test, see it fail, then change the
assertion to make it pass once before beginning your code retreat session.  This will get you started
with a solid foundation on which to build your implementation.

I recommend cloning this repo and attempting to build/run the templates a day or two before the code 
retreat so you don't have to waste any time fiddling around at the start of your pairing session.

What is a code retreat?
----------------------
A coderetreat is a super-awesome day to practice your craft by pairing with other developers!
For more information, see the [main homepage](http://coderetreat.org/).

What dependencies are there?
----------------------------
For javascript and coffeescript I used [nodejs](http://nodejs.org/) version 0.10.12.
Be sure to run "npm install" in the javascript or coffeescript folder prior to running your test.
I also used [mocha](http://mochajs.org/) as the test harness.  You need to install this
as a global npm module using the command "npm install -g mocha".  To run the tests simply issue the command "mocha" from the javascript or coffeescript folders.

For csharp I used [Xamarin Studio](http://xamarin.com/) version 4.0.9 (build 12).  The .sln files are 
supposed to be compatible with Microsoft Visual Studio.  I can't say that I've tried myself.  :)

For elixr I used [Elixir](http://elixir-lang.org/) version 0.9.3.  Run the test by issuing the command "elixir game.exs".  
