Broadsign - Technical coding test

Written by: Nicolas Vicenzo - n.vicenzo@gmail.com
From Montreal, Quebec, Canada

Hello, My name is Nicolas and here is my technical test code for my 
application for Broadsign. In this read-me will provide a detailed
description of my code.

Code used: I used C# with NUnit and Selenium automated testing on Chrome
This was written in Visual Studio 2019

Code style: I used a simple version of "Page object model" for my testing. I chose this
style of testing since is the style I am most familiar with. I woked on this style for
a while. I only know it from a simple aspect and I can always improve on this style.

My approach was to use the page object model to add a layer of abstraction to simplify 
the testing process and to make understandable. 
I based my testing on verifying if certain information displayed in the screen
and that pages were loaded when elements appeared and also if I can 
input on certain elements on the page. I am aware that some of the waits used on the
test were implicit waits where the system was frozen for a few seconds. 
I used this method since it was a simple way for pages to load since other methods I 
tried could not work. This is the only solution I could find for the time being
and I am open to improving it.

How to run:
The packages are already installed in the project. There should be a small circle on line
30 of the file named 'TestClass.cs'. just right click on it and then click on 'run' 
and the test should run. i can confrom that this test is running on my local system.

I have structured the test as follows:

-Pre conditions
--Log into site with username and password
--Click on 'Sales' tab
--Click on 'Digital Avials' section
--Select 3 avails
--Add avails to cart
--Start new campaign

-Main test
--Fill out all information on 'New Campaign' window
--Click save button
--Verify start + end dates on the segements pages